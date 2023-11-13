using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace guid_squid_games
{

    public partial class Form1 : Form
    {

       
public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int secs = 0;
        int count = 0;
        string light = "";
        Random random = new Random();
        int startOfrace = 0;
        double greenPercMoved = (456 * 80 / 100)/3;//364=121 >>Greenlight3 times out of the 
        double greenPlayersStatic = (456 * 20 / 100)/3;//91=30
        string greenEliminated = "None";
        double redPercMoved = (456 * 5 / 100)/3;//22=7,3
        int redPlayerStatic = 1;
        int counts = 1;
        int totalSeconds = 1;
        List<int> Gmoved = new List<int>();
        List<string> GmovedString = new List<string>();
        List<int> Rmoved = new List<int>();
        List<int> Gstatic = new List<int>();
        List<int> Rstatic = new List<int>();
        double mod = 0;
        int minRepeats = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            secs = 5;
            timer1.Start();
            //light = labelLight.Text = "GreenLight";
            //count += 1;
            //labelCount.Text=count.ToString() ;
        }
//For every GREEN light, use random numbers to determine the players that move forward.
//If a player moved forward two times out of
//the three times when there was green light, the player wins.
//Use random numbers to determine the players that will not move. When
//using random numbers, make sure 80% of the players are moving,
//while 20% will not.
        private void timer1_Tick(object sender, EventArgs e)
        {
            int scnd = secs--;
            int greenStaticplayers = random.Next(1, 456);
            labelSeconds.Text = scnd.ToString();
            greenStaticplayers = random.Next(1, 456);

            if (secs <= 0)
            {
                timer1.Stop();

                //light= labelLight.Text = "GreenLight";
            }
            if (secs == 0)//When the timer gets to 0 this must happen
            {
                //light=labelLight.Text = "RedLight";
                timer1.Start();//If the seconds are even numbers redLight must appear 
                count++;
                totalSeconds = count * 5;
                labelCount.Text = totalSeconds.ToString();
                label4.Text = count.ToString();
                secs = 5;
                double mod = totalSeconds % 2;
                if (mod == 1)
                {
                    labelLight.Text = "GreenLight";
                        for (int j = 0; j < Math.Round(greenPercMoved); j++)
                        {
                        int greenMovedplayers = random.Next(1, 456);
                        listBox2.Items.Add(greenMovedplayers);
                        Gmoved.Add(greenMovedplayers);
                        

                            //Console.WriteLine($"{j}: {greenMovedplayers}");
                            //label4.Text = counts++.ToString();
                            //listBox8.Items.Add(j);
                        }
                 listBox5.Items.Add("None");
                    for (int s = 1; s <45; s++)
                    {
                        int staticGplayers = random.Next(1, 456);
                        listBox4.Items.Add(staticGplayers);
                    }
                }
                else if (mod==0)
                {
                    labelLight.Text = "RedLight";
                    for (int j = 0; j < redPercMoved; j++)
                        {
                            int redMovedplayers = random.Next(1, 456);
                            listBox1.Items.Add(redMovedplayers);
                            listBox6.Items.Add(redMovedplayers);
                            Rmoved.Add(redMovedplayers);
                            
                            //Console.WriteLine($"{j}: {greenMovedplayers}");
                            //label4.Text = counts++.ToString();
                            //listBox8.Items.Add(j);
                    }

                    for (int s = 1; s < 45; s++)
                    {
                        int staticRplayers = random.Next(1, 456);
                        listBox3.Items.Add(staticRplayers);
                    }
                }
                if (count == 6)
                {
                    timer1.Stop();

                    //Winners code

                    List<string> duplicatesList = new List<string>();

                    string[] winners = Gmoved.Select(x => x.ToString()).ToArray();
                    foreach (var item in Gmoved)
                    {
                        GmovedString.Add(item.ToString());
                    }


                    for (int i = 0; i < winners.Length; i++)
                    {
                        int duplicate = 1;
                        for (int j = i + 1; j < winners.Length; j++)
                        {
                            if (winners[i] == winners[j])
                            {
                                duplicate++;
                                if (duplicate >= minRepeats && !duplicatesList.Contains(winners[i]))
                                //if number duplicates =3 but duplicateList
                                //doesnt contain those items add them
                                {
                                    duplicatesList.Add(winners[i]); 
                                }
                            }
                        }
                    }
                    foreach (var item in duplicatesList)
                    {
                        listBox7.Items.Add(item);
                    }
                }
            }
        }
    
        private void seconds_Click(object sender, EventArgs e)
        {

        }

        private void labelSeconds_Click(object sender, EventArgs e)
        {

        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void labelGmoved_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
