namespace TheInterface
{
    public partial class Form1 : Form
    {
        Random rnd= new Random();
        string path = "InterfaceText.txt";
        int num = 0;
       private int itemArraySum = 0;
        IShape[] shapesArr = new IShape[100];
       private  int shapesArrayCount = 0;
        enum days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        IItem[] itemArr = new IItem[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text + "," + textBox2.Text +","+ textBox3.Text+",\n";
            File.AppendAllText(path, text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string read = File.ReadAllText(path);
                string[] readArr = read.Split(',');
                days day = (days)Enum.Parse(typeof(days), readArr[1],true);
                try
                {
                    textBox1.Text = readArr[num];
                    textBox2.Text = readArr[num + 1];
                    textBox3.Text = readArr[num + 2];
                    num = num + 3;
                }
                catch (Exception)
                {
                    num = 0;
                    textBox1.Text = "ENTER Name";
                    textBox2.Text = "ENTER Day";
                    textBox3.Text = "ENTER Age";
                }
               
            }
            else
            {
                //msg file does not exist
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cola newCola=new cola();
            IItem colaItem=(IItem)(newCola);
            int price= colaItem.getPrice();
            button3.Text = price.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (itemArraySum<5)
            {
                itemArr[itemArraySum] = (IItem)new cola();
                itemArraySum++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (itemArraySum < 5)
            {
                itemArr[itemArraySum] = (IItem)new kinley();
                itemArraySum++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string arrString="";
            for (int i = 0; i < itemArraySum; i++)
            {
               int itemPrice =itemArr[i].getPrice();
                arrString = arrString + itemPrice.ToString()+" ";   
            }
            if (arrString != null)
            {
                MessageBox.Show(arrString);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if(shapesArrayCount == 100)
            { return; }

            if (checkBox1.Checked)
            {
                shapesArr[shapesArrayCount] = new Circle();
                shapesArrayCount++;
            }
            if (checkBox2.Checked)
            {
                shapesArr[shapesArrayCount] = new Triangle();
                shapesArrayCount++;
            }
            if (checkBox3.Checked)
            {
                shapesArr[shapesArrayCount] = new Rectangle();
                shapesArrayCount++;
            }
            if (checkBox4.Checked)
            {
                shapesArr[shapesArrayCount] = new Moon(rnd.Next(1,10));
                shapesArrayCount++;
            }
            if (checkBox5.Checked)
            {
                shapesArr[shapesArrayCount] = new Elipse(rnd.Next(1, 10), rnd.Next(1, 20));
                shapesArrayCount++;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int vertexSum = 0;
            for (int i = 0; i < shapesArrayCount; i++)
            {
                int runner = shapesArr[i].getVertexAmount();
                vertexSum += runner;
            }
            label1.Text = vertexSum.ToString();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}