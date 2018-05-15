using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDataProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Data(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem(textBoxName.Text);
            list.SubItems.Add(textBoxSurname.Text);
            //........
            //........
            listView1.Items.Add(list);
        }
    }
}
