namespace TimeLineUI_Proto_1
{
    partial class TimeLineMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLineMain));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnTimeStop = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLineAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnTimeAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Object Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "|<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnTimeStop
            // 
            this.BtnTimeStop.Location = new System.Drawing.Point(80, 60);
            this.BtnTimeStop.Name = "BtnTimeStop";
            this.BtnTimeStop.Size = new System.Drawing.Size(40, 25);
            this.BtnTimeStop.TabIndex = 7;
            this.BtnTimeStop.UseVisualStyleBackColor = true;
            this.BtnTimeStop.Click += new System.EventHandler(this.BtnTimeStop_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(120, 60);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(40, 25);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = ">";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(160, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = ">|";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(200, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = ">>|";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(317, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLineAdd
            // 
            this.BtnLineAdd.Location = new System.Drawing.Point(763, 37);
            this.BtnLineAdd.Name = "BtnLineAdd";
            this.BtnLineAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnLineAdd.TabIndex = 14;
            this.BtnLineAdd.Text = "Line";
            this.BtnLineAdd.UseVisualStyleBackColor = true;
            this.BtnLineAdd.Click += new System.EventHandler(this.BtnLineAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(359, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 174);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // BtnTimeAdd
            // 
            this.BtnTimeAdd.Location = new System.Drawing.Point(671, 7);
            this.BtnTimeAdd.Name = "BtnTimeAdd";
            this.BtnTimeAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnTimeAdd.TabIndex = 16;
            this.BtnTimeAdd.Text = "Time Add";
            this.BtnTimeAdd.UseVisualStyleBackColor = true;
            this.BtnTimeAdd.Click += new System.EventHandler(this.BtnTimeAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.replayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.replayToolStripMenuItem.Text = "Replay";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 91);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(354, 172);
            this.treeView1.TabIndex = 17;
            // 
            // TimeLineMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 263);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BtnTimeAdd);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnLineAdd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnTimeStop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TimeLineMain";
            this.Text = "Time Line";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnTimeStop;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnLineAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnTimeAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}

