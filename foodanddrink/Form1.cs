using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodanddrink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public string currentindexfood = "";
        public string currentindexfoods = "";
        public string currentindexfoodsortiment = "";
        public string currentindexdrink = "";
        public string currentindexdrinks = "";
        public string currentindexdrinksortiment = "";


        public class element
        {
            
            public string denumire = "";
            public float pret = 0.0f;
            public float cantitate = 0.0f;
            public string subtip = "";
            public string codunic = "";
            public element(string d, float p, float c, string st, string cu)
            {
                this.denumire = d;
                this.pret = p;
                this.cantitate = c;
                this.subtip = st;
                this.codunic = cu;
            }
        }
        public class categorie
        {
            public string denumire = "";
            public string tip = "";
            public categorie(string d, string t)
            {
                this.denumire = d;
                this.tip = t;
            }
        }
        public class subcategorie
        {
            public string denumire = "";
            public string tip = "";
            public string subtip = "";
            public subcategorie(string d, string t, string st) {
                this.denumire = d;
                this.tip = t;
                this.subtip = st;
            }
        }

        public List<categorie> food = new List<categorie>();
        public List<subcategorie> foods = new List<subcategorie>();
        public List<element> foodsortiment = new List<element>();

        public List<categorie> drink = new List<categorie>();
        public List<subcategorie> drinks = new List<subcategorie>();
        public List<element> drinksortiment = new List<element>();


        public void loaddatasfood()
        {
            food.Add(new categorie("panificatie","1"));
            food.Add(new categorie("lactate", "2"));
            food.Add(new categorie("fructe", "3"));
            food.Add(new categorie("legume", "4"));
            food.Add(new categorie("vegetale", "5"));
            food.Add(new categorie("carne", "6"));
            food.Add(new categorie("peste", "7"));
            food.Add(new categorie("fructedemare", "8"));
            food.Add(new categorie("apicol", "9"));
            food.Add(new categorie("naturist", "10"));
            food.Add(new categorie("ceai", "11"));
            food.Add(new categorie("dulciuri", "12"));
        }
        public void loaddatasfoods(int i)
        {
            foods.Add(new subcategorie("paine","1","1"));
            foods.Add(new subcategorie("franzela", "1", "2"));
            foods.Add(new subcategorie("lapte", "2", "3"));
            foods.Add(new subcategorie("iaurt", "2", "4"));
            foods.Add(new subcategorie("mere", "3", "5"));
            foods.Add(new subcategorie("pere", "3", "6"));
            foods.Add(new subcategorie("banane", "4", "7"));
            foods.Add(new subcategorie("cartofi", "4", "8"));
            foods.Add(new subcategorie("rosi", "4", "9"));
            foods.Add(new subcategorie("ceapa", "4", "10"));
            foods.Add(new subcategorie("mici", "6", "11"));
            foods.Add(new subcategorie("burger", "6", "12"));
            foods.Add(new subcategorie("salam", "6", "13"));
            foods.Add(new subcategorie("crap", "7", "14"));
            foods.Add(new subcategorie("somon", "7", "15"));
            foods.Add(new subcategorie("languste", "8", "16"));
            foods.Add(new subcategorie("caracatita", "8", "17"));
            foods.Add(new subcategorie("sepie", "8", "18"));
            foods.Add(new subcategorie("miere", "9", "19"));
            foods.Add(new subcategorie("seminte", "10", "20"));
            foods.Add(new subcategorie("tei", "11", "21"));
            foods.Add(new subcategorie("soc", "11", "22"));
            foods.Add(new subcategorie("menta", "11", "23"));
            foods.Add(new subcategorie("tort", "12", "24"));
            foods.Add(new subcategorie("bomboane", "12", "25"));
            foods.Add(new subcategorie("ciocolata", "12", "26"));
            foods.Add(new subcategorie("prajitura", "12", "27"));


        }

        public void loaddatasfoodssortiments(int i)
        {
            foodsortiment.Add(new element("paine feliata 100 grame",4.50f,10.00f,"1","00000000001"));
            foodsortiment.Add(new element("lapte 1000ml", 3.50f, 14.00f, "3", "00000000002"));
        }

            public void loaddatasdrink()
        {
            drink.Add(new categorie("bere", "1"));
            drink.Add(new categorie("vinuri", "2"));
            drink.Add(new categorie("fructe naturale", "3"));
            drink.Add(new categorie("legume naturale", "4"));
            drink.Add(new categorie("ceaiuri", "5"));
            drink.Add(new categorie("alcoolice", "6"));
            drink.Add(new categorie("lactate", "7"));
            drink.Add(new categorie("spirtoase", "8"));
            drink.Add(new categorie("cafele", "9"));
            drink.Add(new categorie("naturiste", "10"));
            drink.Add(new categorie("dulci", "11"));
            drink.Add(new categorie("ape", "12"));

            
        }
        public void refreshall()
        {
            //reset all datas
            this.comboBox1.Items.Clear(); // food
            this.comboBox2.Items.Clear(); //drink
            this.comboBox3.Items.Clear(); //foods
            this.comboBox4.Items.Clear(); // drinks
            this.comboBox5.Items.Clear(); //foodsortiment
            this.comboBox6.Items.Clear(); //drinksortiment
            this.comboBox1.ResetText();
            this.comboBox2.ResetText();
            this.comboBox3.ResetText();
            this.comboBox4.ResetText();
            this.comboBox5.ResetText();
            this.comboBox6.ResetText();
            this.textBox1.Text = "";
            this.label10.Text = "";
            this.label11.Text = "";
            this.label12.Text = "";
            this.label13.Text = "";
            this.currentindexfood = "";
            this.currentindexfoods = "";
            this.currentindexfoodsortiment = "";
            this.currentindexdrink = "";
            this.currentindexdrinks = "";
            this.currentindexdrinksortiment = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {


            this.refreshall();
            Refresh();
            

            //load all datas into combos
            for (int i = 0; i < food.Count; i++)
            {
                this.comboBox1.Items.Add(food[i].denumire);

            }
            for (int i = 0; i < drink.Count; i++)
            {
                this.comboBox2.Items.Add(drink[i].denumire);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox3.Items.Clear(); //foods
            for (int i = 0; i < foods.Count; i++)
            {
                
                if (this.label10.Text  == foods[i].tip.ToString())
                {
                    this.comboBox3.Items.Add(foods[i].denumire);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            try
            {
                this.label10.Text = (comboBox1.SelectedIndex+1).ToString();
                currentindexfood = this.label10.Text;
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddatasdrink();
            loaddatasfood();
            loaddatasfoods(0);
            loaddatasfoodssortiments(0);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            Refresh();
            try
            {
                //asta nu functioneaza . ar trebui ca indexul sa fie preluat din foods
                //acest index ar trebui sa fie food[i].tip sau foods[i].subtip nu indexul afisat in combo
               
                this.label11.Text = (comboBox3.SelectedIndex + 1).ToString();
                
            }
            catch { }
        }

        public List<string> indexcodunicsortiment = new List<string>();

        private void button3_Click(object sender, EventArgs e)
        {
            this.comboBox5.Items.Clear(); //foods sortiments
            indexcodunicsortiment.Clear(); //clear idx
            for (int i = 0; i < foodsortiment.Count; i++)
            {
                
                if (this.label11.Text == foodsortiment[i].subtip.ToString())
                {
                    indexcodunicsortiment.Add(foodsortiment[i].codunic);
                    
                    this.comboBox5.Items.Add(foodsortiment[i].denumire);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            currentindexfoodsortiment = this.label12.Text;

            textBox1.Text += "\r\n" + "Denumire: " + "\t" + "\r\n" +  foodsortiment[int.Parse(this.label13.Text) - 1].denumire;
            textBox1.Text += "\r\n" + "Pret: " + "\t" + "\r\n" + foodsortiment[int.Parse(this.label13.Text) - 1].pret.ToString();
            textBox1.Text += "\r\n" + "Cantitate: " + "\t" + "\r\n" + foodsortiment[int.Parse(this.label13.Text) - 1].cantitate.ToString();
            textBox1.Text += "\r\n" + "Subtip: " + "\t" + "\r\n" + foodsortiment[int.Parse(this.label13.Text) - 1].subtip.ToString();
            textBox1.Text += "\r\n" + "CodUnic: " + "\t" + "\r\n" + foodsortiment[int.Parse(this.label13.Text) - 1].codunic.ToString();


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            try
            {
                this.label12.Text = (comboBox5.SelectedIndex + 1).ToString();
                this.label13.Text= indexcodunicsortiment[comboBox5.SelectedIndex];
            }
            catch { }
        }
        
        public List<string> elementul = new List<string>();
        public List<string> elementeleselectate = new List<string>();
        private void button5_Click(object sender, EventArgs e)
        {
            elementul.Clear();
            elementul.Add(foodsortiment[int.Parse(this.label13.Text) - 1].denumire);
            elementul.Add(foodsortiment[int.Parse(this.label13.Text) - 1].pret.ToString());
            elementul.Add(foodsortiment[int.Parse(this.label13.Text) - 1].cantitate.ToString());
            elementul.Add(foodsortiment[int.Parse(this.label13.Text) - 1].subtip.ToString());
            elementul.Add(foodsortiment[int.Parse(this.label13.Text) - 1].codunic.ToString());

            elementeleselectate.Add(elementul[0] + "," + elementul[1] + "," + elementul[2] + "," + elementul[3] + "," + elementul[4]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < elementeleselectate.Count; i++)
            {
                textBox1.Text += elementeleselectate[i]+"\r\n";
            }
        }
    }
}
