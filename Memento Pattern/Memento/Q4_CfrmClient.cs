using System.Collections.Generic;
using System.Windows.Forms;

namespace Ct6Q3v2_Memento
{
    public partial class CfrmClient : Form
    {
        //List of caretakers for Item
        List<ctItem> caretakers = ctItem.GetCaretakers();

        //Constructor
        public CfrmClient()
        {
            InitializeComponent();
        } //ctor

        //Initialise list of caretakers
        private void CfrmClient_Load(object sender, System.EventArgs e)
        {
            //caretakers = ctItem.GetCaretakers();
            RefreshListBox();
        } //CfrmClient_Load

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        } //btnClose_Click

        private void RefreshListBox()
        {
            lstbxItems.DataSource = null;
            lstbxItems.DataSource = caretakers;
            lstbxItems.DisplayMember = "Name";
        } //RefreshListbox

        private void btnAddItem_Click(object sender, System.EventArgs e)
        {
            CdlgAddEditItem dlg = new CdlgAddEditItem();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ctItem ct_item = ctItem.AddItem(dlg.Item_name, dlg.Quantity);
                caretakers.Add(ct_item);
                RefreshListBox();
            }
        } //AddItem

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            ctItem ct_item = ((ctItem)lstbxItems.SelectedItem);
            CdlgAddEditItem dlg = new CdlgAddEditItem(ct_item.item);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ct_item.EditItem(dlg.Item_name, dlg.Quantity);
                //RefreshListBox();
            }
        } //btnEdit_Click

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            //Get caretaker
            ctItem ct_item = ((ctItem)lstbxItems.SelectedItem);
            
            //Restore item from history
            ct_item.Restore();

            MessageBox.Show("Item " + ct_item.Name + " restored");

            //RefreshListBox();
        } //btnRestore_Click

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Sure?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Get caretaker of item
                ctItem ct_item = ((ctItem)lstbxItems.SelectedItem);

                //Remove item from DB
                ctItem.DeleteItem(ct_item.id);
                //Remove item from list of caretakers
                caretakers.Remove(ct_item);

                RefreshListBox();
            } //if confirm
        } //btnDelete_Click
    } //class CfrmClient
} //namespace
