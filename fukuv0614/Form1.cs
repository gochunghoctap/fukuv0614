namespace fukuv0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int ans = random.Next(51);
        int count = 0;
        int yosou;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}âÒñ⁄ÇÃíßêÌ");
            
            textBox1.Text = $"{yosou}";

            if (ans == yosou)
                MessageBox.Show("Bingo!!");
                ans = random.Next(51);
                count = 0;

            if (ans < yosou)
                MessageBox.Show("Less");
                ans = random.Next(51);
                count = 0;

            if (ans > yosou)
                MessageBox.Show("Greater");
                ans = random.Next(51);
                count = 0;
        }

      
    }
}