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
            this.add_monto = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.add_desc = new System.Windows.Forms.TextBox();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.lblSaldoDisponible = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // add_gasto
            // 
            this.add_gasto.Location = new System.Drawing.Point(61, 101);
            this.add_gasto.Name = "add_gasto";
            this.add_gasto.Size = new System.Drawing.Size(127, 42);
            this.add_gasto.TabIndex = 0;
            this.add_gasto.Text = "Agregar Gasto";
            this.add_gasto.UseVisualStyleBackColor = true;
            this.add_gasto.Click += new System.EventHandler(this.add_gasto_Click);
            // 
            // dlt_gasto
            // 
            this.dlt_gasto.Location = new System.Drawing.Point(61, 162);
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
            this.listBox1.Location = new System.Drawing.Point(358, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 284);
            this.listBox1.TabIndex = 2;
            // 
            // add_monto
            // 
            this.add_monto.Location = new System.Drawing.Point(358, 117);
            this.add_monto.Name = "add_monto";
            this.add_monto.Size = new System.Drawing.Size(379, 26);
            this.add_monto.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 229);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // add_desc
            // 
            this.add_desc.Location = new System.Drawing.Point(358, 162);
            this.add_desc.Name = "add_desc";
            this.add_desc.Size = new System.Drawing.Size(379, 26);
            this.add_desc.TabIndex = 5;
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.ItemHeight = 20;
            this.listBoxCategorias.Location = new System.Drawing.Point(759, 116);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(390, 384);
            this.listBoxCategorias.TabIndex = 6;
            // 
            // lblSaldoDisponible
            // 
            this.lblSaldoDisponible.AutoSize = true;
            this.lblSaldoDisponible.Location = new System.Drawing.Point(1064, 62);
            this.lblSaldoDisponible.Name = "lblSaldoDisponible";
            this.lblSaldoDisponible.Size = new System.Drawing.Size(51, 20);
            this.lblSaldoDisponible.TabIndex = 7;
            this.lblSaldoDisponible.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 539);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1134, 115);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Gastofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 698);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblSaldoDisponible);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.add_desc);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.add_monto);
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
        private System.Windows.Forms.TextBox add_monto;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox add_desc;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Label lblSaldoDisponible;
        private System.Windows.Forms.ListView listView1;
    }
}