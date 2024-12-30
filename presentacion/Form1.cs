using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominios;
using Negocio;

namespace presentacion
{
    public partial class Form1 : Form
    {
        private List<Contacto> listaDeContactos;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Contacto contacto)
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ContactoData dataCont = new ContactoData();

            try
            {
                listaDeContactos = dataCont.listar();
                dataGridViewVerContactos.DataSource = listaDeContactos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewVerContactos.Columns["Id"].Visible = false;
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarContacto formAgregarCont = new FormAgregarContacto();
            formAgregarCont.ShowDialog();

            cargar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void textBoxBuscarContacto_TextChanged(object sender, EventArgs e)
        {
            List<Contacto> listaFiltrada;

            string filtro = textBoxBuscarContacto.Text;


            if (filtro.Length >= 2)
            {
                listaFiltrada = listaDeContactos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Telefono.ToUpper().Contains(filtro.ToUpper()) || x.Direccion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {

                listaFiltrada = listaDeContactos;

            }

            dataGridViewVerContactos.DataSource = null;
            dataGridViewVerContactos.DataSource = listaFiltrada;
            ocultarColumnas();
        }


        private void dataGridViewVerContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVerContactos.CurrentRow != null)
            {
                Contacto articuloSeleccionado = (Contacto)dataGridViewVerContactos.CurrentRow.DataBoundItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contacto seleccionado;

            if (dataGridViewVerContactos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un contacto para modificar");
                return;
            }

            seleccionado = (Contacto)dataGridViewVerContactos.CurrentRow.DataBoundItem;


            FormAgregarContacto modificarDisco = new FormAgregarContacto(seleccionado);
            modificarDisco.ShowDialog();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ContactoData data = new ContactoData();
            Contacto contactoSeleccionado;

            if (dataGridViewVerContactos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un contacto para eliminar");
                return;
            }

            try
            {

                DialogResult respuesta = MessageBox.Show("seguro que desea eliminar?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                //Verificar la respuesta del usuario:
                if (respuesta == DialogResult.Yes)
                {
                    //Seleccionar el disco a eliminar de la celda de la DGV
                    contactoSeleccionado = (Contacto)dataGridViewVerContactos.CurrentRow.DataBoundItem;

                    data.eliminar(contactoSeleccionado.Id);

                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
