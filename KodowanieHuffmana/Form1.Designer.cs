namespace KodowanieHuffmana
{
    partial class EncodingForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.poleTekstuDoZakodowania = new System.Windows.Forms.TextBox();
            this.poleZakodowanegoTekstu = new System.Windows.Forms.TextBox();
            this.poleKoduLiter = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do zakodowania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kody :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kod Huffmana";
            // 
            // poleTekstuDoZakodowania
            // 
            this.poleTekstuDoZakodowania.Location = new System.Drawing.Point(29, 60);
            this.poleTekstuDoZakodowania.Name = "poleTekstuDoZakodowania";
            this.poleTekstuDoZakodowania.Size = new System.Drawing.Size(343, 20);
            this.poleTekstuDoZakodowania.TabIndex = 4;
            // 
            // poleZakodowanegoTekstu
            // 
            this.poleZakodowanegoTekstu.Location = new System.Drawing.Point(29, 359);
            this.poleZakodowanegoTekstu.Name = "poleZakodowanegoTekstu";
            this.poleZakodowanegoTekstu.Size = new System.Drawing.Size(343, 20);
            this.poleZakodowanegoTekstu.TabIndex = 5;
            this.poleZakodowanegoTekstu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // poleKoduLiter
            // 
            this.poleKoduLiter.FormattingEnabled = true;
            this.poleKoduLiter.Location = new System.Drawing.Point(434, 60);
            this.poleKoduLiter.Name = "poleKoduLiter";
            this.poleKoduLiter.Size = new System.Drawing.Size(341, 368);
            this.poleKoduLiter.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(117, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zakoduj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PrzyciskKodowania);
            // 
            // EncodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poleKoduLiter);
            this.Controls.Add(this.poleZakodowanegoTekstu);
            this.Controls.Add(this.poleTekstuDoZakodowania);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EncodingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poleTekstuDoZakodowania;
        private System.Windows.Forms.TextBox poleZakodowanegoTekstu;
        private System.Windows.Forms.ListBox poleKoduLiter;
        private System.Windows.Forms.Button button1;
    }
}

