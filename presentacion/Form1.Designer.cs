namespace presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewVerContactos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscarContacto = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 35);
            this.panelTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Controls.Add(this.pictureBoxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 35);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1218, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(32, 29);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1256, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(32, 29);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuVertical.Controls.Add(this.flowLayoutPanel3);
            this.panelMenuVertical.Controls.Add(this.flowLayoutPanel2);
            this.panelMenuVertical.Controls.Add(this.flowLayoutPanel1);
            this.panelMenuVertical.Controls.Add(this.button3);
            this.panelMenuVertical.Controls.Add(this.button2);
            this.panelMenuVertical.Controls.Add(this.btnAgregar);
            this.panelMenuVertical.Controls.Add(this.pictureBox1);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(200, 615);
            this.panelMenuVertical.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 314);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(18, 34);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 254);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(18, 34);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(18, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(12, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar contacto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar contacto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(12, 196);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar contacto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-48, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewVerContactos
            // 
            this.dataGridViewVerContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerContactos.Location = new System.Drawing.Point(268, 115);
            this.dataGridViewVerContactos.Name = "dataGridViewVerContactos";
            this.dataGridViewVerContactos.ReadOnly = true;
            this.dataGridViewVerContactos.RowHeadersWidth = 51;
            this.dataGridViewVerContactos.RowTemplate.Height = 24;
            this.dataGridViewVerContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVerContactos.Size = new System.Drawing.Size(912, 400);
            this.dataGridViewVerContactos.TabIndex = 3;
            this.dataGridViewVerContactos.SelectionChanged += new System.EventHandler(this.dataGridViewVerContactos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion de contactos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1187, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(236, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxBuscarContacto
            // 
            this.textBoxBuscarContacto.Location = new System.Drawing.Point(268, 81);
            this.textBoxBuscarContacto.Name = "textBoxBuscarContacto";
            this.textBoxBuscarContacto.Size = new System.Drawing.Size(310, 22);
            this.textBoxBuscarContacto.TabIndex = 8;
            this.textBoxBuscarContacto.TextChanged += new System.EventHandler(this.textBoxBuscarContacto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.textBoxBuscarContacto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVerContactos);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewVerContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxBuscarContacto;
    }
}

