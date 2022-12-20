using System.IO;
using System;
using System.Numerics;

namespace Projeto_Editor_Texto
{
    public partial class Form1 : Form
    {
        StringReader leitor = null;

        public Form1()
        {
            InitializeComponent();
        }

        #region Manipular NOVO DOCUMENTO
        private void NovoDocumento()
        {
            if(richTextBox1.Text == "")
            {
                richTextBox1.Clear();
                richTextBox1.Focus();
            }
            else
            {
                if((MessageBox.Show("Você deseja abrir um novo documento. Você perderá seu trabalho", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    richTextBox1.Clear();
                    richTextBox1.Focus();
                }
                else
                {
                    richTextBox1.Focus();
                }
            }
        }
        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            NovoDocumento();
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoDocumento();
        }
        #endregion

        #region Manipular SALVAR DOCUMENTO
        private void SalvarDocumento()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escritor = new StreamWriter(arquivo);
                    escritor.Flush();
                    escritor.BaseStream.Seek(0, SeekOrigin.Begin);
                    escritor.Write(this.richTextBox1.Text);
                    escritor.Flush();
                    escritor.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Salvar trabalho.",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarDocumento();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarDocumento();
        }
        #endregion

        #region Manipular ABRIR DOCUMENTO
        private void AbrirDocumento()
        {
            this.openFileDialog1.Title = "Abri Arquivo";
            openFileDialog1.InitialDirectory = "@\\Documentos";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader leitor = new StreamReader(arquivo);
                    leitor.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = leitor.ReadLine();
                    while(linha != null )
                    {
                        richTextBox1.Text += linha + "\n";
                        linha = leitor.ReadLine();
                    }
                    leitor.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro na leitura do arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            AbrirDocumento();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirDocumento();
        }
        #endregion

        #region Método COPIAR, COLAR e RECORTAR
        private void Copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void Recortar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }
        private void Btn_Recortar_Click(object sender, EventArgs e)
        {
            Recortar();
        }
        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recortar();
        }

        private void Btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        #endregion

        #region MÉTODOS DE FORMATAÇÃO
        private void Negritar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n,i,s = false;
            nome_fonte = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            if (n == false)
            {
                if(i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic| FontStyle.Underline);
                }
                else if(i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Underline);
                }
                else if(i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
                else
                {
                    if (i == true & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte ,FontStyle.Italic| FontStyle.Underline);
                    }
                    else if (i == false & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte ,FontStyle.Underline);
                    }
                    else if (i == true & s == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte ,FontStyle.Italic);
                    }
                }
            }
        }
        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n, i, s = false;
            nome_fonte = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic| FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic| FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
                else
                {
                    if (n == true & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Underline);
                    }
                    else if (n == false & s == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                    }
                    else if (n == true & s == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                    }
                }
            }
        }
        private void Sublinhar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n, i, s = false;
            nome_fonte = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic| FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic| FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Underline);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
                else
                {
                    if (n == true & i == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold| FontStyle.Italic);
                    }
                    else if (n == false & i == true)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                    }
                    else if (n == true & i == false)
                    {
                        richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                    }
                }
            }
        }
        private void AlterarFonte()
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }
        }
        private void Btn_Negrito_Click(object sender, EventArgs e)
        {
            Negritar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negritar();
        }

        private void Btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }
        private void Btn_Sublinhar_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }
        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            AlterarFonte();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFonte();
        }
        private void Btn_CapsLock_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Text.ToUpper();
            }
        }

        #endregion

        #region Método IMPRIMIR

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float posicaoY = 0;
            int cont = 0;

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
                margemEsquerda = 20;
            if (margemSuperior < 5)
                margemSuperior = 20;

            linhasPagina = e.MarginBounds.Height/fonte.GetHeight(e.Graphics);

            linha = leitor.ReadLine();

            while(cont <= linhasPagina)
            {
                posicaoY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, posicaoY, new StringFormat());
                cont+= 1;
                linha = leitor.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages= true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitor = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void configuraçõesDeImpreçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracoesImpressora();
        }
        private void ConfiguracoesImpressora()
        {
            try
            {
                this.printDialog1.Document = this.printDocument1;
                printDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizaImpressao();
        }

        private void visualizaImpressao()
        {
            try
            {
                string strTexto = this.richTextBox1.Text;
                leitor = new StringReader(strTexto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = this.printDocument1;
                prn.Text = "SRMV - Visualizando a impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Métodos de ALINHAMENTO DE TEXTO

        private void AlinharAEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharADireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlinharAoCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void JustificarText()
        {

        }

        private void Btn_ADireita_Click(object sender, EventArgs e)
        {
            AlinharADireita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharADireita();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharAEsquerda();
        }

        private void Btn_AEsquerda_Click(object sender, EventArgs e)
        {
            AlinharAEsquerda();
        }
        private void Btn_Centralizar_Click(object sender, EventArgs e)
        {
            AlinharAoCentro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharAoCentro();
        }


        #endregion

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)sender;

            richTextBox1.Location = new Point((form1.Size.Width - richTextBox1.Size.Width) / 2, 60);
            richTextBox1.Size = new Size(960, form1.Size.Height - 110);

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ajuda_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}