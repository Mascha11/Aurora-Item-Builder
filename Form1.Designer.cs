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
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)Field9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Field11).BeginInit();
            SuspendLayout();
            // 
            // Field1
            // 
            Field1.Location = new Point(21, 24);
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
            Field2.Location = new Point(271, 24);
            Field2.Name = "Field2";
            Field2.Size = new Size(212, 38);
            Field2.TabIndex = 2;
            Field2.Text = "Choose Type";
            // 
            // Field3
            // 
            Field3.Location = new Point(558, 24);
            Field3.Name = "Field3";
            Field3.Size = new Size(175, 35);
            Field3.TabIndex = 3;
            Field3.Text = "Name of Source";
            // 
            // Field4
            // 
            Field4.Location = new Point(808, 27);
            Field4.Name = "Field4";
            Field4.Size = new Size(175, 35);
            Field4.TabIndex = 4;
            Field4.Text = "Author";
            // 
            // Field6
            // 
            Field6.Location = new Point(21, 77);
            Field6.Name = "Field6";
            Field6.Size = new Size(962, 128);
            Field6.TabIndex = 5;
            Field6.Text = "Description";
            // 
            // Field8
            // 
            Field8.FormattingEnabled = true;
            Field8.Items.AddRange(new object[] { "Adventuring Gear", "Treasure", "Equipment Packs", "Tools", "Musical Instruments", "Armor", "Magic Armor", "Weapons", "Magic Weapons", "Ammunition", "Spellcasting Focus", "Wondrous Items", "Supernatural Gifts", "Staffs", "Rods", "Wands", "Rings", "Potions", "Poison ", "Scrolls", "Spell Scrolls", "Explosives", "Mounts & Vehicles", "Optional Class Feature", "Alchemical Formulas", "Whetstones Reagents", "Additional Feature", "Additional Language", "Additional Proficiency", "Additional Spell", "Additional Ranger Spell" });
            Field8.Location = new Point(21, 211);
            Field8.Name = "Field8";
            Field8.Size = new Size(354, 38);
            Field8.TabIndex = 6;
            Field8.Text = "Shop Category";
            // 
            // Field9
            // 
            Field9.Location = new Point(490, 214);
            Field9.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Field9.Name = "Field9";
            Field9.Size = new Size(210, 35);
            Field9.TabIndex = 7;
            // 
            // Field10
            // 
            Field10.FormattingEnabled = true;
            Field10.Items.AddRange(new object[] { "PP", "GP", "EP", "SP", "CP" });
            Field10.Location = new Point(706, 211);
            Field10.Name = "Field10";
            Field10.Size = new Size(61, 38);
            Field10.TabIndex = 8;
            Field10.Text = "GP";
            // 
            // Field11
            // 
            Field11.Location = new Point(847, 214);
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
            button1.Location = new Point(750, 398);
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
            Field12.Location = new Point(21, 276);
            Field12.Name = "Field12";
            Field12.Size = new Size(212, 38);
            Field12.TabIndex = 12;
            Field12.Text = "Type of Focus";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(24, 331);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(209, 100);
            checkedListBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 563);
            Controls.Add(checkedListBox1);
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
        private CheckedListBox checkedListBox1;
    }
}
