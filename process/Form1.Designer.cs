namespace process
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            функцииToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            listView1 = new ListView();
            Task = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(675, 448);
            button1.Name = "button1";
            button1.Size = new Size(99, 25);
            button1.TabIndex = 0;
            button1.Text = "Снять задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(12, 448);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Снять задачу";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { функцииToolStripMenuItem, выходToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(68, 20);
            toolStripMenuItem1.Text = "Функции";
            // 
            // функцииToolStripMenuItem
            // 
            функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            функцииToolStripMenuItem.Size = new Size(189, 22);
            функцииToolStripMenuItem.Text = "Запуск новой задачи";
            функцииToolStripMenuItem.Click += функцииToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(189, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(280, 448);
            button2.Name = "button2";
            button2.Size = new Size(83, 23);
            button2.TabIndex = 4;
            button2.Text = "Снять Задачу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { Task, columnHeader1 });
            listView1.Location = new Point(42, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(746, 391);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Task
            // 
            Task.Text = "Task";
            Task.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(0, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DpiChangedAfterParent += Form1_Load;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 483);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(listView1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(246, 362);
            Name = "Form1";
            Text = "Диспетчер задач";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem функцииToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button button2;
        private ListView listView1;
        private ColumnHeader Task;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader1;
        private ImageList imageList1;
    }
}
