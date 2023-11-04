namespace myProgram
{
    partial class CountingSortInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountingSortInfoForm));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(345, 26);
            label1.TabIndex = 0;
            label1.Text = "Что такое сортировка подсчетом?";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(23, 103);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(602, 263);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(631, 29);
            label2.Name = "label2";
            label2.Size = new Size(375, 26);
            label2.TabIndex = 2;
            label2.Text = "Визуализация сортировки подсчетом";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.counting;
            pictureBox1.Location = new Point(631, 103);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 247);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CountingSortInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CountingSortInfoForm";
            Text = "CountingSortInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}