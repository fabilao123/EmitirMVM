
namespace EmitirMVM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btPublicar = new System.Windows.Forms.Button();
            this.txtMvm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 69);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(449, 108);
            this.txtMensagem.TabIndex = 73;
            this.txtMensagem.Text = resources.GetString("txtMensagem.Text");
            // 
            // btPublicar
            // 
            this.btPublicar.Location = new System.Drawing.Point(359, 22);
            this.btPublicar.Name = "btPublicar";
            this.btPublicar.Size = new System.Drawing.Size(102, 23);
            this.btPublicar.TabIndex = 78;
            this.btPublicar.Text = "Publicar";
            this.btPublicar.UseVisualStyleBackColor = true;
            this.btPublicar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMvm
            // 
            this.txtMvm.Location = new System.Drawing.Point(12, 25);
            this.txtMvm.Name = "txtMvm";
            this.txtMvm.Size = new System.Drawing.Size(195, 20);
            this.txtMvm.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Numero do MVM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Mensagem ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 193);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 13);
            this.lblStatus.TabIndex = 82;
            this.lblStatus.Text = "Status Mensagem: ";
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIdResposta
            // 
            this.lblIdResposta.AutoSize = true;
            this.lblIdResposta.Location = new System.Drawing.Point(12, 217);
            this.lblIdResposta.Name = "lblIdResposta";
            this.lblIdResposta.Size = new System.Drawing.Size(70, 13);
            this.lblIdResposta.TabIndex = 83;
            this.lblIdResposta.Text = "Id Resposta: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdResposta);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMvm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btPublicar);
            this.Controls.Add(this.txtMensagem);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btPublicar;
        private System.Windows.Forms.TextBox txtMvm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdResposta;
    }
}