namespace MidtermGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            label1 = new Label();
            lblMeasure = new Label();
            textTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 231);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(559, 97);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Converter App";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(238, 673);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 34);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(538, 675);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(835, 679);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Indigo;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(587, 335);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(168, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Inches to Meters";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Indigo;
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(587, 361);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(168, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Meters to Inches";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Indigo;
            textBox2.Location = new Point(797, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(355, 179);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 9;
            label1.Text = "Enter the value and choose conversion";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeasure
            // 
            lblMeasure.AutoSize = true;
            lblMeasure.BackColor = Color.Indigo;
            lblMeasure.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMeasure.ForeColor = SystemColors.ControlLightLight;
            lblMeasure.Location = new Point(587, 307);
            lblMeasure.Name = "lblMeasure";
            lblMeasure.Size = new Size(202, 25);
            lblMeasure.TabIndex = 10;
            lblMeasure.Text = "Convert Measurement";
            // 
            // textTotal
            // 
            textTotal.BackColor = Color.MediumPurple;
            textTotal.Location = new Point(583, 524);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(294, 31);
            textTotal.TabIndex = 11;
            textTotal.TextChanged += textTotal_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1153, 786);
            Controls.Add(textTotal);
            Controls.Add(lblMeasure);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private Label label1;
        private Label lblMeasure;
        private TextBox textTotal;
    }
}
