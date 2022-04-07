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
            this.button1 = new System.Windows.Forms.Button();
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
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutBase.Controls.Add(this.pConstelacion, 0, 0);
            this.layoutBase.Controls.Add(this.pControles, 0, 1);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 2;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutBase.Size = new System.Drawing.Size(1008, 729);
            this.layoutBase.TabIndex = 0;
            // 
            // pConstelacion
            // 
            this.pConstelacion.BackColor = System.Drawing.Color.Black;
            this.pConstelacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConstelacion.Location = new System.Drawing.Point(3, 3);
            this.pConstelacion.Name = "pConstelacion";
            this.pConstelacion.Size = new System.Drawing.Size(1002, 683);
            this.pConstelacion.TabIndex = 0;
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.button1);
            this.pControles.Controls.Add(this.btnEliminar);
            this.pControles.Controls.Add(this.lblNovedades);
            this.pControles.Controls.Add(this.btnAgregar);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(3, 692);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1002, 34);
            this.pControles.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(832, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNovedades
            // 
            this.lblNovedades.AutoSize = true;
            this.lblNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovedades.Location = new System.Drawing.Point(211, 7);
            this.lblNovedades.Name = "lblNovedades";
            this.lblNovedades.Size = new System.Drawing.Size(177, 20);
            this.lblNovedades.TabIndex = 1;
            this.lblNovedades.Text = "Cantidad de Estrellas: 0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(39, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Estrella";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConstelacionVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.layoutBase);
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
        private System.Windows.Forms.Button button1;
    }
}

