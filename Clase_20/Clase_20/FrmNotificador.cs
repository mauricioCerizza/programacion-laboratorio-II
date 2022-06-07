using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_20
{
    public partial class FrmNotificador : Form
    {
        private Newsletter newsletterTecnologia;
        private Newsletter newsletterFinanzas;

        public FrmNotificador()
        {
            InitializeComponent();
        }

        private void FrmNotificador_Load(object sender, EventArgs e)
        {
            // objeto.Evento += manejador (sin paréntesis)
            btnNewsTech.Click += btnNewsTech_OnClick;
            btnNewsFinanzas.Click += btnNewsFinanzas_OnClick;

            newsletterFinanzas = new Newsletter("Finanzas");
            newsletterTecnologia = new Newsletter("Tecnología");
            List<Suscriptor> suscriptores = TraerSuscriptores();

            foreach (Suscriptor suscriptor in suscriptores)
            {
                if (suscriptor.Id % 2 == 0)
                {
                    // objeto.Evento += manejador
                    newsletterFinanzas.NovedadEnviada += suscriptor.RecibirNovedad;
                    // NovedadEnviada es el evento del objeto newsletter (finanzas)
                    // RecibirNovedad es el manejador de dicho evento en un objeto de tipo Suscriptor.
                }
                else
                {
                    newsletterTecnologia.NovedadEnviada += suscriptor.RecibirNovedad;
                }
            }
        }

        public void btnNewsTech_OnClick(object sender, EventArgs e)
        {
            newsletterTecnologia.EnviarNovedades();
        }

        public void btnNewsFinanzas_OnClick(object sender, EventArgs e)
        {
            newsletterFinanzas.EnviarNovedades();
        }

        public List<Suscriptor> TraerSuscriptores()
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server=.;Database=CLASE_19_DB;Trusted_Connection=True;"))
            {
                string commandText = "SELECT ID, NOMBRE FROM USUARIOS";
                SqlCommand cmd = new SqlCommand(commandText, sqlConnection);
                
                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                List<Suscriptor> suscriptores = new List<Suscriptor>();

                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nombre = reader["NOMBRE"].ToString();

                    Suscriptor suscriptor = new Suscriptor(id, nombre);
                    suscriptores.Add(suscriptor);
                }

                return suscriptores;
            }
        }
    }
}
