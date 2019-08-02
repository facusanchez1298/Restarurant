namespace prueba
{
    partial class Editor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.trackBarAltura = new System.Windows.Forms.TrackBar();
            this.trackBarAncho = new System.Windows.Forms.TrackBar();
            this.textBoxAlto = new System.Windows.Forms.TextBox();
            this.textBoxAncho = new System.Windows.Forms.TextBox();
            this.panel = new prueba.Plano();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAncho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            // 
            // selector
            // 
            this.selector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selector.AutoScroll = true;
            this.selector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selector.Controls.Add(this.pictureBox4);
            this.selector.Controls.Add(this.pictureBox5);
            this.selector.Controls.Add(this.pictureBox2);
            this.selector.Controls.Add(this.pictureBox8);
            this.selector.Controls.Add(this.pictureBox6);
            this.selector.Controls.Add(this.pictureBox7);
            this.selector.Controls.Add(this.pictureBox14);
            this.selector.Controls.Add(this.pictureBox16);
            this.selector.Location = new System.Drawing.Point(18, 12);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(233, 419);
            this.selector.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::prueba.Properties.Resources.mesa_roja_4;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Mesa Roja 4";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::prueba.Properties.Resources.mesa_negra_4;
            this.pictureBox5.Location = new System.Drawing.Point(105, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Mesa Negra 4";
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::prueba.Properties.Resources.mesa_de_madera_4_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 105);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Mesa Blanca 4";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::prueba.Properties.Resources.mesa_blanca_6_personas;
            this.pictureBox8.Location = new System.Drawing.Point(105, 105);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(105, 105);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Mesa Blanca 6";
            this.pictureBox8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::prueba.Properties.Resources.mesa_negra_6;
            this.pictureBox6.Location = new System.Drawing.Point(0, 210);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(105, 105);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Mesa Negra 6";
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::prueba.Properties.Resources.pared_roja;
            this.pictureBox7.Location = new System.Drawing.Point(105, 210);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(105, 105);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Pared";
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = global::prueba.Properties.Resources.tabla_bar;
            this.pictureBox14.Location = new System.Drawing.Point(0, 315);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(105, 105);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 6;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "Tabla Bar";
            this.pictureBox14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Location = new System.Drawing.Point(105, 315);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(105, 105);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 8;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "Tabla Cocina";
            this.pictureBox16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.item_MouseDown);
            this.pictureBox16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_MouseMove);
            this.pictureBox16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.item_MouseUp);
            // 
            // trackBarAltura
            // 
            this.trackBarAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarAltura.Location = new System.Drawing.Point(291, 438);
            this.trackBarAltura.Maximum = 100;
            this.trackBarAltura.Minimum = 10;
            this.trackBarAltura.Name = "trackBarAltura";
            this.trackBarAltura.Size = new System.Drawing.Size(116, 45);
            this.trackBarAltura.TabIndex = 15;
            this.trackBarAltura.Value = 10;
            this.trackBarAltura.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarAltura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            // 
            // trackBarAncho
            // 
            this.trackBarAncho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarAncho.Location = new System.Drawing.Point(456, 438);
            this.trackBarAncho.Maximum = 100;
            this.trackBarAncho.Minimum = 10;
            this.trackBarAncho.Name = "trackBarAncho";
            this.trackBarAncho.Size = new System.Drawing.Size(104, 45);
            this.trackBarAncho.TabIndex = 16;
            this.trackBarAncho.Value = 10;
            this.trackBarAncho.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarAncho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            // 
            // textBoxAlto
            // 
            this.textBoxAlto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAlto.Location = new System.Drawing.Point(413, 438);
            this.textBoxAlto.Name = "textBoxAlto";
            this.textBoxAlto.ReadOnly = true;
            this.textBoxAlto.Size = new System.Drawing.Size(37, 20);
            this.textBoxAlto.TabIndex = 16;
            this.textBoxAlto.TabStop = false;
            this.textBoxAlto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            // 
            // textBoxAncho
            // 
            this.textBoxAncho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAncho.Location = new System.Drawing.Point(566, 438);
            this.textBoxAncho.Name = "textBoxAncho";
            this.textBoxAncho.ReadOnly = true;
            this.textBoxAncho.Size = new System.Drawing.Size(37, 20);
            this.textBoxAncho.TabIndex = 16;
            this.textBoxAncho.TabStop = false;
            this.textBoxAncho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(291, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 420);
            this.panel.TabIndex = 13;
            this.panel.TabStop = false;
            this.panel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditar.BackColor = System.Drawing.Color.Azure;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.buttonEditar.Location = new System.Drawing.Point(618, 438);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(93, 40);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "Aceptar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxAncho);
            this.Controls.Add(this.textBoxAlto);
            this.Controls.Add(this.trackBarAncho);
            this.Controls.Add(this.trackBarAltura);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Editor";
            this.Size = new System.Drawing.Size(809, 509);
            this.Tag = "Aceptar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tocarBoton);
            this.Resize += new System.EventHandler(this.Editor_Resize);
            this.selector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAncho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel selector;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox16;
        public Plano panel;
        private System.Windows.Forms.TrackBar trackBarAltura;
        private System.Windows.Forms.TrackBar trackBarAncho;
        private System.Windows.Forms.TextBox textBoxAlto;
        private System.Windows.Forms.TextBox textBoxAncho;
        private System.Windows.Forms.Button buttonEditar;
    }
}
