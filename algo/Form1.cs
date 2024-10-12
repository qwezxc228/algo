using System.Drawing;

namespace algo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int a = 10;
            int[] random = new int[a];
            
            Random rand = new Random();
            int x = rand.Next(1,100);
            for (int i = 0; i < a; i++)
            {
                random[i] = rand.Next(1, 101); 
            }
            for (int i = 0;i < random.Length; i++)
            {
                for(int j = 0; j < random.Length; j++)
                {
                    if (random[i] * random[j]!=x)
                    {
                        MessageBox.Show("таких нет");
                    }
                    else
                    {
                        MessageBox.Show(random.ToString());
                    }
                }
            }
        }
    }
}