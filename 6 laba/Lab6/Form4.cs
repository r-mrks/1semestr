using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        } 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var text = textBox1.Text;
            Regex rg = new Regex(@"^([А-Я][а-я]+)\s+([А-Я])\.\s*([А-Я])\.\s+\$(\d+)");
            MatchCollection matchCollection = rg.Matches(text);
            for (var i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];
                var text1 = match.Value;
                if (match.Success && int.Parse(match.Groups[4].Value) > 9000)
                {
                    textBox2.AppendText(text1);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}