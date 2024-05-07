namespace SaveTheOcean2
{
    partial class Play
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            lbl_rol = new Label();
            butt_tecnico = new Button();
            butt_veterinario = new Button();
            lbl_nombre = new Label();
            txtBoxName = new TextBox();
            NameProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NameProvider).BeginInit();
            SuspendLayout();
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rol.ForeColor = SystemColors.ControlLightLight;
            lbl_rol.Location = new Point(173, 235);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(120, 25);
            lbl_rol.TabIndex = 0;
            lbl_rol.Text = "Escoje tu rol";
            // 
            // butt_tecnico
            // 
            butt_tecnico.Enabled = false;
            butt_tecnico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_tecnico.ForeColor = SystemColors.MenuHighlight;
            butt_tecnico.Location = new Point(299, 227);
            butt_tecnico.Name = "butt_tecnico";
            butt_tecnico.Size = new Size(189, 40);
            butt_tecnico.TabIndex = 1;
            butt_tecnico.Text = "Tecnico (45 XP)";
            butt_tecnico.UseVisualStyleBackColor = true;
            butt_tecnico.Click += butt_tecnic_Click;
            // 
            // butt_veterinario
            // 
            butt_veterinario.Enabled = false;
            butt_veterinario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_veterinario.ForeColor = SystemColors.MenuHighlight;
            butt_veterinario.Location = new Point(494, 227);
            butt_veterinario.Name = "butt_veterinario";
            butt_veterinario.Size = new Size(189, 40);
            butt_veterinario.TabIndex = 2;
            butt_veterinario.Text = "Veterinario (80 XP)";
            butt_veterinario.UseVisualStyleBackColor = true;
            butt_veterinario.Click += butt_veterinari_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = SystemColors.ControlLightLight;
            lbl_nombre.Location = new Point(97, 170);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(196, 25);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Introduce el nombre";
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(299, 167);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(384, 33);
            txtBoxName.TabIndex = 4;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            txtBoxName.Validating += txtBoxName_Validating;
            // 
            // NameProvider
            // 
            NameProvider.ContainerControl = this;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxName);
            Controls.Add(lbl_nombre);
            Controls.Add(butt_veterinario);
            Controls.Add(butt_tecnico);
            Controls.Add(lbl_rol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Play";
            Text = "FormRol";
            ((System.ComponentModel.ISupportInitialize)NameProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_rol;
        private Button butt_tecnico;
        private Button butt_veterinario;
        private Label lbl_nombre;
        private TextBox txtBoxName;
        private ErrorProvider NameProvider;
    }
}