﻿namespace Aurora_Item_Builder
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
            RuleBuilder2.Location = new Point(12, 74);
            RuleBuilder2.Name = "RuleBuilder2";
            RuleBuilder2.Size = new Size(212, 38);
            RuleBuilder2.TabIndex = 2;
            RuleBuilder2.SelectionChangeCommitted += RuleBuilder2_SelectionChangeCommitted;
            // 
            // RuleBuilder3
            // 
            RuleBuilder3.FormattingEnabled = true;
            RuleBuilder3.Location = new Point(12, 136);
            RuleBuilder3.Name = "RuleBuilder3";
            RuleBuilder3.Size = new Size(212, 38);
            RuleBuilder3.TabIndex = 3;
            // 
            // RuleBuilder4
            // 
            RuleBuilder4.FormattingEnabled = true;
            RuleBuilder4.Location = new Point(12, 198);
            RuleBuilder4.Name = "RuleBuilder4";
            RuleBuilder4.Size = new Size(212, 38);
            RuleBuilder4.TabIndex = 4;
            RuleBuilder4.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 716);
            Controls.Add(RuleBuilder4);
            Controls.Add(RuleBuilder3);
            Controls.Add(RuleBuilder2);
            Controls.Add(RuleBuilder1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private ComboBox RuleBuilder1;
        private ComboBox RuleBuilder2;
        private ComboBox RuleBuilder3;
        private ComboBox RuleBuilder4;
    }
}