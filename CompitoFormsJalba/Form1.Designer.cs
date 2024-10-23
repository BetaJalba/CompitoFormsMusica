namespace CompitoFormsJalba
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
            lblLista = new Label();
            lstBoxLista = new ListBox();
            radBtnChitarra = new RadioButton();
            radBtnBatterista = new RadioButton();
            btnAdd = new Button();
            label1 = new Label();
            btnRemove = new Button();
            panel1 = new Panel();
            btnAddVolume = new Button();
            txtNuovoNome = new TextBox();
            button2 = new Button();
            btnCompare = new Button();
            btnPlaying = new Button();
            btnBatterista = new Button();
            lblInfo = new Label();
            button1 = new Button();
            lblOptions = new Label();
            label2 = new Label();
            btnPrimaChitarra = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(12, 9);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(62, 15);
            lblLista.TabIndex = 0;
            lblLista.Text = "Strumenti:";
            // 
            // lstBoxLista
            // 
            lstBoxLista.FormattingEnabled = true;
            lstBoxLista.ItemHeight = 15;
            lstBoxLista.Location = new Point(12, 27);
            lstBoxLista.Name = "lstBoxLista";
            lstBoxLista.Size = new Size(365, 34);
            lstBoxLista.TabIndex = 1;
            // 
            // radBtnChitarra
            // 
            radBtnChitarra.AutoSize = true;
            radBtnChitarra.Location = new Point(12, 77);
            radBtnChitarra.Name = "radBtnChitarra";
            radBtnChitarra.Size = new Size(67, 19);
            radBtnChitarra.TabIndex = 2;
            radBtnChitarra.TabStop = true;
            radBtnChitarra.Text = "Chitarra";
            radBtnChitarra.UseVisualStyleBackColor = true;
            // 
            // radBtnBatterista
            // 
            radBtnBatterista.AutoSize = true;
            radBtnBatterista.Location = new Point(96, 77);
            radBtnBatterista.Name = "radBtnBatterista";
            radBtnBatterista.Size = new Size(74, 19);
            radBtnBatterista.TabIndex = 3;
            radBtnBatterista.TabStop = true;
            radBtnBatterista.Text = "Batterista";
            radBtnBatterista.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Aggiungi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 5;
            label1.Text = "Crea max 3 per tipo";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(302, 73);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Rimuovi";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnPrimaChitarra);
            panel1.Controls.Add(btnAddVolume);
            panel1.Controls.Add(txtNuovoNome);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCompare);
            panel1.Controls.Add(btnPlaying);
            panel1.Controls.Add(btnBatterista);
            panel1.Controls.Add(lblInfo);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 240);
            panel1.TabIndex = 7;
            // 
            // btnAddVolume
            // 
            btnAddVolume.Location = new Point(277, 15);
            btnAddVolume.Name = "btnAddVolume";
            btnAddVolume.Size = new Size(75, 23);
            btnAddVolume.TabIndex = 12;
            btnAddVolume.Text = "Aumenta Volume";
            btnAddVolume.UseVisualStyleBackColor = true;
            btnAddVolume.Click += btnAddVolume_Click;
            // 
            // txtNuovoNome
            // 
            txtNuovoNome.Location = new Point(115, 16);
            txtNuovoNome.Name = "txtNuovoNome";
            txtNuovoNome.Size = new Size(75, 23);
            txtNuovoNome.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(277, 44);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 10;
            button2.Text = "Diminuisci volume";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(196, 44);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(75, 41);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "Confronta chitarre";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnPlaying
            // 
            btnPlaying.Location = new Point(13, 44);
            btnPlaying.Name = "btnPlaying";
            btnPlaying.Size = new Size(75, 41);
            btnPlaying.TabIndex = 3;
            btnPlaying.Text = "Print playing";
            btnPlaying.UseVisualStyleBackColor = true;
            btnPlaying.Click += btnPlaying_Click;
            // 
            // btnBatterista
            // 
            btnBatterista.Location = new Point(115, 44);
            btnBatterista.Name = "btnBatterista";
            btnBatterista.Size = new Size(75, 41);
            btnBatterista.TabIndex = 2;
            btnBatterista.Text = "Rinomina batterista";
            btnBatterista.UseVisualStyleBackColor = true;
            btnBatterista.Click += btnBatterista_Click;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(22, 100);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(323, 123);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Qui verranno mostrate";
            // 
            // button1
            // 
            button1.Location = new Point(13, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Print all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(12, 123);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(56, 15);
            lblOptions.TabIndex = 8;
            lblOptions.Text = "Controlli:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 9;
            label2.Text = "Max 5 elementi";
            // 
            // btnPrimaChitarra
            // 
            btnPrimaChitarra.Location = new Point(196, 16);
            btnPrimaChitarra.Name = "btnPrimaChitarra";
            btnPrimaChitarra.Size = new Size(75, 23);
            btnPrimaChitarra.TabIndex = 13;
            btnPrimaChitarra.Text = "Prima Chitarra";
            btnPrimaChitarra.UseVisualStyleBackColor = true;
            btnPrimaChitarra.Click += btnPrimaChitarra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 396);
            Controls.Add(label2);
            Controls.Add(lblOptions);
            Controls.Add(panel1);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(radBtnBatterista);
            Controls.Add(radBtnChitarra);
            Controls.Add(lstBoxLista);
            Controls.Add(lblLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLista;
        private ListBox lstBoxLista;
        private RadioButton radBtnChitarra;
        private RadioButton radBtnBatterista;
        private Button btnAdd;
        private Label label1;
        private Button btnRemove;
        private Panel panel1;
        private Button btnBatterista;
        private Label lblInfo;
        private Button button1;
        private Label lblOptions;
        private Button btnCompare;
        private Button btnPlaying;
        private Label label2;
        private Button button2;
        private TextBox txtNuovoNome;
        private Button btnAddVolume;
        private Button btnPrimaChitarra;
    }
}