namespace Concresur
{
    partial class Start
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
            this.add_categoria = new System.Windows.Forms.Button();
            this.dlt_categoria = new System.Windows.Forms.Button();
            this.nme_of_ctgry = new System.Windows.Forms.TextBox();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // add_categoria
            // 
            this.add_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_categoria.Location = new System.Drawing.Point(98, 141);
            this.add_categoria.Name = "add_categoria";
            this.add_categoria.Size = new System.Drawing.Size(146, 49);
            this.add_categoria.TabIndex = 0;
            this.add_categoria.Text = "Anadir categoria";
            this.add_categoria.UseVisualStyleBackColor = false;
            this.add_categoria.Click += new System.EventHandler(this.add_categoria_Click);
            // 
            // dlt_categoria
            // 
            this.dlt_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dlt_categoria.Location = new System.Drawing.Point(98, 222);
            this.dlt_categoria.Name = "dlt_categoria";
            this.dlt_categoria.Size = new System.Drawing.Size(146, 55);
            this.dlt_categoria.TabIndex = 1;
            this.dlt_categoria.Text = "Eliminar categoria";
            this.dlt_categoria.UseVisualStyleBackColor = false;
            this.dlt_categoria.Click += new System.EventHandler(this.dlt_categoria_Click);
            // 
            // nme_of_ctgry
            // 
            this.nme_of_ctgry.Location = new System.Drawing.Point(326, 141);
            this.nme_of_ctgry.Name = "nme_of_ctgry";
            this.nme_of_ctgry.Size = new System.Drawing.Size(400, 26);
            this.nme_of_ctgry.TabIndex = 2;
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.ItemHeight = 20;
            this.listBoxCategorias.Location = new System.Drawing.Point(312, 239);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(400, 304);
            this.listBoxCategorias.TabIndex = 3;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(839, 644);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.nme_of_ctgry);
            this.Controls.Add(this.dlt_categoria);
            this.Controls.Add(this.add_categoria);
            this.Name = "Start";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_categoria;
        private System.Windows.Forms.Button dlt_categoria;
        private System.Windows.Forms.TextBox nme_of_ctgry;
        private System.Windows.Forms.ListBox listBoxCategorias;
    }
}