using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class MainDisplay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.inputPartSearch = new System.Windows.Forms.TextBox();
            this.btnPartsSearch = new System.Windows.Forms.Button();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.inputProductSearch = new System.Windows.Forms.TextBox();
            this.productsDataView = new System.Windows.Forms.DataGridView();
            this.partsDataView = new System.Windows.Forms.DataGridView();
            this.mainContentContainer = new System.Windows.Forms.TableLayoutPanel();
            this.clearPartSearch = new System.Windows.Forms.Button();
            this.clearProductSearch = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelMainTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).BeginInit();
            this.mainContentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPartSearch
            // 
            this.inputPartSearch.Location = new System.Drawing.Point(233, 3);
            this.inputPartSearch.Name = "inputPartSearch";
            this.inputPartSearch.Size = new System.Drawing.Size(100, 20);
            this.inputPartSearch.TabIndex = 10;
            // 
            // btnPartsSearch
            // 
            this.btnPartsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartsSearch.Location = new System.Drawing.Point(178, 3);
            this.btnPartsSearch.Name = "btnPartsSearch";
            this.btnPartsSearch.Size = new System.Drawing.Size(49, 22);
            this.btnPartsSearch.TabIndex = 2;
            this.btnPartsSearch.Text = "Search";
            this.btnPartsSearch.UseVisualStyleBackColor = true;
            this.btnPartsSearch.Click += new System.EventHandler(this.btnPartsSearch_Click);
            // 
            // labelParts
            // 
            this.labelParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelParts.Location = new System.Drawing.Point(3, 9);
            this.labelParts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(44, 19);
            this.labelParts.TabIndex = 0;
            this.labelParts.Text = "Parts";
            this.labelParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProducts
            // 
            this.labelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelProducts.Location = new System.Drawing.Point(411, 9);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(70, 19);
            this.labelProducts.TabIndex = 1;
            this.labelProducts.Text = "Products";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductsSearch.Location = new System.Drawing.Point(586, 3);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(49, 22);
            this.btnProductsSearch.TabIndex = 3;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.btnProductsSearch_Click);
            // 
            // inputProductSearch
            // 
            this.inputProductSearch.Location = new System.Drawing.Point(641, 3);
            this.inputProductSearch.Name = "inputProductSearch";
            this.inputProductSearch.Size = new System.Drawing.Size(100, 20);
            this.inputProductSearch.TabIndex = 11;
            // 
            // productsDataView
            // 
            this.productsDataView.AllowUserToAddRows = false;
            this.productsDataView.AllowUserToDeleteRows = false;
            this.productsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainContentContainer.SetColumnSpan(this.productsDataView, 4);
            this.productsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsDataView.Location = new System.Drawing.Point(411, 31);
            this.productsDataView.MultiSelect = false;
            this.productsDataView.Name = "productsDataView";
            this.productsDataView.ReadOnly = true;
            this.productsDataView.RowHeadersVisible = false;
            this.productsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataView.Size = new System.Drawing.Size(386, 478);
            this.productsDataView.TabIndex = 7;
            // 
            // partsDataView
            // 
            this.partsDataView.AllowUserToAddRows = false;
            this.partsDataView.AllowUserToDeleteRows = false;
            this.partsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.partsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainContentContainer.SetColumnSpan(this.partsDataView, 4);
            this.partsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsDataView.Location = new System.Drawing.Point(3, 31);
            this.partsDataView.MultiSelect = false;
            this.partsDataView.Name = "partsDataView";
            this.partsDataView.ReadOnly = true;
            this.partsDataView.RowHeadersVisible = false;
            this.partsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataView.Size = new System.Drawing.Size(385, 478);
            this.partsDataView.TabIndex = 6;
            // 
            // mainContentContainer
            // 
            this.mainContentContainer.AutoSize = true;
            this.mainContentContainer.ColumnCount = 9;
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainContentContainer.Controls.Add(this.clearPartSearch, 3, 0);
            this.mainContentContainer.Controls.Add(this.inputPartSearch, 2, 0);
            this.mainContentContainer.Controls.Add(this.labelParts, 0, 0);
            this.mainContentContainer.Controls.Add(this.labelProducts, 5, 0);
            this.mainContentContainer.Controls.Add(this.btnProductsSearch, 6, 0);
            this.mainContentContainer.Controls.Add(this.inputProductSearch, 7, 0);
            this.mainContentContainer.Controls.Add(this.productsDataView, 5, 1);
            this.mainContentContainer.Controls.Add(this.partsDataView, 0, 1);
            this.mainContentContainer.Controls.Add(this.btnPartsSearch, 1, 0);
            this.mainContentContainer.Controls.Add(this.clearProductSearch, 8, 0);
            this.mainContentContainer.Controls.Add(this.btnAddProduct, 5, 2);
            this.mainContentContainer.Controls.Add(this.btnModifyProduct, 6, 2);
            this.mainContentContainer.Controls.Add(this.btnDeleteProduct, 7, 2);
            this.mainContentContainer.Controls.Add(this.btnAddPart, 0, 2);
            this.mainContentContainer.Controls.Add(this.btnModifyPart, 1, 2);
            this.mainContentContainer.Controls.Add(this.btnDeletePart, 2, 2);
            this.mainContentContainer.Controls.Add(this.btnExit, 7, 3);
            this.mainContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainContentContainer.Location = new System.Drawing.Point(0, 32);
            this.mainContentContainer.Name = "mainContentContainer";
            this.mainContentContainer.RowCount = 4;
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContentContainer.Size = new System.Drawing.Size(800, 568);
            this.mainContentContainer.TabIndex = 6;
            // 
            // clearPartSearch
            // 
            this.clearPartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearPartSearch.Location = new System.Drawing.Point(339, 3);
            this.clearPartSearch.Name = "clearPartSearch";
            this.clearPartSearch.Size = new System.Drawing.Size(49, 22);
            this.clearPartSearch.TabIndex = 12;
            this.clearPartSearch.Text = "Clear";
            this.clearPartSearch.UseVisualStyleBackColor = true;
            this.clearPartSearch.Click += new System.EventHandler(this.clearPartSearch_Click);
            // 
            // clearProductSearch
            // 
            this.clearProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearProductSearch.Location = new System.Drawing.Point(748, 3);
            this.clearProductSearch.Name = "clearProductSearch";
            this.clearProductSearch.Size = new System.Drawing.Size(49, 22);
            this.clearProductSearch.TabIndex = 13;
            this.clearProductSearch.Text = "Clear";
            this.clearProductSearch.UseVisualStyleBackColor = true;
            this.clearProductSearch.Click += new System.EventHandler(this.clearProductSearch_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.Location = new System.Drawing.Point(531, 515);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(49, 22);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifyProduct.Location = new System.Drawing.Point(586, 515);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(49, 22);
            this.btnModifyProduct.TabIndex = 4;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(641, 515);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(49, 22);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPart.Location = new System.Drawing.Point(123, 515);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(49, 22);
            this.btnAddPart.TabIndex = 3;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifyPart.Location = new System.Drawing.Point(178, 515);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(49, 22);
            this.btnModifyPart.TabIndex = 5;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(233, 515);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(49, 22);
            this.btnDeletePart.TabIndex = 9;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(692, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 22);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMainTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelMainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMainTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(348, 32);
            this.labelMainTitle.TabIndex = 4;
            this.labelMainTitle.Text = "Inventory Management System";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContentContainer);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "MainDisplay";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.EnabledChanged += new System.EventHandler(this.MainDisplay_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataView)).EndInit();
            this.mainContentContainer.ResumeLayout(false);
            this.mainContentContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox inputPartSearch;
        private Button btnPartsSearch;
        private Label labelParts;
        private Label labelProducts;
        private Button btnProductsSearch;
        private TextBox inputProductSearch;
        private DataGridView productsDataView;
        private TableLayoutPanel mainContentContainer;
        private DataGridView partsDataView;
        private Label labelMainTitle;
        private Button btnDeleteProduct;
        private Button btnModifyProduct;
        private Button btnAddProduct;
        private Button btnDeletePart;
        private Button btnModifyPart;
        private Button btnAddPart;
        private Button btnExit;
        private Button clearPartSearch;
        private Button clearProductSearch;
    }
}
