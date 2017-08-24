using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mäppchen
{
    public partial class MäppchenInhalt : Form
    {
        private Mäppchen ausgewähltesMäppchen;

        public MäppchenInhalt(string auswahl)
        {
            InitializeComponent();
            ausgewähltesMäppchen = Mäppchen.AlleMäppchen[int.Parse(auswahl)];
            txtFarbe.Text = ausgewähltesMäppchen.Farbe;
            btnÖffnenSchließen_Click(null, null);
            btnÖffnenSchließen_Click(null, null);
            RefreshListView();
        }

        private void RefreshListView()
        {
            lstvStifte.Items.Clear();

            List<ListViewItem> lstvItems = new List<ListViewItem>();
            foreach (Stift stift in ausgewähltesMäppchen.Inhalt)
            {
                lstvItems.Add(Stift.ToListViewItem(ausgewähltesMäppchen, stift));
            }

            lstvStifte.Items.AddRange(lstvItems.ToArray());
        }
        private void btnAnmalen_Click(object sender, System.EventArgs e)
        {
            if (txtFarbe.Text == string.Empty)
                MessageBox.Show("Du musst schon eine Farbe eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ausgewähltesMäppchen.Farbe = txtFarbe.Text;
        }
        private void btnÖffnenSchließen_Click(object sender, System.EventArgs e)
        {
            if (ausgewähltesMäppchen.Offen)
            {
                ausgewähltesMäppchen.Schließen();
                btnÖffnenSchließen.Text = "Öffnen";
                btnAddStift.Enabled = false;
                btnRemoveStift.Enabled = false;
            }
            else
            {
                ausgewähltesMäppchen.Öffnen();
                btnÖffnenSchließen.Text = "Schließen";
                btnAddStift.Enabled = true;
                btnRemoveStift.Enabled = true;
            }
        }
        private void btnAddStift_Click(object sender, System.EventArgs e)
        {
            if (ausgewähltesMäppchen.Inhalt.Count < ausgewähltesMäppchen.MaxStifte)
                ausgewähltesMäppchen.Inhalt.Add(new Stift());
            else
                MessageBox.Show("Es ist die maximale Anzahln von Stiften im Mäppchen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshListView();
        }
        private void btnRemoveStift_Click(object sender, System.EventArgs e)
        {
            if (ausgewähltesMäppchen.Inhalt.Count > 0)
            {
                Random r = new Random(DateTime.Now.Ticks.GetHashCode());
                ausgewähltesMäppchen.StiftRausnehmen(ausgewähltesMäppchen.Inhalt[r.Next(0, ausgewähltesMäppchen.Inhalt.Count - 1)]);
                RefreshListView();
            }
        }

        private void lstvStifte_DoubleClick(object sender, EventArgs e)
        {
            if (lstvStifte.SelectedItems.Count == 1 && ausgewähltesMäppchen.Offen)
            {
                if (!ausgewähltesMäppchen.Inhalt[int.Parse(lstvStifte.SelectedItems[0].Name)].Benutzen())
                    ausgewähltesMäppchen.StiftRausnehmen(ausgewähltesMäppchen.Inhalt[int.Parse(lstvStifte.SelectedItems[0].Name)]);

                RefreshListView();

            }
        }
    }
}
