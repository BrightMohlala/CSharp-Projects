
using System.Drawing;
using System.Windows.Forms;

partial class CfrmParticipant
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
        txtMessageOut = new TextBox();
        label1 = new Label();
        label2 = new Label();
        lstbxMessagesReceived = new ListBox();
        btnSend = new Button();
        chlstbxRecipients = new CheckedListBox();
        label3 = new Label();
        panel1 = new Panel();
        panel2 = new Panel();
        SuspendLayout();
        // 
        // txtMessageOut
        // 
        txtMessageOut.BorderStyle = BorderStyle.FixedSingle;
        txtMessageOut.Location = new Point(12, 41);
        txtMessageOut.Multiline = true;
        txtMessageOut.Name = "txtMessageOut";
        txtMessageOut.Size = new Size(457, 58);
        txtMessageOut.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 18);
        label1.Name = "label1";
        label1.Size = new Size(93, 20);
        label1.TabIndex = 1;
        label1.Text = "Message out";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 112);
        label2.Name = "label2";
        label2.Size = new Size(133, 20);
        label2.TabIndex = 2;
        label2.Text = "Messages received";
        // 
        // lstbxMessagesReceived
        // 
        lstbxMessagesReceived.FormattingEnabled = true;
        lstbxMessagesReceived.ItemHeight = 20;
        lstbxMessagesReceived.Location = new Point(12, 136);
        lstbxMessagesReceived.Name = "lstbxMessagesReceived";
        lstbxMessagesReceived.Size = new Size(457, 144);
        lstbxMessagesReceived.TabIndex = 3;
        // 
        // btnSend
        // 
        btnSend.Location = new Point(494, 246);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(120, 33);
        btnSend.TabIndex = 4;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // chlstbxRecipients
        // 
        chlstbxRecipients.CheckOnClick = true;
        chlstbxRecipients.FormattingEnabled = true;
        chlstbxRecipients.Location = new Point(494, 41);
        chlstbxRecipients.Name = "chlstbxRecipients";
        chlstbxRecipients.Size = new Size(120, 202);
        chlstbxRecipients.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(494, 18);
        label3.Name = "label3";
        label3.Size = new Size(77, 20);
        label3.TabIndex = 6;
        label3.Text = "Recipients";
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Location = new Point(12, 105);
        panel1.Name = "panel1";
        panel1.Size = new Size(470, 2);
        panel1.TabIndex = 7;
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Location = new Point(481, 105);
        panel2.Name = "panel2";
        panel2.Size = new Size(2, 180);
        panel2.TabIndex = 8;
        // 
        // CfrmParticipant
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(629, 286);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label3);
        Controls.Add(chlstbxRecipients);
        Controls.Add(btnSend);
        Controls.Add(lstbxMessagesReceived);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtMessageOut);
        Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(3, 4, 3, 4);
        Name = "CfrmParticipant";
        StartPosition = FormStartPosition.Manual;
        Text = "Participant";
        Load += CfrmParticipant_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtMessageOut;
    private Label label1;
    private Label label2;
    private ListBox lstbxMessagesReceived;
    private Button btnSend;
    private CheckedListBox chlstbxRecipients;
    private Label label3;
    private Panel panel1;
    private Panel panel2;
}

