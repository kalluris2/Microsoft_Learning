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
            string Name = @"Data Source=DESKTOP-1FN2CN9;Initial Catalog=ChitFund;Integrated Security=true";
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
    }
}
