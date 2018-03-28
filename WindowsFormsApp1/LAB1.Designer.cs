namespace WindowsFormsApp1
{
    partial class LAB1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addComboBox = new System.Windows.Forms.Button();
            this.sentRes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.UnturnButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Yes1 = new System.Windows.Forms.RadioButton();
            this.No1 = new System.Windows.Forms.RadioButton();
            this.Middle1 = new System.Windows.Forms.RadioButton();
            this.Yes2 = new System.Windows.Forms.RadioButton();
            this.No2 = new System.Windows.Forms.RadioButton();
            this.Middle2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Yes3 = new System.Windows.Forms.RadioButton();
            this.Yes5 = new System.Windows.Forms.RadioButton();
            this.Yes4 = new System.Windows.Forms.RadioButton();
            this.No3 = new System.Windows.Forms.RadioButton();
            this.No4 = new System.Windows.Forms.RadioButton();
            this.No5 = new System.Windows.Forms.RadioButton();
            this.Middle3 = new System.Windows.Forms.RadioButton();
            this.Middle4 = new System.Windows.Forms.RadioButton();
            this.Middle5 = new System.Windows.Forms.RadioButton();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Yes6 = new System.Windows.Forms.RadioButton();
            this.No6 = new System.Windows.Forms.RadioButton();
            this.Middle6 = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnturnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 63);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.addComboBox);
            this.panel3.Controls.Add(this.sentRes);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 709);
            this.panel3.TabIndex = 2;
            // 
            // addComboBox
            // 
            this.addComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addComboBox.ForeColor = System.Drawing.Color.White;
            this.addComboBox.Location = new System.Drawing.Point(12, 57);
            this.addComboBox.Name = "addComboBox";
            this.addComboBox.Size = new System.Drawing.Size(110, 42);
            this.addComboBox.TabIndex = 26;
            this.addComboBox.Text = "Добавить";
            this.addComboBox.UseVisualStyleBackColor = false;
            this.addComboBox.Click += new System.EventHandler(this.addComboBox_Click);
            // 
            // sentRes
            // 
            this.sentRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sentRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sentRes.ForeColor = System.Drawing.Color.White;
            this.sentRes.Location = new System.Drawing.Point(12, 655);
            this.sentRes.Name = "sentRes";
            this.sentRes.Size = new System.Drawing.Size(110, 42);
            this.sentRes.TabIndex = 3;
            this.sentRes.Text = "Отправить";
            this.sentRes.UseVisualStyleBackColor = false;
            this.sentRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.TurnButton);
            this.panel4.Controls.Add(this.UnturnButton);
            this.panel4.Controls.Add(this.CloseButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 39);
            this.panel4.TabIndex = 2;
            // 
            // TurnButton
            // 
            this.TurnButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnButton.Image")));
            this.TurnButton.Location = new System.Drawing.Point(28, 3);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(19, 18);
            this.TurnButton.TabIndex = 3;
            this.TurnButton.TabStop = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // UnturnButton
            // 
            this.UnturnButton.Image = ((System.Drawing.Image)(resources.GetObject("UnturnButton.Image")));
            this.UnturnButton.Location = new System.Drawing.Point(50, 3);
            this.UnturnButton.Name = "UnturnButton";
            this.UnturnButton.Size = new System.Drawing.Size(19, 18);
            this.UnturnButton.TabIndex = 2;
            this.UnturnButton.TabStop = false;
            this.UnturnButton.Click += new System.EventHandler(this.UnturnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Yes1
            // 
            this.Yes1.AutoSize = true;
            this.Yes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes1.Location = new System.Drawing.Point(765, 78);
            this.Yes1.Name = "Yes1";
            this.Yes1.Size = new System.Drawing.Size(48, 24);
            this.Yes1.TabIndex = 5;
            this.Yes1.TabStop = true;
            this.Yes1.Text = "Да";
            this.Yes1.UseVisualStyleBackColor = true;
            // 
            // No1
            // 
            this.No1.AutoSize = true;
            this.No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No1.Location = new System.Drawing.Point(844, 78);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(57, 24);
            this.No1.TabIndex = 6;
            this.No1.TabStop = true;
            this.No1.Text = "Нет";
            this.No1.UseVisualStyleBackColor = true;
            // 
            // Middle1
            // 
            this.Middle1.AutoSize = true;
            this.Middle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle1.Location = new System.Drawing.Point(919, 78);
            this.Middle1.Name = "Middle1";
            this.Middle1.Size = new System.Drawing.Size(119, 24);
            this.Middle1.TabIndex = 7;
            this.Middle1.TabStop = true;
            this.Middle1.Text = "Воздержусь";
            this.Middle1.UseVisualStyleBackColor = true;
            // 
            // Yes2
            // 
            this.Yes2.AutoSize = true;
            this.Yes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes2.Location = new System.Drawing.Point(765, 125);
            this.Yes2.Name = "Yes2";
            this.Yes2.Size = new System.Drawing.Size(48, 24);
            this.Yes2.TabIndex = 9;
            this.Yes2.TabStop = true;
            this.Yes2.Text = "Да";
            this.Yes2.UseVisualStyleBackColor = true;
            // 
            // No2
            // 
            this.No2.AutoSize = true;
            this.No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No2.Location = new System.Drawing.Point(844, 127);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(57, 24);
            this.No2.TabIndex = 10;
            this.No2.TabStop = true;
            this.No2.Text = "Нет";
            this.No2.UseVisualStyleBackColor = true;
            // 
            // Middle2
            // 
            this.Middle2.AutoSize = true;
            this.Middle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle2.Location = new System.Drawing.Point(919, 127);
            this.Middle2.Name = "Middle2";
            this.Middle2.Size = new System.Drawing.Size(119, 24);
            this.Middle2.TabIndex = 11;
            this.Middle2.TabStop = true;
            this.Middle2.Text = "Воздержусь";
            this.Middle2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(583, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Выберите вариант";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(582, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "Выберите вариант";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 172);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(583, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.Text = "Выберите вариант";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(143, 216);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(582, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.Text = "Выберите вариант";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(144, 261);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(582, 21);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.Text = "Выберите вариант";
            // 
            // Yes3
            // 
            this.Yes3.AutoSize = true;
            this.Yes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes3.Location = new System.Drawing.Point(765, 172);
            this.Yes3.Name = "Yes3";
            this.Yes3.Size = new System.Drawing.Size(48, 24);
            this.Yes3.TabIndex = 17;
            this.Yes3.TabStop = true;
            this.Yes3.Text = "Да";
            this.Yes3.UseVisualStyleBackColor = true;
            // 
            // Yes5
            // 
            this.Yes5.AutoSize = true;
            this.Yes5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes5.Location = new System.Drawing.Point(765, 262);
            this.Yes5.Name = "Yes5";
            this.Yes5.Size = new System.Drawing.Size(48, 24);
            this.Yes5.TabIndex = 18;
            this.Yes5.TabStop = true;
            this.Yes5.Text = "Да";
            this.Yes5.UseVisualStyleBackColor = true;
            // 
            // Yes4
            // 
            this.Yes4.AutoSize = true;
            this.Yes4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes4.Location = new System.Drawing.Point(765, 212);
            this.Yes4.Name = "Yes4";
            this.Yes4.Size = new System.Drawing.Size(48, 24);
            this.Yes4.TabIndex = 19;
            this.Yes4.TabStop = true;
            this.Yes4.Text = "Да";
            this.Yes4.UseVisualStyleBackColor = true;
            // 
            // No3
            // 
            this.No3.AutoSize = true;
            this.No3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No3.Location = new System.Drawing.Point(844, 172);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(57, 24);
            this.No3.TabIndex = 20;
            this.No3.TabStop = true;
            this.No3.Text = "Нет";
            this.No3.UseVisualStyleBackColor = true;
            // 
            // No4
            // 
            this.No4.AutoSize = true;
            this.No4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No4.Location = new System.Drawing.Point(844, 216);
            this.No4.Name = "No4";
            this.No4.Size = new System.Drawing.Size(57, 24);
            this.No4.TabIndex = 21;
            this.No4.TabStop = true;
            this.No4.Text = "Нет";
            this.No4.UseVisualStyleBackColor = true;
            // 
            // No5
            // 
            this.No5.AutoSize = true;
            this.No5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No5.Location = new System.Drawing.Point(844, 261);
            this.No5.Name = "No5";
            this.No5.Size = new System.Drawing.Size(57, 24);
            this.No5.TabIndex = 22;
            this.No5.TabStop = true;
            this.No5.Text = "Нет";
            this.No5.UseVisualStyleBackColor = true;
            // 
            // Middle3
            // 
            this.Middle3.AutoSize = true;
            this.Middle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle3.Location = new System.Drawing.Point(919, 172);
            this.Middle3.Name = "Middle3";
            this.Middle3.Size = new System.Drawing.Size(119, 24);
            this.Middle3.TabIndex = 23;
            this.Middle3.TabStop = true;
            this.Middle3.Text = "Воздержусь";
            this.Middle3.UseVisualStyleBackColor = true;
            // 
            // Middle4
            // 
            this.Middle4.AutoSize = true;
            this.Middle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle4.Location = new System.Drawing.Point(919, 213);
            this.Middle4.Name = "Middle4";
            this.Middle4.Size = new System.Drawing.Size(119, 24);
            this.Middle4.TabIndex = 24;
            this.Middle4.TabStop = true;
            this.Middle4.Text = "Воздержусь";
            this.Middle4.UseVisualStyleBackColor = true;
            // 
            // Middle5
            // 
            this.Middle5.AutoSize = true;
            this.Middle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle5.Location = new System.Drawing.Point(919, 257);
            this.Middle5.Name = "Middle5";
            this.Middle5.Size = new System.Drawing.Size(119, 24);
            this.Middle5.TabIndex = 25;
            this.Middle5.TabStop = true;
            this.Middle5.Text = "Воздержусь";
            this.Middle5.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(144, 310);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(582, 21);
            this.comboBox6.TabIndex = 26;
            this.comboBox6.Text = "Выберите вариант";
            // 
            // Yes6
            // 
            this.Yes6.AutoSize = true;
            this.Yes6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Yes6.Location = new System.Drawing.Point(765, 307);
            this.Yes6.Name = "Yes6";
            this.Yes6.Size = new System.Drawing.Size(48, 24);
            this.Yes6.TabIndex = 27;
            this.Yes6.TabStop = true;
            this.Yes6.Text = "Да";
            this.Yes6.UseVisualStyleBackColor = true;
            // 
            // No6
            // 
            this.No6.AutoSize = true;
            this.No6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.No6.Location = new System.Drawing.Point(844, 306);
            this.No6.Name = "No6";
            this.No6.Size = new System.Drawing.Size(57, 24);
            this.No6.TabIndex = 28;
            this.No6.TabStop = true;
            this.No6.Text = "Нет";
            this.No6.UseVisualStyleBackColor = true;
            // 
            // Middle6
            // 
            this.Middle6.AutoSize = true;
            this.Middle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Middle6.Location = new System.Drawing.Point(919, 306);
            this.Middle6.Name = "Middle6";
            this.Middle6.Size = new System.Drawing.Size(119, 24);
            this.Middle6.TabIndex = 29;
            this.Middle6.TabStop = true;
            this.Middle6.Text = "Воздержусь";
            this.Middle6.UseVisualStyleBackColor = true;
            // 
            // LAB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 709);
            this.Controls.Add(this.Middle6);
            this.Controls.Add(this.No6);
            this.Controls.Add(this.Yes6);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.Middle5);
            this.Controls.Add(this.Middle4);
            this.Controls.Add(this.Middle3);
            this.Controls.Add(this.No5);
            this.Controls.Add(this.No4);
            this.Controls.Add(this.No3);
            this.Controls.Add(this.Yes4);
            this.Controls.Add(this.Yes5);
            this.Controls.Add(this.Yes3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Middle2);
            this.Controls.Add(this.No2);
            this.Controls.Add(this.Yes2);
            this.Controls.Add(this.Middle1);
            this.Controls.Add(this.No1);
            this.Controls.Add(this.Yes1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LAB1";
            this.Text = "LAB1";
            this.Load += new System.EventHandler(this.LAB1_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnturnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox TurnButton;
        private System.Windows.Forms.PictureBox UnturnButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button sentRes;
        private System.Windows.Forms.RadioButton Middle1;
        private System.Windows.Forms.RadioButton No1;
        private System.Windows.Forms.RadioButton Yes1;
        private System.Windows.Forms.RadioButton Middle2;
        private System.Windows.Forms.RadioButton No2;
        private System.Windows.Forms.RadioButton Yes2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Middle5;
        private System.Windows.Forms.RadioButton Middle4;
        private System.Windows.Forms.RadioButton Middle3;
        private System.Windows.Forms.RadioButton No5;
        private System.Windows.Forms.RadioButton No4;
        private System.Windows.Forms.RadioButton No3;
        private System.Windows.Forms.RadioButton Yes4;
        private System.Windows.Forms.RadioButton Yes5;
        private System.Windows.Forms.RadioButton Yes3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button addComboBox;
        private System.Windows.Forms.RadioButton Middle6;
        private System.Windows.Forms.RadioButton No6;
        private System.Windows.Forms.RadioButton Yes6;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}