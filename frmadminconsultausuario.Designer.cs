
namespace Recursos_Humanos
{
    partial class frmadminconsultausuario
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
            this.txtcaracter = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnlimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnbuscar = new MaterialSkin.Controls.MaterialButton();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnsalir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtcaracter);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btnlimpiar);
            this.materialCard1.Controls.Add(this.btnbuscar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(30, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(741, 54);
            this.materialCard1.TabIndex = 0;
            // 
            // txtcaracter
            // 
            this.txtcaracter.Location = new System.Drawing.Point(156, 17);
            this.txtcaracter.Multiline = true;
            this.txtcaracter.Name = "txtcaracter";
            this.txtcaracter.Size = new System.Drawing.Size(237, 24);
            this.txtcaracter.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(84, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Buscar:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnlimpiar.Depth = 0;
            this.btnlimpiar.HighEmphasis = true;
            this.btnlimpiar.Icon = global::Recursos_Humanos.Properties.Resources.ic_limpiar;
            this.btnlimpiar.Location = new System.Drawing.Point(580, 8);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnlimpiar.Size = new System.Drawing.Size(107, 36);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnlimpiar.UseAccentColor = false;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnbuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnbuscar.Depth = 0;
            this.btnbuscar.HighEmphasis = true;
            this.btnbuscar.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btnbuscar.Location = new System.Drawing.Point(433, 8);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnbuscar.Size = new System.Drawing.Size(105, 36);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnbuscar.UseAccentColor = false;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(30, 140);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.Size = new System.Drawing.Size(741, 259);
            this.dgvusuarios.TabIndex = 1;
            this.dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellContentClick);
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsalir.Depth = 0;
            this.btnsalir.HighEmphasis = true;
            this.btnsalir.Icon = global::Recursos_Humanos.Properties.Resources.ic_salir;
            this.btnsalir.Location = new System.Drawing.Point(386, 407);
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
            // frmadminconsultausuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmadminconsultausuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Usuario";
            this.Load += new System.EventHandler(this.frmadminconsultausuario_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox txtcaracter;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnlimpiar;
        private MaterialSkin.Controls.MaterialButton btnbuscar;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private MaterialSkin.Controls.MaterialButton btnsalir;
    }
}