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
            comboBoxVon.DroppedDown = true;

        }

        private void comboBoxNach_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verbindung(comboBoxNach);
            comboBoxNach.DroppedDown = true;
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

            foreach (var s in stationList)
            {
                if (s.Name != null)
                {
                    box.Items.Add(s.Name);
                }
            }
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            List<Connection> connectionPointsList = transport.GetConnections(comboBoxVon.Text, comboBoxNach.Text).ConnectionList;

            listViewVerbindungen.Items.Clear();

            foreach (var s in connectionPointsList)
            {
                if (s.Duration != null)
                {
                    var departureAb = DateTime.Parse(s.From.Departure);
                    var departureAn = DateTime.Parse(s.To.Arrival);
                    listViewVerbindungen.Items.Add("Von: " + s.From.Station.Name + "        Abfahrt: " + departureAb + "        Ankunft: " + departureAn + "        Nach: " + s.To.Station.Name);
                    listViewVerbindungen.Items.Add("");
                }
            }
        }

        private void comboBoxVon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verbindung(comboBoxVon2);
            comboBoxVon2.DroppedDown = true;
        }

        private void buttonSuchen2_Click(object sender, EventArgs e)
        {
            List<StationBoard> StationBoardList = transport.GetStationBoard(comboBoxVon2.Text, string.Empty).Entries;

            listBoxAnschluesse.Items.Clear();

            foreach (var s in StationBoardList)
            {
                if (s.Name != null)
                {
                    listBoxAnschluesse.Items.Add("Von: " + comboBoxVon2.Text + "        Nach: " + s.To);
                    listBoxAnschluesse.Items.Add("");
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControl.SelectedIndex == 0)
            {
                this.AcceptButton = buttonSuchen;
            }
            if (this.tabControl.SelectedIndex == 1)
            {
                this.AcceptButton = buttonSuchen2;
            }
            if (this.tabControl.SelectedIndex == 2)
            {
                this.AcceptButton = buttonSuchen3;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZeit.Text = DateTime.Now.ToLongTimeString();
        }

        private void WindowsFenster_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
