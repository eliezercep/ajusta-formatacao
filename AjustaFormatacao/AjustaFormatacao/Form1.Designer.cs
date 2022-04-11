namespace AjustaFormatacao
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
            this.SuspendLayout();
            // 
            // btnAjustar
            // 
            this.btnAjustar.Location = new System.Drawing.Point(119, 347);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(144, 43);
            this.btnAjustar.TabIndex = 0;
            this.btnAjustar.Text = "Ajustar";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // textCodidos
            // 
            this.textCodidos.Location = new System.Drawing.Point(119, 59);
            this.textCodidos.Multiline = true;
            this.textCodidos.Name = "textCodidos";
            this.textCodidos.Size = new System.Drawing.Size(513, 254);
            this.textCodidos.TabIndex = 1;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(557, 367);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArquivo.TabIndex = 2;
            this.btnAbrirArquivo.Text = "Abrir";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

