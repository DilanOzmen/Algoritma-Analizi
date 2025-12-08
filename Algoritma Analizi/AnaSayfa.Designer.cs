namespace Algoritma_Analizi
{
    partial class AnaSayfa
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
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(651, 24);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(44, 16);
            this.lblHosgeldiniz.TabIndex = 0;
            this.lblHosgeldiniz.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rezervasyon Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(373, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rezervasyonlarım";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}