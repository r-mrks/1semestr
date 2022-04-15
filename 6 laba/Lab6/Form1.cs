using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public string[] words;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var text = textBox1.Text;
            Regex rg = new Regex(@"([А-Я][^,]+?\.)",RegexOptions.Multiline);
            MatchCollection matchCollection = rg.Matches(text);
            for (var i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];
                var text1 = match.Value;
                textBox2.AppendText(text1);
            }
        }
    }
}