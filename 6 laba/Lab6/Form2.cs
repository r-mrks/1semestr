using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var text = textBox1.Text;
            Regex rg = new Regex(@"\(.*\)",RegexOptions.Multiline);
            var str = rg.Replace(text, "");
            textBox2.AppendText(str);
        }
    }
}