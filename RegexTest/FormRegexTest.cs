using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace RegexTest
{
    public partial class FormRegexTest : Form
    {
        ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
        List<INFORMATION_SCHEMA_Result> results;
        int StoreProcedureActivo = 0;
        int RegexSelected = -1;
        List<string> RegexSettings;
        bool displayHEX = false;
        int HexSize = 44;
        FormRegexDef WebHelp = new FormRegexDef();

        public FormRegexTest()
        {
            InitializeComponent();
            Found.ScrollBars = ScrollBars.Vertical;
            richTextBoxStoreProcedureDefinition.ScrollBars = RichTextBoxScrollBars.Vertical;
            results = ctx.Database.SqlQuery<INFORMATION_SCHEMA_Result>("SELECT OBJECT_NAME(OBJECT_ID) as ROUTINE_NAME, OBJECT_DEFINITION(OBJECT_ID) as ROUTINE_DEFINITION  FROM SYS.PROCEDURES").ToList();
            foreach(INFORMATION_SCHEMA_Result sp in results)
            {
                comboBoxStoreProcedures.Items.Add(sp.ROUTINE_NAME);
            }

            // Cadena inicial: >["\\d+","\\w+"]<<
            string StringRegexSettings;
            StringRegexSettings = Properties.Settings.Default.RegexMemory;
            textBoxINFO.Text = StringRegexSettings;
            RegexSettings = JsonConvert.DeserializeObject<List<string>>(StringRegexSettings);
            foreach(string sr in RegexSettings)
            {
                comboBoxRegexDef.Items.Add(sr);
            }
            textBoxASCIITable.ScrollBars = ScrollBars.Vertical;
            string espchars = "\t\n\r";
            //Console.WriteLine(StringHexDump.HexDump(espchars, 20));
            //Console.WriteLine(StringHexDump.ASCIITable(16));
            
        }   

        
        private void Apply_Click(object sender, EventArgs e)
        {
            Found.Text = "";
            Regex rx = new Regex(textBoxRegex.Text, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (rx.Match(results[StoreProcedureActivo].ROUTINE_DEFINITION).Success)
            {
                textBoxINFO.Text = "Success";
                MatchCollection matches = rx.Matches(results[StoreProcedureActivo].ROUTINE_DEFINITION);
                
                foreach (Match m in matches)
                {
                    string newline = Environment.NewLine;
                    Found.Text += m.Value + newline;
                }
            }
            else
            {
                textBoxINFO.Text = "Not Found";
            }
        }

        private void comboBoxStoreProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayHEX)
            {
                richTextBoxStoreProcedureDefinition.Text = StringHexDump.HexDump(results[StoreProcedureActivo = comboBoxStoreProcedures.SelectedIndex].ROUTINE_DEFINITION, HexSize);
            }
            else
            {
                richTextBoxStoreProcedureDefinition.Text = results[StoreProcedureActivo = comboBoxStoreProcedures.SelectedIndex].ROUTINE_DEFINITION;
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string SRegexSettings = JsonConvert.SerializeObject(RegexSettings);
            textBoxINFO.Text = SRegexSettings;
            Properties.Settings.Default.RegexMemory = SRegexSettings;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void buttonInsertRegex_Click(object sender, EventArgs e)
        {
            RegexSettings.Add(textBoxRegex.Text);
            comboBoxRegexDef.Items.Add(textBoxRegex.Text);
            
        }

        private void buttonDeleteRegex_Click(object sender, EventArgs e)
        {
            if (RegexSelected >= 0)
            {
                RegexSettings.RemoveAt(RegexSelected);
                comboBoxRegexDef.Items.RemoveAt(RegexSelected);
                
                RegexSelected = -1;
                textBoxRegex.Text = "";
            }
        }

        private void comboBoxRegexDef_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRegex.Text = (string) comboBoxRegexDef.Items[comboBoxRegexDef.SelectedIndex];
            RegexSelected = comboBoxRegexDef.SelectedIndex;
        }

        private void buttonHEX_Click(object sender, EventArgs e)
        {
            if (displayHEX)
            {
                displayHEX = false;
                richTextBoxStoreProcedureDefinition.Text = results[StoreProcedureActivo].ROUTINE_DEFINITION;
                buttonHEX.Text = "ASCII";
            }
            else
            {
                displayHEX = true;
                richTextBoxStoreProcedureDefinition.Text = StringHexDump.HexDump(results[StoreProcedureActivo].ROUTINE_DEFINITION, HexSize);
                buttonHEX.Text = "HEXA";
            }
        }

        private void buttonSaveRegex_Click(object sender, EventArgs e)
        {
            string SRegexSettings = JsonConvert.SerializeObject(RegexSettings);
            textBoxINFO.Text = SRegexSettings;
            Properties.Settings.Default.RegexMemory = SRegexSettings;
            Properties.Settings.Default.Save();
        }

        private void buttonRegexDef_Click(object sender, EventArgs e)
        {
            WebHelp.Show();
        }
    }
}
