﻿namespace CuboBRO
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
            this.btnAceptarCUBO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptarCUBO
            // 
            this.btnAceptarCUBO.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAceptarCUBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCUBO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCUBO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarCUBO.Location = new System.Drawing.Point(983, 545);
            this.btnAceptarCUBO.Name = "btnAceptarCUBO";
            this.btnAceptarCUBO.Size = new System.Drawing.Size(150, 50);
            this.btnAceptarCUBO.TabIndex = 6;
            this.btnAceptarCUBO.Text = "ACEPTAR";
            this.btnAceptarCUBO.UseVisualStyleBackColor = false;
            this.btnAceptarCUBO.Click += new System.EventHandler(this.btnAceptarCUBO_Click);
            // 
            // frmConsultarCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 607);
            this.Controls.Add(this.btnAceptarCUBO);
            this.Name = "frmConsultarCubo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CUBO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarCUBO;
    }
}