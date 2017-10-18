using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            foreach (int i in nums)
            {
                richTextBox1.AppendText(i + ",");
            }
            richTextBox1.AppendText("\n=================\n");
            nums.Remove(3);
            foreach (int i in nums)
            {
                richTextBox1.AppendText(i + ",");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
