using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmitirMVM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();


        private void button2_Click(object sender, EventArgs e)
        {
            btPublicar.Enabled = false;
            btSelectFiles.Enabled = false;
            txtMvm.Enabled = false;
            if (!String.IsNullOrEmpty(txtMvm.Text))
            {
                if (ofd.FileNames.Length > 0)
                {

                    foreach (String arquivo in ofd.FileNames)
                    {
                        lblFile.Text = "File: " + arquivo;
                        txtMensagem.Text = File.ReadAllText(@arquivo);
                        lblStatus.Text = "Status Mensagem : ";
                        lblIdResposta.Text = "Id Resposta: ";

                        if (txtMvm.Text.Length > 0)
                            txtMensagem.Text = txtMensagem.Text.StartsWith("T321400") || txtMensagem.Text.StartsWith("T331400") ?
                                txtMensagem.Text.Replace(txtMensagem.Text.Substring(228, 8), txtMvm.Text) :
                                txtMensagem.Text.Replace(txtMensagem.Text.Substring(211, 8), txtMvm.Text);

                        //return;
                        string topicArn = "arn:aws:sns:us-east-1:234061357661:import-return-s746_topic_mq_nonprod_master";
                        string message = txtMensagem.Text;

                        var client = new AmazonSimpleNotificationServiceClient(region: Amazon.RegionEndpoint.USEast1);

                        var request = new PublishRequest
                        {
                            Message = message,
                            TopicArn = topicArn
                        };

                        try
                        {
                            btPublicar.Text = "Publicando...";
                            var response = client.Publish(request);

                            //Console.WriteLine("Message sent to topic:");
                            //Console.WriteLine(message);
                            btPublicar.Text = "Publicar";
                            lblStatus.Text = lblStatus.Text + response.HttpStatusCode;
                            lblIdResposta.Text = lblIdResposta.Text + response.MessageId;
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine("Caught exception publishing request:");
                            //Console.WriteLine(ex.Message);
                            btPublicar.Text = "Publicar";
                            lblStatus.Text = lblStatus.Text + "Erro";
                            lblIdResposta.Text = lblIdResposta.Text + ex.Message;                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione ao menos um arquivo.");
                }
            }
            else
            {
                MessageBox.Show("Informe o número do MVM");
                txtMvm.Focus();
            }

            lblFile.Text = "File";
            //txtMensagem.Text = "";
            btPublicar.Enabled = true;
            btSelectFiles.Enabled = true;
            txtMvm.Enabled = true;
        }

        private void btSelectFiles_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblLista.Text = ofd.FileNames.Length.ToString().Trim() + " arquivo(s).";
            }
            else
            {
                lblLista.Text = "...";
            }
        }
    }
}
