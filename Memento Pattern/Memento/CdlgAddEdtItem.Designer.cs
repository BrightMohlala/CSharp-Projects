namespace Ct6Q3v2_Memento
{
    partial class CdlgAddEditItem
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
            label1 = new System.Windows.Forms.Label();
            txtItemName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Item name";
            // 
            // txtItemName
            // 
            txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtItemName.Location = new System.Drawing.Point(96, 25);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new System.Drawing.Size(100, 27);
            txtItemName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new System.Drawing.Point(96, 71);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(64, 27);
            nudQuantity.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(29, 122);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(73, 36);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(123, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(73, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CdlgAddEdtItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(216, 180);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(nudQuantity);
            Controls.Add(label2);
            Controls.Add(txtItemName);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CdlgAddEdtItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add/Edt Item";
            FormClosing += CdlgAddEdtItem_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}