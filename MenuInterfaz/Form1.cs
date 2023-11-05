using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asdasdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //aqui se ejecuta el evento click del treeview
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text) 
            {
                case "Primera Opcion":
                    MessageBox.Show("Primera Opcion");
                    break;
                default:
                    MessageBox.Show("Test");
                    break;
            }
        }
    }
}
