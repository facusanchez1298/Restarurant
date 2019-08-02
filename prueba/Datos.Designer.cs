namespace prueba
{
    partial class Datos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLLego = new System.Windows.Forms.Label();
            this.labelActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonOcupar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelNumero
            // 
            resources.ApplyResources(this.labelNumero, "labelNumero");
            this.labelNumero.BackColor = System.Drawing.SystemColors.Window;
            this.labelNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumero.Name = "labelNumero";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // labelPrecio
            // 
            this.labelPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.labelPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.labelPrecio, "labelPrecio");
            this.labelPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.labelPrecio.Name = "labelPrecio";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // labelLLego
            // 
            this.labelLLego.BackColor = System.Drawing.SystemColors.Window;
            this.labelLLego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLLego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.labelLLego, "labelLLego");
            this.labelLLego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.labelLLego.Name = "labelLLego";
            // 
            // labelActual
            // 
            this.labelActual.BackColor = System.Drawing.SystemColors.Window;
            this.labelActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.labelActual, "labelActual");
            this.labelActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.labelActual.Name = "labelActual";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAgregar
            // 
            resources.ApplyResources(this.buttonAgregar, "buttonAgregar");
            this.buttonAgregar.BackColor = System.Drawing.Color.Azure;
            this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.hacerPedido_Click);
            // 
            // buttonSalir
            // 
            resources.ApplyResources(this.buttonSalir, "buttonSalir");
            this.buttonSalir.BackColor = System.Drawing.Color.Azure;
            this.buttonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonOcupar
            // 
            resources.ApplyResources(this.buttonOcupar, "buttonOcupar");
            this.buttonOcupar.BackColor = System.Drawing.Color.Azure;
            this.buttonOcupar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonOcupar.Name = "buttonOcupar";
            this.buttonOcupar.UseVisualStyleBackColor = false;
            this.buttonOcupar.Click += new System.EventHandler(this.botonOcupar);
            // 
            // buttonAceptar
            // 
            resources.ApplyResources(this.buttonAceptar, "buttonAceptar");
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.TabStop = false;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonBorrar
            // 
            resources.ApplyResources(this.buttonBorrar, "buttonBorrar");
            this.buttonBorrar.BackColor = System.Drawing.Color.Azure;
            this.buttonBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Datos
            // 
            this.AcceptButton = this.buttonAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonOcupar);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelLLego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLLego;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonOcupar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBorrar;
    }
}