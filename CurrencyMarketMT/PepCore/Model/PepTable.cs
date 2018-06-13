using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.Model
{
    public class PepTable : IEnumerable
    {
        private IEnumerable<string> columns = new List<string>();
        private IEnumerable<IEnumerable<object>> rows = new List<List<object>>();
        private string tableName;
        private IEnumerable<string> errors;
        private long dataSize;

        public long DataSize
        {
            get { return dataSize; }
            set { dataSize = value; }
        }


        public IEnumerable<string> Errors
        {
            get { return errors; }
            set { errors = value; }
        }

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public IEnumerable<IEnumerable<object>> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public IEnumerable<string> Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}
