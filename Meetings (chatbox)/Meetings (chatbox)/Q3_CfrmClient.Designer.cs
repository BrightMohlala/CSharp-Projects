using System.Drawing;
using System.Windows.Forms;

partial class CfrmClient
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
        btnAddParticipant = new Button();
        SuspendLayout();
        // 
        // btnAddParticipant
        // 
        btnAddParticipant.Location = new Point(40, 39);
        btnAddParticipant.Name = "btnAddParticipant";
        btnAddParticipant.Size = new Size(133, 39);
        btnAddParticipant.TabIndex = 0;
        btnAddParticipant.Text = "Add participant";
        btnAddParticipant.UseVisualStyleBackColor = true;
        btnAddParticipant.Click += btnAddParticipant_Click;
        // 
        // CfrmClient
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(217, 116);
        Controls.Add(btnAddParticipant);
        Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(3, 4, 3, 4);
        Name = "CfrmClient";
        StartPosition = FormStartPosition.Manual;
        Text = "Online meetings";
        ResumeLayout(false);
    }

    #endregion

    private Button btnAddParticipant;
}
