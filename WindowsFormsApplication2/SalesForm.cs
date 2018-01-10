using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SalesForm : Form
    {
        TextBox gN = new TextBox();
        TextBox code = new TextBox();
        TextBox cN = new TextBox();
        TextBox value = new TextBox();
        TextBox customerCode = new TextBox();

        TextBoxController control = new TextBoxController();
        SalesController sale = new SalesController();
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            CreateListView();
        }

        public void CreateListView()
        {

            listViewCheckItems.View = View.Details;
            listViewCheckItems.AllowColumnReorder = true;
            listViewCheckItems.GridLines = true;

            //columns
            listViewCheckItems.Columns.Add("Game ID", 200, HorizontalAlignment.Left);
            listViewCheckItems.Columns.Add("Title", 450, HorizontalAlignment.Left);
            listViewCheckItems.Columns.Add("Console", 450, HorizontalAlignment.Left);
            listViewCheckItems.Columns.Add("Price", 450, HorizontalAlignment.Left);

            listViewTotal.View = View.Details;
            listViewTotal.Columns.Add("Total", 400, HorizontalAlignment.Center);
            listViewTotal.GridLines = true;

        }


        private void listViewCheckItems_Click(object sender, EventArgs e)
        {
            sale.ListBoxSelect(listViewCheckItems, listViewTotal);
        }

        private void textBoxScan_TextChanged(object sender, EventArgs e)
        {
            gN = textBoxGameName;
            code = textBoxScan;
            control.updateTextBoxes(code ,gN);
        }

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {
            cN = textBoxCustomerName;
            value = textBoxTradeValue;
            customerCode = textBoxCustomerID;
            control.updateCustomerTextBox(customerCode, cN, value);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            sale.ListViewRemove(listViewCheckItems, listViewTotal);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sale.AddItemToListView(textBoxScan, listViewCheckItems);
            sale.TotalAdd(textBoxScan, listViewTotal);
        }

        private void listViewCheckItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            sale.ListBoxSelect(listViewCheckItems, listViewTotal);
        }

        private void buttonTrade_Click(object sender, EventArgs e)
        {
            sale.ApplyTrade(textBoxCustomerID, listViewTotal);
        }
    }
}
