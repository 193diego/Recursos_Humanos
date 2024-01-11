
namespace Recursos_Humanos
{
    partial class frmasistenciaempleado
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
            this.btnmarcasalida = new MaterialSkin.Controls.MaterialButton();
            this.btnmarcaentrada = new MaterialSkin.Controls.MaterialButton();
            this.btnconsultaasistencia = new MaterialSkin.Controls.MaterialButton();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnmarcasalida);
            this.materialCard1.Controls.Add(this.btnmarcaentrada);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(531, 130);
            this.materialCard1.TabIndex = 0;
            // 
            // btnmarcasalida
            // 
            this.btnmarcasalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmarcasalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnmarcasalida.Depth = 0;
            this.btnmarcasalida.HighEmphasis = true;
            this.btnmarcasalida.Icon = global::Recursos_Humanos.Properties.Resources.ic_salida;
            this.btnmarcasalida.Location = new System.Drawing.Point(326, 46);
            this.btnmarcasalida.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnmarcasalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmarcasalida.Name = "btnmarcasalida";
            this.btnmarcasalida.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnmarcasalida.Size = new System.Drawing.Size(163, 36);
            this.btnmarcasalida.TabIndex = 1;
            this.btnmarcasalida.Text = "Marcar Salida";
            this.btnmarcasalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnmarcasalida.UseAccentColor = false;
            this.btnmarcasalida.UseVisualStyleBackColor = true;
            this.btnmarcasalida.Click += new System.EventHandler(this.btnmarcasalida_Click);
            // 
            // btnmarcaentrada
            // 
            this.btnmarcaentrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmarcaentrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnmarcaentrada.Depth = 0;
            this.btnmarcaentrada.HighEmphasis = true;
            this.btnmarcaentrada.Icon = global::Recursos_Humanos.Properties.Resources.ic_entrada;
            this.btnmarcaentrada.Location = new System.Drawing.Point(31, 46);
            this.btnmarcaentrada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnmarcaentrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmarcaentrada.Name = "btnmarcaentrada";
            this.btnmarcaentrada.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnmarcaentrada.Size = new System.Drawing.Size(179, 36);
            this.btnmarcaentrada.TabIndex = 0;
            this.btnmarcaentrada.Text = "Marcar Entrada";
            this.btnmarcaentrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnmarcaentrada.UseAccentColor = false;
            this.btnmarcaentrada.UseVisualStyleBackColor = true;
            this.btnmarcaentrada.Click += new System.EventHandler(this.btnmarcaentrada_Click);
            // 
            // btnconsultaasistencia
            // 
            this.btnconsultaasistencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnconsultaasistencia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnconsultaasistencia.Depth = 0;
            this.btnconsultaasistencia.HighEmphasis = true;
            this.btnconsultaasistencia.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btnconsultaasistencia.Location = new System.Drawing.Point(174, 228);
            this.btnconsultaasistencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnconsultaasistencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnconsultaasistencia.Name = "btnconsultaasistencia";
            this.btnconsultaasistencia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnconsultaasistencia.Size = new System.Drawing.Size(221, 36);
            this.btnconsultaasistencia.TabIndex = 1;
            this.btnconsultaasistencia.Text = "Consultar Asistencia";
            this.btnconsultaasistencia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnconsultaasistencia.UseAccentColor = false;
            this.btnconsultaasistencia.UseVisualStyleBackColor = true;
            this.btnconsultaasistencia.Click += new System.EventHandler(this.btnconsultaasistencia_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(250, 293);
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
            // frmasistenciaempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 346);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconsultaasistencia);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmasistenciaempleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.frmasistenciaempleado_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnmarcasalida;
        private MaterialSkin.Controls.MaterialButton btnmarcaentrada;
        private MaterialSkin.Controls.MaterialButton btnconsultaasistencia;
        private MaterialSkin.Controls.MaterialButton btnsalir;
    }
}