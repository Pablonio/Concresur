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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_gasto
            // 
            this.add_gasto.Location = new System.Drawing.Point(81, 296);
            this.add_gasto.Name = "add_gasto";
            this.add_gasto.Size = new System.Drawing.Size(127, 42);
            this.add_gasto.TabIndex = 0;
            this.add_gasto.Text = "Agregar Gasto";
            this.add_gasto.UseVisualStyleBackColor = true;
            this.add_gasto.Click += new System.EventHandler(this.add_gasto_Click);
            // 
            // dlt_gasto
            // 
            this.dlt_gasto.Location = new System.Drawing.Point(81, 221);
            this.dlt_gasto.Name = "dlt_gasto";
            this.dlt_gasto.Size = new System.Drawing.Size(127, 42);
            this.dlt_gasto.TabIndex = 1;
            this.dlt_gasto.Text = "Eliminar Gasto";
            this.dlt_gasto.UseVisualStyleBackColor = true;
            this.dlt_gasto.Click += new System.EventHandler(this.dlt_gasto_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(249, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 204);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Gastofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dlt_gasto);
            this.Controls.Add(this.add_gasto);
            this.Name = "Gastofrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_gasto;
        private System.Windows.Forms.Button dlt_gasto;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}