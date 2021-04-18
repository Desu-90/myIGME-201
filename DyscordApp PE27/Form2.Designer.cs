
namespace DyscordApp
{
    partial class DyscordForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.convRichTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.webBrowser1);
            this.groupBox.Controls.Add(this.convRichTextBox);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(800, 346);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Conversation";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(547, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 327);
            this.webBrowser1.TabIndex = 1;
            // 
            // convRichTextBox
            // 
            this.convRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.convRichTextBox.Name = "convRichTextBox";
            this.convRichTextBox.Size = new System.Drawing.Size(794, 327);
            this.convRichTextBox.TabIndex = 0;
            this.convRichTextBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.userButton);
            this.splitContainer1.Panel2.Controls.Add(this.sendButton);
            this.splitContainer1.Panel2.Controls.Add(this.loginButton);
            this.splitContainer1.Panel2.Controls.Add(this.userTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 100);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.TabIndex = 2;
            // 
            // msgRichTextBox
            // 
            this.msgRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.msgRichTextBox.Name = "msgRichTextBox";
            this.msgRichTextBox.Size = new System.Drawing.Size(510, 100);
            this.msgRichTextBox.TabIndex = 0;
            this.msgRichTextBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(199, 56);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(109, 56);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "Users";
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(15, 56);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(199, 18);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(15, 18);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(178, 20);
            this.userTextBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 450);
            this.splitContainer2.SplitterDistance = 346;
            this.splitContainer2.TabIndex = 1;
            // 
            // DyscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "DyscordForm";
            this.Text = "Dyscord";
            this.groupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox convRichTextBox;
        private System.Windows.Forms.RichTextBox msgRichTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}