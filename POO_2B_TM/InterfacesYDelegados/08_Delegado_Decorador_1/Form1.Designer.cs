namespace Ejemplo_Delegado_1
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
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            radioButton6 = new RadioButton();
            button4 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 14F);
            radioButton1.Location = new Point(60, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(163, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Decorador 1 ***";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14F);
            radioButton2.Location = new Point(323, 24);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(163, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Decorador 2 ---";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 14F);
            radioButton3.Location = new Point(605, 24);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(160, 29);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Decorador 3 ///";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += radioButton3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(60, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(699, 32);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(60, 169);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(699, 32);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 14F);
            radioButton4.Location = new Point(60, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(169, 29);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "Decorador 4 $$$";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += radioButton4_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 14F);
            radioButton5.Location = new Point(323, 72);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(178, 29);
            radioButton5.TabIndex = 7;
            radioButton5.Text = "Decorador 5 ^^^";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(60, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 342);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 14F);
            radioButton6.Location = new Point(605, 72);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(154, 29);
            radioButton6.TabIndex = 11;
            radioButton6.Text = "Decorador 6 |||";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.Click += radioButton6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(380, 259);
            button4.Name = "button4";
            button4.Size = new Size(255, 28);
            button4.TabIndex = 12;
            button4.Text = "Uso de MyDelegate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(640, 264);
            checkBox1.Margin = new Padding(2, 1, 2, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Asteriscos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 395);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(radioButton6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton6;
        private Button button4;
        private CheckBox checkBox1;
    }
}
