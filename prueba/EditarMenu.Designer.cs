namespace prueba
{
    partial class EditarMenu
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
            this.buttonOcupar = new System.Windows.Forms.Button();
            this.checkBoxSinTACC = new System.Windows.Forms.CheckBox();
            this.checkBoxVegetariano = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOcupar
            // 
            this.buttonOcupar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOcupar.BackColor = System.Drawing.Color.Azure;
            this.buttonOcupar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOcupar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonOcupar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonOcupar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOcupar.Location = new System.Drawing.Point(139, 231);
            this.buttonOcupar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOcupar.Name = "buttonOcupar";
            this.buttonOcupar.Size = new System.Drawing.Size(126, 30);
            this.buttonOcupar.TabIndex = 19;
            this.buttonOcupar.Text = "Borrar";
            this.buttonOcupar.UseCompatibleTextRendering = true;
            this.buttonOcupar.UseVisualStyleBackColor = false;
            this.buttonOcupar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // checkBoxSinTACC
            // 
            this.checkBoxSinTACC.AutoSize = true;
            this.checkBoxSinTACC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxSinTACC.Location = new System.Drawing.Point(166, 36);
            this.checkBoxSinTACC.Name = "checkBoxSinTACC";
            this.checkBoxSinTACC.Size = new System.Drawing.Size(99, 19);
            this.checkBoxSinTACC.TabIndex = 17;
            this.checkBoxSinTACC.Text = "Sin T.A.C.C";
            this.checkBoxSinTACC.UseVisualStyleBackColor = true;
            this.checkBoxSinTACC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxVegetariano
            // 
            this.checkBoxVegetariano.AutoSize = true;
            this.checkBoxVegetariano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxVegetariano.Location = new System.Drawing.Point(13, 36);
            this.checkBoxVegetariano.Name = "checkBoxVegetariano";
            this.checkBoxVegetariano.Size = new System.Drawing.Size(109, 19);
            this.checkBoxVegetariano.TabIndex = 18;
            this.checkBoxVegetariano.Text = " Vegetariano";
            this.checkBoxVegetariano.UseVisualStyleBackColor = true;
            this.checkBoxVegetariano.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filtrar:";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(68, 10);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(197, 20);
            this.textBoxFiltrar.TabIndex = 15;
            this.textBoxFiltrar.TextChanged += new System.EventHandler(this.textBoxFiltrar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(252, 167);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(139, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salir";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.salir_click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(13, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Editar";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(13, 231);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "Agregar";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.AgregarComida_Click);
            // 
            // EditarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(274, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonOcupar);
            this.Controls.Add(this.checkBoxSinTACC);
            this.Controls.Add(this.checkBoxVegetariano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarMenu";
            this.Text = "EditarMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOcupar;
        private System.Windows.Forms.CheckBox checkBoxSinTACC;
        private System.Windows.Forms.CheckBox checkBoxVegetariano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}