using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using User;

namespace DALStoredProcedure
{
    public class StoredProcedure
    {
        SqlConnection connection = null;
        public SqlConnection DataBaseConnection()
        {
            string Name = @"Data Source=DESKTOP-1FN2CN9;Initial Catalog=UserData;Integrated Security=true";
            return new SqlConnection(Name);
        }

        public void Insert(UserInput user)
        {
            try
            {
                 connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30).Value = user.UserName;
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                cmd.Parameters.Add("@passWord", SqlDbType.VarChar, 30).Value = user.Password;
                cmd.Parameters.Add("@role", SqlDbType.VarChar, 30).Value = user.Role;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();  
            }

        }

        public void Update(UserInput user)
        {
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spUpdateData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30).Value = user.UserName;
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                cmd.Parameters.Add("@passWord", SqlDbType.VarChar, 30).Value = user.Password;
                cmd.Parameters.Add("@role", SqlDbType.VarChar, 30).Value = user.Role;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public void Delete(UserInput user)
        {
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spDeleteData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
