namespace CT7Q2_Weather
{
    partial class CfrmWeather
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
            picWeather = new System.Windows.Forms.PictureBox();
            lblProvince = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnClose = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            lblMinTemp = new System.Windows.Forms.Label();
            lblMaxTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picWeather).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picWeather
            // 
            picWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            picWeather.Location = new System.Drawing.Point(0, 32);
            picWeather.Name = "picWeather";
            picWeather.Size = new System.Drawing.Size(508, 393);
            picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picWeather.TabIndex = 0;
            picWeather.TabStop = false;
            // 
            // lblProvince
            // 
            lblProvince.Dock = System.Windows.Forms.DockStyle.Top;
            lblProvince.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProvince.Location = new System.Drawing.Point(0, 0);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new System.Drawing.Size(508, 32);
            lblProvince.TabIndex = 1;
            lblProvince.Text = "Province";
            lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(lblMinTemp);
            groupBox1.Controls.Add(lblMaxTemp);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Location = new System.Drawing.Point(0, 425);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(508, 72);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(401, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(95, 41);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnStart.Location = new System.Drawing.Point(269, 19);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(95, 41);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblMinTemp
            // 
            lblMinTemp.AutoSize = true;
            lblMinTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMinTemp.Location = new System.Drawing.Point(6, 14);
            lblMinTemp.Name = "lblMinTemp";
            lblMinTemp.Size = new System.Drawing.Size(94, 25);
            lblMinTemp.TabIndex = 5;
            lblMinTemp.Text = "min Temp";
            lblMinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblMinTemp.Visible = false;
            // 
            // lblMaxTemp
            // 
            lblMaxTemp.AutoSize = true;
            lblMaxTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMaxTemp.Location = new System.Drawing.Point(6, 40);
            lblMaxTemp.Name = "lblMaxTemp";
            lblMaxTemp.Size = new System.Drawing.Size(97, 25);
            lblMaxTemp.TabIndex = 4;
            lblMaxTemp.Text = "max Temp";
            lblMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblMaxTemp.Visible = false;
            // 
            // CfrmWeather
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(508, 497);
            Controls.Add(picWeather);
            Controls.Add(groupBox1);
            Controls.Add(lblProvince);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "CfrmWeather";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Weather forecast";
            Shown += CfrmWeather_Shown;
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
    }
}
