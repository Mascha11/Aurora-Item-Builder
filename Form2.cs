using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Aurora_Item_Builder
{
    public partial class Form2 : Form

    {
        private string Rule1;
        private string Rule2;
        private string Rule3;
        private string Rule4;
        private string Rule5;
        private string RuleValue;
        private List<string> RulesList;
        public Form2()
        {
            InitializeComponent();
            RulesList = new List<string>();
        }

        private void RuleBuilder1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rule1 = RuleBuilder1.SelectedItem?.ToString();
            RuleBuilder1.Text = Rule1;
            RuleBuilder2.Text = "";
            RuleBuilder3.Text = "";
            RuleBuilder4.Text = "";
            RuleBuilder5.Text = "";
            RuleBuilder2.Items.Clear();
            RuleBuilder3.Items.Clear();
            RuleBuilder4.Items.Clear();
            RuleBuilder5.Items.Clear();
            if (Rule1 == "change stat")
            {
                RuleBuilder2.Items.Add("Speed");
                RuleBuilder2.Items.Add("Ability");
                RuleBuilder2.Items.Add("Vision");
                RuleBuilder2.Items.Add("Check");
                RuleBuilder2.Items.Add("Damage");
                RuleBuilder2.Items.Add("AC");
                RuleBuilder2.Items.Add("Proficiency");
                RuleBuilder2.Items.Add("Initiative");
            }
            else
            {
                RuleBuilder2.Items.Add("Grant Condition");
                RuleBuilder2.Items.Add("Grant Proficiency");
                RuleBuilder2.Items.Add("Grant Vision");
                RuleBuilder2.Items.Add("Grant Language");
                RuleBuilderValue.Visible = false;
                RuleBuilder4.Visible = false;
            }
        }

        private void RuleBuilder2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rule2 = RuleBuilder2.SelectedItem?.ToString();
            RuleBuilder3.Text = "";
            RuleBuilder4.Text = "";
            RuleBuilder5.Text = "";
            RuleBuilder3.Items.Clear();
            RuleBuilder4.Items.Clear();
            RuleBuilder5.Items.Clear();
            if (Rule2 == "Speed")
            {
                RuleBuilder4.Visible = false;
                RuleBuilder3.Items.Add("Base");
                RuleBuilder3.Items.Add("Swim");
                RuleBuilder3.Items.Add("Climb");
                RuleBuilder3.Items.Add("Fly");
                RuleBuilderValue.Minimum = 0;
                RuleBuilderValue.Maximum = 100;
            }
            if (Rule2 == "Ability")
            {
                RuleBuilderValue.Visible = true;
                RuleBuilder3.Items.Add("set Score");
                RuleBuilder3.Items.Add("add to Score");
                RuleBuilder3.Items.Add("change max Score");
            }
            if (Rule2 == "Vision")
            {
                RuleBuilder4.Visible = false;
                string VisionString = Properties.Resources.Vision;
                List<string> visionList = VisionString.Split(',').ToList();
                RuleBuilder3.Items.AddRange(visionList.ToArray());
                RuleBuilderValue.Minimum = 0;
                RuleBuilderValue.Maximum = 100;

            }
            if (Rule2 == "Check")
            {
                RuleBuilder3.Items.Add("Ability");
                RuleBuilder3.Items.Add("Skill");
                RuleBuilder3.Items.Add("Spell");
            }
            if (Rule2 == "Damage")
            {
                RuleBuilder3.Items.Add("Longbow");
                RuleBuilder3.Items.Add("Shortbow");
                RuleBuilder3.Items.Add("Melee");
                RuleBuilder3.Items.Add("Martial Arts");
                RuleBuilder3.Items.Add("Agonizing Blast");
                RuleBuilder3.Items.Add("Unarmed");
                RuleBuilder3.Items.Add("Companion");
                RuleBuilder3.Items.Add("Lifedrinker");
                RuleBuilder3.Items.Add("Natural");
                RuleBuilder3.Items.Add("More...");
            }
            if (Rule2 == "Grant Condition")
            {
                RuleBuilder4.Visible = true;
                RuleBuilder3.Items.Add("Damage Immunity");
                RuleBuilder3.Items.Add("Damage Resistance");
                RuleBuilder3.Items.Add("Damage Vulnerability");

                string DamageString = Properties.Resources.DamageTypes;
                List<string> DamageList = DamageString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(DamageList.ToArray());
            }
            if (Rule2 == "Grant Proficiency")
            {
                RuleBuilder3.Items.Add("Skill");
                RuleBuilder3.Items.Add("Gaming Set");
                RuleBuilder3.Items.Add("Weapon");
                RuleBuilder3.Items.Add("Armor");
                RuleBuilder3.Items.Add("Tool");
            }
            if (Rule2 == "Grant Vision")
            {
                string VisionString = Properties.Resources.Vision;
                List<string> visionList = VisionString.Split(',').ToList();
                RuleBuilder3.Items.AddRange(visionList.ToArray());
            }
            if (Rule2 == "Grant Language")
            {
                RuleBuilder4.Visible = false;
                string LanguageString = Properties.Resources.LanguageList;
                List<string> LangList = LanguageString.Split(',').ToList();
                RuleBuilder3.Items.AddRange(LangList.ToArray());
            }
        }

        private void RuleBuilder3_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Rule3 = RuleBuilder3.SelectedItem?.ToString();
            string CheckRule2 = Rule2;
            RuleBuilder4.Text = "";
            RuleBuilder5.Text = "";
            if (Rule2 != "Grant Condition")
            {
                RuleBuilder4.Items.Clear();
                RuleBuilder5.Items.Clear();
            }
            if (RuleBuilder3.SelectedItem != null)
            {
                //richTextBox1.AppendText(RuleBuilder3.SelectedItem.ToString() + Environment.NewLine);
            }

            if (Rule3 == "set Score" || Rule3 == "add to Score" || Rule3 == "change max Score")
            {
                bool RuleField4Vis = true;
                RuleBuilder4.Visible = RuleField4Vis;

                string AbilString = Properties.Resources.AbilityList;
                List<string> AbilList = AbilString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(AbilList.ToArray());

            }
            if (Rule3 == "Ability")
            {
                string AbilString = Properties.Resources.AbilityList;
                List<string> AbilList = AbilString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(AbilList.ToArray());
            }
            if (Rule3 == "Skill")
            {
                bool RuleField4Vis = true;
                RuleBuilder4.Visible = RuleField4Vis;

                string skillsString = Properties.Resources.skillList;
                List<string> skillList = skillsString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(skillList.ToArray());

            }
            if (Rule3 == "Spell")
            {
                RuleBuilder4.Visible = true;
                RuleBuilder4.Items.Add("Attack");
                RuleBuilder4.Items.Add("Spell DC");
            }
            if (Rule3 == "Gaming Set")
            {
                string gamingString = Properties.Resources.GamingSets;
                List<string> gameList = gamingString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(gameList.ToArray());
            }
            if (Rule3 == "Weapon")
            {
                string WeaponString = Properties.Resources.WeaponProfs;
                List<string> WeaponList = WeaponString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(WeaponList.ToArray());
            }
            if (Rule3 == "Armor")
            {
                string ArmorString = Properties.Resources.ArmorProfs;
                List<string> ArmorList = ArmorString.Split(',').ToList();
                RuleBuilder4.Items.AddRange(ArmorList.ToArray());
            }
            if (Rule3 == "Tool")
            {
                RuleBuilder4.Visible = true;
                RuleBuilder4.Items.Add("Tools and Supplies");
                RuleBuilder4.Items.Add("Instruments");
            }


        }
        private void RuleBuilder4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* Rule4 = RuleBuilder4.SelectedItem?.ToString();
             richTextBox1.AppendText(RuleBuilder4.SelectedItem.ToString() + Environment.NewLine);
             richTextBox1.AppendText(Rule4 + Environment.NewLine);*/
            Rule4 = RuleBuilder4.SelectedItem?.ToString();
            string CheckRule3 = Rule3;
            RuleBuilder5.Text = "";
            RuleBuilder5.Items.Clear();
            if (Rule4 == "Tools and Supplies")
            {
                RuleBuilder5.Visible = true;
                string ToolString = Properties.Resources.Tools;
                string[] allTools = ToolString.Split(',');
                List<string> selectedTools = allTools.Skip(10).Take(25).ToList();
                RuleBuilder5.Items.AddRange(selectedTools.ToArray());
            }
            if (Rule4 == "Instruments")
            {
                RuleBuilder5.Visible = true;
                RuleBuilder5.Visible = true;
                string ToolString = Properties.Resources.Tools;
                string[] allTools = ToolString.Split(',');
                List<string> selectedTools = allTools.Take(10).ToList();
                RuleBuilder5.Items.AddRange(selectedTools.ToArray());
            }
        }
        private void RuleBuilder5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rule5 = RuleBuilder5.SelectedItem?.ToString();
            richTextBox1.AppendText(RuleBuilder5.SelectedItem.ToString() + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CheckRule1 = Rule1;
            string CheckRule2 = Rule2;
            string CheckRule3 = Rule3;
            string convRule3 = string.Empty;
            if (!string.IsNullOrEmpty(CheckRule3))
            { convRule3 = CheckRule3.ToLower(); }
            string CheckRule4 = Rule4;
            string convRule4 = string.Empty;
            if (!string.IsNullOrEmpty(CheckRule4))
            { convRule4 = CheckRule4.ToLower(); }
            string BuildStrPt1 = string.Empty;
            string BuildStrPt2 = string.Empty;
            string BuildStrPt3 = string.Empty;
            string BuildStrPt4 = string.Empty;
            string BuildStrPt5 = string.Empty;
            string FullString = string.Empty;
            if (CheckRule1 == "change stat")
            {
                BuildStrPt1 = "<stat name=";
                if (CheckRule2 == "Speed")
                {
                    if (CheckRule3 == "Base")
                    { BuildStrPt2 = "\"speed\""; }
                    else
                    {
                        BuildStrPt2 = "\"speed:" + convRule3 + "\"";
                    }
                }
                if (CheckRule2 == "Ability")
                {
                    BuildStrPt2 = "\"" + convRule4;
                    if (CheckRule3 == "set Score")
                    {
                        BuildStrPt3 = ":score:set\"";
                    }
                    if (CheckRule3 == "add to Score")
                    {
                        BuildStrPt3 = "\"";
                    }
                    if (CheckRule3 == "change max Score")
                    {
                        BuildStrPt3 = ":max\"";
                    }
                }
                if (CheckRule2 == "Vision")
                {
                    BuildStrPt2 = "\"" + convRule3 + ":range\"";
                }
                if (CheckRule2 == "Check")
                {
                    if (CheckRule3 == "Ability")
                    {
                        BuildStrPt2 = "\"" + convRule4 + ":save:misc\"";
                    }
                    if (CheckRule3 == "Skill")
                    {
                        BuildStrPt2 = "\"" + convRule4 + ":misc\"";
                    }
                    if (CheckRule3 == "Spell")
                    {
                        if (CheckRule4 == "Attack")
                        { BuildStrPt2 = "\"spellcasting:attack\""; }
                        if (CheckRule4 == "Spell DC")
                        { BuildStrPt2 = "\"spellcasting:dc\""; }
                    }
                }
                if (CheckRule2 == "Damage")
                {
                    if (CheckRule3 != "More...")
                    {
                        BuildStrPt2 = "\"" + convRule3 + ":damage\"";
                    }
                }
                if (CheckRule2 == "AC")
                {
                    BuildStrPt2 = "\"ac:misc\"";
                }
                if (CheckRule2 == "Proficiency")
                {
                    BuildStrPt2 = "\"proficiency\"";
                }
                if (CheckRule2 == "Initiative")
                {
                    BuildStrPt2 = "\"initiative\"";
                }
            }

            if (CheckRule1 == "grant something")
            {

                BuildStrPt1 = "<grant type=";

                if (CheckRule2 == "Grant Condition")
                {
                    BuildStrPt2 = " \"Condition\" " + "id=\"ID_INTERNAL_CONDITION_";
                    if (CheckRule3 == "Damage Immunity")
                    {
                        BuildStrPt3 = "DAMAGE_IMMUNITY_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Damage Resistance")
                    {
                        BuildStrPt3 = "DAMAGE_RESISTANCE_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Damage Vulnerability")
                    {
                        BuildStrPt3 = "VULNERABILITY_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                }
                if (CheckRule2 == "Grant Proficiency")
                {
                    BuildStrPt2 = " \"Proficiency\" " + "id=\"ID_PROFICIENCY_";

                    if (CheckRule3 == "Skill")
                    {
                        BuildStrPt3 = "SKILL_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Gaming Set")
                    {
                        BuildStrPt3 = "GAMING_SET_PROFICIENCY_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Weapon")
                    {
                        BuildStrPt3 = "WEAPON_PROFICIENCY_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Armor")
                    {
                        BuildStrPt3 = "ARMOR_PROFICIENCY_";
                        string formattedRule4 = Rule4.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule4 + "\"";
                    }
                    if (CheckRule3 == "Tool")
                    {
                        BuildStrPt3 = "TOOL_PROFICIENCY_";
                        string formattedRule5 = Rule5.ToUpper().Replace(' ', '_');
                        BuildStrPt4 = formattedRule5 + "\"";
                    }

                }
                if (CheckRule2 == "Grant Vision")
                {
                    string formattedRule3 = Rule3.ToUpper().Replace(' ', '_');
                    BuildStrPt2 = " \"Vision\" " + "id=\"ID_VISION_" + formattedRule3 + "\"";
                }
                if (CheckRule2 == "Grant Language")
                {
                    string formattedRule3 = Rule3.ToUpper().Replace(' ', '_');
                    BuildStrPt2 = " \"Language\" " + "id=\"ID_LANGUAGE_" + formattedRule3 + "\"";
                }

            }


            //Part4
            if (CheckRule1 == "change stat")
            {
                BuildStrPt4 = " value=\"" + RuleValue + "\"";
            }
            //Part 5
            BuildStrPt5 = " bonus=\"base\"";

            StringBuilder output = new StringBuilder();
            //output.AppendLine("<rules>");
            if (CheckRule2 == "Speed" || CheckRule2 == "Vision")
            {
                output.AppendLine(BuildStrPt1 + BuildStrPt2 + BuildStrPt3 + BuildStrPt4 + BuildStrPt5 + "/>");
                FullString = BuildStrPt1 + BuildStrPt2 + BuildStrPt3 + BuildStrPt4 + BuildStrPt5 + "/>";
            }
            else
            {
                output.AppendLine(BuildStrPt1 + BuildStrPt2 + BuildStrPt3 + BuildStrPt4 + "/>");
                FullString = BuildStrPt1 + BuildStrPt2 + BuildStrPt3 + BuildStrPt4 + "/>";
            }
            richTextBox2.Text = output.ToString();
            RulesList.Add(FullString);
            listBox1.Items.Clear();
            foreach (string rule in RulesList)
            {
                listBox1.Items.Add(rule);
            }

            //var Debugging:
            /*StringBuilder Text1 = new StringBuilder();
            Text1.AppendLine("Test");
            Text1.AppendLine(CheckRule1);
            Text1.AppendLine(CheckRule2);
            Text1.AppendLine(CheckRule3);
            Text1.AppendLine(CheckRule4);
            Text1.AppendLine(convRule3);
            Text1.AppendLine(convRule4);
            richTextBox1.Text = Text1.ToString();*/
        }



        private void RuleBuilderValue_ValueChanged(object sender, EventArgs e)
        {
            RuleValue = RuleBuilderValue.Text;
        }

        private void deleteRule_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox1.SelectedItem != null)
            {
                // Get the selected item
                string selectedItem = listBox1.SelectedItem.ToString();

                // Remove the selected item from the ListBox
                listBox1.Items.Remove(selectedItem);

                // Remove the selected item from the underlying data source
                RulesList.Remove(selectedItem);
            }
            else
            {
                // Optionally handle the case where no item is selected
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }

}
    
