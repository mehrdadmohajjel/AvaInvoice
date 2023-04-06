using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Utility
{
    public static class Tools
    {
        public static string CnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb";
        public static DataTable sqlDT = new DataTable();
        public static DataTable sqlDT2 = new DataTable();
        public static DataTable ExecuteSQLQuery(string SQLQuery)
        {
            try
            {
                OleDbConnection sqlCon = new OleDbConnection(CnString);
                OleDbDataAdapter sqlDA = new OleDbDataAdapter(SQLQuery, sqlCon);
                OleDbCommandBuilder sqlCB = new OleDbCommandBuilder(sqlDA);
                sqlDT.Reset();
                sqlDA.Fill(sqlDT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT;
        }
        public static DataTable ExecuteSQLQuery2(string SQLQuery)
        {
            try
            {
                OleDbConnection sqlCon = new OleDbConnection(CnString);
                OleDbDataAdapter sqlDA = new OleDbDataAdapter(SQLQuery, sqlCon);
                OleDbCommandBuilder sqlCB = new OleDbCommandBuilder(sqlDA);
                sqlDT2.Reset();
                sqlDA.Fill(sqlDT2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT2;
        }

        public static void FillDataGrid(string sql, DataGridView dgv)
        {
            OleDbConnection conn = new OleDbConnection(CnString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter adp = new OleDbDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                dgv.DataSource = dt;
                adp.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Preencher Combo Box Dinamicamente
        public static void FillComboBox(string sql, string Value_Member, string Display_Member, ComboBox combo)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(CnString))
            {
                using (var cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }
            combo.DataSource = dt;
            combo.ValueMember = Value_Member;
            combo.DisplayMember = Display_Member;
        }


        public static double num_repl(string a)
        {
            double n;
            bool isNumeric = double.TryParse(a, out n);
            return n;
        }

        public static object fltr_combo(ComboBox cmbo)
        {
            if (cmbo.SelectedIndex == -1)
            {
                return 0;
            }
            return cmbo.SelectedValue;
        }
        public static string Hash(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value))
                );
        }
        public static string ConvertArabicCharacterToPersian(string word)
        {
            return word.Replace("ی", "ي")
                        .Replace("ک", "ك");
        }

        public static string ConvertDataTableToJson(DataTable table)
        {
            return JsonConvert.SerializeObject(table);
        }

        public static string ConvertToEnglishNumber(string number)
        {
            var arabic = new string[10] { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };
            var persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            const int loopLength = 10;
            for (var i = 0; i < loopLength; i++)
            {
                var iAsNum = i.ToString();
                number = number.Replace(persian[i], iAsNum)
                               .Replace(arabic[i], iAsNum);
            }

            return number;
        }

        public static string ConvertToPersianNumber(string number)
        {
            var arabic = new string[10] { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };
            var persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            const int loopLength = 10;
            for (var i = 0; i < loopLength; i++)
            {
                var iAsNum = i.ToString();
                number = number.Replace(iAsNum, persian[i]);
            }

            return number;
        }

        public static DateTime ConvertToLatinDate(string shamsiDate, string format = "yyyy-MM-dd", char splitter = '/')
        {
            if (format is null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            var pc = new PersianCalendar();
            var shamsiList = shamsiDate.Split(splitter);
            var year = Convert.ToInt32(shamsiList[0]);
            var month = Convert.ToInt32(shamsiList[1]);
            var day = Convert.ToInt32(shamsiList[2]);

            return new DateTime(year, month, day, pc);
        }

        public static DateTime ConvertToLatinDateTime(string shamsiDate, string time)
        {
            var date = ConvertToLatinDate(shamsiDate);
            var splitTime = time.Split(':');
            var hour = Convert.ToInt32(splitTime[0]);
            var minute = Convert.ToInt32(splitTime[1]);
            date += new TimeSpan(hour, minute, 0);
            return date;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                _ = table.Columns.Add(prop.Name, type);
            }
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable ToDataTable<T>(this T item)
        {
            var type = typeof(T);
            return ToDataTable(item, type);
        }

        public static DataTable ToDataTable<T>(this T item, Type type)
        {
            var properties = TypeDescriptor.GetProperties(type);
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                var propPropertyType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                _ = table.Columns.Add(prop.Name, propPropertyType);
            }

            var row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            }
            table.Rows.Add(row);

            return table;
        }


        public static string ToShamsiDateString(this DateTime value, string separator = "/")
        {
            var pc = new PersianCalendar();
            var year = pc.GetYear(value);
            var month = pc.GetMonth(value).ToString("00");
            var day = pc.GetDayOfMonth(value).ToString("00");

            return year + separator + month + separator + day;
        }

    }
}
