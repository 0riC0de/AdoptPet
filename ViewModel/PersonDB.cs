using Model;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ViewModel
{
    public class PersonsDb : BaseDB
    {

        public PersonsDb() : base("Person")
        {

        }

        public PersonList SelectALL()
        {
            string query = "SELECT * from " + _tableName;
            PersonList lst = Select(query);
            return lst;
        }

        public Person SelectByID(int id)
        {
            string query = string.Format("SELECT * from {0} WHERE id = {1}", _tableName, id);
            PersonList lst = Select(query);
            return lst.FirstOrDefault(); ;
        }
        private PersonList Select(string query)
        {
            PersonList list = new PersonList();
            using (OleDbConnection connection = new OleDbConnection(_connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand(query, connection);
                reader = command.ExecuteReader();
                Person p;
                while (reader.Read())
                {
                    p = new Person();
                    p.Id = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.SurName = reader.GetString(2);
                    p.Email = reader.GetString(3);
                    p.IsAdmin = reader.GetBoolean(4);
                    p.PassWord = reader.GetString(5);
                    p.Phone = reader.GetInt32(6);
                    int adressId = reader.GetInt32(7);
                    //TODO get adress from adressdb
                    p.UserName = reader.GetString(8);
                    list.Add(p);
                }
                return list;
            }
        }


       
    }
}