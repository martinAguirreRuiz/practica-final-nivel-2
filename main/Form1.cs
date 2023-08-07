using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Disco> listaDiscos;

        //Funciones que no son eventos:

        public void cargarInfo()
        {
            try
            {
                DiscoNegocio negocio = new DiscoNegocio();
                listaDiscos = negocio.listarDiscos();
                dgvDiscos.DataSource = listaDiscos;
                cargarImagen(listaDiscos[0].UrlImagen);
                ocultarColumnas();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos, por favor intente de nuevo más tarde");
            }
            
        }

        public void cargarImagen(string urlImagen)
        {
            try
            {
                pbDiscos.Load(urlImagen);
            }
            catch (Exception)
            {
                pbDiscos.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }

        }

        public void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
        }

        //Acá empiezan los eventos:

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarInfo();

            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Fecha de Lanzamiento");
            cboCampo.Items.Add("Cantidad de Canciones");

            nudFiltro.Visible = false;
            dtpFiltro.Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado;
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            cargarInfo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            Form2 formModificar = new Form2(seleccionado);
            formModificar.ShowDialog();

            cargarInfo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Está seguro de que quiere eliminar este disco? No se podrá revertir", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (resultado == DialogResult.Yes)
            {
                negocio.eliminarDisco(seleccionado);
            }

            cargarInfo();
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {

            List<Disco> listaFiltrada;

            listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedValueChanged(object sender, EventArgs e)
        {
            cboCriterio.Items.Clear();

            switch (cboCampo.SelectedIndex)
            {
                case 0:

                    cboCriterio.Items.Add("Empieza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    nudFiltro.Visible = false;
                    dtpFiltro.Visible = false;
                    txtFiltro.Visible = true;


                    break;

                case 1:

                    cboCriterio.Items.Add("Antes de");
                    cboCriterio.Items.Add("Después de");
                    cboCriterio.Items.Add("El día");
                    dtpFiltro.Visible = true;
                    txtFiltro.Visible = false;
                    nudFiltro.Visible = false;

                    break;

 
                default:

                    cboCriterio.Items.Add("Más de");
                    cboCriterio.Items.Add("Menos de");
                    cboCriterio.Items.Add("Exactamente");
                    dtpFiltro.Visible = false;
                    nudFiltro.Visible = true;
                    txtFiltro.Visible = false;
                    

                    break;
            }
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            DiscoNegocio negocio = new DiscoNegocio();
            List<Disco> listaFiltradaPro;
            try
            {
                if (cboCampo.Text == "Título")
                {
                    listaFiltradaPro = negocio.filtrar(cboCampo.Text, cboCriterio.Text, txtFiltro.Text);
                }
                else if (cboCampo.Text == "Cantidad de Canciones")
                {
                    listaFiltradaPro = negocio.filtrar(cboCampo.Text, cboCriterio.Text, nudFiltro.Value.ToString());
                    
                }
                else
                {
                    listaFiltradaPro = negocio.filtrar(cboCampo.Text, cboCriterio.Text, dtpFiltro.Value.ToString());
                }
                dgvDiscos.DataSource = null;
                dgvDiscos.DataSource = listaFiltradaPro;
                ocultarColumnas();

                //if ((dgvDiscos.DataSource = listaFiltradaPro) == null)
                //{
                //    MessageBox.Show("No se encontraron coincidencias");
                //    cargarInfo();
                //}

            }
            catch (Exception ex)
            {

                throw ex;
                //MessageBox.Show("Ocurrió un error al cargar los datos, por favor intente de nuevo más tarde");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboCampo.Items.Clear();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Fecha de Lanzamiento");
            cboCampo.Items.Add("Cantidad de Canciones");
            cboCriterio.Items.Clear();
            txtFiltro.Text = "";
            nudFiltro.Visible = false;
            dtpFiltro.Visible = false;
            txtFiltro.Visible = true;

            dgvDiscos.DataSource = null;
            cargarInfo();
           
        }

    }
}