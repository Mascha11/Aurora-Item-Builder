using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aurora_Item_Builder
{
    public partial class Form1 : Form
    {
        
        private string name;
        private string type;
        private string source;
        private string author;
        private string description;
        private string category;
        private int cost;
        private string currency;
        private int weight;
        private string ItemType;
        private string rarity;
        private string enhancement;
        private string focus;
        private string slot;
        private string attunement;
        private int NormalRange;
        private int LongRange;
        private int NumberDmgDice;
        private string TypeDmgDice;
        private int DmgFlatMod;
        private string DmgType;
        private string WeaponTags;
        private string ArmorType;
        private string ArmorImprovement;
        private int Charges;
        private string ACMod;
        private string ACFlat;
        private string ArmorAbilMod;
        private int MaxMod;
        private string CustomNameAdd;
        private string NameAdd;
        private string Stealth;
        
        public Form1()
        {
            InitializeComponent();
            string TypeString = Properties.Resources.ElementType;
            List<string> TypeList = TypeString.Split(',').ToList();
            SelectTypeCB.Items.AddRange(TypeList.ToArray());
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
            string convName = SelectNameTI.Text.ToUpper().Replace(' ', '_');
            string convType = SelectTypeCB.Text.ToUpper().Replace(' ', '_');
            string convSource = SelectSourceTI.Text.ToUpper().Replace(' ', '_');
            string convAuthor = SelectAuthorTI.Text.ToUpper().Replace(' ', '_');

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

        private void AddImprovement_CheckedChanged(object sender, EventArgs e)
        {
            SelectImprovementTagTL.Visible = ImprovementCheck.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            form2.Show();
        }

        private void SelectTypeCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*string TypeString = Properties.Resources.AbilityList;
            List<string> TypeList = TypeString.Split(',').ToList();
            SelectTypeCB.Items.AddRange(TypeList.ToArray());*/
        }

        private void SelectNameTI_TextChanged(object sender, EventArgs e)
        {
            name = SelectNameTI.Text;
        }

        private void SelectTypeCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            type = SelectTypeCB.SelectedItem?.ToString();
        }

        private void SelectSourceTI_TextChanged(object sender, EventArgs e)
        {
            source = SelectSourceTI.Text;
        }

        private void SelectAuthorTI_TextChanged(object sender, EventArgs e)
        {
            author = SelectAuthorTI.Text;
        }

        private void SelectCatCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category = SelectCatCB.SelectedItem?.ToString();
        }

        private void descriptionInput_TextChanged(object sender, EventArgs e)
        {
            description = descriptionInput.Text;
        }

        private void SelectCostNI_ValueChanged(object sender, EventArgs e)
        {
            cost = Convert.ToInt32(Math.Round(SelectCostNI.Value, 0)); ;
        }

        private void SelectCurrencyCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currency = SelectCurrencyCB.SelectedItem?.ToString();
        }

        private void SelectWeightNI_ValueChanged(object sender, EventArgs e)
        {
            weight = Convert.ToInt32(Math.Round(SelectWeightNI.Value, 0)); ;
        }

        private void SelectItemTypeCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ItemType = SelectItemTypeCB.SelectedItem?.ToString();
        }

        private void SelectRarityCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rarity = SelectRarityCB.SelectedItem?.ToString();
        }

        private void SelectEnhanceCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            enhancement = SelectEnhanceCB.SelectedItem?.ToString();
        }

        private void SelectFocusCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            focus = SelectFocusCB.SelectedItem?.ToString();
        }

        private void SelectSlotTL_SelectedValueChanged(object sender, EventArgs e)
        {
            slot = "";
            foreach (var item in SelectSlotTL.CheckedItems)
            {
                slot += item.ToString() + ", ";
            }
        }

        private void SelectAttuneTL_SelectedValueChanged(object sender, EventArgs e)
        {
            attunement = "";
            foreach (var item in SelectAttuneTL.CheckedItems)
            {
                attunement += item.ToString() + ", ";
            }
        }

        private void SelectNormalRangeNI_ValueChanged(object sender, EventArgs e)
        {
            NormalRange = Convert.ToInt32(Math.Round(SelectNormalRangeNI.Value, 0)); ;
        }

        private void SelectLongRangeNI_ValueChanged(object sender, EventArgs e)
        {
            LongRange = Convert.ToInt32(Math.Round(SelectLongRangeNI.Value, 0)); ;
        }

        private void SelectNumberDiceNI_ValueChanged(object sender, EventArgs e)
        {
            NumberDmgDice = Convert.ToInt32(Math.Round(SelectNumberDiceNI.Value, 0)); ;
        }

        private void SelectDmgDiceCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TypeDmgDice = SelectDmgDiceCB.SelectedItem?.ToString();
        }

        private void SelectDmgModNI_ValueChanged(object sender, EventArgs e)
        {
            DmgFlatMod = Convert.ToInt32(Math.Round(SelectDmgModNI.Value, 0)); ;
        }

        private void SelectDmgTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DmgType = SelectDmgTypeCB.SelectedItem?.ToString();
        }

        private void SelectWpnTagTL_SelectedValueChanged(object sender, EventArgs e)
        {
            WeaponTags = "";
            foreach (var item in SelectWpnTagTL.CheckedItems)
            {
                WeaponTags += item.ToString() + ", ";
            }
        }

        private void SelectArmorTypeCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArmorType = SelectArmorTypeCB.SelectedItem?.ToString();
        }

        private void SelectImprovementTagTL_SelectedValueChanged(object sender, EventArgs e)
        {
            ArmorImprovement = "";
            foreach (var item in SelectImprovementTagTL.CheckedItems)
            { ArmorImprovement += item.ToString() + ", "; }
        }

        private void SelectChargesNI_ValueChanged(object sender, EventArgs e)
        {
            Charges = Convert.ToInt32(Math.Round(SelectChargesNI.Value, 0)); ;
        }

        private void SelectACModNI_ValueChanged(object sender, EventArgs e)
        {
            ACMod = SelectACModNI.Text;
        }

        private void SelectACFlatNI_ValueChanged(object sender, EventArgs e)
        {
            ACFlat = SelectACFlatNI.Text;
        }

        private void SelectArmorAbilCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArmorAbilMod = SelectArmorAbilCB.SelectedItem?.ToString();
        }

        private void SelectACAbilModMaxNI_ValueChanged(object sender, EventArgs e)
        {
            MaxMod = Convert.ToInt32(Math.Round(SelectChargesNI.Value, 0)); ;
        }

        private void SelectCustomNameAddTI_TextChanged(object sender, EventArgs e)
        {
            CustomNameAdd = SelectCustomNameAddTI.Text;
        }

        private void SelectNameAddCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NameAdd = SelectNameAddCB.SelectedItem?.ToString();
        }

        private void SelectArmorStealthModCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Stealth = SelectArmorStealthModCB.SelectedItem?.ToString();
        }
    }
}
