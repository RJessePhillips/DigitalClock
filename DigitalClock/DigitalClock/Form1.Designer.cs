namespace DigitalClock
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
            this.HourMinuteLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HourMinuteLabel
            // 
            this.HourMinuteLabel.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourMinuteLabel.Location = new System.Drawing.Point(12, 9);
            this.HourMinuteLabel.Name = "HourMinuteLabel";
            this.HourMinuteLabel.Size = new System.Drawing.Size(148, 60);
            this.HourMinuteLabel.TabIndex = 0;
            this.HourMinuteLabel.Text = "07 : 25";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(164, 9);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(70, 60);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = "25";
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(8, 69);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(391, 60);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "January 03 2019";
            // 
            // DayLabel
            // 
            this.DayLabel.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(12, 129);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(222, 60);
            this.DayLabel.TabIndex = 3;
            this.DayLabel.Text = "Monday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(393, 214);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.HourMinuteLabel);
            this.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourMinuteLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

