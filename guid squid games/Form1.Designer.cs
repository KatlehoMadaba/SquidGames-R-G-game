
namespace guid_squid_games
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelLight = new System.Windows.Forms.Label();
            this.RmovedlistBox = new System.Windows.Forms.ListBox();
            this.GmovedlistBox = new System.Windows.Forms.ListBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RstaticlistBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelGmoved = new System.Windows.Forms.Label();
            this.GstaticlistBox = new System.Windows.Forms.ListBox();
            this.GeliminatedlsBox = new System.Windows.Forms.ListBox();
            this.RelimatedlsBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start time ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Location = new System.Drawing.Point(22, 164);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(26, 13);
            this.labelLight.TabIndex = 3;
            this.labelLight.Text = "light";
            // 
            // RmovedlistBox
            // 
            this.RmovedlistBox.FormattingEnabled = true;
            this.RmovedlistBox.Location = new System.Drawing.Point(413, 46);
            this.RmovedlistBox.Name = "RmovedlistBox";
            this.RmovedlistBox.Size = new System.Drawing.Size(120, 108);
            this.RmovedlistBox.TabIndex = 6;
            this.RmovedlistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GmovedlistBox
            // 
            this.GmovedlistBox.FormattingEnabled = true;
            this.GmovedlistBox.Location = new System.Drawing.Point(179, 41);
            this.GmovedlistBox.Name = "GmovedlistBox";
            this.GmovedlistBox.Size = new System.Drawing.Size(166, 147);
            this.GmovedlistBox.TabIndex = 7;
            this.GmovedlistBox.SelectedIndexChanged += new System.EventHandler(this.GmovedlistBox_SelectedIndexChanged);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(38, 41);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(10, 13);
            this.labelSeconds.TabIndex = 8;
            this.labelSeconds.Text = ".";
            this.labelSeconds.Click += new System.EventHandler(this.labelSeconds_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(93, 233);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "0";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total seconds:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Timer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lightbulb:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "RedLight";
            // 
            // RstaticlistBox
            // 
            this.RstaticlistBox.FormattingEnabled = true;
            this.RstaticlistBox.Location = new System.Drawing.Point(413, 233);
            this.RstaticlistBox.Name = "RstaticlistBox";
            this.RstaticlistBox.Size = new System.Drawing.Size(169, 108);
            this.RstaticlistBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "GreenLight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Moved:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Static:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Eliminated ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Moved:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Static:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(410, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Eliminated ";
            // 
            // labelGmoved
            // 
            this.labelGmoved.AutoSize = true;
            this.labelGmoved.Location = new System.Drawing.Point(335, 180);
            this.labelGmoved.Name = "labelGmoved";
            this.labelGmoved.Size = new System.Drawing.Size(10, 13);
            this.labelGmoved.TabIndex = 23;
            this.labelGmoved.Text = ".";
            this.labelGmoved.Click += new System.EventHandler(this.labelGmoved_Click);
            // 
            // GstaticlistBox
            // 
            this.GstaticlistBox.FormattingEnabled = true;
            this.GstaticlistBox.Location = new System.Drawing.Point(179, 233);
            this.GstaticlistBox.Name = "GstaticlistBox";
            this.GstaticlistBox.Size = new System.Drawing.Size(166, 108);
            this.GstaticlistBox.TabIndex = 24;
            this.GstaticlistBox.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // GeliminatedlsBox
            // 
            this.GeliminatedlsBox.FormattingEnabled = true;
            this.GeliminatedlsBox.Location = new System.Drawing.Point(179, 395);
            this.GeliminatedlsBox.Name = "GeliminatedlsBox";
            this.GeliminatedlsBox.Size = new System.Drawing.Size(120, 95);
            this.GeliminatedlsBox.TabIndex = 25;
            this.GeliminatedlsBox.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // RelimatedlsBox
            // 
            this.RelimatedlsBox.FormattingEnabled = true;
            this.RelimatedlsBox.Location = new System.Drawing.Point(413, 395);
            this.RelimatedlsBox.Name = "RelimatedlsBox";
            this.RelimatedlsBox.Size = new System.Drawing.Size(120, 95);
            this.RelimatedlsBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Winners";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(660, 30);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(103, 134);
            this.listBox7.TabIndex = 27;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "[]";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rounds:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.RelimatedlsBox);
            this.Controls.Add(this.GeliminatedlsBox);
            this.Controls.Add(this.GstaticlistBox);
            this.Controls.Add(this.labelGmoved);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RstaticlistBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.GmovedlistBox);
            this.Controls.Add(this.RmovedlistBox);
            this.Controls.Add(this.labelLight);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.ListBox RmovedlistBox;
        private System.Windows.Forms.ListBox GmovedlistBox;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox RstaticlistBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelGmoved;
        private System.Windows.Forms.ListBox GstaticlistBox;
        private System.Windows.Forms.ListBox GeliminatedlsBox;
        private System.Windows.Forms.ListBox RelimatedlsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

