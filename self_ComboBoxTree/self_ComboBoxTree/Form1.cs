using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace self_ComboBoxTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //添加一个节点，这个结点是根节点。  
            TreeNode node = new TreeNode();
            node.Text = "hope";
            treeView1.Nodes.Add(node);

            TreeNode node1 = new TreeNode();
            node1.Text = "hopeone";
            TreeNode node11 = new TreeNode();
            node11.Text = "hopeoneone";
            TreeNode node2 = new TreeNode();
            node2.Text = "hopetwo";

            node1.Nodes.Add(node11);//在node1下面在添加一个结点。  

            node.Nodes.Add(node1);//node下的两个子节点。  
            node.Nodes.Add(node2);


            TreeNode t = new TreeNode("basil");//作为根节点。  
            treeView1.Nodes.Add(t);
            TreeNode t1 = new TreeNode("basilone");
            t.Nodes.Add(t1);
            TreeNode t2 = new TreeNode("basiltwo");
            t.Nodes.Add(t2);

            TreeNode newTn;
            foreach (TreeNode tn in treeView1.Nodes)
            {
                newTn = new TreeNode(tn.Text, tn.ImageIndex, tn.SelectedImageIndex);
                if (tn.Nodes.Count > 0)
                {
                    CopyChildren(newTn, tn);
                }
                comboBoxTree1.Nodes.Add(newTn);
            }
            comboBoxTree1.ClearSelectNode();


        }
        public void CopyChildren(TreeNode parent, TreeNode original)
        {
            TreeNode newTn;
            foreach (TreeNode tn in original.Nodes)
            {
                newTn = new TreeNode(tn.Text, tn.ImageIndex, tn.SelectedImageIndex);
                parent.Nodes.Add(newTn);
                if (tn.Nodes.Count > 0)
                {
                    CopyChildren(newTn, tn);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if((textBox1.Text.Trim()).Length>0)
            {
                //MessageBox.Show(textBox1.Text.Trim());
            }
        }

        private void comboBoxTree1_Value_Changed(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxTree1.Text;
        }
    }
}
