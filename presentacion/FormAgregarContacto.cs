using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominios;
using Negocio;
using System.Text.RegularExpressions;

namespace presentacion
{
    public partial class FormAgregarContacto : Form
    {

        private Contacto contactoN = null;
        private OpenFileDialog archivo = null;

        public FormAgregarContacto()
        {
            InitializeComponent();
        }
        public FormAgregarContacto(Contacto contacto)
        {
            InitializeComponent();
            this.contactoN = contacto;

        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBoxCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTopFormAddContact_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ContactoData data = new ContactoData();

            try
            {
                if (contactoN == null)
                    contactoN = new Contacto();

                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("debe tener Nombre");
                    return;
                }


                if (string.IsNullOrWhiteSpace(textBoxTelefono.Text))
                {
                    MessageBox.Show("debe tener Telefono");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxDireccion.Text))
                {
                    MessageBox.Show("debe tener Direccion");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("debe tener correo electronico");
                    return;
                }

                contactoN.Nombre = textBoxNombre.Text;
                contactoN.Telefono = textBoxTelefono.Text;
                contactoN.Direccion = textBoxDireccion.Text;
                contactoN.Email = textBoxEmail.Text;

                if (contactoN.Id != 0)
                {
                    data.modificar(contactoN);
                    MessageBox.Show("modificado exitosamente");
                }

                if (contactoN.Id == 0)
                {
                    data.AgregarContacto(contactoN);
                    MessageBox.Show("creado exitosamente");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregarContacto_Load(object sender, EventArgs e)
        {
            ContactoData contactoData = new ContactoData();

            try
            {
                if (contactoN != null)
                {
                    textBoxNombre.Text = contactoN.Nombre;
                    textBoxTelefono.Text = contactoN.Telefono;
                    textBoxEmail.Text = contactoN.Email;
                    textBoxDireccion.Text = contactoN.Direccion; // bloque para cuando viene un disco para modificat
                    //porque trae algo adentro porque es distinto de nulo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ContactoData data = new ContactoData();

            try
            {
                if (contactoN == null)
                    contactoN = new Contacto();

                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("debe tener nombre");
                    return;
                }


                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("debe tener Email");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxDireccion.Text))
                {
                    MessageBox.Show("Debe tener direccion");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxTelefono.Text))
                {
                    MessageBox.Show("Debe tener Telefono");
                    return;
                }

                contactoN.Nombre = textBoxNombre.Text;
                contactoN.Email = textBoxEmail.Text;
                contactoN.Direccion = textBoxDireccion.Text;
                contactoN.Telefono = textBoxTelefono.Text;

                if (contactoN.Id != 0)
                {
                    data.modificar(contactoN);
                    MessageBox.Show("modificado exitosamente");
                }

                if (contactoN.Id == 0)
                {
                    data.AgregarContacto(contactoN);
                    MessageBox.Show("creado exitosamente");
                }

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                MessageBox.Show("solo puede ingresar numeros");
                e.Handled = true;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un '@'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus(); // Regresa el foco al TextBox para que el usuario corrija el error
            }
        }
    }
}
