namespace Server
{
    partial class MainFormServer
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtImportantWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFazan = new System.Windows.Forms.TextBox();
            this.btnBlocat = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtContinuationWord = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "FAZAN ";
            // 
            // txtImportantWord
            // 
            this.txtImportantWord.Enabled = false;
            this.txtImportantWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportantWord.ForeColor = System.Drawing.Color.Red;
            this.txtImportantWord.Location = new System.Drawing.Point(138, 177);
            this.txtImportantWord.Multiline = true;
            this.txtImportantWord.Name = "txtImportantWord";
            this.txtImportantWord.Size = new System.Drawing.Size(73, 50);
            this.txtImportantWord.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(415, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 50);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Trimite raspuns";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFazan
            // 
            this.txtFazan.Enabled = false;
            this.txtFazan.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFazan.ForeColor = System.Drawing.Color.Red;
            this.txtFazan.Location = new System.Drawing.Point(217, 116);
            this.txtFazan.Name = "txtFazan";
            this.txtFazan.Size = new System.Drawing.Size(155, 36);
            this.txtFazan.TabIndex = 13;
            // 
            // btnBlocat
            // 
            this.btnBlocat.Location = new System.Drawing.Point(185, 241);
            this.btnBlocat.Name = "btnBlocat";
            this.btnBlocat.Size = new System.Drawing.Size(224, 39);
            this.btnBlocat.TabIndex = 12;
            this.btnBlocat.Text = "M-am blocat";
            this.btnBlocat.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(20, 187);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(107, 26);
            this.lblInput.TabIndex = 11;
            this.lblInput.Text = "Input text";
            // 
            // txtContinuationWord
            // 
            this.txtContinuationWord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContinuationWord.Location = new System.Drawing.Point(217, 177);
            this.txtContinuationWord.Multiline = true;
            this.txtContinuationWord.Name = "txtContinuationWord";
            this.txtContinuationWord.Size = new System.Drawing.Size(192, 50);
            this.txtContinuationWord.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(431, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 29);
            this.btnConnect.TabIndex = 40;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(294, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 29);
            this.txtPort.TabIndex = 39;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(90, 32);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(146, 29);
            this.txtHost.TabIndex = 38;
            this.txtHost.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(242, 35);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 22);
            this.lblPort.TabIndex = 37;
            this.lblPort.Text = "Port";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(24, 35);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(49, 22);
            this.lblHost.TabIndex = 36;
            this.lblHost.Text = "Host";
            // 
            // MainFormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 367);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImportantWord);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFazan);
            this.Controls.Add(this.btnBlocat);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtContinuationWord);
            this.Name = "MainFormServer";
            this.Text = "Client from Server";
            this.Load += new System.EventHandler(this.MainFormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImportantWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFazan;
        private System.Windows.Forms.Button btnBlocat;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtContinuationWord;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHost;
    }
}