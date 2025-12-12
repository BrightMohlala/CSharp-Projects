/* CSIS2664, 2023
 * Test 1, Question 5
 * P Blignaut
 * August 2023
 */


using System.Windows.Forms;

namespace Bikes
{
    public partial class CdlgOutput : Form
    {
        public CdlgOutput(string txt)
        {
            InitializeComponent();
            txtOutput.Text = txt;
        } //ctor
    } //class
} //namesapce
