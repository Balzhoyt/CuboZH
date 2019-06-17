namespace CuboBRO
{
    partial class frmConsultarCubo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAceptarCUBO = new System.Windows.Forms.Button();
            this.dwvCubo = new System.Windows.Forms.DataGridView();
            this.btnEjecutarSQL = new System.Windows.Forms.Button();
            this.cmbConsultas = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCrearReglas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dwvCubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarCUBO
            // 
            this.btnAceptarCUBO.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAceptarCUBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCUBO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCUBO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarCUBO.Location = new System.Drawing.Point(1497, 713);
            this.btnAceptarCUBO.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarCUBO.Name = "btnAceptarCUBO";
            this.btnAceptarCUBO.Size = new System.Drawing.Size(200, 62);
            this.btnAceptarCUBO.TabIndex = 6;
            this.btnAceptarCUBO.Text = "ACEPTAR";
            this.btnAceptarCUBO.UseVisualStyleBackColor = false;
            this.btnAceptarCUBO.Click += new System.EventHandler(this.btnAceptarCUBO_Click);
            // 
            // dwvCubo
            // 
            this.dwvCubo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dwvCubo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dwvCubo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvCubo.Location = new System.Drawing.Point(13, 115);
            this.dwvCubo.Margin = new System.Windows.Forms.Padding(4);
            this.dwvCubo.Name = "dwvCubo";
            this.dwvCubo.Size = new System.Drawing.Size(1077, 571);
            this.dwvCubo.TabIndex = 7;
            this.dwvCubo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwvVentas_CellContentClick);
            // 
            // btnEjecutarSQL
            // 
            this.btnEjecutarSQL.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEjecutarSQL.Image = global::CuboBRO.Properties.Resources.images1;
            this.btnEjecutarSQL.Location = new System.Drawing.Point(14, 26);
            this.btnEjecutarSQL.Margin = new System.Windows.Forms.Padding(4);
            this.btnEjecutarSQL.Name = "btnEjecutarSQL";
            this.btnEjecutarSQL.Size = new System.Drawing.Size(140, 70);
            this.btnEjecutarSQL.TabIndex = 9;
            this.btnEjecutarSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutarSQL.UseVisualStyleBackColor = true;
            // 
            // cmbConsultas
            // 
            this.cmbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbConsultas.Items.AddRange(new object[] {
            "VENTAS POR CATEGORIAS",
            "VENTAS TOTALES POR CATEGORIAS",
            "VENTAS TIENDAS POR CATEGORIAS"});
            this.cmbConsultas.Location = new System.Drawing.Point(147, 50);
            this.cmbConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConsultas.Name = "cmbConsultas";
            this.cmbConsultas.Size = new System.Drawing.Size(547, 28);
            this.cmbConsultas.TabIndex = 0;
            this.cmbConsultas.Text = "SELECCIONE UNA CONSULTA A EJECUTAR";
            this.cmbConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbConsultas_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1115, 115);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(582, 363);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // btnCrearReglas
            // 
            this.btnCrearReglas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCrearReglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReglas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearReglas.Location = new System.Drawing.Point(625, 709);
            this.btnCrearReglas.Name = "btnCrearReglas";
            this.btnCrearReglas.Size = new System.Drawing.Size(465, 67);
            this.btnCrearReglas.TabIndex = 11;
            this.btnCrearReglas.Text = "Buscar reglas de asociación con Algoritmo Apriori";
            this.btnCrearReglas.UseVisualStyleBackColor = false;
            this.btnCrearReglas.Click += new System.EventHandler(this.btnCrearReglas_Click);
            // 
            // frmConsultarCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 788);
            this.Controls.Add(this.btnCrearReglas);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cmbConsultas);
            this.Controls.Add(this.btnEjecutarSQL);
            this.Controls.Add(this.dwvCubo);
            this.Controls.Add(this.btnAceptarCUBO);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarCubo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CUBO";
            ((System.ComponentModel.ISupportInitialize)(this.dwvCubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarCUBO;
        private System.Windows.Forms.DataGridView dwvCubo;
        private System.Windows.Forms.Button btnEjecutarSQL;
        private System.Windows.Forms.ComboBox cmbConsultas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCrearReglas;
    }
}