
namespace Recursos_Humanos
{
    partial class frmeditarusuario
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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.cbotipousuario = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnaceptar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.cbotipousuario);
            this.materialCard3.Controls.Add(this.txtclave);
            this.materialCard3.Controls.Add(this.txtusuario);
            this.materialCard3.Controls.Add(this.materialLabel8);
            this.materialCard3.Controls.Add(this.materialLabel9);
            this.materialCard3.Controls.Add(this.materialLabel10);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(35, 78);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(527, 201);
            this.materialCard3.TabIndex = 2;
            // 
            // cbotipousuario
            // 
            this.cbotipousuario.FormattingEnabled = true;
            this.cbotipousuario.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cbotipousuario.Location = new System.Drawing.Point(370, 79);
            this.cbotipousuario.Name = "cbotipousuario";
            this.cbotipousuario.Size = new System.Drawing.Size(130, 21);
            this.cbotipousuario.TabIndex = 5;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(82, 140);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(130, 20);
            this.txtclave.TabIndex = 4;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(82, 27);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(130, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(244, 81);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(116, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Tipo de Usuario:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(13, 140);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(44, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Clave:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(13, 28);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(63, 19);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "Usuario: ";
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = global::Recursos_Humanos.Properties.Resources.ic_cancelar;
            this.btncancelar.Location = new System.Drawing.Point(328, 299);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnaceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnaceptar.Depth = 0;
            this.btnaceptar.HighEmphasis = true;
            this.btnaceptar.Icon = global::Recursos_Humanos.Properties.Resources.ic_aceptar;
            this.btnaceptar.Location = new System.Drawing.Point(117, 299);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnaceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnaceptar.Size = new System.Drawing.Size(114, 36);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnaceptar.UseAccentColor = false;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmeditarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 365);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.materialCard3);
            this.Name = "frmeditarusuario";
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.frmeditarusuario_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.ComboBox cbotipousuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btnaceptar;
        private MaterialSkin.Controls.MaterialButton btncancelar;
    }
}