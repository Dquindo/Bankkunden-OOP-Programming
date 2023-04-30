using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankkunden
{
    public partial class Form1 : Form
    {
        Person pers1 = new Person(1,"Willi", "25372635");
        Person pers2 = new Person(2, "Tobi", "634857264");
        Person pers3 = new Person(3, "paul", "68157264");
        Person pers4 = new Person(4, "timm", "63035223");

        Bankkonto konto1 = new Bankkonto("11223344", "1234", 1005.50f);
        Bankkonto konto2 = new Bankkonto("22334455", "2345", 1500.50f);
        Bankkonto konto3 = new Bankkonto("33445566", "3456", 14500.50f);
        Bankkonto konto4 = new Bankkonto("44556677", "4567", 1000.50f);

        Fachartikel art1 = new Fachartikel(1, "Artikel1", "text1", "thema1", "01.02.01", true, 1);
        Fachartikel art2 = new Fachartikel(2, "Artikel2", "text2", "thema2", "01.02.02", true, 2);
        Fachartikel art3 = new Fachartikel(3, "Artikel3", "text3", "thema3", "01.02.03", true, 1);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pers1.setPassword("12345678");
            //textBox1.Text = 
            pers1.setEmail("al.do@sushi");


            textBox1.Text = "";
            pers1.DatenAusgeben(textBox1);
            pers2.DatenAusgeben(textBox1);
            pers3.DatenAusgeben(textBox1);
            pers4.DatenAusgeben(textBox1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pers1.bankkonto1 = konto1;
            pers2.bankkonto1 = konto2;
            pers3.bankkonto1 = konto3;
            pers4.bankkonto1 = konto4;

            pers1.DatenAusgeben(textBox1);
            pers2.DatenAusgeben(textBox1);
            pers3.DatenAusgeben(textBox1);
            pers4.DatenAusgeben(textBox1);

        }
       
            
        class Person
        {
            //Attribute
            public int ID;
            public string name;
            public string Telephonnummer;
            public Bankkonto bankkonto1;
            private string passwort = "qwertz";
            private string email= "Alt.test@Test";

            //Konstruktor
            public Person(int ID, string name, string Telephonnummer)
            {
                this.ID = ID;
                this.name = name;
                this.Telephonnummer = Telephonnummer;
                
            }
            //Setter und Getter
            public void setPassword(string passwort)
            {
                if (passwort.Length > 8)
                {
                    this.passwort = passwort;
                }
                else
                {
                    //Fehlermeldung
                }
            }
            public string getPasswort() { return this.passwort; }

            public void setEmail(string email)
            {
                if (email.Contains("@"))
                {
                    this.email = email;
                }
                else
                {
                    //Fehlermeldung
                }
            }
            public string getEmail() { return this.email; }

            //Methoden
            public void DatenAusgeben(TextBox TxtBox)
            {
                TxtBox.Text += this.ID + "  " + this.name + " Tel.:" + this.Telephonnummer + "\r\n";
                bankkonto1.datenAusgeben(TxtBox);
            }
        }
        class Bankkonto
        {
            //Attribute
            public string kontonummer;
            public string pin;
            public float guthaben;

            //Konstruktor
            public Bankkonto(string kontonummer, string pin, float guthaben)
            {
                this.kontonummer = kontonummer;
                this.pin = pin;
                this.guthaben = guthaben;
            }

            public void datenAusgeben(TextBox txtBox)
            {
                txtBox.Text += "Kontodaten: " + this.kontonummer + " " + this.pin + " " + this.guthaben + "\r\n\r\n";
            }

            public void einzahlen(float betrag)
            {
                this.guthaben = this.guthaben + betrag;
            }
            public void auszahlen(float betrag)
            {
                this.guthaben = this.guthaben - betrag;
            }

        }
        class Fachartikel
        {
            //Attribute
            public int id;
            //public string[]autor;
            public string title;
            public string text;
            public string thema;
            public string date;
            public bool published;
            public int bewertung;

            //Konstruktor
            public Fachartikel (int id,string title,string text,string thema, string date, bool published,int bewertung)
            {
                this.id = id;
                //this.autor = autor;
                this.title = title;
                this.text = text;
                this.thema = thema;
                this.date = date;
                this.published = published;
                this.bewertung = bewertung;

            }
            //Methoden
            public void datenAusgeben(TextBox txtBox)
            {
                txtBox.Text += "Fachartikel: " + this.id + this.title + this.text + this.thema + this.date + this.published + this.bewertung;
            }

            public void publishing()
            {

            }
            public void withdraw()
            {

            }

            public void bewerten(int x)
            {

            }

        }

    }
}
