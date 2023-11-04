namespace myProgram
{
    partial class MainPage
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
            listBox1 = new ListBox();
            Start = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(119, 29);
            label1.Name = "label1";
            label1.Size = new Size(589, 78);
            label1.TabIndex = 0;
            label1.Text = "                Приветствую вас в\r\nОбучающем тренажере по алгоритмам!";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveBorder;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "Цель разработки приложения “Обучающий тренажер” заключается в создании ", "       инструмента, который позволит учащимся 10-11 классов средней школы ", "          изучить три алгоритма сортировки массивов  и закрепить материал." });
            listBox1.Location = new Point(54, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(699, 110);
            listBox1.TabIndex = 1;
            // 
            // Start
            // 
            Start.BackColor = SystemColors.GradientActiveCaption;
            Start.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Start.Location = new Point(283, 318);
            Start.Name = "Start";
            Start.Size = new Size(182, 93);
            Start.TabIndex = 2;
            Start.Text = "Let’s start!";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(Start);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button Start;
    }
}