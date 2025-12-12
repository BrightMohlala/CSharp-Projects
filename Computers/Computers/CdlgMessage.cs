using System.Windows.Forms;

namespace Computers
{
    public partial class CdlgMessage : Form
    {
        public CdlgMessage(string caption, string message)
        {
            InitializeComponent();
            this.Text = caption;
            this.lblMessage.Text = message;
        } //ctor
    } //class
} //namespace
