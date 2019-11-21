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
    public partial class C_noteR : Form
    {
        public C_noteR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            note_T newFrom = new note_T();
            newFrom.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            note_P newFrom = new note_P();
            newFrom.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
