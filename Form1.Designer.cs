namespace tetsuota_marumasign_generator
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
            URL = new TextBox();
            label1 = new Label();
            posX = new TextBox();
            posY = new TextBox();
            posZ = new TextBox();
            sizeX = new TextBox();
            sizeY = new TextBox();
            rotationX = new TextBox();
            rotationY = new TextBox();
            rotationZ = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            output_label = new Label();
            filename_Textbox = new TextBox();
            SuspendLayout();
            // 
            // URL
            // 
            URL.Location = new Point(12, 49);
            URL.Name = "URL";
            URL.Size = new Size(310, 23);
            URL.TabIndex = 0;
            URL.Text = "ここにURLを貼り付ける";
            URL.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 1;
            label1.Text = "生成を押すとクリップボードにコピーされます";
            label1.Click += label1_Click;
            // 
            // posX
            // 
            posX.Location = new Point(12, 78);
            posX.Name = "posX";
            posX.Size = new Size(310, 23);
            posX.TabIndex = 2;
            posX.Text = "0";
            // 
            // posY
            // 
            posY.Location = new Point(12, 107);
            posY.Name = "posY";
            posY.Size = new Size(310, 23);
            posY.TabIndex = 3;
            posY.Text = "0";
            // 
            // posZ
            // 
            posZ.Location = new Point(12, 136);
            posZ.Name = "posZ";
            posZ.Size = new Size(310, 23);
            posZ.TabIndex = 4;
            posZ.Text = "0";
            // 
            // sizeX
            // 
            sizeX.Location = new Point(12, 165);
            sizeX.Name = "sizeX";
            sizeX.Size = new Size(310, 23);
            sizeX.TabIndex = 5;
            sizeX.Text = "0";
            // 
            // sizeY
            // 
            sizeY.Location = new Point(12, 194);
            sizeY.Name = "sizeY";
            sizeY.Size = new Size(310, 23);
            sizeY.TabIndex = 6;
            sizeY.Text = "0";
            // 
            // rotationX
            // 
            rotationX.Location = new Point(12, 223);
            rotationX.Name = "rotationX";
            rotationX.Size = new Size(310, 23);
            rotationX.TabIndex = 7;
            rotationX.Text = "0";
            // 
            // rotationY
            // 
            rotationY.Location = new Point(12, 252);
            rotationY.Name = "rotationY";
            rotationY.Size = new Size(310, 23);
            rotationY.TabIndex = 8;
            rotationY.Text = "0";
            // 
            // rotationZ
            // 
            rotationZ.Location = new Point(12, 281);
            rotationZ.Name = "rotationZ";
            rotationZ.Size = new Size(310, 23);
            rotationZ.TabIndex = 9;
            rotationZ.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(338, 49);
            button1.Name = "button1";
            button1.Size = new Size(217, 52);
            button1.TabIndex = 10;
            button1.Text = "生成(1.20)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(338, 165);
            button2.Name = "button2";
            button2.Size = new Size(217, 50);
            button2.TabIndex = 11;
            button2.Text = "txtファイルから読み出し";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 252);
            button3.Name = "button3";
            button3.Size = new Size(217, 50);
            button3.TabIndex = 12;
            button3.Text = "txtファイルに保存";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(338, 107);
            button4.Name = "button4";
            button4.Size = new Size(217, 52);
            button4.TabIndex = 13;
            button4.Text = "生成(1.21)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.Location = new Point(12, 332);
            output_label.Name = "output_label";
            output_label.Size = new Size(310, 15);
            output_label.TabIndex = 14;
            output_label.Text = "URL|位置X|位置Y|位置Z|大きさX|大きさY|回転X|回転Y|回転Z";
            // 
            // filename_Textbox
            // 
            filename_Textbox.Location = new Point(338, 223);
            filename_Textbox.Name = "filename_Textbox";
            filename_Textbox.Size = new Size(217, 23);
            filename_Textbox.TabIndex = 15;
            filename_Textbox.Text = "保存するファイル名または読み出すファイル名";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 356);
            Controls.Add(filename_Textbox);
            Controls.Add(output_label);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rotationZ);
            Controls.Add(rotationY);
            Controls.Add(rotationX);
            Controls.Add(sizeY);
            Controls.Add(sizeX);
            Controls.Add(posZ);
            Controls.Add(posY);
            Controls.Add(posX);
            Controls.Add(label1);
            Controls.Add(URL);
            Name = "Form1";
            Text = "まるまさいんジェネレータ　てつおたver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox URL;
        private Label label1;
        private TextBox posX;
        private TextBox posY;
        private TextBox posZ;
        private TextBox sizeX;
        private TextBox sizeY;
        private TextBox rotationX;
        private TextBox rotationY;
        private TextBox rotationZ;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label output_label;
        private TextBox filename_Textbox;
    }
}
