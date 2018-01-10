using RegistrationInputs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseConnection
{
    public class Operations
    {
        SqlConnection connection = null;

        public SqlConnection DatabaseConnect()
        {
            string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=ChitFund;Integrated Security=true";
            return new SqlConnection(Name);
        }
        public void InsertRegistration(Person inputValues)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertPeopleData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = inputValues.RegistrationNumber;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 30).Value = inputValues.FirstName;
                cmd.Parameters.Add("@secondname", SqlDbType.VarChar, 30).Value = inputValues.SecondName;
                cmd.Parameters.Add("@phno", SqlDbType.VarChar, 10).Value = inputValues.PhoneNumber;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = inputValues.Address;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 10).Value = inputValues.ChitId;
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
        public void InsertEmployee(Person Values)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployeeData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@employeeid", SqlDbType.Int ).Value = Values.EmployeeId;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar,30).Value = Values.FirstName;
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar,30).Value = Values.SecondName;
                cmd.Parameters.Add("@jobid", SqlDbType.Int).Value = Values.JobId;
                cmd.Parameters.Add("@password", SqlDbType.VarChar,10).Value = Values.Password;
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
        public bool EmployeeLogin(int id, string password)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                string command = "select count(Password) from Employees where EmployeeId= '" +id +"' and Password= '" +password+"'";
                SqlDataAdapter data = new SqlDataAdapter(command, connection);
                DataTable table = new DataTable();
                data.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                    return true;
                else
                   return false;
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public void InsertPayment(Person inputvalues)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertChitDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@paymentid", SqlDbType.VarChar, 30).Value = inputvalues.PaymentId;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = inputvalues.RegistrationNumber;
                cmd.Parameters.Add("@datepaid", SqlDbType.Date).Value = inputvalues.DatePaidOn;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 30).Value = inputvalues.ChitId;
                cmd.Parameters.Add("@amtpaid", SqlDbType.Int).Value = inputvalues.AmountPaid;
                cmd.Parameters.Add("@receivedby", SqlDbType.VarChar, 30).Value = inputvalues.AmountReceivedBy;
                cmd.Parameters.Add("@paidby", SqlDbType.VarChar, 30).Value = inputvalues.FirstName;
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
        

        public List<Registration> ViewData(string value)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                //string query = "select R.FirstName,R.SecondName,P.ChitId,P.DatePaid,P.AmtPaid from dbo.Registration As R join dbo.PaymentDetails As P " +
                  //  "on R.RegistrationNo = P.Registrationno where P.ChitId='" + value + "'";
               // string query = "select R.FirstName,R.SecondName,P.ChitId,P.DatePaid,P.AmtPaid from dbo.Registration As R join dbo.PaymentDetails As P " +
                 //  "on R.RegistrationNo = P.Registrationno where P.ChitId='@chitid'";
                   
               // SqlCommand cmd = new SqlCommand(query, connection);
                SqlCommand cmd = new SqlCommand("spPersonDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@chitid", value);

                //DataSet Data = new DataSet();
                //SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                //Adapter.Fill(Data);
                SqlDataReader dataReader = cmd.ExecuteReader();
               
                List<Registration> _chitregistrationsList = new List<Registration>();
                while(dataReader.Read())
                {
                    Registration registrantionInstance = new Registration();
                    registrantionInstance.FirstName = dataReader[0].ToString();
                    registrantionInstance.LastName = dataReader[1].ToString();
                    registrantionInstance.ChittiId = dataReader[2].ToString();
                    registrantionInstance.DatePaid = dataReader[3].ToString();
                    registrantionInstance.PaidAmount = dataReader[4].ToString();
                    registrantionInstance.TotalEmi = dataReader[5].ToString();
                    registrantionInstance.MonthlyEmiPayments = dataReader[6].ToString();


                    _chitregistrationsList.Add(registrantionInstance);
                }
                
                return _chitregistrationsList;
                //var result= Data;
                //return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool CustomerLogin(int id, string password)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                string command = "select count(Password) from Registration where RegistrationNo= '" + id + "' and Password= '" + password + "'";
                SqlDataAdapter data = new SqlDataAdapter(command, connection);
                DataTable table = new DataTable();
                data.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
