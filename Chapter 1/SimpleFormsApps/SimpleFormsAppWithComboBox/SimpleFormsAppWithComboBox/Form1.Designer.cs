namespace SimpleFormsAppWithComboBox
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
            checkedListBox = new CheckedListBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            slcBtn = new Button();
            label2 = new Label();
            listBox = new ListBox();
            addBtn = new Button();
            dltBtn = new Button();
            clrBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.IndianRed;
            checkedListBox.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox.ForeColor = Color.FromArgb(192, 255, 255);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(173, 169);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(215, 256);
            checkedListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(407, 33);
            label1.TabIndex = 1;
            label1.Text = "FAVORITE FOOD PICKER APP";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Salmon;
            comboBox1.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(224, 224, 224);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 31);
            comboBox1.TabIndex = 2;
            // 
            // slcBtn
            // 
            slcBtn.BackColor = Color.FromArgb(255, 192, 192);
            slcBtn.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            slcBtn.ForeColor = Color.Maroon;
            slcBtn.Location = new Point(18, 286);
            slcBtn.Name = "slcBtn";
            slcBtn.Size = new Size(119, 39);
            slcBtn.TabIndex = 3;
            slcBtn.Text = "SELECT";
            slcBtn.UseVisualStyleBackColor = false;
            slcBtn.Click += slcBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Handwriting", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(38, 149);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 4;
            label2.Text = "Cuisine";
            // 
            // listBox
            // 
            listBox.BackColor = Color.IndianRed;
            listBox.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.ForeColor = Color.FromArgb(192, 255, 255);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 23;
            listBox.Location = new Point(481, 166);
            listBox.Name = "listBox";
            listBox.Size = new Size(217, 257);
            listBox.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(255, 192, 192);
            addBtn.Font = new Font("Segoe Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.Maroon;
            addBtn.Location = new Point(173, 451);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(129, 37);
            addBtn.TabIndex = 6;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.BackColor = Color.FromArgb(255, 192, 192);
            dltBtn.Font = new Font("Segoe Script", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dltBtn.ForeColor = Color.Maroon;
            dltBtn.Location = new Point(762, 216);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(114, 44);
            dltBtn.TabIndex = 7;
            dltBtn.Text = "REMOVE";
            dltBtn.UseVisualStyleBackColor = false;
            dltBtn.Click += dltBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.FromArgb(255, 192, 192);
            clrBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrBtn.ForeColor = Color.Maroon;
            clrBtn.Location = new Point(762, 337);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(114, 42);
            clrBtn.TabIndex = 8;
            clrBtn.Text = "CLEAR ALL";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(190, 124);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 9;
            label3.Text = "FOOD LIST";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(481, 122);
            label4.Name = "label4";
            label4.Size = new Size(270, 33);
            label4.TabIndex = 10;
            label4.Text = "MY FAVORITE FOOD LIST";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 532);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(clrBtn);
            Controls.Add(dltBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox);
            Controls.Add(label2);
            Controls.Add(slcBtn);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(checkedListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox;
        private Label label1;
        private ComboBox comboBox1;
        private Button slcBtn;
        private Label label2;
        private ListBox listBox;
        private Button addBtn;
        private Button dltBtn;
        private Button clrBtn;
        private Label label3;
        private Label label4;
    }
}
