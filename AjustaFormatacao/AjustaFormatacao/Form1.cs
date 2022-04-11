using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AjustaFormatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {           
            try
            {
                string codigos = textCodidos.Text;

                string[] codigoTeste = codigos.Split(" ");

                string[] codigosLIsta = codigoTeste[0].Split($"\r\n");

                List<string> codigoProntos = new List<string>();

                int cont = (int)codigosLIsta.Count;

                foreach (var item in codigosLIsta)
                {



                    var linha = string.Format("'" + item + "',");
                    codigoProntos.Add(linha);
                }

                var caminho = Directory.GetCurrentDirectory() + "\\Codigos";

                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                }

                string fileName = "linhas.txt";

                string caminhoFile = string.Format(caminho + "\\" + fileName);                

                if (!File.Exists(caminhoFile))
                {
                    File.CreateText(caminhoFile).Close();
                }

                using (StreamWriter file = File.AppendText(caminhoFile))
                {
                    foreach (var linha in codigoProntos)
                    {
                        file.WriteLine(linha);
                    }
                }

                MessageBox.Show("Códigos formatados com sucesso");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }            
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            var caminho = Directory.GetCurrentDirectory() + "\\Codigos";
            string fileName = "linhas.txt";

            string caminhoFile = string.Format(caminho + "\\" + fileName);

            try
            {

                if (!File.Exists(caminhoFile))
                {
                    throw new Exception("Arquivo ainda nao gerado ou encontrado");
                }

                Process.Start("notepad.exe", caminhoFile);

            }
            catch(Exception erro)
            {
                MessageBox.Show("!: " + erro.Message);
            }

            
        }
    }
}
