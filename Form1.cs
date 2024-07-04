using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aurora_Item_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Field8_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = Field8.SelectedItem;
            if (Field8.SelectedItem.ToString() == "Spellcasting Focus")
            {
                Field12.Visible = true;
            }
            else
            {
                Field12.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Gather input from the controls
            string name = Field1.Text;
            string convName = Field1.Text.ToUpper().Replace(' ', '_');
            string type = Field2.SelectedItem?.ToString();
            string convType = Field2.Text.ToUpper().Replace(' ', '_');
            string source = Field3.Text;
            string convSource = Field3.Text.ToUpper().Replace(' ', '_');
            string author = Field4.Text;
            string convAuthor = Field4.Text.ToUpper().Replace(' ', '_');
            string description = Field6.Text;
            string category = Field8.SelectedItem?.ToString();
            /*
            StringBuilder checkedListBoxInput = new StringBuilder();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedListBoxInput.AppendLine(item.ToString());
            }
            */
            // Format the output text
            StringBuilder output = new StringBuilder();
            output.AppendLine("<element name\"" + name + "\"" + " type\"" + type + "\"" + " source=\"" + source + "\"" + " id=\"ID_{" + convAuthor + "}_{" + convSource + "}_{" + convType + "}_{" + convName + "}\">");
            output.AppendLine("<description>" + description + "</description>");
            //output.AppendLine("ComboBox Selected: " + (type ?? "None"));
            //output.AppendLine("CheckedListBox Selected Items:");
            //output.Append(checkedListBoxInput.ToString());

            // Display the formatted text in richTextBox1
            richTextBox1.Text = output.ToString();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Field27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddImprovement_CheckedChanged(object sender, EventArgs e)
        {
            Field27.Visible = AddImprovement.Checked;
        }
    }
}
