namespace Pav.U3.DelegadosProblema
{
    partial class EstrellaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEstrella = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstrella
            // 
            this.lblEstrella.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrella.ForeColor = System.Drawing.Color.White;
            this.lblEstrella.Location = new System.Drawing.Point(-4, -17);
            this.lblEstrella.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstrella.Name = "lblEstrella";
            this.lblEstrella.Size = new System.Drawing.Size(31, 41);
            this.lblEstrella.TabIndex = 0;
            this.lblEstrella.Text = "·";
            // 
            // EstrellaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblEstrella);
            this.Name = "EstrellaControl";
            this.Size = new System.Drawing.Size(25, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstrella;
    }
}
