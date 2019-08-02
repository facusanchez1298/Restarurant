namespace prueba
{
    partial class Pedido
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxVegetariano = new System.Windows.Forms.CheckBox();
            this.checkBoxSinTACC = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(250, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(65, 11);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(195, 20);
            this.textBoxFiltrar.TabIndex = 1;
            this.textBoxFiltrar.TextChanged += new System.EventHandler(this.textBoxFiltrar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar:";
            // 
            // checkBoxVegetariano
            // 
            this.checkBoxVegetariano.AutoSize = true;
            this.checkBoxVegetariano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxVegetariano.Location = new System.Drawing.Point(10, 37);
            this.checkBoxVegetariano.Name = "checkBoxVegetariano";
            this.checkBoxVegetariano.Size = new System.Drawing.Size(109, 19);
            this.checkBoxVegetariano.TabIndex = 2;
            this.checkBoxVegetariano.Text = " Vegetariano";
            this.checkBoxVegetariano.UseVisualStyleBackColor = true;
            this.checkBoxVegetariano.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxSinTACC
            // 
            this.checkBoxSinTACC.AutoSize = true;
            this.checkBoxSinTACC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxSinTACC.Location = new System.Drawing.Point(163, 37);
            this.checkBoxSinTACC.Name = "checkBoxSinTACC";
            this.checkBoxSinTACC.Size = new System.Drawing.Size(99, 19);
            this.checkBoxSinTACC.TabIndex = 3;
            this.checkBoxSinTACC.Text = "Sin T.A.C.C";
            this.checkBoxSinTACC.UseVisualStyleBackColor = true;
            this.checkBoxSinTACC.CheckedChanged += new System.EventHandler(this.checkBoxSinTACC_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(262, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(13, 298);
            this.button3.TabIndex = 16;
            this.button3.Text = "<";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pedido
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(274, 298);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxSinTACC);
            this.Controls.Add(this.checkBoxVegetariano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxVegetariano;
        private System.Windows.Forms.CheckBox checkBoxSinTACC;
        private System.Windows.Forms.Button button3;
    }
}