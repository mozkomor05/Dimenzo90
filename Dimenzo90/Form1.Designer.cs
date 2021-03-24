namespace Dimenzo90
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zwspeed = new System.Windows.Forms.ComboBox();
            this.zwreset = new System.Windows.Forms.Button();
            this.ywreset = new System.Windows.Forms.Button();
            this.xwreset = new System.Windows.Forms.Button();
            this.xyreset = new System.Windows.Forms.Button();
            this.xzreset = new System.Windows.Forms.Button();
            this.yzreset = new System.Windows.Forms.Button();
            this.ywspeed = new System.Windows.Forms.ComboBox();
            this.xwspeed = new System.Windows.Forms.ComboBox();
            this.xyspeed = new System.Windows.Forms.ComboBox();
            this.xzspeed = new System.Windows.Forms.ComboBox();
            this.yzspeed = new System.Windows.Forms.ComboBox();
            this.zwauto = new System.Windows.Forms.CheckBox();
            this.ywauto = new System.Windows.Forms.CheckBox();
            this.xwauto = new System.Windows.Forms.CheckBox();
            this.xyauto = new System.Windows.Forms.CheckBox();
            this.xzauto = new System.Windows.Forms.CheckBox();
            this.yzauto = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zwlabel = new System.Windows.Forms.Label();
            this.zwscroll = new System.Windows.Forms.TrackBar();
            this.ywlabel = new System.Windows.Forms.Label();
            this.ywscroll = new System.Windows.Forms.TrackBar();
            this.xwlabel = new System.Windows.Forms.Label();
            this.xwscroll = new System.Windows.Forms.TrackBar();
            this.xylabel = new System.Windows.Forms.Label();
            this.xyscroll = new System.Windows.Forms.TrackBar();
            this.xzlabel = new System.Windows.Forms.Label();
            this.xzscroll = new System.Windows.Forms.TrackBar();
            this.yzlabel = new System.Windows.Forms.Label();
            this.yzscroll = new System.Windows.Forms.TrackBar();
            this.opacity = new System.Windows.Forms.TrackBar();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prtype = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zwscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ywscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xwscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xzscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yzscroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zwspeed);
            this.groupBox1.Controls.Add(this.zwreset);
            this.groupBox1.Controls.Add(this.ywreset);
            this.groupBox1.Controls.Add(this.xwreset);
            this.groupBox1.Controls.Add(this.xyreset);
            this.groupBox1.Controls.Add(this.xzreset);
            this.groupBox1.Controls.Add(this.yzreset);
            this.groupBox1.Controls.Add(this.ywspeed);
            this.groupBox1.Controls.Add(this.xwspeed);
            this.groupBox1.Controls.Add(this.xyspeed);
            this.groupBox1.Controls.Add(this.xzspeed);
            this.groupBox1.Controls.Add(this.yzspeed);
            this.groupBox1.Controls.Add(this.zwauto);
            this.groupBox1.Controls.Add(this.ywauto);
            this.groupBox1.Controls.Add(this.xwauto);
            this.groupBox1.Controls.Add(this.xyauto);
            this.groupBox1.Controls.Add(this.xzauto);
            this.groupBox1.Controls.Add(this.yzauto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.zwlabel);
            this.groupBox1.Controls.Add(this.zwscroll);
            this.groupBox1.Controls.Add(this.ywlabel);
            this.groupBox1.Controls.Add(this.ywscroll);
            this.groupBox1.Controls.Add(this.xwlabel);
            this.groupBox1.Controls.Add(this.xwscroll);
            this.groupBox1.Controls.Add(this.xylabel);
            this.groupBox1.Controls.Add(this.xyscroll);
            this.groupBox1.Controls.Add(this.xzlabel);
            this.groupBox1.Controls.Add(this.xzscroll);
            this.groupBox1.Controls.Add(this.yzlabel);
            this.groupBox1.Controls.Add(this.yzscroll);
            this.groupBox1.Location = new System.Drawing.Point(782, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // zwspeed
            // 
            this.zwspeed.Enabled = false;
            this.zwspeed.FormattingEnabled = true;
            this.zwspeed.Location = new System.Drawing.Point(32, 319);
            this.zwspeed.Name = "zwspeed";
            this.zwspeed.Size = new System.Drawing.Size(44, 21);
            this.zwspeed.TabIndex = 32;
            this.zwspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // zwreset
            // 
            this.zwreset.Image = ((System.Drawing.Image)(resources.GetObject("zwreset.Image")));
            this.zwreset.Location = new System.Drawing.Point(484, 317);
            this.zwreset.Name = "zwreset";
            this.zwreset.Size = new System.Drawing.Size(28, 23);
            this.zwreset.TabIndex = 31;
            this.zwreset.UseVisualStyleBackColor = true;
            this.zwreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // ywreset
            // 
            this.ywreset.Image = ((System.Drawing.Image)(resources.GetObject("ywreset.Image")));
            this.ywreset.Location = new System.Drawing.Point(484, 264);
            this.ywreset.Name = "ywreset";
            this.ywreset.Size = new System.Drawing.Size(28, 23);
            this.ywreset.TabIndex = 30;
            this.ywreset.UseVisualStyleBackColor = true;
            this.ywreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // xwreset
            // 
            this.xwreset.Image = ((System.Drawing.Image)(resources.GetObject("xwreset.Image")));
            this.xwreset.Location = new System.Drawing.Point(484, 215);
            this.xwreset.Name = "xwreset";
            this.xwreset.Size = new System.Drawing.Size(28, 23);
            this.xwreset.TabIndex = 29;
            this.xwreset.UseVisualStyleBackColor = true;
            this.xwreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // xyreset
            // 
            this.xyreset.Image = ((System.Drawing.Image)(resources.GetObject("xyreset.Image")));
            this.xyreset.Location = new System.Drawing.Point(484, 166);
            this.xyreset.Name = "xyreset";
            this.xyreset.Size = new System.Drawing.Size(28, 23);
            this.xyreset.TabIndex = 28;
            this.xyreset.UseVisualStyleBackColor = true;
            this.xyreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // xzreset
            // 
            this.xzreset.Image = ((System.Drawing.Image)(resources.GetObject("xzreset.Image")));
            this.xzreset.Location = new System.Drawing.Point(484, 111);
            this.xzreset.Name = "xzreset";
            this.xzreset.Size = new System.Drawing.Size(28, 23);
            this.xzreset.TabIndex = 27;
            this.xzreset.UseVisualStyleBackColor = true;
            this.xzreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // yzreset
            // 
            this.yzreset.Image = ((System.Drawing.Image)(resources.GetObject("yzreset.Image")));
            this.yzreset.Location = new System.Drawing.Point(484, 51);
            this.yzreset.Name = "yzreset";
            this.yzreset.Size = new System.Drawing.Size(28, 23);
            this.yzreset.TabIndex = 26;
            this.yzreset.UseVisualStyleBackColor = true;
            this.yzreset.Click += new System.EventHandler(this.ResetClick);
            // 
            // ywspeed
            // 
            this.ywspeed.Enabled = false;
            this.ywspeed.FormattingEnabled = true;
            this.ywspeed.Location = new System.Drawing.Point(32, 266);
            this.ywspeed.Name = "ywspeed";
            this.ywspeed.Size = new System.Drawing.Size(44, 21);
            this.ywspeed.TabIndex = 24;
            this.ywspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // xwspeed
            // 
            this.xwspeed.Enabled = false;
            this.xwspeed.FormattingEnabled = true;
            this.xwspeed.Location = new System.Drawing.Point(32, 217);
            this.xwspeed.Name = "xwspeed";
            this.xwspeed.Size = new System.Drawing.Size(44, 21);
            this.xwspeed.TabIndex = 23;
            this.xwspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // xyspeed
            // 
            this.xyspeed.Enabled = false;
            this.xyspeed.FormattingEnabled = true;
            this.xyspeed.Location = new System.Drawing.Point(32, 168);
            this.xyspeed.Name = "xyspeed";
            this.xyspeed.Size = new System.Drawing.Size(44, 21);
            this.xyspeed.TabIndex = 22;
            this.xyspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // xzspeed
            // 
            this.xzspeed.Enabled = false;
            this.xzspeed.FormattingEnabled = true;
            this.xzspeed.Location = new System.Drawing.Point(32, 113);
            this.xzspeed.Name = "xzspeed";
            this.xzspeed.Size = new System.Drawing.Size(44, 21);
            this.xzspeed.TabIndex = 21;
            this.xzspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // yzspeed
            // 
            this.yzspeed.Enabled = false;
            this.yzspeed.FormattingEnabled = true;
            this.yzspeed.Location = new System.Drawing.Point(32, 53);
            this.yzspeed.Name = "yzspeed";
            this.yzspeed.Size = new System.Drawing.Size(44, 21);
            this.yzspeed.TabIndex = 20;
            this.yzspeed.SelectedValueChanged += new System.EventHandler(this.SpeedChanged);
            // 
            // zwauto
            // 
            this.zwauto.AutoSize = true;
            this.zwauto.Location = new System.Drawing.Point(10, 322);
            this.zwauto.Name = "zwauto";
            this.zwauto.Size = new System.Drawing.Size(15, 14);
            this.zwauto.TabIndex = 19;
            this.zwauto.UseVisualStyleBackColor = true;
            this.zwauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // ywauto
            // 
            this.ywauto.AutoSize = true;
            this.ywauto.Location = new System.Drawing.Point(10, 269);
            this.ywauto.Name = "ywauto";
            this.ywauto.Size = new System.Drawing.Size(15, 14);
            this.ywauto.TabIndex = 18;
            this.ywauto.UseVisualStyleBackColor = true;
            this.ywauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // xwauto
            // 
            this.xwauto.AutoSize = true;
            this.xwauto.Location = new System.Drawing.Point(10, 220);
            this.xwauto.Name = "xwauto";
            this.xwauto.Size = new System.Drawing.Size(15, 14);
            this.xwauto.TabIndex = 17;
            this.xwauto.UseVisualStyleBackColor = true;
            this.xwauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // xyauto
            // 
            this.xyauto.AutoSize = true;
            this.xyauto.Location = new System.Drawing.Point(10, 171);
            this.xyauto.Name = "xyauto";
            this.xyauto.Size = new System.Drawing.Size(15, 14);
            this.xyauto.TabIndex = 16;
            this.xyauto.UseVisualStyleBackColor = true;
            this.xyauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // xzauto
            // 
            this.xzauto.AutoSize = true;
            this.xzauto.Location = new System.Drawing.Point(10, 116);
            this.xzauto.Name = "xzauto";
            this.xzauto.Size = new System.Drawing.Size(15, 14);
            this.xzauto.TabIndex = 15;
            this.xzauto.UseVisualStyleBackColor = true;
            this.xzauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // yzauto
            // 
            this.yzauto.AutoSize = true;
            this.yzauto.Location = new System.Drawing.Point(10, 56);
            this.yzauto.Name = "yzauto";
            this.yzauto.Size = new System.Drawing.Size(15, 14);
            this.yzauto.TabIndex = 14;
            this.yzauto.UseVisualStyleBackColor = true;
            this.yzauto.CheckedChanged += new System.EventHandler(this.AutoChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Automatic rotation";
            // 
            // zwlabel
            // 
            this.zwlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zwlabel.Location = new System.Drawing.Point(365, 295);
            this.zwlabel.Name = "zwlabel";
            this.zwlabel.Size = new System.Drawing.Size(146, 13);
            this.zwlabel.TabIndex = 12;
            this.zwlabel.Text = "0° - ZW label";
            this.zwlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zwscroll
            // 
            this.zwscroll.Location = new System.Drawing.Point(82, 311);
            this.zwscroll.Maximum = 18000;
            this.zwscroll.Minimum = -18000;
            this.zwscroll.Name = "zwscroll";
            this.zwscroll.Size = new System.Drawing.Size(406, 45);
            this.zwscroll.TabIndex = 11;
            this.zwscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // ywlabel
            // 
            this.ywlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ywlabel.Location = new System.Drawing.Point(365, 244);
            this.ywlabel.Name = "ywlabel";
            this.ywlabel.Size = new System.Drawing.Size(146, 13);
            this.ywlabel.TabIndex = 10;
            this.ywlabel.Text = "0° - YW plane";
            this.ywlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ywscroll
            // 
            this.ywscroll.Location = new System.Drawing.Point(82, 260);
            this.ywscroll.Maximum = 18000;
            this.ywscroll.Minimum = -18000;
            this.ywscroll.Name = "ywscroll";
            this.ywscroll.Size = new System.Drawing.Size(406, 45);
            this.ywscroll.TabIndex = 9;
            this.ywscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // xwlabel
            // 
            this.xwlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xwlabel.Location = new System.Drawing.Point(365, 193);
            this.xwlabel.Name = "xwlabel";
            this.xwlabel.Size = new System.Drawing.Size(146, 13);
            this.xwlabel.TabIndex = 8;
            this.xwlabel.Text = "0° - XW plane";
            this.xwlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xwscroll
            // 
            this.xwscroll.Location = new System.Drawing.Point(82, 209);
            this.xwscroll.Maximum = 18000;
            this.xwscroll.Minimum = -18000;
            this.xwscroll.Name = "xwscroll";
            this.xwscroll.Size = new System.Drawing.Size(406, 45);
            this.xwscroll.TabIndex = 7;
            this.xwscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // xylabel
            // 
            this.xylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xylabel.Location = new System.Drawing.Point(388, 142);
            this.xylabel.Name = "xylabel";
            this.xylabel.Size = new System.Drawing.Size(123, 13);
            this.xylabel.TabIndex = 6;
            this.xylabel.Text = "0° - XY plane";
            this.xylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xyscroll
            // 
            this.xyscroll.Location = new System.Drawing.Point(82, 158);
            this.xyscroll.Maximum = 18000;
            this.xyscroll.Minimum = -18000;
            this.xyscroll.Name = "xyscroll";
            this.xyscroll.Size = new System.Drawing.Size(406, 45);
            this.xyscroll.TabIndex = 5;
            this.xyscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // xzlabel
            // 
            this.xzlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xzlabel.Location = new System.Drawing.Point(385, 91);
            this.xzlabel.Name = "xzlabel";
            this.xzlabel.Size = new System.Drawing.Size(126, 13);
            this.xzlabel.TabIndex = 4;
            this.xzlabel.Text = "0° - XZ plane";
            this.xzlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xzscroll
            // 
            this.xzscroll.Location = new System.Drawing.Point(82, 107);
            this.xzscroll.Maximum = 18000;
            this.xzscroll.Minimum = -18000;
            this.xzscroll.Name = "xzscroll";
            this.xzscroll.Size = new System.Drawing.Size(406, 45);
            this.xzscroll.TabIndex = 3;
            this.xzscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // yzlabel
            // 
            this.yzlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yzlabel.Location = new System.Drawing.Point(365, 30);
            this.yzlabel.Name = "yzlabel";
            this.yzlabel.Size = new System.Drawing.Size(146, 13);
            this.yzlabel.TabIndex = 2;
            this.yzlabel.Text = "0° - YZ plane";
            this.yzlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yzscroll
            // 
            this.yzscroll.Location = new System.Drawing.Point(82, 46);
            this.yzscroll.Maximum = 18000;
            this.yzscroll.Minimum = -18000;
            this.yzscroll.Name = "yzscroll";
            this.yzscroll.Size = new System.Drawing.Size(406, 45);
            this.yzscroll.TabIndex = 1;
            this.yzscroll.ValueChanged += new System.EventHandler(this.RotationAxeChanged);
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(6, 32);
            this.opacity.Maximum = 255;
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(505, 45);
            this.opacity.TabIndex = 1;
            this.opacity.Value = 20;
            this.opacity.Scroll += new System.EventHandler(this.Opacity_Scroll);
            // 
            // opacityLabel
            // 
            this.opacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityLabel.Location = new System.Drawing.Point(317, 16);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(194, 13);
            this.opacityLabel.TabIndex = 2;
            this.opacityLabel.Text = "20 - Faces\' opacity";
            this.opacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prtype);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.opacityLabel);
            this.groupBox2.Controls.Add(this.opacity);
            this.groupBox2.Location = new System.Drawing.Point(782, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appearance";
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(764, 737);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Projection type:";
            // 
            // prtype
            // 
            this.prtype.FormattingEnabled = true;
            this.prtype.Items.AddRange(new object[] {
            "Perspection projection (between all dimensions, d)",
            "Orthographic projection for unnatural dimensions (d > 3)",
            "Orthographic projection (between all dimensions, d)"});
            this.prtype.Location = new System.Drawing.Point(93, 77);
            this.prtype.Name = "prtype";
            this.prtype.Size = new System.Drawing.Size(418, 21);
            this.prtype.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1328, 800);
            this.MinimumSize = new System.Drawing.Size(1328, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimenzo90";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zwscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ywscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xwscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xzscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yzscroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label xylabel;
        private System.Windows.Forms.TrackBar xyscroll;
        private System.Windows.Forms.Label xzlabel;
        private System.Windows.Forms.TrackBar xzscroll;
        private System.Windows.Forms.Label yzlabel;
        private System.Windows.Forms.TrackBar yzscroll;
        private System.Windows.Forms.TrackBar opacity;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button zwreset;
        private System.Windows.Forms.Button ywreset;
        private System.Windows.Forms.Button xwreset;
        private System.Windows.Forms.Button xyreset;
        private System.Windows.Forms.Button xzreset;
        private System.Windows.Forms.Button yzreset;
        private System.Windows.Forms.ComboBox ywspeed;
        private System.Windows.Forms.ComboBox xwspeed;
        private System.Windows.Forms.ComboBox xyspeed;
        private System.Windows.Forms.ComboBox xzspeed;
        private System.Windows.Forms.ComboBox yzspeed;
        private System.Windows.Forms.CheckBox zwauto;
        private System.Windows.Forms.CheckBox ywauto;
        private System.Windows.Forms.CheckBox xwauto;
        private System.Windows.Forms.CheckBox xyauto;
        private System.Windows.Forms.CheckBox xzauto;
        private System.Windows.Forms.CheckBox yzauto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label zwlabel;
        private System.Windows.Forms.TrackBar zwscroll;
        private System.Windows.Forms.Label ywlabel;
        private System.Windows.Forms.TrackBar ywscroll;
        private System.Windows.Forms.Label xwlabel;
        private System.Windows.Forms.TrackBar xwscroll;
        private System.Windows.Forms.ComboBox zwspeed;
        private System.Windows.Forms.ComboBox prtype;
        private System.Windows.Forms.Label label1;
    }
}

