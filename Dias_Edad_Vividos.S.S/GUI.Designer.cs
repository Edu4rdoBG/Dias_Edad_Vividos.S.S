namespace Dias_Edad_Vividos.S.S
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dcTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFdNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMercurio = new System.Windows.Forms.Label();
            this.lblVenus = new System.Windows.Forms.Label();
            this.lblTierra = new System.Windows.Forms.Label();
            this.lblMarte = new System.Windows.Forms.Label();
            this.lblJupiter = new System.Windows.Forms.Label();
            this.lblSaturno = new System.Windows.Forms.Label();
            this.lblUrano = new System.Windows.Forms.Label();
            this.lblNeptuno = new System.Windows.Forms.Label();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timeAnimacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(435, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.bunifuImageButton1);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(472, 39);
            this.pnlTitulo.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(43, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Dias y años vividos S.S.";
            // 
            // dcTitulo
            // 
            this.dcTitulo.Fixed = true;
            this.dcTitulo.Horizontal = true;
            this.dcTitulo.TargetControl = this.pnlTitulo;
            this.dcTitulo.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(303, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de dias vividos";
            // 
            // dtpFdNacimiento
            // 
            this.dtpFdNacimiento.BackColor = System.Drawing.Color.White;
            this.dtpFdNacimiento.BorderRadius = 0;
            this.dtpFdNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.dtpFdNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFdNacimiento.FormatCustom = null;
            this.dtpFdNacimiento.Location = new System.Drawing.Point(9, 84);
            this.dtpFdNacimiento.Name = "dtpFdNacimiento";
            this.dtpFdNacimiento.Size = new System.Drawing.Size(285, 36);
            this.dtpFdNacimiento.TabIndex = 3;
            this.dtpFdNacimiento.Value = new System.DateTime(2019, 2, 11, 14, 33, 49, 623);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblDias.Location = new System.Drawing.Point(303, 93);
            this.lblDias.MaximumSize = new System.Drawing.Size(157, 19);
            this.lblDias.MinimumSize = new System.Drawing.Size(157, 19);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(157, 19);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "0";
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNeptuno);
            this.groupBox1.Controls.Add(this.lblMarte);
            this.groupBox1.Controls.Add(this.lblUrano);
            this.groupBox1.Controls.Add(this.lblTierra);
            this.groupBox1.Controls.Add(this.lblSaturno);
            this.groupBox1.Controls.Add(this.lblVenus);
            this.groupBox1.Controls.Add(this.lblJupiter);
            this.groupBox1.Controls.Add(this.lblMercurio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tu edad en el sistema solar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mercurio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tierra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Marte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(221, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Jupiter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(221, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Saturno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(221, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Urano:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(221, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Neptuno:";
            // 
            // lblMercurio
            // 
            this.lblMercurio.AutoSize = true;
            this.lblMercurio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercurio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblMercurio.Location = new System.Drawing.Point(80, 37);
            this.lblMercurio.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblMercurio.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblMercurio.Name = "lblMercurio";
            this.lblMercurio.Size = new System.Drawing.Size(120, 19);
            this.lblMercurio.TabIndex = 3;
            this.lblMercurio.Text = "0";
            this.lblMercurio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVenus
            // 
            this.lblVenus.AutoSize = true;
            this.lblVenus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblVenus.Location = new System.Drawing.Point(80, 67);
            this.lblVenus.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblVenus.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblVenus.Name = "lblVenus";
            this.lblVenus.Size = new System.Drawing.Size(120, 19);
            this.lblVenus.TabIndex = 3;
            this.lblVenus.Text = "0";
            this.lblVenus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTierra
            // 
            this.lblTierra.AutoSize = true;
            this.lblTierra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTierra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblTierra.Location = new System.Drawing.Point(80, 97);
            this.lblTierra.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblTierra.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblTierra.Name = "lblTierra";
            this.lblTierra.Size = new System.Drawing.Size(120, 19);
            this.lblTierra.TabIndex = 3;
            this.lblTierra.Text = "0";
            this.lblTierra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarte
            // 
            this.lblMarte.AutoSize = true;
            this.lblMarte.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblMarte.Location = new System.Drawing.Point(80, 127);
            this.lblMarte.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblMarte.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblMarte.Name = "lblMarte";
            this.lblMarte.Size = new System.Drawing.Size(120, 19);
            this.lblMarte.TabIndex = 3;
            this.lblMarte.Text = "0";
            this.lblMarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJupiter
            // 
            this.lblJupiter.AutoSize = true;
            this.lblJupiter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJupiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblJupiter.Location = new System.Drawing.Point(300, 37);
            this.lblJupiter.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblJupiter.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblJupiter.Name = "lblJupiter";
            this.lblJupiter.Size = new System.Drawing.Size(120, 19);
            this.lblJupiter.TabIndex = 3;
            this.lblJupiter.Text = "0";
            this.lblJupiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaturno
            // 
            this.lblSaturno.AutoSize = true;
            this.lblSaturno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblSaturno.Location = new System.Drawing.Point(300, 67);
            this.lblSaturno.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblSaturno.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblSaturno.Name = "lblSaturno";
            this.lblSaturno.Size = new System.Drawing.Size(120, 19);
            this.lblSaturno.TabIndex = 3;
            this.lblSaturno.Text = "0";
            this.lblSaturno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUrano
            // 
            this.lblUrano.AutoSize = true;
            this.lblUrano.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblUrano.Location = new System.Drawing.Point(300, 97);
            this.lblUrano.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblUrano.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblUrano.Name = "lblUrano";
            this.lblUrano.Size = new System.Drawing.Size(120, 19);
            this.lblUrano.TabIndex = 3;
            this.lblUrano.Text = "0";
            this.lblUrano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeptuno
            // 
            this.lblNeptuno.AutoSize = true;
            this.lblNeptuno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeptuno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.lblNeptuno.Location = new System.Drawing.Point(300, 127);
            this.lblNeptuno.MaximumSize = new System.Drawing.Size(120, 19);
            this.lblNeptuno.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblNeptuno.Name = "lblNeptuno";
            this.lblNeptuno.Size = new System.Drawing.Size(120, 19);
            this.lblNeptuno.TabIndex = 3;
            this.lblNeptuno.Text = "0";
            this.lblNeptuno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.BorderRadius = 5;
            this.btnCalcular.ButtonText = "Calcular";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcular.Iconimage = null;
            this.btnCalcular.Iconimage_right = null;
            this.btnCalcular.Iconimage_right_Selected = null;
            this.btnCalcular.Iconimage_Selected = null;
            this.btnCalcular.IconMarginLeft = 25;
            this.btnCalcular.IconMarginRight = 0;
            this.btnCalcular.IconRightVisible = true;
            this.btnCalcular.IconRightZoom = 0D;
            this.btnCalcular.IconVisible = true;
            this.btnCalcular.IconZoom = 90D;
            this.btnCalcular.IsTab = false;
            this.btnCalcular.Location = new System.Drawing.Point(355, 147);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.btnCalcular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(105, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // timeAnimacion
            // 
            this.timeAnimacion.Interval = 10;
            this.timeAnimacion.Tick += new System.EventHandler(this.timeAnimacion_Tick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 372);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFdNacimiento);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl dcTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMercurio;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFdNacimiento;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private System.Windows.Forms.Label lblNeptuno;
        private System.Windows.Forms.Label lblMarte;
        private System.Windows.Forms.Label lblUrano;
        private System.Windows.Forms.Label lblTierra;
        private System.Windows.Forms.Label lblSaturno;
        private System.Windows.Forms.Label lblVenus;
        private System.Windows.Forms.Label lblJupiter;
        private System.Windows.Forms.Timer timeAnimacion;
    }
}