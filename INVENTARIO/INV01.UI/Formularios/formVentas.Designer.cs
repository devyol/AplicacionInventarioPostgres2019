namespace INV01.UI.Formularios
{
    partial class formVentas
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
            this.btncerrarventas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncerrarventas
            // 
            this.btncerrarventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrarventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btncerrarventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrarventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarventas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarventas.ForeColor = System.Drawing.Color.White;
            this.btncerrarventas.Location = new System.Drawing.Point(678, 496);
            this.btncerrarventas.Name = "btncerrarventas";
            this.btncerrarventas.Size = new System.Drawing.Size(107, 38);
            this.btncerrarventas.TabIndex = 1;
            this.btncerrarventas.Text = "Cerrar";
            this.btncerrarventas.UseVisualStyleBackColor = false;
            this.btncerrarventas.Click += new System.EventHandler(this.btncerrarventas_Click);
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(797, 546);
            this.Controls.Add(this.btncerrarventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVentas";
            this.Text = "Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrarventas;

    }
}