using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domain;

namespace Session
{
    public class Connection
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connstringbuilder;

        void ConnectTo()
        {
            connstringbuilder = new SqlConnectionStringBuilder();
            connstringbuilder.DataSource = "DESKTOP-TEEVUL2\\LKH";
            connstringbuilder.InitialCatalog = "systemDB";
            connstringbuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connstringbuilder.ToString());
        }

        public Connection()
        {
            ConnectTo();
        }

        public void Insert(Member m)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.MemberInfo(ID, PW, NAME, PERSONAL_NO, SEX, ADDRESS, EMAIL, QUESTION, ANSWER) VALUES(@ID, @PW, @NAME, @PERSONAL_NO, @SEX, @ADDRESS, @EMAIL, @QUESTION, @ANSWER)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@ID", m.Id);
                cmd.Parameters.AddWithValue("@PW", m.Pw);
                cmd.Parameters.AddWithValue("@NAME", m.Name);
                cmd.Parameters.AddWithValue("@PERSONAL_NO", m.Personal_no);
                cmd.Parameters.AddWithValue("@ADDRESS", m.Address);
                cmd.Parameters.AddWithValue("@EMAIL", m.Email);
                cmd.Parameters.AddWithValue("@QUESTION", m.Question);
                cmd.Parameters.AddWithValue("@ANSWER", m.Answer);
                cmd.Parameters.AddWithValue("@SEX", m.Sex);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }


        public bool Search(Member m)
        {
            try
            {
                string cmdText = "SELECT * FROM dbo.MemberInfo WHERE Convert(varchar(8000),isnull(ID,'')) = '" + m.Id + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sr = cmd.ExecuteReader();
                return sr.HasRows;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public string Login(Member m)
        {
            try
            {
                string cmdText = "SELECT ID, PW FROM dbo.MemberInfo WHERE Convert(varchar(8000),isnull(ID,'')) = '" + m.Id + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Read();
                string pw = sr.GetString(1);
                return pw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public string IDFind(Member m)
        {
            try
            {
                string cmdText = "SELECT ID FROM dbo.MemberInfo WHERE Convert(varchar(8000),isnull(NAME,'')) = '" + m.Name + "' AND Convert(varchar(8000),isnull(PERSONAL_NO,'')) = '" + m.Personal_no + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Read();
                string id = sr.GetString(0);
                return id;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public string PWFind(Member m)
        {
            try
            {
                string cmdText = "SELECT PW FROM dbo.MemberInfo WHERE Convert(varchar(8000),isnull(ID,'')) = '" + m.Id + "' AND Convert(varchar(8000),isnull(QUESTION,'')) = '" + m.Question + "' AND Convert(varchar(8000),isnull(ANSWER,'')) = '" + m.Answer + "'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Read();
                string pw = sr.GetString(0);
                return pw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public DataTable GetDBTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
