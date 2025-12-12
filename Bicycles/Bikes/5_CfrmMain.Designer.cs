
namespace Bikes
{
    partial class CfrmMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lstbxTypes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblAccessories = new System.Windows.Forms.Label();
            this.lblHandles = new System.Windows.Forms.Label();
            this.lblSeating = new System.Windows.Forms.Label();
            this.lblGears = new System.Windows.Forms.Label();
            this.lblSuspension = new System.Windows.Forms.Label();
            this.lblWheels = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(439, 302);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstbxTypes
            // 
            this.lstbxTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxTypes.FormattingEnabled = true;
            this.lstbxTypes.ItemHeight = 18;
            this.lstbxTypes.Location = new System.Drawing.Point(0, 18);
            this.lstbxTypes.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxTypes.Name = "lstbxTypes";
            this.lstbxTypes.Size = new System.Drawing.Size(158, 333);
            this.lstbxTypes.TabIndex = 1;
            this.lstbxTypes.SelectedIndexChanged += new System.EventHandler(this.lstbxTypes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstbxTypes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 351);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types of bicycles";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(319, 302);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 32);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wheels && Tyres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suspension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gears";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seating position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Handles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Accessories";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(295, 18);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(0, 18);
            this.lblPurpose.TabIndex = 12;
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.Location = new System.Drawing.Point(295, 198);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(0, 18);
            this.lblAccessories.TabIndex = 18;
            // 
            // lblHandles
            // 
            this.lblHandles.AutoSize = true;
            this.lblHandles.Location = new System.Drawing.Point(295, 168);
            this.lblHandles.Name = "lblHandles";
            this.lblHandles.Size = new System.Drawing.Size(0, 18);
            this.lblHandles.TabIndex = 17;
            // 
            // lblSeating
            // 
            this.lblSeating.AutoSize = true;
            this.lblSeating.Location = new System.Drawing.Point(295, 138);
            this.lblSeating.Name = "lblSeating";
            this.lblSeating.Size = new System.Drawing.Size(0, 18);
            this.lblSeating.TabIndex = 16;
            // 
            // lblGears
            // 
            this.lblGears.AutoSize = true;
            this.lblGears.Location = new System.Drawing.Point(295, 108);
            this.lblGears.Name = "lblGears";
            this.lblGears.Size = new System.Drawing.Size(0, 18);
            this.lblGears.TabIndex = 15;
            // 
            // lblSuspension
            // 
            this.lblSuspension.AutoSize = true;
            this.lblSuspension.Location = new System.Drawing.Point(295, 78);
            this.lblSuspension.Name = "lblSuspension";
            this.lblSuspension.Size = new System.Drawing.Size(0, 18);
            this.lblSuspension.TabIndex = 14;
            // 
            // lblWheels
            // 
            this.lblWheels.AutoSize = true;
            this.lblWheels.Location = new System.Drawing.Point(295, 48);
            this.lblWheels.Name = "lblWheels";
            this.lblWheels.Size = new System.Drawing.Size(0, 18);
            this.lblWheels.TabIndex = 13;
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 351);
            this.Controls.Add(this.lblAccessories);
            this.Controls.Add(this.lblHandles);
            this.Controls.Add(this.lblSeating);
            this.Controls.Add(this.lblGears);
            this.Controls.Add(this.lblSuspension);
            this.Controls.Add(this.lblWheels);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owen\'s Bike Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstbxTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.Label lblHandles;
        private System.Windows.Forms.Label lblSeating;
        private System.Windows.Forms.Label lblGears;
        private System.Windows.Forms.Label lblSuspension;
        private System.Windows.Forms.Label lblWheels;
    }
}

