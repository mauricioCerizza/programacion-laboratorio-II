using System;
using System.Windows.Forms;

namespace Repaso
{
    public partial class FrmContador : Form
    {
        private Bar bar;
        private int cantidadEmpleados;
        private int cantidadGente;
        private int limiteGente;

        public FrmContador()
        {
            InitializeComponent();
            this.bar = Bar.GetBar();
            this.cantidadEmpleados = 0;
            this.cantidadGente = 0;
            this.nudEmpleados.ReadOnly = true;
            this.nudGente.ReadOnly = true;
            this.nudGente.Maximum = 0;
            this.limiteGente = 10;
        }

        private void btnInforme_OnClick(object sender, EventArgs e)
        {
            FrmInforme frmInforme = new FrmInforme(this.bar);
            frmInforme.StartPosition = FormStartPosition.CenterParent;
            frmInforme.ShowDialog();
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (this.nudEmpleados.Value > this.cantidadEmpleados)
            {
                if (this.bar + new Empleado())
                {
                    this.cantidadEmpleados++;
                }
            }
            else
            {
                int contadorEmpleados = this.bar.Empleados.Count;
                if (this.bar.Empleados.Count > 0)
                {
                    this.bar.Empleados.RemoveAt(contadorEmpleados - 1);
                    this.cantidadEmpleados--;
                }
            }

            this.nudGente.Maximum = this.cantidadEmpleados * 10;
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            if (this.nudGente.Value > this.cantidadGente)
            {
                if (this.bar + new Gente())
                {
                    this.cantidadGente++;
                }
            }
            else
            {
                int contadorGente = this.bar.Gente.Count;
                if (contadorGente > 0)
                {
                    this.bar.Gente.RemoveAt(0);
                    this.cantidadGente--;
                }
            }
        }
    }
}
