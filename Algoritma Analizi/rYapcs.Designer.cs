namespace Algoritma_Analizi
{
    partial class rYapcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilmAdi = new System.Windows.Forms.ComboBox();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.comboBoxSeans = new System.Windows.Forms.ComboBox();
            this.btnRezYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seans:";
            // 
            // comboBoxFilmAdi
            // 
            this.comboBoxFilmAdi.FormattingEnabled = true;
            this.comboBoxFilmAdi.Location = new System.Drawing.Point(207, 68);
            this.comboBoxFilmAdi.Name = "comboBoxFilmAdi";
            this.comboBoxFilmAdi.Size = new System.Drawing.Size(242, 24);
            this.comboBoxFilmAdi.TabIndex = 3;
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(207, 173);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(242, 24);
            this.comboBoxSalon.TabIndex = 4;
            // 
            // comboBoxSeans
            // 
            this.comboBoxSeans.FormattingEnabled = true;
            this.comboBoxSeans.Location = new System.Drawing.Point(207, 273);
            this.comboBoxSeans.Name = "comboBoxSeans";
            this.comboBoxSeans.Size = new System.Drawing.Size(242, 24);
            this.comboBoxSeans.TabIndex = 5;
            // 
            // btnRezYap
            // 
            this.btnRezYap.Location = new System.Drawing.Point(198, 368);
            this.btnRezYap.Name = "btnRezYap";
            this.btnRezYap.Size = new System.Drawing.Size(230, 51);
            this.btnRezYap.TabIndex = 6;
            this.btnRezYap.Text = "Rezervasyon Yap";
            this.btnRezYap.UseVisualStyleBackColor = true;
            this.btnRezYap.Click += new System.EventHandler(this.btnRezYap_Click);
            // 
            // rYapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezYap);
            this.Controls.Add(this.comboBoxSeans);
            this.Controls.Add(this.comboBoxSalon);
            this.Controls.Add(this.comboBoxFilmAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rYapcs";
            this.Text = "rYapcs";
            this.Load += new System.EventHandler(this.rYapcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilmAdi;
        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.ComboBox comboBoxSeans;
        private System.Windows.Forms.Button btnRezYap;
    }
}