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
    public partial class C_noteL : Form
    {
        public C_noteL()
        {
            InitializeComponent();
        }

        private void Bpdf_Click(object sender, EventArgs e)
        {
            PDFViewer newFrom = new PDFViewer();
            newFrom.Show();
        }

        private void Bms_Click(object sender, EventArgs e)
        {
            MSViewer newForm = new MSViewer();
            newForm.Show();
        }
    }
}
