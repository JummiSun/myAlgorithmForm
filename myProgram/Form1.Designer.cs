namespace myProgram
{
    partial class Form1
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
            label1 = new Label();
            SizeArrayTextBox = new TextBox();
            label2 = new Label();
            generateButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            sortButton = new Button();
            countingSortRadioButton = new RadioButton();
            timeLabel = new Label();
            listBoxIterations = new ListBox();
            pancakeSortRadioButton = new RadioButton();
            pigeonholeSortRadioButton = new RadioButton();
            infoButtonCountingSort = new Button();
            infoButtonPancakeSort = new Button();
            infoButtonPigeonSort = new Button();
            compareAnalyseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 0;
            label1.Text = "Размер массива";
            // 
            // SizeArrayTextBox
            // 
            SizeArrayTextBox.Location = new Point(226, 26);
            SizeArrayTextBox.Margin = new Padding(3, 4, 3, 4);
            SizeArrayTextBox.Name = "SizeArrayTextBox";
            SizeArrayTextBox.Size = new Size(174, 27);
            SizeArrayTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(523, 26);
            label2.Name = "label2";
            label2.Size = new Size(272, 22);
            label2.TabIndex = 2;
            label2.Text = "Диапазон массива: от 1 до 100";
            // 
            // generateButton
            // 
            generateButton.BackColor = SystemColors.MenuHighlight;
            generateButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generateButton.Location = new Point(19, 82);
            generateButton.Margin = new Padding(3, 4, 3, 4);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(180, 41);
            generateButton.TabIndex = 3;
            generateButton.Text = "СГЕНЕРИРОВАТЬ";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 89);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(731, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 185);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(731, 27);
            textBox2.TabIndex = 5;
            // 
            // sortButton
            // 
            sortButton.BackColor = SystemColors.MenuHighlight;
            sortButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortButton.ForeColor = SystemColors.ControlText;
            sortButton.Location = new Point(19, 179);
            sortButton.Margin = new Padding(3, 4, 3, 4);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(180, 39);
            sortButton.TabIndex = 6;
            sortButton.Text = "ОТСОРТИРОВАТЬ";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // countingSortRadioButton
            // 
            countingSortRadioButton.AutoSize = true;
            countingSortRadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countingSortRadioButton.Location = new Point(19, 302);
            countingSortRadioButton.Margin = new Padding(3, 4, 3, 4);
            countingSortRadioButton.Name = "countingSortRadioButton";
            countingSortRadioButton.Size = new Size(227, 26);
            countingSortRadioButton.TabIndex = 7;
            countingSortRadioButton.TabStop = true;
            countingSortRadioButton.Text = "Сортировка подсчетом";
            countingSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(19, 500);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(44, 22);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "time";
            // 
            // listBoxIterations
            // 
            listBoxIterations.FormattingEnabled = true;
            listBoxIterations.ItemHeight = 20;
            listBoxIterations.Location = new Point(372, 276);
            listBoxIterations.Margin = new Padding(3, 4, 3, 4);
            listBoxIterations.Name = "listBoxIterations";
            listBoxIterations.Size = new Size(700, 384);
            listBoxIterations.TabIndex = 10;
            // 
            // pancakeSortRadioButton
            // 
            pancakeSortRadioButton.AutoSize = true;
            pancakeSortRadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pancakeSortRadioButton.Location = new Point(19, 364);
            pancakeSortRadioButton.Margin = new Padding(3, 4, 3, 4);
            pancakeSortRadioButton.Name = "pancakeSortRadioButton";
            pancakeSortRadioButton.Size = new Size(205, 26);
            pancakeSortRadioButton.TabIndex = 11;
            pancakeSortRadioButton.TabStop = true;
            pancakeSortRadioButton.Text = "Блинная сортировка";
            pancakeSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // pigeonholeSortRadioButton
            // 
            pigeonholeSortRadioButton.AutoSize = true;
            pigeonholeSortRadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pigeonholeSortRadioButton.Location = new Point(19, 430);
            pigeonholeSortRadioButton.Margin = new Padding(3, 4, 3, 4);
            pigeonholeSortRadioButton.Name = "pigeonholeSortRadioButton";
            pigeonholeSortRadioButton.Size = new Size(222, 26);
            pigeonholeSortRadioButton.TabIndex = 12;
            pigeonholeSortRadioButton.TabStop = true;
            pigeonholeSortRadioButton.Text = "Голубиная сортировка";
            pigeonholeSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoButtonCountingSort
            // 
            infoButtonCountingSort.BackColor = SystemColors.MenuHighlight;
            infoButtonCountingSort.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoButtonCountingSort.ForeColor = SystemColors.ControlText;
            infoButtonCountingSort.Location = new Point(257, 293);
            infoButtonCountingSort.Margin = new Padding(3, 4, 3, 4);
            infoButtonCountingSort.Name = "infoButtonCountingSort";
            infoButtonCountingSort.Size = new Size(86, 45);
            infoButtonCountingSort.TabIndex = 13;
            infoButtonCountingSort.Text = "?";
            infoButtonCountingSort.UseVisualStyleBackColor = false;
            infoButtonCountingSort.Click += infoButtonCountingSort_Click;
            // 
            // infoButtonPancakeSort
            // 
            infoButtonPancakeSort.BackColor = SystemColors.MenuHighlight;
            infoButtonPancakeSort.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoButtonPancakeSort.Location = new Point(257, 355);
            infoButtonPancakeSort.Name = "infoButtonPancakeSort";
            infoButtonPancakeSort.Size = new Size(86, 45);
            infoButtonPancakeSort.TabIndex = 14;
            infoButtonPancakeSort.Text = "?";
            infoButtonPancakeSort.UseVisualStyleBackColor = false;
            infoButtonPancakeSort.Click += infoButtonPancakeSort_Click;
            // 
            // infoButtonPigeonSort
            // 
            infoButtonPigeonSort.BackColor = SystemColors.MenuHighlight;
            infoButtonPigeonSort.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoButtonPigeonSort.Location = new Point(257, 421);
            infoButtonPigeonSort.Name = "infoButtonPigeonSort";
            infoButtonPigeonSort.Size = new Size(86, 44);
            infoButtonPigeonSort.TabIndex = 15;
            infoButtonPigeonSort.Text = "?";
            infoButtonPigeonSort.UseVisualStyleBackColor = false;
            infoButtonPigeonSort.Click += infoButtonPigeonSort_Click;
            // 
            // compareAnalyseButton
            // 
            compareAnalyseButton.BackColor = SystemColors.MenuHighlight;
            compareAnalyseButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            compareAnalyseButton.Location = new Point(23, 612);
            compareAnalyseButton.Name = "compareAnalyseButton";
            compareAnalyseButton.Size = new Size(320, 48);
            compareAnalyseButton.TabIndex = 16;
            compareAnalyseButton.Text = "СРАВНИТЕЛЬНЫЙ АНАЛИЗ";
            compareAnalyseButton.UseVisualStyleBackColor = false;
            compareAnalyseButton.Click += compareAnalyseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 716);
            Controls.Add(compareAnalyseButton);
            Controls.Add(infoButtonPigeonSort);
            Controls.Add(infoButtonPancakeSort);
            Controls.Add(infoButtonCountingSort);
            Controls.Add(pigeonholeSortRadioButton);
            Controls.Add(pancakeSortRadioButton);
            Controls.Add(listBoxIterations);
            Controls.Add(timeLabel);
            Controls.Add(countingSortRadioButton);
            Controls.Add(sortButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(generateButton);
            Controls.Add(label2);
            Controls.Add(SizeArrayTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SizeArrayTextBox;
        private Label label2;
        private Button generateButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button sortButton;
        private RadioButton countingSortRadioButton;
        private Label timeLabel;
        private ListBox listBoxIterations;
        private RadioButton pancakeSortRadioButton;
        private RadioButton pigeonholeSortRadioButton;
        private Button infoButtonCountingSort;
        private Button infoButtonPancakeSort;
        private Button infoButtonPigeonSort;
        private Button compareAnalyseButton;
    }
}