namespace SimpleCSEC
{
    partial class CfrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfrmMain));
            btnClose = new System.Windows.Forms.Button();
            btnNewConsoleApp = new System.Windows.Forms.Button();
            txtMain = new System.Windows.Forms.RichTextBox();
            btnRun = new System.Windows.Forms.Button();
            txtCompilerOutput = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnErrors = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(588, 548);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(96, 32);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNewConsoleApp
            // 
            btnNewConsoleApp.FlatAppearance.BorderSize = 0;
            btnNewConsoleApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnNewConsoleApp.Image = (System.Drawing.Image)resources.GetObject("btnNewConsoleApp.Image");
            btnNewConsoleApp.Location = new System.Drawing.Point(12, 12);
            btnNewConsoleApp.Name = "btnNewConsoleApp";
            btnNewConsoleApp.Size = new System.Drawing.Size(44, 43);
            btnNewConsoleApp.TabIndex = 2;
            btnNewConsoleApp.UseVisualStyleBackColor = true;
            btnNewConsoleApp.Click += btnNewConsoleApp_Click;
            // 
            // txtMain
            // 
            txtMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMain.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMain.Location = new System.Drawing.Point(12, 61);
            txtMain.Name = "txtMain";
            txtMain.Size = new System.Drawing.Size(672, 283);
            txtMain.TabIndex = 3;
            txtMain.Text = "";
            // 
            // btnRun
            // 
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRun.Image = (System.Drawing.Image)resources.GetObject("btnRun.Image");
            btnRun.Location = new System.Drawing.Point(62, 12);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(44, 43);
            btnRun.TabIndex = 4;
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtCompilerOutput
            // 
            txtCompilerOutput.BackColor = System.Drawing.SystemColors.Window;
            txtCompilerOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCompilerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            txtCompilerOutput.Location = new System.Drawing.Point(0, 0);
            txtCompilerOutput.Name = "txtCompilerOutput";
            txtCompilerOutput.ReadOnly = true;
            txtCompilerOutput.Size = new System.Drawing.Size(670, 135);
            txtCompilerOutput.TabIndex = 5;
            txtCompilerOutput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 363);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 21);
            label1.TabIndex = 6;
            label1.Text = "Compiler output";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCompilerOutput);
            panel1.Location = new System.Drawing.Point(12, 387);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(672, 137);
            panel1.TabIndex = 7;
            // 
            // btnErrors
            // 
            btnErrors.Location = new System.Drawing.Point(484, 548);
            btnErrors.Margin = new System.Windows.Forms.Padding(4);
            btnErrors.Name = "btnErrors";
            btnErrors.Size = new System.Drawing.Size(96, 32);
            btnErrors.TabIndex = 9;
            btnErrors.Text = "Errors";
            btnErrors.UseVisualStyleBackColor = true;
            btnErrors.Click += btnErrors_Click;
            // 
            // CfrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(699, 593);
            ControlBox = false;
            Controls.Add(btnErrors);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Controls.Add(txtMain);
            Controls.Add(btnNewConsoleApp);
            Controls.Add(btnClose);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "CfrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Simple C# Editor and Compiler (SCSEC)";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewConsoleApp;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox txtCompilerOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnErrors;
    }
}
