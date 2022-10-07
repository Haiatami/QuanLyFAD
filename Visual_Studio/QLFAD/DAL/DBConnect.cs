using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class DBConnect
    {
        string connsql = ("Data Source=MSI\\HOANGHAI;Initial Catalog=QLFAD;Integrated Security=True");
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                conn.Close();

            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                conn.Close();

            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                conn.Close();

            }
            return data;
        }
        public DataTable Load_Data(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();

            }
            return data;


        }
        public DataTable LoadDataWithParameter(string query, string[] name, object[] values, int parameter)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameter; i++)
                {
                    command.Parameters.AddWithValue(name[i], values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();

            }
            return data;

        }
        public int Excute_Data(string query, string[] name, object[] values, int parameter)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameter; i++)
                {
                    command.Parameters.AddWithValue(name[i], values[i]);
                }
                return command.ExecuteNonQuery();
                conn.Close();
            }

        }
        public int ReturnValueInt(string query)
        {
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                return int.Parse(command.ExecuteScalar().ToString());
                conn.Close();
            }


        }
        public int ReturnValueIntWithParameter(string query, string[] name, object[] values, int parameter)
        {
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameter; i++)
                {
                    command.Parameters.AddWithValue(name[i], values[i]);
                }
                return int.Parse(command.ExecuteScalar().ToString());
                conn.Close();
            }

        }
        public string ReturnValueString(string query)
        {
            using (SqlConnection conn = new SqlConnection(connsql))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                return command.ExecuteScalar().ToString();

                conn.Close();
            }

        }
    }
}
