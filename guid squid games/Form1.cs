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
        string lights = "";
        Random random = new Random();
        int startOfrace = 0;
        double greenPercMoved = (456 * 80 / 100);//364
        double greenPlayerstaticPerc = (456 * 20 / 100);//91
        double redPlayersStaticPerc = (456 * 20 / 100);
        string greenEliminated = "None";
        double redPercMoved = (456 * 5 / 100);//22
        int counts = 1;
        int totalSeconds = 1;
        List<int> Greenmoved = new List<int>();
        List<int> redMovedList = new List<int>();
        List<int> Rmoved = new List<int>();
        List<int> redStaticList = new List<int>();
        List<string> duplicatesList1 = new List<string>();
        List<string> G_round1 = new List<string>();
        List<string> G_round2 = new List<string>();
        List<string> G_round3 = new List<string>();
        List<string> R_round1 = new List<string>();
        List<string> R_round2 = new List<string>();
        List<string> R_round3 = new List<string>();
        List<string> Gstatic_round1 = new List<string>();
        List<string> Rstatic_round1 = new List<string>();
        List<string> Gstatic_round2 = new List<string>();
        List<string> Rstatic_round2 = new List<string>();
        List<string> Gstatic_round3 = new List<string>();
        List<string> Rstatic_round3 = new List<string>();
        List<int> GstaticList = new List<int>();
        List<string> ElimantedList = new List<string>();
        List<string> lastGreenMoved = new List<string>();
     
        double mod = 0;

        int minRepeats = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            secs = 5;
            timer1.Start();
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
            labelSeconds.Text = scnd.ToString();
            int greenMovedRandom = random.Next(1, 456);
            int redMovedRandom = random.Next(1, 456);
            int staticGreenRandom = random.Next(1, 456);
            if (secs <= 0)
            {
                timer1.Stop();
            }
            if (secs == 0)//When the timer gets to 0 this must happen
            {
                timer1.Start();//If the seconds are even numbers redLight must appear w
                count++;
                totalSeconds = count * 5;
                labelCount.Text = totalSeconds.ToString();
                label4.Text = count.ToString();
                secs = 5;
                double mod = totalSeconds % 2;
                //GreenLight
                if (mod == 1)
                {
                    labelLight.Text = "GreenLight";
                    if (count == 1)
                    {
                        //GreenLight1
                        for (int i = 0; i < greenPercMoved; i++) 
                        {
                            greenMovedRandom= random.Next(1, 456);
                            Greenmoved.Add(greenMovedRandom);
                        }
                        //Static1
                        for (int i = 0; i < greenPlayerstaticPerc; i++)
                        {
                            staticGreenRandom = random.Next(1, 456);
                            GstaticList.Add(staticGreenRandom);
                        }
                        //Round1
                        string[] GrandomArr = Greenmoved.Select(x => x.ToString()).ToArray();
                        string[] GstaticArr = GstaticList.Select(x => x.ToString()).ToArray();
                        string[] uniqueElementsGreenmoved = GrandomArr.Except(GstaticArr).ToArray();
                        string[] uniqueElementsGstaticList = GstaticArr.Except(GrandomArr).ToArray();
                        //Green not in static!
                        foreach (var item in uniqueElementsGreenmoved)
                        {
                            G_round1.Add(item);
                        }
                        //Staic not in Green!
                        foreach (var item in uniqueElementsGstaticList)
                        {

                            Gstatic_round1.Add(item);
                        }
                        foreach (var item in G_round1)
                        {
                            GmovedlistBox.Items.Add(item);
                        }
                        foreach (var item in Gstatic_round1)
                        {
                            GstaticlistBox.Items.Add(item);
                        }
                    }
                    if (count==3)
                    {
                        //Round2Moved
                        for (int i = 0; i < greenPercMoved; i++)
                        {
                            greenMovedRandom = random.Next(1, 456);
                            Greenmoved.Add(greenMovedRandom);
                        }
                        //Static2
                        for (int i = 0; i < greenPlayerstaticPerc; i++)
                        {
                            staticGreenRandom = random.Next(1, 456);
                            GstaticList.Add(staticGreenRandom);
                        }
                        //Round2
                        string[] GrandomArr2 = Greenmoved.Select(x => x.ToString()).ToArray();
                        string[] GstaticArr2 = GstaticList.Select(x => x.ToString()).ToArray();
                        string[] uniqueElementsGreenmoved2 = GrandomArr2.Except(GstaticArr2).ToArray();
                        string[] uniqueElementsGstaticList2 = GstaticArr2.Except(GrandomArr2).ToArray();
                        string[] GMovedwithoutRed1 = uniqueElementsGreenmoved2.Except(R_round1).ToArray();
                        string[] GStaticwithoutRed1 = uniqueElementsGstaticList2.Except(R_round1).ToArray();
                        //Green not in static2!
                        GmovedlistBox.Items.Add("ROUND2");
                        foreach (var item in GMovedwithoutRed1)
                        {
                            G_round2.Add(item);
                        }
                        //Staic not in Green2!
                        GstaticlistBox.Items.Add("ROUND2");
                        foreach (var item in GStaticwithoutRed1)
                        {

                            Gstatic_round2.Add(item);
                        }
                        foreach (var item in G_round2)
                        {
                            GmovedlistBox.Items.Add(item);
                        }
                        foreach (var item in Gstatic_round2)
                        {
                            GstaticlistBox.Items.Add(item);
                        }
                    }
                    ////ROUND3
                    if (count == 5)
                    {
                        //Round3Moved
                        for (int i = 0; i < greenPercMoved; i++)
                        {
                            greenMovedRandom = random.Next(1, 456);
                            Greenmoved.Add(greenMovedRandom);
                        }
                        //Static3
                        for (int i = 0; i < greenPlayerstaticPerc; i++)
                        {
                            staticGreenRandom = random.Next(1, 456);
                            GstaticList.Add(staticGreenRandom);
                        }
                        string[] GrandomArr3 = Greenmoved.Select(x => x.ToString()).ToArray();
                        string[] GstaticArr3 = GstaticList.Select(x => x.ToString()).ToArray();
                        string[] uniqueElementsGreenmoved3 = GrandomArr3.Except(GstaticArr3).ToArray();
                        string[] uniqueElementsGstaticList3 = GstaticArr3.Except(GrandomArr3).ToArray();
                        string[] GMovedwithoutRed2 = uniqueElementsGreenmoved3.Except(R_round2).ToArray();
                        string[] GStaticwithoutRed2 = uniqueElementsGstaticList3.Except(R_round2).ToArray();
                        //Green not in static2!
                        GmovedlistBox.Items.Add("ROUND3");
                        foreach (var item in GMovedwithoutRed2)
                        {
                            G_round3.Add(item);
                        }
                        //Staic not in Green2!
                        foreach (var item in GStaticwithoutRed2)
                        {

                            Gstatic_round3.Add(item);
                        }
                        foreach (var item in G_round3)
                        {
                            GmovedlistBox.Items.Add(item);
                        }
                        GstaticlistBox.Items.Add("ROUND3");
                        foreach (var item in Gstatic_round3)
                        {
                            GstaticlistBox.Items.Add(item);
                            lastGreenMoved.Add(item);
                        }
                    }
                    GeliminatedlsBox.Items.Add("None");
                }
                
                ///RED LIGHT!!
                else if (mod == 0)
                {
                    labelLight.Text = "RedLight";
                    if (count == 2)//FirstRedCount
                    {
                        for (int i = 1; i < redPlayersStaticPerc; i++)//First Static
                        {
                           int redStaticplayers = random.Next(1, 456);
                            redStaticList.Add(redStaticplayers);
                        }   
                        for (int i = 1; i < redPercMoved; i++)
                        {
                            redMovedRandom = random.Next(1, 456);
                            redMovedList.Add(redMovedRandom);
                        }
                        string[] redStaticArr = redStaticList.Select(x => x.ToString()).ToArray();
                        string[] redMovedArr = redMovedList.Select(x => x.ToString()).ToArray();
                        string[] uniqueElementsRedmoved = redMovedArr.Except(redStaticArr).ToArray();
                        string[] uniqueElementsRedstaticList = redStaticArr.Except(redMovedArr).ToArray();

                        foreach (var item in uniqueElementsRedmoved)
                        {
                            R_round1.Add(item);
                        }
                        foreach (var item in uniqueElementsRedstaticList)
                        {
                            Rstatic_round1.Add(item);
                        }
                        foreach (var item in Rstatic_round1)
                        {
                            RstaticlistBox.Items.Add(item);
                        }
                        foreach (var item in R_round1)
                        {
                            RmovedlistBox.Items.Add(item);
                            RelimatedlsBox.Items.Add(item);
                        }
                    }
                    //Round2 Red
                    if (count == 4)
                    {
                        for(int i = 1; i < redPlayersStaticPerc; i++)// Static
                        {
                            int redStaticplayers = random.Next(1, 456);
                            redStaticList.Add(redStaticplayers);
                        }
                        for (int i = 1; i < redPercMoved; i++)
                        {
                            redMovedRandom = random.Next(1, 456);
                            redMovedList.Add(redMovedRandom);
                        }
                        string[] redStaticArr2 = redStaticList.Select(x => x.ToString()).ToArray();
                        string[] redMovedArr2 = redMovedList.Select(x => x.ToString()).ToArray();
                        string[] uniqueElementsRedmoved2 = redMovedArr2.Except(redStaticArr2).ToArray();
                        string[] redMovedround2 = uniqueElementsRedmoved2.Except(R_round1).ToArray();
                        string[] uniqueElementsRedstaticList2 = redStaticArr2.Except(redMovedArr2).ToArray();
                        string[] redStaticround2 = uniqueElementsRedstaticList2.Except(Rstatic_round1).ToArray();
                        RmovedlistBox.Items.Add("ROUND2");
                        RelimatedlsBox.Items.Add("ROUND2");
                        RstaticlistBox.Items.Add("ROUND2");
                        foreach (var item in redMovedround2)
                        {
                            R_round2.Add(item);
                        }
                        foreach (var item in redStaticround2)
                        {
                            Rstatic_round2.Add(item);
                        }
                        foreach (var item in Rstatic_round2)
                        {
                            RstaticlistBox.Items.Add(item);
                        }
                        foreach (var item in R_round2)
                        {
                            RmovedlistBox.Items.Add(item);
                            RelimatedlsBox.Items.Add(item);
                        }
                    }
                }
                //Roun3//Lastround
                if (count == 6)
                {

                    for (int i = 1; i < redPlayersStaticPerc; i++)// Static
                    {
                        int redStaticplayers = random.Next(1, 456);
                        redStaticList.Add(redStaticplayers);
                    }
                    for (int i = 1; i < redPercMoved; i++)
                    {
                        redMovedRandom = random.Next(1, 456);
                        redMovedList.Add(redMovedRandom);
                    }

                    string[] redStaticArr3 = redStaticList.Select(x => x.ToString()).ToArray();
                    string[] redMovedArr3 = redMovedList.Select(x => x.ToString()).ToArray();
                    string[] uniqueElementsRedmoved3 = redMovedArr3.Except(redStaticArr3).ToArray();
                    string[] redMovedround3 = uniqueElementsRedmoved3.Except(R_round2).ToArray();
                    string[] uniqueElementsRedstaticList3 = redStaticArr3.Except(redMovedArr3).ToArray();
                    string[] redStaticround3 = uniqueElementsRedstaticList3.Except(Rstatic_round2).ToArray();
                    RmovedlistBox.Items.Add("ROUND3");
                    RelimatedlsBox.Items.Add("ROUND3");
                    RstaticlistBox.Items.Add("ROUND3");
                    foreach (var item in redMovedround3)
                    {
                        R_round3.Add(item);
                    }
                    foreach (var item in redStaticround3)
                    {
                        Rstatic_round3.Add(item);
                    }
                    foreach (var item in Rstatic_round3)
                    {
                        RstaticlistBox.Items.Add(item);
                    }
                    foreach (var item in R_round3)
                    {
                        RmovedlistBox.Items.Add(item);
                        RelimatedlsBox.Items.Add(item);
                        ElimantedList.Add(item);
                    }
                    //Winners code
                    //string[] Wwinners = lastGreenMoved.Select(x => x.ToString()).ToArray();
                    //string[] lastElimanted = ElimantedList.Select(x => x.ToString()).ToArray();
                    string[] winners = Greenmoved.Select(x => x.ToString()).ToArray(); ;
                    for (int i = 0; i < winners.Length; i++)
                    {
                        int duplicate = 1;
                        for (int j = i + 1; j < winners.Length; j++)
                        {
                            if (winners[i] == winners[j])
                            {
                                duplicate++;
                                if (duplicate >= minRepeats && !duplicatesList1.Contains(winners[i]))
                                //if number duplicates =3 but duplicateList
                                //doesnt contain those items add them
                                {
                                    duplicatesList1.Add(winners[i]);
                                }
                            }
                        }
                    }
                    foreach (var item in duplicatesList1)
                    {
                        listBox7.Items.Add(item);
                    }
                    //foreach (var item in duplicatesList1)
                    //{
                    //    listBox7.Items.Add(item);
                    //}
                    timer1.Stop();
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

        private void GmovedlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}