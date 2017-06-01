using System;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class FormMain : Form
    {    
        int suijishu = -1;
        int n = 0;
        bool dianji = true;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            if (dianji != true)
            {
                return;
            }
            int i = (Convert.ToInt32((sender as Label).Name.Substring(5, 1)));
            switch (i)
            {
                case 1:
                    label1.ImageIndex = 1;
                    break;
                case 2:
                    label2.ImageIndex = 1;
                    break;
                case 3:
                    label3.ImageIndex = 1;
                    break;
                case 4:
                    label4.ImageIndex = 1;
                    break;
                case 5:
                    label5.ImageIndex = 1;
                    break;
                case 6:
                    label6.ImageIndex = 1;
                    break;
                case 7:
                    label7.ImageIndex = 1;
                    break;
                case 8:
                    label8.ImageIndex = 1;
                    break;
                case 9:
                    label9.ImageIndex = 1;
                    break;
                case 0:
                    label0.ImageIndex=1;
                    break;
            }
            n += 1;
            textBox1.Text = n.ToString();
            dianji = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dianji = true;
            kaishi:
            Random r = new Random();
            int ran = r.Next(0, 10);
            if (ran == suijishu)
            {
                goto kaishi;
            }
            switch (ran)
            {
                case 1:
                    label1.ImageIndex = 0;
                    label1.Visible = true;
                    break;
                case 2:
                    label2.ImageIndex = 0;
                    label2.Visible = true;
                    break;
                case 3:
                    label3.ImageIndex = 0;
                    label3.Visible = true;
                    break;
                case 4:
                    label4.ImageIndex = 0;
                    label4.Visible = true;
                    break;
                case 5:
                    label5.ImageIndex = 0;
                    label5.Visible = true;
                    break;
                case 6:
                    label6.ImageIndex = 0;
                    label6.Visible = true;
                    break;
                case 7:
                    label7.ImageIndex = 0;
                    label7.Visible = true;
                    break;
                case 8:
                    label8.ImageIndex = 0;
                    label8.Visible = true;
                    break;
                case 9:
                    label9.ImageIndex = 0;
                    label9.Visible = true;
                    break;
                case 0:
                    label0.ImageIndex = 0;
                    label0.Visible = true;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label0.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            suijishu = -1;
            n = 0;
            dianji = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            label0.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            string xiaoxi = textBox1.Text;
            xiaoxi += "分，呵呵！";
            MessageBox.Show(xiaoxi,"Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void 简单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = true;
            中等ToolStripMenuItem.Checked = false;
            困难ToolStripMenuItem.Checked = false;
            timer1.Interval = 1200;
            timer2.Interval = 2400;
        }

        private void 中等ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = false;
            中等ToolStripMenuItem.Checked = true;
            困难ToolStripMenuItem.Checked = false;
            timer1.Interval = 1000;
            timer2.Interval = 2000;
        }

        private void 困难ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = false;
            中等ToolStripMenuItem.Checked = false;
            困难ToolStripMenuItem.Checked = true;
            timer1.Interval = 750;
            timer2.Interval = 1500;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string output="可以选择3个难度";
            output+=Environment.NewLine;
            output+="开始后点击即可敲打地鼠";
            MessageBox.Show(output, "帮助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 关于打地鼠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing want to say", "关于打地鼠", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "Go!";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "开始";
        }
    }
}
