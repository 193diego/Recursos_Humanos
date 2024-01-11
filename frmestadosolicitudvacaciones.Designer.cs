
namespace Recursos_Humanos
{
    partial class frmestadosolicitudvacaciones
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
            this.dgvsolicitudvacaciones = new System.Windows.Forms.DataGridView();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            this.txtcomentarioadmin = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitudvacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsolicitudvacaciones
            // 
            this.dgvsolicitudvacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsolicitudvacaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvsolicitudvacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsolicitudvacaciones.Location = new System.Drawing.Point(24, 91);
            this.dgvsolicitudvacaciones.Name = "dgvsolicitudvacaciones";
            this.dgvsolicitudvacaciones.Size = new System.Drawing.Size(522, 198);
            this.dgvsolicitudvacaciones.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(421, 373);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsalir.Size = new System.Drawing.Size(89, 36);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsalir.UseAccentColor = false;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtcomentarioadmin
            // 
            this.txtcomentarioadmin.Enabled = false;
            this.txtcomentarioadmin.Location = new System.Drawing.Point(24, 340);
            this.txtcomentarioadmin.Multiline = true;
            this.txtcomentarioadmin.Name = "txtcomentarioadmin";
            this.txtcomentarioadmin.Size = new System.Drawing.Size(272, 97);
            this.txtcomentarioadmin.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(49, 309);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(212, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Comentario de Administrador:";
            // 
            // frmestadosolicitudvacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtcomentarioadmin);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvsolicitudvacaciones);
            this.Name = "frmestadosolicitudvacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de Solicitud de Vacaciones";
            this.Load += new System.EventHandler(this.frmestadosolicitudvacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitudvacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsolicitudvacaciones;
        private MaterialSkin.Controls.MaterialButton btnsalir;
        private System.Windows.Forms.TextBox txtcomentarioadmin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}