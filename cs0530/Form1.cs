namespace cs0530
{
    public partial class Form1 : Form
    {

        //
        int[] vx = new int[4];
        int[] vy = new int[4];

        int counter = 0;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            for (int i=0; i < 4; i++)
            {
                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }

            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);

            label1.Left = random.Next(0, ClientSize.Width - label1.Width);
            label1.Top = random.Next(0, ClientSize.Height - label1.Height);
            vx[2] = random.Next(-10, 11);
            vy[2] = random.Next(-10, 11);

            label4.Left = random.Next(0, ClientSize.Width - label4.Width);
            label4.Top = random.Next(0, ClientSize.Height - label4.Height);
            vx[3] = random.Next(-10, 11);
            vy[3] = random.Next(-10, 11);

            label5.Left = random.Next(0, ClientSize.Width - label5.Width);
            label5.Top = random.Next(0, ClientSize.Height - label5.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var mpos = MousePosition;
            var fpos = PointToClient(mpos);
            Text = $"{mpos.X},{mpos.Y}/{fpos.X},{fpos.Y}";

            label2.Left = fpos.X - (label2.Width / 2);
            label2.Top = fpos.Y - (label2.Height / 2);
            //v1-1
            label1.Left += vx[1];
            label1.Top += vy[1];
            if (label1.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label1.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }
            //v2-4
            label4.Left += vx[2];
            label4.Top += vy[2];
            if (label4.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label4.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label4.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            else if (label4.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }
            //v3-5
            label5.Left += vx[3];
            label5.Top += vy[3];
            if (label5.Left < 0)
            {
                vx[3] = Math.Abs(vx[3]);
            }
            else if (label5.Right > ClientSize.Width)
            {
                vx[3] = -Math.Abs(vx[3]);
            }
            if (label5.Top < 0)
            {
                vy[3] = Math.Abs(vy[3]);
            }
            else if (label5.Bottom > ClientSize.Height)
            {
                vy[3] = -Math.Abs(vy[3]);
            }

            counter++;
            label3.Text = $"{counter}";

            if (
                (label1.Left < fpos.X)
                &&
                (label1.Right > fpos.X)
                &&
                (label1.Top < fpos.Y)
                &&
                (label1.Bottom > fpos.Y)
                )
            {
                timer1.Enabled = false;
                button1.Visible = true;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            counter = 0;
            button1.Visible = false;
            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);

            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label1.Top = random.Next(ClientSize.Height - label1.Height);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");
            }
        }
    }
}
