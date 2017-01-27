namespace Registros.UI.Consultas
{
    partial class Consultas
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
            this.ConsultaUsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.Verbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaUsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaUsuariodataGridView
            // 
            this.ConsultaUsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaUsuariodataGridView.Location = new System.Drawing.Point(12, 60);
            this.ConsultaUsuariodataGridView.Name = "ConsultaUsuariodataGridView";
            this.ConsultaUsuariodataGridView.Size = new System.Drawing.Size(353, 261);
            this.ConsultaUsuariodataGridView.TabIndex = 0;
            // 
            // Verbutton
            // 
            this.Verbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Verbutton.Image = global::Registros.Properties.Resources.Buscar;
            this.Verbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Verbutton.Location = new System.Drawing.Point(12, 12);
            this.Verbutton.Name = "Verbutton";
            this.Verbutton.Size = new System.Drawing.Size(75, 33);
            this.Verbutton.TabIndex = 1;
            this.Verbutton.Text = "Ver lista";
            this.Verbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Verbutton.UseVisualStyleBackColor = false;
            this.Verbutton.Click += new System.EventHandler(this.Verbutton_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 338);
            this.Controls.Add(this.Verbutton);
            this.Controls.Add(this.ConsultaUsuariodataGridView);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaUsuariodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaUsuariodataGridView;
        private System.Windows.Forms.Button Verbutton;
    }
}