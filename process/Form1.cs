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
        /// Form1_Load loads all secondary functions 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
            listBox1_SelectedIndexChanged_1(sender, e);
        }
        /// <summary>
        /// The button responsible for canceling the task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            Process[] processes = Process.GetProcesses();
            processes[listBox1.SelectedIndex].Kill();

        }
        /// <summary>
        /// The function responsible for outputting the list of processes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            foreach (Process process in Process.GetProcesses())
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }
        /// <summary>
        /// Timer responsible for updating the list of processes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1_SelectedIndexChanged_1(sender, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// The function starts an additional window for starting tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ÙÛÌÍˆËËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }

                listBox1.Sorted = true;

            }

        }
        /// <summary>
        /// The function closes the dispatcher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// This function was to delete the process that would be entered in the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    Process[] processes = Process.GetProcesses();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        p
    }
}
