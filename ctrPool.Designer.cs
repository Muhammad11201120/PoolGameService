namespace PoolGame
{
    partial class ctrPool
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblTableTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 250);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoolGame.Properties.Resources.pool;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.Location = new System.Drawing.Point(63, 10);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(64, 22);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "Table1";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(221, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 33);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Player";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(236, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(134, 35);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(253, 157);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(106, 38);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartStop.Location = new System.Drawing.Point(253, 113);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(106, 38);
            this.btnStartStop.TabIndex = 11;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel1);
            this.Name = "ctrPool";
            this.Size = new System.Drawing.Size(402, 250);
            this.Load += new System.EventHandler(this.ctrPool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer timer1;
    }
}
