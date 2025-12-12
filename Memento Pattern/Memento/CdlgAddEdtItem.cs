using System.Windows.Forms;

namespace Ct6Q3v2_Memento
{
    public partial class CdlgAddEditItem : Form
    {
        public string Item_name { get; private set; }
        public int Quantity { get; private set; }

        //Constructors
        //- For add
        public CdlgAddEditItem()
        {
            InitializeComponent();
        } //ctor 1

        //- For edit
        public CdlgAddEditItem(Item item)
        {
            InitializeComponent();
            txtItemName.Text = item.Name;
            nudQuantity.Value = item.Quantity;
        } //ctor 2

        //FormClosing
        private void CdlgAddEdtItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Item_name = txtItemName.Text;
                Quantity = (int)nudQuantity.Value;
            }
        } //CdlgAddEdtItem_FormClosing
    } //class
} //namespace
