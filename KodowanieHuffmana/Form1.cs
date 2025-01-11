using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KodowanieHuffmana
{
    public partial class EncodingForm : Form
    {
        public EncodingForm()
        {
            InitializeComponent();
        }

        private void PrzyciskKodowania(object sender, EventArgs e)
        {
            string tekstDoZakodowania = poleTekstuDoZakodowania.Text;

            if (string.IsNullOrWhiteSpace(tekstDoZakodowania))
            {
                MessageBox.Show("Blad podaj kod do zakodowania");
                return;
            }

            char[] znaki;
            int[] czestotliwosc;
            LiczenieCzestotliwosci(tekstDoZakodowania, out znaki, out czestotliwosc);

            Node rootNode = TworzenieDrzewa(znaki, czestotliwosc);

            string[] kodyHuffmana = new string[znaki.Length];
            GenerujKodHuffmana(rootNode, "", kodyHuffmana, znaki);

            WypelnianieListBox(znaki, kodyHuffmana);

            string zakodowanyKod = ZakodujTekst(tekstDoZakodowania, znaki, kodyHuffmana);
            poleZakodowanegoTekstu.Text = zakodowanyKod;
        }

        private void LiczenieCzestotliwosci(string input, out char[] znaki, out int[] czestotliwosci)
        {
            List<char> listaZnakow = new List<char>();
            List<int> listaCzestotliwosci = new List<int>();

            foreach (char character in input)
            {
                int index = listaZnakow.IndexOf(character);
                if (index == -1)
                {
                    listaZnakow.Add(character);
                    listaCzestotliwosci.Add(1);
                }
                else
                {
                    listaCzestotliwosci[index]++;
                }
            }

            znaki = listaZnakow.ToArray();
            czestotliwosci = listaCzestotliwosci.ToArray();
        }

        private Node TworzenieDrzewa(char[] znaki, int[] czestotliwosci)
        {
            List<Node> nodes = new List<Node>();

            for (int i = 0; i < znaki.Length; i++)
            {
                nodes.Add(new Node { symbol = znaki[i], czestotliwosc = czestotliwosci[i] });
            }

            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(node => node.czestotliwosc).ToList();
                var leftNode = nodes[0];
                var rightNode = nodes[1];

                var parentNode = new Node
                {
                    czestotliwosc = leftNode.czestotliwosc + rightNode.czestotliwosc,
                    lewo = leftNode,
                    prawo = rightNode
                };

                nodes.RemoveAt(0);
                nodes.RemoveAt(0);
                nodes.Add(parentNode);
            }

            return nodes[0];
        }

        private void GenerujKodHuffmana(Node node, string aktualnyKod, string[] codes, char[] znaki)
        {
            if (node == null)
                return;

            if (node.lewo == null && node.prawo == null)
            {
                int index = Array.IndexOf(znaki, node.symbol);
                codes[index] = aktualnyKod;
                return;
            }

            GenerujKodHuffmana(node.lewo, aktualnyKod + "0", codes, znaki);
            GenerujKodHuffmana(node.prawo, aktualnyKod + "1", codes, znaki);
        }

        private void WypelnianieListBox(char[] znaki, string[] kody)
        {
            poleKoduLiter.Items.Clear();

            for (int i = 0; i < znaki.Length; i++)
            {
                poleKoduLiter.Items.Add($"{znaki[i]}: {kody[i]}");
            }
        }

        private string ZakodujTekst(string input, char[] znaki, string[] kody)
        {
            string wynik = "";

            foreach (char znak in input)
            {
                int index = Array.IndexOf(znaki, znak);
                wynik += kody[index];
            }

            return wynik;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}

