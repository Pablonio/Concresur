namespace Concresur
{
    partial class Bienvenido
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
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.lbl_texto_bienv = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.insrt_sald_ini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.Location = new System.Drawing.Point(128, 37);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(87, 20);
            this.lbl_Bienvenida.TabIndex = 0;
            this.lbl_Bienvenida.Text = "Bienvenido";
            // 
            // lbl_texto_bienv
            // 
            this.lbl_texto_bienv.AutoSize = true;
            this.lbl_texto_bienv.Location = new System.Drawing.Point(55, 85);
            this.lbl_texto_bienv.Name = "lbl_texto_bienv";
            this.lbl_texto_bienv.Size = new System.Drawing.Size(261, 20);
            this.lbl_texto_bienv.TabIndex = 1;
            this.lbl_texto_bienv.Text = "Introduce el saldo Inicial que tienes ";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(50, 151);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(257, 26);
            this.txt_saldo.TabIndex = 2;
            // 
            // insrt_sald_ini
            // 
            this.insrt_sald_ini.BackColor = System.Drawing.Color.Teal;
            this.insrt_sald_ini.Location = new System.Drawing.Point(132, 222);
            this.insrt_sald_ini.Name = "insrt_sald_ini";
            this.insrt_sald_ini.Size = new System.Drawing.Size(91, 50);
            this.insrt_sald_ini.TabIndex = 3;
            this.insrt_sald_ini.Text = "Insertar";
            this.insrt_sald_ini.UseVisualStyleBackColor = false;
            this.insrt_sald_ini.Click += new System.EventHandler(this.insrt_sald_ini_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(352, 317);
            this.Controls.Add(this.insrt_sald_ini);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.lbl_texto_bienv);
            this.Controls.Add(this.lbl_Bienvenida);
            this.Name = "Bienvenido";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.Label lbl_texto_bienv;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button insrt_sald_ini;
    }
}