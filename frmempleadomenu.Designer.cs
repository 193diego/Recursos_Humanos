
namespace Recursos_Humanos
{
    partial class frmempleadomenu
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
            this.cardmenu = new MaterialSkin.Controls.MaterialCard();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            this.btnsolicitarvacaciones = new MaterialSkin.Controls.MaterialButton();
            this.btnasistencia = new MaterialSkin.Controls.MaterialButton();
            this.cardmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardmenu
            // 
            this.cardmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardmenu.Controls.Add(this.btnsalir);
            this.cardmenu.Controls.Add(this.btnsolicitarvacaciones);
            this.cardmenu.Controls.Add(this.btnasistencia);
            this.cardmenu.Depth = 0;
            this.cardmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardmenu.Location = new System.Drawing.Point(42, 78);
            this.cardmenu.Margin = new System.Windows.Forms.Padding(14);
            this.cardmenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardmenu.Name = "cardmenu";
            this.cardmenu.Padding = new System.Windows.Forms.Padding(14);
            this.cardmenu.Size = new System.Drawing.Size(363, 297);
            this.cardmenu.TabIndex = 2;
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(134, 210);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsalir.Size = new System.Drawing.Size(89, 36);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsalir.UseAccentColor = false;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnsolicitarvacaciones
            // 
            this.btnsolicitarvacaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsolicitarvacaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsolicitarvacaciones.Depth = 0;
            this.btnsolicitarvacaciones.HighEmphasis = true;
            this.btnsolicitarvacaciones.Icon = global::Recursos_Humanos.Properties.Resources.ic_vacaciones;
            this.btnsolicitarvacaciones.Location = new System.Drawing.Point(70, 128);
            this.btnsolicitarvacaciones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsolicitarvacaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsolicitarvacaciones.Name = "btnsolicitarvacaciones";
            this.btnsolicitarvacaciones.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsolicitarvacaciones.Size = new System.Drawing.Size(216, 36);
            this.btnsolicitarvacaciones.TabIndex = 1;
            this.btnsolicitarvacaciones.Text = "Solicitar Vacaciones";
            this.btnsolicitarvacaciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsolicitarvacaciones.UseAccentColor = false;
            this.btnsolicitarvacaciones.UseVisualStyleBackColor = true;
            this.btnsolicitarvacaciones.Click += new System.EventHandler(this.btnsolicitarvacaciones_Click);
            // 
            // btnasistencia
            // 
            this.btnasistencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnasistencia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnasistencia.Depth = 0;
            this.btnasistencia.HighEmphasis = true;
            this.btnasistencia.Icon = global::Recursos_Humanos.Properties.Resources.ic_asistencia;
            this.btnasistencia.Location = new System.Drawing.Point(112, 46);
            this.btnasistencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnasistencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnasistencia.Name = "btnasistencia";
            this.btnasistencia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnasistencia.Size = new System.Drawing.Size(132, 36);
            this.btnasistencia.TabIndex = 0;
            this.btnasistencia.Text = "Asistencia";
            this.btnasistencia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnasistencia.UseAccentColor = false;
            this.btnasistencia.UseVisualStyleBackColor = true;
            this.btnasistencia.Click += new System.EventHandler(this.btnasistencia_Click);
            // 
            // frmempleadomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 408);
            this.Controls.Add(this.cardmenu);
            this.MaximizeBox = false;
            this.Name = "frmempleadomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Empleado";
            this.Load += new System.EventHandler(this.frmempleadomenu_Load);
            this.cardmenu.ResumeLayout(false);
            this.cardmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard cardmenu;
        private MaterialSkin.Controls.MaterialButton btnsalir;
        private MaterialSkin.Controls.MaterialButton btnsolicitarvacaciones;
        private MaterialSkin.Controls.MaterialButton btnasistencia;
    }
}