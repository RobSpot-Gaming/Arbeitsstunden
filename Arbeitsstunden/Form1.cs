using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitsstunden
{
    public partial class Form1 : Form
    {
        Steuerung dieSteuerung;
        System.Threading.Thread mitgliederVerwaltung;

        public Form1(Steuerung pSteuerung)
        {
            InitializeComponent();
            dieSteuerung = pSteuerung;
        }

        private void btn_mitgliederVerwaltung_Click(object sender, EventArgs e)
        {
            mitgliederVerwaltung = new System.Threading.Thread(new System.Threading.ThreadStart(dieSteuerung.schowMitgliederVerwaltung));
            mitgliederVerwaltung.Start();
        }
    }
}
