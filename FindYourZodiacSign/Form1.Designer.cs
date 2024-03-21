namespace FindYourZodiacSign
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbBday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(453, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntry.Location = new System.Drawing.Point(147, 34);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(260, 22);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Please Enter Your Birthday";
            this.lblEntry.Click += new System.EventHandler(this.lblEntry_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(159, 215);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(28, 13);
            this.lblPrint.TabIndex = 2;
            this.lblPrint.Text = "Print";
            this.lblPrint.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.Location = new System.Drawing.Point(225, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Okay";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbBday
            // 
            this.tbBday.Location = new System.Drawing.Point(162, 75);
            this.tbBday.Name = "tbBday";
            this.tbBday.Size = new System.Drawing.Size(233, 20);
            this.tbBday.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 421);
            this.ControlBox = false;
            this.Controls.Add(this.tbBday);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbBday;
    }
}

