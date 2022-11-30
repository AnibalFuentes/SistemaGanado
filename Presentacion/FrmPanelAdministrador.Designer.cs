namespace Presentacion
{
    partial class FrmPanelAdministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesoVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMesesRecup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxSexo = new System.Windows.Forms.ComboBox();
            this.boxRaza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrillaGanados = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGanado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesesRecuperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtIdGanado = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Estadisticas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.estad = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaGanados)).BeginInit();
            this.Estadisticas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.estad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPesoVenta);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMesesRecup);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boxSexo);
            this.panel1.Controls.Add(this.boxRaza);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 536);
            this.panel1.TabIndex = 3;
            // 
            // txtPesoVenta
            // 
            this.txtPesoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPesoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoVenta.Enabled = false;
            this.txtPesoVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoVenta.ForeColor = System.Drawing.Color.Black;
            this.txtPesoVenta.Location = new System.Drawing.Point(29, 434);
            this.txtPesoVenta.Name = "txtPesoVenta";
            this.txtPesoVenta.ReadOnly = true;
            this.txtPesoVenta.Size = new System.Drawing.Size(200, 26);
            this.txtPesoVenta.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label9.Location = new System.Drawing.Point(26, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Peso de venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioVenta.Location = new System.Drawing.Point(29, 494);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(200, 26);
            this.txtPrecioVenta.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(26, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valor de venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Enabled = false;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioCompra.Location = new System.Drawing.Point(29, 315);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(200, 26);
            this.txtPrecioCompra.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label7.Location = new System.Drawing.Point(26, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor de compra:";
            // 
            // txtMesesRecup
            // 
            this.txtMesesRecup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesesRecup.Location = new System.Drawing.Point(29, 372);
            this.txtMesesRecup.Name = "txtMesesRecup";
            this.txtMesesRecup.Size = new System.Drawing.Size(200, 26);
            this.txtMesesRecup.TabIndex = 16;
            this.txtMesesRecup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesesRecup_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(26, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Meses de recuperación:";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(29, 254);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(200, 26);
            this.txtPeso.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Peso: (Kg)";
            // 
            // boxSexo
            // 
            this.boxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSexo.FormattingEnabled = true;
            this.boxSexo.Location = new System.Drawing.Point(29, 193);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(200, 26);
            this.boxSexo.TabIndex = 12;
            // 
            // boxRaza
            // 
            this.boxRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRaza.FormattingEnabled = true;
            this.boxRaza.Location = new System.Drawing.Point(29, 133);
            this.boxRaza.Name = "boxRaza";
            this.boxRaza.Size = new System.Drawing.Size(200, 26);
            this.boxRaza.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registrar ganado:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Location = new System.Drawing.Point(29, 76);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(200, 26);
            this.txtReferencia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Referencia:";
            // 
            // GrillaGanados
            // 
            this.GrillaGanados.AllowUserToAddRows = false;
            this.GrillaGanados.AllowUserToDeleteRows = false;
            this.GrillaGanados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaGanados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaGanados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaGanados.BackgroundColor = System.Drawing.Color.Silver;
            this.GrillaGanados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaGanados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaGanados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.IdGanado,
            this.Referencia,
            this.Raza,
            this.Sexo,
            this.Peso,
            this.MesesRecuperacion,
            this.PesoVenta,
            this.PrecioCompra,
            this.PrecioVenta,
            this.FechaRegistro,
            this.Estado,
            this.EstadoValor});
            this.GrillaGanados.Location = new System.Drawing.Point(281, 42);
            this.GrillaGanados.Name = "GrillaGanados";
            this.GrillaGanados.ReadOnly = true;
            this.GrillaGanados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaGanados.RowHeadersWidth = 25;
            this.GrillaGanados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaGanados.Size = new System.Drawing.Size(686, 539);
            this.GrillaGanados.TabIndex = 2;
            this.GrillaGanados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaGanados_CellClick);
            this.GrillaGanados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GrillaGanados_CellPainting);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // IdGanado
            // 
            this.IdGanado.HeaderText = "ID";
            this.IdGanado.Name = "IdGanado";
            this.IdGanado.ReadOnly = true;
            this.IdGanado.Visible = false;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "REFERENCIA";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "RAZA";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "PESO";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // MesesRecuperacion
            // 
            this.MesesRecuperacion.HeaderText = "M. RECUP.";
            this.MesesRecuperacion.Name = "MesesRecuperacion";
            this.MesesRecuperacion.ReadOnly = true;
            // 
            // PesoVenta
            // 
            this.PesoVenta.HeaderText = "P. VENTA";
            this.PesoVenta.Name = "PesoVenta";
            this.PesoVenta.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "$ COMPRA";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "$ VENTA";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FECHA REGISTRO";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EST VALOR";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Presentacion.Properties.Resources.dinero;
            this.button1.Location = new System.Drawing.Point(51, 552);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calcular";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Presentacion.Properties.Resources.recargar;
            this.button2.Location = new System.Drawing.Point(9, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = global::Presentacion.Properties.Resources.agregar;
            this.btnIngresar.Location = new System.Drawing.Point(157, 552);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnIngresar.Size = new System.Drawing.Size(99, 38);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtIdGanado
            // 
            this.txtIdGanado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdGanado.Location = new System.Drawing.Point(939, 576);
            this.txtIdGanado.Name = "txtIdGanado";
            this.txtIdGanado.Size = new System.Drawing.Size(25, 26);
            this.txtIdGanado.TabIndex = 23;
            this.txtIdGanado.Text = "0";
            this.txtIdGanado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdGanado.Visible = false;
            // 
            // txtIndice
            // 
            this.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndice.Location = new System.Drawing.Point(908, 576);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(25, 26);
            this.txtIndice.TabIndex = 25;
            this.txtIndice.Text = "-1";
            this.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndice.Visible = false;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultar.Location = new System.Drawing.Point(767, 10);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(200, 26);
            this.txtConsultar.TabIndex = 23;
            this.txtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label10.Location = new System.Drawing.Point(683, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Consultar:";
            // 
            // Estadisticas
            // 
            this.Estadisticas.Controls.Add(this.tabPage1);
            this.Estadisticas.Controls.Add(this.estad);
            this.Estadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Estadisticas.Location = new System.Drawing.Point(0, 0);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.SelectedIndex = 0;
            this.Estadisticas.Size = new System.Drawing.Size(984, 654);
            this.Estadisticas.TabIndex = 26;
            this.Estadisticas.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtIndice);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.GrillaGanados);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.txtConsultar);
            this.tabPage1.Controls.Add(this.txtIdGanado);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // estad
            // 
            this.estad.Controls.Add(this.lblGanancias);
            this.estad.Controls.Add(this.label11);
            this.estad.Location = new System.Drawing.Point(4, 27);
            this.estad.Name = "estad";
            this.estad.Padding = new System.Windows.Forms.Padding(3);
            this.estad.Size = new System.Drawing.Size(976, 623);
            this.estad.TabIndex = 1;
            this.estad.Text = "Estadisticas";
            this.estad.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 20F);
            this.label11.Location = new System.Drawing.Point(17, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ganancias:";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(20, 49);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(59, 18);
            this.lblGanancias.TabIndex = 1;
            this.lblGanancias.Text = "label12";
            // 
            // FrmPanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 654);
            this.Controls.Add(this.Estadisticas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPanelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPanelAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.FrmPanelAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaGanados)).EndInit();
            this.Estadisticas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.estad.ResumeLayout(false);
            this.estad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GrillaGanados;
        private System.Windows.Forms.TextBox txtMesesRecup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxSexo;
        private System.Windows.Forms.ComboBox boxRaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesoVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdGanado;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGanado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesesRecuperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl Estadisticas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage estad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGanancias;
    }
}