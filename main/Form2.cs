using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace main
{
    public partial class Form2 : Form
    {
        private Disco aux = null;
        private OpenFileDialog archivo = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Disco seleccionado)
        {
            InitializeComponent();
            aux = seleccionado;
        }

        //Funciones:
        public void cargarImagen(string urlImagen)
        {
            try
            {
                pbDiscoNuevo.Load(urlImagen);
            }
            catch (Exception)
            {
                pbDiscoNuevo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }

        }

        public void cargarInfoDiscos(Disco aux) 
        {
            aux.Titulo = txtTitulo.Text;
            aux.FechaLanzamiento = dtpFechaLanzamiento.Value;
            aux.CantidadCanciones = (int)nudCantidadCanciones.Value;
            aux.UrlImagen = txtImagen.Text;
            aux.Estilo = (Estilo)cboEstilo.SelectedItem;
            aux.TipoEdicion = (TipoEdicion)cboEdicion.SelectedItem;
        }

        //Eventos:
        private void Form2_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();
            try
            {
                cboEstilo.DataSource = estiloNegocio.listarEstilo();
                //cboEstilo.ValueMember = "Id";
                //cboEstilo.DisplayMember = "Descripcion";
                cboEdicion.DataSource = tipoEdicionNegocio.listarEdicion();
                //cboEdicion.ValueMember = "Id";
                //cboEdicion.DisplayMember = "Descripcion";
                
                if (aux != null)
                {  
                    txtTitulo.Text = aux.Titulo;
                    txtImagen.Text = aux.UrlImagen;
                    dtpFechaLanzamiento.Value = aux.FechaLanzamiento;
                    nudCantidadCanciones.Value = aux.CantidadCanciones;
                    cboEstilo.Text = aux.Estilo.Descripcion;
                    cboEdicion.Text = aux.TipoEdicion.Descripcion;
                    //cboEstilo.SelectedValue = aux.Estilo.Id;
                    //cboEdicion.SelectedValue = aux.TipoEdicion.Id;
                }
                cargarImagen(txtImagen.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                if (aux == null)
                {
                    aux = new Disco();

                    cargarInfoDiscos(aux);

                    negocio.agregarDisco(aux);

                    MessageBox.Show("Disco agregado exitosamente!");
                }
                else
                {
                    cargarInfoDiscos(aux);

                    negocio.modificarDisco(aux);

                    MessageBox.Show("Disco modificado exitosamente!");
                }

                if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }
            }
            catch (Exception)
            {
                throw;
            }


            this.Close();
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
            }
        }
    }
}
