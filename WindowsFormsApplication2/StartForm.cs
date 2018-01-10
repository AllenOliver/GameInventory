using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void priceChartingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try

            { System.Diagnostics.Process.Start("https://www.pricecharting.com/"); }

            catch (Exception)

            { MessageBox.Show("Woah, thats not a website!", "Call your local developer", MessageBoxButtons.OK); }
        }

        private void gameStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try

            { System.Diagnostics.Process.Start("https://www.gamestop.com/"); }

            catch (Exception)

            { MessageBox.Show("Woah, thats not a website!", "Call your local developer", MessageBoxButtons.OK); }
        }

        private void ebayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try

            { System.Diagnostics.Process.Start("https://www.ebay.com/"); }

            catch (Exception)

            { MessageBox.Show("Woah, thats not a website!", "Call your local developer", MessageBoxButtons.OK); }
        }

        private void developerWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try

            { System.Diagnostics.Process.Start("http://www.aribaa.com/"); }

            catch (Exception)

            { MessageBox.Show("Woah, thats not a website!", "Call your local developer", MessageBoxButtons.OK); }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = textBoxGameTitle;
                SetUpComboBoxes();
                DefaultResults();
                CreateListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Whoa!", "Not Working!", MessageBoxButtons.OK);
            }
        }

        public void CreateListView()
        {
            listViewGames.View = View.Details;
            listViewGames.AllowColumnReorder = true;
            listViewGames.GridLines = true;

            //columns
            listViewGames.Columns.Add("Game ID", 100, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Console", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Price", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Trade Value", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Cash Value", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("In Stock", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Target Number", 150, HorizontalAlignment.Left);
            listViewGames.Columns.Add("Location", 250, HorizontalAlignment.Left);


        }

        public void SetUpComboBoxes()
        {
            comboBoxConsole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConsole.Items.Add("NES");
            comboBoxConsole.Items.Add("SNES");
            //ect TO DO
            comboBoxConsole.SelectedIndex = 0;



            comboBoxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocation.Items.Add("Elizabethton");
            comboBoxLocation.SelectedIndex = 0;
        }


        private void FilterResults()
        {

            string queryName;
            string Query;
            string rawName;
            rawName = textBoxGameTitle.Text;
            queryName = Regex.Replace(rawName, @"[^0-9a-zA-Z]+", " ");
            Query = "SELECT * FROM Games where GameName LIKE '%" + queryName + "%' and GameName not like '" + " " + "' order by GameName asc;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(
             Query, con);
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            listViewGames.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["GameID"].ToString());
                item.SubItems.Add(dr["GameName"].ToString());
                item.SubItems.Add(dr["Console"].ToString());
                item.SubItems.Add("$" + dr["Price"].ToString());
                item.SubItems.Add("$"+dr["TradeValue"].ToString());
                item.SubItems.Add("$" + dr["CashValue"].ToString());
                item.SubItems.Add(dr["InStock"].ToString());
                item.SubItems.Add(dr["NumberWanted"].ToString());
                item.SubItems.Add(dr["StoreLocation"].ToString());
                if (i % 2 == 0)
                {
                    item.BackColor = Color.LightBlue;
                }
                else
                {
                    item.BackColor = Color.White;
                }
                listViewGames.Items.Add(item);
            }
            con.Close();

        }

 
        public void DefaultResults()
        {
            //  listViewGames.View = View.Details;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();
            DataSet ds = new DataSet();


            SqlDataAdapter adapt = new SqlDataAdapter(
             "SELECT top 50 * from Games where GameName not like '" + "" + "' order by GameName asc", con);

            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            listViewGames.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["GameID"].ToString());
                item.SubItems.Add(dr["GameName"].ToString());
                item.SubItems.Add(dr["Console"].ToString());
                item.SubItems.Add("$" + dr["Price"].ToString());
                item.SubItems.Add("$" + dr["TradeValue"].ToString());
                item.SubItems.Add("$" + dr["CashValue"].ToString());
                item.SubItems.Add(dr["InStock"].ToString());
                item.SubItems.Add(dr["NumberWanted"].ToString());
                item.SubItems.Add(dr["StoreLocation"].ToString());
                if (i % 2 == 0)
                {
                    item.BackColor = Color.LightBlue;
                }
                else
                {
                    item.BackColor = Color.White;
                }
                listViewGames.Items.Add(item);
            }
            con.Close();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DefaultResults();
            textBoxGameTitle.Text = string.Empty;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxGameTitle.Text == String.Empty)
            {
                DefaultResults();
            }
            else
            {
                FilterResults();
            }

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm frm = new CreditsForm();
            frm.ShowDialog();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm frm = new AddItemForm();
            frm.ShowDialog();
        }

        private void showALLGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(
            "SELECT * from Games where GameName not like '" + "" + "' order by GameName asc", con);


            DataSet ds = new DataSet();

            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            listViewGames.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["GameID"].ToString());
                item.SubItems.Add(dr["GameName"].ToString());
                item.SubItems.Add(dr["Console"].ToString());
                item.SubItems.Add("$" + dr["Price"].ToString());
                item.SubItems.Add("$" + dr["TradeValue"].ToString());
                item.SubItems.Add("$" + dr["CashValue"].ToString());
                item.SubItems.Add(dr["InStock"].ToString());
                item.SubItems.Add(dr["NumberWanted"].ToString());
                item.SubItems.Add(dr["StoreLocation"].ToString());
                if (i % 2 == 0)
                {
                    item.BackColor = Color.LightBlue;
                }
                else
                {
                    item.BackColor = Color.White;
                }
                listViewGames.Items.Add(item);
            }

            con.Close();
        }

        private void comboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rawName;
            string queryName;

            rawName = textBoxGameTitle.Text;
            queryName = Regex.Replace(rawName, @"[^0-9a-zA-Z]+", " ");
            string consoleFilter = "";
            switch(comboBoxConsole.SelectedIndex)
            {
                case (0):
                    consoleFilter = "NES";
                    break;
                case (1):
                    consoleFilter = "SNES";
                    break;
            }
            string Query;

            Query = "SELECT * FROM Games where GameName like'%" + queryName + "%' and Console like '%" + consoleFilter + "%' and  GameName not like '" + "" + "' order by GameName asc;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLExpress;" +
             "User Instance=true;" +
             "Integrated Security=true;" +
             @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(
             Query, con);
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            listViewGames.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["GameID"].ToString());
                item.SubItems.Add(dr["GameName"].ToString());
                item.SubItems.Add(dr["Console"].ToString());
                item.SubItems.Add("$" + dr["Price"].ToString());
                item.SubItems.Add("$" + dr["TradeValue"].ToString());
                item.SubItems.Add("$" + dr["CashValue"].ToString());
                item.SubItems.Add(dr["InStock"].ToString());
                item.SubItems.Add(dr["NumberWanted"].ToString());
                item.SubItems.Add(dr["StoreLocation"].ToString());
                if (i % 2 == 0)
                {
                    item.BackColor = Color.LightBlue;
                }
                else
                {
                    item.BackColor = Color.White;
                }
                listViewGames.Items.Add(item);
            }
            con.Close();
        }

        private void BackUpDB()
        {

        }

        private void ShutDown()
        {
            if(DateTime.Now.Hour == 21)
            {
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void removeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemForm frm = new RemoveItemForm();
            frm.ShowDialog();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm();
            frm.ShowDialog();
        }
    }
}
