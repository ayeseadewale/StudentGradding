namespace StudentGrading
{
    public partial class Form1 : Form
    {
        public object Int { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int maths, eng, yoruba, computer, total;
            double average, percentage;
            maths = Convert.ToInt32(MathBox.Text);
            eng=Convert.ToInt32(EngBox.Text);
            yoruba= Convert.ToInt32(YoruBox.Text);
            computer= Convert.ToInt32(CPUBox.Text);

            total = maths + eng + yoruba + computer;
            totaltxt.Text = ("Total Score: "+total.ToString());
            
            average = total / 4;
            AverageTxt.Text = ("Average Score: "+ average.ToString());
            string message;
            if(average >=70 && average <=100)
            {
                message = "A";
            }else if(average >=60 && average <= 69.9)
            {
                message = "B";
            }else if(average >=50 && average <= 59.99)
            {
                message = "C";
            }else if(average >=45 && average <= 49.9)
            {
                message = "D";
            }else if(average>=40 && average <= 44.99)
            {
                message = "E";
            }
            else
            {
                message = "F";
            }
            GradeTxt.Text =("Grade: " + message.ToString());
            percentage = (total / 400 * 100);
            PercentTxt.Text = ("Percentage: " + Convert.ToDouble(percentage));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}