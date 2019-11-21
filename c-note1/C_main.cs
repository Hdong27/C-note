using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_note1

{
    public partial class C_main : Form
    {
       

        public C_main()
        {
            InitializeComponent();

        }
        
        private void BnoteL_Click(object sender, EventArgs e)
        {
            PDFViewer newFrom = new PDFViewer();
            newFrom.Show();

        }

        private void BnoteR_Click(object sender, EventArgs e)
        {
            note_P newFrom = new note_P();
            newFrom.Show();
        }
       

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
