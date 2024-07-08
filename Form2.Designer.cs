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
            TreeNode treeNode3 = new TreeNode("Change (a) Speed", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("set specific Score");
            TreeNode treeNode5 = new TreeNode("add to specific Score");
            TreeNode treeNode6 = new TreeNode("change Score Max");
            TreeNode treeNode7 = new TreeNode("change an Ability", new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("change a vision");
            TreeNode treeNode9 = new TreeNode("change a skill");
            TreeNode treeNode10 = new TreeNode("change the Damage");
            TreeNode treeNode11 = new TreeNode("change an AC");
            TreeNode treeNode12 = new TreeNode("change a Proficiency");
            TreeNode treeNode13 = new TreeNode("change Initiative");
            TreeNode treeNode14 = new TreeNode("Modify a Stat", new TreeNode[] { treeNode3, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12, treeNode13 });
            TreeNode treeNode15 = new TreeNode("Modify a Grant");
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
            treeNode3.Name = "modSpeed";
            treeNode3.Text = "Change (a) Speed";
            treeNode4.Name = "modAbilSet";
            treeNode4.Text = "set specific Score";
            treeNode5.Name = "modAbilAdd";
            treeNode5.Text = "add to specific Score";
            treeNode6.Name = "modAbilMax";
            treeNode6.Text = "change Score Max";
            treeNode7.Name = "modAbil";
            treeNode7.Text = "change an Ability";
            treeNode8.Name = "modVision";
            treeNode8.Text = "change a vision";
            treeNode9.Name = "modSkill";
            treeNode9.Text = "change a skill";
            treeNode10.Name = "modDamage";
            treeNode10.Text = "change the Damage";
            treeNode11.Name = "modAC";
            treeNode11.Text = "change an AC";
            treeNode12.Name = "modProficiency";
            treeNode12.Text = "change a Proficiency";
            treeNode13.Name = "modIni";
            treeNode13.Text = "change Initiative";
            treeNode14.Name = "stat";
            treeNode14.Text = "Modify a Stat";
            treeNode15.Name = "grant";
            treeNode15.Text = "Modify a Grant";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode14, treeNode15 });
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