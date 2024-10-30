using System;
using System.Windows.Forms;

namespace pd4
{
    public partial class Form1 : Form
    {
        private BinaryTree tree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void DodajLiczbe_Click(object sender, EventArgs e)
        {
            if (int.TryParse(liczbaTextBox.Text, out int liczba))
            {
                tree.Add(liczba);
                liczbaTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Podaj prawidłową liczbę.");
            }
        }

        private void WyswietlDrzewo_Click(object sender, EventArgs e)
        {
            drzewoTreeView.Nodes.Clear();
            if (tree.Root != null)
            {
                DisplayTree(tree.Root, drzewoTreeView.Nodes);
            }
        }

        private void DisplayTree(BinaryTreeNode node, TreeNodeCollection treeNodes)
        {
            if (node == null)
                return;

            var newNode = treeNodes.Add(node.Value.ToString());
            DisplayTree(node.Left, newNode.Nodes);
            DisplayTree(node.Right, newNode.Nodes);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            tree = new BinaryTree();
            drzewoTreeView.Nodes.Clear();
        }
    }
}

