namespace WindowsFormsApp1
{
    partial class addV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addV));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.result1 = new System.Windows.Forms.Button();
            this.testbutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.UnturnButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnturnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.result1);
            this.panel3.Controls.Add(this.testbutton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 561);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result1
            // 
            this.result1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.result1.ForeColor = System.Drawing.Color.White;
            this.result1.Location = new System.Drawing.Point(12, 741);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(110, 42);
            this.result1.TabIndex = 28;
            this.result1.Text = "Результат";
            this.result1.UseVisualStyleBackColor = false;
            // 
            // testbutton
            // 
            this.testbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.testbutton.ForeColor = System.Drawing.Color.White;
            this.testbutton.Location = new System.Drawing.Point(3, 693);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(125, 42);
            this.testbutton.TabIndex = 27;
            this.testbutton.Text = "Готовый тест";
            this.testbutton.UseVisualStyleBackColor = false;
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
            // 
            // UnturnButton
            // 
            this.UnturnButton.Image = ((System.Drawing.Image)(resources.GetObject("UnturnButton.Image")));
            this.UnturnButton.Location = new System.Drawing.Point(50, 3);
            this.UnturnButton.Name = "UnturnButton";
            this.UnturnButton.Size = new System.Drawing.Size(19, 18);
            this.UnturnButton.TabIndex = 2;
            this.UnturnButton.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 63);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(186, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Введите проблемы";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(143, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Введите количество проблем";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(400, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 26);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(516, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(143, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 415);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Visible = false;
            // 
            // addV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addV";
            this.Text = "addV";
            this.Load += new System.EventHandler(this.addV_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnturnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button result1;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox TurnButton;
        private System.Windows.Forms.PictureBox UnturnButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}