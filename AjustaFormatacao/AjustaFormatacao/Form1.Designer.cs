﻿namespace AjustaFormatacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjustar = new System.Windows.Forms.Button();
            this.textCodidos = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.textTipoFormatador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjustar
            // 
            this.btnAjustar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjustar.Location = new System.Drawing.Point(198, 462);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(162, 52);
            this.btnAjustar.TabIndex = 0;
            this.btnAjustar.Text = "Ajustar Formato";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // textCodidos
            // 
            this.textCodidos.BackColor = System.Drawing.SystemColors.Menu;
            this.textCodidos.Location = new System.Drawing.Point(198, 32);
            this.textCodidos.Multiline = true;
            this.textCodidos.Name = "textCodidos";
            this.textCodidos.Size = new System.Drawing.Size(513, 317);
            this.textCodidos.TabIndex = 1;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirArquivo.Location = new System.Drawing.Point(562, 462);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(149, 42);
            this.btnAbrirArquivo.TabIndex = 2;
            this.btnAbrirArquivo.Text = "Abrir";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // textTipoFormatador
            // 
            this.textTipoFormatador.Location = new System.Drawing.Point(413, 394);
            this.textTipoFormatador.Name = "textTipoFormatador";
            this.textTipoFormatador.Size = new System.Drawing.Size(115, 23);
            this.textTipoFormatador.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(403, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo do formato:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTipoFormatador);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.textCodidos);
            this.Controls.Add(this.btnAjustar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.TextBox textCodidos;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.TextBox textTipoFormatador;
        private System.Windows.Forms.Label label1;
    }
}

