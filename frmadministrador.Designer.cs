
namespace Recursos_Humanos
{
    partial class frmadministrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadministrador));
            this.btninforconsulta = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.btninformacionconsul = new MaterialSkin.Controls.MaterialButton();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dtpde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvconsultainfor = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnconsultausuario = new MaterialSkin.Controls.MaterialButton();
            this.btnagregarusuario = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.cbotipousuario = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnconsultainfor = new MaterialSkin.Controls.MaterialCard();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btnregistrarempleado = new MaterialSkin.Controls.MaterialButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cbotipousuarioid = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnversolicitudes = new MaterialSkin.Controls.MaterialButton();
            this.dgvvacaciones = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnregistrarevaluacion = new MaterialSkin.Controls.MaterialButton();
            this.btnconsultacedula = new MaterialSkin.Controls.MaterialButton();
            this.cbocalificacion = new System.Windows.Forms.ComboBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.txtcedulaempleado = new System.Windows.Forms.TextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btninforconsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultainfor)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.btnconsultainfor.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacaciones)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninforconsulta
            // 
            this.btninforconsulta.Controls.Add(this.tabPage1);
            this.btninforconsulta.Controls.Add(this.tabPage6);
            this.btninforconsulta.Controls.Add(this.tabPage2);
            this.btninforconsulta.Controls.Add(this.tabPage3);
            this.btninforconsulta.Controls.Add(this.tabPage4);
            this.btninforconsulta.Depth = 0;
            this.btninforconsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btninforconsulta.ImageList = this.imageList1;
            this.btninforconsulta.Location = new System.Drawing.Point(3, 64);
            this.btninforconsulta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btninforconsulta.Multiline = true;
            this.btninforconsulta.Name = "btninforconsulta";
            this.btninforconsulta.SelectedIndex = 0;
            this.btninforconsulta.ShowToolTips = true;
            this.btninforconsulta.Size = new System.Drawing.Size(749, 402);
            this.btninforconsulta.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard4);
            this.tabPage1.Controls.Add(this.dgvconsultainfor);
            this.tabPage1.ImageKey = "ic_panel.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.btninformacionconsul);
            this.materialCard4.Controls.Add(this.dtphasta);
            this.materialCard4.Controls.Add(this.dtpde);
            this.materialCard4.Controls.Add(this.materialLabel16);
            this.materialCard4.Controls.Add(this.materialLabel15);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(10, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(712, 61);
            this.materialCard4.TabIndex = 1;
            // 
            // btninformacionconsul
            // 
            this.btninformacionconsul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btninformacionconsul.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btninformacionconsul.Depth = 0;
            this.btninformacionconsul.HighEmphasis = true;
            this.btninformacionconsul.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btninformacionconsul.Location = new System.Drawing.Point(568, 14);
            this.btninformacionconsul.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btninformacionconsul.MouseState = MaterialSkin.MouseState.HOVER;
            this.btninformacionconsul.Name = "btninformacionconsul";
            this.btninformacionconsul.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btninformacionconsul.Size = new System.Drawing.Size(134, 36);
            this.btninformacionconsul.TabIndex = 4;
            this.btninformacionconsul.Text = "Consultar";
            this.btninformacionconsul.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btninformacionconsul.UseAccentColor = false;
            this.btninformacionconsul.UseVisualStyleBackColor = true;
            this.btninformacionconsul.Click += new System.EventHandler(this.btninformacionconsul_Click);
            // 
            // dtphasta
            // 
            this.dtphasta.Location = new System.Drawing.Point(339, 21);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(217, 20);
            this.dtphasta.TabIndex = 3;
            // 
            // dtpde
            // 
            this.dtpde.Location = new System.Drawing.Point(56, 21);
            this.dtpde.Name = "dtpde";
            this.dtpde.Size = new System.Drawing.Size(217, 20);
            this.dtpde.TabIndex = 2;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(286, 22);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(47, 19);
            this.materialLabel16.TabIndex = 1;
            this.materialLabel16.Text = "Hasta:";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(26, 22);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(24, 19);
            this.materialLabel15.TabIndex = 0;
            this.materialLabel15.Text = "De:";
            // 
            // dgvconsultainfor
            // 
            this.dgvconsultainfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvconsultainfor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvconsultainfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultainfor.GridColor = System.Drawing.SystemColors.Control;
            this.dgvconsultainfor.Location = new System.Drawing.Point(19, 92);
            this.dgvconsultainfor.Name = "dgvconsultainfor";
            this.dgvconsultainfor.Size = new System.Drawing.Size(703, 252);
            this.dgvconsultainfor.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnconsultausuario);
            this.tabPage6.Controls.Add(this.btnagregarusuario);
            this.tabPage6.Controls.Add(this.materialCard3);
            this.tabPage6.ImageKey = "ic_ad_usuario.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(741, 359);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Usuarios";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnconsultausuario
            // 
            this.btnconsultausuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnconsultausuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnconsultausuario.Depth = 0;
            this.btnconsultausuario.HighEmphasis = true;
            this.btnconsultausuario.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btnconsultausuario.Location = new System.Drawing.Point(416, 279);
            this.btnconsultausuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnconsultausuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnconsultausuario.Name = "btnconsultausuario";
            this.btnconsultausuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnconsultausuario.Size = new System.Drawing.Size(134, 36);
            this.btnconsultausuario.TabIndex = 4;
            this.btnconsultausuario.Text = "Consultar";
            this.btnconsultausuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnconsultausuario.UseAccentColor = false;
            this.btnconsultausuario.UseVisualStyleBackColor = true;
            this.btnconsultausuario.Click += new System.EventHandler(this.btnconsultausuario_Click);
            // 
            // btnagregarusuario
            // 
            this.btnagregarusuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregarusuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregarusuario.Depth = 0;
            this.btnagregarusuario.HighEmphasis = true;
            this.btnagregarusuario.Icon = global::Recursos_Humanos.Properties.Resources.ic_add;
            this.btnagregarusuario.Location = new System.Drawing.Point(212, 279);
            this.btnagregarusuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregarusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregarusuario.Name = "btnagregarusuario";
            this.btnagregarusuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregarusuario.Size = new System.Drawing.Size(116, 36);
            this.btnagregarusuario.TabIndex = 3;
            this.btnagregarusuario.Text = "Agregar";
            this.btnagregarusuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregarusuario.UseAccentColor = false;
            this.btnagregarusuario.UseVisualStyleBackColor = true;
            this.btnagregarusuario.Click += new System.EventHandler(this.btnagregarusuario_Click);
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
            this.materialCard3.Location = new System.Drawing.Point(105, 25);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(527, 201);
            this.materialCard3.TabIndex = 1;
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
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnconsultainfor);
            this.tabPage2.ImageKey = "ic_empleado.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnconsultainfor
            // 
            this.btnconsultainfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnconsultainfor.Controls.Add(this.txtsalario);
            this.btnconsultainfor.Controls.Add(this.btnregistrarempleado);
            this.btnconsultainfor.Controls.Add(this.txtnombre);
            this.btnconsultainfor.Controls.Add(this.txtcedula);
            this.btnconsultainfor.Controls.Add(this.materialLabel11);
            this.btnconsultainfor.Controls.Add(this.cbotipousuarioid);
            this.btnconsultainfor.Controls.Add(this.materialLabel7);
            this.btnconsultainfor.Controls.Add(this.materialLabel6);
            this.btnconsultainfor.Controls.Add(this.materialLabel5);
            this.btnconsultainfor.Depth = 0;
            this.btnconsultainfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnconsultainfor.Location = new System.Drawing.Point(17, 17);
            this.btnconsultainfor.Margin = new System.Windows.Forms.Padding(14);
            this.btnconsultainfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnconsultainfor.Name = "btnconsultainfor";
            this.btnconsultainfor.Padding = new System.Windows.Forms.Padding(14);
            this.btnconsultainfor.Size = new System.Drawing.Size(707, 295);
            this.btnconsultainfor.TabIndex = 0;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(142, 140);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(133, 20);
            this.txtsalario.TabIndex = 7;
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalario_KeyPress_1);
            // 
            // btnregistrarempleado
            // 
            this.btnregistrarempleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnregistrarempleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnregistrarempleado.Depth = 0;
            this.btnregistrarempleado.HighEmphasis = true;
            this.btnregistrarempleado.Icon = global::Recursos_Humanos.Properties.Resources.ic_ingresar;
            this.btnregistrarempleado.Location = new System.Drawing.Point(240, 218);
            this.btnregistrarempleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnregistrarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnregistrarempleado.Name = "btnregistrarempleado";
            this.btnregistrarempleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnregistrarempleado.Size = new System.Drawing.Size(127, 36);
            this.btnregistrarempleado.TabIndex = 1;
            this.btnregistrarempleado.Text = "Registrar";
            this.btnregistrarempleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnregistrarempleado.UseAccentColor = false;
            this.btnregistrarempleado.UseVisualStyleBackColor = true;
            this.btnregistrarempleado.Click += new System.EventHandler(this.btnregistrarempleado_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(142, 81);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(142, 30);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(133, 20);
            this.txtcedula.TabIndex = 5;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress_1);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(377, 28);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(114, 19);
            this.materialLabel11.TabIndex = 4;
            this.materialLabel11.Text = "Tipo Usuario ID:";
            // 
            // cbotipousuarioid
            // 
            this.cbotipousuarioid.FormattingEnabled = true;
            this.cbotipousuarioid.Location = new System.Drawing.Point(518, 26);
            this.cbotipousuarioid.Name = "cbotipousuarioid";
            this.cbotipousuarioid.Size = new System.Drawing.Size(121, 21);
            this.cbotipousuarioid.TabIndex = 3;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(60, 140);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(59, 19);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Salario: ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(58, 81);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Nombre:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(58, 30);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Cedula:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnversolicitudes);
            this.tabPage3.Controls.Add(this.dgvvacaciones);
            this.tabPage3.ImageKey = "ic_g_vacaciones.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(741, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vacaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnversolicitudes
            // 
            this.btnversolicitudes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnversolicitudes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnversolicitudes.Depth = 0;
            this.btnversolicitudes.HighEmphasis = true;
            this.btnversolicitudes.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btnversolicitudes.Location = new System.Drawing.Point(273, 314);
            this.btnversolicitudes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnversolicitudes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnversolicitudes.Name = "btnversolicitudes";
            this.btnversolicitudes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnversolicitudes.Size = new System.Drawing.Size(171, 36);
            this.btnversolicitudes.TabIndex = 1;
            this.btnversolicitudes.Text = "Ver Solicitudes";
            this.btnversolicitudes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnversolicitudes.UseAccentColor = false;
            this.btnversolicitudes.UseVisualStyleBackColor = true;
            this.btnversolicitudes.Click += new System.EventHandler(this.btnversolicitudes_Click);
            // 
            // dgvvacaciones
            // 
            this.dgvvacaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvvacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvacaciones.Location = new System.Drawing.Point(32, 11);
            this.dgvvacaciones.Name = "dgvvacaciones";
            this.dgvvacaciones.Size = new System.Drawing.Size(676, 294);
            this.dgvvacaciones.TabIndex = 0;
            this.dgvvacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvacaciones_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialCard2);
            this.tabPage4.ImageKey = "ic_evaluacion.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(741, 359);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Desempeño";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnregistrarevaluacion);
            this.materialCard2.Controls.Add(this.btnconsultacedula);
            this.materialCard2.Controls.Add(this.cbocalificacion);
            this.materialCard2.Controls.Add(this.txtcomentario);
            this.materialCard2.Controls.Add(this.txtcedulaempleado);
            this.materialCard2.Controls.Add(this.materialLabel14);
            this.materialCard2.Controls.Add(this.materialLabel13);
            this.materialCard2.Controls.Add(this.materialLabel12);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(38, 24);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(663, 246);
            this.materialCard2.TabIndex = 0;
            // 
            // btnregistrarevaluacion
            // 
            this.btnregistrarevaluacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnregistrarevaluacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnregistrarevaluacion.Depth = 0;
            this.btnregistrarevaluacion.HighEmphasis = true;
            this.btnregistrarevaluacion.Icon = global::Recursos_Humanos.Properties.Resources.ic_enviar;
            this.btnregistrarevaluacion.Location = new System.Drawing.Point(377, 135);
            this.btnregistrarevaluacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnregistrarevaluacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnregistrarevaluacion.Name = "btnregistrarevaluacion";
            this.btnregistrarevaluacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnregistrarevaluacion.Size = new System.Drawing.Size(220, 36);
            this.btnregistrarevaluacion.TabIndex = 1;
            this.btnregistrarevaluacion.Text = "Registrar Evaluacion";
            this.btnregistrarevaluacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnregistrarevaluacion.UseAccentColor = false;
            this.btnregistrarevaluacion.UseVisualStyleBackColor = true;
            this.btnregistrarevaluacion.Click += new System.EventHandler(this.btnregistrarevaluacion_Click);
            // 
            // btnconsultacedula
            // 
            this.btnconsultacedula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnconsultacedula.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnconsultacedula.Depth = 0;
            this.btnconsultacedula.HighEmphasis = true;
            this.btnconsultacedula.Icon = global::Recursos_Humanos.Properties.Resources.ic_consulta;
            this.btnconsultacedula.Location = new System.Drawing.Point(300, 21);
            this.btnconsultacedula.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnconsultacedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnconsultacedula.Name = "btnconsultacedula";
            this.btnconsultacedula.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnconsultacedula.Size = new System.Drawing.Size(105, 36);
            this.btnconsultacedula.TabIndex = 7;
            this.btnconsultacedula.Text = "Buscar";
            this.btnconsultacedula.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnconsultacedula.UseAccentColor = false;
            this.btnconsultacedula.UseVisualStyleBackColor = true;
            this.btnconsultacedula.Click += new System.EventHandler(this.btnconsultacedula_Click);
            // 
            // cbocalificacion
            // 
            this.cbocalificacion.FormattingEnabled = true;
            this.cbocalificacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbocalificacion.Location = new System.Drawing.Point(116, 95);
            this.cbocalificacion.Name = "cbocalificacion";
            this.cbocalificacion.Size = new System.Drawing.Size(121, 21);
            this.cbocalificacion.TabIndex = 6;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(110, 166);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(204, 63);
            this.txtcomentario.TabIndex = 5;
            // 
            // txtcedulaempleado
            // 
            this.txtcedulaempleado.Location = new System.Drawing.Point(110, 30);
            this.txtcedulaempleado.Name = "txtcedulaempleado";
            this.txtcedulaempleado.Size = new System.Drawing.Size(175, 20);
            this.txtcedulaempleado.TabIndex = 3;
            this.txtcedulaempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedulaempleado_KeyPress);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(17, 182);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(91, 19);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "Comentario: ";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(17, 97);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(93, 19);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "Calificacion: ";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(17, 31);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(54, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Cedula:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_pago.png");
            this.imageList1.Images.SetKeyName(1, "ic_evaluacion.png");
            this.imageList1.Images.SetKeyName(2, "ic_panel.png");
            this.imageList1.Images.SetKeyName(3, "ic_g_vacaciones.png");
            this.imageList1.Images.SetKeyName(4, "ic_empleado.png");
            this.imageList1.Images.SetKeyName(5, "ic_ad_usuario.png");
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(36, 127);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 19);
            this.materialLabel3.TabIndex = 2;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(41, 181);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 3;
            // 
            // frmadministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 469);
            this.Controls.Add(this.btninforconsulta);
            this.DrawerTabControl = this.btninforconsulta;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmadministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido Admin";
            this.Load += new System.EventHandler(this.frmadministrador_Load);
            this.btninforconsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultainfor)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.btnconsultainfor.ResumeLayout(false);
            this.btnconsultainfor.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacaciones)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl btninforconsulta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialButton btnconsultausuario;
        private MaterialSkin.Controls.MaterialButton btnagregarusuario;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.ComboBox cbotipousuario;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton btnregistrarempleado;
        private MaterialSkin.Controls.MaterialCard btnconsultainfor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcedula;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox cbotipousuarioid;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgvvacaciones;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton btnregistrarevaluacion;
        private MaterialSkin.Controls.MaterialButton btnconsultacedula;
        private System.Windows.Forms.ComboBox cbocalificacion;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.TextBox txtcedulaempleado;
        private MaterialSkin.Controls.MaterialButton btnversolicitudes;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton btninformacionconsul;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DateTimePicker dtpde;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.DataGridView dgvconsultainfor;
    }
}