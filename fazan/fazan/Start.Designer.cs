namespace fazan
{
    partial class Start
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
            this.btnReguli = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnStartJoc = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReguli
            // 
            this.btnReguli.Location = new System.Drawing.Point(153, 12);
            this.btnReguli.Name = "btnReguli";
            this.btnReguli.Size = new System.Drawing.Size(123, 42);
            this.btnReguli.TabIndex = 22;
            this.btnReguli.Text = "reguli joc";
            this.btnReguli.UseVisualStyleBackColor = true;
            this.btnReguli.Click += new System.EventHandler(this.btnReguli_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(123, 42);
            this.btnInfo.TabIndex = 21;
            this.btnInfo.Text = "info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnStartJoc
            // 
            this.btnStartJoc.Location = new System.Drawing.Point(182, 213);
            this.btnStartJoc.Name = "btnStartJoc";
            this.btnStartJoc.Size = new System.Drawing.Size(181, 65);
            this.btnStartJoc.TabIndex = 23;
            this.btnStartJoc.Text = "Start Joc";
            this.btnStartJoc.UseVisualStyleBackColor = true;
            this.btnStartJoc.Click += new System.EventHandler(this.btnStartJoc_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 168);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 26);
            this.txtName.TabIndex = 24;
            this.txtName.Text = "Player1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Numele tau";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 360);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStartJoc);
            this.Controls.Add(this.btnReguli);
            this.Controls.Add(this.btnInfo);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReguli;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnStartJoc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}