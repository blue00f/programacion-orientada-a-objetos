namespace EjercicioIComparer
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
            grillaInstrumentoAsc = new DataGridView();
            grillaEdadAsc = new DataGridView();
            grillaNombreAsc = new DataGridView();
            grillaInstrumentoDesc = new DataGridView();
            grillaEdadDesc = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInstrumentoAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaEdadAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaNombreAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaInstrumentoDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaEdadDesc).BeginInit();
            SuspendLayout();
            // 
            // grillaInstrumentoAsc
            // 
            grillaInstrumentoAsc.AllowUserToAddRows = false;
            grillaInstrumentoAsc.AllowUserToDeleteRows = false;
            grillaInstrumentoAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInstrumentoAsc.Location = new Point(20, 58);
            grillaInstrumentoAsc.Name = "grillaInstrumentoAsc";
            grillaInstrumentoAsc.ReadOnly = true;
            grillaInstrumentoAsc.Size = new Size(375, 228);
            grillaInstrumentoAsc.TabIndex = 0;
            // 
            // grillaEdadAsc
            // 
            grillaEdadAsc.AllowUserToAddRows = false;
            grillaEdadAsc.AllowUserToDeleteRows = false;
            grillaEdadAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaEdadAsc.Location = new Point(460, 58);
            grillaEdadAsc.Name = "grillaEdadAsc";
            grillaEdadAsc.ReadOnly = true;
            grillaEdadAsc.Size = new Size(375, 228);
            grillaEdadAsc.TabIndex = 1;
            // 
            // grillaNombreAsc
            // 
            grillaNombreAsc.AllowUserToAddRows = false;
            grillaNombreAsc.AllowUserToDeleteRows = false;
            grillaNombreAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaNombreAsc.Location = new Point(893, 58);
            grillaNombreAsc.Name = "grillaNombreAsc";
            grillaNombreAsc.ReadOnly = true;
            grillaNombreAsc.Size = new Size(375, 228);
            grillaNombreAsc.TabIndex = 2;
            // 
            // grillaInstrumentoDesc
            // 
            grillaInstrumentoDesc.AllowUserToAddRows = false;
            grillaInstrumentoDesc.AllowUserToDeleteRows = false;
            grillaInstrumentoDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInstrumentoDesc.Location = new Point(20, 330);
            grillaInstrumentoDesc.Name = "grillaInstrumentoDesc";
            grillaInstrumentoDesc.ReadOnly = true;
            grillaInstrumentoDesc.Size = new Size(375, 228);
            grillaInstrumentoDesc.TabIndex = 3;
            // 
            // grillaEdadDesc
            // 
            grillaEdadDesc.AllowUserToAddRows = false;
            grillaEdadDesc.AllowUserToDeleteRows = false;
            grillaEdadDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaEdadDesc.Location = new Point(460, 330);
            grillaEdadDesc.Name = "grillaEdadDesc";
            grillaEdadDesc.ReadOnly = true;
            grillaEdadDesc.Size = new Size(375, 228);
            grillaEdadDesc.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 5;
            label1.Text = "Instrumento ASC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 302);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 6;
            label2.Text = "Instrumento DESC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 30);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 7;
            label3.Text = "Edad ASC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(460, 302);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 8;
            label4.Text = "Edad DESC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(893, 30);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 9;
            label5.Text = "Nombre ASC";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(893, 330);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(127, 26);
            btnOrdenar.TabIndex = 10;
            btnOrdenar.Text = "Ordenar grillas";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 579);
            Controls.Add(btnOrdenar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaEdadDesc);
            Controls.Add(grillaInstrumentoDesc);
            Controls.Add(grillaNombreAsc);
            Controls.Add(grillaEdadAsc);
            Controls.Add(grillaInstrumentoAsc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInstrumentoAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaEdadAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaNombreAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaInstrumentoDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaEdadDesc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaInstrumentoAsc;
        private DataGridView grillaEdadAsc;
        private DataGridView grillaNombreAsc;
        private DataGridView grillaInstrumentoDesc;
        private DataGridView grillaEdadDesc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOrdenar;
    }
}
