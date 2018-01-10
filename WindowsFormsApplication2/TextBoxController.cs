using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class TextBoxController
    {
       public void updateTextBoxes(TextBox Code, TextBox GameName)
        {
            string gameNameOut;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();

            int gameToUpdate = 0;
            try
            {
                if (Code.Text != "")
                {
                    gameToUpdate = Convert.ToInt32(Code.Text);
                }

            }
            catch (Exception)
            {
                GameName.Text = "That's Not a game!";
            }

            SqlCommand currentGameName = new SqlCommand(
                "select GameName from Games where GameID = @code;", con);
            currentGameName.Parameters.AddWithValue("@Code", gameToUpdate);
            gameNameOut = (String)currentGameName.ExecuteScalar();
            if (gameNameOut == "")
            {
                GameName.Text = "Game Not Found! :[";
            }
            else
            {
                GameName.Text = gameNameOut;
            }
            con.Close();
        }

        public void updateCustomerTextBox(TextBox Code, TextBox CustomerName, TextBox Value)
        {
            string customerNameOut;
            string tradeValueOut;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();

            int gameToUpdate = 0;
            try
            {
                if (Code.Text != "")
                {
                    gameToUpdate = Convert.ToInt32(Code.Text);
                }
                else
                {
                    gameToUpdate = 0;
                }

            }
            catch (Exception)
            {
                CustomerName.Text = "That's Not a game!";
            }

            SqlCommand currentCustomerName = new SqlCommand(
                "select CustomerName from TradeValues where CustomerID = @code;", con);
            currentCustomerName.Parameters.AddWithValue("@Code", gameToUpdate);
            customerNameOut = (String)currentCustomerName.ExecuteScalar();
            if (customerNameOut == "")
            {
                CustomerName.Text = "Customer Not Found! :[";
            }
            else
            {
                CustomerName.Text = customerNameOut;
            }


            SqlCommand customerTrade = new SqlCommand(
               "select TradeValue from TradeValues where CustomerID = @Code;", con);
            customerTrade.Parameters.AddWithValue("@Code", gameToUpdate);
            if(customerTrade != null)
            {
                tradeValueOut = "$" + customerTrade.ExecuteScalar();
                if (tradeValueOut == "")
                {
                    Value.Text = "Customer Not Found! :[";
                }
                else
                {
                    Value.Text = tradeValueOut;
                }
            }
            else
            {
                Value.Text = "";
            }


            con.Close();
        }

    }
}
