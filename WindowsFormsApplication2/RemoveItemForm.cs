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
    public partial class RemoveItemForm : Form
    {
        TextBoxController control = new TextBoxController();
        TextBox gN = new TextBox();
        TextBox code = new TextBox();

        public RemoveItemForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            UpdateGameInDB();
        }

        private void UpdateGameInDB()
        {
            try
            {
                int gameToUpdate = 0;
                try
                {
                    gameToUpdate = Convert.ToInt32(textBoxCode.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("That's not a number!", "Please Scan Again!", MessageBoxButtons.OK);
                }
                int inStockNum;
                int valueFromIncrementor = Convert.ToInt32(numericUpDownQuantity.Value);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLExpress;" +
                 "User Instance=true;" +
                 "Integrated Security=true;" +
                 @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
                con.Open();


                SqlCommand inStock = new SqlCommand(
                    "Select InStock from Games where GameID = @Code" ,con);
                inStock.Parameters.AddWithValue("@Code", gameToUpdate);
                inStock.ExecuteScalar();
                inStockNum = Convert.ToInt32(inStock.ExecuteScalar());
                if (inStockNum >= valueFromIncrementor)
                {
                    SqlCommand update = new SqlCommand(
                    "update Games SET InStock = (InStock - @value)  WHERE GameID = @Code and InStock > 0 and GameName not like '" + "" + "';", con);
                    update.Parameters.AddWithValue("@Code", gameToUpdate);
                    update.Parameters.AddWithValue("@value", valueFromIncrementor);
                    if (gameToUpdate >= 1)
                    {
                        update.ExecuteNonQuery();
                        MessageBox.Show( inStockNum.ToString() + " " + valueFromIncrementor.ToString() + " Game was Removed!", "Success!", MessageBoxButtons.OK);
                        this.Close();
                        con.Close();
                    }
                }
                else
               {
                   SqlCommand update = new SqlCommand(
                        "update Games SET InStock = 0  WHERE GameID = @Code and InStock > 0 and GameName not like '" + "" + "';", con);
                    update.Parameters.AddWithValue("@Code", gameToUpdate);
                    update.Parameters.AddWithValue("@value", valueFromIncrementor);
                    if (gameToUpdate >= 1)
                    {
                        update.ExecuteNonQuery();
                        MessageBox.Show("Success!", "Game was Removed!", MessageBoxButtons.OK);
                        this.Close();
                         con.Close();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Rescan that! No matches found for game.", "Invalid Code!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            gN = textBoxGameName;
            code = textBoxCode;

            control.updateTextBoxes(code, gN);

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

        private void RemoveItemForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxCode;
            clear();
            ComboBox();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
