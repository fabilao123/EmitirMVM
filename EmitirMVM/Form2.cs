using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (btPublicar.Text == "Publicar")
            {
                lblStatus.Text = "Status Mensagem : ";
                lblIdResposta.Text = "Id Resposta: " ;

                if (txtMvm.Text.Length > 0)
                    txtMensagem.Text = txtMensagem.Text.StartsWith("T321400") || txtMensagem.Text.StartsWith("T331400") ? 
                        txtMensagem.Text.Replace(txtMensagem.Text.Substring(228, 8), txtMvm.Text) :
                        txtMensagem.Text.Replace(txtMensagem.Text.Substring(211, 8), txtMvm.Text);

                //return;
                string topicArn = "arn:aws:sns:us-east-1:234061357661:import-return-s746_topic_mq";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
