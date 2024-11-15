namespace plccOMMUNICATION
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
            this.lblplcopen = new System.Windows.Forms.Label();
            this.lblplcRead = new System.Windows.Forms.Label();
            this.plcwrite = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSethigh = new System.Windows.Forms.Button();
            this.btnSetLow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDataFromPLC = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblplcopen
            // 
            this.lblplcopen.Location = new System.Drawing.Point(57, 78);
            this.lblplcopen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplcopen.Name = "lblplcopen";
            this.lblplcopen.Size = new System.Drawing.Size(133, 28);
            this.lblplcopen.TabIndex = 0;
            this.lblplcopen.Text = "IsPLCConnect";
            // 
            // lblplcRead
            // 
            this.lblplcRead.Location = new System.Drawing.Point(301, 33);
            this.lblplcRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplcRead.Name = "lblplcRead";
            this.lblplcRead.Size = new System.Drawing.Size(243, 53);
            this.lblplcRead.TabIndex = 0;
            this.lblplcRead.Text = "label1";
            // 
            // plcwrite
            // 
            this.plcwrite.Location = new System.Drawing.Point(663, 172);
            this.plcwrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plcwrite.Name = "plcwrite";
            this.plcwrite.Size = new System.Drawing.Size(388, 52);
            this.plcwrite.TabIndex = 0;
            this.plcwrite.Text = "label1";
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(57, 474);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(144, 16);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "SHOW ERROR";
            // 
            // btnSethigh
            // 
            this.btnSethigh.Location = new System.Drawing.Point(563, 404);
            this.btnSethigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSethigh.Name = "btnSethigh";
            this.btnSethigh.Size = new System.Drawing.Size(100, 28);
            this.btnSethigh.TabIndex = 1;
            this.btnSethigh.Text = "Set High";
            this.btnSethigh.UseVisualStyleBackColor = true;
            this.btnSethigh.Click += new System.EventHandler(this.btnSethigh_Click);
            // 
            // btnSetLow
            // 
            this.btnSetLow.Location = new System.Drawing.Point(732, 404);
            this.btnSetLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetLow.Name = "btnSetLow";
            this.btnSetLow.Size = new System.Drawing.Size(100, 28);
            this.btnSetLow.TabIndex = 1;
            this.btnSetLow.Text = "Set Low";
            this.btnSetLow.UseVisualStyleBackColor = true;
            this.btnSetLow.Click += new System.EventHandler(this.btnSetLow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send data PLC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Read Data From Plc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDataFromPLC
            // 
            this.lblDataFromPLC.Location = new System.Drawing.Point(90, 315);
            this.lblDataFromPLC.Name = "lblDataFromPLC";
            this.lblDataFromPLC.Size = new System.Drawing.Size(168, 23);
            this.lblDataFromPLC.TabIndex = 4;
            this.lblDataFromPLC.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(732, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Send string data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblDataFromPLC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetLow);
            this.Controls.Add(this.btnSethigh);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.plcwrite);
            this.Controls.Add(this.lblplcRead);
            this.Controls.Add(this.lblplcopen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblplcopen;
        private System.Windows.Forms.Label lblplcRead;
        private System.Windows.Forms.Label plcwrite;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSethigh;
        private System.Windows.Forms.Button btnSetLow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDataFromPLC;
        private System.Windows.Forms.Button button3;
    }
}

