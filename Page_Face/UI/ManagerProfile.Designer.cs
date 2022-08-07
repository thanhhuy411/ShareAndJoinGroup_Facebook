namespace Page_Face.UI
{
    partial class ManagerProfile
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
            this.dtgInfo1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timeJoin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeShare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkShare = new System.Windows.Forms.TextBox();
            this.groupJoin = new System.Windows.Forms.TextBox();
            this.groupShare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfo1
            // 
            this.dtgInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgInfo1.Location = new System.Drawing.Point(12, 12);
            this.dtgInfo1.Name = "dtgInfo1";
            this.dtgInfo1.RowHeadersWidth = 51;
            this.dtgInfo1.RowTemplate.Height = 24;
            this.dtgInfo1.Size = new System.Drawing.Size(481, 716);
            this.dtgInfo1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "2FA";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Tên profile";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1052, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1052, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 108);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tạo và lưu account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1020, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "thời gian join";
            // 
            // timeJoin
            // 
            this.timeJoin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.timeJoin.Location = new System.Drawing.Point(976, 65);
            this.timeJoin.Multiline = true;
            this.timeJoin.Name = "timeJoin";
            this.timeJoin.Size = new System.Drawing.Size(161, 36);
            this.timeJoin.TabIndex = 21;
            this.timeJoin.WordWrap = false;
            this.timeJoin.TextChanged += new System.EventHandler(this.timeJoin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(859, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "thời gian share";
            // 
            // timeShare
            // 
            this.timeShare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.timeShare.Location = new System.Drawing.Point(834, 65);
            this.timeShare.Multiline = true;
            this.timeShare.Name = "timeShare";
            this.timeShare.Size = new System.Drawing.Size(146, 36);
            this.timeShare.TabIndex = 19;
            this.timeShare.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Group join";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Group share";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Link bài share";
            // 
            // linkShare
            // 
            this.linkShare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.linkShare.Location = new System.Drawing.Point(499, 46);
            this.linkShare.Multiline = true;
            this.linkShare.Name = "linkShare";
            this.linkShare.Size = new System.Drawing.Size(308, 55);
            this.linkShare.TabIndex = 15;
            this.linkShare.WordWrap = false;
            // 
            // groupJoin
            // 
            this.groupJoin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupJoin.Location = new System.Drawing.Point(779, 388);
            this.groupJoin.Multiline = true;
            this.groupJoin.Name = "groupJoin";
            this.groupJoin.Size = new System.Drawing.Size(260, 340);
            this.groupJoin.TabIndex = 14;
            this.groupJoin.WordWrap = false;
            // 
            // groupShare
            // 
            this.groupShare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupShare.Location = new System.Drawing.Point(499, 388);
            this.groupShare.Multiline = true;
            this.groupShare.Name = "groupShare";
            this.groupShare.Size = new System.Drawing.Size(274, 340);
            this.groupShare.TabIndex = 13;
            this.groupShare.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Join Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Share link vào group";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(654, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 20);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "bật";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(654, 185);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 20);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "bật";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ManagerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 740);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeJoin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeShare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkShare);
            this.Controls.Add(this.groupJoin);
            this.Controls.Add(this.groupShare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgInfo1);
            this.Name = "ManagerProfile";
            this.Text = "ManagerProfile";
            this.Load += new System.EventHandler(this.ManageProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeJoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeShare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox linkShare;
        private System.Windows.Forms.TextBox groupJoin;
        private System.Windows.Forms.TextBox groupShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}