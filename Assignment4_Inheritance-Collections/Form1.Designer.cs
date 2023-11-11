namespace Assignment4_Inheritance_Collections
{
    partial class Window
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView2 = new ListView();
            toolTip1 = new ToolTip(components);
            CopyrightLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            CreateCustomCardButton = new Button();
            RankRTB = new RichTextBox();
            SuitRTB = new RichTextBox();
            groupBox4 = new GroupBox();
            ExitButton = new Button();
            HelpButton = new Button();
            ResetButton = new Button();
            ShuffleButton = new Button();
            ViewDeckButton = new Button();
            DealCardButton = new Button();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(8, 20);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(273, 371);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Rank";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 112;
            // 
            // listView2
            // 
            listView2.Location = new Point(8, 56);
            listView2.Margin = new Padding(4);
            listView2.Name = "listView2";
            listView2.Size = new Size(273, 335);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            CopyrightLabel.Location = new Point(171, 553);
            CopyrightLabel.Margin = new Padding(1, 0, 1, 0);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(277, 15);
            CopyrightLabel.TabIndex = 12;
            CopyrightLabel.Text = "Copyright © Ramiyan Gangatharan - DC 2023 ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(13, 144);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(289, 400);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deck";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(listView2);
            groupBox2.Location = new Point(318, 144);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(289, 400);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cards Dealt";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52" });
            comboBox1.Location = new Point(95, 20);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 28);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "Draw Card";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(CreateCustomCardButton);
            groupBox3.Controls.Add(RankRTB);
            groupBox3.Controls.Add(SuitRTB);
            groupBox3.Location = new Point(13, 3);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(244, 133);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Card";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Rank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 3;
            label1.Text = "Suit";
            // 
            // CreateCustomCardButton
            // 
            CreateCustomCardButton.Location = new Point(57, 95);
            CreateCustomCardButton.Margin = new Padding(4);
            CreateCustomCardButton.Name = "CreateCustomCardButton";
            CreateCustomCardButton.Size = new Size(175, 31);
            CreateCustomCardButton.TabIndex = 2;
            CreateCustomCardButton.Text = "&Create Custom Card";
            CreateCustomCardButton.UseVisualStyleBackColor = true;
            CreateCustomCardButton.Click += CreateCustomCardButton_Click;
            // 
            // RankRTB
            // 
            RankRTB.Location = new Point(57, 56);
            RankRTB.Margin = new Padding(4);
            RankRTB.Name = "RankRTB";
            RankRTB.Size = new Size(174, 29);
            RankRTB.TabIndex = 1;
            RankRTB.Text = "";
            // 
            // SuitRTB
            // 
            SuitRTB.Location = new Point(57, 19);
            SuitRTB.Margin = new Padding(4);
            SuitRTB.Name = "SuitRTB";
            SuitRTB.Size = new Size(174, 29);
            SuitRTB.TabIndex = 0;
            SuitRTB.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ExitButton);
            groupBox4.Controls.Add(HelpButton);
            groupBox4.Controls.Add(ResetButton);
            groupBox4.Controls.Add(ShuffleButton);
            groupBox4.Controls.Add(ViewDeckButton);
            groupBox4.Controls.Add(DealCardButton);
            groupBox4.Location = new Point(265, 3);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(342, 133);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Controls";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(228, 77);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(90, 45);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(130, 77);
            HelpButton.Margin = new Padding(4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(90, 45);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "&Help";
            HelpButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(32, 77);
            ResetButton.Margin = new Padding(4);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(90, 45);
            ResetButton.TabIndex = 11;
            ResetButton.Text = "&Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // ShuffleButton
            // 
            ShuffleButton.Location = new Point(228, 24);
            ShuffleButton.Margin = new Padding(4);
            ShuffleButton.Name = "ShuffleButton";
            ShuffleButton.Size = new Size(90, 45);
            ShuffleButton.TabIndex = 10;
            ShuffleButton.Text = "&Shuffle";
            ShuffleButton.UseVisualStyleBackColor = true;
            // 
            // ViewDeckButton
            // 
            ViewDeckButton.Location = new Point(130, 24);
            ViewDeckButton.Margin = new Padding(4);
            ViewDeckButton.Name = "ViewDeckButton";
            ViewDeckButton.Size = new Size(90, 45);
            ViewDeckButton.TabIndex = 9;
            ViewDeckButton.Text = "&View";
            ViewDeckButton.UseVisualStyleBackColor = true;
            // 
            // DealCardButton
            // 
            DealCardButton.Location = new Point(32, 24);
            DealCardButton.Margin = new Padding(4);
            DealCardButton.Name = "DealCardButton";
            DealCardButton.Size = new Size(90, 45);
            DealCardButton.TabIndex = 8;
            DealCardButton.Text = "&Deal ";
            DealCardButton.UseVisualStyleBackColor = true;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Suit";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 112;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 577);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CopyrightLabel);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Window";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Deck Builder";
            Load += Window_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private ToolTip toolTip1;
        private Label CopyrightLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private Button CreateCustomCardButton;
        private RichTextBox RankRTB;
        private RichTextBox SuitRTB;
        private ComboBox comboBox1;
        private Label label3;
        private Button DealCardButton;
        private Button HelpButton;
        private Button ResetButton;
        private Button ShuffleButton;
        private Button ViewDeckButton;
        private Button ExitButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}