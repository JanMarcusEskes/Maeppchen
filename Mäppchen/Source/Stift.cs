using System;
using System.Windows.Forms;

namespace Mäppchen
{
    class Stift
    {
        private String farbe;
        private String zustand;
        private Double länge;
        private String material;
        private int benutzungen = 0;
        private String[] farben = { "Blau", "Rot", "Grün", "Gelb", "Lila", "Braun", "Regenbogen" };
        private String[] zustände = { "Spitz", "Flach", "Marker" };
        private String[] materialien = { "Filsstift", "Wachsmalstift", "Edding", "Buntstift", "Bleistift", "Füller" };

        public String Farbe
        {
            get { return farbe; }
        }
        public String Zustand
        {
            get { return zustand; }
        }
        public Double Länge
        {
            get { return länge; }
        }
        public String Material
        {
            get { return material; }
        }

        public Stift()
        {
            Random r = new Random(DateTime.Now.Ticks.GetHashCode());
            material = materialien[r.Next(0, materialien.Length - 1)];
            if (material == "Filsstift" || material == "Edding")
            {
                länge = 14;
                farbe = farben[r.Next(0, farben.Length - 1)];
                zustand = zustände[r.Next(0, zustände.Length - 1)];
            }
            else if (material == "Bleistift")
            {
                farbe = "Grau";
                zustand = zustände[r.Next(0, zustände.Length - 1)];
                länge = r.Next(1, 15);
            }
            else if (material == "Füller")
            {
                farbe = "Blau";
                länge = 15;
                zustand = "Feder";
            }
            else
            {
                farbe = farben[r.Next(0, farben.Length - 1)];
                zustand = zustände[r.Next(0, zustände.Length - 1)];
                länge = r.Next(1, 15);
            }

        }
        public bool Benutzen()
        {
            if (länge < 0.1)
            {
                MessageBox.Show("Der Stift wurde komplett verbraucht", "Stift weg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (material != "Füller" && material != "Filsstift" && material != "Edding")
            {
                länge -= 0.1;
                if (benutzungen > 10)
                    zustand = "stumpf";
            }
            return true;
        }
        public bool Spitzen()
        {
            if (länge < 0.1)
            {
                MessageBox.Show("Der Stift wurde komplett verbraucht", "Stift weg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (material != "Füller" && material != "Filsstift" && material != "Edding")
            {
                länge -= 0.1;
                benutzungen = 0;
                zustand = "spitz";
            }
            return true;
        }

        public static ListViewItem ToListViewItem(Mäppchen m, Stift s)
        {
            ListViewItem lstvItem = new ListViewItem();
            lstvItem.Name = m.Inhalt.IndexOf(s).ToString();
            lstvItem.Text = "Stift";
            lstvItem.SubItems.Add(s.Material);
            lstvItem.SubItems.Add(s.Farbe);
            lstvItem.SubItems.Add(s.Zustand);
            lstvItem.SubItems.Add(s.Länge.ToString());

            return lstvItem;
        }
    }
}
