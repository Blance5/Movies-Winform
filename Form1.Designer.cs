namespace WinFormsApp1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ratedBtn = new Button();
            submitBtn = new Button();
            votedBtn = new Button();
            actorsBtn = new Button();
            startTB = new TextBox();
            output = new DataGridView();
            greatestRad = new RadioButton();
            leastRad = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            startRad = new RadioButton();
            containRad = new RadioButton();
            endRad = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            SuspendLayout();
            // 
            // ratedBtn
            // 
            ratedBtn.Location = new Point(40, 68);
            ratedBtn.Name = "ratedBtn";
            ratedBtn.Size = new Size(157, 58);
            ratedBtn.TabIndex = 0;
            ratedBtn.Text = "Highest Rated";
            ratedBtn.UseVisualStyleBackColor = true;
            ratedBtn.Click += button1_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(235, 148);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(93, 24);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += button2_Click;
            // 
            // votedBtn
            // 
            votedBtn.Location = new Point(431, 68);
            votedBtn.Name = "votedBtn";
            votedBtn.Size = new Size(157, 58);
            votedBtn.TabIndex = 2;
            votedBtn.Text = "Most Voted for";
            votedBtn.UseVisualStyleBackColor = true;
            votedBtn.Click += button3_Click;
            // 
            // actorsBtn
            // 
            actorsBtn.Location = new Point(235, 68);
            actorsBtn.Name = "actorsBtn";
            actorsBtn.Size = new Size(157, 58);
            actorsBtn.TabIndex = 3;
            actorsBtn.Text = "Most Actors";
            actorsBtn.UseVisualStyleBackColor = true;
            actorsBtn.Click += button4_Click;
            // 
            // startTB
            // 
            startTB.ForeColor = Color.Gray;
            startTB.Location = new Point(40, 148);
            startTB.Name = "startTB";
            startTB.Size = new Size(189, 23);
            startTB.TabIndex = 4;
            startTB.Text = "Enter start of a movie name...";
            startTB.TextChanged += textBox1_TextChanged;
            startTB.GotFocus += textBox1_Gotfocus;
            startTB.LostFocus += textBox1_LostFocus;
            // 
            // output
            // 
            output.AllowUserToAddRows = false;
            output.AllowUserToDeleteRows = false;
            output.AllowUserToResizeColumns = false;
            output.AllowUserToResizeRows = false;
            output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            output.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            output.Location = new Point(40, 200);
            output.Name = "output";
            output.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            output.RowsDefaultCellStyle = dataGridViewCellStyle1;
            output.RowTemplate.Height = 25;
            output.SelectionMode = DataGridViewSelectionMode.CellSelect;
            output.Size = new Size(700, 230);
            output.TabIndex = 7;
            output.CellContentClick += output_CellContentClick;
            // 
            // greatestRad
            // 
            greatestRad.AutoCheck = false;
            greatestRad.Checked = true;
            greatestRad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            greatestRad.Location = new Point(622, 56);
            greatestRad.Name = "greatestRad";
            greatestRad.Size = new Size(150, 35);
            greatestRad.TabIndex = 8;
            greatestRad.TabStop = true;
            greatestRad.Text = "Greatest";
            greatestRad.UseVisualStyleBackColor = true;
            greatestRad.CheckedChanged += greatestRad_CheckedChanged;
            greatestRad.Click += greatestRadClick;
            // 
            // leastRad
            // 
            leastRad.AutoCheck = false;
            leastRad.AutoSize = true;
            leastRad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            leastRad.Location = new Point(622, 97);
            leastRad.Name = "leastRad";
            leastRad.Size = new Size(73, 29);
            leastRad.TabIndex = 9;
            leastRad.TabStop = true;
            leastRad.Text = "Least";
            leastRad.UseVisualStyleBackColor = true;
            leastRad.Click += leastRadClick;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 17);
            label1.Name = "label1";
            label1.Size = new Size(542, 34);
            label1.TabIndex = 10;
            label1.Text = "Movie Statistics";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(622, 17);
            label2.Name = "label2";
            label2.Size = new Size(118, 34);
            label2.TabIndex = 11;
            label2.Text = "Sort By:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // startRad
            // 
            startRad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            startRad.Location = new Point(334, 147);
            startRad.Name = "startRad";
            startRad.Size = new Size(114, 24);
            startRad.TabIndex = 12;
            startRad.Text = "Starts With..";
            startRad.UseVisualStyleBackColor = true;
            startRad.Click += startRadClick;
            // 
            // containRad
            // 
            containRad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            containRad.Location = new Point(444, 148);
            containRad.Name = "containRad";
            containRad.Size = new Size(96, 24);
            containRad.TabIndex = 13;
            containRad.TabStop = true;
            containRad.Text = "..Contains..";
            containRad.UseVisualStyleBackColor = true;
            containRad.Click += containRadClick;
            // 
            // endRad
            // 
            endRad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            endRad.Location = new Point(551, 149);
            endRad.Name = "endRad";
            endRad.Size = new Size(100, 20);
            endRad.TabIndex = 14;
            endRad.TabStop = true;
            endRad.Text = "..Ends With";
            endRad.UseVisualStyleBackColor = true;
            endRad.Click += endRadClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(endRad);
            Controls.Add(containRad);
            Controls.Add(startRad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(leastRad);
            Controls.Add(greatestRad);
            Controls.Add(output);
            Controls.Add(startTB);
            Controls.Add(actorsBtn);
            Controls.Add(votedBtn);
            Controls.Add(submitBtn);
            Controls.Add(ratedBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ratedBtn;
        private Button submitBtn;
        private Button votedBtn;
        private Button actorsBtn;
        private TextBox startTB;
        private DataGridView output;
        private RadioButton greatestRad;
        private RadioButton leastRad;
        private Label label1;
        private Label label2;
        private RadioButton startRad;
        private RadioButton containRad;
        private RadioButton endRad;
    }
}