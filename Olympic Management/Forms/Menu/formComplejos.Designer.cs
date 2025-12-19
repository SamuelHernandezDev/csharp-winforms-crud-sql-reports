namespace Olympic_Management
{
    partial class formComplejos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComplejos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnAgregar = new ReaLTaiizor.Controls.NightButton();
            this.btnGuardar = new ReaLTaiizor.Controls.NightButton();
            this.btnEliminar = new ReaLTaiizor.Controls.NightButton();
            this.btnEditar = new ReaLTaiizor.Controls.NightButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoComplejo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtCampo1 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCampo2 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCampo3 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblCampo1 = new ReaLTaiizor.Controls.NightLabel();
            this.lblCampo2 = new ReaLTaiizor.Controls.NightLabel();
            this.lblCampo3 = new ReaLTaiizor.Controls.NightLabel();
            this.lblReferencia = new ReaLTaiizor.Controls.NightLabel();
            this.cmbReferencia = new ReaLTaiizor.Controls.DungeonComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplejos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.636566F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.41846F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.944971F));
            this.tableLayoutPanel3.Controls.Add(this.dgvComplejos, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 389);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // dgvComplejos
            // 
            this.dgvComplejos.AllowUserToResizeRows = false;
            this.dgvComplejos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplejos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplejos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplejos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComplejos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplejos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComplejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplejos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComplejos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplejos.EnableHeadersVisualStyles = false;
            this.dgvComplejos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvComplejos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvComplejos.Location = new System.Drawing.Point(63, 3);
            this.dgvComplejos.Name = "dgvComplejos";
            this.dgvComplejos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplejos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvComplejos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComplejos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplejos.Size = new System.Drawing.Size(662, 383);
            this.dgvComplejos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnAgregar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnAgregar.HoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnAgregar.Location = new System.Drawing.Point(59, 25);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0, 25, 15, 35);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnAgregar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnAgregar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnAgregar.PressedForeColor = System.Drawing.Color.White;
            this.btnAgregar.Radius = 20;
            this.btnAgregar.Size = new System.Drawing.Size(144, 47);
            this.btnAgregar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.HoverBackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.HoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnGuardar.Location = new System.Drawing.Point(575, 25);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(60, 25, 0, 35);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NormalBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnGuardar.PressedBackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.PressedForeColor = System.Drawing.Color.White;
            this.btnGuardar.Radius = 20;
            this.btnGuardar.Size = new System.Drawing.Size(155, 47);
            this.btnGuardar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEliminar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEliminar.HoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnEliminar.Location = new System.Drawing.Point(363, 25);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0, 25, 15, 35);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEliminar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnEliminar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEliminar.PressedForeColor = System.Drawing.Color.White;
            this.btnEliminar.Radius = 20;
            this.btnEliminar.Size = new System.Drawing.Size(144, 47);
            this.btnEliminar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEditar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEditar.HoverForeColor = System.Drawing.Color.White;
            this.btnEditar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnEditar.Location = new System.Drawing.Point(211, 25);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 25, 15, 35);
            this.btnEditar.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEditar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnEditar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnEditar.PressedForeColor = System.Drawing.Color.White;
            this.btnEditar.Radius = 20;
            this.btnEditar.Size = new System.Drawing.Size(144, 47);
            this.btnEditar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 565);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 100);
            this.tableLayoutPanel2.TabIndex = 18;
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
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoComplejo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCampo1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCampo2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCampo3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCampo1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCampo2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCampo3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblReferencia, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbReferencia, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.47727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.77273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 176);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(295, 3);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 73);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gestion de Complejos Deportivos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipoComplejo
            // 
            this.cmbTipoComplejo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbTipoComplejo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbTipoComplejo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbTipoComplejo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbTipoComplejo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTipoComplejo.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbTipoComplejo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbTipoComplejo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbTipoComplejo.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbTipoComplejo.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbTipoComplejo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoComplejo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipoComplejo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoComplejo.DropDownHeight = 100;
            this.cmbTipoComplejo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComplejo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoComplejo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbTipoComplejo.FormattingEnabled = true;
            this.cmbTipoComplejo.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbTipoComplejo.IntegralHeight = false;
            this.cmbTipoComplejo.ItemHeight = 20;
            this.cmbTipoComplejo.Location = new System.Drawing.Point(102, 76);
            this.cmbTipoComplejo.Margin = new System.Windows.Forms.Padding(40, 0, 60, 40);
            this.cmbTipoComplejo.Name = "cmbTipoComplejo";
            this.cmbTipoComplejo.Size = new System.Drawing.Size(124, 26);
            this.cmbTipoComplejo.StartIndex = 0;
            this.cmbTipoComplejo.TabIndex = 7;
            this.cmbTipoComplejo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoComplejo_SelectedIndexChanged);
            // 
            // txtCampo1
            // 
            this.txtCampo1.BackColor = System.Drawing.Color.Transparent;
            this.txtCampo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCampo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCampo1.EdgeColor = System.Drawing.Color.White;
            this.txtCampo1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCampo1.ForeColor = System.Drawing.Color.DimGray;
            this.txtCampo1.Location = new System.Drawing.Point(62, 136);
            this.txtCampo1.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.txtCampo1.MaxLength = 32767;
            this.txtCampo1.Multiline = false;
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.ReadOnly = false;
            this.txtCampo1.Size = new System.Drawing.Size(204, 28);
            this.txtCampo1.TabIndex = 10;
            this.txtCampo1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCampo1.UseSystemPasswordChar = false;
            // 
            // txtCampo2
            // 
            this.txtCampo2.BackColor = System.Drawing.Color.Transparent;
            this.txtCampo2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCampo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCampo2.EdgeColor = System.Drawing.Color.White;
            this.txtCampo2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCampo2.ForeColor = System.Drawing.Color.DimGray;
            this.txtCampo2.Location = new System.Drawing.Point(306, 136);
            this.txtCampo2.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.txtCampo2.MaxLength = 32767;
            this.txtCampo2.Multiline = false;
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.ReadOnly = false;
            this.txtCampo2.Size = new System.Drawing.Size(183, 28);
            this.txtCampo2.TabIndex = 9;
            this.txtCampo2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCampo2.UseSystemPasswordChar = false;
            // 
            // txtCampo3
            // 
            this.txtCampo3.BackColor = System.Drawing.Color.Transparent;
            this.txtCampo3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCampo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCampo3.EdgeColor = System.Drawing.Color.White;
            this.txtCampo3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCampo3.ForeColor = System.Drawing.Color.DimGray;
            this.txtCampo3.Location = new System.Drawing.Point(529, 136);
            this.txtCampo3.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.txtCampo3.MaxLength = 32767;
            this.txtCampo3.Multiline = false;
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.ReadOnly = false;
            this.txtCampo3.Size = new System.Drawing.Size(195, 28);
            this.txtCampo3.TabIndex = 11;
            this.txtCampo3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCampo3.UseSystemPasswordChar = false;
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCampo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCampo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblCampo1.Location = new System.Drawing.Point(62, 110);
            this.lblCampo1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(224, 21);
            this.lblCampo1.TabIndex = 12;
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCampo2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCampo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblCampo2.Location = new System.Drawing.Point(306, 110);
            this.lblCampo2.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(203, 21);
            this.lblCampo2.TabIndex = 13;
            // 
            // lblCampo3
            // 
            this.lblCampo3.AutoSize = true;
            this.lblCampo3.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCampo3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCampo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblCampo3.Location = new System.Drawing.Point(529, 110);
            this.lblCampo3.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.lblCampo3.Name = "lblCampo3";
            this.lblCampo3.Size = new System.Drawing.Size(195, 21);
            this.lblCampo3.TabIndex = 14;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblReferencia.Location = new System.Drawing.Point(569, 55);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(60, 55, 0, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(155, 21);
            this.lblReferencia.TabIndex = 15;
            // 
            // cmbReferencia
            // 
            this.cmbReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbReferencia.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbReferencia.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbReferencia.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbReferencia.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbReferencia.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbReferencia.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbReferencia.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbReferencia.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbReferencia.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbReferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReferencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReferencia.DropDownHeight = 100;
            this.cmbReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbReferencia.FormattingEnabled = true;
            this.cmbReferencia.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbReferencia.IntegralHeight = false;
            this.cmbReferencia.ItemHeight = 20;
            this.cmbReferencia.Location = new System.Drawing.Point(569, 76);
            this.cmbReferencia.Margin = new System.Windows.Forms.Padding(60, 0, 40, 40);
            this.cmbReferencia.Name = "cmbReferencia";
            this.cmbReferencia.Size = new System.Drawing.Size(115, 26);
            this.cmbReferencia.StartIndex = 0;
            this.cmbReferencia.TabIndex = 16;
            // 
            // formComplejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 665);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formComplejos";
            this.Text = "formComplejos";
            this.Load += new System.EventHandler(this.formComplejos_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplejos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.NightButton btnAgregar;
        private ReaLTaiizor.Controls.NightButton btnGuardar;
        private ReaLTaiizor.Controls.NightButton btnEliminar;
        private ReaLTaiizor.Controls.NightButton btnEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbTipoComplejo;
        private ReaLTaiizor.Controls.DungeonTextBox txtCampo2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvComplejos;
        private ReaLTaiizor.Controls.DungeonTextBox txtCampo1;
        private ReaLTaiizor.Controls.DungeonTextBox txtCampo3;
        private System.Windows.Forms.Label lblTitulo;
        private ReaLTaiizor.Controls.NightLabel lblCampo1;
        private ReaLTaiizor.Controls.NightLabel lblCampo2;
        private ReaLTaiizor.Controls.NightLabel lblCampo3;
        private ReaLTaiizor.Controls.NightLabel lblReferencia;
        private ReaLTaiizor.Controls.DungeonComboBox cmbReferencia;
    }
}