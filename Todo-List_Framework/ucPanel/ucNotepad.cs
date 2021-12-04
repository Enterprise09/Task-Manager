using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List_Framework.ucPanel
{
    public partial class ucNotepad : UserControl
    {
        public ucNotepad()
        {
            InitializeComponent();
        }

        private void pb_AddNote_Click(object sender, EventArgs e)
        {
            (new AddNoteForm()).Show();
        }
    }
}
