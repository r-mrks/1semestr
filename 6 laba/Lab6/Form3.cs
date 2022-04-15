using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab6
{
    public partial class Form3 : Form3
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var text = textBox1.Text;
            Regex rg = new Regex(@"([a-zA-Z]+\s)",RegexOptions.Multiline);
            MatchCollection matchCollection = rg.Matches(text);
            for (var i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];
                var word = match.Value;
                var chars = word.ToCharArray(); /// копирует символ в этот экземпляр в массив символов.
                chars[0] = Char.ToUpper(chars[0]);
                word = new string(chars);
                textBox2.AppendText(word);
            }
        }
    }
}