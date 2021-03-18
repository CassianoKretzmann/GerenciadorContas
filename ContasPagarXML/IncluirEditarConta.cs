using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;

namespace ContasPagarXML
{
    public partial class frInserirNovaConta : Form
    {
        public frInserirNovaConta()
        {
            InitializeComponent();
        }

        private string codigoConta;
        private bool Editando;
        //Construtor para edição;
        public frInserirNovaConta(IEnumerable<XElement> conta)
        {
            InitializeComponent();

            Editando = true;
            codigoConta = conta.ElementAt(0).Element("CodigoConta").Value;
            tbValor.Text = conta.ElementAt(0).Element("Valor").Value;
            cbFormaPagamento.SelectedIndex = Convert.ToInt32(conta.ElementAt(0).Element("FormaPagamento").Attribute("Codigo").Value);
            tbDescricao.Text = conta.ElementAt(0).Element("DescricaoConta").Value;
            mtbDataCompra.Text = conta.ElementAt(0).Element("DataCompra").Value; 
            mtbDataVencimento.Text = conta.ElementAt(0).Element("DataVencimento").Value;
            mtbDataPagamento.Text = conta.ElementAt(0).Element("DataPagamento").Value;

        }

        XMLContasPagar arqXML = new XMLContasPagar();

        private void MensagemAviso()
        {
            DialogResult dr = MessageBox.Show("Os dados não salvos seram perdidos", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                Close();
            }
        }

        public void MensagemValidacaoCampos(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private Boolean InformacoesObrigatoriasPreenchidas()
        {
           if (tbValor.Text == "")
            {
                MensagemValidacaoCampos("Valor não informado");
                return false;
            }
            else if (cbFormaPagamento.Text == "")
            {
                MensagemValidacaoCampos("Forma de pagamento não informada");
                return false;
            }
            else if (tbDescricao.Text == "")
            {
                MensagemValidacaoCampos("Descrição da conta não informada");
                return false;
            }
            else if (mtbDataCompra.Text == "  /  /")
            {
                MensagemValidacaoCampos("Data de compra não informada");
                return false;
            }
            //else if (mtbDataVencimento.Text == "  /  /")
            //{
            //    MensagemValidacaoCampos("Data de vencimento não informada");
            //    return false;
            //}
            else
            {
                return true;
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdAvancado.ShowDialog();
        }

        private string _caminhoArq;
        public string caminhoArq
        {
            get { return _caminhoArq; }
            set { _caminhoArq = value; }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (InformacoesObrigatoriasPreenchidas())
            {
                if (Editando)
                    arqXML.EditaContaXML(codigoConta, _caminhoArq, tbValor.Text, cbFormaPagamento.SelectedIndex.ToString(), cbFormaPagamento.Text,
                        tbDescricao.Text, mtbDataVencimento.Text, mtbDataCompra.Text, mtbDataPagamento.Text);
                else
                    arqXML.InserirNovaConta(_caminhoArq, tbValor.Text, cbFormaPagamento.SelectedIndex.ToString(), cbFormaPagamento.Text,
                        tbDescricao.Text, mtbDataVencimento.Text, mtbDataCompra.Text, mtbDataPagamento.Text);

                Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MensagemAviso();
        }

        private void TbValor_Leave(object sender, EventArgs e)
        {
            if (tbValor.Text != "")
                tbValor.Text = Convert.ToDouble(tbValor.Text).ToString("F");
        }

        private void TbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 08) && (e.KeyChar != 44)) || 
                ((tbValor.Text == "") && (e.KeyChar == 44) && ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 08))))
                e.Handled = true;
        }
    }
}
