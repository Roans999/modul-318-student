using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBR_App
{
    public partial class WindowsFenster : Form
    {
        private Transport transport = new Transport();

        public WindowsFenster()
        {
            InitializeComponent();
        }

        private void comboBoxVon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verbindung(comboBoxVon);

        }

        private void comboBoxNach_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verbindung(comboBoxNach);
        }

        private void Verbindung (ComboBox box)
        {
            int f = box.Items.Count;

            while (box.Items.Count > 0)
            {
                box.Items.RemoveAt(0);
            }

            string suchText = box.Text;
            List<Station> stationList = transport.GetStations(suchText).StationList;
            Console.WriteLine(stationList);

            foreach (var s in stationList)
            {
                if (s.Name != null)
                {
                    box.Items.Add(s.Name);
                }
            }
        }
    }
}
