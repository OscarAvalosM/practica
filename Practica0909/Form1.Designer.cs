﻿
namespace Practica0909
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnGetNames = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(245, 325);
            this.dgData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(562, 194);
            this.dgData.TabIndex = 7;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(245, 85);
            this.lstNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(150, 212);
            this.lstNames.TabIndex = 6;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(92, 325);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(70, 32);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.Text = "getData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click_1);
            // 
            // btnGetNames
            // 
            this.btnGetNames.Location = new System.Drawing.Point(92, 85);
            this.btnGetNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetNames.Name = "btnGetNames";
            this.btnGetNames.Size = new System.Drawing.Size(56, 19);
            this.btnGetNames.TabIndex = 4;
            this.btnGetNames.Text = "getNames";
            this.btnGetNames.UseVisualStyleBackColor = true;
            this.btnGetNames.Click += new System.EventHandler(this.btnGetNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 598);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGetNames);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnGetNames;
    }
}

