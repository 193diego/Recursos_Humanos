
namespace Recursos_Humanos
{
    partial class frmasistenciaconsulta
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
            this.dgvasistencia = new System.Windows.Forms.DataGridView();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvasistencia
            // 
            this.dgvasistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvasistencia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvasistencia.Location = new System.Drawing.Point(17, 86);
            this.dgvasistencia.Name = "dgvasistencia";
            this.dgvasistencia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvasistencia.Size = new System.Drawing.Size(685, 349);
            this.dgvasistencia.TabIndex = 1;
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(315, 452);
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
            // frmasistenciaconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 500);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvasistencia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmasistenciaconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Asistencia";
            this.Load += new System.EventHandler(this.frmasistenciaconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvasistencia;
        private MaterialSkin.Controls.MaterialButton btnsalir;
    }
}