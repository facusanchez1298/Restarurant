namespace prueba
{
    partial class EditarMozo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOcupar = new System.Windows.Forms.Button();
            this.checkBoxNoche = new System.Windows.Forms.CheckBox();
            this.checkBoxTarde = new System.Windows.Forms.CheckBox();
            this.checkBoxMañana = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(15, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(237, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(174, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.salir_Click);
            // 
            // buttonOcupar
            // 
            this.buttonOcupar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOcupar.BackColor = System.Drawing.Color.Azure;
            this.buttonOcupar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOcupar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonOcupar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonOcupar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOcupar.Location = new System.Drawing.Point(84, 101);
            this.buttonOcupar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOcupar.Name = "buttonOcupar";
            this.buttonOcupar.Size = new System.Drawing.Size(78, 23);
            this.buttonOcupar.TabIndex = 5;
            this.buttonOcupar.Text = "Agregar";
            this.buttonOcupar.UseVisualStyleBackColor = false;
            this.buttonOcupar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // checkBoxNoche
            // 
            this.checkBoxNoche.AutoSize = true;
            this.checkBoxNoche.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxNoche.Location = new System.Drawing.Point(193, 72);
            this.checkBoxNoche.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxNoche.Name = "checkBoxNoche";
            this.checkBoxNoche.Size = new System.Drawing.Size(68, 19);
            this.checkBoxNoche.TabIndex = 4;
            this.checkBoxNoche.Text = "Noche";
            this.checkBoxNoche.UseVisualStyleBackColor = true;
            // 
            // checkBoxTarde
            // 
            this.checkBoxTarde.AutoSize = true;
            this.checkBoxTarde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxTarde.Location = new System.Drawing.Point(111, 72);
            this.checkBoxTarde.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTarde.Name = "checkBoxTarde";
            this.checkBoxTarde.Size = new System.Drawing.Size(64, 19);
            this.checkBoxTarde.TabIndex = 3;
            this.checkBoxTarde.Text = "Tarde";
            this.checkBoxTarde.UseVisualStyleBackColor = true;
            // 
            // checkBoxMañana
            // 
            this.checkBoxMañana.AutoSize = true;
            this.checkBoxMañana.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxMañana.Location = new System.Drawing.Point(16, 72);
            this.checkBoxMañana.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxMañana.Name = "checkBoxMañana";
            this.checkBoxMañana.Size = new System.Drawing.Size(77, 19);
            this.checkBoxMañana.TabIndex = 2;
            this.checkBoxMañana.Text = "Mañana";
            this.checkBoxMañana.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Turno:";
            // 
            // EditarMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(270, 133);
            this.Controls.Add(this.checkBoxNoche);
            this.Controls.Add(this.checkBoxTarde);
            this.Controls.Add(this.checkBoxMañana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOcupar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarMozo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Mozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOcupar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.CheckBox checkBoxNoche;
        public System.Windows.Forms.CheckBox checkBoxTarde;
        public System.Windows.Forms.CheckBox checkBoxMañana;
    }
}