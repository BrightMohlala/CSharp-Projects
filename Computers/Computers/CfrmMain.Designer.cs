
namespace Computers
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
            this.lstbxComputers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbxComputers
            // 
            this.lstbxComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxComputers.FormattingEnabled = true;
            this.lstbxComputers.ItemHeight = 18;
            this.lstbxComputers.Location = new System.Drawing.Point(0, 0);
            this.lstbxComputers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbxComputers.Name = "lstbxComputers";
            this.lstbxComputers.Size = new System.Drawing.Size(297, 356);
            this.lstbxComputers.TabIndex = 0;
            this.lstbxComputers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbxComputers_MouseDoubleClick);
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 356);
            this.Controls.Add(this.lstbxComputers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Computers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxComputers;
    }
}

