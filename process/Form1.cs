using System.Diagnostics;
using System.Windows.Forms;

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
        /// /*Form1_Load loads all secondary functions */
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1_TextChanged(sender, e);
            listView1_SelectedIndexChanged(sender, e);
        }
        /// <summary>
        /// The button responsible for canceling the task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            Process[] processes = Process.GetProcesses();
            //processes[].Kill();

        }

        /// <summary>
        /// The function responsible for outputting the list of processes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Timer responsible for updating the list of processes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView1_SelectedIndexChanged(sender, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// The function starts an additional window for starting tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void функцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 from = new Form2())
            {
                if (from.ShowDialog() == DialogResult.OK)
                {

                }


            }

        }
        /// <summary>
        /// The function closes the dispatcher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    // Загружаем иконку процесса
                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(process.MainModule.FileName);

                    // Создаем новый PictureBox для отображения иконки
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = icon.ToBitmap();
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                    // Устанавливаем положение PictureBox на форме
                    pictureBox.Left = 10;
                    pictureBox.Top = Controls.Count * 50;

                    // Добавляем PictureBox на форму
                    this.Controls.Add(pictureBox);
                }
                catch { };
                listView1.Items.Add(process.ProcessName);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

