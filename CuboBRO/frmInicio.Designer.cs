namespace CuboBRO
{
    partial class frmInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnConsultarCUBO = new System.Windows.Forms.Button();
            this.btnVisualizarDW = new System.Windows.Forms.Button();
            this.btnEjecutarETL = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 536);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultarCUBO);
            this.splitContainer1.Panel1.Controls.Add(this.btnVisualizarDW);
            this.splitContainer1.Panel1.Controls.Add(this.btnEjecutarETL);
            this.splitContainer1.Panel1.Controls.Add(this.btnCargarDatos);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1231, 536);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnConsultarCUBO
            // 
            this.btnConsultarCUBO.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConsultarCUBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCUBO.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCUBO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarCUBO.Location = new System.Drawing.Point(147, 355);
            this.btnConsultarCUBO.Name = "btnConsultarCUBO";
            this.btnConsultarCUBO.Size = new System.Drawing.Size(180, 62);
            this.btnConsultarCUBO.TabIndex = 4;
            this.btnConsultarCUBO.Text = "CONSULTAR CUBO";
            this.btnConsultarCUBO.UseVisualStyleBackColor = false;
            this.btnConsultarCUBO.Click += new System.EventHandler(this.btnConsultarCUBO_Click);
            // 
            // btnVisualizarDW
            // 
            this.btnVisualizarDW.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVisualizarDW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarDW.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarDW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisualizarDW.Location = new System.Drawing.Point(147, 254);
            this.btnVisualizarDW.Name = "btnVisualizarDW";
            this.btnVisualizarDW.Size = new System.Drawing.Size(180, 62);
            this.btnVisualizarDW.TabIndex = 3;
            this.btnVisualizarDW.Text = "VISUALIZAR DW";
            this.btnVisualizarDW.UseVisualStyleBackColor = false;
            this.btnVisualizarDW.Click += new System.EventHandler(this.btnVisualizarDW_Click);
            // 
            // btnEjecutarETL
            // 
            this.btnEjecutarETL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEjecutarETL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutarETL.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnEjecutarETL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEjecutarETL.Location = new System.Drawing.Point(147, 151);
            this.btnEjecutarETL.Name = "btnEjecutarETL";
            this.btnEjecutarETL.Size = new System.Drawing.Size(180, 62);
            this.btnEjecutarETL.TabIndex = 2;
            this.btnEjecutarETL.Text = "EJECUTAR ETL";
            this.btnEjecutarETL.UseVisualStyleBackColor = false;
            this.btnEjecutarETL.Click += new System.EventHandler(this.btnEjecutarETL_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnCargarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarDatos.Location = new System.Drawing.Point(147, 47);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(180, 62);
            this.btnCargarDatos.TabIndex = 1;
            this.btnCargarDatos.Text = "CARGAR DATOS";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 536);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuboBRO.Properties.Resources.MENU_PROCESOS;
            this.pictureBox1.Location = new System.Drawing.Point(48, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CuboBRO.Properties.Resources.texto2;
            this.pictureBox2.Location = new System.Drawing.Point(108, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 463);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 536);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INICIO";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnConsultarCUBO;
        private System.Windows.Forms.Button btnVisualizarDW;
        private System.Windows.Forms.Button btnEjecutarETL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}