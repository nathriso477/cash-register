namespace cash_register
{
    partial class resetbutton
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bayonet = new System.Windows.Forms.TextBox();
            this.karambit = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.Taxlabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tenderd = new System.Windows.Forms.Label();
            this.changebox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Button();
            this.changelabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(244, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(332, 55);
            this.title.TabIndex = 0;
            this.title.Text = "CSGO SKINS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bayonet ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Karambit";
            // 
            // bayonet
            // 
            this.bayonet.Location = new System.Drawing.Point(177, 98);
            this.bayonet.Name = "bayonet";
            this.bayonet.Size = new System.Drawing.Size(44, 20);
            this.bayonet.TabIndex = 4;
            // 
            // karambit
            // 
            this.karambit.Location = new System.Drawing.Point(177, 191);
            this.karambit.Name = "karambit";
            this.karambit.Size = new System.Drawing.Size(44, 20);
            this.karambit.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculate.Location = new System.Drawing.Point(35, 220);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(92, 27);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Lime;
            this.subtotalLabel.Location = new System.Drawing.Point(14, 267);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(75, 16);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // Taxlabel
            // 
            this.Taxlabel.AutoSize = true;
            this.Taxlabel.BackColor = System.Drawing.Color.Transparent;
            this.Taxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taxlabel.ForeColor = System.Drawing.Color.Lime;
            this.Taxlabel.Location = new System.Drawing.Point(14, 294);
            this.Taxlabel.Name = "Taxlabel";
            this.Taxlabel.Size = new System.Drawing.Size(30, 15);
            this.Taxlabel.TabIndex = 9;
            this.Taxlabel.Text = "Tax";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.BackColor = System.Drawing.Color.Transparent;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.ForeColor = System.Drawing.Color.Lime;
            this.totallabel.Location = new System.Drawing.Point(14, 323);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(39, 15);
            this.totallabel.TabIndex = 10;
            this.totallabel.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::cash_register.Properties.Resources.bayonet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(283, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 76);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::cash_register.Properties.Resources.karambit;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::cash_register.Properties.Resources.karambit;
            this.pictureBox2.Location = new System.Drawing.Point(283, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 69);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // tenderd
            // 
            this.tenderd.AutoSize = true;
            this.tenderd.BackColor = System.Drawing.Color.Transparent;
            this.tenderd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderd.ForeColor = System.Drawing.Color.Lime;
            this.tenderd.Location = new System.Drawing.Point(14, 369);
            this.tenderd.Name = "tenderd";
            this.tenderd.Size = new System.Drawing.Size(68, 15);
            this.tenderd.TabIndex = 13;
            this.tenderd.Text = "Tendered";
            // 
            // changebox
            // 
            this.changebox.Location = new System.Drawing.Point(169, 368);
            this.changebox.Name = "changebox";
            this.changebox.Size = new System.Drawing.Size(35, 20);
            this.changebox.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(26, 394);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(102, 28);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.change_Click);
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(26, 485);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(101, 25);
            this.receipt.TabIndex = 16;
            this.receipt.Text = "Print Receipt";
            this.receipt.UseVisualStyleBackColor = true;
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // changelabel
            // 
            this.changelabel.AutoSize = true;
            this.changelabel.BackColor = System.Drawing.Color.Transparent;
            this.changelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelabel.ForeColor = System.Drawing.Color.Lime;
            this.changelabel.Location = new System.Drawing.Point(14, 452);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(56, 15);
            this.changelabel.TabIndex = 17;
            this.changelabel.Text = "Change";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.Transparent;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Red;
            this.output.Location = new System.Drawing.Point(16, 347);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 15);
            this.output.TabIndex = 18;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(153, 485);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(99, 25);
            this.reset.TabIndex = 19;
            this.reset.Text = "Place New Order";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // resetbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cash_register.Properties.Resources.dust_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 522);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.output);
            this.Controls.Add(this.changelabel);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changebox);
            this.Controls.Add(this.tenderd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.Taxlabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.karambit);
            this.Controls.Add(this.bayonet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "resetbutton";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bayonet;
        private System.Windows.Forms.TextBox karambit;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label Taxlabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tenderd;
        private System.Windows.Forms.TextBox changebox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button reset;
    }
}

