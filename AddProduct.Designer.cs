using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class AddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPartMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.labelAddPartTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelAddProductLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddProductTitle = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.inputProductID = new System.Windows.Forms.TextBox();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.labelProductInventory = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductMax = new System.Windows.Forms.Label();
            this.labelProductMin = new System.Windows.Forms.Label();
            this.inputProductInv = new System.Windows.Forms.TextBox();
            this.inputProductPrice = new System.Windows.Forms.TextBox();
            this.inputProductMax = new System.Windows.Forms.TextBox();
            this.inputProductMin = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAddProductRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddCandidateParts = new System.Windows.Forms.Label();
            this.labelAddAssociatedParts = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddAssociatedPart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.inputAllPartSearch = new System.Windows.Forms.TextBox();
            this.allPartsDataView = new System.Windows.Forms.DataGridView();
            this.associatedPartsDataView = new System.Windows.Forms.DataGridView();
            this.clearSearch = new System.Windows.Forms.Button();
            this.addPartMainContainer.SuspendLayout();
            this.tableLayoutPanelAddProductLeft.SuspendLayout();
            this.tableLayoutPanelAddProductRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartMainContainer
            // 
            this.addPartMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPartMainContainer.AutoSize = true;
            this.addPartMainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPartMainContainer.ColumnCount = 4;
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addPartMainContainer.Controls.Add(this.rbInHouse, 1, 0);
            this.addPartMainContainer.Location = new System.Drawing.Point(0, 0);
            this.addPartMainContainer.Name = "addPartMainContainer";
            this.addPartMainContainer.RowCount = 1;
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addPartMainContainer.Size = new System.Drawing.Size(200, 100);
            this.addPartMainContainer.TabIndex = 0;
            // 
            // rbInHouse
            // 
            this.rbInHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Checked = true;
            this.rbInHouse.Location = new System.Drawing.Point(29, 3);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse.TabIndex = 26;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            // 
            // labelAddPartTitle
            // 
            this.labelAddPartTitle.AutoSize = true;
            this.labelAddPartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddPartTitle.Location = new System.Drawing.Point(3, 0);
            this.labelAddPartTitle.Name = "labelAddPartTitle";
            this.labelAddPartTitle.Size = new System.Drawing.Size(76, 21);
            this.labelAddPartTitle.TabIndex = 25;
            this.labelAddPartTitle.Text = "Add Part";
            this.labelAddPartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelAddProductLeft
            // 
            this.tableLayoutPanelAddProductLeft.AutoSize = true;
            this.tableLayoutPanelAddProductLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAddProductLeft.ColumnCount = 4;
            this.tableLayoutPanelAddProductLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddProductLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelAddProductLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddProductLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelAddProductTitle, 0, 0);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductID, 0, 1);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductName, 0, 2);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductID, 1, 1);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductName, 1, 2);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductInventory, 0, 3);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductPrice, 0, 4);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductMax, 0, 5);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.labelProductMin, 2, 5);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductInv, 1, 3);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductPrice, 1, 4);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductMax, 1, 5);
            this.tableLayoutPanelAddProductLeft.Controls.Add(this.inputProductMin, 3, 5);
            this.tableLayoutPanelAddProductLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelAddProductLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelAddProductLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddProductLeft.Name = "tableLayoutPanelAddProductLeft";
            this.tableLayoutPanelAddProductLeft.RowCount = 6;
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductLeft.Size = new System.Drawing.Size(239, 600);
            this.tableLayoutPanelAddProductLeft.TabIndex = 8;
            // 
            // labelAddProductTitle
            // 
            this.labelAddProductTitle.AutoSize = true;
            this.tableLayoutPanelAddProductLeft.SetColumnSpan(this.labelAddProductTitle, 2);
            this.labelAddProductTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddProductTitle.Location = new System.Drawing.Point(3, 0);
            this.labelAddProductTitle.Name = "labelAddProductTitle";
            this.labelAddProductTitle.Size = new System.Drawing.Size(105, 21);
            this.labelAddProductTitle.TabIndex = 25;
            this.labelAddProductTitle.Text = "Add Product";
            this.labelAddProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductID
            // 
            this.labelProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(48, 64);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(18, 13);
            this.labelProductID.TabIndex = 6;
            this.labelProductID.Text = "ID";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(31, 90);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(35, 13);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Name";
            // 
            // inputProductID
            // 
            this.inputProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAddProductLeft.SetColumnSpan(this.inputProductID, 3);
            this.inputProductID.Enabled = false;
            this.inputProductID.Location = new System.Drawing.Point(72, 64);
            this.inputProductID.Name = "inputProductID";
            this.inputProductID.ReadOnly = true;
            this.inputProductID.Size = new System.Drawing.Size(164, 20);
            this.inputProductID.TabIndex = 13;
            // 
            // inputProductName
            // 
            this.inputProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelAddProductLeft.SetColumnSpan(this.inputProductName, 3);
            this.inputProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProductName.Location = new System.Drawing.Point(72, 90);
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(164, 20);
            this.inputProductName.TabIndex = 14;
            this.inputProductName.TextChanged += new System.EventHandler(this.inputProductName_TextChanged);
            this.inputProductName.Leave += new System.EventHandler(this.inputProductName_Leave);
            // 
            // labelProductInventory
            // 
            this.labelProductInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductInventory.AutoSize = true;
            this.labelProductInventory.Location = new System.Drawing.Point(15, 116);
            this.labelProductInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductInventory.Name = "labelProductInventory";
            this.labelProductInventory.Size = new System.Drawing.Size(51, 13);
            this.labelProductInventory.TabIndex = 20;
            this.labelProductInventory.Text = "Inventory";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(3, 142);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(63, 13);
            this.labelProductPrice.TabIndex = 21;
            this.labelProductPrice.Text = "Price / Cost";
            // 
            // labelProductMax
            // 
            this.labelProductMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductMax.AutoSize = true;
            this.labelProductMax.Location = new System.Drawing.Point(39, 168);
            this.labelProductMax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductMax.Name = "labelProductMax";
            this.labelProductMax.Size = new System.Drawing.Size(27, 13);
            this.labelProductMax.TabIndex = 22;
            this.labelProductMax.Text = "Max";
            // 
            // labelProductMin
            // 
            this.labelProductMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductMin.AutoSize = true;
            this.labelProductMin.Location = new System.Drawing.Point(142, 168);
            this.labelProductMin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProductMin.Name = "labelProductMin";
            this.labelProductMin.Size = new System.Drawing.Size(24, 13);
            this.labelProductMin.TabIndex = 23;
            this.labelProductMin.Text = "Min";
            // 
            // inputProductInv
            // 
            this.inputProductInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputProductInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProductInv.Location = new System.Drawing.Point(72, 116);
            this.inputProductInv.Name = "inputProductInv";
            this.inputProductInv.Size = new System.Drawing.Size(64, 20);
            this.inputProductInv.TabIndex = 27;
            this.inputProductInv.TextChanged += new System.EventHandler(this.inputProductInv_TextChanged);
            this.inputProductInv.Leave += new System.EventHandler(this.inputProductInv_Leave);
            // 
            // inputProductPrice
            // 
            this.inputProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProductPrice.Location = new System.Drawing.Point(72, 142);
            this.inputProductPrice.Name = "inputProductPrice";
            this.inputProductPrice.Size = new System.Drawing.Size(64, 20);
            this.inputProductPrice.TabIndex = 28;
            this.inputProductPrice.TextChanged += new System.EventHandler(this.inputProductPrice_TextChanged);
            this.inputProductPrice.Leave += new System.EventHandler(this.inputProductPrice_Leave);
            // 
            // inputProductMax
            // 
            this.inputProductMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputProductMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProductMax.Location = new System.Drawing.Point(72, 168);
            this.inputProductMax.Name = "inputProductMax";
            this.inputProductMax.Size = new System.Drawing.Size(64, 20);
            this.inputProductMax.TabIndex = 29;
            this.inputProductMax.TextChanged += new System.EventHandler(this.inputProductMax_TextChanged);
            this.inputProductMax.Leave += new System.EventHandler(this.inputProductMax_Leave);
            // 
            // inputProductMin
            // 
            this.inputProductMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputProductMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProductMin.Location = new System.Drawing.Point(172, 168);
            this.inputProductMin.Name = "inputProductMin";
            this.inputProductMin.Size = new System.Drawing.Size(64, 20);
            this.inputProductMin.TabIndex = 30;
            this.inputProductMin.TextChanged += new System.EventHandler(this.inputProductMin_TextChanged);
            this.inputProductMin.Leave += new System.EventHandler(this.inputProductMin_Leave);
            // 
            // tableLayoutPanelAddProductRight
            // 
            this.tableLayoutPanelAddProductRight.AutoSize = true;
            this.tableLayoutPanelAddProductRight.ColumnCount = 5;
            this.tableLayoutPanelAddProductRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddProductRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelAddProductRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelAddProductRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelAddProductRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddProductRight.Controls.Add(this.labelAddCandidateParts, 0, 1);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.labelAddAssociatedParts, 0, 4);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.btnAddAssociatedPart, 3, 3);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.btnCancel, 3, 7);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.btnSave, 2, 7);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.btnDeleteAssociatedPart, 3, 6);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.inputAllPartSearch, 2, 0);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.allPartsDataView, 0, 2);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.associatedPartsDataView, 0, 5);
            this.tableLayoutPanelAddProductRight.Controls.Add(this.clearSearch, 4, 0);
            this.tableLayoutPanelAddProductRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelAddProductRight.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelAddProductRight.Location = new System.Drawing.Point(284, 0);
            this.tableLayoutPanelAddProductRight.Name = "tableLayoutPanelAddProductRight";
            this.tableLayoutPanelAddProductRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanelAddProductRight.RowCount = 8;
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAddProductRight.Size = new System.Drawing.Size(516, 600);
            this.tableLayoutPanelAddProductRight.TabIndex = 9;
            // 
            // labelAddCandidateParts
            // 
            this.labelAddCandidateParts.AutoSize = true;
            this.labelAddCandidateParts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAddCandidateParts.Location = new System.Drawing.Point(8, 26);
            this.labelAddCandidateParts.Name = "labelAddCandidateParts";
            this.labelAddCandidateParts.Size = new System.Drawing.Size(110, 15);
            this.labelAddCandidateParts.TabIndex = 0;
            this.labelAddCandidateParts.Text = "All Candidate Parts";
            // 
            // labelAddAssociatedParts
            // 
            this.labelAddAssociatedParts.AutoSize = true;
            this.labelAddAssociatedParts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAddAssociatedParts.Location = new System.Drawing.Point(8, 300);
            this.labelAddAssociatedParts.Name = "labelAddAssociatedParts";
            this.labelAddAssociatedParts.Size = new System.Drawing.Size(199, 15);
            this.labelAddAssociatedParts.TabIndex = 1;
            this.labelAddAssociatedParts.Text = "Parts Associated With This Product";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddAssociatedPart
            // 
            this.btnAddAssociatedPart.Location = new System.Drawing.Point(353, 277);
            this.btnAddAssociatedPart.Name = "btnAddAssociatedPart";
            this.btnAddAssociatedPart.Size = new System.Drawing.Size(64, 20);
            this.btnAddAssociatedPart.TabIndex = 3;
            this.btnAddAssociatedPart.Text = "Add";
            this.btnAddAssociatedPart.UseVisualStyleBackColor = true;
            this.btnAddAssociatedPart.Click += new System.EventHandler(this.btnAddAssociatedPart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 20);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 577);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 20);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAssociatedPart
            // 
            this.btnDeleteAssociatedPart.Location = new System.Drawing.Point(353, 551);
            this.btnDeleteAssociatedPart.Name = "btnDeleteAssociatedPart";
            this.btnDeleteAssociatedPart.Size = new System.Drawing.Size(64, 20);
            this.btnDeleteAssociatedPart.TabIndex = 6;
            this.btnDeleteAssociatedPart.Text = "Delete";
            this.btnDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnDeleteAssociatedPart.Click += new System.EventHandler(this.btnDeleteAssociatedPart_Click);
            // 
            // inputAllPartSearch
            // 
            this.tableLayoutPanelAddProductRight.SetColumnSpan(this.inputAllPartSearch, 2);
            this.inputAllPartSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAllPartSearch.Location = new System.Drawing.Point(283, 3);
            this.inputAllPartSearch.Name = "inputAllPartSearch";
            this.inputAllPartSearch.Size = new System.Drawing.Size(134, 20);
            this.inputAllPartSearch.TabIndex = 7;
            // 
            // allPartsDataView
            // 
            this.allPartsDataView.AllowUserToAddRows = false;
            this.allPartsDataView.AllowUserToDeleteRows = false;
            this.allPartsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allPartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelAddProductRight.SetColumnSpan(this.allPartsDataView, 5);
            this.allPartsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPartsDataView.Location = new System.Drawing.Point(8, 44);
            this.allPartsDataView.MultiSelect = false;
            this.allPartsDataView.Name = "allPartsDataView";
            this.allPartsDataView.ReadOnly = true;
            this.allPartsDataView.RowHeadersVisible = false;
            this.allPartsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsDataView.Size = new System.Drawing.Size(505, 227);
            this.allPartsDataView.TabIndex = 8;
            // 
            // associatedPartsDataView
            // 
            this.associatedPartsDataView.AllowUserToAddRows = false;
            this.associatedPartsDataView.AllowUserToDeleteRows = false;
            this.associatedPartsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.associatedPartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelAddProductRight.SetColumnSpan(this.associatedPartsDataView, 5);
            this.associatedPartsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.associatedPartsDataView.Location = new System.Drawing.Point(8, 318);
            this.associatedPartsDataView.MultiSelect = false;
            this.associatedPartsDataView.Name = "associatedPartsDataView";
            this.associatedPartsDataView.ReadOnly = true;
            this.associatedPartsDataView.RowHeadersVisible = false;
            this.associatedPartsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataView.Size = new System.Drawing.Size(505, 227);
            this.associatedPartsDataView.TabIndex = 9;
            // 
            // clearSearch
            // 
            this.clearSearch.Location = new System.Drawing.Point(423, 3);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(64, 20);
            this.clearSearch.TabIndex = 10;
            this.clearSearch.Text = "Clear";
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanelAddProductRight);
            this.Controls.Add(this.tableLayoutPanelAddProductLeft);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(800, 600);
            this.addPartMainContainer.ResumeLayout(false);
            this.addPartMainContainer.PerformLayout();
            this.tableLayoutPanelAddProductLeft.ResumeLayout(false);
            this.tableLayoutPanelAddProductLeft.PerformLayout();
            this.tableLayoutPanelAddProductRight.ResumeLayout(false);
            this.tableLayoutPanelAddProductRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel addPartMainContainer;
        private RadioButton rbInHouse;
        private Label labelAddPartTitle;
        private TableLayoutPanel tableLayoutPanelAddProductLeft;
        private Label labelAddProductTitle;
        private Label labelProductID;
        private Label labelProductName;
        private TextBox inputProductID;
        private TextBox inputProductName;
        private Label labelProductInventory;
        private Label labelProductPrice;
        private Label labelProductMax;
        private Label labelProductMin;
        private TableLayoutPanel tableLayoutPanelAddProductRight;
        private Label labelAddCandidateParts;
        private Label labelAddAssociatedParts;
        private Button btnSearch;
        private Button btnAddAssociatedPart;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDeleteAssociatedPart;
        private TextBox inputAllPartSearch;
        private DataGridView allPartsDataView;
        private DataGridView associatedPartsDataView;
        private TextBox inputProductInv;
        private TextBox inputProductPrice;
        private TextBox inputProductMax;
        private TextBox inputProductMin;
        private Button clearSearch;
    }
}
