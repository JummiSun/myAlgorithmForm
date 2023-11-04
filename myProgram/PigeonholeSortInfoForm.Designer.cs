namespace myProgram
{
    partial class PigeonholeSortInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PigeonholeSortInfoForm));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(340, 26);
            label1.TabIndex = 0;
            label1.Text = "Что такое голубиная сортировка?";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(40, 84);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(659, 275);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pig;
            pictureBox1.Location = new Point(716, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(691, 189);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PigeonholeSortInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 450);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "PigeonholeSortInfoForm";
            Text = "PigeonholeSortInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}