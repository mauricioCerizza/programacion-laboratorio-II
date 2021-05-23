using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.txt";
                Archivador archivador = new Archivador(ruta);
                string texto = richTextBoxGuardar.Text;
                archivador.Guardar(texto);
                MessageBox.Show("Guardado correctamente.", "EXITO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.txt";
                Archivador archivador = new Archivador(ruta);
                richTextBoxLeer.Text = archivador.Leer();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSerializar_Click(object sender, EventArgs e)
        {
            if (radioButtonXml.Checked)
            {
                SerializarXml();
            }
            else
            {
                SerializarBinario();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonXml.Checked)
            {
                DeserializarXml();
            }
            else
            {
                DeserializarBinario();
            }
        }

        private void SerializarBinario()
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.bin";
                SerializadorBinario<Persona> serializadorBinario = new SerializadorBinario<Persona>(ruta);
                Persona persona = new Persona(textBoxApellido.Text, textBoxNombre.Text);
                serializadorBinario.Guardar(persona);
                MessageBox.Show("Serializado correctamente.", "EXITO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeserializarBinario()
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.bin";
                SerializadorBinario<Persona> serializadorBinario = new SerializadorBinario<Persona>(ruta);
                Persona persona = serializadorBinario.Leer();
                richTextBoxPersona.Text = persona.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerializarXml()
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.xml";
                SerializadorXml<Persona> serializadorXml = new SerializadorXml<Persona>(ruta);
                Persona persona = new Persona(textBoxApellido.Text, textBoxNombre.Text);
                serializadorXml.Guardar(persona);
                MessageBox.Show("Serializado correctamente.", "EXITO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeserializarXml()
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Prueba.xml";
                SerializadorXml<Persona> serializadorXml = new SerializadorXml<Persona>(ruta);
                Persona persona = serializadorXml.Leer();
                richTextBoxPersona.Text = persona.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
