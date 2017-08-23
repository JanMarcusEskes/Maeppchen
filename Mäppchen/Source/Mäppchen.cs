using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mäppchen
{
    class Mäppchen
    {
        //Lokale Variabelen
        private String material;
        private String form;
        private int halter;
        private bool offen;
        private int maxStifte;
        private List<Stift> inhalt = new List<Stift>();
        private String[] farben = { "Blau", "Rot", "Grün", "Gelb", "Lila", "Braun", "Regenbogen", "Kackbraun" };
        //Öffentliche Variabelen
        public String Farbe;
        public String Material
        {
            get { return material; }
        }
        public String Form
        {
            get { return form; }
        }
        public int MaxStifte
        {
            get { return maxStifte; }
        }
        public List<Stift> Inhalt
        {
            get { return inhalt; }
        }
        public bool Offen
        {
            get { return offen; }
        }
        //Statiche Öffentliche
        public static List<Mäppchen> AlleMäppchen = new List<Mäppchen>();

        //Öffenbtliche Methoden
        public Mäppchen(string Material, string Form, int MaxStifte)
        {
            material = Material;
            if (material == String.Empty)
                material = "Poliester";
            form = Form;
            if (form == String.Empty)
                form = "Rechteckig";
            maxStifte = MaxStifte;
            Farbe = farben[new Random(DateTime.Now.Ticks.GetHashCode()).Next(0, farben.Length - 1)];
        }
        public Stift StiftRausnehmen()
        {
            Stift rückgabe = inhalt.Last();
            inhalt.Remove(rückgabe);
            return rückgabe;
        }
        public bool StiftReinlegen(Stift stift)
        {
            if (inhalt.Count > maxStifte)
                return false;
            else
                inhalt.Add(stift);
            return true;
        }
        public void Öffnen()
        {
            offen = true;
        }
        public void Schließen()
        {
            offen = false;
        }
        //Statiche Methoden
        public static ListViewItem ToListViewItem(Mäppchen m)
        {
            ListViewItem lstvItem = new ListViewItem();
            lstvItem.Name = AlleMäppchen.IndexOf(m).ToString();
            lstvItem.Text = m.Material;
            lstvItem.SubItems.Add(m.Farbe);
            lstvItem.SubItems.Add(m.Form);
            lstvItem.SubItems.Add(m.Offen.ToString());
            lstvItem.SubItems.Add(m.MaxStifte.ToString());
            lstvItem.SubItems.Add(m.Inhalt.Count.ToString());

            return lstvItem;
        }
    }
}
