namespace pd4
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
            this.liczbaTextBox = new System.Windows.Forms.TextBox();
            this.dodajLiczbeButton = new System.Windows.Forms.Button();
            this.wyswietlDrzewoButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.drzewoTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // liczbaTextBox
            // 
            this.liczbaTextBox.Location = new System.Drawing.Point(150, 20);
            this.liczbaTextBox.Name = "liczbaTextBox";
            this.liczbaTextBox.Size = new System.Drawing.Size(100, 20);
            this.liczbaTextBox.TabIndex = 0;
            // 
            // dodajLiczbeButton
            // 
            this.dodajLiczbeButton.Location = new System.Drawing.Point(150, 60);
            this.dodajLiczbeButton.Name = "dodajLiczbeButton";
            this.dodajLiczbeButton.Size = new System.Drawing.Size(100, 30);
            this.dodajLiczbeButton.TabIndex = 1;
            this.dodajLiczbeButton.Text = "Dodaj liczbę";
            this.dodajLiczbeButton.Click += new System.EventHandler(this.DodajLiczbe_Click);
            // 
            // wyswietlDrzewoButton
            // 
            this.wyswietlDrzewoButton.Location = new System.Drawing.Point(150, 100);
            this.wyswietlDrzewoButton.Name = "wyswietlDrzewoButton";
            this.wyswietlDrzewoButton.Size = new System.Drawing.Size(100, 30);
            this.wyswietlDrzewoButton.TabIndex = 2;
            this.wyswietlDrzewoButton.Text = "Wyświetl drzewo";
            this.wyswietlDrzewoButton.Click += new System.EventHandler(this.WyswietlDrzewo_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(150, 140);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(100, 30);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.Click += new System.EventHandler(this.Restart_Click);
            // 
            // drzewoTreeView
            // 
            this.drzewoTreeView.Location = new System.Drawing.Point(20, 20);
            this.drzewoTreeView.Name = "drzewoTreeView";
            this.drzewoTreeView.Size = new System.Drawing.Size(120, 300);
            this.drzewoTreeView.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.liczbaTextBox);
            this.Controls.Add(this.dodajLiczbeButton);
            this.Controls.Add(this.wyswietlDrzewoButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.drzewoTreeView);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox liczbaTextBox;
        private System.Windows.Forms.Button dodajLiczbeButton;
        private System.Windows.Forms.Button wyswietlDrzewoButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TreeView drzewoTreeView;
    }
}


