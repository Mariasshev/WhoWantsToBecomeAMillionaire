namespace WinFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(902, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(46, 20);
            играToolStripMenuItem.Text = "Игра";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 18);
            button1.Name = "button1";
            button1.Size = new Size(67, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(76, 18);
            button2.Name = "button2";
            button2.Size = new Size(67, 40);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(170, 18);
            button3.Name = "button3";
            button3.Size = new Size(101, 40);
            button3.TabIndex = 1;
            button3.Text = "Стоп";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.ForeColor = Color.Gold;
            groupBox1.Location = new Point(628, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подсказки";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(45, 22);
            button4.Name = "button4";
            button4.Size = new Size(67, 40);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(118, 22);
            button5.Name = "button5";
            button5.Size = new Size(67, 40);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(191, 22);
            button6.Name = "button6";
            button6.Size = new Size(67, 40);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 566);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(628, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 491);
            panel2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.ForeColor = Color.Gold;
            richTextBox1.Location = new Point(36, 307);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(556, 79);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveCaptionText;
            richTextBox2.ForeColor = Color.Gold;
            richTextBox2.Location = new Point(36, 405);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(264, 59);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.InactiveCaptionText;
            richTextBox3.ForeColor = Color.Gold;
            richTextBox3.Location = new Point(332, 470);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(260, 59);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.InactiveCaptionText;
            richTextBox4.ForeColor = Color.Gold;
            richTextBox4.Location = new Point(332, 405);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(260, 59);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = SystemColors.InactiveCaptionText;
            richTextBox5.ForeColor = Color.Gold;
            richTextBox5.Location = new Point(36, 470);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(264, 59);
            richTextBox5.TabIndex = 3;
            richTextBox5.Text = "";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaptionText;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.Gold;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 450);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 592);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Кто хочет стать миллионером";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox2;
        private ListBox listBox1;
    }
}
