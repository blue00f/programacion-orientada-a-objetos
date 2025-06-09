namespace LinQ
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(64, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Par";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(64, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Impar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(265, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 36);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Mayor a:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(419, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(64, 81);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 45);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(53, 19);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "DESC";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += radioButton4_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "ASC";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += radioButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 208);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}
