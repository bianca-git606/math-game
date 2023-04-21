namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random seed = new Random();
            int num1 = seed.Next(10) + 1;
            int num2 = seed.Next(10) + 1;
            int num3 = seed.Next(10) + 1;

            frstNum.Text = num1.ToString();
            scndNum.Text = num2.ToString();
            thrdNum.Text = num3.ToString();

            pbx1.Image = Image.FromFile("num" + num1.ToString() + ".jpg");
            pbx2.Image = Image.FromFile("num" + num2.ToString() + ".jpg");
            pbx3.Image = Image.FromFile("num" + num3.ToString() + ".jpg");

            
        }
        int totalTry = 0;
        int corAnw = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int userAnw;

            int num1 = int.Parse(frstNum.Text);
            int num2 = int.Parse(scndNum.Text);
            int num3 = int.Parse(thrdNum.Text);
            int correctAnw = num1 + num2 * num3;

            
            userAnw = Int32.Parse(userAnswer.Text);
            string congrats = "Good job! Keep it up.";
            string sorry = "Your answer is not correct. \nHint: Multiplication comes first.";

            if (userAnw == correctAnw)
            {
                pbxRes.Image = Image.FromFile("congrats.jpg");
                response.Text = congrats;

                corAnw = corAnw + 1;
                totalTry = totalTry + 1;
                totalTries.Text = totalTry.ToString();
                correctAnsw.Text = corAnw.ToString();
            }
            else

            if (userAnw >= 110)
            {
                MessageBox.Show("Your answer is too big!");
                totalTry = totalTry + 1;
                totalTries.Text = totalTry.ToString();
            }
            else

            if (userAnw <= 2)
            {
                MessageBox.Show("Your answer is too small!");
                totalTry = totalTry + 1;
                totalTries.Text = totalTry.ToString();
            }
            else
            {
                response.Text = sorry;
                pbxRes.Image = Image.FromFile("tryagain.jpg");
                totalTry = totalTry + 1;
                totalTries.Text = totalTry.ToString();
            }
        }
    }
}
