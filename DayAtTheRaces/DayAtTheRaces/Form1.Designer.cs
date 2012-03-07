namespace DayAtTheRaces
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDogBetOn = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblDog1 = new System.Windows.Forms.Label();
            this.lblDog2 = new System.Windows.Forms.Label();
            this.lblDog3 = new System.Windows.Forms.Label();
            this.lblDog4 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 206);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Controls.Add(this.txtDogBetOn);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.txtBet);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Location = new System.Drawing.Point(36, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtDogBetOn
            // 
            this.txtDogBetOn.Location = new System.Drawing.Point(128, 72);
            this.txtDogBetOn.Name = "txtDogBetOn";
            this.txtDogBetOn.Size = new System.Drawing.Size(115, 20);
            this.txtDogBetOn.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(309, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(7, 72);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(115, 20);
            this.txtBet.TabIndex = 7;
            this.txtBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBet_KeyPress);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(653, 173);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(75, 23);
            this.btnRace.TabIndex = 6;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblDog1
            // 
            this.lblDog1.AutoSize = true;
            this.lblDog1.Location = new System.Drawing.Point(777, 30);
            this.lblDog1.Name = "lblDog1";
            this.lblDog1.Size = new System.Drawing.Size(22, 13);
            this.lblDog1.TabIndex = 7;
            this.lblDog1.Text = "5:1";
            // 
            // lblDog2
            // 
            this.lblDog2.AutoSize = true;
            this.lblDog2.Location = new System.Drawing.Point(777, 95);
            this.lblDog2.Name = "lblDog2";
            this.lblDog2.Size = new System.Drawing.Size(22, 13);
            this.lblDog2.TabIndex = 8;
            this.lblDog2.Text = "2:1";
            // 
            // lblDog3
            // 
            this.lblDog3.AutoSize = true;
            this.lblDog3.Location = new System.Drawing.Point(777, 153);
            this.lblDog3.Name = "lblDog3";
            this.lblDog3.Size = new System.Drawing.Size(22, 13);
            this.lblDog3.TabIndex = 9;
            this.lblDog3.Text = "3:1";
            // 
            // lblDog4
            // 
            this.lblDog4.AutoSize = true;
            this.lblDog4.Location = new System.Drawing.Point(777, 219);
            this.lblDog4.Name = "lblDog4";
            this.lblDog4.Size = new System.Drawing.Size(22, 13);
            this.lblDog4.TabIndex = 10;
            this.lblDog4.Text = "4:1";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(7, 33);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 489);
            this.Controls.Add(this.lblDog4);
            this.Controls.Add(this.lblDog3);
            this.Controls.Add(this.lblDog2);
            this.Controls.Add(this.lblDog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.TextBox txtDogBetOn;
        private System.Windows.Forms.Label lblDog1;
        private System.Windows.Forms.Label lblDog2;
        private System.Windows.Forms.Label lblDog3;
        private System.Windows.Forms.Label lblDog4;
        private System.Windows.Forms.Label lblTest;
    }
}

