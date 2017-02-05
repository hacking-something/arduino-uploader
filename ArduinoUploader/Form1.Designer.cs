namespace ArduinoUploader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result_box = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.upload_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_logo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_logo.Location = new System.Drawing.Point(89, 15);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(205, 23);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "ARDUINO UPLOADER";
            this.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.result_box);
            this.panel1.Font = new System.Drawing.Font("Lato", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(-1, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 37);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ArduinoUploader.Properties.Resources.info_disebled;
            this.pictureBox1.Location = new System.Drawing.Point(353, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // result_box
            // 
            this.result_box.AutoSize = true;
            this.result_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result_box.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_box.ForeColor = System.Drawing.Color.White;
            this.result_box.Location = new System.Drawing.Point(13, 9);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(0, 18);
            this.result_box.TabIndex = 1;
            // 
            // fileText
            // 
            this.fileText.BackColor = System.Drawing.Color.White;
            this.fileText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileText.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileText.Location = new System.Drawing.Point(103, 58);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(186, 25);
            this.fileText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Baud Rate";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.modelBox);
            this.panel2.Location = new System.Drawing.Point(103, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 26);
            this.panel2.TabIndex = 7;
            // 
            // modelBox
            // 
            this.modelBox.BackColor = System.Drawing.Color.White;
            this.modelBox.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "m8",
            "m168",
            "m328p",
            "128",
            "m1280",
            "atmega2560"});
            this.modelBox.Location = new System.Drawing.Point(-1, -1);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(186, 26);
            this.modelBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comPort);
            this.panel3.Location = new System.Drawing.Point(103, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 26);
            this.panel3.TabIndex = 8;
            // 
            // comPort
            // 
            this.comPort.BackColor = System.Drawing.Color.White;
            this.comPort.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(-1, -1);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(186, 26);
            this.comPort.TabIndex = 0;
            this.comPort.DropDown += new System.EventHandler(this.comPort_DropDown);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.baudRateBox);
            this.panel4.Location = new System.Drawing.Point(103, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 26);
            this.panel4.TabIndex = 8;
            // 
            // baudRateBox
            // 
            this.baudRateBox.BackColor = System.Drawing.Color.White;
            this.baudRateBox.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.baudRateBox.Location = new System.Drawing.Point(-1, -1);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(186, 26);
            this.baudRateBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "HEX files (*.hex)|*.hex|Все файлы|*.*";
            this.openFileDialog1.InitialDirectory = "@\\\"C:\\\\\\\"";
            this.openFileDialog1.Title = "Open HEX-file...";
            // 
            // upload_button
            // 
            this.upload_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_button.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_button.Location = new System.Drawing.Point(152, 205);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(84, 28);
            this.upload_button.TabIndex = 9;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // view_button
            // 
            this.view_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_button.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_button.Location = new System.Drawing.Point(295, 56);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(79, 28);
            this.view_button.TabIndex = 10;
            this.view_button.Text = "View";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 285);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arduino Uploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox baudRateBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Label result_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

