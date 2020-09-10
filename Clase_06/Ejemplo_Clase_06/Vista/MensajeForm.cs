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
    public partial class MensajeForm : Form
    {
        public MensajeForm()
        {
            InitializeComponent();
            this.lblSaludo.Text = string.Empty;
        }

        public string Mensaje
        {
            get
            {
                return this.lblSaludo.Text;
            }
            set
            {
                this.lblSaludo.Text = value;
            }
        }
    }
}
