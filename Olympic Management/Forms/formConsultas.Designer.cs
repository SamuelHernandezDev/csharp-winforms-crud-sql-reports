namespace Olympic_Management
{
    partial class formConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbSeleccionConsulta = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtUmbralFiltro = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblFiltroDinamico = new ReaLTaiizor.Controls.NightLabel();
            this.lblFiltroUmbral = new ReaLTaiizor.Controls.NightLabel();
            this.lblFechaFinal = new ReaLTaiizor.Controls.NightLabel();
            this.lblReferencia = new ReaLTaiizor.Controls.NightLabel();
            this.cmbFiltroDinamico = new ReaLTaiizor.Controls.DungeonComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportes = new ReaLTaiizor.Controls.NightButton();
            this.btnLimpiar = new ReaLTaiizor.Controls.NightButton();
            this.btnBuscar = new ReaLTaiizor.Controls.NightButton();
            this.dgvResultados = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaFinFiltro = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lblSeleccionConsultas = new ReaLTaiizor.Controls.NightLabel();
            this.lblFechaInicio = new ReaLTaiizor.Controls.NightLabel();
            this.dtpFechaInicioFiltro = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(348, 3);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 69);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Consultas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSeleccionConsulta
            // 
            this.cmbSeleccionConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbSeleccionConsulta.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbSeleccionConsulta.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbSeleccionConsulta.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbSeleccionConsulta.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbSeleccionConsulta.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbSeleccionConsulta.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbSeleccionConsulta.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbSeleccionConsulta.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbSeleccionConsulta.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbSeleccionConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSeleccionConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSeleccionConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeleccionConsulta.DropDownHeight = 100;
            this.cmbSeleccionConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionConsulta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSeleccionConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbSeleccionConsulta.FormattingEnabled = true;
            this.cmbSeleccionConsulta.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbSeleccionConsulta.IntegralHeight = false;
            this.cmbSeleccionConsulta.ItemHeight = 20;
            this.cmbSeleccionConsulta.Location = new System.Drawing.Point(62, 77);
            this.cmbSeleccionConsulta.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbSeleccionConsulta.Name = "cmbSeleccionConsulta";
            this.cmbSeleccionConsulta.Size = new System.Drawing.Size(204, 26);
            this.cmbSeleccionConsulta.StartIndex = 0;
            this.cmbSeleccionConsulta.TabIndex = 7;
            // 
            // txtUmbralFiltro
            // 
            this.txtUmbralFiltro.BackColor = System.Drawing.Color.Transparent;
            this.txtUmbralFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUmbralFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUmbralFiltro.EdgeColor = System.Drawing.Color.White;
            this.txtUmbralFiltro.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUmbralFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.txtUmbralFiltro.Location = new System.Drawing.Point(306, 143);
            this.txtUmbralFiltro.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.txtUmbralFiltro.MaxLength = 32767;
            this.txtUmbralFiltro.Multiline = false;
            this.txtUmbralFiltro.Name = "txtUmbralFiltro";
            this.txtUmbralFiltro.ReadOnly = false;
            this.txtUmbralFiltro.Size = new System.Drawing.Size(183, 28);
            this.txtUmbralFiltro.TabIndex = 9;
            this.txtUmbralFiltro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUmbralFiltro.UseSystemPasswordChar = false;
            // 
            // lblFiltroDinamico
            // 
            this.lblFiltroDinamico.AutoSize = true;
            this.lblFiltroDinamico.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFiltroDinamico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroDinamico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblFiltroDinamico.Location = new System.Drawing.Point(62, 123);
            this.lblFiltroDinamico.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblFiltroDinamico.Name = "lblFiltroDinamico";
            this.lblFiltroDinamico.Size = new System.Drawing.Size(224, 15);
            this.lblFiltroDinamico.TabIndex = 12;
            this.lblFiltroDinamico.Text = "Filtro Dinamico";
            // 
            // lblFiltroUmbral
            // 
            this.lblFiltroUmbral.AutoSize = true;
            this.lblFiltroUmbral.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroUmbral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFiltroUmbral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroUmbral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblFiltroUmbral.Location = new System.Drawing.Point(306, 123);
            this.lblFiltroUmbral.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.lblFiltroUmbral.Name = "lblFiltroUmbral";
            this.lblFiltroUmbral.Size = new System.Drawing.Size(203, 15);
            this.lblFiltroUmbral.TabIndex = 13;
            this.lblFiltroUmbral.Text = "Filtro Umbral";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(529, 123);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(195, 15);
            this.lblFechaFinal.TabIndex = 14;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblReferencia.Location = new System.Drawing.Point(346, 127);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(60, 55, 0, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(163, 1);
            this.lblReferencia.TabIndex = 15;
            // 
            // cmbFiltroDinamico
            // 
            this.cmbFiltroDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbFiltroDinamico.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbFiltroDinamico.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbFiltroDinamico.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbFiltroDinamico.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbFiltroDinamico.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbFiltroDinamico.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbFiltroDinamico.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbFiltroDinamico.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbFiltroDinamico.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbFiltroDinamico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltroDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFiltroDinamico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroDinamico.DropDownHeight = 100;
            this.cmbFiltroDinamico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroDinamico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroDinamico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbFiltroDinamico.FormattingEnabled = true;
            this.cmbFiltroDinamico.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbFiltroDinamico.IntegralHeight = false;
            this.cmbFiltroDinamico.ItemHeight = 20;
            this.cmbFiltroDinamico.Location = new System.Drawing.Point(62, 143);
            this.cmbFiltroDinamico.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.cmbFiltroDinamico.Name = "cmbFiltroDinamico";
            this.cmbFiltroDinamico.Size = new System.Drawing.Size(204, 26);
            this.cmbFiltroDinamico.StartIndex = 0;
            this.cmbFiltroDinamico.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.482996F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.2585F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.2585F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.2585F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.2585F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.482995F));
            this.tableLayoutPanel2.Controls.Add(this.btnReportes, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 565);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 100);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnReportes.HoverBackColor = System.Drawing.Color.ForestGreen;
            this.btnReportes.HoverForeColor = System.Drawing.Color.White;
            this.btnReportes.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnReportes.Location = new System.Drawing.Point(575, 25);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(60, 25, 0, 35);
            this.btnReportes.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.NormalBackColor = System.Drawing.Color.LimeGreen;
            this.btnReportes.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnReportes.PressedBackColor = System.Drawing.Color.ForestGreen;
            this.btnReportes.PressedForeColor = System.Drawing.Color.White;
            this.btnReportes.Radius = 20;
            this.btnReportes.Size = new System.Drawing.Size(155, 47);
            this.btnReportes.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Visualizar Reporte";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnLimpiar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnLimpiar.HoverForeColor = System.Drawing.Color.White;
            this.btnLimpiar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnLimpiar.Location = new System.Drawing.Point(211, 25);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0, 25, 15, 35);
            this.btnLimpiar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnLimpiar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnLimpiar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnLimpiar.PressedForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Radius = 20;
            this.btnLimpiar.Size = new System.Drawing.Size(144, 47);
            this.btnLimpiar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnBuscar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnBuscar.HoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnBuscar.Location = new System.Drawing.Point(59, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0, 25, 15, 35);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnBuscar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnBuscar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnBuscar.PressedForeColor = System.Drawing.Color.White;
            this.btnBuscar.Radius = 20;
            this.btnBuscar.Size = new System.Drawing.Size(144, 47);
            this.btnBuscar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResultados.Location = new System.Drawing.Point(63, 3);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(662, 473);
            this.dgvResultados.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.636566F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.41846F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.944971F));
            this.tableLayoutPanel3.Controls.Add(this.dgvResultados, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 186);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 479);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.896492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.29577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18785F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.18691F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.432977F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSeleccionConsulta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUmbralFiltro, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFiltroDinamico, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFiltroUmbral, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaFinal, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFiltroDinamico, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaFinFiltro, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSeleccionConsultas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaInicio, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblReferencia, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaInicioFiltro, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.65979F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.74227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 186);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // dtpFechaFinFiltro
            // 
            this.dtpFechaFinFiltro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFinFiltro.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Small;
            this.dtpFechaFinFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinFiltro.Location = new System.Drawing.Point(529, 141);
            this.dtpFechaFinFiltro.Margin = new System.Windows.Forms.Padding(20, 3, 100, 3);
            this.dtpFechaFinFiltro.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtpFechaFinFiltro.Name = "dtpFechaFinFiltro";
            this.dtpFechaFinFiltro.Size = new System.Drawing.Size(95, 25);
            this.dtpFechaFinFiltro.TabIndex = 17;
            // 
            // lblSeleccionConsultas
            // 
            this.lblSeleccionConsultas.AutoSize = true;
            this.lblSeleccionConsultas.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionConsultas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeleccionConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblSeleccionConsultas.Location = new System.Drawing.Point(62, 55);
            this.lblSeleccionConsultas.Margin = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.lblSeleccionConsultas.Name = "lblSeleccionConsultas";
            this.lblSeleccionConsultas.Size = new System.Drawing.Size(117, 15);
            this.lblSeleccionConsultas.TabIndex = 18;
            this.lblSeleccionConsultas.Text = "Seleccionar Consulta";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(529, 55);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(20, 55, 0, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(70, 15);
            this.lblFechaInicio.TabIndex = 19;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicioFiltro
            // 
            this.dtpFechaInicioFiltro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaInicioFiltro.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Small;
            this.dtpFechaInicioFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioFiltro.Location = new System.Drawing.Point(529, 75);
            this.dtpFechaInicioFiltro.Margin = new System.Windows.Forms.Padding(20, 3, 100, 3);
            this.dtpFechaInicioFiltro.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtpFechaInicioFiltro.Name = "dtpFechaInicioFiltro";
            this.dtpFechaInicioFiltro.Size = new System.Drawing.Size(95, 25);
            this.dtpFechaInicioFiltro.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 20;
            // 
            // formConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 665);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConsultas";
            this.Text = "formConsultas";
            this.Load += new System.EventHandler(this.formConsultas_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private ReaLTaiizor.Controls.DungeonComboBox cmbSeleccionConsulta;
        private ReaLTaiizor.Controls.DungeonTextBox txtUmbralFiltro;
        private ReaLTaiizor.Controls.NightLabel lblFiltroDinamico;
        private ReaLTaiizor.Controls.NightLabel lblFiltroUmbral;
        private ReaLTaiizor.Controls.NightLabel lblFechaFinal;
        private ReaLTaiizor.Controls.NightLabel lblReferencia;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFiltroDinamico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.NightButton btnReportes;
        private ReaLTaiizor.Controls.NightButton btnBuscar;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvResultados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaFinFiltro;
        private ReaLTaiizor.Controls.NightLabel lblSeleccionConsultas;
        private ReaLTaiizor.Controls.NightButton btnLimpiar;
        private ReaLTaiizor.Controls.NightLabel lblFechaInicio;
        private ReaLTaiizor.Controls.PoisonDateTime dtpFechaInicioFiltro;
    }
}