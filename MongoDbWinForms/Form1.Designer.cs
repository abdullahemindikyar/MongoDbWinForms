namespace MongoDbWinForms
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblPurchaseAmount;
        private System.Windows.Forms.TextBox txtPurchaseAmount;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCustomers;

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
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblPurchaseAmount = new System.Windows.Forms.Label();
            this.txtPurchaseAmount = new System.Windows.Forms.TextBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lblListCount = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnGetById = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlFormCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(24, 73);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(61, 15);
            this.lblCustomerId.TabIndex = 11;
            this.lblCustomerId.Text = "Müşteri ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerId.Location = new System.Drawing.Point(24, 94);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(295, 25);
            this.txtCustomerId.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(24, 139);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(22, 15);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Text = "Ad";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(24, 160);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 25);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Location = new System.Drawing.Point(180, 139);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(39, 15);
            this.lblCustomerSurname.TabIndex = 9;
            this.lblCustomerSurname.Text = "Soyad";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtCustomerSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerSurname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerSurname.Location = new System.Drawing.Point(180, 160);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(139, 25);
            this.txtCustomerSurname.TabIndex = 2;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Location = new System.Drawing.Point(24, 205);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(33, 15);
            this.lblCustomerCity.TabIndex = 8;
            this.lblCustomerCity.Text = "Şehir";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtCustomerCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerCity.Location = new System.Drawing.Point(24, 226);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(140, 25);
            this.txtCustomerCity.TabIndex = 3;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(180, 205);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(41, 15);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Bakiye";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBalance.Location = new System.Drawing.Point(180, 226);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(139, 25);
            this.txtBalance.TabIndex = 4;
            // 
            // lblPurchaseAmount
            // 
            this.lblPurchaseAmount.AutoSize = true;
            this.lblPurchaseAmount.Location = new System.Drawing.Point(24, 271);
            this.lblPurchaseAmount.Name = "lblPurchaseAmount";
            this.lblPurchaseAmount.Size = new System.Drawing.Size(81, 15);
            this.lblPurchaseAmount.TabIndex = 6;
            this.lblPurchaseAmount.Text = "Alışveriş tutarı";
            // 
            // txtPurchaseAmount
            // 
            this.txtPurchaseAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.txtPurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchaseAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPurchaseAmount.Location = new System.Drawing.Point(24, 292);
            this.txtPurchaseAmount.Name = "txtPurchaseAmount";
            this.txtPurchaseAmount.Size = new System.Drawing.Size(295, 25);
            this.txtPurchaseAmount.TabIndex = 5;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblBrandSubtitle);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(218, 720);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(230)))));
            this.btnSettings.Location = new System.Drawing.Point(18, 249);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(182, 44);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "  Ayarlar";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(230)))));
            this.btnCustomers.Location = new System.Drawing.Point(18, 197);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(182, 44);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "  Müşteriler";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(18, 145);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(182, 44);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "  Genel Bakış";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(165)))), ((int)(((byte)(188)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(30, 75);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(160, 20);
            this.lblBrandSubtitle.TabIndex = 3;
            this.lblBrandSubtitle.Text = "Müşteri yönetim sistemi";
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(28, 35);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(165, 37);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "MüşteriPanel";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(218, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 110);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(132)))), ((int)(((byte)(151)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(39, 68);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(500, 22);
            this.lblPageSubtitle.TabIndex = 0;
            this.lblPageSubtitle.Text = "Müşteri kayıtlarını görüntüleyin ve yönetin";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.lblPageTitle.Location = new System.Drawing.Point(36, 24);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(400, 40);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Müşteri yönetimi";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlContent.Controls.Add(this.pnlListCard);
            this.pnlContent.Controls.Add(this.pnlFormCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(218, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(36, 28, 36, 30);
            this.pnlContent.Size = new System.Drawing.Size(982, 610);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlListCard
            // 
            this.pnlListCard.BackColor = System.Drawing.Color.White;
            this.pnlListCard.Controls.Add(this.btnGetById);
            this.pnlListCard.Controls.Add(this.dgvCustomers);
            this.pnlListCard.Controls.Add(this.btnUpdate);
            this.pnlListCard.Controls.Add(this.btnDelete);
            this.pnlListCard.Controls.Add(this.btnList);
            this.pnlListCard.Controls.Add(this.lblListCount);
            this.pnlListCard.Controls.Add(this.lblListTitle);
            this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListCard.Location = new System.Drawing.Point(391, 28);
            this.pnlListCard.Name = "pnlListCard";
            this.pnlListCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlListCard.Size = new System.Drawing.Size(555, 552);
            this.pnlListCard.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeight = 38;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.dgvCustomers.Location = new System.Drawing.Point(24, 82);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 36;
            this.dgvCustomers.Size = new System.Drawing.Size(520, 450);
            this.dgvCustomers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad Soyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Şehir";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Bakiye";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnUpdate.Location = new System.Drawing.Point(371, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnDelete.Location = new System.Drawing.Point(311, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnList.Location = new System.Drawing.Point(231, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(70, 32);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblListCount
            // 
            this.lblListCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(132)))), ((int)(((byte)(151)))));
            this.lblListCount.Location = new System.Drawing.Point(25, 51);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(200, 20);
            this.lblListCount.TabIndex = 4;
            this.lblListCount.Text = "Kayıtlar burada listelenecek";
            // 
            // lblListTitle
            // 
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.lblListTitle.Location = new System.Drawing.Point(24, 22);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(220, 28);
            this.lblListTitle.TabIndex = 5;
            this.lblListTitle.Text = "Müşteri listesi";
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnClear);
            this.pnlFormCard.Controls.Add(this.btnAdd);
            this.pnlFormCard.Controls.Add(this.lblFormTitle);
            this.pnlFormCard.Controls.Add(this.txtPurchaseAmount);
            this.pnlFormCard.Controls.Add(this.lblPurchaseAmount);
            this.pnlFormCard.Controls.Add(this.txtBalance);
            this.pnlFormCard.Controls.Add(this.lblBalance);
            this.pnlFormCard.Controls.Add(this.txtCustomerCity);
            this.pnlFormCard.Controls.Add(this.lblCustomerCity);
            this.pnlFormCard.Controls.Add(this.txtCustomerSurname);
            this.pnlFormCard.Controls.Add(this.lblCustomerSurname);
            this.pnlFormCard.Controls.Add(this.txtCustomerName);
            this.pnlFormCard.Controls.Add(this.lblCustomerName);
            this.pnlFormCard.Controls.Add(this.txtCustomerId);
            this.pnlFormCard.Controls.Add(this.lblCustomerId);
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFormCard.Location = new System.Drawing.Point(36, 28);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlFormCard.Size = new System.Drawing.Size(355, 552);
            this.pnlFormCard.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.btnClear.Location = new System.Drawing.Point(180, 487);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 38);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Müşteri ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.lblFormTitle.Location = new System.Drawing.Point(24, 22);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(280, 28);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Yeni müşteri kaydı";
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnGetById.FlatAppearance.BorderSize = 0;
            this.btnGetById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetById.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnGetById.Location = new System.Drawing.Point(459, 19);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(82, 32);
            this.btnGetById.TabIndex = 6;
            this.btnGetById.Text = "Bul";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriPanel | Müşteri Yönetimi";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnGetById;
    }
}

