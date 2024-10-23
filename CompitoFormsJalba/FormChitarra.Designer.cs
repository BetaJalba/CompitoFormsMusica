namespace CompitoFormsJalba
{
    partial class FormChitarra
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
            numSuono = new NumericUpDown();
            lblSuono = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numSuono).BeginInit();
            SuspendLayout();
            // 
            // numSuono
            // 
            numSuono.Location = new Point(25, 42);
            numSuono.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSuono.Name = "numSuono";
            numSuono.Size = new Size(84, 23);
            numSuono.TabIndex = 1;
            // 
            // lblSuono
            // 
            lblSuono.AutoSize = true;
            lblSuono.Location = new Point(25, 24);
            lblSuono.Name = "lblSuono";
            lblSuono.Size = new Size(84, 15);
            lblSuono.TabIndex = 2;
            lblSuono.Text = "Qualità suono:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Aggiungi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormChitarra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(133, 128);
            Controls.Add(btnAdd);
            Controls.Add(lblSuono);
            Controls.Add(numSuono);
            Name = "FormChitarra";
            Text = "FormChitarra";
            ((System.ComponentModel.ISupportInitialize)numSuono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSuono;
        private Label lblSuono;
        private Button btnAdd;
    }
}