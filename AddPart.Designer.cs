using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class AddPart
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
            this.addPartTopContainer = new System.Windows.Forms.TableLayoutPanel();
            this.labelPartID = new System.Windows.Forms.Label();
            this.labelPartName = new System.Windows.Forms.Label();
            this.inputPartName = new System.Windows.Forms.TextBox();
            this.inputPartDynamic = new System.Windows.Forms.TextBox();
            this.labelPartInventory = new System.Windows.Forms.Label();
            this.labelPartPrice = new System.Windows.Forms.Label();
            this.labelPartMax = new System.Windows.Forms.Label();
            this.labelPartMin = new System.Windows.Forms.Label();
            this.labelDynamicPart = new System.Windows.Forms.Label();
            this.addPartMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.labelAddPartTitle = new System.Windows.Forms.Label();
            this.inputPartID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.inputPartInv = new System.Windows.Forms.TextBox();
            this.inputPartPrice = new System.Windows.Forms.TextBox();
            this.inputPartMax = new System.Windows.Forms.TextBox();
            this.inputPartMin = new System.Windows.Forms.TextBox();
            this.addPartMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartTopContainer
            // 
            this.addPartTopContainer.AutoSize = true;
            this.addPartTopContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPartTopContainer.ColumnCount = 3;
            this.addPartTopContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25478F));
            this.addPartTopContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.addPartTopContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87114F));
            this.addPartTopContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.addPartTopContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.addPartTopContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.addPartTopContainer.Location = new System.Drawing.Point(0, 0);
            this.addPartTopContainer.Name = "addPartTopContainer";
            this.addPartTopContainer.RowCount = 1;
            this.addPartTopContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addPartTopContainer.Size = new System.Drawing.Size(0, 0);
            this.addPartTopContainer.TabIndex = 6;
            // 
            // labelPartID
            // 
            this.labelPartID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartID.AutoSize = true;
            this.labelPartID.Location = new System.Drawing.Point(82, 26);
            this.labelPartID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartID.Name = "labelPartID";
            this.labelPartID.Size = new System.Drawing.Size(18, 13);
            this.labelPartID.TabIndex = 6;
            this.labelPartID.Text = "ID";
            // 
            // labelPartName
            // 
            this.labelPartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartName.AutoSize = true;
            this.labelPartName.Location = new System.Drawing.Point(65, 51);
            this.labelPartName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartName.Name = "labelPartName";
            this.labelPartName.Size = new System.Drawing.Size(35, 13);
            this.labelPartName.TabIndex = 7;
            this.labelPartName.Text = "Name";
            // 
            // inputPartName
            // 
            this.inputPartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartName.Location = new System.Drawing.Point(106, 51);
            this.inputPartName.Name = "inputPartName";
            this.inputPartName.Size = new System.Drawing.Size(138, 20);
            this.inputPartName.TabIndex = 14;
            this.inputPartName.TextChanged += new System.EventHandler(this.inputPartName_TextChanged);
            this.inputPartName.Leave += new System.EventHandler(this.inputPartName_Leave);
            // 
            // inputPartDynamic
            // 
            this.inputPartDynamic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartDynamic.Location = new System.Drawing.Point(106, 151);
            this.inputPartDynamic.Name = "inputPartDynamic";
            this.inputPartDynamic.Size = new System.Drawing.Size(138, 20);
            this.inputPartDynamic.TabIndex = 17;
            this.inputPartDynamic.TextChanged += new System.EventHandler(this.inputPartDynamic_TextChanged);
            this.inputPartDynamic.Leave += new System.EventHandler(this.inputPartDynamic_Leave);
            // 
            // labelPartInventory
            // 
            this.labelPartInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartInventory.AutoSize = true;
            this.labelPartInventory.Location = new System.Drawing.Point(49, 76);
            this.labelPartInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartInventory.Name = "labelPartInventory";
            this.labelPartInventory.Size = new System.Drawing.Size(51, 13);
            this.labelPartInventory.TabIndex = 20;
            this.labelPartInventory.Text = "Inventory";
            // 
            // labelPartPrice
            // 
            this.labelPartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartPrice.AutoSize = true;
            this.labelPartPrice.Location = new System.Drawing.Point(37, 101);
            this.labelPartPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartPrice.Name = "labelPartPrice";
            this.labelPartPrice.Size = new System.Drawing.Size(63, 13);
            this.labelPartPrice.TabIndex = 21;
            this.labelPartPrice.Text = "Price / Cost";
            // 
            // labelPartMax
            // 
            this.labelPartMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartMax.AutoSize = true;
            this.labelPartMax.Location = new System.Drawing.Point(73, 126);
            this.labelPartMax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartMax.Name = "labelPartMax";
            this.labelPartMax.Size = new System.Drawing.Size(27, 13);
            this.labelPartMax.TabIndex = 22;
            this.labelPartMax.Text = "Max";
            // 
            // labelPartMin
            // 
            this.labelPartMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPartMin.AutoSize = true;
            this.labelPartMin.Location = new System.Drawing.Point(250, 126);
            this.labelPartMin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelPartMin.Name = "labelPartMin";
            this.labelPartMin.Size = new System.Drawing.Size(24, 13);
            this.labelPartMin.TabIndex = 23;
            this.labelPartMin.Text = "Min";
            // 
            // labelDynamicPart
            // 
            this.labelDynamicPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDynamicPart.AutoSize = true;
            this.labelDynamicPart.Location = new System.Drawing.Point(38, 151);
            this.labelDynamicPart.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelDynamicPart.Name = "labelDynamicPart";
            this.labelDynamicPart.Size = new System.Drawing.Size(62, 13);
            this.labelDynamicPart.TabIndex = 24;
            this.labelDynamicPart.Text = "Machine ID";
            // 
            // addPartMainContainer
            // 
            this.addPartMainContainer.AutoSize = true;
            this.addPartMainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPartMainContainer.ColumnCount = 4;
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addPartMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addPartMainContainer.Controls.Add(this.rbInHouse, 1, 0);
            this.addPartMainContainer.Controls.Add(this.labelAddPartTitle, 0, 0);
            this.addPartMainContainer.Controls.Add(this.labelPartID, 0, 1);
            this.addPartMainContainer.Controls.Add(this.labelPartName, 0, 2);
            this.addPartMainContainer.Controls.Add(this.inputPartID, 1, 1);
            this.addPartMainContainer.Controls.Add(this.inputPartName, 1, 2);
            this.addPartMainContainer.Controls.Add(this.inputPartDynamic, 1, 6);
            this.addPartMainContainer.Controls.Add(this.labelPartInventory, 0, 3);
            this.addPartMainContainer.Controls.Add(this.labelPartPrice, 0, 4);
            this.addPartMainContainer.Controls.Add(this.labelPartMax, 0, 5);
            this.addPartMainContainer.Controls.Add(this.labelPartMin, 2, 5);
            this.addPartMainContainer.Controls.Add(this.labelDynamicPart, 0, 6);
            this.addPartMainContainer.Controls.Add(this.btnCancel, 3, 7);
            this.addPartMainContainer.Controls.Add(this.btnSave, 1, 7);
            this.addPartMainContainer.Controls.Add(this.rbOutsourced, 3, 0);
            this.addPartMainContainer.Controls.Add(this.inputPartInv, 1, 3);
            this.addPartMainContainer.Controls.Add(this.inputPartPrice, 1, 4);
            this.addPartMainContainer.Controls.Add(this.inputPartMax, 1, 5);
            this.addPartMainContainer.Controls.Add(this.inputPartMin, 3, 5);
            this.addPartMainContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.addPartMainContainer.Location = new System.Drawing.Point(3, 3);
            this.addPartMainContainer.Name = "addPartMainContainer";
            this.addPartMainContainer.RowCount = 8;
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addPartMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.addPartMainContainer.Size = new System.Drawing.Size(421, 205);
            this.addPartMainContainer.TabIndex = 7;
            // 
            // rbInHouse
            // 
            this.rbInHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Checked = true;
            this.rbInHouse.Location = new System.Drawing.Point(176, 3);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse.TabIndex = 26;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.Click += new System.EventHandler(this.rbInHouse_Click);
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
            // inputPartID
            // 
            this.inputPartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartID.Enabled = false;
            this.inputPartID.Location = new System.Drawing.Point(106, 26);
            this.inputPartID.Name = "inputPartID";
            this.inputPartID.ReadOnly = true;
            this.inputPartID.Size = new System.Drawing.Size(138, 20);
            this.inputPartID.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 176);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 19);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(176, 176);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 19);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Location = new System.Drawing.Point(284, 3);
            this.rbOutsourced.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rbOutsourced.TabIndex = 27;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.Click += new System.EventHandler(this.rbOutsourced_Click);
            // 
            // inputPartInv
            // 
            this.inputPartInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartInv.Location = new System.Drawing.Point(106, 76);
            this.inputPartInv.Name = "inputPartInv";
            this.inputPartInv.Size = new System.Drawing.Size(138, 20);
            this.inputPartInv.TabIndex = 29;
            this.inputPartInv.TextChanged += new System.EventHandler(this.inputPartInv_TextChanged);
            this.inputPartInv.Leave += new System.EventHandler(this.inputPartInv_Leave);
            // 
            // inputPartPrice
            // 
            this.inputPartPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartPrice.Location = new System.Drawing.Point(106, 101);
            this.inputPartPrice.Name = "inputPartPrice";
            this.inputPartPrice.Size = new System.Drawing.Size(138, 20);
            this.inputPartPrice.TabIndex = 30;
            this.inputPartPrice.TextChanged += new System.EventHandler(this.inputPartPrice_TextChanged);
            this.inputPartPrice.Leave += new System.EventHandler(this.inputPartPrice_Leave);
            // 
            // inputPartMax
            // 
            this.inputPartMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartMax.Location = new System.Drawing.Point(106, 126);
            this.inputPartMax.Name = "inputPartMax";
            this.inputPartMax.Size = new System.Drawing.Size(138, 20);
            this.inputPartMax.TabIndex = 31;
            this.inputPartMax.TextChanged += new System.EventHandler(this.inputPartMax_TextChanged);
            this.inputPartMax.Leave += new System.EventHandler(this.inputPartMax_Leave);
            // 
            // inputPartMin
            // 
            this.inputPartMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputPartMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPartMin.Location = new System.Drawing.Point(280, 126);
            this.inputPartMin.Name = "inputPartMin";
            this.inputPartMin.Size = new System.Drawing.Size(138, 20);
            this.inputPartMin.TabIndex = 32;
            this.inputPartMin.TextChanged += new System.EventHandler(this.inputPartMin_TextChanged);
            this.inputPartMin.Leave += new System.EventHandler(this.inputPartMin_Leave);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addPartTopContainer);
            this.Controls.Add(this.addPartMainContainer);
            this.Name = "AddPart";
            this.Size = new System.Drawing.Size(427, 211);
            this.addPartMainContainer.ResumeLayout(false);
            this.addPartMainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel addPartTopContainer;
        private Label labelPartID;
        private Label labelPartName;
        private TextBox inputPartName;
        private TextBox inputPartDynamic;
        private Label labelPartInventory;
        private Label labelPartPrice;
        private Label labelPartMax;
        private Label labelPartMin;
        private Label labelDynamicPart;
        private TableLayoutPanel addPartMainContainer;
        private Button btnCancel;
        private Button btnSave;
        private RadioButton rbInHouse;
        private Label labelAddPartTitle;
        private RadioButton rbOutsourced;
        private TextBox inputPartID;
        private TextBox inputPartInv;
        private TextBox inputPartPrice;
        private TextBox inputPartMax;
        private TextBox inputPartMin;
    }
}
