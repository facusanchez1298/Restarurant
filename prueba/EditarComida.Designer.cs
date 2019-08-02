namespace prueba
{
    partial class EditarComida
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
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxVegetariano = new System.Windows.Forms.CheckBox();
            this.checkBoxSinTACC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(84, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(168, 20);
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
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cancelar_Click);
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
            this.buttonOcupar.Text = "Aceptar";
            this.buttonOcupar.UseVisualStyleBackColor = false;
            this.buttonOcupar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(84, 47);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(168, 20);
            this.textBoxPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Precio:";
            // 
            // checkBoxVegetariano
            // 
            this.checkBoxVegetariano.AutoSize = true;
            this.checkBoxVegetariano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxVegetariano.Location = new System.Drawing.Point(18, 73);
            this.checkBoxVegetariano.Name = "checkBoxVegetariano";
            this.checkBoxVegetariano.Size = new System.Drawing.Size(109, 19);
            this.checkBoxVegetariano.TabIndex = 3;
            this.checkBoxVegetariano.Text = " Vegetariano";
            this.checkBoxVegetariano.UseVisualStyleBackColor = true;
            // 
            // checkBoxSinTACC
            // 
            this.checkBoxSinTACC.AutoSize = true;
            this.checkBoxSinTACC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxSinTACC.Location = new System.Drawing.Point(153, 73);
            this.checkBoxSinTACC.Name = "checkBoxSinTACC";
            this.checkBoxSinTACC.Size = new System.Drawing.Size(99, 19);
            this.checkBoxSinTACC.TabIndex = 4;
            this.checkBoxSinTACC.Text = "Sin T.A.C.C";
            this.checkBoxSinTACC.UseVisualStyleBackColor = true;
            // 
            // EditarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(270, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOcupar);
            this.Controls.Add(this.checkBoxSinTACC);
            this.Controls.Add(this.checkBoxVegetariano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarComida";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Comida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOcupar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.TextBox textBoxPrecio;
        public System.Windows.Forms.CheckBox checkBoxVegetariano;
        public System.Windows.Forms.CheckBox checkBoxSinTACC;
    }
}