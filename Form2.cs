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
        public Form2()
        {
            InitializeComponent();

        }

        private void RuleBuilder1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rule1 = RuleBuilder1.SelectedItem?.ToString();
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
            Rule2 = RuleBuilder2.SelectedItem?.ToString();
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

            Rule3 = RuleBuilder3.SelectedItem?.ToString();
            string CheckRule2 = Rule2;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CheckRule1 = Rule1;
            string CheckRule2 = Rule2;
            string CheckRule3 = Rule3;
            string convRule3 = Rule3.ToLower();
            string CheckRule4 = Rule4;
            string convRule4 = Rule4.ToLower();
            string BuildStrPt1 = string.Empty;
            string BuildStrPt2 = string.Empty;
            string BuildStrPt3 = string.Empty;
            if (CheckRule1 == "change stat")
            {
                BuildStrPt1 = "<stat name=";
                if (CheckRule2 == "Speed")
                {
                    BuildStrPt2 = "\"speed";
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
                        if (CheckRule3 == "change Max Score")
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
                        BuildStrPt2 = "\"" + convRule4 + ":misc";
                    }
                }
            }
            if (CheckRule1 == "grant something") { BuildStrPt1 = "<grant type="; }

            StringBuilder output = new StringBuilder();
            //output.AppendLine("<rules>");
            output.AppendLine(BuildStrPt1);

            richTextBox2.Text = output.ToString();
        }

        private void RuleBuilder4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Rule4 = RuleBuilder4.SelectedItem?.ToString();
        }
    }
}
