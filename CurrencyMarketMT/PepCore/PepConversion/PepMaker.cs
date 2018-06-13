using PepCore.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.PepConversion
{
    public class PepMaker
    {
        public static PepTable MakeTableFromReader(SqlDataReader reader)
        {
            var pepTable = new PepTable();
            List<string> errors = new List<string>();
            try
            {
                var cols = new List<string>();
                for (var i = 0; i < reader.FieldCount; i++)
                    cols.Add(reader.GetName(i));
                pepTable.Columns = cols;

                var rows = new List<List<object>>();
                while (reader.Read())
                {
                    rows.Add(SerializeRow(cols, reader));
                }
                pepTable.Rows = rows;
            }
            catch (Exception ex)
            {

                pepTable.Errors = errors;
            }
           
            return pepTable;
        }
        private static List<object> SerializeRow(IEnumerable<string> cols,
                                                        SqlDataReader reader)
        {
            var result = new List<object>();
            foreach (var col in cols)
                result.Add(reader[col]);
            return result;
        }
    }
}
