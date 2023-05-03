namespace Concresur
{
    partial class Gastofrm
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
            this.add_gasto = new System.Windows.Forms.Button();
            this.dlt_gasto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_gasto
            // 
            this.add_gasto.Location = new System.Drawing.Point(81, 376);
            this.add_gasto.Name = "add_gasto";
            this.add_gasto.Size = new System.Drawing.Size(127, 42);
            this.add_gasto.TabIndex = 0;
            this.add_gasto.Text = "Agregar Gasto";
            this.add_gasto.UseVisualStyleBackColor = true;
            this.add_gasto.Click += new System.EventHandler(this.add_gasto_Click);
            // 
            // dlt_gasto
            // 
            this.dlt_gasto.Location = new System.Drawing.Point(81, 304);
            this.dlt_gasto.Name = "dlt_gasto";
            this.dlt_gasto.Size = new System.Drawing.Size(127, 42);
            this.dlt_gasto.TabIndex = 1;
            this.dlt_gasto.Text = "Eliminar Gasto";
            this.dlt_gasto.UseVisualStyleBackColor = true;
            this.dlt_gasto.Click += new System.EventHandler(this.dlt_gasto_Click);
            // 
            // Gastofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 518);
            this.Controls.Add(this.dlt_gasto);
            this.Controls.Add(this.add_gasto);
            this.Name = "Gastofrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_gasto;
        private System.Windows.Forms.Button dlt_gasto;
    }
}