namespace SaveTheOcean2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            lbl_saveocean = new Label();
            butt_jugar = new Button();
            butt_salir = new Button();
            butt_rescates = new Button();
            SuspendLayout();
            // 
            // lbl_saveocean
            // 
            lbl_saveocean.Font = new Font("Segoe Fluent Icons", 57.85F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saveocean.Location = new Point(133, 63);
            lbl_saveocean.Name = "lbl_saveocean";
            lbl_saveocean.Size = new Size(562, 116);
            lbl_saveocean.TabIndex = 0;
            lbl_saveocean.Text = "Save the ocean";
            lbl_saveocean.TextAlign = ContentAlignment.MiddleCenter;
            lbl_saveocean.Click += lblTitle_Click;
            // 
            // butt_jugar
            // 
            butt_jugar.Font = new Font("Bahnschrift SemiLight", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_jugar.Location = new Point(99, 206);
            butt_jugar.Name = "butt_jugar";
            butt_jugar.Size = new Size(277, 117);
            butt_jugar.TabIndex = 1;
            butt_jugar.Text = "Jugar";
            butt_jugar.UseVisualStyleBackColor = true;
            butt_jugar.Click += butt_start_Click;
            // 
            // butt_salir
            // 
            butt_salir.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_salir.Location = new Point(698, 397);
            butt_salir.Name = "butt_salir";
            butt_salir.Size = new Size(90, 41);
            butt_salir.TabIndex = 2;
            butt_salir.Text = "Salir";
            butt_salir.UseVisualStyleBackColor = true;
            butt_salir.Click += butt_leave_Click;
            // 
            // butt_rescates
            // 
            butt_rescates.Font = new Font("Bahnschrift SemiLight", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_rescates.Location = new Point(428, 206);
            butt_rescates.Name = "butt_rescates";
            butt_rescates.Size = new Size(277, 117);
            butt_rescates.TabIndex = 3;
            butt_rescates.Text = "Rescates";
            butt_rescates.UseVisualStyleBackColor = true;
            butt_rescates.Click += butt_rescued_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(butt_rescates);
            Controls.Add(butt_salir);
            Controls.Add(butt_jugar);
            Controls.Add(lbl_saveocean);
            ForeColor = SystemColors.MenuHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            Text = "Save the ocean";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_saveocean;
        private Button butt_jugar;
        private Button butt_salir;
        private Button butt_rescates;
    }
}
