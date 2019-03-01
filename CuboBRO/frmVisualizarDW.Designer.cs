namespace CuboBRO
{
    partial class frmVisualizarDW
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
            this.tabControlVista = new System.Windows.Forms.TabControl();
            this.tpEsquema = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptarAlmacen = new System.Windows.Forms.Button();
            this.dwvVentas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dwvProductos = new System.Windows.Forms.DataGridView();
            this.dwvTiempo = new System.Windows.Forms.DataGridView();
            this.dwvTiendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpSoriana = new System.Windows.Forms.TabPage();
            this.tabControlVista.SuspendLayout();
            this.tpEsquema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvTiendas)).BeginInit();
            this.tpSoriana.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVista
            // 
            this.tabControlVista.Controls.Add(this.tpEsquema);
            this.tabControlVista.Controls.Add(this.tpSoriana);
            this.tabControlVista.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControlVista.Location = new System.Drawing.Point(2, 2);
            this.tabControlVista.Name = "tabControlVista";
            this.tabControlVista.SelectedIndex = 0;
            this.tabControlVista.Size = new System.Drawing.Size(1215, 583);
            this.tabControlVista.TabIndex = 1;
            // 
            // tpEsquema
            // 
            this.tpEsquema.AutoScroll = true;
            this.tpEsquema.Controls.Add(this.pictureBox1);
            this.tpEsquema.Font = new System.Drawing.Font("Arial", 10F);
            this.tpEsquema.Location = new System.Drawing.Point(4, 27);
            this.tpEsquema.Name = "tpEsquema";
            this.tpEsquema.Padding = new System.Windows.Forms.Padding(3);
            this.tpEsquema.Size = new System.Drawing.Size(1207, 552);
            this.tpEsquema.TabIndex = 0;
            this.tpEsquema.Text = "Esquema";
            this.tpEsquema.UseVisualStyleBackColor = true;
            this.tpEsquema.Click += new System.EventHandler(this.tpEsquema_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuboBRO.Properties.Resources.esquemaCubo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptarAlmacen
            // 
            this.btnAceptarAlmacen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAceptarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAlmacen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAlmacen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarAlmacen.Location = new System.Drawing.Point(1053, 588);
            this.btnAceptarAlmacen.Name = "btnAceptarAlmacen";
            this.btnAceptarAlmacen.Size = new System.Drawing.Size(150, 50);
            this.btnAceptarAlmacen.TabIndex = 5;
            this.btnAceptarAlmacen.Text = "ACEPTAR";
            this.btnAceptarAlmacen.UseVisualStyleBackColor = false;
            this.btnAceptarAlmacen.Click += new System.EventHandler(this.btnAceptarAlmacen_Click);
            // 
            // dwvVentas
            // 
            this.dwvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dwvVentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dwvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvVentas.Location = new System.Drawing.Point(26, 237);
            this.dwvVentas.Name = "dwvVentas";
            this.dwvVentas.Size = new System.Drawing.Size(1123, 295);
            this.dwvVentas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "   hechosVentas   ";
            // 
            // dwvProductos
            // 
            this.dwvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dwvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvProductos.Location = new System.Drawing.Point(579, 46);
            this.dwvProductos.Name = "dwvProductos";
            this.dwvProductos.Size = new System.Drawing.Size(570, 150);
            this.dwvProductos.TabIndex = 3;
            // 
            // dwvTiempo
            // 
            this.dwvTiempo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dwvTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvTiempo.Location = new System.Drawing.Point(264, 45);
            this.dwvTiempo.Name = "dwvTiempo";
            this.dwvTiempo.Size = new System.Drawing.Size(300, 150);
            this.dwvTiempo.TabIndex = 1;
            // 
            // dwvTiendas
            // 
            this.dwvTiendas.AllowUserToAddRows = false;
            this.dwvTiendas.AllowUserToDeleteRows = false;
            this.dwvTiendas.AllowUserToOrderColumns = true;
            this.dwvTiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dwvTiendas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dwvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvTiendas.Location = new System.Drawing.Point(29, 45);
            this.dwvTiendas.Name = "dwvTiendas";
            this.dwvTiendas.ReadOnly = true;
            this.dwvTiendas.Size = new System.Drawing.Size(220, 150);
            this.dwvTiendas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "   dimTienda   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(261, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "   dimTiempo   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(576, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "   dimProductos   ";
            // 
            // tpSoriana
            // 
            this.tpSoriana.Controls.Add(this.dwvProductos);
            this.tpSoriana.Controls.Add(this.dwvTiendas);
            this.tpSoriana.Controls.Add(this.label4);
            this.tpSoriana.Controls.Add(this.dwvTiempo);
            this.tpSoriana.Controls.Add(this.label3);
            this.tpSoriana.Controls.Add(this.dwvVentas);
            this.tpSoriana.Controls.Add(this.label2);
            this.tpSoriana.Controls.Add(this.label1);
            this.tpSoriana.Font = new System.Drawing.Font("Arial", 10F);
            this.tpSoriana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpSoriana.Location = new System.Drawing.Point(4, 27);
            this.tpSoriana.Name = "tpSoriana";
            this.tpSoriana.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoriana.Size = new System.Drawing.Size(1207, 552);
            this.tpSoriana.TabIndex = 1;
            this.tpSoriana.Text = "Datos de almacen";
            this.tpSoriana.UseVisualStyleBackColor = true;
            // 
            // frmVisualizarDW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 650);
            this.Controls.Add(this.btnAceptarAlmacen);
            this.Controls.Add(this.tabControlVista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarDW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISUALIZAR EL ALMACEN DE DATOS DW ";
            this.Load += new System.EventHandler(this.frmVisualizarDW_Load);
            this.tabControlVista.ResumeLayout(false);
            this.tpEsquema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwvTiendas)).EndInit();
            this.tpSoriana.ResumeLayout(false);
            this.tpSoriana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVista;
        private System.Windows.Forms.TabPage tpEsquema;
        private System.Windows.Forms.Button btnAceptarAlmacen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tpSoriana;
        private System.Windows.Forms.DataGridView dwvProductos;
        private System.Windows.Forms.DataGridView dwvTiendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dwvTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dwvVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}