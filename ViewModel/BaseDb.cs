using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace ViewModel
{
    public class BaseDB
    {
        protected string _connString;
        protected SqlConnection _connection;
        protected SqlCommand _command;
        protected SqlDataReader _reader;
        protected string _tableName;
        public BaseDB(string tableName)
        {
            _tableName = tableName;
            _connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orioz\OneDrive\מסמכים\AnimalsBase.accdb";
        }
    }
}
