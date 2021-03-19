using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobloxHacksAPI;
using WeAreDevs_API;
using EasyExploits;

namespace HanExecuter_V3
{
    public partial class HanExecuter : Form
    {
        EasyExploits.Module module = new EasyExploits.Module(); 

        ExploitAPI api = new ExploitAPI(); //Wearedevs API
        
        RobloxHacksAPI.Module module1 = new RobloxHacksAPI.Module(); //RobloxHacksAPI
        public HanExecuter()
        {
            InitializeComponent();
        }
        Point lastPoint;
        //int r = 255, g = 0, b = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                api.LaunchExploit();
            }
            if (checkBox2.Checked)
            {
                module1.InjectDLL();
            }
            if (checkBox3.Checked)
            {
                module.LaunchExploit();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HanExecuter_Load(object sender, EventArgs e)
        {
            //Home
            label6.Visible = false;
            
            //settings load
            label3.Visible = false;
            label4.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            panel4.Visible = false;
            pictureBox2.Visible = false;
            label7.Visible = false;
            checkBox4.Visible = false;

            //executer
            label6.Visible = true;

            
        }

        private void HanExecuter_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HanExecuter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string script = richTextBox1.Text;
                api.SendLuaScript(script);
            }   
            if (checkBox2.Checked)
            {
                module1.Execute(richTextBox1.Text);
            }
            if (checkBox3.Checked)
            {
                module.ExecuteScript(richTextBox1.Text);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/FhBcjDzevx");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //settings
            label3.Visible = true;
            label4.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            pictureBox5.Visible = true;
            label5.Visible = true;
            panel4.Visible = true;
            pictureBox2.Visible = true;
            label7.Visible = true;
            checkBox4.Visible = true;
            //executer
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            richTextBox1.Visible = false;
            listBox1.Visible = false;
            pictureBox1.Visible = false;
            label6.Visible = false;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
           
            if (checkBox1.Checked == true)
            {
                checkBox3.Checked = false;
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
           
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
            }
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
            }
           
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
            }
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Home
            label6.Visible = false;
            
            //settings
            label3.Visible = false;
            label4.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            panel4.Visible = false;
            pictureBox2.Visible = false;
            label7.Visible = false;
            checkBox4.Visible = false;
            //executer
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            richTextBox1.Visible = true;
            listBox1.Visible = true;
            pictureBox1.Visible = true;
            label6.Visible = true;
           
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            //Home
            label6.Visible = false;
            
            //settings
            label3.Visible = false;
            label4.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            panel4.Visible = false;
            pictureBox2.Visible = false;
            label7.Visible = false;
            checkBox4.Visible = false;
            //executer
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            richTextBox1.Visible = true;
            listBox1.Visible = true;
            pictureBox1.Visible = true;
            label6.Visible = true;
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            button7.ForeColor = Color.FromArgb(A, R, G, B);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                timer1.Start();
                panel3.Visible = false;
            }
            else
            {
                timer1.Stop();
                panel3.Visible = true;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
    }
}
