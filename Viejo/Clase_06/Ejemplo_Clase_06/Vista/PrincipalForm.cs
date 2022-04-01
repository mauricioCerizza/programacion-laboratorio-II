using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Saludar_OnClick(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;

            if (ValidarNombre(nombre))
            {
                nombre = nombre.Trim();
                string mensaje = $"Hola {nombre}!";

                MensajeForm mensajeForm = new MensajeForm();
                mensajeForm.Mensaje = mensaje;

                mensajeForm.ShowDialog();
            }

            DialogResult result = MessageBox.Show("¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private bool ValidarNombre(string nombre)
        { 
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
