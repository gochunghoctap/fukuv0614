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
            MessageBox.Show($"{count}��ڂ̒���");
            
            yosou=int.Parse(textBox1.Text);

            if (ans == yosou)
                MessageBox.Show("Bingo!!");
                ans = random.Next(51);
                count = 0;

            if (ans < yosou)
                MessageBox.Show("Less");

            if (ans > yosou)
                MessageBox.Show("Greater");
        }

      
    }
}