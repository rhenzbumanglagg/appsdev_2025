namespace SimpleFormsAppWithCheckedListBox
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
            label1 = new Label();
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            dltBtn = new Button();
            clrBtn = new Button();
            addBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(89, 31);
            label1.Name = "label1";
            label1.Size = new Size(628, 53);
            label1.TabIndex = 0;
            label1.Text = "MY FAVORITE MOVIE PICKER APP";
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.Black;
            checkedListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkedListBox.ForeColor = Color.FromArgb(192, 0, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(128, 120);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(166, 220);
            checkedListBox.TabIndex = 1;
            // 
            // listBox
            // 
            listBox.BackColor = Color.Black;
            listBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            listBox.ForeColor = Color.FromArgb(192, 0, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 21;
            listBox.Location = new Point(417, 120);
            listBox.Name = "listBox";
            listBox.Size = new Size(166, 214);
            listBox.TabIndex = 2;
            // 
            // dltBtn
            // 
            dltBtn.BackColor = SystemColors.ActiveCaptionText;
            dltBtn.Font = new Font("Segoe Script", 9F);
            dltBtn.ForeColor = SystemColors.ControlLightLight;
            dltBtn.Location = new Point(408, 371);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(75, 34);
            dltBtn.TabIndex = 4;
            dltBtn.Text = "REMOVE";
            dltBtn.UseVisualStyleBackColor = false;
            dltBtn.Click += dltBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = SystemColors.ActiveCaptionText;
            clrBtn.Font = new Font("Segoe Script", 9F);
            clrBtn.ForeColor = SystemColors.ControlLightLight;
            clrBtn.Location = new Point(508, 371);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(75, 34);
            clrBtn.TabIndex = 5;
            clrBtn.Text = "CLEAR";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ActiveCaptionText;
            addBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(128, 371);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 34);
            addBtn.TabIndex = 6;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.netf;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(addBtn);
            Controls.Add(clrBtn);
            Controls.Add(dltBtn);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button dltBtn;
        private Button clrBtn;
        private Button addBtn;
    }
}
