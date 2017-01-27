namespace MenuPrincipal
{
    partial class Form1
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
            this.Peliculasbutton = new System.Windows.Forms.Button();
            this.Categoriasbutton = new System.Windows.Forms.Button();
            this.Usuariosbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Peliculasbutton
            // 
            this.Peliculasbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Peliculasbutton.Image = global::MenuPrincipal.Properties.Resources.Peliculas;
            this.Peliculasbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Peliculasbutton.Location = new System.Drawing.Point(132, 216);
            this.Peliculasbutton.Name = "Peliculasbutton";
            this.Peliculasbutton.Size = new System.Drawing.Size(101, 32);
            this.Peliculasbutton.TabIndex = 4;
            this.Peliculasbutton.Text = "Peliculas";
            this.Peliculasbutton.UseVisualStyleBackColor = false;
            this.Peliculasbutton.Click += new System.EventHandler(this.Peliculasbutton_Click);
            // 
            // Categoriasbutton
            // 
            this.Categoriasbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Categoriasbutton.Image = global::MenuPrincipal.Properties.Resources.Categorias;
            this.Categoriasbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categoriasbutton.Location = new System.Drawing.Point(132, 157);
            this.Categoriasbutton.Name = "Categoriasbutton";
            this.Categoriasbutton.Size = new System.Drawing.Size(101, 32);
            this.Categoriasbutton.TabIndex = 3;
            this.Categoriasbutton.Text = "Categorias";
            this.Categoriasbutton.UseVisualStyleBackColor = false;
            this.Categoriasbutton.Click += new System.EventHandler(this.Categoriasbutton_Click);
            // 
            // Usuariosbutton
            // 
            this.Usuariosbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Usuariosbutton.Image = global::MenuPrincipal.Properties.Resources.Usuario;
            this.Usuariosbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuariosbutton.Location = new System.Drawing.Point(132, 99);
            this.Usuariosbutton.Name = "Usuariosbutton";
            this.Usuariosbutton.Size = new System.Drawing.Size(101, 32);
            this.Usuariosbutton.TabIndex = 2;
            this.Usuariosbutton.Text = "Usuarios";
            this.Usuariosbutton.UseVisualStyleBackColor = false;
            this.Usuariosbutton.Click += new System.EventHandler(this.Usuariosbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 299);
            this.Controls.Add(this.Peliculasbutton);
            this.Controls.Add(this.Categoriasbutton);
            this.Controls.Add(this.Usuariosbutton);
            this.Name = "Form1";
            this.Text = "Menu Registros";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Usuariosbutton;
        private System.Windows.Forms.Button Categoriasbutton;
        private System.Windows.Forms.Button Peliculasbutton;
    }
}

