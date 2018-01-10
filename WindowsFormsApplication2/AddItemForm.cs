using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AddItemForm : Form
    {
        TextBoxController control = new TextBoxController();
        AddItemController add = new AddItemController();
        NumericUpDown quantity = new NumericUpDown();
        TextBox gN = new TextBox();
        TextBox code = new TextBox();


        public AddItemForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            numericUpDownQuantity.Value = 0;
            textBoxCode.Text = string.Empty;
            textBoxGameName.Text = string.Empty;
        }

        private void ComboBox()
        {
            comboBoxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocation.Items.Add("Elizabethton");
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxCode;
            clear();
            ComboBox();
        }

       

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            quantity = numericUpDownQuantity;
            add.UpdateGameInDB(code, quantity);
        }

        private void textBoxGameName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

            gN = textBoxGameName;
            code = textBoxCode;
            control.updateTextBoxes(code, gN);
        }
    }
}
