namespace ClientApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dt = new System.Windows.Forms.TabPage();
            this.kn = new System.Windows.Forms.TabPage();
            this.matX = new System.Windows.Forms.TextBox();
            this.matY = new System.Windows.Forms.TextBox();
            this.permX = new System.Windows.Forms.TextBox();
            this.permY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtprivate = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtpublic = new System.Windows.Forms.TextBox();
            this.xtea = new System.Windows.Forms.TabPage();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dt.SuspendLayout();
            this.kn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.xtea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dt);
            this.tabControl1.Controls.Add(this.kn);
            this.tabControl1.Controls.Add(this.xtea);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // dt
            // 
            this.dt.Controls.Add(this.label4);
            this.dt.Controls.Add(this.label3);
            this.dt.Controls.Add(this.label2);
            this.dt.Controls.Add(this.label1);
            this.dt.Controls.Add(this.permY);
            this.dt.Controls.Add(this.permX);
            this.dt.Controls.Add(this.matY);
            this.dt.Controls.Add(this.matX);
            this.dt.Location = new System.Drawing.Point(4, 25);
            this.dt.Name = "dt";
            this.dt.Padding = new System.Windows.Forms.Padding(3);
            this.dt.Size = new System.Drawing.Size(594, 329);
            this.dt.TabIndex = 0;
            this.dt.Text = "Double Transposition";
            this.dt.UseVisualStyleBackColor = true;
            // 
            // kn
            // 
            this.kn.Controls.Add(this.label8);
            this.kn.Controls.Add(this.label7);
            this.kn.Controls.Add(this.label6);
            this.kn.Controls.Add(this.label5);
            this.kn.Controls.Add(this.txtpublic);
            this.kn.Controls.Add(this.button4);
            this.kn.Controls.Add(this.txtn);
            this.kn.Controls.Add(this.txtm);
            this.kn.Controls.Add(this.txtprivate);
            this.kn.Location = new System.Drawing.Point(4, 25);
            this.kn.Name = "kn";
            this.kn.Padding = new System.Windows.Forms.Padding(3);
            this.kn.Size = new System.Drawing.Size(594, 329);
            this.kn.TabIndex = 1;
            this.kn.Text = "Knapsack";
            this.kn.UseVisualStyleBackColor = true;
            // 
            // matX
            // 
            this.matX.Location = new System.Drawing.Point(131, 39);
            this.matX.Name = "matX";
            this.matX.Size = new System.Drawing.Size(100, 22);
            this.matX.TabIndex = 0;
            // 
            // matY
            // 
            this.matY.Location = new System.Drawing.Point(131, 114);
            this.matY.Name = "matY";
            this.matY.Size = new System.Drawing.Size(100, 22);
            this.matY.TabIndex = 1;
            // 
            // permX
            // 
            this.permX.Location = new System.Drawing.Point(131, 190);
            this.permX.Name = "permX";
            this.permX.Size = new System.Drawing.Size(100, 22);
            this.permX.TabIndex = 2;
            // 
            // permY
            // 
            this.permY.Location = new System.Drawing.Point(131, 255);
            this.permY.Name = "permY";
            this.permY.Size = new System.Drawing.Size(100, 22);
            this.permY.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypt and save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Decrypt and download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(616, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 266);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtprivate
            // 
            this.txtprivate.Location = new System.Drawing.Point(136, 46);
            this.txtprivate.Name = "txtprivate";
            this.txtprivate.Size = new System.Drawing.Size(220, 22);
            this.txtprivate.TabIndex = 0;
            this.txtprivate.Text = "2,3,7,14,30,57,120,251";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(136, 93);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 22);
            this.txtm.TabIndex = 1;
            this.txtm.Text = "41";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(136, 148);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 2;
            this.txtn.Text = "491";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtpublic
            // 
            this.txtpublic.Location = new System.Drawing.Point(136, 202);
            this.txtpublic.Name = "txtpublic";
            this.txtpublic.Size = new System.Drawing.Size(245, 22);
            this.txtpublic.TabIndex = 5;
            // 
            // xtea
            // 
            this.xtea.Controls.Add(this.label9);
            this.xtea.Controls.Add(this.txtkey);
            this.xtea.Location = new System.Drawing.Point(4, 25);
            this.xtea.Name = "xtea";
            this.xtea.Size = new System.Drawing.Size(594, 329);
            this.xtea.TabIndex = 2;
            this.xtea.Text = "XTEA";
            this.xtea.UseVisualStyleBackColor = true;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(108, 48);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(328, 22);
            this.txtkey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MatX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MatY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "PermX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PermY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Private key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "M:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "N:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Public key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Key:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.dt.ResumeLayout(false);
            this.dt.PerformLayout();
            this.kn.ResumeLayout(false);
            this.kn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.xtea.ResumeLayout(false);
            this.xtea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dt;
        private System.Windows.Forms.TextBox permY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox permX;
        private System.Windows.Forms.TextBox matY;
        private System.Windows.Forms.TextBox matX;
        private System.Windows.Forms.TabPage kn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpublic;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtprivate;
        private System.Windows.Forms.TabPage xtea;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}