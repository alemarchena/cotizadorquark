namespace Cotizador
{
    partial class Form1
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
            this.panelVendedor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnNuevoVendedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTienda = new System.Windows.Forms.Panel();
            this.btnCrearTienda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionTienda = new System.Windows.Forms.TextBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.panelDatosTienda = new System.Windows.Forms.Panel();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.listaStock = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerStock = new System.Windows.Forms.Button();
            this.panelCotizador = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCalidad = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.panelPrenda = new System.Windows.Forms.Panel();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.lblTotalCotizado = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioMangaCorta = new System.Windows.Forms.RadioButton();
            this.radioMangaLarga = new System.Windows.Forms.RadioButton();
            this.panelVendedor.SuspendLayout();
            this.panelTienda.SuspendLayout();
            this.panelDatosTienda.SuspendLayout();
            this.panelCotizador.SuspendLayout();
            this.panelCalidad.SuspendLayout();
            this.panelPrenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVendedor
            // 
            this.panelVendedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelVendedor.Controls.Add(this.label4);
            this.panelVendedor.Controls.Add(this.label3);
            this.panelVendedor.Controls.Add(this.txtApellido);
            this.panelVendedor.Controls.Add(this.txtNombre);
            this.panelVendedor.Controls.Add(this.label2);
            this.panelVendedor.Controls.Add(this.lblHistorial);
            this.panelVendedor.Controls.Add(this.label1);
            this.panelVendedor.Controls.Add(this.lblId);
            this.panelVendedor.Controls.Add(this.btnNuevoVendedor);
            this.panelVendedor.Location = new System.Drawing.Point(425, 12);
            this.panelVendedor.Name = "panelVendedor";
            this.panelVendedor.Size = new System.Drawing.Size(366, 105);
            this.panelVendedor.TabIndex = 9;
            this.panelVendedor.Tag = "Panel Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(71, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id Historial";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHistorial.Enabled = false;
            this.lblHistorial.Location = new System.Drawing.Point(198, 17);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(40, 13);
            this.lblHistorial.TabIndex = 12;
            this.lblHistorial.Text = "           ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id Vendedor";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblId.Enabled = false;
            this.lblId.Location = new System.Drawing.Point(79, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "           ";
            // 
            // btnNuevoVendedor
            // 
            this.btnNuevoVendedor.Location = new System.Drawing.Point(255, 43);
            this.btnNuevoVendedor.Name = "btnNuevoVendedor";
            this.btnNuevoVendedor.Size = new System.Drawing.Size(82, 39);
            this.btnNuevoVendedor.TabIndex = 9;
            this.btnNuevoVendedor.Text = "Crear Vendedor";
            this.btnNuevoVendedor.UseVisualStyleBackColor = true;
            this.btnNuevoVendedor.Click += new System.EventHandler(this.btnNuevoVendedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "COTIZADOR";
            // 
            // panelTienda
            // 
            this.panelTienda.Controls.Add(this.btnCrearTienda);
            this.panelTienda.Controls.Add(this.label6);
            this.panelTienda.Controls.Add(this.label7);
            this.panelTienda.Controls.Add(this.txtDireccionTienda);
            this.panelTienda.Controls.Add(this.txtNombreTienda);
            this.panelTienda.Location = new System.Drawing.Point(24, 57);
            this.panelTienda.Name = "panelTienda";
            this.panelTienda.Size = new System.Drawing.Size(395, 60);
            this.panelTienda.TabIndex = 11;
            // 
            // btnCrearTienda
            // 
            this.btnCrearTienda.Location = new System.Drawing.Point(284, 6);
            this.btnCrearTienda.Name = "btnCrearTienda";
            this.btnCrearTienda.Size = new System.Drawing.Size(82, 23);
            this.btnCrearTienda.TabIndex = 22;
            this.btnCrearTienda.Text = "Crear Tienda";
            this.btnCrearTienda.UseVisualStyleBackColor = true;
            this.btnCrearTienda.Click += new System.EventHandler(this.btnCrearTienda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombre de la Tienda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dirección de la tienda";
            // 
            // txtDireccionTienda
            // 
            this.txtDireccionTienda.Location = new System.Drawing.Point(129, 34);
            this.txtDireccionTienda.Name = "txtDireccionTienda";
            this.txtDireccionTienda.Size = new System.Drawing.Size(237, 20);
            this.txtDireccionTienda.TabIndex = 19;
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(125, 7);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(153, 20);
            this.txtNombreTienda.TabIndex = 18;
            // 
            // panelDatosTienda
            // 
            this.panelDatosTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDatosTienda.Controls.Add(this.lblDireccionTienda);
            this.panelDatosTienda.Controls.Add(this.lblNombreTienda);
            this.panelDatosTienda.Location = new System.Drawing.Point(24, 56);
            this.panelDatosTienda.Name = "panelDatosTienda";
            this.panelDatosTienda.Size = new System.Drawing.Size(395, 61);
            this.panelDatosTienda.TabIndex = 12;
            this.panelDatosTienda.Visible = false;
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Location = new System.Drawing.Point(13, 38);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(0, 13);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 0);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(0, 20);
            this.lblNombreTienda.TabIndex = 0;
            // 
            // listaStock
            // 
            this.listaStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listaStock.FullRowSelect = true;
            this.listaStock.HideSelection = false;
            this.listaStock.Location = new System.Drawing.Point(24, 161);
            this.listaStock.MultiSelect = false;
            this.listaStock.Name = "listaStock";
            this.listaStock.Size = new System.Drawing.Size(395, 367);
            this.listaStock.TabIndex = 13;
            this.listaStock.UseCompatibleStateImageBehavior = false;
            this.listaStock.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 500;
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(24, 132);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(75, 23);
            this.btnVerStock.TabIndex = 15;
            this.btnVerStock.Text = "Ver Stock";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // panelCotizador
            // 
            this.panelCotizador.Controls.Add(this.label16);
            this.panelCotizador.Controls.Add(this.btnCotizar);
            this.panelCotizador.Controls.Add(this.lblTotalCotizado);
            this.panelCotizador.Controls.Add(this.lblStockDisponible);
            this.panelCotizador.Controls.Add(this.label15);
            this.panelCotizador.Controls.Add(this.panel1);
            this.panelCotizador.Controls.Add(this.label9);
            this.panelCotizador.Controls.Add(this.panelCalidad);
            this.panelCotizador.Controls.Add(this.panelPrenda);
            this.panelCotizador.Location = new System.Drawing.Point(437, 132);
            this.panelCotizador.Name = "panelCotizador";
            this.panelCotizador.Size = new System.Drawing.Size(351, 396);
            this.panelCotizador.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "PRENDA";
            // 
            // panelCalidad
            // 
            this.panelCalidad.AccessibleName = "";
            this.panelCalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalidad.Controls.Add(this.label10);
            this.panelCalidad.Controls.Add(this.label8);
            this.panelCalidad.Controls.Add(this.radioPremium);
            this.panelCalidad.Controls.Add(this.radioStandard);
            this.panelCalidad.Location = new System.Drawing.Point(13, 134);
            this.panelCalidad.Name = "panelCalidad";
            this.panelCalidad.Size = new System.Drawing.Size(322, 52);
            this.panelCalidad.TabIndex = 5;
            this.panelCalidad.Tag = "Calidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(159, 19);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 1;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(85, 19);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // panelPrenda
            // 
            this.panelPrenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrenda.Controls.Add(this.panel2);
            this.panelPrenda.Controls.Add(this.chkChupin);
            this.panelPrenda.Controls.Add(this.radioPantalon);
            this.panelPrenda.Controls.Add(this.radioCamisa);
            this.panelPrenda.Location = new System.Drawing.Point(13, 15);
            this.panelPrenda.Name = "panelPrenda";
            this.panelPrenda.Size = new System.Drawing.Size(322, 100);
            this.panelPrenda.TabIndex = 0;
            this.panelPrenda.Tag = "Tipo de Prenda";
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(114, 60);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(59, 17);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "Chupin";
            this.chkChupin.UseVisualStyleBackColor = true;
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(22, 60);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 1;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Checked = true;
            this.radioCamisa.Location = new System.Drawing.Point(22, 20);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 0;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "CALIDAD";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(13, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 84);
            this.panel1.TabIndex = 19;
            this.panel1.Tag = "Calidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "PRECIO UNITARIO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Unidades de stock disponibles";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Location = new System.Drawing.Point(174, 201);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(13, 13);
            this.lblStockDisponible.TabIndex = 21;
            this.lblStockDisponible.Text = "0";
            // 
            // lblTotalCotizado
            // 
            this.lblTotalCotizado.AutoSize = true;
            this.lblTotalCotizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCotizado.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalCotizado.Location = new System.Drawing.Point(209, 343);
            this.lblTotalCotizado.Name = "lblTotalCotizado";
            this.lblTotalCotizado.Size = new System.Drawing.Size(29, 31);
            this.lblTotalCotizado.TabIndex = 22;
            this.lblTotalCotizado.Text = "0";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Teal;
            this.btnCotizar.FlatAppearance.BorderSize = 2;
            this.btnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCotizar.Location = new System.Drawing.Point(13, 331);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(154, 55);
            this.btnCotizar.TabIndex = 23;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(183, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 31);
            this.label16.TabIndex = 24;
            this.label16.Text = "$";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioMangaLarga);
            this.panel2.Controls.Add(this.radioMangaCorta);
            this.panel2.Location = new System.Drawing.Point(111, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 5;
            // 
            // radioMangaCorta
            // 
            this.radioMangaCorta.AutoSize = true;
            this.radioMangaCorta.Checked = true;
            this.radioMangaCorta.Location = new System.Drawing.Point(14, 13);
            this.radioMangaCorta.Name = "radioMangaCorta";
            this.radioMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.radioMangaCorta.TabIndex = 1;
            this.radioMangaCorta.Text = "Manga Corta";
            this.radioMangaCorta.UseVisualStyleBackColor = true;
            // 
            // radioMangaLarga
            // 
            this.radioMangaLarga.AutoSize = true;
            this.radioMangaLarga.Location = new System.Drawing.Point(106, 13);
            this.radioMangaLarga.Name = "radioMangaLarga";
            this.radioMangaLarga.Size = new System.Drawing.Size(88, 17);
            this.radioMangaLarga.TabIndex = 2;
            this.radioMangaLarga.Text = "Manga Larga";
            this.radioMangaLarga.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.panelCotizador);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.listaStock);
            this.Controls.Add(this.panelTienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelVendedor);
            this.Controls.Add(this.panelDatosTienda);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizador";
            this.panelVendedor.ResumeLayout(false);
            this.panelVendedor.PerformLayout();
            this.panelTienda.ResumeLayout(false);
            this.panelTienda.PerformLayout();
            this.panelDatosTienda.ResumeLayout(false);
            this.panelDatosTienda.PerformLayout();
            this.panelCotizador.ResumeLayout(false);
            this.panelCotizador.PerformLayout();
            this.panelCalidad.ResumeLayout(false);
            this.panelCalidad.PerformLayout();
            this.panelPrenda.ResumeLayout(false);
            this.panelPrenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnNuevoVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTienda;
        private System.Windows.Forms.Button btnCrearTienda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionTienda;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Panel panelDatosTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.ListView listaStock;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panelCotizador;
        private System.Windows.Forms.Panel panelPrenda;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.Panel panelCalidad;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalCotizado;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioMangaLarga;
        private System.Windows.Forms.RadioButton radioMangaCorta;
    }
}

