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

namespace Aurora_Item_Builder
{
    public partial class Form2 : Form

    {
        public string skillList = "skills.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void RuleBuilder1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Rule1 = RuleBuilder1.SelectedItem?.ToString();
            RuleBuilder1.Text = Rule1;
            RuleBuilder2.Items.Clear();
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
            }
        }

        private void RuleBuilder2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Rule2 = RuleBuilder2.SelectedItem?.ToString();
            RuleBuilder3.Text = "";
            RuleBuilder3.Items.Clear();
            if (Rule2 == "Speed")
            {
                RuleBuilder3.Items.Add("Base");
                RuleBuilder3.Items.Add("Swim");
                RuleBuilder3.Items.Add("Climb");
                RuleBuilder3.Items.Add("Fly");
            }
            if (Rule2 == "Ability")
            {
                RuleBuilder3.Items.Add("set Score");
                RuleBuilder3.Items.Add("add to Score");
                RuleBuilder3.Items.Add("change max Score");
            }
            if (Rule2 == "Vision")
            {
                RuleBuilder3.Items.Add("Darkvision");
                RuleBuilder3.Items.Add("Blindsight");
                RuleBuilder3.Items.Add("Truesight");
                RuleBuilder3.Items.Add("Tremorsense");
                RuleBuilder3.Items.Add("Mindsight");
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
        }

        private void RuleBuilder3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                string Rule3 = RuleBuilder3.SelectedItem?.ToString();
                string Rule2 = RuleBuilder2.SelectedItem?.ToString();
                RuleBuilder4.Text = "";
                RuleBuilder4.Items.Clear();
            if (RuleBuilder3.SelectedItem != null)
            {
                richTextBox1.AppendText(RuleBuilder3.SelectedItem.ToString() + Environment.NewLine);
            }

            if (Rule3 == "set Score" || Rule3 == "add to Score" || Rule3 == "change max Score")
                {
                    bool RuleField4Vis = true;
                    RuleBuilder4.Visible = RuleField4Vis;

                    RuleBuilder4.Items.Add("Strength");
                    RuleBuilder4.Items.Add("Dexterity");
                    RuleBuilder4.Items.Add("Constitution");
                    RuleBuilder4.Items.Add("Intelligence");
                    RuleBuilder4.Items.Add("Wisdom");
                    RuleBuilder4.Items.Add("Charisma");
                }
                if (Rule3 == "Ability")
                {
                    RuleBuilder4.Visible = true;
                    RuleBuilder4.Items.Add("Strength");
                    RuleBuilder4.Items.Add("Dexterity");
                    RuleBuilder4.Items.Add("Constitution");
                    RuleBuilder4.Items.Add("Intelligence");
                    RuleBuilder4.Items.Add("Wisdom");
                    RuleBuilder4.Items.Add("Charisma");
                }
                if (Rule3 == "Skill")
                {
                    bool RuleField4Vis = true;
                    RuleBuilder4.Visible = RuleField4Vis;
               
                // Get the skills list from the resources
                string skillsString = Properties.Resources.skillList;
                List<string> skillList = skillsString.Split(',').ToList();

                // Populate the ComboBox with the skills list
                RuleBuilder4.Items.AddRange(skillList.ToArray());

                /*RuleBuilder4.Items.Add("Acrobatics");
                RuleBuilder4.Items.Add("Animal Handling");
                RuleBuilder4.Items.Add("Arcana");
                RuleBuilder4.Items.Add("Athletics");
                RuleBuilder4.Items.Add("Deception");
                RuleBuilder4.Items.Add("History");
                RuleBuilder4.Items.Add("Insight");
                RuleBuilder4.Items.Add("Intimidation");
                RuleBuilder4.Items.Add("Investigation");
                RuleBuilder4.Items.Add("Medicine");
                RuleBuilder4.Items.Add("Nature");
                RuleBuilder4.Items.Add("Perception");
                RuleBuilder4.Items.Add("Performance");
                RuleBuilder4.Items.Add("Persuasion");
                RuleBuilder4.Items.Add("Religion");
                RuleBuilder4.Items.Add("Sleight of Hand");
                RuleBuilder4.Items.Add("Stealth");
                RuleBuilder4.Items.Add("Survival");*/
            }
            if (Rule3 == "Spell")
                {
                    RuleBuilder4.Visible = true;
                    RuleBuilder4.Items.Add("Attack");
                    RuleBuilder4.Items.Add("Spell DC");
                }
               /* else
                {
                    bool RuleField4Vis = false;
                    RuleBuilder4.Visible = RuleField4Vis;
                }*/
            
        }
    }
}
