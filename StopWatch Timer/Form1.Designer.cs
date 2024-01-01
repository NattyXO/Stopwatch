namespace CountDown_Timer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.btnStopTime = new System.Windows.Forms.Button();
            this.btnFastTime = new System.Windows.Forms.Button();
            this.btnLapTime = new System.Windows.Forms.Button();
            this.lblLapRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(181, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(288, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(41, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Watch Timer";
            // 
            // btnStartTime
            // 
            this.btnStartTime.BackColor = System.Drawing.Color.Lime;
            this.btnStartTime.FlatAppearance.BorderSize = 0;
            this.btnStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTime.ForeColor = System.Drawing.Color.Black;
            this.btnStartTime.Location = new System.Drawing.Point(12, 247);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(81, 32);
            this.btnStartTime.TabIndex = 4;
            this.btnStartTime.Text = "Start";
            this.btnStartTime.UseVisualStyleBackColor = false;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnStopTime
            // 
            this.btnStopTime.BackColor = System.Drawing.Color.Lime;
            this.btnStopTime.FlatAppearance.BorderSize = 0;
            this.btnStopTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTime.ForeColor = System.Drawing.Color.Black;
            this.btnStopTime.Location = new System.Drawing.Point(114, 247);
            this.btnStopTime.Name = "btnStopTime";
            this.btnStopTime.Size = new System.Drawing.Size(81, 32);
            this.btnStopTime.TabIndex = 5;
            this.btnStopTime.Text = "Stop";
            this.btnStopTime.UseVisualStyleBackColor = false;
            this.btnStopTime.Click += new System.EventHandler(this.btnStopTime_Click);
            // 
            // btnFastTime
            // 
            this.btnFastTime.BackColor = System.Drawing.Color.Blue;
            this.btnFastTime.FlatAppearance.BorderSize = 0;
            this.btnFastTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastTime.ForeColor = System.Drawing.Color.Black;
            this.btnFastTime.Location = new System.Drawing.Point(216, 247);
            this.btnFastTime.Name = "btnFastTime";
            this.btnFastTime.Size = new System.Drawing.Size(81, 32);
            this.btnFastTime.TabIndex = 6;
            this.btnFastTime.Text = "Fast";
            this.btnFastTime.UseVisualStyleBackColor = false;
            this.btnFastTime.Click += new System.EventHandler(this.btnFastTime_Click);
            // 
            // btnLapTime
            // 
            this.btnLapTime.BackColor = System.Drawing.Color.Blue;
            this.btnLapTime.FlatAppearance.BorderSize = 0;
            this.btnLapTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLapTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapTime.ForeColor = System.Drawing.Color.Black;
            this.btnLapTime.Location = new System.Drawing.Point(116, 200);
            this.btnLapTime.Name = "btnLapTime";
            this.btnLapTime.Size = new System.Drawing.Size(81, 32);
            this.btnLapTime.TabIndex = 7;
            this.btnLapTime.Text = "Lap";
            this.btnLapTime.UseVisualStyleBackColor = false;
            this.btnLapTime.Click += new System.EventHandler(this.btnLapTime_Click);
            // 
            // lblLapRecord
            // 
            this.lblLapRecord.AutoSize = true;
            this.lblLapRecord.ForeColor = System.Drawing.Color.White;
            this.lblLapRecord.Location = new System.Drawing.Point(339, 148);
            this.lblLapRecord.Name = "lblLapRecord";
            this.lblLapRecord.Size = new System.Drawing.Size(58, 13);
            this.lblLapRecord.TabIndex = 8;
            this.lblLapRecord.Text = "Lap record";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(12, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 32);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(428, 291);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblLapRecord);
            this.Controls.Add(this.btnLapTime);
            this.Controls.Add(this.btnFastTime);
            this.Controls.Add(this.btnStopTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Button btnStopTime;
        private System.Windows.Forms.Button btnFastTime;
        private System.Windows.Forms.Button btnLapTime;
        private System.Windows.Forms.Label lblLapRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
    }
}

