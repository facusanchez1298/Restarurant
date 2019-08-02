namespace prueba
{
    partial class Mozos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.checkBoxMañana = new System.Windows.Forms.CheckBox();
            this.checkBoxTarde = new System.Windows.Forms.CheckBox();
            this.checkBoxNoche = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mozo:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(61, 7);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(203, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(252, 168);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBorrar.BackColor = System.Drawing.Color.Azure;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBorrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBorrar.Location = new System.Drawing.Point(12, 259);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(126, 30);
            this.buttonBorrar.TabIndex = 6;
            this.buttonBorrar.Text = "Editar";
            this.buttonBorrar.UseCompatibleTextRendering = true;
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click_1);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.Color.Azure;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAgregar.Location = new System.Drawing.Point(138, 259);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(126, 30);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Salir";
            this.buttonAgregar.UseCompatibleTextRendering = true;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.Color.Azure;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditar.Location = new System.Drawing.Point(12, 229);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(126, 30);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Agregar";
            this.buttonEditar.UseCompatibleTextRendering = true;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.BackColor = System.Drawing.Color.Azure;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.buttonAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAceptar.Location = new System.Drawing.Point(137, 229);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(127, 30);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Borrar";
            this.buttonAceptar.UseCompatibleTextRendering = true;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // checkBoxMañana
            // 
            this.checkBoxMañana.AutoSize = true;
            this.checkBoxMañana.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxMañana.Location = new System.Drawing.Point(60, 33);
            this.checkBoxMañana.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxMañana.Name = "checkBoxMañana";
            this.checkBoxMañana.Size = new System.Drawing.Size(77, 19);
            this.checkBoxMañana.TabIndex = 2;
            this.checkBoxMañana.Text = "Mañana";
            this.checkBoxMañana.UseVisualStyleBackColor = true;
            this.checkBoxMañana.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBoxTarde
            // 
            this.checkBoxTarde.AutoSize = true;
            this.checkBoxTarde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxTarde.Location = new System.Drawing.Point(137, 33);
            this.checkBoxTarde.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTarde.Name = "checkBoxTarde";
            this.checkBoxTarde.Size = new System.Drawing.Size(64, 19);
            this.checkBoxTarde.TabIndex = 3;
            this.checkBoxTarde.Text = "Tarde";
            this.checkBoxTarde.UseVisualStyleBackColor = true;
            this.checkBoxTarde.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBoxNoche
            // 
            this.checkBoxNoche.AutoSize = true;
            this.checkBoxNoche.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.checkBoxNoche.Location = new System.Drawing.Point(203, 33);
            this.checkBoxNoche.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxNoche.Name = "checkBoxNoche";
            this.checkBoxNoche.Size = new System.Drawing.Size(68, 19);
            this.checkBoxNoche.TabIndex = 4;
            this.checkBoxNoche.Text = "Noche";
            this.checkBoxNoche.UseVisualStyleBackColor = true;
            this.checkBoxNoche.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Turno:";
            // 
            // Mozos
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(274, 298);
            this.Controls.Add(this.checkBoxNoche);
            this.Controls.Add(this.checkBoxTarde);
            this.Controls.Add(this.checkBoxMañana);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mozos";
            this.Text = "Mozos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.CheckBox checkBoxMañana;
        private System.Windows.Forms.CheckBox checkBoxTarde;
        private System.Windows.Forms.CheckBox checkBoxNoche;
        private System.Windows.Forms.Label label2;
    }
}