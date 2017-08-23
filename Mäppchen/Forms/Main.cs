using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mäppchen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnErstelle_Click(object sender, EventArgs e)
        {
            Mäppchen m = new Mäppchen(txtMaterial.Text, txtForm.Text, int.Parse(nudMaxStifte.Value.ToString()));
            Mäppchen.AlleMäppchen.Add(m);
            RefreshList();
        }
        private void RefreshList()
        {
            lstvMäppchen.Items.Clear();

            List<ListViewItem> lstvItems = new List<ListViewItem>();
            foreach (Mäppchen mäppchen in Mäppchen.AlleMäppchen)
            {
                lstvItems.Add(Mäppchen.ToListViewItem(mäppchen));
            }

            lstvMäppchen.Items.AddRange(lstvItems.ToArray());
        }

        private void lstvMäppchen_DoubleClick(object sender, EventArgs e)
        {
            if (lstvMäppchen.SelectedItems.Count == 1)
            {
                MäppchenInhalt mäppcheninhalt = new MäppchenInhalt(lstvMäppchen.SelectedItems[0].Name);
                mäppcheninhalt.ShowDialog();
                RefreshList();
            }
        }
    }
}
