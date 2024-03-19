﻿namespace MetaData_Demo
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            artistBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            albumBox = new TextBox();
            label6 = new Label();
            yearBox = new TextBox();
            label4 = new Label();
            trackBox = new TextBox();
            label7 = new Label();
            titleBox = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 119);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "File Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 167);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // artistBox
            // 
            artistBox.Location = new Point(446, 164);
            artistBox.Name = "artistBox";
            artistBox.Size = new Size(327, 23);
            artistBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 167);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Artist";
            // 
            // button1
            // 
            button1.Location = new Point(800, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Browse:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 209);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "Album:";
            // 
            // albumBox
            // 
            albumBox.Location = new Point(446, 206);
            albumBox.Name = "albumBox";
            albumBox.Size = new Size(327, 23);
            albumBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 252);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 9;
            label6.Text = "Year:";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(446, 249);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(327, 23);
            yearBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 295);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 11;
            label4.Text = "Track Number:";
            // 
            // trackBox
            // 
            trackBox.Location = new Point(446, 292);
            trackBox.Name = "trackBox";
            trackBox.Size = new Size(327, 23);
            trackBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 333);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 13;
            label7.Text = "Title:";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(446, 330);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(327, 23);
            titleBox.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(1161, 68);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1032, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 454);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureButton
            // 
            pictureButton.Location = new Point(1032, 68);
            pictureButton.Name = "pictureButton";
            pictureButton.Size = new Size(75, 23);
            pictureButton.TabIndex = 16;
            pictureButton.Text = "Picture Box";
            pictureButton.UseVisualStyleBackColor = true;
            pictureButton.Click += pictureButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 675);
            Controls.Add(pictureButton);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(titleBox);
            Controls.Add(label4);
            Controls.Add(trackBox);
            Controls.Add(label6);
            Controls.Add(yearBox);
            Controls.Add(label5);
            Controls.Add(albumBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(artistBox);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Metadata App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox artistBox;
        private Label label3;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private TextBox trackBox;
        private Label label5;
        private TextBox albumBox;
        private Label label6;
        private TextBox yearBox;
        private Label label7;
        private TextBox titleBox;
        private Button button2;
        private PictureBox pictureBox1;
        private Button pictureButton;
    }
}
