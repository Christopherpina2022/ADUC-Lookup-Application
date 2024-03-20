namespace GetGroupsByUser
{
    partial class ALAForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMembersButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userAccessButton = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(360, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupMembersButton
            // 
            this.groupMembersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMembersButton.Location = new System.Drawing.Point(6, 77);
            this.groupMembersButton.Name = "groupMembersButton";
            this.groupMembersButton.Size = new System.Drawing.Size(134, 23);
            this.groupMembersButton.TabIndex = 9;
            this.groupMembersButton.Text = "Get Members";
            this.groupMembersButton.UseVisualStyleBackColor = true;
            this.groupMembersButton.Click += new System.EventHandler(this.groupMembersButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(82, 51);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.groupNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Looks for any members within a Global Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupNameTextBox);
            this.groupBox2.Controls.Add(this.groupMembersButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 113);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Global Group Members";
            // 
            // userAccessButton
            // 
            this.userAccessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccessButton.Location = new System.Drawing.Point(6, 77);
            this.userAccessButton.Name = "userAccessButton";
            this.userAccessButton.Size = new System.Drawing.Size(135, 23);
            this.userAccessButton.TabIndex = 2;
            this.userAccessButton.Text = "Get Global Groups";
            this.userAccessButton.UseVisualStyleBackColor = true;
            this.userAccessButton.Click += new System.EventHandler(this.userAccessButton_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(81, 51);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(175, 20);
            this.userIDTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Looks for any Global Group a user is a part of";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(this.userAccessButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get User Access List";
            // 
            // ALAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ALAForm";
            this.Text = "ADUC Lookup Application (ALA)";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button groupMembersButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button userAccessButton;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

