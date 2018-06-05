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
    public partial class MitgliederVerwaltung : Form
    {
        Datenbank dieDatenbank;

        public MitgliederVerwaltung(Datenbank pDatenbank)
        {
            InitializeComponent();
            dieDatenbank = pDatenbank;
            dataGridView1.DataSource = dieDatenbank.DataAdapter("SELECT * FROM mitglied");
        }
    }
}
