namespace CategoriasPeliculas
{
    partial class CategoriasPeliculasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriaIdtextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton2 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // CategoriaIdtextBox
            // 
            this.CategoriaIdtextBox.Location = new System.Drawing.Point(81, 70);
            this.CategoriaIdtextBox.Name = "CategoriaIdtextBox";
            this.CategoriaIdtextBox.Size = new System.Drawing.Size(180, 20);
            this.CategoriaIdtextBox.TabIndex = 2;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(81, 108);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(265, 92);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Consultarbutton.Image = global::CategoriasPeliculas.Properties.Resources.Consult;
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(267, 242);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(79, 31);
            this.Consultarbutton.TabIndex = 8;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = false;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Nuevobutton.Image = global::CategoriasPeliculas.Properties.Resources.Nuevo3;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(182, 242);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(79, 31);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton2
            // 
            this.Eliminarbutton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Eliminarbutton2.Image = global::CategoriasPeliculas.Properties.Resources.Eliminar;
            this.Eliminarbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton2.Location = new System.Drawing.Point(97, 242);
            this.Eliminarbutton2.Name = "Eliminarbutton2";
            this.Eliminarbutton2.Size = new System.Drawing.Size(79, 31);
            this.Eliminarbutton2.TabIndex = 6;
            this.Eliminarbutton2.Text = "Eliminar";
            this.Eliminarbutton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton2.UseVisualStyleBackColor = false;
            this.Eliminarbutton2.Click += new System.EventHandler(this.Eliminarbutton2_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Guardarbutton.Image = global::CategoriasPeliculas.Properties.Resources.Guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(12, 242);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(79, 31);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Buscarbutton.Image = global::CategoriasPeliculas.Properties.Resources.Buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(267, 61);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(79, 29);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CategoriasPeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 307);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton2);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CategoriaIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CategoriasPeliculasForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CategoriasPeliculasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoriaIdtextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton2;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Consultarbutton;
    }
}

