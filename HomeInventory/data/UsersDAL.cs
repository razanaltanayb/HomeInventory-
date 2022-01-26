using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeInventory.entites;

namespace HomeInventory.data
{
    public static class UsersDAL
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\Desktop\\User.accdb";
        private static OleDbConnection connection = new OleDbConnection(connectionString);




        public static void CreateUser(User user)
        {
            string commandText = String.Format("Insert into User(FirstName,LastName ,Password)" +
               "values('{0}','{1}',{2})",
               user.FirstName, user.LastName, user.Password);

            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUser(User user)
        {
            string commandText = String.Format("Update User Set FirstName='{1}',LastName='{2}'" +
                "where UserID={0}",
                user.UserID, user.FirstName, user.LastName);


            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteUser(User user)
        {
            string commandText = String.Format("Delete from User where UserID = {user.UserID}");

            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public static DataTable GetAllUsers()
        {
            string commandText = String.Format($"Select * from User");
            OleDbCommand command = new OleDbCommand(commandText, connection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public static User GetUserById(int UserID)
        {
            User user = new User();

            string commandText = $"Select * from SystemUsers where UserId={UserID}";

            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();

            OleDbDataReader userReader = command.ExecuteReader();

            if (userReader.HasRows)
            {
                while (userReader.Read())
                {
                    user.UserID = userReader.GetInt32(0);
                    user.FirstName = userReader.GetString(1);
                    user.LastName = userReader.GetString(2);

                    user.Password = userReader.GetString(3);
                }
            }

            connection.Close();
            return user;

        }
    }
}
