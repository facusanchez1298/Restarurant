namespace prueba
{
    partial class Ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver));
            this.panelReloj = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDatos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonMozo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTurno = new System.Windows.Forms.Panel();
            this.labelAlto = new System.Windows.Forms.Label();
            this.labelAncho = new System.Windows.Forms.Label();
            this.planoVer = new prueba.Plano();
            this.panelReloj.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReloj
            // 
            this.panelReloj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReloj.Controls.Add(this.labelHora);
            this.panelReloj.Controls.Add(this.labelDia);
            this.panelReloj.Controls.Add(this.labelFecha);
            this.panelReloj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReloj.Location = new System.Drawing.Point(7, 12);
            this.panelReloj.Name = "panelReloj";
            this.panelReloj.Size = new System.Drawing.Size(276, 107);
            this.panelReloj.TabIndex = 2;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelHora.Location = new System.Drawing.Point(3, 10);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(268, 59);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "11:25:04";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDia
            // 
            this.labelDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDia.Location = new System.Drawing.Point(152, 69);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(123, 32);
            this.labelDia.TabIndex = 1;
            this.labelDia.Text = "Domingo";
            this.labelDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFecha
            // 
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(-1, 69);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(154, 32);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "30/12/2019";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatos.AutoSize = true;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.dataGridView1);
            this.panelDatos.Location = new System.Drawing.Point(7, 125);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(276, 307);
            this.panelDatos.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(274, 305);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditar.BackColor = System.Drawing.Color.Azure;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonEditar.Location = new System.Drawing.Point(8, 437);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(88, 27);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMenu.BackColor = System.Drawing.Color.Azure;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonMenu.Location = new System.Drawing.Point(101, 437);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(88, 27);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonMozo
            // 
            this.buttonMozo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMozo.BackColor = System.Drawing.Color.Azure;
            this.buttonMozo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMozo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMozo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMozo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonMozo.Location = new System.Drawing.Point(194, 437);
            this.buttonMozo.Name = "buttonMozo";
            this.buttonMozo.Size = new System.Drawing.Size(88, 27);
            this.buttonMozo.TabIndex = 5;
            this.buttonMozo.Text = "Mozos";
            this.buttonMozo.UseVisualStyleBackColor = false;
            this.buttonMozo.Click += new System.EventHandler(this.buttonMozo_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Azure;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = global::prueba.Properties.Resources.number6;
            this.button6.Location = new System.Drawing.Point(677, 435);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 34);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = global::prueba.Properties.Resources._5;
            this.button5.Location = new System.Drawing.Point(643, 435);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 34);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::prueba.Properties.Resources._4;
            this.button4.Location = new System.Drawing.Point(609, 435);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 34);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::prueba.Properties.Resources._3;
            this.button3.Location = new System.Drawing.Point(575, 435);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 34);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::prueba.Properties.Resources._2;
            this.button2.Location = new System.Drawing.Point(541, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::prueba.Properties.Resources._11;
            this.button1.Location = new System.Drawing.Point(507, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 8;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(287, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Turno:";
            // 
            // panelTurno
            // 
            this.panelTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTurno.Controls.Add(this.comboBox1);
            this.panelTurno.Location = new System.Drawing.Point(359, 440);
            this.panelTurno.Name = "panelTurno";
            this.panelTurno.Size = new System.Drawing.Size(124, 24);
            this.panelTurno.TabIndex = 13;
            // 
            // labelAlto
            // 
            this.labelAlto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlto.AutoSize = true;
            this.labelAlto.Location = new System.Drawing.Point(12, 468);
            this.labelAlto.Name = "labelAlto";
            this.labelAlto.Size = new System.Drawing.Size(35, 13);
            this.labelAlto.TabIndex = 14;
            this.labelAlto.Text = "label1";
            // 
            // labelAncho
            // 
            this.labelAncho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAncho.AutoSize = true;
            this.labelAncho.Location = new System.Drawing.Point(12, 488);
            this.labelAncho.Name = "labelAncho";
            this.labelAncho.Size = new System.Drawing.Size(35, 13);
            this.labelAncho.TabIndex = 14;
            this.labelAncho.Text = "label1";
            // 
            // planoVer
            // 
            this.planoVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planoVer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.planoVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planoVer.Location = new System.Drawing.Point(291, 12);
            this.planoVer.Name = "planoVer";
            this.planoVer.Size = new System.Drawing.Size(420, 420);
            this.planoVer.TabIndex = 10;
            this.planoVer.Click += new System.EventHandler(this.plano1_Click);
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(764, 505);
            this.Controls.Add(this.labelAncho);
            this.Controls.Add(this.labelAlto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.planoVer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMozo);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelReloj);
            this.Controls.Add(this.panelTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Ver_Resize);
            this.panelReloj.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTurno.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelReloj;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelDatos;
        public Plano planoVer;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonMozo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelTurno;
        private System.Windows.Forms.Label labelAlto;
        private System.Windows.Forms.Label labelAncho;
    }
}