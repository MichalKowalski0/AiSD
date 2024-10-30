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
            this.widokListyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.liczbyTextBox.Location = new System.Drawing.Point(12, 12);
            this.liczbyTextBox.Name = "liczbyTextBox";
            this.liczbyTextBox.Size = new System.Drawing.Size(400, 23);

            this.utworzListeButton.Location = new System.Drawing.Point(12, 50);
            this.utworzListeButton.Name = "utworzListeButton";
            this.utworzListeButton.Size = new System.Drawing.Size(120, 30);
            this.utworzListeButton.Text = "Stworz liste";
            this.utworzListeButton.Click += new System.EventHandler(this.UtworzListe_Click);

            this.dodajNaPoczatekButton.Location = new System.Drawing.Point(150, 50);
            this.dodajNaPoczatekButton.Name = "dodajNaPoczatekButton";
            this.dodajNaPoczatekButton.Size = new System.Drawing.Size(120, 30);
            this.dodajNaPoczatekButton.Text = "Dodaj na początek";
            this.dodajNaPoczatekButton.Click += new System.EventHandler(this.DodajNaPoczatek_Click);

            this.dodajNaKoniecButton.Location = new System.Drawing.Point(290, 50);
            this.dodajNaKoniecButton.Name = "dodajNaKoniecButton";
            this.dodajNaKoniecButton.Size = new System.Drawing.Size(120, 30);
            this.dodajNaKoniecButton.Text = "Dodaj na koniec";
            this.dodajNaKoniecButton.Click += new System.EventHandler(this.DodajNaKoniec_Click);

            this.usunPoczatekButton.Location = new System.Drawing.Point(12, 90);
            this.usunPoczatekButton.Name = "usunPoczatekButton";
            this.usunPoczatekButton.Size = new System.Drawing.Size(120, 30);
            this.usunPoczatekButton.Text = "Usun początek";
            this.usunPoczatekButton.Click += new System.EventHandler(this.UsunPoczatek_Click);

            this.usunKoniecButton.Location = new System.Drawing.Point(150, 90);
            this.usunKoniecButton.Name = "usunKoniecButton";
            this.usunKoniecButton.Size = new System.Drawing.Size(120, 30);
            this.usunKoniecButton.Text = "Usun koniec";
            this.usunKoniecButton.Click += new System.EventHandler(this.UsunKoniec_Click);

            this.usunListeButton.Location = new System.Drawing.Point(290, 90);
            this.usunListeButton.Name = "usunListeButton";
            this.usunListeButton.Size = new System.Drawing.Size(120, 30);
            this.usunListeButton.Text = "Usun liste";
            this.usunListeButton.Click += new System.EventHandler(this.UsunListe_Click);

            this.widokListyTextBox.Location = new System.Drawing.Point(12, 130);
            this.widokListyTextBox.Multiline = true;
            this.widokListyTextBox.Name = "widokListyTextBox";
            this.widokListyTextBox.Size = new System.Drawing.Size(468, 200);
            this.widokListyTextBox.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.liczbyTextBox);
            this.Controls.Add(this.utworzListeButton);
            this.Controls.Add(this.dodajNaPoczatekButton);
            this.Controls.Add(this.dodajNaKoniecButton);
            this.Controls.Add(this.usunPoczatekButton);
            this.Controls.Add(this.usunKoniecButton);
            this.Controls.Add(this.usunListeButton);
            this.Controls.Add(this.widokListyTextBox);
            this.Name = "Form1";
            this.Text = "Linked List";
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
        private System.Windows.Forms.TextBox widokListyTextBox;
    }
}






