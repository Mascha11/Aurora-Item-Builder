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

            //MessageBox.Show(selectedItem.ToString());


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
