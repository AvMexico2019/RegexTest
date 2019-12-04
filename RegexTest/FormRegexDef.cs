using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class FormRegexDef : Form
    {

        public FormRegexDef()
        {
            InitializeComponent();
            this.Load += FormRegexDef_Load;
        }

        void FormRegexDef_Load(object sender, EventArgs e)
        {
            webBrowserRegex.Navigate(string.Format("https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference", Application.StartupPath.Replace('\\', '/')));
        }
    }
}
