
namespace TuongTacCheo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listInfo = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkFollow = new System.Windows.Forms.CheckBox();
            this.checkLikePage = new System.Windows.Forms.CheckBox();
            this.checkLikePost = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumRun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(677, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin auto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listInfo
            // 
            this.listInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUsername,
            this.txtPassword,
            this.txtCookie,
            this.txtMoney,
            this.txtStatus});
            this.listInfo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listInfo.Location = new System.Drawing.Point(32, 73);
            this.listInfo.Name = "listInfo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.listInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listInfo.Size = new System.Drawing.Size(737, 117);
            this.listInfo.TabIndex = 2;
            this.listInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listInfo_CellContentClick);
            // 
            // txtUsername
            // 
            this.txtUsername.HeaderText = "Username TTC";
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Width = 150;
            // 
            // txtPassword
            // 
            this.txtPassword.HeaderText = "Password TTC";
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Width = 150;
            // 
            // txtCookie
            // 
            this.txtCookie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txtCookie.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtCookie.HeaderText = "Cookie Facebook";
            this.txtCookie.Name = "txtCookie";
            // 
            // txtMoney
            // 
            this.txtMoney.HeaderText = "Số Xu Hiện Tại";
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Width = 120;
            // 
            // txtStatus
            // 
            this.txtStatus.HeaderText = "Trạng Thái";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Width = 130;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(125, 221);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(64, 22);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "10";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quãng nghỉ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Option";
            // 
            // checkFollow
            // 
            this.checkFollow.AutoSize = true;
            this.checkFollow.Checked = true;
            this.checkFollow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFollow.Location = new System.Drawing.Point(73, 303);
            this.checkFollow.Name = "checkFollow";
            this.checkFollow.Size = new System.Drawing.Size(66, 20);
            this.checkFollow.TabIndex = 6;
            this.checkFollow.Text = "Follow";
            this.checkFollow.UseVisualStyleBackColor = true;
            // 
            // checkLikePage
            // 
            this.checkLikePage.AutoSize = true;
            this.checkLikePage.Checked = true;
            this.checkLikePage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLikePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLikePage.Location = new System.Drawing.Point(73, 344);
            this.checkLikePage.Name = "checkLikePage";
            this.checkLikePage.Size = new System.Drawing.Size(88, 20);
            this.checkLikePage.TabIndex = 7;
            this.checkLikePage.Text = "Like Page";
            this.checkLikePage.UseVisualStyleBackColor = true;
            // 
            // checkLikePost
            // 
            this.checkLikePost.AutoSize = true;
            this.checkLikePost.Checked = true;
            this.checkLikePost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLikePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLikePost.Location = new System.Drawing.Point(73, 386);
            this.checkLikePost.Name = "checkLikePost";
            this.checkLikePost.Size = new System.Drawing.Size(82, 20);
            this.checkLikePost.TabIndex = 8;
            this.checkLikePost.Text = "Like Post";
            this.checkLikePost.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLog.Location = new System.Drawing.Point(253, 303);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(516, 127);
            this.txtLog.TabIndex = 9;
            this.txtLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lần chạy/ 1 nv";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNumRun
            // 
            this.txtNumRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRun.Location = new System.Drawing.Point(437, 221);
            this.txtNumRun.Name = "txtNumRun";
            this.txtNumRun.Size = new System.Drawing.Size(64, 22);
            this.txtNumRun.TabIndex = 12;
            this.txtNumRun.Text = "10";
            this.txtNumRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumRun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(806, 478);
            this.Controls.Add(this.txtNumRun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.checkLikePost);
            this.Controls.Add(this.checkLikePage);
            this.Controls.Add(this.checkFollow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Tương Tác Chéo";
            ((System.ComponentModel.ISupportInitialize)(this.listInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listInfo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkFollow;
        private System.Windows.Forms.CheckBox checkLikePage;
        private System.Windows.Forms.CheckBox checkLikePost;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumRun;
    }
}

