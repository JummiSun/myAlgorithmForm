namespace myProgram
{
    partial class PancakeSortInfoForm
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 33);
            label1.Name = "label1";
            label1.Size = new Size(320, 26);
            label1.TabIndex = 0;
            label1.Text = "Что такое блинная сортировка?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 81);
            label2.Name = "label2";
            label2.Size = new Size(577, 88);
            label2.TabIndex = 1;
            label2.Text = "Блинная сортировка - это не конкретный алгоритм \r\nсортировки, а класс сортировок, в которых запускается \r\nтолько одна операция - переворот элементов последовательности \r\nдо  какого-либо индекса.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pancake;
            pictureBox1.Location = new Point(66, 216);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 274);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PancakeSortInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PancakeSortInfoForm";
            Text = "PancakeSortInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}