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
            this.btn_wnd_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wnd_add
            // 
            this.btn_wnd_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_wnd_add.Location = new System.Drawing.Point(816, 161);
            this.btn_wnd_add.Name = "btn_wnd_add";
            this.btn_wnd_add.Size = new System.Drawing.Size(110, 57);
            this.btn_wnd_add.TabIndex = 0;
            this.btn_wnd_add.Text = "Agregar Nuevo Gasto";
            this.btn_wnd_add.UseVisualStyleBackColor = false;
            this.btn_wnd_add.Click += new System.EventHandler(this.btn_wnd_add_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1173, 835);
            this.Controls.Add(this.btn_wnd_add);
            this.Name = "Start";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_wnd_add;
    }
}