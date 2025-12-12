namespace CT7Q1_Observer
{
    partial class CfrmController
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
            btnClose = new System.Windows.Forms.Button();
            chStation1 = new System.Windows.Forms.CheckBox();
            chStation2 = new System.Windows.Forms.CheckBox();
            chStation3 = new System.Windows.Forms.CheckBox();
            chStation4 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(12, 139);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(85, 42);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // chStation1
            // 
            chStation1.AutoSize = true;
            chStation1.Location = new System.Drawing.Point(12, 13);
            chStation1.Name = "chStation1";
            chStation1.Size = new System.Drawing.Size(87, 24);
            chStation1.TabIndex = 1;
            chStation1.Text = "Station 1";
            chStation1.UseVisualStyleBackColor = true;
            chStation1.CheckedChanged += chStation_CheckedChanged;
            // 
            // chStation2
            // 
            chStation2.AutoSize = true;
            chStation2.Location = new System.Drawing.Point(12, 43);
            chStation2.Name = "chStation2";
            chStation2.Size = new System.Drawing.Size(87, 24);
            chStation2.TabIndex = 2;
            chStation2.Text = "Station 2";
            chStation2.UseVisualStyleBackColor = true;
            chStation2.CheckedChanged += chStation_CheckedChanged;
            // 
            // chStation3
            // 
            chStation3.AutoSize = true;
            chStation3.Location = new System.Drawing.Point(12, 73);
            chStation3.Name = "chStation3";
            chStation3.Size = new System.Drawing.Size(87, 24);
            chStation3.TabIndex = 3;
            chStation3.Text = "Station 3";
            chStation3.UseVisualStyleBackColor = true;
            chStation3.CheckedChanged += chStation_CheckedChanged;
            // 
            // chStation4
            // 
            chStation4.AutoSize = true;
            chStation4.Location = new System.Drawing.Point(12, 103);
            chStation4.Name = "chStation4";
            chStation4.Size = new System.Drawing.Size(87, 24);
            chStation4.TabIndex = 4;
            chStation4.Text = "Station 4";
            chStation4.UseVisualStyleBackColor = true;
            chStation4.CheckedChanged += chStation_CheckedChanged;
            // 
            // CfrmController
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(120, 198);
            ControlBox = false;
            Controls.Add(chStation4);
            Controls.Add(chStation3);
            Controls.Add(chStation2);
            Controls.Add(chStation1);
            Controls.Add(btnClose);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CfrmController";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Irrigation controller";
            Shown += CfrmController_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chStation1;
        private System.Windows.Forms.CheckBox chStation2;
        private System.Windows.Forms.CheckBox chStation3;
        private System.Windows.Forms.CheckBox chStation4;
    }
}
