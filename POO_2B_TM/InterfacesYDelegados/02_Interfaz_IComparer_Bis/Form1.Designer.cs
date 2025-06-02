namespace Ejemplo07
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            label3 = new Label();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            dataGridView6 = new DataGridView();
            dataGridView7 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(412, 160);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(529, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 160);
            button1.TabIndex = 1;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(106, 245);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(412, 160);
            dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 213);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 317);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Ascendentes";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(112, 422);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(412, 160);
            dataGridView3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 496);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 6;
            label3.Text = "Descendentes";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(529, 245);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.Size = new Size(412, 160);
            dataGridView4.TabIndex = 7;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(529, 422);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.Size = new Size(412, 160);
            dataGridView5.TabIndex = 8;
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.AllowUserToDeleteRows = false;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(947, 245);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.Size = new Size(412, 160);
            dataGridView6.TabIndex = 9;
            // 
            // dataGridView7
            // 
            dataGridView7.AllowUserToAddRows = false;
            dataGridView7.AllowUserToDeleteRows = false;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(947, 422);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.ReadOnly = true;
            dataGridView7.Size = new Size(412, 160);
            dataGridView7.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(726, 213);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1153, 213);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(629, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(730, 160);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 634);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView7);
            Controls.Add(dataGridView6);
            Controls.Add(dataGridView5);
            Controls.Add(dataGridView4);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView3;
        private Label label3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}
