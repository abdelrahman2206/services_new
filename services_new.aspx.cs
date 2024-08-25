using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace services_new
{
    
    public partial class About : Page
        
    {
        private int key = 0;
        private SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Integrated Security=True");
        private void Showgrid()
        {
            con.Open();
            string  Quiry = "select * from services_new ";
            SqlDataAdapter sda= new SqlDataAdapter(Quiry,con);
            
            var ds = new DataSet();
            sda.Fill(ds);
            GV1.DataSource = ds.Tables[0];
            GV1.DataBind();


            con.Close();    
        }
          

        private void Editserv()
        {
            if (Mname.Text == "" || MType.SelectedIndex == -1 || Mqty.Text == "" || Mprice.Text == "" || Manu.SelectedIndex == -1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('missing data');", true);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE services_new SET name = @N,type = @T,quantity = @Q,price = @P,manufacture=@M WHERE num=@W", con);
                    cmd.Parameters.AddWithValue("@N", Mname.Text);
                    cmd.Parameters.AddWithValue("@T", MType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Q", Mqty.Text);
                    cmd.Parameters.AddWithValue("@P", Mprice.Text);
                    cmd.Parameters.AddWithValue("@M", Manu.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@W", key);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterStartupScript(this,this.GetType(),"Script","alert('services updated in stock');",true);
                    con.Close();
                    Showgrid();

                }
                catch
                {

                    throw;
                }
            }
        }
        private void InsertName()
        {
            if (Mname.Text == "" || MType.SelectedIndex == -1 || Mqty.Text == "" || Mprice.Text == "" || Manu.SelectedIndex == -1)
            {
                Console.WriteLine("incomplete data");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into services_new(name,type,quantity,price,manufacture) values(@N,@T,@Q,@P,@M)", con);
                    cmd.Parameters.AddWithValue("@N", Mname.Text);
                    cmd.Parameters.AddWithValue("@T", MType.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Q", Mqty.Text);
                    cmd.Parameters.AddWithValue("@P", Mprice.Text);
                    cmd.Parameters.AddWithValue("@M", Manu.SelectedItem.Text);
                    cmd.ExecuteNonQuery();
                    //ScriptManager.RegisterStartupScript(this,this.GetType(),"Script","alert('services Added in stock');",true);
                    con.Close();
                    Showgrid();

                }
                catch
                {

                 throw;
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Showgrid();
        }

        protected void Addbtn_Click(object sender, EventArgs e)
        { 
         InsertName();
        }
        
        protected void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Mname.Text = GV1.SelectedRow.Cells[2].Text;
            MType.SelectedItem.Text = GV1.SelectedRow.Cells[3].Text;
            Mqty.Text = GV1.SelectedRow.Cells[4].Text;
            Mprice.Text = GV1.SelectedRow.Cells[5].Text;
            Manu.SelectedItem.Text = GV1.SelectedRow.Cells[6].Text;

            
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", $"alert('Key: {key}, Name: {Mname.Text}');", true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('M.name');", true);
        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            if (Mname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(GV1.SelectedRow.Cells[1].Text);
            }

            Editserv();
           // ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", $"alert('Key: {key}, Name: {Mname.Text}');", true);
            
        }
    }
}
