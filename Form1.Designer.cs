namespace Aurora_Item_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SelectNameTI = new TextBox();
            SelectTypeCB = new ComboBox();
            SelectSourceTI = new TextBox();
            SelectAuthorTI = new TextBox();
            Field6 = new RichTextBox();
            SelectCatCB = new ComboBox();
            SelectCostNI = new NumericUpDown();
            SelectCurrencyCB = new ComboBox();
            SelectWeightNI = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            Generate = new Button();
            SelectFocusCB = new ComboBox();
            SelectSlotTL = new CheckedListBox();
            label1 = new Label();
            SelectNormalRangeNI = new NumericUpDown();
            label2 = new Label();
            SelectLongRangeNI = new NumericUpDown();
            label3 = new Label();
            SelectNumberDiceNI = new NumericUpDown();
            SelectDmgDiceCB = new ComboBox();
            SelectDmgModNI = new NumericUpDown();
            SelectDmgTypeCB = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SelectItemTypeCB = new ComboBox();
            label6 = new Label();
            SelectAttuneTL = new CheckedListBox();
            label7 = new Label();
            weight = new Label();
            label8 = new Label();
            label9 = new Label();
            SelectRarityCB = new ComboBox();
            label10 = new Label();
            SelectEnhanceCB = new ComboBox();
            label11 = new Label();
            SelectWpnTagTL = new CheckedListBox();
            label12 = new Label();
            SelectArmorTypeCB = new ComboBox();
            ImprovementCheck = new CheckBox();
            SelectImprovementTagTL = new CheckedListBox();
            label13 = new Label();
            label14 = new Label();
            SelectACModNI = new NumericUpDown();
            toolTip2 = new ToolTip(components);
            SelectACFlatNI = new NumericUpDown();
            SelectArmorAbilCB = new ComboBox();
            ArmorAbilCheck = new CheckBox();
            ACmaxModCheck = new CheckBox();
            SelectACAbilModMaxNI = new NumericUpDown();
            SelectCustomNameAddTI = new TextBox();
            NameAddCheck = new CheckBox();
            label15 = new Label();
            SelectNameAddCB = new ComboBox();
            SelectArmorStealthModCB = new ComboBox();
            StealthChangeCheck = new CheckBox();
            ChargesCheck = new CheckBox();
            SelectChargesNI = new NumericUpDown();
            Field38 = new CheckBox();
            elementText = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)SelectCostNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectWeightNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectNormalRangeNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectLongRangeNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectNumberDiceNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectDmgModNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectACModNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectACFlatNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectACAbilModMaxNI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectChargesNI).BeginInit();
            SuspendLayout();
            // 
            // SelectNameTI
            // 
            SelectNameTI.Location = new Point(21, 26);
            SelectNameTI.Name = "SelectNameTI";
            SelectNameTI.Size = new Size(175, 35);
            SelectNameTI.TabIndex = 0;
            SelectNameTI.Text = "Item Name";
            SelectNameTI.TextChanged += textBox1_TextChanged;
            // 
            // SelectTypeCB
            // 
            SelectTypeCB.Location = new Point(265, 24);
            SelectTypeCB.Name = "SelectTypeCB";
            SelectTypeCB.Size = new Size(212, 38);
            SelectTypeCB.TabIndex = 2;
            SelectTypeCB.Text = "Choose Type";
            toolTip1.SetToolTip(SelectTypeCB, "Choose what Type you want to add");
            SelectTypeCB.DrawItem += SelectTypeCB_DrawItem;
            // 
            // SelectSourceTI
            // 
            SelectSourceTI.Location = new Point(546, 26);
            SelectSourceTI.Name = "SelectSourceTI";
            SelectSourceTI.Size = new Size(175, 35);
            SelectSourceTI.TabIndex = 3;
            SelectSourceTI.Text = "Name of Source";
            // 
            // SelectAuthorTI
            // 
            SelectAuthorTI.Location = new Point(790, 26);
            SelectAuthorTI.Name = "SelectAuthorTI";
            SelectAuthorTI.Size = new Size(175, 35);
            SelectAuthorTI.TabIndex = 4;
            SelectAuthorTI.Text = "Author";
            // 
            // Field6
            // 
            Field6.Location = new Point(21, 77);
            Field6.Name = "Field6";
            Field6.Size = new Size(1367, 128);
            Field6.TabIndex = 5;
            Field6.Text = "Description";
            // 
            // SelectCatCB
            // 
            SelectCatCB.FormattingEnabled = true;
            SelectCatCB.Items.AddRange(new object[] { "Adventuring Gear", "Treasure", "Equipment Packs", "Tools", "Musical Instruments", "Armor", "Magic Armor", "Weapons", "Magic Weapons", "Ammunition", "Spellcasting Focus", "Wondrous Items", "Supernatural Gifts", "Staffs", "Rods", "Wands", "Rings", "Potions", "Poison ", "Scrolls", "Spell Scrolls", "Explosives", "Mounts & Vehicles", "Optional Class Feature", "Alchemical Formulas", "Whetstones Reagents", "Additional Feature", "Additional Language", "Additional Proficiency", "Additional Spell", "Additional Ranger Spell" });
            SelectCatCB.Location = new Point(1034, 24);
            SelectCatCB.Name = "SelectCatCB";
            SelectCatCB.Size = new Size(354, 38);
            SelectCatCB.TabIndex = 6;
            SelectCatCB.Text = "Shop Category";
            // 
            // SelectCostNI
            // 
            SelectCostNI.Location = new Point(21, 254);
            SelectCostNI.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            SelectCostNI.Name = "SelectCostNI";
            SelectCostNI.Size = new Size(210, 35);
            SelectCostNI.TabIndex = 7;
            // 
            // SelectCurrencyCB
            // 
            SelectCurrencyCB.FormattingEnabled = true;
            SelectCurrencyCB.Items.AddRange(new object[] { "PP", "GP", "EP", "SP", "CP" });
            SelectCurrencyCB.Location = new Point(237, 252);
            SelectCurrencyCB.Name = "SelectCurrencyCB";
            SelectCurrencyCB.Size = new Size(61, 38);
            SelectCurrencyCB.TabIndex = 8;
            SelectCurrencyCB.Text = "GP";
            // 
            // SelectWeightNI
            // 
            SelectWeightNI.Location = new Point(373, 254);
            SelectWeightNI.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SelectWeightNI.Name = "SelectWeightNI";
            SelectWeightNI.Size = new Size(136, 35);
            SelectWeightNI.TabIndex = 9;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Weight in lb";
            // 
            // Generate
            // 
            Generate.Location = new Point(1155, 906);
            Generate.Name = "Generate";
            Generate.Size = new Size(233, 40);
            Generate.TabIndex = 11;
            Generate.Text = "Generate Element";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += button1_Click;
            // 
            // SelectFocusCB
            // 
            SelectFocusCB.FormattingEnabled = true;
            SelectFocusCB.Items.AddRange(new object[] { "Arcane Focus", "Druidic Focus", "Holy Symbol" });
            SelectFocusCB.Location = new Point(24, 349);
            SelectFocusCB.Name = "SelectFocusCB";
            SelectFocusCB.Size = new Size(212, 38);
            SelectFocusCB.TabIndex = 12;
            SelectFocusCB.Text = "Type of Focus";
            // 
            // SelectSlotTL
            // 
            SelectSlotTL.FormattingEnabled = true;
            SelectSlotTL.Items.AddRange(new object[] { "Body", "onehand", "secondary" });
            SelectSlotTL.Location = new Point(24, 463);
            SelectSlotTL.Name = "SelectSlotTL";
            SelectSlotTL.Size = new Size(209, 100);
            SelectSlotTL.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 316);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 14;
            label1.Text = "Range";
            // 
            // SelectNormalRangeNI
            // 
            SelectNormalRangeNI.Location = new Point(521, 355);
            SelectNormalRangeNI.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            SelectNormalRangeNI.Name = "SelectNormalRangeNI";
            SelectNormalRangeNI.Size = new Size(90, 35);
            SelectNormalRangeNI.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 357);
            label2.Name = "label2";
            label2.Size = new Size(21, 30);
            label2.TabIndex = 16;
            label2.Text = "/";
            // 
            // SelectLongRangeNI
            // 
            SelectLongRangeNI.Location = new Point(676, 355);
            SelectLongRangeNI.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            SelectLongRangeNI.Name = "SelectLongRangeNI";
            SelectLongRangeNI.Size = new Size(96, 35);
            SelectLongRangeNI.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 399);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 18;
            label3.Text = "Damage";
            // 
            // SelectNumberDiceNI
            // 
            SelectNumberDiceNI.Location = new Point(521, 437);
            SelectNumberDiceNI.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            SelectNumberDiceNI.Name = "SelectNumberDiceNI";
            SelectNumberDiceNI.Size = new Size(81, 35);
            SelectNumberDiceNI.TabIndex = 19;
            // 
            // SelectDmgDiceCB
            // 
            SelectDmgDiceCB.FormattingEnabled = true;
            SelectDmgDiceCB.Items.AddRange(new object[] { "d2", "d4", "d6", "d8", "d10", "d12", "d20" });
            SelectDmgDiceCB.Location = new Point(608, 435);
            SelectDmgDiceCB.Name = "SelectDmgDiceCB";
            SelectDmgDiceCB.Size = new Size(69, 38);
            SelectDmgDiceCB.TabIndex = 20;
            // 
            // SelectDmgModNI
            // 
            SelectDmgModNI.Location = new Point(683, 436);
            SelectDmgModNI.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            SelectDmgModNI.Name = "SelectDmgModNI";
            SelectDmgModNI.Size = new Size(90, 35);
            SelectDmgModNI.TabIndex = 21;
            // 
            // SelectDmgTypeCB
            // 
            SelectDmgTypeCB.FormattingEnabled = true;
            SelectDmgTypeCB.Items.AddRange(new object[] { "Acid", "Bludgeoning", "Cold", "Fire", "Force", "Lightning", "Necrotic", "Piercing", "Poison", "Psychic", "Radiant", "Slashing", "Thunder" });
            SelectDmgTypeCB.Location = new Point(521, 525);
            SelectDmgTypeCB.Name = "SelectDmgTypeCB";
            SelectDmgTypeCB.Size = new Size(252, 38);
            SelectDmgTypeCB.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 430);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 23;
            label4.Text = "Slot";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 492);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 24;
            label5.Text = "Damage Type";
            // 
            // SelectItemTypeCB
            // 
            SelectItemTypeCB.FormattingEnabled = true;
            SelectItemTypeCB.Items.AddRange(new object[] { "Shield", "Staff", "Potion", "Scroll", "Ammunition", "Mount", "Tool" });
            SelectItemTypeCB.Location = new Point(565, 251);
            SelectItemTypeCB.Name = "SelectItemTypeCB";
            SelectItemTypeCB.Size = new Size(212, 38);
            SelectItemTypeCB.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(619, 212);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 26;
            label6.Text = "Item Type";
            // 
            // SelectAttuneTL
            // 
            SelectAttuneTL.FormattingEnabled = true;
            SelectAttuneTL.Items.AddRange(new object[] { "Artificer", "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" });
            SelectAttuneTL.Location = new Point(261, 367);
            SelectAttuneTL.Name = "SelectAttuneTL";
            SelectAttuneTL.Size = new Size(212, 196);
            SelectAttuneTL.TabIndex = 27;
            SelectAttuneTL.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 216);
            label7.Name = "label7";
            label7.Size = new Size(54, 30);
            label7.TabIndex = 28;
            label7.Text = "Cost";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(398, 216);
            weight.Name = "weight";
            weight.Size = new Size(79, 30);
            weight.TabIndex = 29;
            weight.Text = "Weight";
            weight.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 316);
            label8.Name = "label8";
            label8.Size = new Size(124, 30);
            label8.TabIndex = 30;
            label8.Text = "Attunement";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(868, 212);
            label9.Name = "label9";
            label9.Size = new Size(66, 30);
            label9.TabIndex = 31;
            label9.Text = "Rarity";
            // 
            // SelectRarityCB
            // 
            SelectRarityCB.FormattingEnabled = true;
            SelectRarityCB.Items.AddRange(new object[] { "Common", "Uncommon", "Rare", "Very Rare", "Epic", "Legendary", "Mythic" });
            SelectRarityCB.Location = new Point(804, 251);
            SelectRarityCB.Name = "SelectRarityCB";
            SelectRarityCB.Size = new Size(212, 38);
            SelectRarityCB.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1048, 212);
            label10.Name = "label10";
            label10.Size = new Size(149, 30);
            label10.TabIndex = 33;
            label10.Text = "Enhancements";
            // 
            // SelectEnhanceCB
            // 
            SelectEnhanceCB.FormattingEnabled = true;
            SelectEnhanceCB.Items.AddRange(new object[] { "+1", "+2", "+3" });
            SelectEnhanceCB.Location = new Point(1085, 254);
            SelectEnhanceCB.Name = "SelectEnhanceCB";
            SelectEnhanceCB.Size = new Size(66, 38);
            SelectEnhanceCB.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1034, 316);
            label11.Name = "label11";
            label11.Size = new Size(137, 30);
            label11.TabIndex = 35;
            label11.Text = "Weapon Tags";
            // 
            // SelectWpnTagTL
            // 
            SelectWpnTagTL.FormattingEnabled = true;
            SelectWpnTagTL.Items.AddRange(new object[] { "Quarterstaff", "ID_INTERNAL_WEAPON_CATEGORY_SIMPLE_MELEE", "ID_INTERNAL_WEAPON_CATEGORY_SIMPLE_RANGED" });
            SelectWpnTagTL.Location = new Point(820, 367);
            SelectWpnTagTL.Name = "SelectWpnTagTL";
            SelectWpnTagTL.Size = new Size(568, 196);
            SelectWpnTagTL.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(227, 610);
            label12.Name = "label12";
            label12.Size = new Size(120, 30);
            label12.TabIndex = 39;
            label12.Text = "Armor Type";
            // 
            // SelectArmorTypeCB
            // 
            SelectArmorTypeCB.FormattingEnabled = true;
            SelectArmorTypeCB.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "Shield" });
            SelectArmorTypeCB.Location = new Point(21, 643);
            SelectArmorTypeCB.Name = "SelectArmorTypeCB";
            SelectArmorTypeCB.Size = new Size(516, 38);
            SelectArmorTypeCB.TabIndex = 40;
            // 
            // ImprovementCheck
            // 
            ImprovementCheck.AutoSize = true;
            ImprovementCheck.Location = new Point(198, 701);
            ImprovementCheck.Name = "ImprovementCheck";
            ImprovementCheck.Size = new Size(172, 34);
            ImprovementCheck.TabIndex = 42;
            ImprovementCheck.Text = "Improvement?";
            ImprovementCheck.UseVisualStyleBackColor = true;
            ImprovementCheck.CheckedChanged += AddImprovement_CheckedChanged;
            // 
            // SelectImprovementTagTL
            // 
            SelectImprovementTagTL.FormattingEnabled = true;
            SelectImprovementTagTL.Items.AddRange(new object[] { "ID_INTERNAL_ARMOR_GROUP_LIGHT", "ID_INTERNAL_ARMOR_GROUP_MEDIUM", "ID_INTERNAL_ARMOR_GROUP_HEAVY" });
            SelectImprovementTagTL.Location = new Point(21, 741);
            SelectImprovementTagTL.Name = "SelectImprovementTagTL";
            SelectImprovementTagTL.Size = new Size(516, 132);
            SelectImprovementTagTL.TabIndex = 43;
            SelectImprovementTagTL.Visible = false;
            SelectImprovementTagTL.SelectedIndexChanged += Field27_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(735, 600);
            label13.Name = "label13";
            label13.Size = new Size(124, 30);
            label13.TabIndex = 44;
            label13.Text = "Armor Class";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(694, 644);
            label14.Name = "label14";
            label14.Size = new Size(27, 30);
            label14.TabIndex = 45;
            label14.Text = "+";
            // 
            // SelectACModNI
            // 
            SelectACModNI.Location = new Point(727, 642);
            SelectACModNI.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            SelectACModNI.Name = "SelectACModNI";
            SelectACModNI.Size = new Size(57, 35);
            SelectACModNI.TabIndex = 46;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "For adding improvements on pre-exisiting armor like Shield+1";
            toolTip2.Popup += toolTip2_Popup;
            // 
            // SelectACFlatNI
            // 
            SelectACFlatNI.Location = new Point(824, 643);
            SelectACFlatNI.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            SelectACFlatNI.Name = "SelectACFlatNI";
            SelectACFlatNI.Size = new Size(69, 35);
            SelectACFlatNI.TabIndex = 47;
            SelectACFlatNI.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // SelectArmorAbilCB
            // 
            SelectArmorAbilCB.FormattingEnabled = true;
            SelectArmorAbilCB.Items.AddRange(new object[] { "Dexterity", "Strength" });
            SelectArmorAbilCB.Location = new Point(676, 759);
            SelectArmorAbilCB.Name = "SelectArmorAbilCB";
            SelectArmorAbilCB.Size = new Size(238, 38);
            SelectArmorAbilCB.TabIndex = 48;
            // 
            // ArmorAbilCheck
            // 
            ArmorAbilCheck.AutoSize = true;
            ArmorAbilCheck.Location = new Point(676, 719);
            ArmorAbilCheck.Name = "ArmorAbilCheck";
            ArmorAbilCheck.Size = new Size(257, 34);
            ArmorAbilCheck.TabIndex = 49;
            ArmorAbilCheck.Text = "Ability Modifier on top?";
            ArmorAbilCheck.UseVisualStyleBackColor = true;
            // 
            // ACmaxModCheck
            // 
            ACmaxModCheck.AutoSize = true;
            ACmaxModCheck.Location = new Point(676, 839);
            ACmaxModCheck.Name = "ACmaxModCheck";
            ACmaxModCheck.Size = new Size(176, 34);
            ACmaxModCheck.TabIndex = 50;
            ACmaxModCheck.Text = "max. Modifier?";
            ACmaxModCheck.UseVisualStyleBackColor = true;
            // 
            // SelectACAbilModMaxNI
            // 
            SelectACAbilModMaxNI.Location = new Point(850, 839);
            SelectACAbilModMaxNI.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            SelectACAbilModMaxNI.Name = "SelectACAbilModMaxNI";
            SelectACAbilModMaxNI.Size = new Size(64, 35);
            SelectACAbilModMaxNI.TabIndex = 51;
            // 
            // SelectCustomNameAddTI
            // 
            SelectCustomNameAddTI.Location = new Point(1187, 668);
            SelectCustomNameAddTI.Name = "SelectCustomNameAddTI";
            SelectCustomNameAddTI.Size = new Size(175, 35);
            SelectCustomNameAddTI.TabIndex = 52;
            SelectCustomNameAddTI.Text = "own Name";
            // 
            // NameAddCheck
            // 
            NameAddCheck.AutoSize = true;
            NameAddCheck.Location = new Point(1044, 596);
            NameAddCheck.Name = "NameAddCheck";
            NameAddCheck.Size = new Size(260, 34);
            NameAddCheck.TabIndex = 53;
            NameAddCheck.Text = "Check if Name Addition";
            NameAddCheck.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1044, 689);
            label15.Name = "label15";
            label15.Size = new Size(123, 30);
            label15.TabIndex = 54;
            label15.Text = "{{parent}} + ";
            // 
            // SelectNameAddCB
            // 
            SelectNameAddCB.FormattingEnabled = true;
            SelectNameAddCB.Items.AddRange(new object[] { "{{enhancement}}" });
            SelectNameAddCB.Location = new Point(1187, 709);
            SelectNameAddCB.Name = "SelectNameAddCB";
            SelectNameAddCB.Size = new Size(201, 38);
            SelectNameAddCB.TabIndex = 55;
            // 
            // SelectArmorStealthModCB
            // 
            SelectArmorStealthModCB.FormattingEnabled = true;
            SelectArmorStealthModCB.Items.AddRange(new object[] { "Advantage", "Disadvantage" });
            SelectArmorStealthModCB.Location = new Point(1044, 835);
            SelectArmorStealthModCB.Name = "SelectArmorStealthModCB";
            SelectArmorStealthModCB.Size = new Size(344, 38);
            SelectArmorStealthModCB.TabIndex = 56;
            // 
            // StealthChangeCheck
            // 
            StealthChangeCheck.AutoSize = true;
            StealthChangeCheck.Location = new Point(1044, 790);
            StealthChangeCheck.Name = "StealthChangeCheck";
            StealthChangeCheck.Size = new Size(182, 34);
            StealthChangeCheck.TabIndex = 57;
            StealthChangeCheck.Text = "Affects Stealth?";
            StealthChangeCheck.UseVisualStyleBackColor = true;
            // 
            // ChargesCheck
            // 
            ChargesCheck.AutoSize = true;
            ChargesCheck.Location = new Point(21, 912);
            ChargesCheck.Name = "ChargesCheck";
            ChargesCheck.Size = new Size(257, 34);
            ChargesCheck.TabIndex = 58;
            ChargesCheck.Text = "check if limited charges";
            ChargesCheck.UseVisualStyleBackColor = true;
            // 
            // SelectChargesNI
            // 
            SelectChargesNI.Location = new Point(284, 911);
            SelectChargesNI.Name = "SelectChargesNI";
            SelectChargesNI.Size = new Size(71, 35);
            SelectChargesNI.TabIndex = 59;
            // 
            // Field38
            // 
            Field38.AutoSize = true;
            Field38.Location = new Point(407, 912);
            Field38.Name = "Field38";
            Field38.Size = new Size(182, 34);
            Field38.TabIndex = 60;
            Field38.Text = "stackable Item?";
            Field38.UseVisualStyleBackColor = true;
            // 
            // elementText
            // 
            elementText.Location = new Point(1404, 24);
            elementText.Name = "elementText";
            elementText.Size = new Size(445, 929);
            elementText.TabIndex = 61;
            elementText.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(986, 900);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 62;
            button1.Text = "open form2 DEBUG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 965);
            Controls.Add(button1);
            Controls.Add(elementText);
            Controls.Add(Field38);
            Controls.Add(SelectChargesNI);
            Controls.Add(ChargesCheck);
            Controls.Add(StealthChangeCheck);
            Controls.Add(SelectArmorStealthModCB);
            Controls.Add(SelectNameAddCB);
            Controls.Add(label15);
            Controls.Add(NameAddCheck);
            Controls.Add(SelectCustomNameAddTI);
            Controls.Add(SelectACAbilModMaxNI);
            Controls.Add(ACmaxModCheck);
            Controls.Add(ArmorAbilCheck);
            Controls.Add(SelectArmorAbilCB);
            Controls.Add(SelectACFlatNI);
            Controls.Add(SelectACModNI);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(SelectImprovementTagTL);
            Controls.Add(ImprovementCheck);
            Controls.Add(SelectArmorTypeCB);
            Controls.Add(label12);
            Controls.Add(SelectWpnTagTL);
            Controls.Add(label11);
            Controls.Add(SelectEnhanceCB);
            Controls.Add(label10);
            Controls.Add(SelectRarityCB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(weight);
            Controls.Add(label7);
            Controls.Add(SelectAttuneTL);
            Controls.Add(label6);
            Controls.Add(SelectItemTypeCB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SelectDmgTypeCB);
            Controls.Add(SelectDmgModNI);
            Controls.Add(SelectDmgDiceCB);
            Controls.Add(SelectNumberDiceNI);
            Controls.Add(label3);
            Controls.Add(SelectLongRangeNI);
            Controls.Add(label2);
            Controls.Add(SelectNormalRangeNI);
            Controls.Add(label1);
            Controls.Add(SelectSlotTL);
            Controls.Add(SelectFocusCB);
            Controls.Add(Generate);
            Controls.Add(SelectWeightNI);
            Controls.Add(SelectCurrencyCB);
            Controls.Add(SelectCostNI);
            Controls.Add(SelectCatCB);
            Controls.Add(Field6);
            Controls.Add(SelectAuthorTI);
            Controls.Add(SelectSourceTI);
            Controls.Add(SelectTypeCB);
            Controls.Add(SelectNameTI);
            Name = "Form1";
            Text = "Aurora Item Builder";
            ((System.ComponentModel.ISupportInitialize)SelectCostNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectWeightNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectNormalRangeNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectLongRangeNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectNumberDiceNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectDmgModNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectACModNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectACFlatNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectACAbilModMaxNI).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectChargesNI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SelectNameTI;
        private ComboBox SelectTypeCB;
        private TextBox SelectSourceTI;
        private TextBox SelectAuthorTI;
        private RichTextBox Field6;
        private ComboBox SelectCatCB;
        private NumericUpDown SelectCostNI;
        private ComboBox SelectCurrencyCB;
        private NumericUpDown SelectWeightNI;
        private ToolTip toolTip1;
        private Button Generate;
        private ComboBox SelectFocusCB;
        private CheckedListBox SelectSlotTL;
        private Label label1;
        private NumericUpDown SelectNormalRangeNI;
        private Label label2;
        private NumericUpDown SelectLongRangeNI;
        private Label label3;
        private NumericUpDown SelectNumberDiceNI;
        private ComboBox SelectDmgDiceCB;
        private NumericUpDown SelectDmgModNI;
        private ComboBox SelectDmgTypeCB;
        private Label label4;
        private Label label5;
        private ComboBox SelectItemTypeCB;
        private Label label6;
        private CheckedListBox SelectAttuneTL;
        private Label label7;
        private Label weight;
        private Label label8;
        private Label label9;
        private ComboBox SelectRarityCB;
        private Label label10;
        private ComboBox SelectEnhanceCB;
        private Label label11;
        private CheckedListBox SelectWpnTagTL;
        private Label label12;
        private ComboBox SelectArmorTypeCB;
        private CheckBox ImprovementCheck;
        private CheckedListBox SelectImprovementTagTL;
        private Label label13;
        private Label label14;
        private NumericUpDown SelectACModNI;
        private ToolTip toolTip2;
        private NumericUpDown SelectACFlatNI;
        private ComboBox SelectArmorAbilCB;
        private CheckBox ArmorAbilCheck;
        private CheckBox ACmaxModCheck;
        private NumericUpDown SelectACAbilModMaxNI;
        private TextBox SelectCustomNameAddTI;
        private CheckBox NameAddCheck;
        private Label label15;
        private ComboBox SelectNameAddCB;
        private ComboBox SelectArmorStealthModCB;
        private CheckBox StealthChangeCheck;
        private CheckBox ChargesCheck;
        private NumericUpDown SelectChargesNI;
        private CheckBox Field38;
        private RichTextBox elementText;
        private Button button1;
    }
}
