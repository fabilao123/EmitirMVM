using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EmitirMVM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clickService = new MVMCreate.MVMCreateClient();
            clickService.Open();

            var item = new MVMCreate.DadosMVM();
            item.Hash = txtHash.Text;
            item.Empresa = cmbCNPJ.SelectedItem.ToString().Substring(cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2, cmbCNPJ.SelectedItem.ToString().Length - (cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2));

            item.FornecedorEnvio = txtFornecedorEnvio.Text;
            item.Fornecedores = txtFornecedores.Text;
            item.FornecedorTransportadora = txtTransportadora.Text;
            item.NomeMotorista = txtNomeMotorista.Text;
            item.NumeroRGMotorista = txtRGMotorista.Text;
            item.NumeroCPFMotorista = txtCPFMotorista.Text;
            item.TipoCNHMotorista = cmbTipoCNH.SelectedItem.ToString();
            item.NumeroCNHMotorista = txtCNHMotorista.Text;
            item.DataValidadeCNHMotorista = dtValidadeCNH.Value.ToShortDateString();
            item.TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Substring(0, 2);
            item.DescricaoMarcaVeiculo = txtMarcaVeiculo.Text;
            item.NumeroPlacaVeiculo = txtPlacaveiculo.Text;
            item.NumeroPlacaCarreta = txtPlacacarreta.Text;
            item.QtdeAjudante = txtQtdeAjudante.Text;
            item.NumeroConhecimento = txtNumConhecimento.Text;
            item.Observacao = txtObservacao.Text;
            item.VlrTotalMercadorias = txtVlrTotalMercadorias.Text;
            item.PesoBruto = txtPesoBruto.Text;

            item.UsuarioCriacao = "WebService";

            var ListaItens = new List<string>();

            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var NF = Datarow.Cells[0].Value.ToString();
                    var Tipo = Datarow.Cells[1].Value.ToString();
                    ListaItens.Add(NF + Tipo.Substring(0, 1));
                }

            }
            string Resposta = clickService.EmitirMVM(item, ListaItens.ToArray());
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!"; 
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtChave.Text != "")
            {
                if (txtChave.Text.Where(c => char.IsLetter(c)).Count() == 0)
                {
                    if (txtChave.TextLength == 44)
                    {
                        string[] row = new string[] { txtChave.Text, cmbTipoNF.SelectedItem.ToString() };
                        dataGridView1.Rows.Add(row);
                        txtChave.Text = "";
                        txtChave.Focus();
                    }
                    else
                    {
                        txtChave.Focus();
                        MessageBox.Show("O Campo Chave Nota Fiscal é obrigatório ter 44 caracteres!");
                    }

                }
                else
                {
                    txtChave.Focus();
                    MessageBox.Show("Campo Chave Nota Fiscal só aceita numeros!");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            int LinhasTabela = dataGridView1.Rows.Count - 1;
            while (count < LinhasTabela)
            {
                dataGridView1.Rows.RemoveAt(0);
                count++;
            }

        }

        private void cmbCNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var clickService = new MVMCreate2.MVMCreateClient();
            clickService.Open();

            var item = new MVMCreate2.DadosMVM();
            item.Hash = txtHash.Text;
            item.Empresa = cmbCNPJ.SelectedItem.ToString().Substring(cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2, cmbCNPJ.SelectedItem.ToString().Length - (cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2));

            item.FornecedorEnvio = txtFornecedorEnvio.Text;
            item.Fornecedores = txtFornecedores.Text;
            item.FornecedorTransportadora = txtTransportadora.Text;
            item.NomeMotorista = txtNomeMotorista.Text;
            item.NumeroRGMotorista = txtRGMotorista.Text;
            item.NumeroCPFMotorista = txtCPFMotorista.Text;
            item.TipoCNHMotorista = cmbTipoCNH.SelectedItem.ToString();
            item.NumeroCNHMotorista = txtCNHMotorista.Text;
            item.DataValidadeCNHMotorista = dtValidadeCNH.Value.ToShortDateString();
            item.TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Substring(0, 2);
            item.DescricaoMarcaVeiculo = txtMarcaVeiculo.Text;
            item.NumeroPlacaVeiculo = txtPlacaveiculo.Text;
            item.NumeroPlacaCarreta = txtPlacacarreta.Text;
            item.QtdeAjudante = txtQtdeAjudante.Text;
            item.NumeroConhecimento = txtNumConhecimento.Text;
            item.Observacao = txtObservacao.Text;
            item.UsuarioCriacao = "WebService";

            var ListaItens = new List<string>();

            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var NF = Datarow.Cells[0].Value.ToString();
                    var Tipo = Datarow.Cells[1].Value.ToString();
                    ListaItens.Add(NF + Tipo.Substring(0, 1));
                }

            }
            string Resposta = clickService.EmitirMVM(item, ListaItens.ToArray());
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!";
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var clickService = new MVMServiceH.MVMCreateClient();
            clickService.Open();

            var item = new MVMServiceH.DadosMVM();
            item.Hash = txtHash.Text;
            item.Empresa = cmbCNPJ.SelectedItem.ToString().Substring(cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2, cmbCNPJ.SelectedItem.ToString().Length - (cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2));

            item.FornecedorEnvio = txtFornecedorEnvio.Text;
            item.Fornecedores = txtFornecedores.Text;
            item.FornecedorTransportadora = txtTransportadora.Text;
            item.NomeMotorista = txtNomeMotorista.Text;
            item.NumeroRGMotorista = txtRGMotorista.Text;
            item.NumeroCPFMotorista = txtCPFMotorista.Text;
            item.TipoCNHMotorista = cmbTipoCNH.SelectedItem.ToString();
            item.NumeroCNHMotorista = txtCNHMotorista.Text;
            item.DataValidadeCNHMotorista = dtValidadeCNH.Value.ToShortDateString();
            item.TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Substring(0, 2);
            item.DescricaoMarcaVeiculo = txtMarcaVeiculo.Text;
            item.NumeroPlacaVeiculo = txtPlacaveiculo.Text;
            item.NumeroPlacaCarreta = txtPlacacarreta.Text;
            item.QtdeAjudante = txtQtdeAjudante.Text;
            item.NumeroConhecimento = txtNumConhecimento.Text;
            item.Observacao = txtObservacao.Text;

            item.UsuarioCriacao = "WebService";

            var ListaItens = new List<string>();

            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var NF = Datarow.Cells[0].Value.ToString();
                    var Tipo = Datarow.Cells[1].Value.ToString();
                    ListaItens.Add(NF + Tipo.Substring(0, 1));
                }

            }
            string Resposta = clickService.EmitirMVM(item, ListaItens.ToArray());
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!";
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //char letra = Convert.ToChar(textBox1.Text);
            // int codigo = Convert.ToInt32(letra);
            //var teste = System.Text.Encoding.ASCII.GetBytes(textBox1.Text);
            //MessageBox.Show( ((char)teste).ToString());


            int unicode = 28;
            char character = (char)unicode;
            string readText = File.ReadAllText(@"C:\ETL\ELOG\Inbox\CJDB2B.ASN856-THTO191.20200129132106150");
            string text = readText.ToString().Replace(character, '|');
            foreach (var linha in text.Split('|'))
            {
                MessageBox.Show(linha);
            }
            MessageBox.Show(text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var clickService = new Int1.MVMCreateClient();
            clickService.Open();

            var item = new Int1.DadosMVM();
            item.Hash = txtHash.Text;
            item.Empresa = cmbCNPJ.SelectedItem.ToString().Substring(cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2, cmbCNPJ.SelectedItem.ToString().Length - (cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2));

            item.FornecedorEnvio = txtFornecedorEnvio.Text;
            item.Fornecedores = txtFornecedores.Text;
            item.FornecedorTransportadora = txtTransportadora.Text;
            item.NomeMotorista = txtNomeMotorista.Text;
            item.NumeroRGMotorista = txtRGMotorista.Text;
            item.NumeroCPFMotorista = txtCPFMotorista.Text;
            item.TipoCNHMotorista = cmbTipoCNH.SelectedItem.ToString();
            item.NumeroCNHMotorista = txtCNHMotorista.Text;
            item.DataValidadeCNHMotorista = dtValidadeCNH.Value.ToShortDateString();
            item.TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Substring(0, 2);
            item.DescricaoMarcaVeiculo = txtMarcaVeiculo.Text;
            item.NumeroPlacaVeiculo = txtPlacaveiculo.Text;
            item.NumeroPlacaCarreta = txtPlacacarreta.Text;
            item.QtdeAjudante = txtQtdeAjudante.Text;
            item.NumeroConhecimento = txtNumConhecimento.Text;
            item.Observacao = txtObservacao.Text;
            item.UsuarioCriacao = "WebService";

            var ListaItens = new List<string>();

            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var NF = Datarow.Cells[0].Value.ToString();
                    var Tipo = Datarow.Cells[1].Value.ToString();
                    ListaItens.Add(NF + Tipo.Substring(0, 1));
                }

            }
            string Resposta = clickService.EmitirMVM(item, ListaItens.ToArray());
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!";
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var clickService = new Int2.MVMCreateClient();
            clickService.Open();

            var item = new Int2.DadosMVM();
            item.Hash = txtHash.Text;
            item.Empresa = cmbCNPJ.SelectedItem.ToString().Substring(cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2, cmbCNPJ.SelectedItem.ToString().Length - (cmbCNPJ.SelectedItem.ToString().IndexOf('-') + 2));

            item.FornecedorEnvio = txtFornecedorEnvio.Text;
            item.Fornecedores = txtFornecedores.Text;
            item.FornecedorTransportadora = txtTransportadora.Text;
            item.NomeMotorista = txtNomeMotorista.Text;
            item.NumeroRGMotorista = txtRGMotorista.Text;
            item.NumeroCPFMotorista = txtCPFMotorista.Text;
            item.TipoCNHMotorista = cmbTipoCNH.SelectedItem.ToString();
            item.NumeroCNHMotorista = txtCNHMotorista.Text;
            item.DataValidadeCNHMotorista = dtValidadeCNH.Value.ToShortDateString();
            item.TipoVeiculo = cmbTipoVeiculo.SelectedItem.ToString().Substring(0, 2);
            item.DescricaoMarcaVeiculo = txtMarcaVeiculo.Text;
            item.NumeroPlacaVeiculo = txtPlacaveiculo.Text;
            item.NumeroPlacaCarreta = txtPlacacarreta.Text;
            item.QtdeAjudante = txtQtdeAjudante.Text;
            item.NumeroConhecimento = txtNumConhecimento.Text;
            item.Observacao = txtObservacao.Text;
            item.UsuarioCriacao = "WebService";

            var ListaItens = new List<string>();

            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    var NF = Datarow.Cells[0].Value.ToString();
                    var Tipo = Datarow.Cells[1].Value.ToString();
                    ListaItens.Add(NF + Tipo.Substring(0, 1));
                }

            }
            string Resposta = clickService.EmitirMVM(item, ListaItens.ToArray());
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!";
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));


        }

        private void button9_Click(object sender, EventArgs e)
        {
            //var MvmApiservice = new ServiceReference2.MvmSoapServiceClient();
            //MvmApiservice.Open();

            //MessageBox.Show(MvmApiservice.Metodo1());// .Open();

            var client = new ServiceReference2.MvmSoapServiceClient();
            var dados = new ServiceReference2.DadosMVM()
            {
                Hash = "3e7f17d1792ee2f3c4f2a0028b7cef5e",
                DataValidadeCNHMotorista = "15/07/2022",
                DescricaoMarcaVeiculo = "Fiat",
                Empresa = "1-1",
                FornecedorEnvio = "02990605000100",
                Fornecedores = "16701716002876,33171026001123", //41757527000223
                FornecedorTransportadora = "20468310000223",
                NomeMotorista = "David",
                NumeroCNHMotorista = "123456789",
                NumeroConhecimento = "55555",
                NumeroCPFMotorista = "31802156888",
                NumeroPlacaCarreta = "EEE-8888",
                NumeroPlacaVeiculo = "AAA-9999",
                NumeroRGMotorista = "888888",
                Observacao = "webserviceeee",
                PesoBruto = "1111",
                QtdeAjudante = "1",
                TipoCNHMotorista = "B",
                TipoVeiculo = "01",
                UsuarioCriacao = "dvd11",
                VlrTotalMercadorias = "99"
            };
            var nfs = new ServiceReference2.ArrayOfString() { "42345678901234567890123456789012345678904444V", "49345678901234567890123456789012345678904444V" };
            //Console.WriteLine(client.EmitirMVM(dados, nfs));
            //Console.WriteLine("FIM ");

            string Resposta = client.EmitirMVM(dados, nfs);
            if (Resposta.Contains("OK-"))
                lblResposta.Text = "MVM: " + Resposta.Replace("OK-", "") + " criado com sucesso!";
            else
                MessageBox.Show(Resposta.Replace("|", "\n"));
        }
    }
}
