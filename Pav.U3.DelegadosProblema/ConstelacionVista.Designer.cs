namespace Pav.U3.DelegadosProblema
{
    partial class ConstelacionVista
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
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.pConstelacion = new System.Windows.Forms.Panel();
            this.pControles = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNovedades = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.layoutBase.SuspendLayout();
            this.pControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutBase
            // 
            this.layoutBase.ColumnCount = 1;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutBase.Controls.Add(this.pConstelacion, 0, 0);
            this.layoutBase.Controls.Add(this.pControles, 0, 1);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 2;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutBase.Size = new System.Drawing.Size(1344, 897);
            this.layoutBase.TabIndex = 0;
            // 
            // pConstelacion
            // 
            this.pConstelacion.BackColor = System.Drawing.Color.Black;
            this.pConstelacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConstelacion.Location = new System.Drawing.Point(4, 4);
            this.pConstelacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pConstelacion.Name = "pConstelacion";
            this.pConstelacion.Size = new System.Drawing.Size(1336, 840);
            this.pConstelacion.TabIndex = 0;
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.btnEliminar);
            this.pControles.Controls.Add(this.lblNovedades);
            this.pControles.Controls.Add(this.btnAgregar);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(4, 852);
            this.pControles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1336, 41);
            this.pControles.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1109, 7);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNovedades
            // 
            this.lblNovedades.AutoSize = true;
            this.lblNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovedades.Location = new System.Drawing.Point(281, 9);
            this.lblNovedades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNovedades.Name = "lblNovedades";
            this.lblNovedades.Size = new System.Drawing.Size(219, 25);
            this.lblNovedades.TabIndex = 1;
            this.lblNovedades.Text = "Cantidad de Estrellas: 0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(52, 7);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(153, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Estrella";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConstelacionVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.layoutBase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConstelacionVista";
            this.Text = "Mi Constelación";
            this.layoutBase.ResumeLayout(false);
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.Panel pConstelacion;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNovedades;
        private System.Windows.Forms.Button btnEliminar;
    }
}

