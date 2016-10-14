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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLineMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnObjectAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnTimeStop = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.LockIcon = new System.Windows.Forms.PictureBox();
            this.ViewIcon = new System.Windows.Forms.PictureBox();
            this.BtnLineAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnTimeAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameItem,
            this.lockItem,
            this.viewItem});
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(353, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameItem
            // 
            this.nameItem.HeaderText = "Name";
            this.nameItem.Name = "nameItem";
            this.nameItem.Width = 250;
            // 
            // lockItem
            // 
            this.lockItem.HeaderText = "Lock";
            this.lockItem.Name = "lockItem";
            this.lockItem.Width = 50;
            // 
            // viewItem
            // 
            this.viewItem.HeaderText = "View";
            this.viewItem.Name = "viewItem";
            this.viewItem.Width = 50;
            // 
            // BtnObjectAdd
            // 
            this.BtnObjectAdd.Location = new System.Drawing.Point(763, 7);
            this.BtnObjectAdd.Name = "BtnObjectAdd";
            this.BtnObjectAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnObjectAdd.TabIndex = 2;
            this.BtnObjectAdd.Text = "Object Add";
            this.BtnObjectAdd.UseVisualStyleBackColor = true;
            this.BtnObjectAdd.Click += new System.EventHandler(this.BtnObjectAdd_Click);
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
            // LockIcon
            // 
            this.LockIcon.Image = ((System.Drawing.Image)(resources.GetObject("LockIcon.Image")));
            this.LockIcon.InitialImage = null;
            this.LockIcon.Location = new System.Drawing.Point(270, 67);
            this.LockIcon.Name = "LockIcon";
            this.LockIcon.Size = new System.Drawing.Size(16, 16);
            this.LockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockIcon.TabIndex = 11;
            this.LockIcon.TabStop = false;
            // 
            // ViewIcon
            // 
            this.ViewIcon.Image = ((System.Drawing.Image)(resources.GetObject("ViewIcon.Image")));
            this.ViewIcon.InitialImage = null;
            this.ViewIcon.Location = new System.Drawing.Point(317, 67);
            this.ViewIcon.Name = "ViewIcon";
            this.ViewIcon.Size = new System.Drawing.Size(16, 16);
            this.ViewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewIcon.TabIndex = 12;
            this.ViewIcon.TabStop = false;
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
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
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
            // TimeLineMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 263);
            this.Controls.Add(this.BtnTimeAdd);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnLineAdd);
            this.Controls.Add(this.ViewIcon);
            this.Controls.Add(this.LockIcon);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnTimeStop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnObjectAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TimeLineMain";
            this.Text = "Time Line";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnObjectAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn viewItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnTimeStop;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox LockIcon;
        private System.Windows.Forms.PictureBox ViewIcon;
        private System.Windows.Forms.Button BtnLineAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnTimeAdd;
    }
}

