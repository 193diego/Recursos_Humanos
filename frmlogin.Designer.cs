
namespace Recursos_Humanos
{
    partial class frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtusuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtclave = new MaterialSkin.Controls.MaterialTextBox2();
            this.btningresar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(30, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Usuario:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(30, 181);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Clave:";
            // 
            // txtusuario
            // 
            this.txtusuario.AnimateReadOnly = false;
            this.txtusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusuario.Depth = 0;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtusuario.HideSelection = true;
            this.txtusuario.LeadingIcon = null;
            this.txtusuario.Location = new System.Drawing.Point(30, 117);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.PrefixSuffixText = null;
            this.txtusuario.ReadOnly = false;
            this.txtusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.ShortcutsEnabled = true;
            this.txtusuario.Size = new System.Drawing.Size(250, 48);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.TabStop = false;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusuario.TrailingIcon = null;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // txtclave
            // 
            this.txtclave.AnimateReadOnly = false;
            this.txtclave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtclave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtclave.Depth = 0;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtclave.HideSelection = true;
            this.txtclave.LeadingIcon = null;
            this.txtclave.Location = new System.Drawing.Point(30, 216);
            this.txtclave.MaxLength = 32767;
            this.txtclave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '\0';
            this.txtclave.PrefixSuffixText = null;
            this.txtclave.ReadOnly = false;
            this.txtclave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtclave.SelectedText = "";
            this.txtclave.SelectionLength = 0;
            this.txtclave.SelectionStart = 0;
            this.txtclave.ShortcutsEnabled = true;
            this.txtclave.Size = new System.Drawing.Size(250, 48);
            this.txtclave.TabIndex = 3;
            this.txtclave.TabStop = false;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtclave.TrailingIcon = null;
            this.txtclave.UseSystemPasswordChar = false;
            // 
            // btningresar
            // 
            this.btningresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btningresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btningresar.Depth = 0;
            this.btningresar.HighEmphasis = true;
            this.btningresar.Icon = global::Recursos_Humanos.Properties.Resources.ic_ingresar;
            this.btningresar.Location = new System.Drawing.Point(93, 303);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btningresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btningresar.Name = "btningresar";
            this.btningresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btningresar.Size = new System.Drawing.Size(119, 36);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btningresar.UseAccentColor = false;
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 365);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtusuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtclave;
        private MaterialSkin.Controls.MaterialButton btningresar;
    }
}

