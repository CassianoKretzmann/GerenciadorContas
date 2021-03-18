using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Data;

namespace ContasPagarXML
{
    class XMLContasPagar
    {
        private int codigoconta;

        private double _valorTotal;
        public double valorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        private IEnumerable<XElement> _contaXML;
        public IEnumerable<XElement> contaXML
        {
            get { return _contaXML; }
            set { _contaXML = value; }
        }

        private enum situacoes
        {
            Paga,
            Pendente,
            Vencida
        }

        //Seta situação da conta;
        public string SetaSituacao(string dataCompra, string dataVencimento, string dataPagamento)
        {
            string situacao = string.Empty;
            if ((dataVencimento != "  /  /") && (DateTime.Now.Date > Convert.ToDateTime(dataVencimento)) && (dataPagamento == "  /  /"))
            {
                situacao = situacoes.Vencida.ToString();
            }
            else if (dataPagamento != "  /  /")
            {
                situacao = situacoes.Paga.ToString();
            }
            else
            {
                situacao = situacoes.Pendente.ToString();
            }
            return situacao;
        }

        //Criação de um novo XML de contas;
        public void CriarNovoArquivoContas(string caminho)
        {
            if (File.Exists(caminho))
                throw new Exception();

            XmlTextWriter xtw = new XmlTextWriter(caminho, Encoding.UTF8);

            xtw.WriteStartDocument();
            xtw.WriteStartElement("Contas");
            xtw.WriteEndElement();
            xtw.Close();
        }
          
        //Insere uma nova conta em um XML existente;
        public void InserirNovaConta(string caminho, string valor, string codFormaPagamento, string formaPagamento,
            string descricao, string dataVencimento, string dataCompra, string dataPagamento)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            //Seta o codigo unico para a conta
            XmlNodeList elemList = xmldoc.GetElementsByTagName("Conta");

            if (elemList.Count > 0)
            {
                codigoconta = Convert.ToInt32(elemList[elemList.Count - 1].Attributes["Codigo"].Value) + 1;
            }
            else
            {
                codigoconta = 1;
            }

            //Cria um novo nó
            XmlElement novaConta = xmldoc.CreateElement("Conta");
            XmlElement xmlCodigoConta = xmldoc.CreateElement("CodigoConta");
            XmlElement xmlValor = xmldoc.CreateElement("Valor");
            XmlElement xmlFormaPagamento = xmldoc.CreateElement("FormaPagamento");
            XmlElement xmlDescricaoConta = xmldoc.CreateElement("DescricaoConta");
            XmlElement xmlDataVencimento = xmldoc.CreateElement("DataVencimento");
            XmlElement xmlDataCompra = xmldoc.CreateElement("DataCompra");
            XmlElement xmlDataPagamento = xmldoc.CreateElement("DataPagamento");
            XmlElement xmlSituacao = xmldoc.CreateElement("Situacao");

            novaConta.SetAttribute(name: "Codigo", codigoconta.ToString());
            xmlCodigoConta.InnerText = (codigoconta.ToString());
            xmlValor.InnerText = valor;
            xmlFormaPagamento.SetAttribute(name: "Codigo", codFormaPagamento);
            xmlFormaPagamento.InnerText = formaPagamento;
            xmlDescricaoConta.InnerText = descricao;
            xmlDataVencimento.InnerText = dataVencimento;
            xmlDataCompra.InnerText = dataCompra;
            xmlDataPagamento.InnerText = dataPagamento;
            xmlSituacao.InnerText = SetaSituacao(dataCompra, dataVencimento, dataPagamento);

            novaConta.AppendChild(xmlCodigoConta);
            novaConta.AppendChild(xmlValor);
            novaConta.AppendChild(xmlFormaPagamento);
            novaConta.AppendChild(xmlDescricaoConta);
            novaConta.AppendChild(xmlDataVencimento);
            novaConta.AppendChild(xmlDataCompra);
            novaConta.AppendChild(xmlDataPagamento);
            novaConta.AppendChild(xmlSituacao);

            xmldoc.DocumentElement.AppendChild(novaConta);
            xmldoc.Save(caminho);
        }

        //Carrega as informações do XML selecionado, retornando um table para ser usado na grid de exibição;
        public DataTable CarregarInformacoesXML(string caminho)
        {
            //Carrega o arquivo selecionado;
            StreamReader sr = File.OpenText(caminho);
            string _stringXML = sr.ReadToEnd();
            sr.Close();

            _stringXML = _stringXML.Replace("\n", "");
            _stringXML = _stringXML.Replace("\r", "");

            XDocument doc = XDocument.Parse(_stringXML);

            //Cria uma tabela com as infos do arquivo
            DataTable tabela = new DataTable();

            tabela.Columns.Add("Codigo da Conta", typeof(string));
            tabela.Columns.Add("Valor", typeof(string));
            tabela.Columns.Add("Forma de Pagamento", typeof(string));
            tabela.Columns.Add("Descricao da Conta", typeof(string));
            tabela.Columns.Add("Data de Vencimento", typeof(string));
            tabela.Columns.Add("Data da Compra", typeof(string));
            tabela.Columns.Add("Data de Pagamento", typeof(string));
            tabela.Columns.Add("Situacao", typeof(string));

            //Cria as linhas da tabela
            DataRow tableLine;

            foreach (var elemXML in doc.Root.Elements("Conta"))
            {
                tableLine = tabela.NewRow();

                tableLine["Codigo da Conta"] = GetValueOrDefault(elemXML.Element("CodigoConta"));
                tableLine["Valor"] = GetValueOrDefault(elemXML.Element("Valor"));
                tableLine["Forma de Pagamento"] = GetValueOrDefault(elemXML.Element("FormaPagamento"));
                tableLine["Descricao da Conta"] = GetValueOrDefault(elemXML.Element("DescricaoConta"));
                tableLine["Data de Vencimento"] = GetValueOrDefault(elemXML.Element("DataVencimento"));
                tableLine["Data da Compra"] = GetValueOrDefault(elemXML.Element("DataCompra"));
                tableLine["Data de Pagamento"] = GetValueOrDefault(elemXML.Element("DataPagamento"));

                //Atualiza a situação do elemento;
                elemXML.Element("Situacao").Value = SetaSituacao(tableLine["Data da Compra"].ToString(),
                    tableLine["Data de Vencimento"].ToString(), tableLine["Data de Pagamento"].ToString());
                tableLine["Situacao"] = elemXML.Element("Situacao").Value;

                tabela.Rows.Add(tableLine);
            }

            //Propriedade de valor total
            _valorTotal = CalcularValorTotalContas(tabela);

            //Salva por conta da situação que pode ter mudado;
            doc.Save(caminho);
            return tabela;
        }

        //Calcula o valor total dos resgistros da grid
        public double CalcularValorTotalContas(DataTable tabelaContas)
        {
            double valores = 0;
            foreach (DataRow valor in tabelaContas.AsEnumerable())
            {
                 valores += Convert.ToDouble(valor.Field<string>("Valor"));
            }

            return valores;
        }

        public IEnumerable<XElement> PegaContaEdicaoXML(string caminho, string codigoConta)
        {
            if (codigoConta != null)
            {
                StreamReader sr = File.OpenText(caminho);
                string _stringXML = sr.ReadToEnd();
                sr.Close();

                _stringXML = _stringXML.Replace("\n", "");
                _stringXML = _stringXML.Replace("\r", "");

                XDocument doc = XDocument.Parse(_stringXML);

                var conta = from node in doc.Descendants("Conta")
                            let attr = node.Attribute("Codigo")
                            where attr != null && attr.Value == codigoConta
                            select node;

                return conta;
            }
            return null;
        }

        //Atualiza a conta com as informações editadas;
        public void EditaContaXML(string codigoConta, string caminho, string valor, string codFormaPagamento, string formaPagamento,
            string descricao, string dataVencimento, string dataCompra, string dataPagamento)
        {
            StreamReader sr = File.OpenText(caminho);
            string _stringXML = sr.ReadToEnd();
            sr.Close();

            _stringXML = _stringXML.Replace("\n", "");
            _stringXML = _stringXML.Replace("\r", "");

            XDocument doc = XDocument.Parse(_stringXML);

            var conta = from node in doc.Descendants("Conta")
                        let attr = node.Attribute("Codigo")
                        where attr != null && attr.Value == codigoConta
                        select node;

            conta.ToList().ElementAt(0).Element("Valor").Value = valor;
            conta.ToList().ElementAt(0).Element("FormaPagamento").Attribute("Codigo").Value = codFormaPagamento;
            conta.ToList().ElementAt(0).Element("FormaPagamento").Value = formaPagamento;
            conta.ToList().ElementAt(0).Element("DescricaoConta").Value = descricao;
            conta.ToList().ElementAt(0).Element("DataCompra").Value = dataCompra;
            conta.ToList().ElementAt(0).Element("DataVencimento").Value = dataVencimento;
            conta.ToList().ElementAt(0).Element("DataPagamento").Value = dataPagamento;
            conta.ToList().ElementAt(0).Element("Situacao").Value = SetaSituacao(dataCompra, dataVencimento, dataPagamento);

            doc.Save(caminho);
        }

        //Remove a conta selecionada na grid
        public void RemoveContaXML(string caminho, string codigoConta)
        {
            if (codigoConta != null)
            {
                StreamReader sr = File.OpenText(caminho);
                string _stringXML = sr.ReadToEnd();
                sr.Close();

                _stringXML = _stringXML.Replace("\n", "");
                _stringXML = _stringXML.Replace("\r", "");

                XDocument doc = XDocument.Parse(_stringXML);

                var conta = from node in doc.Descendants("Conta")
                        let attr = node.Attribute("Codigo")
                        where attr != null && attr.Value == codigoConta
                        select node;
                conta.ToList().ForEach(x => x.Remove());

                doc.Save(caminho);
            }
        }

        //Retorna o value do elemento do arquivo ou um valor padrão vazio;
        private static string GetValueOrDefault(XElement xElement)
        {
            if (xElement != null)
                return xElement.Value;

            return string.Empty;
        }
    }
}
