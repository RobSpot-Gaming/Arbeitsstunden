using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Arbeitsstunden
{
    public class Datenbank
    {
        SQLiteConnection myDBConnection;

        /// <summary>
        /// Hier wird, falls nicht vorhanden eine neue Datenbank erstellt. Danach wird eine Verbindung zu der Datenbank aufgebaut und die Tabllen eingerichtet.
        /// </summary>
        public Datenbank()
        {
            //SQLiteConnection.CreateFile("Arbeitsstunden.sqlite");
            myDBConnection = new SQLiteConnection("Data Source=Arbeitsstunden.sqlite;Version=3;");
            myDBConnection.Open();

            createStructure();

        }

        /// <summary>
        /// Falls die Datenbank neu erstellt wird, werden hier die benötigten Tabellen angelegt.
        /// </summary>
        private void createStructure()
        {
            executeCommand("CREATE TABLE IF NOT EXISTS mitglied (nummer int, vName varchar(20), name varchar(20), arbeitsstunden int);");

            executeCommand("CREATE TABLE IF NOT EXISTS arbeitseinsatz (nummer int, name varchar(20), datum string, dauer int, verantwortlicher int);");
        }

        /// <summary>
        /// Hierbei wird ein String in einen SQL-Command verwandelt und ausgeführt.
        /// </summary>
        /// <param name="pSQL">Der Befehl als String, welcher später ausgeführt wird.</param>
        private void executeCommand(string pSQL)
        {
            SQLiteCommand command = new SQLiteCommand(pSQL, myDBConnection);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Wandelt ein Datumsformat in einen String um, damit man diesen in die Datenbank speichern kann.
        /// </summary>
        /// <param name="datetime">Datum, welches zum String umgewandelt werden soll.</param>
        /// <returns></returns>
        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }




        public DataSet DataAdapter(string sqlAbfrage)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(sqlAbfrage, myDBConnection);
            DataSet ds = new System.Data.DataSet();

            dataadapter.Fill(ds, "mitglied");
            return ds;
        }

        public void insert(string pTable, string pSpalten, string pDaten)
        {
            SQLiteCommand command = new SQLiteCommand(myDBConnection);
            command.CommandText = "INSERT INTO " + pTable + " (" + pSpalten + ") VALUES("+ pDaten + ")";
            command.ExecuteNonQuery();
        }
    }
}
