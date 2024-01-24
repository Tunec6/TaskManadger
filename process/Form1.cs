using System.Diagnostics;

namespace process
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 10000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }
          
        /// <summary>
        /// Form1_Load подгружает все второстепенные функции 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
            listBox1_SelectedIndexChanged_1(sender, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            Process[] processes = Process.GetProcesses();
            processes[listBox1.SelectedIndex].Kill();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            foreach (Process process in Process.GetProcesses())
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1_SelectedIndexChanged_1(sender, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void функцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
