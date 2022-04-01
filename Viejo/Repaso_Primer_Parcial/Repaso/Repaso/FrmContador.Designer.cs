
namespace Repaso
{
    partial class FrmContador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblGente = new System.Windows.Forms.Label();
            this.miControl1 = new MisControles.MiControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEmpleados.Location = new System.Drawing.Point(419, 21);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.Size = new System.Drawing.Size(156, 38);
            this.nudEmpleados.TabIndex = 0;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.nudEmpleados_ValueChanged);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGente.Location = new System.Drawing.Point(419, 76);
            this.nudGente.Name = "nudGente";
            this.nudGente.Size = new System.Drawing.Size(156, 38);
            this.nudGente.TabIndex = 1;
            this.nudGente.ValueChanged += new System.EventHandler(this.nudGente_ValueChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(149, 31);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Empleados";
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(419, 172);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(156, 40);
            this.btnInforme.TabIndex = 3;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_OnClick);
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.Location = new System.Drawing.Point(9, 78);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(88, 31);
            this.lblGente.TabIndex = 4;
            this.lblGente.Text = "Gente";
            // 
            // miControl1
            // 
            this.miControl1.Location = new System.Drawing.Point(15, 122);
            this.miControl1.Name = "miControl1";
            this.miControl1.Size = new System.Drawing.Size(296, 99);
            this.miControl1.TabIndex = 5;
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(616, 233);
            this.Controls.Add(this.miControl1);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.nudEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Mauricio Cerizza";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.NumericUpDown nudGente;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblGente;
        private MisControles.MiControl miControl1;
    }
}

