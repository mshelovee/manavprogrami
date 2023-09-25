namespace manav
{
    partial class formManav
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnBosalt = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxMeyveler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(15, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 59);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnBosalt
            // 
            this.btnBosalt.BackColor = System.Drawing.Color.Red;
            this.btnBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosalt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBosalt.Location = new System.Drawing.Point(15, 212);
            this.btnBosalt.Name = "btnBosalt";
            this.btnBosalt.Size = new System.Drawing.Size(141, 59);
            this.btnBosalt.TabIndex = 1;
            this.btnBosalt.Text = "Sepeti Boşalt";
            this.btnBosalt.UseVisualStyleBackColor = false;
            this.btnBosalt.Click += new System.EventHandler(this.btnBosalt_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(15, 67);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(141, 20);
            this.txtEkle.TabIndex = 2;
            this.txtEkle.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eklenecek Meyve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(211, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sepetteki Meyveler";
            // 
            // lboxMeyveler
            // 
            this.lboxMeyveler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lboxMeyveler.FormattingEnabled = true;
            this.lboxMeyveler.Location = new System.Drawing.Point(214, 67);
            this.lboxMeyveler.Name = "lboxMeyveler";
            this.lboxMeyveler.Size = new System.Drawing.Size(120, 212);
            this.lboxMeyveler.TabIndex = 5;
            this.lboxMeyveler.SelectedIndexChanged += new System.EventHandler(this.lboxMeyveler_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(15, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 59);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Seçili Öğeyi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // formManav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(358, 380);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lboxMeyveler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnBosalt);
            this.Controls.Add(this.btnEkle);
            this.Name = "formManav";
            this.Text = "Manav Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnBosalt;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxMeyveler;
        private System.Windows.Forms.Button btnSil;
    }
}

