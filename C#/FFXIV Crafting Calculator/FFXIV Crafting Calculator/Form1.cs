using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FFXIV_Crafting_Calculator
{
    public partial class Form1 : Form
    {
        bool musicPlaying = false;

        List<string> _requiredItems = new List<string>();

        SoundPlayer musicPlayer = new System.Media.SoundPlayer(Properties.Resources.BGM_Event_Ansoku1);

        Item[] shopitems = { 
                               new Item { Name = "Copper Ingot", Price = 9, fromShop = true },      // 0
                               new Item { Name = "Bronze Ingots", Price = 9, fromShop = true },     // 1
                               new Item { Name = "Bronze Rivets", Price = 4, fromShop = true  },    // 2 
                               new Item { Name = "Moko Grass", Price = 2, fromShop = true  },       // 3
                               new Item { Name = "Straw", Price = 9, fromShop = true  },            // 4 
                               new Item { Name = "Cotton Boll", Price = 10, fromShop = true  },     // 5
                               new Item { Name = "Cock Feather", Price = 4, fromShop = true  },     // 6
                               new Item { Name = "Leather", Price = 8, fromShop = true  },          // 7
                               new Item { Name = "Hard Leather", Price = 31, fromShop = true  },    // 8
                               new Item { Name = "Animal Sinew", Price = 4, fromShop = true  },     // 9
                               new Item { Name = "Beast Sinew", Price = 22, fromShop = true  },     // 10
                               new Item { Name = "Carnation", Price = 13, fromShop = true  },       // 11
                               new Item { Name = "Earth Shard" },                                   // 12
                               new Item { Name = "Fire Shard" },                                    // 13
                               new Item { Name = "Ice Shard" },                                     // 14
                               new Item { Name = "Lightning Shard" },                               // 15
                               new Item { Name = "Wind Shard" },                                    // 16
                               new Item { Name = "Water Shard" }                                    // 17
                           };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < shopitems.Length; i++)
            {
                shopitems[i].ClearQuantity();
            }
            listBox1.DataSource = _requiredItems;
            comboBox1.SelectedIndex = 0;

            System.Diagnostics.Debug.WriteLine(comboBox1.Items.Count + " items in comboBox1");

            lblMadeBy.Text = "Made By: Kitty Inkura\n-------------\nMidgardsormr";

            lblVersion.Location = new Point(191, 101);
            lblVersion.Height = 160;
            lblVersion.Width = 172;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _requiredItems.Clear();

            for (int i = 0; i < shopitems.Length; i++)
            {
                shopitems[i].ClearQuantity();
            }

            if (comboBox1.Text == "Hempen Yarn")
            {
                HempenYarn(1);
                // lblMaterials.Text = (shopitems[3].Quantity.ToString() + " Moko Grass");
            }
            else if (comboBox1.Text == "Undyed Hempen Cloth")
            {
                UndyedHempenCloth(1);
            }
            else if (comboBox1.Text == "Hempen Halfgloves")
            {
                HempenHalfgloves();
            }
            else if (comboBox1.Text == "Hempen Underpants")
            {
                HempenUnderpants();
            }
            else if (comboBox1.Text == "Hempen Pantalettes")
            {
                HempenPantalettes();
            }
            else if (comboBox1.Text == "Hempen Undershirt")
            {
                HempenUndershirt();
            }
            else if (comboBox1.Text == "Hempen Coif")
            {
                HempenCoif();
            }
            else if (comboBox1.Text == "Hempen Camise")
            {
                HempenCamise();
            }
            else if (comboBox1.Text == "Hempen Breeches of Crafting")
            {
                HempenBreechesofCrafting();
            }
            else if (comboBox1.Text == "Hempen Kurta")
            {
                HempenKurta();
            }
            else if (comboBox1.Text == "Hempen Coif of Gathering")
            {
                HempenCoifofGathering();
            }
            else if (comboBox1.Text == "Hempen Shepherd's Slops")
            {
                HempenShepherdsSlops();
            }
            else if (comboBox1.Text == "Hempen Dalmatica")
            {
                HempenDalmatica();
            }
            else if (comboBox1.Text == "Hempen Breeches")
            {
                HempenBreeches();
            }
            else if (comboBox1.Text == "Hempen Dalmatica of Gathering")
            {
                HempenDalmaticaofGathering();
            }
            else if (comboBox1.Text == "Hempen Tunic")
            {
                HempenTunic();
            }
            else if (comboBox1.Text == "Hempen Cowl")
            {
                HempenCowl();
            }
            else if (comboBox1.Text == "Hempen Sarouel")
            {
                HempenSarouel();
            }
            else if (comboBox1.Text == "Hempen Chausses")
            {
                HempenChausses();
            }
            else if (comboBox1.Text == "Hempen Tights")
            {
                HempenTights();                
            }
            else if (comboBox1.Text == "Hempen Bandana")
            {
                HempenBandana();
            }
            else
            {
                MessageBox.Show("Not implemented yet!");
            }

            lblGil.Text = ("Gil Required: " + Calculator(comboBox1.Text));

            listBox1.DataSource = null;
            listBox1.DataSource = _requiredItems;
        }

        public decimal Calculator(string input)
        {
            decimal gil = 0;

            for (int i = 0; i < shopitems.Length; i++)
            {
                gil += shopitems[i].Price * (decimal)shopitems[i].Quantity;
                if (shopitems[i].Quantity > 0 && shopitems[i].Quantity > 0)
                {
                    if (shopitems[i].fromShop)
                    {
                        _requiredItems.Add(shopitems[i].Quantity.ToString() + " " + shopitems[i].Name + ", cost: " +
                            shopitems[i].Price * shopitems[i].Quantity + " gil");
                    }                
                    else
                    {
                        _requiredItems.Add(shopitems[i].Quantity.ToString() + " " + shopitems[i].Name);
                    }
                }
            }

            // _requiredItems.Sort((a, b) => -1* a.CompareTo(b)); // Sorts the list
            return gil;
        }

#region All of the items to craft/need to craft
        public void EarthShard(int shards)
        {
            shopitems[13].Quantity += shards * (int)numericUpDown1.Value;
        }

        public void FireShard(int shards)
        {
            shopitems[14].Quantity += shards * (int)numericUpDown1.Value;
        }

        public void LightningShard(int shards)
        {
            shopitems[15].Quantity += shards * (int)numericUpDown1.Value;
        }

        public void WaterShard(int shards)
        {
            shopitems[16].Quantity += shards * (int)numericUpDown1.Value;
        }

        public void WindShard(int shards)
        {
            shopitems[17].Quantity += shards * (int)numericUpDown1.Value;
        }
        
        public void HempenYarn(int grass)
        {
            shopitems[3].Quantity += ((2 * grass) * (int)numericUpDown1.Value);
            LightningShard(1);
        }

        public void UndyedHempenCloth(int yarn)
        {
            HempenYarn(2 * yarn);
            LightningShard(1);
        }

        public void HempenHalfgloves()
        {
            UndyedHempenCloth(1);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenUnderpants()
        {
            UndyedHempenCloth(1);
            HempenYarn(2);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenPantalettes()
        {
            UndyedHempenCloth(1);
            HempenYarn(2);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenUndershirt()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenCoif()
        {
            UndyedHempenCloth(1);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenCamise()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenBreechesofCrafting()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
        }

        public void HempenKurta()
        {
            UndyedHempenCloth(3);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenCoifofGathering()
        {
            UndyedHempenCloth(1);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenShepherdsSlops()
        {
            UndyedHempenCloth(2);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            shopitems[9].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenDalmatica()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenBreeches()
        {
            UndyedHempenCloth(1);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenDalmaticaofGathering()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            shopitems[9].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenTunic()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenCowl()
        {
            UndyedHempenCloth(4);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        public void HempenSarouel()
        {
            UndyedHempenCloth(1);
            HempenYarn(1);
            shopitems[7].Quantity += 1 * (int)numericUpDown1.Value;
            shopitems[9].Quantity += 1 * (int)numericUpDown1.Value;
            LightningShard(1);
            WindShard(1);
        }

        public void HempenChausses()
        {
            UndyedHempenCloth(3);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        private void HempenTights()
        {
            UndyedHempenCloth(2);
            HempenYarn(1);
            LightningShard(1);
            WindShard(1);
        }

        private void HempenBandana()
        {
            UndyedHempenCloth(3);
            LightningShard(1);
            WindShard(1);
        }
#endregion

        private void lblMaterials_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!musicPlaying)
            {
                musicPlayer.PlayLooping();
                musicPlaying = true;

                lblVersion.Location = new Point(191, 186);
                lblVersion.Height = 75;
                lblVersion.Width = 172;

                lblMadeBy.Visible = true;
            }
            else
            {
                musicPlayer.Stop();
                musicPlaying = false;

                lblVersion.Location = new Point(191, 101);
                lblVersion.Height = 160;
                lblVersion.Width = 172;

                lblMadeBy.Visible = false;
            }
        }
    }
}
