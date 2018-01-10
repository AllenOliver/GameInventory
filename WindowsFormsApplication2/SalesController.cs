using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class SalesController
    {
        public float TotalPrice;
        public float query;
        public void AddItemToListView(TextBox ID, ListView lst)
        {
            try
            {
                float query;
                float lookUp = Convert.ToInt32(ID.Text);
                string gameID;
                gameID = ID.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLExpress;" +
                 "User Instance=true;" +
                 "Integrated Security=true;" +
                 @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
                con.Open();


                DataSet ds = new DataSet();


                SqlDataAdapter LookUpGame = new SqlDataAdapter(
                 "SELECT * from Games where GameID like '" + gameID + "' ", con);

                SqlCommand price = new SqlCommand(
                    "SELECT Price from Games Where GameID like @Code;"
                    ,con);
                price.Parameters.AddWithValue("@Code", lookUp);
                //query = (float)price.ExecuteScalar();
                LookUpGame.Fill(ds);
                DataTable dt = ds.Tables[0];
                //lst.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem item = new ListViewItem(dr["GameID"].ToString());
                    item.SubItems.Add(dr["GameName"].ToString());
                    item.SubItems.Add(dr["Console"].ToString());
                    item.SubItems.Add("$" + dr["Price"].ToString());
                    if (i % 2 == 0)
                    {
                        item.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                    lst.Items.Add(item);
                }
                    con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show(":[","Something broke",MessageBoxButtons.OK);
            }
        }

        public void ListBoxSelect(ListView lst, ListView lstt)
        {
            if (lst.SelectedItems.Count > 0)
            {
                ListViewItem item = lst.SelectedItems[0];
                
            }
        }
        public void ListViewRemove(ListView lst, ListView lstt)
        {

            foreach (ListViewItem eachItem in lst.SelectedItems)
            {
                lst.Items.Remove(eachItem);
                if (TotalPrice != 0)
                {
                    this.TotalPrice -= this.query;
                    lstt.Items.Clear();
                    lstt.Items.Add("$" + TotalPrice.ToString());
                }
            }

        }


        public float TotalAdd(TextBox ID, ListView lst)
        {
            try
            {
                lst.Items.Clear();
                float lookUp = Convert.ToInt32(ID.Text);
                string gameID;
                gameID = ID.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLExpress;" +
                 "User Instance=true;" +
                 "Integrated Security=true;" +
                 @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
                con.Open();

                SqlCommand price = new SqlCommand(
                "SELECT Price from Games Where GameID = @Code;"
                , con);
                price.Parameters.AddWithValue("@Code", lookUp);
                query = (float)Convert.ToInt32(price.ExecuteScalar());

                TotalPrice += query;

                lst.Items.Add("$" + this.TotalPrice.ToString());
                con.Close();
            }
            catch(Exception)
            {

            }
            return query;
        }

        public void ApplyTrade(TextBox Code, ListView lst)
        {
            try
            {
                float tradeValueOut;
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
                    MessageBox.Show("ktmk");
                }

                SqlCommand customerTrade = new SqlCommand(
                   "select TradeValue from TradeValues where CustomerID like @Code;", con);
                customerTrade.Parameters.AddWithValue("@Code", gameToUpdate);
                if (customerTrade != null)
                {
                    tradeValueOut = (float)Convert.ToDouble(customerTrade.ExecuteScalar());
                    MessageBox.Show(tradeValueOut.ToString());
                }
                else
                {
                    tradeValueOut = 0;
                }

                if(tradeValueOut >= TotalPrice)
                {
                    tradeValueOut -= this.TotalPrice;
                    TotalPrice = 0;
                   // tradeValueOut -= this.TotalPrice;
                    SqlCommand TradeUpdate = new SqlCommand(
                    "UPDATE TradeValues set TradeValue = @trade where CustomerID = @Code;", con);
                    TradeUpdate.Parameters.AddWithValue("@Code", gameToUpdate);
                    TradeUpdate.Parameters.AddWithValue("@trade", tradeValueOut);
                    TradeUpdate.ExecuteNonQuery();

                }
                else
                {
                    this.TotalPrice -= tradeValueOut;
                    SqlCommand TradeUpdate = new SqlCommand(
                "UPDATE TradeValues set TradeValue = 0 where CustomerID = @Code;", con);
                    TradeUpdate.Parameters.AddWithValue("@Code", gameToUpdate);
                    TradeUpdate.ExecuteNonQuery();
                }
                con.Close();
                lst.Items.Add("- $" + tradeValueOut.ToString());
                lst.Items.Add("$" + TotalPrice.ToString());
   
            }
            catch(Exception)
            {
                ErrorForm frm = new ErrorForm();
                frm.ShowDialog();
            }
        }
        
    }
}
