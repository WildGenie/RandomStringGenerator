using System;
using System.Text;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class MainForm : Form
    {
        private static readonly Random _random = new Random((int) DateTime.Now.Ticks);
        private static readonly string _passwordCharsLcase = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string _passwordCharsUcase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string _passwordCharsNumeric = "0123456789";
        private static readonly string _passwordCharsSpecial = "*$-+?_&=!%{}/";

        public MainForm()
        {
            InitializeComponent();
            stringType.SetItemChecked(0, true);
            stringType.SetItemChecked(2, true);
        }

        private void GenerateStringClick(object sender, EventArgs e)
        {
            generatedStrings.Text = string.Empty;
            var chars = string.Empty;
            if (stringType.GetItemChecked(0))
                chars += _passwordCharsLcase;
            if (stringType.GetItemChecked(1))
                chars += _passwordCharsUcase;
            if (stringType.GetItemChecked(2))
                chars += _passwordCharsNumeric;
            if (stringType.GetItemChecked(3))
                chars += _passwordCharsSpecial;
            var charsArray = chars.ToCharArray();
            if (charsArray.Length == 0)
            {
                MessageBox.Show("Üretilecek karakter tipi seçilmedi");
            }
            for (var i = 0; i < totalStringCount.Value; i++)
            {
                var charSize = _random.Next((int) minStringSize.Value, (int) maxStringSize.Value);
                var generatedString = new StringBuilder();
                for (var j = 0; j < charSize; j++)
                {
                    generatedString.Append(charsArray[_random.Next(charsArray.Length)]);
                }
                generatedStrings.AppendText(generatedString.ToString());
                generatedStrings.AppendText("\r\n");
            }
        }
    }
}