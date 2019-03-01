namespace CuboBRO
{
    partial class frmCargarDatos
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
            this.tabControlDatos = new System.Windows.Forms.TabControl();
            this.tpNieto = new System.Windows.Forms.TabPage();
            this.txtArchivoTiendaNeto = new System.Windows.Forms.TextBox();
            this.btCargarNeto = new System.Windows.Forms.Button();
            this.dataGridViewNeto = new System.Windows.Forms.DataGridView();
            this.tpSoriana = new System.Windows.Forms.TabPage();
            this.txtArchivoSoriana = new System.Windows.Forms.TextBox();
            this.dataGridViewSoriana = new System.Windows.Forms.DataGridView();
            this.btnCargarSoriana = new System.Windows.Forms.Button();
            this.tpBodegaAurrera = new System.Windows.Forms.TabPage();
            this.txtArchivoBodegaAurrera = new System.Windows.Forms.TextBox();
            this.dataGridViewBodegaAurrera = new System.Windows.Forms.DataGridView();
            this.btnCargarBodegaAurrera = new System.Windows.Forms.Button();
            this.btnAceptarCargaDatos = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControlDatos.SuspendLayout();
            this.tpNieto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeto)).BeginInit();
            this.tpSoriana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoriana)).BeginInit();
            this.tpBodegaAurrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBodegaAurrera)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDatos
            // 
            this.tabControlDatos.Controls.Add(this.tpNieto);
            this.tabControlDatos.Controls.Add(this.tpSoriana);
            this.tabControlDatos.Controls.Add(this.tpBodegaAurrera);
            this.tabControlDatos.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControlDatos.Location = new System.Drawing.Point(0, 0);
            this.tabControlDatos.Name = "tabControlDatos";
            this.tabControlDatos.SelectedIndex = 0;
            this.tabControlDatos.Size = new System.Drawing.Size(1156, 583);
            this.tabControlDatos.TabIndex = 0;
            // 
            // tpNieto
            // 
            this.tpNieto.AutoScroll = true;
            this.tpNieto.Controls.Add(this.progressBar1);
            this.tpNieto.Controls.Add(this.txtArchivoTiendaNeto);
            this.tpNieto.Controls.Add(this.btCargarNeto);
            this.tpNieto.Controls.Add(this.dataGridViewNeto);
            this.tpNieto.Font = new System.Drawing.Font("Arial", 10F);
            this.tpNieto.Location = new System.Drawing.Point(4, 27);
            this.tpNieto.Name = "tpNieto";
            this.tpNieto.Padding = new System.Windows.Forms.Padding(3);
            this.tpNieto.Size = new System.Drawing.Size(1148, 552);
            this.tpNieto.TabIndex = 0;
            this.tpNieto.Text = "Tienda Neto";
            this.tpNieto.UseVisualStyleBackColor = true;
            // 
            // txtArchivoTiendaNeto
            // 
            this.txtArchivoTiendaNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArchivoTiendaNeto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArchivoTiendaNeto.Location = new System.Drawing.Point(11, 493);
            this.txtArchivoTiendaNeto.Name = "txtArchivoTiendaNeto";
            this.txtArchivoTiendaNeto.Size = new System.Drawing.Size(573, 26);
            this.txtArchivoTiendaNeto.TabIndex = 3;
            // 
            // btCargarNeto
            // 
            this.btCargarNeto.Font = new System.Drawing.Font("Arial", 10F);
            this.btCargarNeto.Image = global::CuboBRO.Properties.Resources.icono_XLS;
            this.btCargarNeto.Location = new System.Drawing.Point(590, 478);
            this.btCargarNeto.Name = "btCargarNeto";
            this.btCargarNeto.Size = new System.Drawing.Size(110, 50);
            this.btCargarNeto.TabIndex = 2;
            this.btCargarNeto.Text = "Buscar";
            this.btCargarNeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCargarNeto.UseVisualStyleBackColor = true;
            this.btCargarNeto.Click += new System.EventHandler(this.btCargarNeto_Click);
            // 
            // dataGridViewNeto
            // 
            this.dataGridViewNeto.AllowUserToAddRows = false;
            this.dataGridViewNeto.AllowUserToDeleteRows = false;
            this.dataGridViewNeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNeto.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNeto.Name = "dataGridViewNeto";
            this.dataGridViewNeto.ReadOnly = true;
            this.dataGridViewNeto.Size = new System.Drawing.Size(1142, 460);
            this.dataGridViewNeto.TabIndex = 1;
            // 
            // tpSoriana
            // 
            this.tpSoriana.Controls.Add(this.txtArchivoSoriana);
            this.tpSoriana.Controls.Add(this.dataGridViewSoriana);
            this.tpSoriana.Controls.Add(this.btnCargarSoriana);
            this.tpSoriana.Font = new System.Drawing.Font("Arial", 10F);
            this.tpSoriana.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tpSoriana.Location = new System.Drawing.Point(4, 27);
            this.tpSoriana.Name = "tpSoriana";
            this.tpSoriana.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoriana.Size = new System.Drawing.Size(1148, 552);
            this.tpSoriana.TabIndex = 1;
            this.tpSoriana.Text = "Soriana";
            this.tpSoriana.UseVisualStyleBackColor = true;
            // 
            // txtArchivoSoriana
            // 
            this.txtArchivoSoriana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArchivoSoriana.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArchivoSoriana.Location = new System.Drawing.Point(11, 493);
            this.txtArchivoSoriana.Name = "txtArchivoSoriana";
            this.txtArchivoSoriana.Size = new System.Drawing.Size(573, 26);
            this.txtArchivoSoriana.TabIndex = 5;
            // 
            // dataGridViewSoriana
            // 
            this.dataGridViewSoriana.AllowUserToAddRows = false;
            this.dataGridViewSoriana.AllowUserToDeleteRows = false;
            this.dataGridViewSoriana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoriana.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSoriana.Name = "dataGridViewSoriana";
            this.dataGridViewSoriana.ReadOnly = true;
            this.dataGridViewSoriana.Size = new System.Drawing.Size(1142, 460);
            this.dataGridViewSoriana.TabIndex = 0;
            // 
            // btnCargarSoriana
            // 
            this.btnCargarSoriana.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCargarSoriana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarSoriana.Image = global::CuboBRO.Properties.Resources.icono_XLS;
            this.btnCargarSoriana.Location = new System.Drawing.Point(590, 478);
            this.btnCargarSoriana.Name = "btnCargarSoriana";
            this.btnCargarSoriana.Size = new System.Drawing.Size(110, 50);
            this.btnCargarSoriana.TabIndex = 4;
            this.btnCargarSoriana.Text = "Buscar";
            this.btnCargarSoriana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarSoriana.UseVisualStyleBackColor = true;
            this.btnCargarSoriana.Click += new System.EventHandler(this.btnCargarSoriana_Click);
            // 
            // tpBodegaAurrera
            // 
            this.tpBodegaAurrera.Controls.Add(this.txtArchivoBodegaAurrera);
            this.tpBodegaAurrera.Controls.Add(this.dataGridViewBodegaAurrera);
            this.tpBodegaAurrera.Controls.Add(this.btnCargarBodegaAurrera);
            this.tpBodegaAurrera.Font = new System.Drawing.Font("Arial", 10F);
            this.tpBodegaAurrera.Location = new System.Drawing.Point(4, 27);
            this.tpBodegaAurrera.Name = "tpBodegaAurrera";
            this.tpBodegaAurrera.Padding = new System.Windows.Forms.Padding(3);
            this.tpBodegaAurrera.Size = new System.Drawing.Size(1148, 552);
            this.tpBodegaAurrera.TabIndex = 2;
            this.tpBodegaAurrera.Text = "Bodega Aurrera";
            this.tpBodegaAurrera.UseVisualStyleBackColor = true;
            // 
            // txtArchivoBodegaAurrera
            // 
            this.txtArchivoBodegaAurrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArchivoBodegaAurrera.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArchivoBodegaAurrera.Location = new System.Drawing.Point(6, 492);
            this.txtArchivoBodegaAurrera.Name = "txtArchivoBodegaAurrera";
            this.txtArchivoBodegaAurrera.Size = new System.Drawing.Size(573, 26);
            this.txtArchivoBodegaAurrera.TabIndex = 7;
            // 
            // dataGridViewBodegaAurrera
            // 
            this.dataGridViewBodegaAurrera.AllowUserToAddRows = false;
            this.dataGridViewBodegaAurrera.AllowUserToDeleteRows = false;
            this.dataGridViewBodegaAurrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBodegaAurrera.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBodegaAurrera.Name = "dataGridViewBodegaAurrera";
            this.dataGridViewBodegaAurrera.ReadOnly = true;
            this.dataGridViewBodegaAurrera.Size = new System.Drawing.Size(1142, 460);
            this.dataGridViewBodegaAurrera.TabIndex = 0;
            // 
            // btnCargarBodegaAurrera
            // 
            this.btnCargarBodegaAurrera.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCargarBodegaAurrera.Image = global::CuboBRO.Properties.Resources.icono_XLS;
            this.btnCargarBodegaAurrera.Location = new System.Drawing.Point(585, 478);
            this.btnCargarBodegaAurrera.Name = "btnCargarBodegaAurrera";
            this.btnCargarBodegaAurrera.Size = new System.Drawing.Size(110, 50);
            this.btnCargarBodegaAurrera.TabIndex = 6;
            this.btnCargarBodegaAurrera.Text = "Buscar";
            this.btnCargarBodegaAurrera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarBodegaAurrera.UseVisualStyleBackColor = true;
            this.btnCargarBodegaAurrera.Click += new System.EventHandler(this.btnCargarBodegaAurrera_Click);
            // 
            // btnAceptarCargaDatos
            // 
            this.btnAceptarCargaDatos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAceptarCargaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCargaDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCargaDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarCargaDatos.Location = new System.Drawing.Point(995, 611);
            this.btnAceptarCargaDatos.Name = "btnAceptarCargaDatos";
            this.btnAceptarCargaDatos.Size = new System.Drawing.Size(150, 50);
            this.btnAceptarCargaDatos.TabIndex = 4;
            this.btnAceptarCargaDatos.Text = "ACEPTAR";
            this.btnAceptarCargaDatos.UseVisualStyleBackColor = false;
            this.btnAceptarCargaDatos.Click += new System.EventHandler(this.btnAceptarCargaDatos_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 464);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1140, 10);
            this.progressBar1.TabIndex = 5;
            // 
            // frmCargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 673);
            this.Controls.Add(this.btnAceptarCargaDatos);
            this.Controls.Add(this.tabControlDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGA DE DATOS";
            this.tabControlDatos.ResumeLayout(false);
            this.tpNieto.ResumeLayout(false);
            this.tpNieto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeto)).EndInit();
            this.tpSoriana.ResumeLayout(false);
            this.tpSoriana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoriana)).EndInit();
            this.tpBodegaAurrera.ResumeLayout(false);
            this.tpBodegaAurrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBodegaAurrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDatos;
        private System.Windows.Forms.TabPage tpNieto;
        private System.Windows.Forms.TabPage tpSoriana;
        private System.Windows.Forms.TabPage tpBodegaAurrera;
        private System.Windows.Forms.DataGridView dataGridViewNeto;
        private System.Windows.Forms.DataGridView dataGridViewSoriana;
        private System.Windows.Forms.DataGridView dataGridViewBodegaAurrera;
        private System.Windows.Forms.TextBox txtArchivoTiendaNeto;
        private System.Windows.Forms.Button btCargarNeto;
        private System.Windows.Forms.TextBox txtArchivoSoriana;
        private System.Windows.Forms.Button btnCargarSoriana;
        private System.Windows.Forms.TextBox txtArchivoBodegaAurrera;
        private System.Windows.Forms.Button btnCargarBodegaAurrera;
        private System.Windows.Forms.Button btnAceptarCargaDatos;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}