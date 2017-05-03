using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VerbindungAufbauen();
            Console.WriteLine(ZeigeFragen());
            Console.Read();
        }
        public static SQLiteConnection m_dbConnection;

        public static void VerbindungAufbauen()
        {
            m_dbConnection = new SQLiteConnection("Data Source=KarteiDB.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public static string ZeigeFragen()
        {
            m_dbConnection = new SQLiteConnection("Data Source=KarteiDB.sqlite;Version=3;");
            m_dbConnection.Open();
          //  string sql = "SELECT Frage FROM Karten";
            //   string sql = "CREATE TABLE Karten(id int);";


            string sql = "select Frage from Karten";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            Boolean vorhanden = reader.Read();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["Frage"] );




            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            string erg = "";
            //Boolean vorhanden = reader.Read();
            //Console.WriteLine("bool:"  + vorhanden);

            //while (reader.Read())
            //{
            //    //     Console.WriteLine("Frage: " + reader["Frage"]);

            //    Console.WriteLine("Frage: " + reader["Frage"]);

            //}
            m_dbConnection.Close();

            return erg;
        }
    }
}
