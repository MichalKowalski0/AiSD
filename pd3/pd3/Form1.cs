using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pd3
{
    public partial class Form1 : Form
    {
        private List<LinkedList<int>> listy = new List<LinkedList<int>>();
        private int aktualnaLista = 0;

        public Form1()
        {
            InitializeComponent();
            AktualizujWidokListy();
        }

        private void UtworzListe_Click(object sender, EventArgs e)
        {
            listy.Add(new LinkedList<int>());
            aktualnaLista = listy.Count - 1;
            numerListyUpDown.Value = aktualnaLista;
            AktualizujWidokListy();
        }

        private void DodajNaPoczatek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(liczbyTextBox.Text, out int liczba) && listy.Count > 0)
            {
                listy[aktualnaLista].AddFirst(liczba);
                AktualizujWidokListy();
            }
        }

        private void DodajNaKoniec_Click(object sender, EventArgs e)
        {
            if (int.TryParse(liczbyTextBox.Text, out int liczba) && listy.Count > 0)
            {
                listy[aktualnaLista].AddLast(liczba);
                AktualizujWidokListy();
            }
        }

        private void UsunPoczatek_Click(object sender, EventArgs e)
        {
            if (listy.Count > 0 && listy[aktualnaLista].Count > 0)
            {
                listy[aktualnaLista].RemoveFirst();
                AktualizujWidokListy();
            }
        }

        private void UsunKoniec_Click(object sender, EventArgs e)
        {
            if (listy.Count > 0 && listy[aktualnaLista].Count > 0)
            {
                listy[aktualnaLista].RemoveLast();
                AktualizujWidokListy();
            }
        }

        private void UsunListe_Click(object sender, EventArgs e)
        {
            if (listy.Count > 0)
            {
                listy.RemoveAt(aktualnaLista);
                aktualnaLista = Math.Max(0, listy.Count - 1);
                numerListyUpDown.Value = aktualnaLista;
                AktualizujWidokListy();
            }
        }

        private void NumerListyUpDown_ValueChanged(object sender, EventArgs e)
        {
            aktualnaLista = (int)numerListyUpDown.Value;
            if (aktualnaLista >= listy.Count)
            {
                aktualnaLista = listy.Count - 1;
                numerListyUpDown.Value = aktualnaLista;
            }
            AktualizujWidokListy();
        }

        private void AktualizujWidokListy()
        {
            widokListyTextBox.Clear();
            for (int i = 0; i < listy.Count; i++)
            {
                string elementyListy = string.Join(", ", listy[i]);
                widokListyTextBox.AppendText($"lista{i + 1}: ({elementyListy})\n");
            }
        }
    }
}

