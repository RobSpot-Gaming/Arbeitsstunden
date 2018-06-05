using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arbeitsstunden
{

    public class Steuerung
    {
        MitgliederVerwaltung dieMitgliederVerwaltung;
        Form1 Home;

        Datenbank dieDatenbank;
        public Steuerung()
        {
            dieDatenbank = new Datenbank();
            Application.Run(Home = new Form1(this));
            
        }

        public void schowMitgliederVerwaltung()
        {
            Application.Run(dieMitgliederVerwaltung = new MitgliederVerwaltung(dieDatenbank));
        }
    }
}
