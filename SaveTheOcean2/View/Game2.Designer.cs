namespace SaveTheOcean2.View
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            lbl_msgRescate = new Label();
            lbl_FitxaRescat = new Label();
            lbl_choose = new Label();
            butt_curar = new Button();
            butt_trasladar = new Button();
            butt_menu = new Button();
            lbl_msgtreatment = new Label();
            lbl_msgxp = new Label();
            SuspendLayout();
            // 
            // lbl_msgRescate
            // 
            lbl_msgRescate.AutoSize = true;
            lbl_msgRescate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgRescate.ForeColor = Color.White;
            lbl_msgRescate.Location = new Point(12, 9);
            lbl_msgRescate.Name = "lbl_msgRescate";
            lbl_msgRescate.Size = new Size(113, 25);
            lbl_msgRescate.TabIndex = 1;
            lbl_msgRescate.Text = "msgRescate";
            // 
            // lbl_FitxaRescat
            // 
            lbl_FitxaRescat.AutoSize = true;
            lbl_FitxaRescat.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FitxaRescat.ForeColor = Color.White;
            lbl_FitxaRescat.Location = new Point(16, 60);
            lbl_FitxaRescat.Name = "lbl_FitxaRescat";
            lbl_FitxaRescat.Size = new Size(121, 23);
            lbl_FitxaRescat.TabIndex = 3;
            lbl_FitxaRescat.Text = "msgfitxarescat";
            // 
            // lbl_choose
            // 
            lbl_choose.AutoSize = true;
            lbl_choose.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_choose.ForeColor = Color.White;
            lbl_choose.Location = new Point(298, 60);
            lbl_choose.Name = "lbl_choose";
            lbl_choose.Size = new Size(108, 25);
            lbl_choose.TabIndex = 4;
            lbl_choose.Text = "msgchoose";
            // 
            // butt_curar
            // 
            butt_curar.FlatAppearance.BorderSize = 12;
            butt_curar.Font = new Font("Bahnschrift SemiLight", 15.25F, FontStyle.Bold);
            butt_curar.ForeColor = SystemColors.Highlight;
            butt_curar.Location = new Point(12, 392);
            butt_curar.Name = "butt_curar";
            butt_curar.Size = new Size(125, 46);
            butt_curar.TabIndex = 5;
            butt_curar.Text = "Curar";
            butt_curar.UseVisualStyleBackColor = true;
            butt_curar.Click += butt_heal_Click;
            // 
            // butt_trasladar
            // 
            butt_trasladar.Font = new Font("Bahnschrift SemiLight", 15.25F, FontStyle.Bold);
            butt_trasladar.ForeColor = SystemColors.Highlight;
            butt_trasladar.Location = new Point(156, 392);
            butt_trasladar.Name = "butt_trasladar";
            butt_trasladar.Size = new Size(125, 46);
            butt_trasladar.TabIndex = 6;
            butt_trasladar.Text = "Trasladar";
            butt_trasladar.UseVisualStyleBackColor = true;
            butt_trasladar.Click += butt_move_Click;
            // 
            // butt_menu
            // 
            butt_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_menu.ForeColor = SystemColors.Highlight;
            butt_menu.Location = new Point(12, 269);
            butt_menu.Name = "butt_menu";
            butt_menu.Size = new Size(113, 46);
            butt_menu.TabIndex = 7;
            butt_menu.Text = "Menu";
            butt_menu.UseVisualStyleBackColor = true;
            butt_menu.Visible = false;
            butt_menu.Click += butt_gomenu_Click;
            // 
            // lbl_msgtreatment
            // 
            lbl_msgtreatment.AutoSize = true;
            lbl_msgtreatment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgtreatment.ForeColor = Color.White;
            lbl_msgtreatment.Location = new Point(12, 133);
            lbl_msgtreatment.Name = "lbl_msgtreatment";
            lbl_msgtreatment.Size = new Size(135, 25);
            lbl_msgtreatment.TabIndex = 8;
            lbl_msgtreatment.Text = "msgTreatment";
            lbl_msgtreatment.Visible = false;
            // 
            // lbl_msgxp
            // 
            lbl_msgxp.AutoSize = true;
            lbl_msgxp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgxp.ForeColor = Color.White;
            lbl_msgxp.Location = new Point(12, 174);
            lbl_msgxp.Name = "lbl_msgxp";
            lbl_msgxp.Size = new Size(69, 25);
            lbl_msgxp.TabIndex = 9;
            lbl_msgxp.Text = "msgxp";
            lbl_msgxp.Visible = false;
            // 
            // Game2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(980, 450);
            Controls.Add(lbl_msgxp);
            Controls.Add(lbl_msgtreatment);
            Controls.Add(butt_menu);
            Controls.Add(butt_trasladar);
            Controls.Add(butt_curar);
            Controls.Add(lbl_choose);
            Controls.Add(lbl_FitxaRescat);
            Controls.Add(lbl_msgRescate);
            ForeColor = Color.FromArgb(64, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game2";
            Text = "FormGame";
            Load += Game2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_txtInfo;
        private Label lbl_msgRescate;
        private Label lbl_FitxaRescat;
        private Label lbl_choose;
        private Button butt_curar;
        private Button butt_trasladar;
        private Button butt_menu;
        private Label lbl_msgtreatment;
        private Label lbl_msgxp;
    }
}