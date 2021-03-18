using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContasPagarXML
{
    public partial class frCadXMLContasPagar : Form
    {
        public frCadXMLContasPagar()
        {
            InitializeComponent();
        }

        XMLContasPagar arqXML = new XMLContasPagar();

        private void ConfiguraBtnRemocao()
        {
            btnRemover.Enabled = dgContasPagar.Rows.Count > 1;
        }

        private void BtnNovoDoc_Click(object sender, EventArgs e)
        {
            DialogResult dg = fbdCaminhoArqContas.ShowDialog();

            if (dg == DialogResult.OK)
            {
                try
                {
                    string caminho = fbdCaminhoArqContas.SelectedPath + "\\Contas" + DateTime.Now.ToString("ddMMyyyy") + ".xml";
                    arqXML.CriarNovoArquivoContas(caminho);
                    tbDocContasPagar.Text = caminho;
                    btnIncluir.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Arquivo Existente. Não foi possível criar um novo arquivo.");
                }

            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DialogResult dg= ofdContasPagar.ShowDialog();

            if (dg == DialogResult.OK)
            {
                try
                {
                    ofdContasPagar.InitialDirectory = Path.GetDirectoryName(ofdContasPagar.FileName);
                    tbDocContasPagar.Text = ofdContasPagar.FileName;
                    dgContasPagar.DataSource = arqXML.CarregarInformacoesXML(tbDocContasPagar.Text);
                    tbValorTotal.Text = arqXML.valorTotal.ToString();
                    btnIncluir.Enabled = true;
                    btnEditar.Enabled = true;
                    ConfiguraBtnRemocao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar arquivo : " + ex.Message);
                }
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            frInserirNovaConta telaEdicaoInclusao = new frInserirNovaConta();
            telaEdicaoInclusao.caminhoArq = tbDocContasPagar.Text;
            telaEdicaoInclusao.ShowDialog();
            DataTable tabelaContas = arqXML.CarregarInformacoesXML(tbDocContasPagar.Text);
            tbValorTotal.Text = arqXML.valorTotal.ToString();
            if (tabelaContas != null)
            {
                btnEditar.Enabled = true;
                btnRemover.Enabled = true;
                dgContasPagar.DataSource = tabelaContas;   
            }
        }

        private void FrCadXMLContasPagar_Shown(object sender, EventArgs e)
        {
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            string codigoConta = dgContasPagar.Rows[dgContasPagar.CurrentRow.Index].Cells[0].Value.ToString();
            arqXML.RemoveContaXML(tbDocContasPagar.Text, codigoConta);
            dgContasPagar.DataSource = arqXML.CarregarInformacoesXML(tbDocContasPagar.Text);
            tbValorTotal.Text = arqXML.valorTotal.ToString();
            ConfiguraBtnRemocao();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoConta = dgContasPagar.Rows[dgContasPagar.CurrentRow.Index].Cells[0].Value.ToString();
                arqXML.contaXML = arqXML.PegaContaEdicaoXML(tbDocContasPagar.Text, codigoConta);

                frInserirNovaConta telaEdicaoInclusao = new frInserirNovaConta(arqXML.contaXML);
                telaEdicaoInclusao.caminhoArq = tbDocContasPagar.Text;
                telaEdicaoInclusao.ShowDialog();
                dgContasPagar.DataSource = arqXML.CarregarInformacoesXML(tbDocContasPagar.Text);
                tbValorTotal.Text = arqXML.valorTotal.ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível editar o registro");
            }
        }
    }
}
