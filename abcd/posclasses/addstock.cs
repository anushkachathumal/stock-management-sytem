using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcd.posclasses
{
    class addstock
    {

        public int ID { get; set; }
        public string IteamCode { get; set; }
        public string Category { get; set; }
        public string quantity { get; set; }
        public string TakenPrice { get; set; }
        public string SalessPrice { get; set; }
        public string Takendiscount { get; set; }
        public string salessDiscount { get; set; }

        static string stock = ConfigurationManager.ConnectionStrings["newstock"].ConnectionString;

        public DataTable select() {
            SqlConnection conn = new SqlConnection(stock);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM addstock";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt); 
            }
            catch (Exception ex)
            {

                
            }

            finally
            {
                conn.Close();
            }
            return dt;

        }
        //save
        public  bool Insert(addstock c)

            
        {

            bool issuccess = false;
            SqlConnection conn = new SqlConnection(stock);
            try
            {
                string Sql = "INSER INTO addstock(icode,categoary,tprice,sprice,tdis,sdis)VALUES (@IteamCode,@Category,@quantity,@TakenPrice,@SalessPrice,@TakenDiscount,@salessDiscount)";

                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@IteamCode", c.IteamCode);
                cmd.Parameters.AddWithValue("@Category", c.Category);
                cmd.Parameters.AddWithValue("@quantity", c.quantity);
                cmd.Parameters.AddWithValue("@TakenPrice", c.TakenPrice);
                cmd.Parameters.AddWithValue("@SalessPrice", c.SalessPrice);
                cmd.Parameters.AddWithValue("@TakenDiscount", c.TakenPrice);
                cmd.Parameters.AddWithValue("@salessDiscount", c.salessDiscount);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }

            }


            catch (Exception ex)
            {

                
            }
            finally
            {
                conn.Close();
            }
            return issuccess;
            
        }

    }
}
