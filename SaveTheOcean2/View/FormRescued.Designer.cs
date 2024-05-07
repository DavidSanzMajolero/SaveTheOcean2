namespace SaveTheOcean2
{
    partial class FormRescued
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRescued));
            butt_back = new Button();
            dataGridView1 = new DataGridView();
            lbselectid = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // butt_back
            // 
            butt_back.Font = new Font("Bahnschrift SemiLight", 12.2F, FontStyle.Bold);
            butt_back.ForeColor = SystemColors.Highlight;
            butt_back.Location = new Point(12, 400);
            butt_back.Name = "butt_back";
            butt_back.Size = new Size(79, 38);
            butt_back.TabIndex = 0;
            butt_back.Text = "ATRAS";
            butt_back.UseVisualStyleBackColor = true;
            butt_back.Click += butt_back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 218);
            dataGridView1.TabIndex = 1;
            // 
            // lbselectid
            // 
            lbselectid.AutoSize = true;
            lbselectid.Font = new Font("Bahnschrift SemiLight", 13.25F, FontStyle.Bold);
            lbselectid.ForeColor = Color.White;
            lbselectid.Location = new Point(128, 327);
            lbselectid.Name = "lbselectid";
            lbselectid.Size = new Size(194, 22);
            lbselectid.TabIndex = 2;
            lbselectid.Text = "SELECT BY NUMBER";
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift SemiLight", 10.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(439, 324);
            button1.Name = "button1";
            button1.Size = new Size(71, 25);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 23);
            textBox1.TabIndex = 4;
            // 
            // FormRescued
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(lbselectid);
            Controls.Add(dataGridView1);
            Controls.Add(butt_back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormRescued";
            Text = "SELECT BY ID";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butt_back;
        public DataGridView dataGridView1;
        public DataGridView dataGridView2;
        private Label lbselectid;
        private Button button1;
        private TextBox textBox1;
    }
}