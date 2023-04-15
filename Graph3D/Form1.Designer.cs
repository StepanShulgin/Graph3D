namespace Graph3D
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P00X = new System.Windows.Forms.TextBox();
            this.P01X = new System.Windows.Forms.TextBox();
            this.P10X = new System.Windows.Forms.TextBox();
            this.P11X = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.P00Y = new System.Windows.Forms.TextBox();
            this.P00Z = new System.Windows.Forms.TextBox();
            this.P01Y = new System.Windows.Forms.TextBox();
            this.P01Z = new System.Windows.Forms.TextBox();
            this.P10Y = new System.Windows.Forms.TextBox();
            this.P10Z = new System.Windows.Forms.TextBox();
            this.P11Y = new System.Windows.Forms.TextBox();
            this.P11Z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.xRat = new System.Windows.Forms.TextBox();
            this.yRat = new System.Windows.Forms.TextBox();
            this.graph3D1 = new Plot3D.Graph3D();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "P00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "P10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "P11";
            // 
            // P00X
            // 
            this.P00X.Location = new System.Drawing.Point(825, 41);
            this.P00X.Name = "P00X";
            this.P00X.Size = new System.Drawing.Size(23, 20);
            this.P00X.TabIndex = 5;
            this.P00X.Text = "0";
            this.P00X.TextChanged += new System.EventHandler(this.POOX_TextChanged);
            // 
            // P01X
            // 
            this.P01X.Location = new System.Drawing.Point(825, 90);
            this.P01X.Name = "P01X";
            this.P01X.Size = new System.Drawing.Size(23, 20);
            this.P01X.TabIndex = 6;
            this.P01X.Text = "1";
            this.P01X.TextChanged += new System.EventHandler(this.PO1X_TextChanged);
            // 
            // P10X
            // 
            this.P10X.Location = new System.Drawing.Point(825, 147);
            this.P10X.Name = "P10X";
            this.P10X.Size = new System.Drawing.Size(23, 20);
            this.P10X.TabIndex = 7;
            this.P10X.Text = "0";
            this.P10X.TextChanged += new System.EventHandler(this.P10X_TextChanged);
            // 
            // P11X
            // 
            this.P11X.Location = new System.Drawing.Point(825, 203);
            this.P11X.Name = "P11X";
            this.P11X.Size = new System.Drawing.Size(23, 20);
            this.P11X.TabIndex = 8;
            this.P11X.Text = "1";
            this.P11X.TextChanged += new System.EventHandler(this.P11X_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P00Y
            // 
            this.P00Y.Location = new System.Drawing.Point(877, 41);
            this.P00Y.Name = "P00Y";
            this.P00Y.Size = new System.Drawing.Size(23, 20);
            this.P00Y.TabIndex = 10;
            this.P00Y.Text = "0";
            this.P00Y.TextChanged += new System.EventHandler(this.POOY_TextChanged);
            // 
            // P00Z
            // 
            this.P00Z.Location = new System.Drawing.Point(925, 41);
            this.P00Z.Name = "P00Z";
            this.P00Z.Size = new System.Drawing.Size(23, 20);
            this.P00Z.TabIndex = 11;
            this.P00Z.Text = "1";
            this.P00Z.TextChanged += new System.EventHandler(this.POOZ_TextChanged);
            // 
            // P01Y
            // 
            this.P01Y.Location = new System.Drawing.Point(877, 90);
            this.P01Y.Name = "P01Y";
            this.P01Y.Size = new System.Drawing.Size(23, 20);
            this.P01Y.TabIndex = 12;
            this.P01Y.Text = "1";
            this.P01Y.TextChanged += new System.EventHandler(this.PO1Y_TextChanged);
            // 
            // P01Z
            // 
            this.P01Z.Location = new System.Drawing.Point(925, 90);
            this.P01Z.Name = "P01Z";
            this.P01Z.Size = new System.Drawing.Size(23, 20);
            this.P01Z.TabIndex = 13;
            this.P01Z.Text = "1";
            this.P01Z.TextChanged += new System.EventHandler(this.PO1Z_TextChanged);
            // 
            // P10Y
            // 
            this.P10Y.Location = new System.Drawing.Point(877, 147);
            this.P10Y.Name = "P10Y";
            this.P10Y.Size = new System.Drawing.Size(23, 20);
            this.P10Y.TabIndex = 14;
            this.P10Y.Text = "1";
            this.P10Y.TextChanged += new System.EventHandler(this.P10Y_TextChanged);
            // 
            // P10Z
            // 
            this.P10Z.Location = new System.Drawing.Point(925, 147);
            this.P10Z.Name = "P10Z";
            this.P10Z.Size = new System.Drawing.Size(23, 20);
            this.P10Z.TabIndex = 15;
            this.P10Z.Text = "0";
            this.P10Z.TextChanged += new System.EventHandler(this.P10Z_TextChanged);
            // 
            // P11Y
            // 
            this.P11Y.Location = new System.Drawing.Point(877, 203);
            this.P11Y.Name = "P11Y";
            this.P11Y.Size = new System.Drawing.Size(23, 20);
            this.P11Y.TabIndex = 16;
            this.P11Y.Text = "0";
            this.P11Y.TextChanged += new System.EventHandler(this.P11Y_TextChanged);
            // 
            // P11Z
            // 
            this.P11Z.Location = new System.Drawing.Point(925, 203);
            this.P11Z.Name = "P11Z";
            this.P11Z.Size = new System.Drawing.Size(23, 20);
            this.P11Z.TabIndex = 17;
            this.P11Z.Text = "0";
            this.P11Z.TextChanged += new System.EventHandler(this.P11Z_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(857, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(857, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(857, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(857, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(906, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(906, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Z";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(906, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(906, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Z";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(808, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "X rotation";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(808, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Y rotation";
            // 
            // xRat
            // 
            this.xRat.Location = new System.Drawing.Point(811, 258);
            this.xRat.Name = "xRat";
            this.xRat.Size = new System.Drawing.Size(100, 20);
            this.xRat.TabIndex = 32;
            this.xRat.Text = "0";
            this.xRat.TextChanged += new System.EventHandler(this.xRat_TextChanged);
            // 
            // yRat
            // 
            this.yRat.Location = new System.Drawing.Point(811, 308);
            this.yRat.Name = "yRat";
            this.yRat.Size = new System.Drawing.Size(100, 20);
            this.yRat.TabIndex = 33;
            this.yRat.Text = "0";
            this.yRat.TextChanged += new System.EventHandler(this.yRat_TextChanged);
            // 
            // graph3D1
            // 
            this.graph3D1.AxisX_Color = System.Drawing.Color.DarkBlue;
            this.graph3D1.AxisX_Legend = null;
            this.graph3D1.AxisY_Color = System.Drawing.Color.DarkGreen;
            this.graph3D1.AxisY_Legend = null;
            this.graph3D1.AxisZ_Color = System.Drawing.Color.DarkRed;
            this.graph3D1.AxisZ_Legend = null;
            this.graph3D1.BackColor = System.Drawing.Color.White;
            this.graph3D1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.graph3D1.Location = new System.Drawing.Point(12, 12);
            this.graph3D1.Name = "graph3D1";
            this.graph3D1.PolygonLineColor = System.Drawing.Color.Black;
            this.graph3D1.Raster = Plot3D.Graph3D.eRaster.Off;
            this.graph3D1.Size = new System.Drawing.Size(776, 426);
            this.graph3D1.TabIndex = 0;
            this.graph3D1.TopLegendColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.graph3D1.Load += new System.EventHandler(this.graph3D1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 457);
            this.Controls.Add(this.yRat);
            this.Controls.Add(this.xRat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P11Z);
            this.Controls.Add(this.P11Y);
            this.Controls.Add(this.P10Z);
            this.Controls.Add(this.P10Y);
            this.Controls.Add(this.P01Z);
            this.Controls.Add(this.P01Y);
            this.Controls.Add(this.P00Z);
            this.Controls.Add(this.P00Y);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P11X);
            this.Controls.Add(this.P10X);
            this.Controls.Add(this.P01X);
            this.Controls.Add(this.P00X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph3D1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Plot3D.Graph3D graph3D1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P00X;
        private System.Windows.Forms.TextBox P01X;
        private System.Windows.Forms.TextBox P10X;
        private System.Windows.Forms.TextBox P11X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox P00Y;
        private System.Windows.Forms.TextBox P00Z;
        private System.Windows.Forms.TextBox P01Y;
        private System.Windows.Forms.TextBox P01Z;
        private System.Windows.Forms.TextBox P10Y;
        private System.Windows.Forms.TextBox P10Z;
        private System.Windows.Forms.TextBox P11Y;
        private System.Windows.Forms.TextBox P11Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox xRat;
        private System.Windows.Forms.TextBox yRat;
    }
}