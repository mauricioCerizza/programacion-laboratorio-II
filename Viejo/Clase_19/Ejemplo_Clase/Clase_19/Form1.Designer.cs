
namespace Clase_19
{
    partial class Form1
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
            this.richTextBoxGuardar = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.richTextBoxLeer = new System.Windows.Forms.RichTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonSerializar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonXml = new System.Windows.Forms.RadioButton();
            this.radioButtonBinario = new System.Windows.Forms.RadioButton();
            this.richTextBoxPersona = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxGuardar
            // 
            this.richTextBoxGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGuardar.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxGuardar.Name = "richTextBoxGuardar";
            this.richTextBoxGuardar.Size = new System.Drawing.Size(553, 145);
            this.richTextBoxGuardar.TabIndex = 0;
            this.richTextBoxGuardar.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(490, 163);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(490, 343);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(75, 23);
            this.buttonLeer.TabIndex = 3;
            this.buttonLeer.Text = "LEER";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // richTextBoxLeer
            // 
            this.richTextBoxLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLeer.Location = new System.Drawing.Point(12, 192);
            this.richTextBoxLeer.Name = "richTextBoxLeer";
            this.richTextBoxLeer.Size = new System.Drawing.Size(553, 145);
            this.richTextBoxLeer.TabIndex = 2;
            this.richTextBoxLeer.Text = "";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(635, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(157, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "APELLIDO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(836, 27);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(157, 20);
            this.textBoxApellido.TabIndex = 6;
            // 
            // buttonSerializar
            // 
            this.buttonSerializar.Location = new System.Drawing.Point(894, 66);
            this.buttonSerializar.Name = "buttonSerializar";
            this.buttonSerializar.Size = new System.Drawing.Size(86, 23);
            this.buttonSerializar.TabIndex = 8;
            this.buttonSerializar.Text = "SERIALIZAR";
            this.buttonSerializar.UseVisualStyleBackColor = true;
            this.buttonSerializar.Click += new System.EventHandler(this.buttonSerializar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBinario);
            this.groupBox1.Controls.Add(this.radioButtonXml);
            this.groupBox1.Location = new System.Drawing.Point(635, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // radioButtonXml
            // 
            this.radioButtonXml.AutoSize = true;
            this.radioButtonXml.Checked = true;
            this.radioButtonXml.Location = new System.Drawing.Point(20, 19);
            this.radioButtonXml.Name = "radioButtonXml";
            this.radioButtonXml.Size = new System.Drawing.Size(47, 17);
            this.radioButtonXml.TabIndex = 0;
            this.radioButtonXml.TabStop = true;
            this.radioButtonXml.Text = "XML";
            this.radioButtonXml.UseVisualStyleBackColor = true;
            // 
            // radioButtonBinario
            // 
            this.radioButtonBinario.AutoSize = true;
            this.radioButtonBinario.Location = new System.Drawing.Point(126, 19);
            this.radioButtonBinario.Name = "radioButtonBinario";
            this.radioButtonBinario.Size = new System.Drawing.Size(69, 17);
            this.radioButtonBinario.TabIndex = 1;
            this.radioButtonBinario.Text = "BINARIO";
            this.radioButtonBinario.UseVisualStyleBackColor = true;
            // 
            // richTextBoxPersona
            // 
            this.richTextBoxPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPersona.Location = new System.Drawing.Point(635, 150);
            this.richTextBoxPersona.Name = "richTextBoxPersona";
            this.richTextBoxPersona.Size = new System.Drawing.Size(358, 68);
            this.richTextBoxPersona.TabIndex = 10;
            this.richTextBoxPersona.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "DESERIALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxPersona);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSerializar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.richTextBoxLeer);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.richTextBoxGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxGuardar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLeer;
        private System.Windows.Forms.RichTextBox richTextBoxLeer;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonSerializar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBinario;
        private System.Windows.Forms.RadioButton radioButtonXml;
        private System.Windows.Forms.RichTextBox richTextBoxPersona;
        private System.Windows.Forms.Button button1;
    }
}

