namespace 加密器
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonconvert = new System.Windows.Forms.Button();
            this.textkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioencrypt = new System.Windows.Forms.RadioButton();
            this.radiodecrypt = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(14, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 404);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "明文";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(644, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(400, 404);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "密文";
            // 
            // buttonconvert
            // 
            this.buttonconvert.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonconvert.Location = new System.Drawing.Point(424, 264);
            this.buttonconvert.Margin = new System.Windows.Forms.Padding(5);
            this.buttonconvert.Name = "buttonconvert";
            this.buttonconvert.Size = new System.Drawing.Size(210, 72);
            this.buttonconvert.TabIndex = 5;
            this.buttonconvert.Text = "转换";
            this.buttonconvert.UseVisualStyleBackColor = true;
            this.buttonconvert.Click += new System.EventHandler(this.buttonconvert_Click);
            // 
            // textkey
            // 
            this.textkey.AcceptsReturn = true;
            this.textkey.AcceptsTab = true;
            this.textkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textkey.Location = new System.Drawing.Point(516, 14);
            this.textkey.Margin = new System.Windows.Forms.Padding(5);
            this.textkey.MaxLength = 5;
            this.textkey.Name = "textkey";
            this.textkey.Size = new System.Drawing.Size(118, 48);
            this.textkey.TabIndex = 0;
            this.textkey.Text = "0";
            this.textkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textkey.TextChanged += new System.EventHandler(this.textkey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "密钥";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(424, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "随机密钥";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioencrypt
            // 
            this.radioencrypt.AutoSize = true;
            this.radioencrypt.Checked = true;
            this.radioencrypt.Location = new System.Drawing.Point(424, 154);
            this.radioencrypt.Margin = new System.Windows.Forms.Padding(5);
            this.radioencrypt.Name = "radioencrypt";
            this.radioencrypt.Size = new System.Drawing.Size(107, 45);
            this.radioencrypt.TabIndex = 3;
            this.radioencrypt.TabStop = true;
            this.radioencrypt.Text = "加密";
            this.radioencrypt.UseVisualStyleBackColor = true;
            // 
            // radiodecrypt
            // 
            this.radiodecrypt.AutoSize = true;
            this.radiodecrypt.Location = new System.Drawing.Point(424, 209);
            this.radiodecrypt.Margin = new System.Windows.Forms.Padding(5);
            this.radiodecrypt.Name = "radiodecrypt";
            this.radiodecrypt.Size = new System.Drawing.Size(107, 45);
            this.radiodecrypt.TabIndex = 4;
            this.radiodecrypt.Text = "解密";
            this.radiodecrypt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(424, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radiodecrypt);
            this.Controls.Add(this.radioencrypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textkey);
            this.Controls.Add(this.buttonconvert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "加密器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonconvert;
        private TextBox textkey;
        private Label label1;
        private Button button1;
        private RadioButton radioencrypt;
        private RadioButton radiodecrypt;
        private Button button2;
    }
}