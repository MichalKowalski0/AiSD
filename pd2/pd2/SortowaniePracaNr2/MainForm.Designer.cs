namespace pd2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numbersToConvertText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            numericAmountText = new NumericUpDown();
            numbersToSortText = new TextBox();
            button3 = new Button();
            sortingTimeText = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sortedNumberText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericAmountText).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // numbersToConvertText
            // 
            numbersToConvertText.Location = new Point(93, 66);
            numbersToConvertText.Name = "numbersToConvertText";
            numbersToConvertText.Size = new Size(202, 23);
            numbersToConvertText.TabIndex = 0;
            numbersToConvertText.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(159, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Konwertuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnConvertButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(178, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Generuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnGenerateButtonClick;
            // 
            // numericAmountText
            // 
            numericAmountText.Location = new Point(181, 58);
            numericAmountText.Name = "numericAmountText";
            numericAmountText.Size = new Size(72, 23);
            numericAmountText.TabIndex = 3;
            numericAmountText.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numbersToSortText
            // 
            numbersToSortText.Location = new Point(466, 284);
            numbersToSortText.Name = "numbersToSortText";
            numbersToSortText.Size = new Size(250, 23);
            numbersToSortText.TabIndex = 4;
            numbersToSortText.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(338, 374);
            button3.Name = "button3";
            button3.Size = new Size(122, 46);
            button3.TabIndex = 5;
            button3.Text = "Bubble Sort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnBubbleSortButtonClick;
            // 
            // sortingTimeText
            // 
            sortingTimeText.Location = new Point(190, 323);
            sortingTimeText.Name = "sortingTimeText";
            sortingTimeText.Size = new Size(434, 23);
            sortingTimeText.TabIndex = 6;
            sortingTimeText.Text = "Czas sortowania: ";
            sortingTimeText.TextChanged += textBox3_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(210, 374);
            button4.Name = "button4";
            button4.Size = new Size(122, 46);
            button4.TabIndex = 7;
            button4.Text = "Insertion Sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnInsertionSortButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(466, 374);
            button5.Name = "button5";
            button5.Size = new Size(122, 46);
            button5.TabIndex = 8;
            button5.Text = "Merge Sort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnMergeSortButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(82, 374);
            button6.Name = "button6";
            button6.Size = new Size(122, 46);
            button6.TabIndex = 9;
            button6.Text = "Quick Sort";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OnQuickSortButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(594, 374);
            button7.Name = "button7";
            button7.Size = new Size(122, 46);
            button7.TabIndex = 10;
            button7.Text = "Counting Sort";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OnCountingSortButtonClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numbersToConvertText);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-8, -14);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 227);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 40);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 2;
            label4.Text = "Podaj liczby do sortowania";
            label4.Click += label4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(2, 412);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(numericAmountText);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(401, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 216);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 29);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 4;
            label1.Text = "Ilość liczb do wygenerowania";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 266);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 13;
            label2.Text = "Liczby do sortowania";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 266);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 15;
            label3.Text = "Posortowane liczby";
            label3.Click += label3_Click;
            // 
            // sortedNumberText
            // 
            sortedNumberText.Location = new Point(82, 284);
            sortedNumberText.Name = "sortedNumberText";
            sortedNumberText.Size = new Size(250, 23);
            sortedNumberText.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(sortedNumberText);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(sortingTimeText);
            Controls.Add(button3);
            Controls.Add(numbersToSortText);
            Name = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericAmountText).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numbersToConvertText;
        private Button button1;
        private Button button2;
        private NumericUpDown numericAmountText;
        private TextBox numbersToSortText;
        private Button button3;
        private TextBox sortingTimeText;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sortedNumberText;
        private Label label4;
    }
}