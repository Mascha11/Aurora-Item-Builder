namespace Aurora_Item_Builder
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Base Speed");
            TreeNode treeNode2 = new TreeNode("Swim Speed");
            TreeNode treeNode3 = new TreeNode("Climb Speed");
            TreeNode treeNode4 = new TreeNode("Fly Speed");
            TreeNode treeNode5 = new TreeNode("Change (a) Speed", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Strength");
            TreeNode treeNode7 = new TreeNode("Dexterity");
            TreeNode treeNode8 = new TreeNode("Constitution");
            TreeNode treeNode9 = new TreeNode("Intelligence");
            TreeNode treeNode10 = new TreeNode("Wisdom");
            TreeNode treeNode11 = new TreeNode("Charisma");
            TreeNode treeNode12 = new TreeNode("set specific Score", new TreeNode[] { treeNode6, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("Strength");
            TreeNode treeNode14 = new TreeNode("Dexterity");
            TreeNode treeNode15 = new TreeNode("Constitution");
            TreeNode treeNode16 = new TreeNode("Intelligence");
            TreeNode treeNode17 = new TreeNode("Wisdom");
            TreeNode treeNode18 = new TreeNode("Charisma");
            TreeNode treeNode19 = new TreeNode("add to specific Score", new TreeNode[] { treeNode13, treeNode14, treeNode15, treeNode16, treeNode17, treeNode18 });
            TreeNode treeNode20 = new TreeNode("Strength");
            TreeNode treeNode21 = new TreeNode("Dexterity");
            TreeNode treeNode22 = new TreeNode("Constitution");
            TreeNode treeNode23 = new TreeNode("Intelligence");
            TreeNode treeNode24 = new TreeNode("Wisdom");
            TreeNode treeNode25 = new TreeNode("Charisma");
            TreeNode treeNode26 = new TreeNode("change Score Max", new TreeNode[] { treeNode20, treeNode21, treeNode22, treeNode23, treeNode24, treeNode25 });
            TreeNode treeNode27 = new TreeNode("change an Ability", new TreeNode[] { treeNode12, treeNode19, treeNode26 });
            TreeNode treeNode28 = new TreeNode("Darkvision");
            TreeNode treeNode29 = new TreeNode("Blindsight");
            TreeNode treeNode30 = new TreeNode("Truesight");
            TreeNode treeNode31 = new TreeNode("Tremorsense");
            TreeNode treeNode32 = new TreeNode("Mindsight");
            TreeNode treeNode33 = new TreeNode("change a vision Range", new TreeNode[] { treeNode28, treeNode29, treeNode30, treeNode31, treeNode32 });
            TreeNode treeNode34 = new TreeNode("Knoten1");
            TreeNode treeNode35 = new TreeNode("change a skill", new TreeNode[] { treeNode34 });
            TreeNode treeNode36 = new TreeNode("Skill Save");
            TreeNode treeNode37 = new TreeNode("Ability");
            TreeNode treeNode38 = new TreeNode("Attack");
            TreeNode treeNode39 = new TreeNode("Spell DC");
            TreeNode treeNode40 = new TreeNode("Spell", new TreeNode[] { treeNode38, treeNode39 });
            TreeNode treeNode41 = new TreeNode("change a save", new TreeNode[] { treeNode36, treeNode37, treeNode40 });
            TreeNode treeNode42 = new TreeNode("change the Damage");
            TreeNode treeNode43 = new TreeNode("change an AC");
            TreeNode treeNode44 = new TreeNode("change a Proficiency");
            TreeNode treeNode45 = new TreeNode("change Initiative");
            TreeNode treeNode46 = new TreeNode("Modify a Stat", new TreeNode[] { treeNode5, treeNode27, treeNode33, treeNode35, treeNode41, treeNode42, treeNode43, treeNode44, treeNode45 });
            TreeNode treeNode47 = new TreeNode("Modify a Grant");
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(26, 28);
            treeView1.Name = "treeView1";
            treeNode1.Name = "modSpeedBase";
            treeNode1.Text = "Base Speed";
            treeNode2.Name = "modSpeedSwim";
            treeNode2.Text = "Swim Speed";
            treeNode3.Name = "modSpeedClimb";
            treeNode3.Text = "Climb Speed";
            treeNode4.Name = "modSpeedFly";
            treeNode4.Text = "Fly Speed";
            treeNode5.Name = "modSpeed";
            treeNode5.Text = "Change (a) Speed";
            treeNode6.Name = "modAbilSetStrength";
            treeNode6.Text = "Strength";
            treeNode7.Name = "modAbilSetDexterity";
            treeNode7.Text = "Dexterity";
            treeNode8.Name = "modAbilSetConstitution";
            treeNode8.Text = "Constitution";
            treeNode9.Name = "modAbilSetIntelligence";
            treeNode9.Text = "Intelligence";
            treeNode10.Name = "modAbilSetWisdom";
            treeNode10.Text = "Wisdom";
            treeNode11.Name = "modAbilSetCharisma";
            treeNode11.Text = "Charisma";
            treeNode12.Name = "modAbilSet";
            treeNode12.Text = "set specific Score";
            treeNode13.Name = "modAbilAddStrength";
            treeNode13.Text = "Strength";
            treeNode14.Name = "modAbilAddDexterity";
            treeNode14.Text = "Dexterity";
            treeNode15.Name = "modAbilAddConstitution";
            treeNode15.Text = "Constitution";
            treeNode16.Name = "modAbilAddIntelligence";
            treeNode16.Text = "Intelligence";
            treeNode17.Name = "modAbilAddWisdom";
            treeNode17.Text = "Wisdom";
            treeNode18.Name = "modAbilAddCharisma";
            treeNode18.Text = "Charisma";
            treeNode19.Name = "modAbilAdd";
            treeNode19.Text = "add to specific Score";
            treeNode20.Name = "modAbilMaxStrength";
            treeNode20.Text = "Strength";
            treeNode21.Name = "modAbilMaxDexterity";
            treeNode21.Text = "Dexterity";
            treeNode22.Name = "modAbilMaxConstitution";
            treeNode22.Text = "Constitution";
            treeNode23.Name = "modAbilMaxIntelligence";
            treeNode23.Text = "Intelligence";
            treeNode24.Name = "modAbilMaxWisdom";
            treeNode24.Text = "Wisdom";
            treeNode25.Name = "modAbilMaxCharisma";
            treeNode25.Text = "Charisma";
            treeNode26.Name = "modAbilMax";
            treeNode26.Text = "change Score Max";
            treeNode27.Name = "modAbil";
            treeNode27.Text = "change an Ability";
            treeNode28.Name = "modVisionDark";
            treeNode28.Text = "Darkvision";
            treeNode29.Name = "modVisionBlind";
            treeNode29.Text = "Blindsight";
            treeNode30.Name = "modVisionTrue";
            treeNode30.Text = "Truesight";
            treeNode31.Name = "modVisionTremor";
            treeNode31.Text = "Tremorsense";
            treeNode32.Name = "modVisionMind";
            treeNode32.Text = "Mindsight";
            treeNode33.Name = "modVision";
            treeNode33.Text = "change a vision Range";
            treeNode34.Name = "Knoten1";
            treeNode34.Text = "Knoten1";
            treeNode35.Name = "modSkill";
            treeNode35.Text = "change a skill";
            treeNode36.Name = "modSaveSkill";
            treeNode36.Text = "Skill Save";
            treeNode37.Name = "modSaveAbil";
            treeNode37.Text = "Ability";
            treeNode38.Name = "modSaveSpellAttack";
            treeNode38.Text = "Attack";
            treeNode39.Name = "modSaveSpellDC";
            treeNode39.Text = "Spell DC";
            treeNode40.Name = "modSaveSpell";
            treeNode40.Text = "Spell";
            treeNode41.Name = "modSave";
            treeNode41.Text = "change a save";
            treeNode42.Name = "modDamage";
            treeNode42.Text = "change the Damage";
            treeNode43.Name = "modAC";
            treeNode43.Text = "change an AC";
            treeNode44.Name = "modProficiency";
            treeNode44.Text = "change a Proficiency";
            treeNode45.Name = "modIni";
            treeNode45.Text = "change Initiative";
            treeNode46.Name = "stat";
            treeNode46.Text = "Modify a Stat";
            treeNode47.Name = "grant";
            treeNode47.Text = "Modify a Grant";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode46, treeNode47 });
            treeView1.Size = new Size(212, 170);
            treeView1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}