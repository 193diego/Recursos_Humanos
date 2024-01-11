
namespace Recursos_Humanos
{
    partial class frmsolicitavacaciones
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnenviarsolicitud = new MaterialSkin.Controls.MaterialButton();
            this.btnestadovacaciones = new MaterialSkin.Controls.MaterialButton();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmotivo);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.dtphasta);
            this.materialCard1.Controls.Add(this.dtpdesde);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(686, 199);
            this.materialCard1.TabIndex = 0;
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(207, 95);
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(288, 78);
            this.txtmotivo.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(324, 63);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Motivo:";
            // 
            // dtphasta
            // 
            this.dtphasta.Location = new System.Drawing.Point(415, 17);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(246, 20);
            this.dtphasta.TabIndex = 3;
            // 
            // dtpdesde
            // 
            this.dtpdesde.Location = new System.Drawing.Point(82, 17);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(246, 20);
            this.dtpdesde.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(352, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Hasta:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Desde:";
            // 
            // btnenviarsolicitud
            // 
            this.btnenviarsolicitud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnenviarsolicitud.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnenviarsolicitud.Depth = 0;
            this.btnenviarsolicitud.HighEmphasis = true;
            this.btnenviarsolicitud.Icon = global::Recursos_Humanos.Properties.Resources.ic_enviar;
            this.btnenviarsolicitud.Location = new System.Drawing.Point(57, 308);
            this.btnenviarsolicitud.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnenviarsolicitud.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnenviarsolicitud.Name = "btnenviarsolicitud";
            this.btnenviarsolicitud.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnenviarsolicitud.Size = new System.Drawing.Size(178, 36);
            this.btnenviarsolicitud.TabIndex = 1;
            this.btnenviarsolicitud.Text = "Enviar Solicitud";
            this.btnenviarsolicitud.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnenviarsolicitud.UseAccentColor = false;
            this.btnenviarsolicitud.UseVisualStyleBackColor = true;
            this.btnenviarsolicitud.Click += new System.EventHandler(this.btnenviarsolicitud_Click);
            // 
            // btnestadovacaciones
            // 
            this.btnestadovacaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnestadovacaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnestadovacaciones.Depth = 0;
            this.btnestadovacaciones.HighEmphasis = true;
            this.btnestadovacaciones.Icon = global::Recursos_Humanos.Properties.Resources.ic_ver;
            this.btnestadovacaciones.Location = new System.Drawing.Point(280, 308);
            this.btnestadovacaciones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnestadovacaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnestadovacaciones.Name = "btnestadovacaciones";
            this.btnestadovacaciones.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnestadovacaciones.Size = new System.Drawing.Size(235, 36);
            this.btnestadovacaciones.TabIndex = 2;
            this.btnestadovacaciones.Text = "Ver Estado de Solicitud";
            this.btnestadovacaciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnestadovacaciones.UseAccentColor = false;
            this.btnestadovacaciones.UseVisualStyleBackColor = true;
            this.btnestadovacaciones.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(560, 308);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsalir.Size = new System.Drawing.Size(89, 36);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsalir.UseAccentColor = false;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmsolicitavacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 371);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnestadovacaciones);
            this.Controls.Add(this.btnenviarsolicitud);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsolicitavacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Vacaciones";
            this.Load += new System.EventHandler(this.frmsolicitavacaciones_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnenviarsolicitud;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtmotivo;
        private MaterialSkin.Controls.MaterialButton btnestadovacaciones;
        private MaterialSkin.Controls.MaterialButton btnsalir;
    }
}