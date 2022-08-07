namespace Page_Face
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupShare = new System.Windows.Forms.TextBox();
            this.groupJoin = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.TextBox();
            this.linkShare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeShare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeJoin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupShare
            // 
            this.groupShare.Location = new System.Drawing.Point(360, 296);
            this.groupShare.Multiline = true;
            this.groupShare.Name = "groupShare";
            this.groupShare.Size = new System.Drawing.Size(308, 340);
            this.groupShare.TabIndex = 1;
            this.groupShare.WordWrap = false;
            // 
            // groupJoin
            // 
            this.groupJoin.Location = new System.Drawing.Point(674, 296);
            this.groupJoin.Multiline = true;
            this.groupJoin.Name = "groupJoin";
            this.groupJoin.Size = new System.Drawing.Size(313, 340);
            this.groupJoin.TabIndex = 2;
            this.groupJoin.WordWrap = false;
            this.groupJoin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(12, 75);
            this.account.Multiline = true;
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(342, 561);
            this.account.TabIndex = 3;
            this.account.WordWrap = false;
            // 
            // linkShare
            // 
            this.linkShare.Location = new System.Drawing.Point(360, 75);
            this.linkShare.Multiline = true;
            this.linkShare.Name = "linkShare";
            this.linkShare.Size = new System.Drawing.Size(308, 55);
            this.linkShare.TabIndex = 4;
            this.linkShare.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Link bài share";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Group share";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group join";
            // 
            // timeShare
            // 
            this.timeShare.Location = new System.Drawing.Point(674, 75);
            this.timeShare.Multiline = true;
            this.timeShare.Name = "timeShare";
            this.timeShare.Size = new System.Drawing.Size(146, 55);
            this.timeShare.TabIndex = 9;
            this.timeShare.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "thời gian share";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timeJoin
            // 
            this.timeJoin.Location = new System.Drawing.Point(826, 75);
            this.timeJoin.Multiline = true;
            this.timeJoin.Name = "timeJoin";
            this.timeJoin.Size = new System.Drawing.Size(161, 55);
            this.timeJoin.TabIndex = 11;
            this.timeJoin.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "thời gian join";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1009, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 100);
            this.button2.TabIndex = 13;
            this.button2.Text = "Mở form tạo profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeJoin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeShare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkShare);
            this.Controls.Add(this.account);
            this.Controls.Add(this.groupJoin);
            this.Controls.Add(this.groupShare);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox groupShare;
        private System.Windows.Forms.TextBox groupJoin;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox linkShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeShare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeJoin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

