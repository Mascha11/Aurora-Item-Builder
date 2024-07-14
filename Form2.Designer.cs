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
            RuleBuilder1 = new ComboBox();
            RuleBuilder2 = new ComboBox();
            RuleBuilder3 = new ComboBox();
            RuleBuilder4 = new ComboBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            RuleBuilderValue = new NumericUpDown();
            listBox1 = new ListBox();
            RuleBuilder5 = new ComboBox();
            richTextBox1 = new RichTextBox();
            deleteRule = new Button();
            ((System.ComponentModel.ISupportInitialize)RuleBuilderValue).BeginInit();
            SuspendLayout();
            // 
            // RuleBuilder1
            // 
            RuleBuilder1.FormattingEnabled = true;
            RuleBuilder1.Items.AddRange(new object[] { "change stat", "grant something" });
            RuleBuilder1.Location = new Point(12, 12);
            RuleBuilder1.Name = "RuleBuilder1";
            RuleBuilder1.Size = new Size(212, 38);
            RuleBuilder1.TabIndex = 1;
            RuleBuilder1.SelectionChangeCommitted += RuleBuilder1_SelectionChangeCommitted;
            // 
            // RuleBuilder2
            // 
            RuleBuilder2.FormattingEnabled = true;
            RuleBuilder2.Location = new Point(12, 75);
            RuleBuilder2.Name = "RuleBuilder2";
            RuleBuilder2.Size = new Size(212, 38);
            RuleBuilder2.TabIndex = 2;
            RuleBuilder2.SelectionChangeCommitted += RuleBuilder2_SelectionChangeCommitted;
            // 
            // RuleBuilder3
            // 
            RuleBuilder3.FormattingEnabled = true;
            RuleBuilder3.Location = new Point(12, 138);
            RuleBuilder3.Name = "RuleBuilder3";
            RuleBuilder3.Size = new Size(212, 38);
            RuleBuilder3.TabIndex = 3;
            RuleBuilder3.SelectionChangeCommitted += RuleBuilder3_SelectionChangeCommitted;
            // 
            // RuleBuilder4
            // 
            RuleBuilder4.FormattingEnabled = true;
            RuleBuilder4.Location = new Point(12, 201);
            RuleBuilder4.Name = "RuleBuilder4";
            RuleBuilder4.Size = new Size(212, 38);
            RuleBuilder4.TabIndex = 4;
            RuleBuilder4.SelectionChangeCommitted += RuleBuilder4_SelectionChangeCommitted;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 472);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(776, 232);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 426);
            button1.Name = "button1";
            button1.Size = new Size(439, 40);
            button1.TabIndex = 7;
            button1.Text = "Generate Rules String";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RuleBuilderValue
            // 
            RuleBuilderValue.Location = new Point(12, 327);
            RuleBuilderValue.Name = "RuleBuilderValue";
            RuleBuilderValue.Size = new Size(210, 35);
            RuleBuilderValue.TabIndex = 8;
            RuleBuilderValue.ValueChanged += RuleBuilderValue_ValueChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(457, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 454);
            listBox1.TabIndex = 9;
            // 
            // RuleBuilder5
            // 
            RuleBuilder5.FormattingEnabled = true;
            RuleBuilder5.Location = new Point(12, 264);
            RuleBuilder5.Name = "RuleBuilder5";
            RuleBuilder5.Size = new Size(212, 38);
            RuleBuilder5.TabIndex = 10;
            RuleBuilder5.Visible = false;
            RuleBuilder5.SelectionChangeCommitted += RuleBuilder5_SelectionChangeCommitted;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 710);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 232);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // deleteRule
            // 
            deleteRule.Location = new Point(320, 380);
            deleteRule.Name = "deleteRule";
            deleteRule.Size = new Size(131, 40);
            deleteRule.TabIndex = 12;
            deleteRule.Text = "Delete Item";
            deleteRule.UseVisualStyleBackColor = true;
            deleteRule.Click += deleteRule_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 954);
            Controls.Add(deleteRule);
            Controls.Add(richTextBox1);
            Controls.Add(RuleBuilder5);
            Controls.Add(listBox1);
            Controls.Add(RuleBuilderValue);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(RuleBuilder4);
            Controls.Add(RuleBuilder3);
            Controls.Add(RuleBuilder2);
            Controls.Add(RuleBuilder1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)RuleBuilderValue).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox RuleBuilder1;
        private ComboBox RuleBuilder2;
        private ComboBox RuleBuilder3;
        private ComboBox RuleBuilder4;
        private RichTextBox richTextBox2;
        private Button button1;
        private NumericUpDown RuleBuilderValue;
        private ListBox listBox1;
        private ComboBox RuleBuilder5;
        private RichTextBox richTextBox1;
        private Button deleteRule;
    }
}