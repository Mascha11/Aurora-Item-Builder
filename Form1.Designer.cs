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
            Field1 = new TextBox();
            Field2 = new ComboBox();
            Field3 = new TextBox();
            Field4 = new TextBox();
            Field6 = new RichTextBox();
            Field8 = new ComboBox();
            Field9 = new NumericUpDown();
            Field10 = new ComboBox();
            Field11 = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            Field12 = new ComboBox();
            Field13 = new CheckedListBox();
            label1 = new Label();
            Field14 = new NumericUpDown();
            label2 = new Label();
            Field15 = new NumericUpDown();
            label3 = new Label();
            Field16 = new NumericUpDown();
            Field17 = new ComboBox();
            Field18 = new NumericUpDown();
            Field19 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Field20 = new ComboBox();
            label6 = new Label();
            Field21 = new CheckedListBox();
            label7 = new Label();
            weight = new Label();
            label8 = new Label();
            label9 = new Label();
            Field22 = new ComboBox();
            label10 = new Label();
            Field23 = new ComboBox();
            label11 = new Label();
            Field25 = new CheckedListBox();
            label12 = new Label();
            Field26 = new ComboBox();
            AddImprovement = new CheckBox();
            Field27 = new CheckedListBox();
            label13 = new Label();
            label14 = new Label();
            numericUpDown1 = new NumericUpDown();
            toolTip2 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)Field9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Field1
            // 
            Field1.Location = new Point(21, 26);
            Field1.Name = "Field1";
            Field1.Size = new Size(175, 35);
            Field1.TabIndex = 0;
            Field1.Text = "Item Name";
            Field1.TextChanged += textBox1_TextChanged;
            // 
            // Field2
            // 
            Field2.FormattingEnabled = true;
            Field2.Items.AddRange(new object[] { "Magic Item", "Weapon", "Weapon Property", "Item" });
            Field2.Location = new Point(265, 24);
            Field2.Name = "Field2";
            Field2.Size = new Size(212, 38);
            Field2.TabIndex = 2;
            Field2.Text = "Choose Type";
            // 
            // Field3
            // 
            Field3.Location = new Point(546, 26);
            Field3.Name = "Field3";
            Field3.Size = new Size(175, 35);
            Field3.TabIndex = 3;
            Field3.Text = "Name of Source";
            // 
            // Field4
            // 
            Field4.Location = new Point(790, 26);
            Field4.Name = "Field4";
            Field4.Size = new Size(175, 35);
            Field4.TabIndex = 4;
            Field4.Text = "Author";
            // 
            // Field6
            // 
            Field6.Location = new Point(21, 77);
            Field6.Name = "Field6";
            Field6.Size = new Size(1367, 128);
            Field6.TabIndex = 5;
            Field6.Text = "Description";
            // 
            // Field8
            // 
            Field8.FormattingEnabled = true;
            Field8.Items.AddRange(new object[] { "Adventuring Gear", "Treasure", "Equipment Packs", "Tools", "Musical Instruments", "Armor", "Magic Armor", "Weapons", "Magic Weapons", "Ammunition", "Spellcasting Focus", "Wondrous Items", "Supernatural Gifts", "Staffs", "Rods", "Wands", "Rings", "Potions", "Poison ", "Scrolls", "Spell Scrolls", "Explosives", "Mounts & Vehicles", "Optional Class Feature", "Alchemical Formulas", "Whetstones Reagents", "Additional Feature", "Additional Language", "Additional Proficiency", "Additional Spell", "Additional Ranger Spell" });
            Field8.Location = new Point(1034, 24);
            Field8.Name = "Field8";
            Field8.Size = new Size(354, 38);
            Field8.TabIndex = 6;
            Field8.Text = "Shop Category";
            // 
            // Field9
            // 
            Field9.Location = new Point(21, 254);
            Field9.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Field9.Name = "Field9";
            Field9.Size = new Size(210, 35);
            Field9.TabIndex = 7;
            // 
            // Field10
            // 
            Field10.FormattingEnabled = true;
            Field10.Items.AddRange(new object[] { "PP", "GP", "EP", "SP", "CP" });
            Field10.Location = new Point(237, 252);
            Field10.Name = "Field10";
            Field10.Size = new Size(61, 38);
            Field10.TabIndex = 8;
            Field10.Text = "GP";
            // 
            // Field11
            // 
            Field11.Location = new Point(373, 254);
            Field11.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Field11.Name = "Field11";
            Field11.Size = new Size(136, 35);
            Field11.TabIndex = 9;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Weight in lb";
            // 
            // button1
            // 
            button1.Location = new Point(1155, 750);
            button1.Name = "button1";
            button1.Size = new Size(233, 40);
            button1.TabIndex = 11;
            button1.Text = "Generate Element";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Field12
            // 
            Field12.FormattingEnabled = true;
            Field12.Items.AddRange(new object[] { "Arcane Focus", "Druidic Focus", "Holy Symbol" });
            Field12.Location = new Point(328, 349);
            Field12.Name = "Field12";
            Field12.Size = new Size(212, 38);
            Field12.TabIndex = 12;
            Field12.Text = "Type of Focus";
            // 
            // Field13
            // 
            Field13.FormattingEnabled = true;
            Field13.Items.AddRange(new object[] { "Body", "onehand", "secondary" });
            Field13.Location = new Point(328, 463);
            Field13.Name = "Field13";
            Field13.Size = new Size(209, 100);
            Field13.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 316);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 14;
            label1.Text = "Range";
            // 
            // Field14
            // 
            Field14.Location = new Point(21, 355);
            Field14.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Field14.Name = "Field14";
            Field14.Size = new Size(90, 35);
            Field14.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 357);
            label2.Name = "label2";
            label2.Size = new Size(21, 30);
            label2.TabIndex = 16;
            label2.Text = "/";
            // 
            // Field15
            // 
            Field15.Location = new Point(176, 355);
            Field15.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Field15.Name = "Field15";
            Field15.Size = new Size(96, 35);
            Field15.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 399);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 18;
            label3.Text = "Damage";
            // 
            // Field16
            // 
            Field16.Location = new Point(21, 437);
            Field16.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Field16.Name = "Field16";
            Field16.Size = new Size(81, 35);
            Field16.TabIndex = 19;
            // 
            // Field17
            // 
            Field17.FormattingEnabled = true;
            Field17.Items.AddRange(new object[] { "d2", "d4", "d6", "d8", "d10", "d12", "d20" });
            Field17.Location = new Point(108, 435);
            Field17.Name = "Field17";
            Field17.Size = new Size(69, 38);
            Field17.TabIndex = 20;
            // 
            // Field18
            // 
            Field18.Location = new Point(183, 436);
            Field18.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Field18.Name = "Field18";
            Field18.Size = new Size(90, 35);
            Field18.TabIndex = 21;
            // 
            // Field19
            // 
            Field19.FormattingEnabled = true;
            Field19.Items.AddRange(new object[] { "Acid", "Bludgeoning", "Cold", "Fire", "Force", "Lightning", "Necrotic", "Piercing", "Poison", "Psychic", "Radiant", "Slashing", "Thunder" });
            Field19.Location = new Point(21, 525);
            Field19.Name = "Field19";
            Field19.Size = new Size(252, 38);
            Field19.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 430);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 23;
            label4.Text = "Slot";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 492);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 24;
            label5.Text = "Damage Type";
            // 
            // Field20
            // 
            Field20.FormattingEnabled = true;
            Field20.Items.AddRange(new object[] { "Shield", "Staff", "Potion", "Scroll", "Ammunition", "Mount", "Tool" });
            Field20.Location = new Point(565, 251);
            Field20.Name = "Field20";
            Field20.Size = new Size(212, 38);
            Field20.TabIndex = 25;
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
            // Field21
            // 
            Field21.FormattingEnabled = true;
            Field21.Items.AddRange(new object[] { "Artificer", "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" });
            Field21.Location = new Point(565, 367);
            Field21.Name = "Field21";
            Field21.Size = new Size(212, 196);
            Field21.TabIndex = 27;
            Field21.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
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
            label8.Location = new Point(599, 316);
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
            // Field22
            // 
            Field22.FormattingEnabled = true;
            Field22.Items.AddRange(new object[] { "Common", "Uncommon", "Rare", "Very Rare", "Epic", "Legendary", "Mythic" });
            Field22.Location = new Point(804, 251);
            Field22.Name = "Field22";
            Field22.Size = new Size(212, 38);
            Field22.TabIndex = 32;
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
            // Field23
            // 
            Field23.FormattingEnabled = true;
            Field23.Items.AddRange(new object[] { "+1", "+2", "+3" });
            Field23.Location = new Point(1085, 254);
            Field23.Name = "Field23";
            Field23.Size = new Size(66, 38);
            Field23.TabIndex = 34;
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
            // Field25
            // 
            Field25.FormattingEnabled = true;
            Field25.Items.AddRange(new object[] { "Quarterstaff", "ID_INTERNAL_WEAPON_CATEGORY_SIMPLE_MELEE", "ID_INTERNAL_WEAPON_CATEGORY_SIMPLE_RANGED" });
            Field25.Location = new Point(820, 367);
            Field25.Name = "Field25";
            Field25.Size = new Size(568, 196);
            Field25.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(163, 610);
            label12.Name = "label12";
            label12.Size = new Size(120, 30);
            label12.TabIndex = 39;
            label12.Text = "Armor Type";
            // 
            // Field26
            // 
            Field26.FormattingEnabled = true;
            Field26.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "Shield" });
            Field26.Location = new Point(21, 643);
            Field26.Name = "Field26";
            Field26.Size = new Size(436, 38);
            Field26.TabIndex = 40;
            // 
            // AddImprovement
            // 
            AddImprovement.AutoSize = true;
            AddImprovement.Location = new Point(133, 701);
            AddImprovement.Name = "AddImprovement";
            AddImprovement.Size = new Size(172, 34);
            AddImprovement.TabIndex = 42;
            AddImprovement.Text = "Improvement?";
            AddImprovement.UseVisualStyleBackColor = true;
            // 
            // Field27
            // 
            Field27.FormattingEnabled = true;
            Field27.Items.AddRange(new object[] { "ID_INTERNAL_ARMOR_GROUP_LIGHT", "ID_INTERNAL_ARMOR_GROUP_MEDIUM", "ID_INTERNAL_ARMOR_GROUP_HEAVY" });
            Field27.Location = new Point(21, 741);
            Field27.Name = "Field27";
            Field27.Size = new Size(436, 100);
            Field27.TabIndex = 43;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(532, 610);
            label13.Name = "label13";
            label13.Size = new Size(124, 30);
            label13.TabIndex = 44;
            label13.Text = "Armor Class";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(544, 645);
            label14.Name = "label14";
            label14.Size = new Size(27, 30);
            label14.TabIndex = 45;
            label14.Text = "+";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(577, 643);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 35);
            numericUpDown1.TabIndex = 46;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "For adding improvements on pre-exisiting armor like Shield+1";
            toolTip2.Popup += toolTip2_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 856);
            Controls.Add(numericUpDown1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Field27);
            Controls.Add(AddImprovement);
            Controls.Add(Field26);
            Controls.Add(label12);
            Controls.Add(Field25);
            Controls.Add(label11);
            Controls.Add(Field23);
            Controls.Add(label10);
            Controls.Add(Field22);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(weight);
            Controls.Add(label7);
            Controls.Add(Field21);
            Controls.Add(label6);
            Controls.Add(Field20);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Field19);
            Controls.Add(Field18);
            Controls.Add(Field17);
            Controls.Add(Field16);
            Controls.Add(label3);
            Controls.Add(Field15);
            Controls.Add(label2);
            Controls.Add(Field14);
            Controls.Add(label1);
            Controls.Add(Field13);
            Controls.Add(Field12);
            Controls.Add(button1);
            Controls.Add(Field11);
            Controls.Add(Field10);
            Controls.Add(Field9);
            Controls.Add(Field8);
            Controls.Add(Field6);
            Controls.Add(Field4);
            Controls.Add(Field3);
            Controls.Add(Field2);
            Controls.Add(Field1);
            Name = "Form1";
            Text = "Aurora Item Builder";
            ((System.ComponentModel.ISupportInitialize)Field9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Field11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Field14).EndInit();
            ((System.ComponentModel.ISupportInitialize)Field15).EndInit();
            ((System.ComponentModel.ISupportInitialize)Field16).EndInit();
            ((System.ComponentModel.ISupportInitialize)Field18).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Field1;
        private ComboBox Field2;
        private TextBox Field3;
        private TextBox Field4;
        private RichTextBox Field6;
        private ComboBox Field8;
        private NumericUpDown Field9;
        private ComboBox Field10;
        private NumericUpDown Field11;
        private ToolTip toolTip1;
        private Button button1;
        private ComboBox Field12;
        private CheckedListBox Field13;
        private Label label1;
        private NumericUpDown Field14;
        private Label label2;
        private NumericUpDown Field15;
        private Label label3;
        private NumericUpDown Field16;
        private ComboBox Field17;
        private NumericUpDown Field18;
        private ComboBox Field19;
        private Label label4;
        private Label label5;
        private ComboBox Field20;
        private Label label6;
        private CheckedListBox Field21;
        private Label label7;
        private Label weight;
        private Label label8;
        private Label label9;
        private ComboBox Field22;
        private Label label10;
        private ComboBox Field23;
        private Label label11;
        private CheckedListBox Field25;
        private Label label12;
        private ComboBox Field26;
        private CheckBox AddImprovement;
        private CheckedListBox Field27;
        private Label label13;
        private Label label14;
        private NumericUpDown numericUpDown1;
        private ToolTip toolTip2;
    }
}
