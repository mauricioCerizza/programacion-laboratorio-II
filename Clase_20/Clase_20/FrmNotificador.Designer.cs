namespace Clase_20
{
    partial class FrmNotificador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewsTech = new System.Windows.Forms.Button();
            this.btnNewsFinanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewsTech
            // 
            this.btnNewsTech.Location = new System.Drawing.Point(12, 12);
            this.btnNewsTech.Name = "btnNewsTech";
            this.btnNewsTech.Size = new System.Drawing.Size(168, 77);
            this.btnNewsTech.TabIndex = 0;
            this.btnNewsTech.Text = "Enviar Newsletter Tecnología";
            this.btnNewsTech.UseVisualStyleBackColor = true;
            // 
            // btnNewsFinanzas
            // 
            this.btnNewsFinanzas.Location = new System.Drawing.Point(222, 12);
            this.btnNewsFinanzas.Name = "btnNewsFinanzas";
            this.btnNewsFinanzas.Size = new System.Drawing.Size(168, 77);
            this.btnNewsFinanzas.TabIndex = 1;
            this.btnNewsFinanzas.Text = "Enviar Newsletter Finanzas";
            this.btnNewsFinanzas.UseVisualStyleBackColor = true;
            // 
            // FrmNotificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 116);
            this.Controls.Add(this.btnNewsFinanzas);
            this.Controls.Add(this.btnNewsTech);
            this.Name = "FrmNotificador";
            this.Text = "Notificador";
            this.Load += new System.EventHandler(this.FrmNotificador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewsTech;
        private System.Windows.Forms.Button btnNewsFinanzas;
    }
}
