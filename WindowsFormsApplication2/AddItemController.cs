using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    class AddItemController
    {
        
        public void UpdateGameInDB(TextBox txt, NumericUpDown up)
        {
            try
            {
                int gameIDs = 0;
                int gameToUpdate = 0;
                try
                {
                    gameToUpdate = Convert.ToInt32(txt.Text);
                }
                catch (Exception)
                {
                    ErrorForm frm = new ErrorForm();
                    frm.ShowDialog();
                    //MessageBox.Show("That's not a number!","Please Scan Again!", MessageBoxButtons.OK);
                }

                int valueFromIncrementor = Convert.ToInt32(up.Value);
                string gameOutput;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLExpress;" +
                 "User Instance=true;" +
                 "Integrated Security=true;" +
                 @"AttachDbFilename=|DataDirectory|\Test_Game_DB.mdf;";
                con.Open();
                SqlCommand update = new SqlCommand(
                "update Games SET InStock = (InStock + @value)  WHERE GameID = @Code and GameName not like '" + "" + "' ;", con);
                update.Parameters.AddWithValue("@Code", gameToUpdate);
                update.Parameters.AddWithValue("@value", valueFromIncrementor);
                update.Parameters.AddWithValue("@idCheck", gameIDs);

                SqlCommand gameName = new SqlCommand(
                    "select gamename from games where gameid = @Code", con);
                gameName.Parameters.AddWithValue("@Code", gameToUpdate);
                gameOutput = gameName.ExecuteScalar().ToString();
                if (gameToUpdate >= 1)
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show(gameOutput + " was Added!", " Success!", MessageBoxButtons.OK);
                    Form.ActiveForm.Close();
                    con.Close();
                }

            }
            catch (Exception)
            {

                Form.ActiveForm.Close();
            }
        }
    }
}
