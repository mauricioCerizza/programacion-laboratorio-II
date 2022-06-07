using System;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Suscriptor
    {
        private int id;
        private string nombre;

        public Suscriptor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id => id;

        //public string Nombre => nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        // btnNewsTech_OnClick
        public void RecibirNovedad(Newsletter newsletter, EventArgs eventArgs)
        {
            string contenido = string.Empty;
            if (eventArgs is NewsletterEventArgs newsletterEventArgs)
            {
                contenido = newsletterEventArgs.Contenido;
            }

            using (SqlConnection sqlConnection = new SqlConnection("Server=.;Database=CLASE_19_DB;Trusted_Connection=True;"))
            {
                string commandText = "INSERT INTO NOVEDADES (tema, contenido, id_usuario) VALUES(@tema, @contenido, @id_usuario)";
                SqlCommand cmd = new SqlCommand(commandText, sqlConnection);
                cmd.Parameters.AddWithValue("@tema", newsletter.Tema);
                cmd.Parameters.AddWithValue("@contenido", contenido);
                cmd.Parameters.AddWithValue("@id_usuario", this.id);

                sqlConnection.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
