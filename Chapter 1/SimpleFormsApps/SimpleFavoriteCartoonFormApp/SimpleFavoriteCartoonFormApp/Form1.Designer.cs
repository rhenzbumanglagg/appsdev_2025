namespace SimpleFavoriteCartoonFormApp
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
            comboBox1 = new ComboBox();
            btnView = new Button();
            btnClr = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(471, 37);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite  Cartoon Character Picker";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe Print", 9.75F, FontStyle.Italic);
            btnView.Location = new Point(81, 225);
            btnView.Name = "btnView";
            btnView.Size = new Size(109, 35);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnClr
            // 
            btnClr.Font = new Font("Segoe Print", 9.75F, FontStyle.Italic);
            btnClr.Location = new Point(81, 292);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(109, 33);
            btnClr.TabIndex = 3;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(317, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 163);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnClr);
            Controls.Add(btnView);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnView;
        private Button btnClr;
        private PictureBox pictureBox1;
    }
}
