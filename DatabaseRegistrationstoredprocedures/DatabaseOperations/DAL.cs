using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using User;
using System.Data;

namespace DatabaseOperations
{
    public class DataAccessLayer
    {
        public SqlConnection DataBaseConnection()
        {
            string Name = @"Data Source=DESKTOP-1FN2CN9;Initial Catalog=UserData;Integrated Security=true";
            return new SqlConnection(Name);
        }

        public void Insert(UserInput user)
        {
            try
            {
                string InsertData = "insert into dbo.Data(UserName, UserId, Password, Role)" +
                    "values (@username, @userid, @passWord, @role)";
                SqlConnection Connect = DataBaseConnection();
                Connect.Open();
                SqlCommand cmd = new SqlCommand(InsertData, Connect);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30).Value= user.UserName ;
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                cmd.Parameters.Add("@passWord", SqlDbType.VarChar, 30).Value = user.Password ;
                cmd.Parameters.Add("@role", SqlDbType.VarChar, 30).Value = user.Role;
                cmd.ExecuteNonQuery();
                Connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update(UserInput user)
        {
            try
            {
                string UpdateData = "update Data Set UserName=@username, Password=@passWord, Role=@role Where UserId=@userid";
                SqlConnection Connect = DataBaseConnection();
                Connect.Open();
                SqlCommand cmd = new SqlCommand(UpdateData, Connect);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30).Value =user.UserName ;
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                cmd.Parameters.Add("@passWord", SqlDbType.VarChar, 30).Value = user.Password;
                cmd.Parameters.Add("@role", SqlDbType.VarChar, 30).Value = user.Role;
                cmd.ExecuteNonQuery();
                Connect.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Delete(UserInput user)
        {

            try
            {
                string DeleteData = "Delete from Data where UserId =@userid";
                SqlConnection Connect = DataBaseConnection();
                Connect.Open();
                SqlCommand cmd = new SqlCommand(DeleteData, Connect);
                cmd.Parameters.Add("@userid", SqlDbType.VarChar, 30).Value = user.UserId;
                cmd.ExecuteNonQuery();
                Connect.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                    

    }
}
