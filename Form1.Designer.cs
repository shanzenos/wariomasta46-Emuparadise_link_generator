namespace wariomasta46
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createlink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputstring = new System.Windows.Forms.TextBox();
            this.copylink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EPlink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EPlink)).BeginInit();
            this.SuspendLayout();
            // 
            // inputstring
            // 
            this.inputstring.ForeColor = System.Drawing.SystemColors.MenuText;
            this.inputstring.Location = new System.Drawing.Point(15, 45);
            this.inputstring.Name = "inputstring";
            this.inputstring.Size = new System.Drawing.Size(483, 22);
            this.inputstring.TabIndex = 0;
            this.inputstring.Enter += new System.EventHandler(this.inputstring_enter);
            this.inputstring.Leave += new System.EventHandler(this.inputstring_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paste your Emuparadise Link here:";
            // 
            // createlink
            // 
            this.createlink.Location = new System.Drawing.Point(515, 37);
            this.createlink.Name = "createlink";
            this.createlink.Size = new System.Drawing.Size(96, 50);
            this.createlink.TabIndex = 2;
            this.createlink.Text = "Create Link";
            this.createlink.UseVisualStyleBackColor = true;
            this.createlink.Click += new System.EventHandler(this.createlink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Copy link from the game information page NOT the download page!)";
            // 
            // outputstring
            // 
            this.outputstring.Location = new System.Drawing.Point(15, 210);
            this.outputstring.Name = "outputstring";
            this.outputstring.Size = new System.Drawing.Size(483, 22);
            this.outputstring.TabIndex = 4;
            // 
            // copylink
            // 
            this.copylink.Location = new System.Drawing.Point(610, 202);
            this.copylink.Name = "copylink";
            this.copylink.Size = new System.Drawing.Size(76, 49);
            this.copylink.TabIndex = 5;
            this.copylink.Text = "Copy Link";
            this.copylink.UseVisualStyleBackColor = true;
            this.copylink.Click += new System.EventHandler(this.copylink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Download Link Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "-goomba3210 for the GID method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "#Special Thanks#";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EPlink
            // 
            this.EPlink.Image = ((System.Drawing.Image)(resources.GetObject("EPlink.Image")));
            this.EPlink.InitialImage = ((System.Drawing.Image)(resources.GetObject("EPlink.InitialImage")));
            this.EPlink.Location = new System.Drawing.Point(280, 305);
            this.EPlink.Name = "EPlink";
            this.EPlink.Size = new System.Drawing.Size(299, 106);
            this.EPlink.TabIndex = 11;
            this.EPlink.TabStop = false;
            this.EPlink.DoubleClick += new System.EventHandler(this.EPlink_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 430);
            this.Controls.Add(this.EPlink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copylink);
            this.Controls.Add(this.outputstring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createlink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputstring);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wariomasta46 Emuparadise Link Generator";
            ((System.ComponentModel.ISupportInitialize)(this.EPlink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createlink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputstring;
        private System.Windows.Forms.Button copylink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox EPlink;
    }
}

