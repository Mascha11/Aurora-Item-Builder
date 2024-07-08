using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aurora_Item_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Field8_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = SelectCatCB.SelectedItem;
            if (SelectCatCB.SelectedItem.ToString() == "Spellcasting Focus")
            {
                SelectFocusCB.Visible = true;
            }
            else
            {
                SelectFocusCB.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Gather input from the controls
            string name = SelectNameTI.Text;
            string convName = SelectNameTI.Text.ToUpper().Replace(' ', '_');
            string type = SelectTypeCB.SelectedItem?.ToString();
            string convType = SelectTypeCB.Text.ToUpper().Replace(' ', '_');
            string source = SelectSourceTI.Text;
            string convSource = SelectSourceTI.Text.ToUpper().Replace(' ', '_');
            string author = SelectAuthorTI.Text;
            string convAuthor = SelectAuthorTI.Text.ToUpper().Replace(' ', '_');
            string description = Field6.Text;
            string category = SelectCatCB.SelectedItem?.ToString();
            string cost = SelectCostNI.Text;
            string currency = SelectCurrencyCB.SelectedItem?.ToString();
            string weight = SelectWeightNI.Text;
            string ItemType = SelectItemTypeCB.SelectedItem?.ToString();
            string rarity = SelectRarityCB.SelectedItem?.ToString();
            string enhancement = SelectEnhanceCB.SelectedItem?.ToString();
            string focus = SelectFocusCB.SelectedItem?.ToString();
            string slot = "";
            foreach (var item in SelectSlotTL.CheckedItems)
            {
                slot += item.ToString() + ", ";
            }
            string attunement = "";
            foreach (var item in SelectAttuneTL.CheckedItems)
            {
                attunement += item.ToString() + ", ";
            }
            string NormalRange = SelectNormalRangeNI.Text;
            string LongRange = SelectLongRangeNI.Text;
            string NumberDmgDice = SelectNumberDiceNI.Text;
            string TypeDmgDice = SelectDmgDiceCB.SelectedItem?.ToString();
            string DmgFlatMod = SelectDmgModNI.Text;
            string DmgType = SelectDmgTypeCB.SelectedItem?.ToString();
            string WeaponTags = "";
            foreach (var item in SelectWpnTagTL.CheckedItems)
            {
                WeaponTags += item.ToString() + ", ";
            }
            string ArmorType = SelectArmorTypeCB.SelectedItem?.ToString();
            string ArmorImprovement = "";
            foreach ( var item in SelectImprovementTagTL.CheckedItems)
            { ArmorImprovement += item.ToString() + ", "; }
            string Charges = SelectChargesNI.Text;
            string ACMod = SelectACModNI.Text;
            string ACFlat = SelectACFlatNI.Text;
            string ArmorAbilMod = SelectArmorAbilCB.SelectedItem?.ToString();
            string MaxMod   = SelectACAbilModMaxNI.Text;
            string CustomNameAdd = SelectCustomNameAddTI.Text;
            string NameAdd = SelectNameAddCB.SelectedItem?.ToString();  
            string Stealth = SelectArmorStealthModCB.SelectedItem?.ToString();

            // Format the output text
            StringBuilder output = new StringBuilder();
            output.AppendLine("<element name\"" + name + "\"" + " type\"" + type + "\"" + " source=\"" + source + "\"" + " id=\"ID_{" + convAuthor + "}_{" + convSource + "}_{" + convType + "}_{" + convName + "}\">");
            output.AppendLine("<description>");
            output.AppendLine(description + "</description>");
            output.AppendLine("</description>");
            output.AppendLine("<setters>");
            output.AppendLine("<set name=\"keywords\"></set>");
            output.AppendLine("<set name=\"category\">" + category + "</set>");
            output.AppendLine("<set name=\"cost\"> currency=\"" + currency + "\">" + cost + "</set>");
            output.AppendLine("<set name=\"weight\" lb=\"" + weight + "\">" + weight + "lb" + "</set>");
            //output.AppendLine("ComboBox Selected: " + (type ?? "None"));
            //output.AppendLine("CheckedListBox Selected Items:");
            //output.Append(checkedListBoxInput.ToString());

            // Display the formatted text in richTextBox1
            elementText.Text = output.ToString();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Field27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddImprovement_CheckedChanged(object sender, EventArgs e)
        {
            SelectImprovementTagTL.Visible = ImprovementCheck.Checked;
        }
    }
}
