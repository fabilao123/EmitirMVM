namespace EmitirMVM
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbTipoNF = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCNPJ = new System.Windows.Forms.ComboBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtValidadeCNH = new System.Windows.Forms.DateTimePicker();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumConhecimento = new System.Windows.Forms.TextBox();
            this.txtQtdeAjudante = new System.Windows.Forms.TextBox();
            this.txtPlacaveiculo = new System.Windows.Forms.TextBox();
            this.txtPlacacarreta = new System.Windows.Forms.TextBox();
            this.txtMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCNHMotorista = new System.Windows.Forms.TextBox();
            this.cmbTipoCNH = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPFMotorista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRGMotorista = new System.Windows.Forms.TextBox();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.txtTransportadora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedorEnvio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtVlrTotalMercadorias = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 90;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 355);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 89;
            this.label20.Text = "Tipo da Nota Fiscal";
            // 
            // cmbTipoNF
            // 
            this.cmbTipoNF.FormattingEnabled = true;
            this.cmbTipoNF.Items.AddRange(new object[] {
            "V - Venda",
            "E - Vasilhame",
            "A - Retorno de Armazenagem",
            "G - Garantia",
            "I - Insumo (CFOP: 5902, 6902, 5924, 6924, 5925, 6925)",
            "M - Retorno de Industrialização (CFOP: 5903, 6903)",
            "P - Protótipo",
            "R - Remessa Teste"});
            this.cmbTipoNF.Location = new System.Drawing.Point(310, 371);
            this.cmbTipoNF.Name = "cmbTipoNF";
            this.cmbTipoNF.Size = new System.Drawing.Size(199, 21);
            this.cmbTipoNF.TabIndex = 76;
            this.cmbTipoNF.Text = "V - Venda";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 355);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Chave Nota Fiscal";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(12, 371);
            this.txtChave.MaxLength = 44;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(292, 20);
            this.txtChave.TabIndex = 73;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NF,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 115);
            this.dataGridView1.TabIndex = 87;
            // 
            // NF
            // 
            this.NF.HeaderText = "Nota Fiscal";
            this.NF.Name = "NF";
            this.NF.Width = 270;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // cmbCNPJ
            // 
            this.cmbCNPJ.FormattingEnabled = true;
            this.cmbCNPJ.Items.AddRange(new object[] {
            "Fiat Automoveis - 1-1",
            "FPT Fire - 10-10",
            "FPT Mecânica - 012-1",
            "Fiat Pernambuco - 191-1",
            "FPT Campo Largo - 595-1"});
            this.cmbCNPJ.Location = new System.Drawing.Point(12, 73);
            this.cmbCNPJ.Name = "cmbCNPJ";
            this.cmbCNPJ.Size = new System.Drawing.Size(123, 21);
            this.cmbCNPJ.TabIndex = 86;
            this.cmbCNPJ.Text = "Fiat Automoveis - 1-1";
            this.cmbCNPJ.SelectedIndexChanged += new System.EventHandler(this.cmbCNPJ_SelectedIndexChanged);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(427, 76);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(427, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Resposta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Desenv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtValidadeCNH
            // 
            this.dtValidadeCNH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtValidadeCNH.Location = new System.Drawing.Point(623, 203);
            this.dtValidadeCNH.Name = "dtValidadeCNH";
            this.dtValidadeCNH.Size = new System.Drawing.Size(195, 20);
            this.dtValidadeCNH.TabIndex = 61;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 320);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(806, 20);
            this.txtObservacao.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "Observação";
            // 
            // txtNumConhecimento
            // 
            this.txtNumConhecimento.Location = new System.Drawing.Point(217, 281);
            this.txtNumConhecimento.Name = "txtNumConhecimento";
            this.txtNumConhecimento.Size = new System.Drawing.Size(195, 20);
            this.txtNumConhecimento.TabIndex = 70;
            this.txtNumConhecimento.Text = "0";
            // 
            // txtQtdeAjudante
            // 
            this.txtQtdeAjudante.Location = new System.Drawing.Point(12, 281);
            this.txtQtdeAjudante.Name = "txtQtdeAjudante";
            this.txtQtdeAjudante.Size = new System.Drawing.Size(195, 20);
            this.txtQtdeAjudante.TabIndex = 68;
            this.txtQtdeAjudante.Text = "0";
            // 
            // txtPlacaveiculo
            // 
            this.txtPlacaveiculo.Location = new System.Drawing.Point(418, 242);
            this.txtPlacaveiculo.Name = "txtPlacaveiculo";
            this.txtPlacaveiculo.Size = new System.Drawing.Size(195, 20);
            this.txtPlacaveiculo.TabIndex = 65;
            this.txtPlacaveiculo.Text = "AAA3333";
            // 
            // txtPlacacarreta
            // 
            this.txtPlacacarreta.Location = new System.Drawing.Point(623, 242);
            this.txtPlacacarreta.Name = "txtPlacacarreta";
            this.txtPlacacarreta.Size = new System.Drawing.Size(195, 20);
            this.txtPlacacarreta.TabIndex = 66;
            // 
            // txtMarcaVeiculo
            // 
            this.txtMarcaVeiculo.Location = new System.Drawing.Point(217, 241);
            this.txtMarcaVeiculo.Name = "txtMarcaVeiculo";
            this.txtMarcaVeiculo.Size = new System.Drawing.Size(195, 20);
            this.txtMarcaVeiculo.TabIndex = 63;
            this.txtMarcaVeiculo.Text = "Fiat";
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Items.AddRange(new object[] {
            "01 - TOCO",
            "02 - TOCO-BAU",
            "03 - TK",
            "04 - TK-BAU",
            "05 - CARRETA - 1 EIXO",
            "06 - CARREGA - 2 EIXOS",
            "07 - CARRETA - 3 EIXOS",
            "08 - PRANCHA",
            "09 - AUTOMOVEL",
            "10 - KOMBI",
            "11 - KOMBI PICK-UP",
            "12 - FIORINO",
            "13 - CAMINHONETE",
            "14 - CAMINHAO 3/4",
            "15 - OUTROS",
            "16 - FURGAO"});
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(12, 241);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(195, 21);
            this.cmbTipoVeiculo.TabIndex = 62;
            this.cmbTipoVeiculo.Text = "01 - TOCO";
            // 
            // txtCNHMotorista
            // 
            this.txtCNHMotorista.Location = new System.Drawing.Point(418, 203);
            this.txtCNHMotorista.Name = "txtCNHMotorista";
            this.txtCNHMotorista.Size = new System.Drawing.Size(195, 20);
            this.txtCNHMotorista.TabIndex = 59;
            this.txtCNHMotorista.Text = "05175268136";
            // 
            // cmbTipoCNH
            // 
            this.cmbTipoCNH.FormattingEnabled = true;
            this.cmbTipoCNH.Items.AddRange(new object[] {
            "A",
            "AB",
            "AC",
            "AD",
            "AE",
            "B",
            "C",
            "D",
            "E"});
            this.cmbTipoCNH.Location = new System.Drawing.Point(217, 202);
            this.cmbTipoCNH.Name = "cmbTipoCNH";
            this.cmbTipoCNH.Size = new System.Drawing.Size(195, 21);
            this.cmbTipoCNH.TabIndex = 57;
            this.cmbTipoCNH.Text = "A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Num. Conhecimento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Qtde Ajudantes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(620, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Placa da Carreta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Placa do Veiculo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Marca do Veiculo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Tipo de Veiculo";
            // 
            // txtCPFMotorista
            // 
            this.txtCPFMotorista.Location = new System.Drawing.Point(12, 203);
            this.txtCPFMotorista.Name = "txtCPFMotorista";
            this.txtCPFMotorista.Size = new System.Drawing.Size(195, 20);
            this.txtCPFMotorista.TabIndex = 55;
            this.txtCPFMotorista.Text = "11775756637";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Data Validade da CNH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "CNH do Motorista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Tipo CNH do Motorista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "CPF Motorista";
            // 
            // txtRGMotorista
            // 
            this.txtRGMotorista.Location = new System.Drawing.Point(623, 164);
            this.txtRGMotorista.Name = "txtRGMotorista";
            this.txtRGMotorista.Size = new System.Drawing.Size(195, 20);
            this.txtRGMotorista.TabIndex = 54;
            this.txtRGMotorista.Text = "11775756";
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Location = new System.Drawing.Point(421, 164);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(195, 20);
            this.txtNomeMotorista.TabIndex = 52;
            this.txtNomeMotorista.Text = "RAFAEL LUCAS COELHO";
            // 
            // txtTransportadora
            // 
            this.txtTransportadora.Location = new System.Drawing.Point(12, 164);
            this.txtTransportadora.Name = "txtTransportadora";
            this.txtTransportadora.Size = new System.Drawing.Size(400, 20);
            this.txtTransportadora.TabIndex = 51;
            this.txtTransportadora.Text = "09174577000194";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "RG Motorista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Nome Motorista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Transportadora";
            // 
            // txtFornecedorEnvio
            // 
            this.txtFornecedorEnvio.Location = new System.Drawing.Point(418, 125);
            this.txtFornecedorEnvio.Name = "txtFornecedorEnvio";
            this.txtFornecedorEnvio.Size = new System.Drawing.Size(400, 20);
            this.txtFornecedorEnvio.TabIndex = 49;
            this.txtFornecedorEnvio.Text = "41757527000142";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fornecedor Envio";
            // 
            // txtFornecedores
            // 
            this.txtFornecedores.Location = new System.Drawing.Point(12, 125);
            this.txtFornecedores.Name = "txtFornecedores";
            this.txtFornecedores.Size = new System.Drawing.Size(400, 20);
            this.txtFornecedores.TabIndex = 48;
            this.txtFornecedores.Text = "41757527000142";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Fornecedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Empresa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 91;
            this.label21.Text = "Hash de autenticação";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(12, 25);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(400, 20);
            this.txtHash.TabIndex = 92;
            this.txtHash.Text = "3798dc077cd2860a112587e9cf65b652";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 93;
            this.button4.Text = "Homologação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(310, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 94;
            this.button5.Text = "Produção";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtVlrTotalMercadorias
            // 
            this.txtVlrTotalMercadorias.Location = new System.Drawing.Point(418, 281);
            this.txtVlrTotalMercadorias.Name = "txtVlrTotalMercadorias";
            this.txtVlrTotalMercadorias.Size = new System.Drawing.Size(195, 20);
            this.txtVlrTotalMercadorias.TabIndex = 95;
            this.txtVlrTotalMercadorias.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(415, 265);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 13);
            this.label22.TabIndex = 96;
            this.label22.Text = "Vlr Total Mervadorias";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(622, 281);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(195, 20);
            this.txtPesoBruto.TabIndex = 97;
            this.txtPesoBruto.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(620, 265);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Peso Bruto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 99;
            this.textBox1.Text = "3798dc077cd2860a112587e9cf65b652";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(541, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 100;
            this.button6.Text = "Desenv";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(310, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 101;
            this.button7.Text = "Produção 1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(309, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 23);
            this.button8.TabIndex = 102;
            this.button8.Text = "Produção 2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(698, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 103;
            this.button9.Text = "Desenv";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 557);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPesoBruto);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtVlrTotalMercadorias);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbTipoNF);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCNPJ);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtValidadeCNH);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNumConhecimento);
            this.Controls.Add(this.txtQtdeAjudante);
            this.Controls.Add(this.txtPlacaveiculo);
            this.Controls.Add(this.txtPlacacarreta);
            this.Controls.Add(this.txtMarcaVeiculo);
            this.Controls.Add(this.cmbTipoVeiculo);
            this.Controls.Add(this.txtCNHMotorista);
            this.Controls.Add(this.cmbTipoCNH);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCPFMotorista);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRGMotorista);
            this.Controls.Add(this.txtNomeMotorista);
            this.Controls.Add(this.txtTransportadora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFornecedorEnvio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Criar MVM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbTipoNF;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.ComboBox cmbCNPJ;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtValidadeCNH;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumConhecimento;
        private System.Windows.Forms.TextBox txtQtdeAjudante;
        private System.Windows.Forms.TextBox txtPlacaveiculo;
        private System.Windows.Forms.TextBox txtPlacacarreta;
        private System.Windows.Forms.TextBox txtMarcaVeiculo;
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.TextBox txtCNHMotorista;
        private System.Windows.Forms.ComboBox cmbTipoCNH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPFMotorista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRGMotorista;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.TextBox txtTransportadora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFornecedorEnvio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtVlrTotalMercadorias;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

