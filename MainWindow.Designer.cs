using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDisplay1 = new Inventory_Management_System.MainDisplay();
            this.SuspendLayout();
            // 
            // mainDisplay1
            // 
            this.mainDisplay1.AutoSize = true;
            this.mainDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDisplay1.Location = new System.Drawing.Point(4, 4);
            this.mainDisplay1.Name = "mainDisplay1";
            this.mainDisplay1.Size = new System.Drawing.Size(776, 553);
            this.mainDisplay1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainDisplay1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Inventory Management";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainWindow_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MainWindow_ControlRemoved);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDisplay mainDisplay1;
        private AddPart addPartScreen;
    }
}