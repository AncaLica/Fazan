namespace fazan
{
    partial class reguliJoc
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "REGULAMENT:",
            "",
            "1.Primul jucător alege o literă, după care trimite un cuvânt ce începe cu litera " +
                "respectivă.",
            "",
            "2.Următorul jucător va alege un cuvânt ce începe cu ultimele două litere din cuvâ" +
                "ntul jucătorului pr$",
            "",
            "3.Nu sunt acceptate substantive proprii sau la forma plural.",
            "",
            "4.Când un jucător este blocat, nu mai găseşte un cuvânt sau cuvantul trimis de ac" +
                "esta nu face parte ",
            "5.Ultimul jucător rămas în joc câştigă."});
            this.listBox1.Location = new System.Drawing.Point(32, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 368);
            this.listBox1.TabIndex = 0;
            // 
            // reguliJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 445);
            this.Controls.Add(this.listBox1);
            this.Name = "reguliJoc";
            this.Text = "reguliJoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}