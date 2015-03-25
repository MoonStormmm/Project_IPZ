namespace WindowsFormsApplication1
{
    partial class MyBugs
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBugs));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_example = new System.Windows.Forms.Button();
            this.button_message = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Head");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(41, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button2, "Developer");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(78, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button3, "Tester");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_example
            // 
            this.button_example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_example.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_example.BackgroundImage")));
            this.button_example.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_example.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_example.Location = new System.Drawing.Point(115, 3);
            this.button_example.Name = "button_example";
            this.button_example.Size = new System.Drawing.Size(31, 23);
            this.button_example.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button_example, "Example");
            this.button_example.UseVisualStyleBackColor = false;
            this.button_example.Click += new System.EventHandler(this.button_example_Click);
            // 
            // button_message
            // 
            this.button_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_message.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_message.BackgroundImage")));
            this.button_message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_message.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_message.Location = new System.Drawing.Point(152, 3);
            this.button_message.Name = "button_message";
            this.button_message.Size = new System.Drawing.Size(31, 23);
            this.button_message.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button_message, "Send message");
            this.button_message.UseVisualStyleBackColor = false;
            this.button_message.Click += new System.EventHandler(this.button_message_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_about.BackgroundImage")));
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.Location = new System.Drawing.Point(189, 3);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(31, 23);
            this.button_about.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button_about, "Creators");
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info.BackgroundImage")));
            this.button_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_info.FlatAppearance.BorderSize = 0;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_info.Location = new System.Drawing.Point(226, 3);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(31, 23);
            this.button_info.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button_info, "Info");
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 66);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trekking bug system\r\n          MyBugs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MyBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(262, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.button_example);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBugs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_example;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        
    }
}

