using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            demolistView.View = View.Details;
            demolistView.Width = 400;

            List<string> name = new List<string> { "Joe", "Jill", "Aaron" };
            List<string> phone = new List<string> { "555-555-5555", "666-666-6666", "777-777-7777" };
            List<string> email = new List<string> { "Joe@a.com", "Jill@b.com", "Aaron@c.com" };
            List<string> program = new List<string> { "Programming", "Networking", "Speicalist" };

            for(int = i=0;i<name.Count(); i++)
            {
                ListViewItem item = new ListViewItem(name[i]);
                item.SubItems.Add(phone[i]);
                item.SubItems.Add(email[i]);
                item.SubItems.Add(program[i]);
                demolistView.Items.Add(item);
            }

            /*ListViewItem item1 = new ListViewItem("Joe");

            item1.SubItems.Add("555-555-5678");
            item1.SubItems.Add("a@b.com");
            item1.SubItems.Add("programming");

            ListViewItem item2 = new ListViewItem("Jill");

            item2.SubItems.Add("555-678-2345");
            item2.SubItems.Add("c@d.com");
            item2.SubItems.Add("networking");

            ListViewItem item3 = new ListViewItem("Aaron");

            item3.SubItems.Add("555-543-6666");
            item3.SubItems.Add("e@f.com");
            item3.SubItems.Add("other");*/

            demolistView.Columns.Add("Name        ", -2, HorizontalAlignment.Left);
            demolistView.Columns.Add("Phone       ", -2, HorizontalAlignment.Left);
            demolistView.Columns.Add("Email       ", -2, HorizontalAlignment.Left);
            demolistView.Columns.Add("Program     ", -2, HorizontalAlignment.Left);

            demolistView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            demolistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (demolistView.SelectedItems.Count > 0)
            {
                ListViewItem item = demolistView.SelectedItems[0];
                outputLabel.Text = item.SubItems[0].Text;
                outputLabel.Text += "\n" + item.SubItems[1].Text;
                outputLabel.Text += "\n" + item.SubItems[2].Text;
            }
            else
            {
                outputLabel.Text = string.Empty;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Output";
        }
    }
}
