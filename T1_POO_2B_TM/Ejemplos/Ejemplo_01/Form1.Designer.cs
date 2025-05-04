namespace Ejemplo_01
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 62);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(340, 53);
            button1.TabIndex = 0;
            button1.Text = "Crear Objeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 169);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(340, 53);
            button2.TabIndex = 1;
            button2.Text = "Cargar Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(150, 269);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(340, 53);
            button3.TabIndex = 2;
            button3.Text = "Leer Datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(150, 369);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(340, 53);
            button4.TabIndex = 3;
            button4.Text = "Leer Datos 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(551, 62);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(340, 53);
            button5.TabIndex = 4;
            button5.Text = "LLamar al Dispose";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(551, 169);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(340, 53);
            button6.TabIndex = 5;
            button6.Text = "Desapuntar al objeto";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(551, 269);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(340, 53);
            button7.TabIndex = 6;
            button7.Text = "GC";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(943, 62);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(488, 53);
            button8.TabIndex = 7;
            button8.Text = "Crear Objeto (Nombre)";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(943, 169);
            button9.Margin = new Padding(6);
            button9.Name = "button9";
            button9.Size = new Size(488, 53);
            button9.TabIndex = 8;
            button9.Text = "Crear Objeto (Nombre y Apellido)";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(943, 269);
            button10.Margin = new Padding(6);
            button10.Name = "button10";
            button10.Size = new Size(488, 53);
            button10.TabIndex = 9;
            button10.Text = "Crear Objeto (Nombre, Apellido y Edad)";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
