
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btPublicar = new System.Windows.Forms.Button();
            this.txtMvm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdResposta = new System.Windows.Forms.Label();
            this.btSelectFiles = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(11, 80);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(479, 87);
            this.txtMensagem.TabIndex = 73;
            // 
            // btPublicar
            // 
            this.btPublicar.Location = new System.Drawing.Point(408, 28);
            this.btPublicar.Name = "btPublicar";
            this.btPublicar.Size = new System.Drawing.Size(82, 23);
            this.btPublicar.TabIndex = 78;
            this.btPublicar.Text = "Publicar";
            this.btPublicar.UseVisualStyleBackColor = true;
            this.btPublicar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMvm
            // 
            this.txtMvm.Location = new System.Drawing.Point(12, 30);
            this.txtMvm.Name = "txtMvm";
            this.txtMvm.Size = new System.Drawing.Size(164, 20);
            this.txtMvm.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Numero do MVM";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(11, 64);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 81;
            this.lblFile.Text = "File";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 182);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 13);
            this.lblStatus.TabIndex = 82;
            this.lblStatus.Text = "Status Mensagem: ";
            // 
            // lblIdResposta
            // 
            this.lblIdResposta.AutoSize = true;
            this.lblIdResposta.Location = new System.Drawing.Point(8, 209);
            this.lblIdResposta.Name = "lblIdResposta";
            this.lblIdResposta.Size = new System.Drawing.Size(70, 13);
            this.lblIdResposta.TabIndex = 83;
            this.lblIdResposta.Text = "Id Resposta: ";
            // 
            // btSelectFiles
            // 
            this.btSelectFiles.Location = new System.Drawing.Point(180, 28);
            this.btSelectFiles.Name = "btSelectFiles";
            this.btSelectFiles.Size = new System.Drawing.Size(135, 23);
            this.btSelectFiles.TabIndex = 84;
            this.btSelectFiles.Text = "Selecionar Arquivos";
            this.btSelectFiles.UseVisualStyleBackColor = true;
            this.btSelectFiles.Click += new System.EventHandler(this.btSelectFiles_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(320, 33);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(16, 13);
            this.lblLista.TabIndex = 85;
            this.lblLista.Text = "...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 246);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btSelectFiles);
            this.Controls.Add(this.lblIdResposta);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtMvm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btPublicar);
            this.Controls.Add(this.txtMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes MVM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btPublicar;
        private System.Windows.Forms.TextBox txtMvm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdResposta;
        private System.Windows.Forms.Button btSelectFiles;
        private System.Windows.Forms.Label lblLista;
    }
}