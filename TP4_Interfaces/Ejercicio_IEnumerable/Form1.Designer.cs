namespace Ejercicio_IEnumerable
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
            grillaPlaylist = new DataGridView();
            btnAgregarCancion = new Button();
            btnRecorrerPlaylist = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaPlaylist).BeginInit();
            SuspendLayout();
            // 
            // grillaPlaylist
            // 
            grillaPlaylist.AllowUserToAddRows = false;
            grillaPlaylist.AllowUserToDeleteRows = false;
            grillaPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPlaylist.Location = new Point(32, 53);
            grillaPlaylist.Name = "grillaPlaylist";
            grillaPlaylist.ReadOnly = true;
            grillaPlaylist.Size = new Size(417, 215);
            grillaPlaylist.TabIndex = 0;
            // 
            // btnAgregarCancion
            // 
            btnAgregarCancion.Location = new Point(32, 274);
            btnAgregarCancion.Name = "btnAgregarCancion";
            btnAgregarCancion.Size = new Size(181, 23);
            btnAgregarCancion.TabIndex = 1;
            btnAgregarCancion.Text = "Agregar canción";
            btnAgregarCancion.UseVisualStyleBackColor = true;
            btnAgregarCancion.Click += btnAgregarCancion_Click;
            // 
            // btnRecorrerPlaylist
            // 
            btnRecorrerPlaylist.Location = new Point(268, 274);
            btnRecorrerPlaylist.Name = "btnRecorrerPlaylist";
            btnRecorrerPlaylist.Size = new Size(181, 23);
            btnRecorrerPlaylist.TabIndex = 2;
            btnRecorrerPlaylist.Text = "Recorrer playlist";
            btnRecorrerPlaylist.UseVisualStyleBackColor = true;
            btnRecorrerPlaylist.Click += btnRecorrerPlaylist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "Playlist";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 328);
            Controls.Add(label1);
            Controls.Add(btnRecorrerPlaylist);
            Controls.Add(btnAgregarCancion);
            Controls.Add(grillaPlaylist);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaPlaylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaPlaylist;
        private Button btnAgregarCancion;
        private Button btnRecorrerPlaylist;
        private Label label1;
    }
}
