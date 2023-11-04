namespace myProgram
{
    partial class CompareAnalyseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareAnalyseForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label13 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 284F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Location = new Point(53, 161);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.52381F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.47619F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 177F));
            tableLayoutPanel1.Size = new Size(998, 644);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 114);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(360, 0);
            label2.Name = "label2";
            label2.Size = new Size(343, 76);
            label2.TabIndex = 1;
            label2.Text = "Эффективен при наличии большого набора данных  с ограниченным диапазоном значений. Время выполнения алгоритма линейно зависит от размера массива и диапазона значений.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(717, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 95);
            label3.TabIndex = 2;
            label3.Text = "Зависит от диапазона значений. Требуется дополнительная память для счетчиков, поэтому использование памяти может быть высоким.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 207);
            label4.Name = "label4";
            label4.Size = new Size(338, 152);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(360, 207);
            label5.Name = "label5";
            label5.Size = new Size(350, 95);
            label5.TabIndex = 4;
            label5.Text = "Лучше всего работает на небольших наборах данных, где количество элементов невелико. Время выполнения алгоритма зависит от количества \"ячейке\" в алгоритме. Не оптимален  для больших данных. ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(717, 207);
            label6.Name = "label6";
            label6.Size = new Size(264, 57);
            label6.TabIndex = 5;
            label6.Text = "Требуется дополнительная память для \"ячейке\", и ее объем зависит от диапазона значений.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 466);
            label7.Name = "label7";
            label7.Size = new Size(339, 114);
            label7.TabIndex = 6;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(360, 466);
            label8.Name = "label8";
            label8.Size = new Size(344, 76);
            label8.TabIndex = 7;
            label8.Text = "Эффективен для небольших массивов. Алгоритм основан на переворачивании  элементов, что делает  его не самым быстрым для больших наборов данных.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(717, 466);
            label9.Name = "label9";
            label9.Size = new Size(275, 57);
            label9.TabIndex = 8;
            label9.Text = "Алгоритм не требует дополнительной памяти, так как работает с перестановками в исходном массиве.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(152, 111);
            label10.Name = "label10";
            label10.Size = new Size(118, 23);
            label10.TabIndex = 1;
            label10.Text = "ЗНАЧЕНИЕ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(457, 111);
            label11.Name = "label11";
            label11.Size = new Size(198, 23);
            label11.TabIndex = 2;
            label11.Text = "ЭФФЕКТИВНОСТЬ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(845, 111);
            label12.Name = "label12";
            label12.Size = new Size(97, 23);
            label12.TabIndex = 3;
            label12.Text = "ПАМЯТЬ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(47, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 5);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(47, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 5);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Location = new Point(401, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 644);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Location = new Point(763, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 644);
            panel4.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Yellow;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(364, 55);
            label13.Name = "label13";
            label13.Size = new Size(430, 23);
            label13.TabIndex = 8;
            label13.Text = "СРАВНИТЕЛЬНЫЙ АНАЛИЗ СОРТИРОВОК";
            // 
            // CompareAnalyseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 827);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tableLayoutPanel1);
            Name = "CompareAnalyseForm";
            Text = "CompareAnalyseForm";
            Load += CompareAnalyseForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label13;
    }
}