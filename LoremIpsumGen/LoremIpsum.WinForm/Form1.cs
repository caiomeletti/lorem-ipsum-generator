using LoremIpsum.Services.Interfaces;
using LoremIpsum.Services.Services;

namespace LoremIpsum.WinForm
{
    public partial class Form1 : Form
    {
        private readonly ILoremIpsumService _loremIpsumSevice;

        public Form1()
        {
            InitializeComponent();
            _loremIpsumSevice = new LoremIpsumService();
            rdbWords.Checked = true;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (rdbWords.Checked)
                result = _loremIpsumSevice.GenerateWords((int)nudAmontOf.Value);
            else if (rdbSentences.Checked)
                result = _loremIpsumSevice.GenerateSentece((int)nudAmontOf.Value);
            else if (rdbParagraphs.Checked)
                result = _loremIpsumSevice.GenerateParagraphs((int)nudAmontOf.Value);

            textBox1.Text = result;
        }
    }
}
