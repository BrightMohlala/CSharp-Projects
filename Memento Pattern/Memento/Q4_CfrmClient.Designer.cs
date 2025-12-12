using System.Windows.Forms;

namespace Ct6Q3v2_Memento
{
    partial class CfrmClient
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
            btnRestore = new Button();
            btnAddItem = new Button();
            lstbxItems = new ListBox();
            btnEdit = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnRestore
            // 
            btnRestore.Location = new System.Drawing.Point(159, 11);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new System.Drawing.Size(141, 33);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "Restore current";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new System.Drawing.Point(159, 89);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(141, 33);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add item ...";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lstbxItems
            // 
            lstbxItems.FormattingEnabled = true;
            lstbxItems.ItemHeight = 20;
            lstbxItems.Location = new System.Drawing.Point(12, 12);
            lstbxItems.Name = "lstbxItems";
            lstbxItems.Size = new System.Drawing.Size(130, 184);
            lstbxItems.Sorted = true;
            lstbxItems.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(159, 50);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(141, 33);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit current ...";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(159, 167);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(141, 33);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(159, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(141, 33);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CfrmClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 212);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(lstbxItems);
            Controls.Add(btnAddItem);
            Controls.Add(btnRestore);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CfrmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += CfrmClient_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRestore;
        private Button btnAddItem;
        private ListBox lstbxItems;
        private Button btnEdit;
        private Button btnClose;
        private Button btnDelete;
    }
}
