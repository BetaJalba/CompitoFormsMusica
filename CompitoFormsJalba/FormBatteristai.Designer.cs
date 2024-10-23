namespace CompitoFormsJalba
{
    partial class FormBatteristai
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
            txtNome = new TextBox();
            lblNome = new Label();
            cekBoxPlaying = new CheckBox();
            btnAdd = new Button();
            lblSkill = new Label();
            numSkill = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSkill).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(29, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(105, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome (opzionale):";
            // 
            // cekBoxPlaying
            // 
            cekBoxPlaying.AutoSize = true;
            cekBoxPlaying.Location = new Point(29, 89);
            cekBoxPlaying.Name = "cekBoxPlaying";
            cekBoxPlaying.Size = new Size(98, 19);
            cekBoxPlaying.TabIndex = 2;
            cekBoxPlaying.Text = "Sta suonando";
            cekBoxPlaying.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 188);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Aggiungi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(29, 122);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(59, 15);
            lblSkill.TabIndex = 5;
            lblSkill.Text = "Destrezza:";
            // 
            // numSkill
            // 
            numSkill.Location = new Point(29, 140);
            numSkill.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSkill.Name = "numSkill";
            numSkill.Size = new Size(98, 23);
            numSkill.TabIndex = 4;
            // 
            // FormBatteristai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(155, 241);
            Controls.Add(btnAdd);
            Controls.Add(lblSkill);
            Controls.Add(numSkill);
            Controls.Add(cekBoxPlaying);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "FormBatteristai";
            Text = "FormBatteristai";
            Load += FormBatteristai_Load;
            ((System.ComponentModel.ISupportInitialize)numSkill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private CheckBox cekBoxPlaying;
        private Button btnAdd;
        private Label lblSkill;
        private NumericUpDown numSkill;
    }
}