namespace pd3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.liczbyTextBox = new System.Windows.Forms.TextBox();
            this.utworzListeButton = new System.Windows.Forms.Button();
            this.dodajNaPoczatekButton = new System.Windows.Forms.Button();
            this.dodajNaKoniecButton = new System.Windows.Forms.Button();
            this.usunPoczatekButton = new System.Windows.Forms.Button();
            this.usunKoniecButton = new System.Windows.Forms.Button();
            this.usunListeButton = new System.Windows.Forms.Button();
            this.numerListyUpDown = new System.Windows.Forms.NumericUpDown();
            this.widokListyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numerListyUpDown)).BeginInit();
            this.SuspendLayout();

            // liczbyTextBox
            this.liczbyTextBox.Location = new System.Drawing.Point(20, 20);
            this.liczbyTextBox.Name = "liczbyTextBox";
            this.liczbyTextBox.Size = new System.Drawing.Size(200, 23);

            // utworzListeButton
            this.utworzListeButton.Location = new System.Drawing.Point(240, 20);
            this.utworzListeButton.Name = "utworzListeButton";
            this.utworzListeButton.Size = new System.Drawing.Size(120, 23);
            this.utworzListeButton.Text = "Stworz liste";
            this.utworzListeButton.Click += new System.EventHandler(this.UtworzListe_Click);

            // dodajNaPoczatekButton
            this.dodajNaPoczatekButton.Location = new System.Drawing.Point(20, 60);
            this.dodajNaPoczatekButton.Name = "dodajNaPoczatekButton";
            this.dodajNaPoczatekButton.Size = new System.Drawing.Size(120, 23);
            this.dodajNaPoczatekButton.Text = "Dodaj na początek";
            this.dodajNaPoczatekButton.Click += new System.EventHandler(this.DodajNaPoczatek_Click);

            // dodajNaKoniecButton
            this.dodajNaKoniecButton.Location = new System.Drawing.Point(160, 60);
            this.dodajNaKoniecButton.Name = "dodajNaKoniecButton";
            this.dodajNaKoniecButton.Size = new System.Drawing.Size(120, 23);
            this.dodajNaKoniecButton.Text = "Dodaj na koniec";
            this.dodajNaKoniecButton.Click += new System.EventHandler(this.DodajNaKoniec_Click);

            // usunPoczatekButton
            this.usunPoczatekButton.Location = new System.Drawing.Point(20, 100);
            this.usunPoczatekButton.Name = "usunPoczatekButton";
            this.usunPoczatekButton.Size = new System.Drawing.Size(120, 23);
            this.usunPoczatekButton.Text = "Usun początek";
            this.usunPoczatekButton.Click += new System.EventHandler(this.UsunPoczatek_Click);

            // usunKoniecButton
            this.usunKoniecButton.Location = new System.Drawing.Point(160, 100);
            this.usunKoniecButton.Name = "usunKoniecButton";
            this.usunKoniecButton.Size = new System.Drawing.Size(120, 23);
            this.usunKoniecButton.Text = "Usun koniec";
            this.usunKoniecButton.Click += new System.EventHandler(this.UsunKoniec_Click);

            // usunListeButton
            this.usunListeButton.Location = new System.Drawing.Point(300, 100);
            this.usunListeButton.Name = "usunListeButton";
            this.usunListeButton.Size = new System.Drawing.Size(120, 23);
            this.usunListeButton.Text = "Usun liste";
            this.usunListeButton.Click += new System.EventHandler(this.UsunListe_Click);

            // numerListyUpDown
            this.numerListyUpDown.Location = new System.Drawing.Point(240, 60);
            this.numerListyUpDown.Name = "numerListyUpDown";
            this.numerListyUpDown.Size = new System.Drawing.Size(120, 23);
            this.numerListyUpDown.ValueChanged += new System.EventHandler(this.NumerListyUpDown_ValueChanged);

            // widokListyTextBox
            this.widokListyTextBox.Location = new System.Drawing.Point(20, 140);
            this.widokListyTextBox.Multiline = true;
            this.widokListyTextBox.Name = "widokListyTextBox";
            this.widokListyTextBox.Size = new System.Drawing.Size(400, 150);
            this.widokListyTextBox.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.liczbyTextBox);
            this.Controls.Add(this.utworzListeButton);
            this.Controls.Add(this.dodajNaPoczatekButton);
            this.Controls.Add(this.dodajNaKoniecButton);
            this.Controls.Add(this.usunPoczatekButton);
            this.Controls.Add(this.usunKoniecButton);
            this.Controls.Add(this.usunListeButton);
            this.Controls.Add(this.numerListyUpDown);
            this.Controls.Add(this.widokListyTextBox);
            this.Name = "Form1";
            this.Text = "Linked List";
            ((System.ComponentModel.ISupportInitialize)(this.numerListyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox liczbyTextBox;
        private System.Windows.Forms.Button utworzListeButton;
        private System.Windows.Forms.Button dodajNaPoczatekButton;
        private System.Windows.Forms.Button dodajNaKoniecButton;
        private System.Windows.Forms.Button usunPoczatekButton;
        private System.Windows.Forms.Button usunKoniecButton;
        private System.Windows.Forms.Button usunListeButton;
        private System.Windows.Forms.NumericUpDown numerListyUpDown;
        private System.Windows.Forms.TextBox widokListyTextBox;
    }
}


