using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Arbeitsstunden
{
    class Datenbank
    {
        SQLiteConnection myDBConnection;
        public Datenbank()
        {
            SQLiteConnection.CreateFile("Arbeitsstunden.sqlite");
            myDBConnection = new SQLiteConnection("Data Source=Arbeitsstunden.sqlite;Version=3;");
            myDBConnection.Open();

            createStructure();

        }

        private void createStructure()
        {
            executeCommand("create table mitglied (nummer int, vName varchar(20), name varchar(20), arbeitsstunden int)");

            executeCommand("create table arbeitseinsatz (nummer int, name varchar(20), datum string, dauer int, verantwortlicher int)");

        }

        /// <summary>
        /// Hierbei wird ein String in einen SQL-Command verwandelt und ausgeführt.
        /// </summary>
        /// <param name="pSQL"></param>
        private void executeCommand(string pSQL)
        {
            SQLiteCommand command = new SQLiteCommand(pSQL, myDBConnection);
            command.ExecuteNonQuery();
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }
    }
}
