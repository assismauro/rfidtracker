using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDTracker
{
    public class Db
    {
        static string connStr = Properties.Settings.Default.RFIDTracker.StartsWith("Dsn=")? Properties.Settings.Default.RFIDTracker:
            StringCipher.Decrypt(Properties.Settings.Default.RFIDTracker, "A@#xr");
        public static OdbcConnection dbConnection = null;
        public Db()
        {
            dbConnection = new OdbcConnection(connStr);
        }

        public void execSQL(string sql)
        {
            try
            {
                if (!(dbConnection.State == System.Data.ConnectionState.Open))
                    dbConnection.Open();
                OdbcCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = sql;
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            dbConnection.Close();
        }

        public Object getValue(string sql)
        {
            dbConnection.Open();
            OdbcCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = sql;
            OdbcDataReader dbReader = dbCommand.ExecuteReader();
            string value = null;
            if (dbReader.Read())
            {
                value = dbReader.GetString(0);
            }
            dbConnection.Close();
            return value;
        }

        public List<Dictionary<string, object>> getRows(string sql)
        {
            Dictionary<string, object> item = new Dictionary<string, object>();
            List<Dictionary<string, object>> ls = new List<Dictionary<string, object>>();
            dbConnection.Open();
            OdbcCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = sql;
            OdbcDataReader dbReader = dbCommand.ExecuteReader();
            int fCount = dbReader.FieldCount;
            while (dbReader.Read())
            {
                for (int i = 0; i < fCount; i++)
                {
                    if (!dbReader.IsDBNull(i))
                        if (dbReader.GetFieldType(i).Name == "String")
                            item.Add(dbReader.GetName(i), dbReader.GetString(i));
                        else
                            if (dbReader.GetFieldType(i).Name == "Int32")
                            item.Add(dbReader.GetName(i), dbReader.GetInt32(i));
                        else { }
                    else
                        item.Add(dbReader.GetName(i), System.DBNull.Value);
                }
                ls.Add(item);
            }
            dbConnection.Close();
            return ls;
        }

        public bool UpdateTable(System.Data.DataRowView r, bool opDelete = false)
        {
            if (opDelete)
            {
                string delete = string.Format("delete from {0} where id = {1}",
                    r.Row.Table.TableName, r["id"]);
                execSQL(delete);
                return true;
            }
            if ((int)r["id"] > -1)
            {
                string update = string.Format("update {0} set ", r.Row.Table.TableName);
                string values = string.Empty;
                string where = string.Format(" where id = {0}", r["id"]);
                for (int i = 1; i < r.Row.Table.Columns.Count; i++) // skip id
                {
                    values +=
                        string.Format("{0} = '{1}',",
                        r.Row.Table.Columns[i].ColumnName,
                        r[r.Row.Table.Columns[i].ColumnName] != System.DBNull.Value ?
                        r[r.Row.Table.Columns[i].ColumnName]
                        : "NULL");
                }
                execSQL(update + values.Remove(values.Length - 1) + where);
            }
            else
            {
                string insert = string.Format("insert into {0} (", r.Row.Table.TableName);
                string values = "values (";
                for (int i = 1; i < r.Row.Table.Columns.Count; i++) // skip id
                {
                    insert += string.Format("{0},", r.Row.Table.Columns[i].ColumnName);
                    values += r[r.Row.Table.Columns[i].ColumnName] != System.DBNull.Value ?
                        string.Format("'{0}',", r[r.Row.Table.Columns[i].ColumnName])
                        : "NULL,";
                }
                execSQL(insert.Remove(insert.Length - 1) + ")" +
                    values.Remove(values.Length - 1) + ")");
            }
            return true;
        }
    }
}
