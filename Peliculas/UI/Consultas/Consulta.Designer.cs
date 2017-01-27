namespace Peliculas.UI.Consultas
{
    partial class Consulta
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
            this.VerListabutton = new System.Windows.Forms.Button();
            this.VerListadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VerListadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VerListabutton
            // 
            this.VerListabutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.VerListabutton.Image = global::Peliculas.Properties.Resources.Buscar;
            this.VerListabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerListabutton.Location = new System.Drawing.Point(12, 12);
            this.VerListabutton.Name = "VerListabutton";
            this.VerListabutton.Size = new System.Drawing.Size(75, 36);
            this.VerListabutton.TabIndex = 0;
            this.VerListabutton.Text = "Ver Lista";
            this.VerListabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerListabutton.UseVisualStyleBackColor = false;
            this.VerListabutton.Click += new System.EventHandler(this.VerListabutton_Click);
            // 
            // VerListadataGridView
            // 
            this.VerListadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerListadataGridView.Location = new System.Drawing.Point(12, 70);
            this.VerListadataGridView.Name = "VerListadataGridView";
            this.VerListadataGridView.Size = new System.Drawing.Size(356, 261);
            this.VerListadataGridView.TabIndex = 1;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 336);
            this.Controls.Add(this.VerListadataGridView);
            this.Controls.Add(this.VerListabutton);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.VerListadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerListabutton;
        private System.Windows.Forms.DataGridView VerListadataGridView;
    }
}