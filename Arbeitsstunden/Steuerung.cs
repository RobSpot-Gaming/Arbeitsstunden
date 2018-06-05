using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arbeitsstunden
{
    class Steuerung
    {
        Datenbank dieDatenbank;
        public Steuerung()
        {
            Form1 Home;
            Application.Run(Home = new Form1());
            dieDatenbank = new Datenbank();
        }
    }
}
