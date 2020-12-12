namespace fazan
{
    partial class MainForm
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
            this.txtContinuationWord = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnBlocat = new System.Windows.Forms.Button();
            this.txtFazan = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtImportantWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContinuationWord
            // 
            this.txtContinuationWord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContinuationWord.Location = new System.Drawing.Point(222, 156);
            this.txtContinuationWord.Multiline = true;
            this.txtContinuationWord.Name = "txtContinuationWord";
            this.txtContinuationWord.Size = new System.Drawing.Size(192, 50);
            this.txtContinuationWord.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(25, 166);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(107, 26);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input text";
            // 
            // btnBlocat
            // 
            this.btnBlocat.Location = new System.Drawing.Point(190, 220);
            this.btnBlocat.Name = "btnBlocat";
            this.btnBlocat.Size = new System.Drawing.Size(224, 39);
            this.btnBlocat.TabIndex = 3;
            this.btnBlocat.Text = "M-am blocat";
            this.btnBlocat.UseVisualStyleBackColor = true;
            // 
            // txtFazan
            // 
            this.txtFazan.Enabled = false;
            this.txtFazan.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFazan.ForeColor = System.Drawing.Color.Red;
            this.txtFazan.Location = new System.Drawing.Point(222, 95);
            this.txtFazan.Name = "txtFazan";
            this.txtFazan.Size = new System.Drawing.Size(155, 36);
            this.txtFazan.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(420, 156);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Trimite raspuns";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtImportantWord
            // 
            this.txtImportantWord.Enabled = false;
            this.txtImportantWord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportantWord.ForeColor = System.Drawing.Color.Red;
            this.txtImportantWord.Location = new System.Drawing.Point(143, 156);
            this.txtImportantWord.Multiline = true;
            this.txtImportantWord.Name = "txtImportantWord";
            this.txtImportantWord.Size = new System.Drawing.Size(73, 50);
            this.txtImportantWord.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FAZAN ";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(283, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 29);
            this.txtPort.TabIndex = 34;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(79, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(146, 29);
            this.txtHost.TabIndex = 33;
            this.txtHost.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(231, 15);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 22);
            this.lblPort.TabIndex = 32;
            this.lblPort.Text = "Port";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(13, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(49, 22);
            this.lblHost.TabIndex = 31;
            this.lblHost.Text = "Host";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(420, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 29);
            this.btnConnect.TabIndex = 35;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 316);
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContinuationWord;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnBlocat;
        private System.Windows.Forms.TextBox txtFazan;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtImportantWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnConnect;
    }
}

