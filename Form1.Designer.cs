namespace Packaging_Calculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl Main;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Slilca_gen = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSGSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sg_height = new System.Windows.Forms.NumericUpDown();
            this.sg_width = new System.Windows.Forms.NumericUpDown();
            this.sg_Length = new System.Windows.Forms.NumericUpDown();
            this.SG_SilicaGelVolume = new System.Windows.Forms.MaskedTextBox();
            this.SG_PackageVolume = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Oxygen_absorber = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnOXASubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ox_foodWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ox_height = new System.Windows.Forms.NumericUpDown();
            this.ox_width = new System.Windows.Forms.NumericUpDown();
            this.ox_length = new System.Windows.Forms.NumericUpDown();
            this.OX_PackageVolume = new System.Windows.Forms.MaskedTextBox();
            this.OX_Oxygen_Absorber_Volume = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            Main = new System.Windows.Forms.TabControl();
            Main.SuspendLayout();
            this.Slilca_gen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sg_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sg_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sg_Length)).BeginInit();
            this.Oxygen_absorber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ox_foodWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            Main.Controls.Add(this.Slilca_gen);
            Main.Controls.Add(this.Oxygen_absorber);
            Main.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Main.Location = new System.Drawing.Point(0, 52);
            Main.Name = "Main";
            Main.SelectedIndex = 0;
            Main.Size = new System.Drawing.Size(481, 377);
            Main.TabIndex = 0;
            // 
            // Slilca_gen
            // 
            this.Slilca_gen.Controls.Add(this.splitContainer1);
            this.Slilca_gen.Location = new System.Drawing.Point(4, 24);
            this.Slilca_gen.Name = "Slilca_gen";
            this.Slilca_gen.Padding = new System.Windows.Forms.Padding(3);
            this.Slilca_gen.Size = new System.Drawing.Size(473, 349);
            this.Slilca_gen.TabIndex = 0;
            this.Slilca_gen.Text = "Silica Gel";
            this.Slilca_gen.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSGSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.sg_height);
            this.splitContainer1.Panel1.Controls.Add(this.sg_width);
            this.splitContainer1.Panel1.Controls.Add(this.sg_Length);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SG_SilicaGelVolume);
            this.splitContainer1.Panel2.Controls.Add(this.SG_PackageVolume);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(467, 343);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnSGSubmit
            // 
            this.btnSGSubmit.Location = new System.Drawing.Point(52, 233);
            this.btnSGSubmit.Name = "btnSGSubmit";
            this.btnSGSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSGSubmit.TabIndex = 4;
            this.btnSGSubmit.Text = "Submit";
            this.btnSGSubmit.UseVisualStyleBackColor = true;
            this.btnSGSubmit.Click += new System.EventHandler(this.btnSGSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length (cm)";
            // 
            // sg_height
            // 
            this.sg_height.DecimalPlaces = 2;
            this.sg_height.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.sg_height.Location = new System.Drawing.Point(5, 142);
            this.sg_height.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.sg_height.Name = "sg_height";
            this.sg_height.Size = new System.Drawing.Size(152, 23);
            this.sg_height.TabIndex = 2;
            this.sg_height.ValueChanged += new System.EventHandler(this.sg_height_ValueChanged);
            // 
            // sg_width
            // 
            this.sg_width.DecimalPlaces = 2;
            this.sg_width.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.sg_width.Location = new System.Drawing.Point(4, 83);
            this.sg_width.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.sg_width.Name = "sg_width";
            this.sg_width.Size = new System.Drawing.Size(152, 23);
            this.sg_width.TabIndex = 1;
            this.sg_width.ValueChanged += new System.EventHandler(this.sg_width_ValueChanged);
            // 
            // sg_Length
            // 
            this.sg_Length.DecimalPlaces = 2;
            this.sg_Length.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.sg_Length.Location = new System.Drawing.Point(5, 21);
            this.sg_Length.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.sg_Length.Name = "sg_Length";
            this.sg_Length.Size = new System.Drawing.Size(152, 23);
            this.sg_Length.TabIndex = 0;
            this.sg_Length.ValueChanged += new System.EventHandler(this.sg_Length_ValueChanged);
            // 
            // SG_SilicaGelVolume
            // 
            this.SG_SilicaGelVolume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SG_SilicaGelVolume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SG_SilicaGelVolume.Location = new System.Drawing.Point(26, 117);
            this.SG_SilicaGelVolume.Name = "SG_SilicaGelVolume";
            this.SG_SilicaGelVolume.ReadOnly = true;
            this.SG_SilicaGelVolume.Size = new System.Drawing.Size(231, 35);
            this.SG_SilicaGelVolume.TabIndex = 3;
            // 
            // SG_PackageVolume
            // 
            this.SG_PackageVolume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SG_PackageVolume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SG_PackageVolume.Location = new System.Drawing.Point(26, 42);
            this.SG_PackageVolume.Name = "SG_PackageVolume";
            this.SG_PackageVolume.ReadOnly = true;
            this.SG_PackageVolume.Size = new System.Drawing.Size(231, 35);
            this.SG_PackageVolume.TabIndex = 2;
            this.SG_PackageVolume.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SG_PackageVolume_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(41, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Silica Gel Volume (g)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Package Volume (CC)";
            // 
            // Oxygen_absorber
            // 
            this.Oxygen_absorber.Controls.Add(this.splitContainer2);
            this.Oxygen_absorber.Location = new System.Drawing.Point(4, 24);
            this.Oxygen_absorber.Name = "Oxygen_absorber";
            this.Oxygen_absorber.Padding = new System.Windows.Forms.Padding(3);
            this.Oxygen_absorber.Size = new System.Drawing.Size(473, 349);
            this.Oxygen_absorber.TabIndex = 1;
            this.Oxygen_absorber.Text = "Oxygen Absorber";
            this.Oxygen_absorber.UseVisualStyleBackColor = true;
            this.Oxygen_absorber.Click += new System.EventHandler(this.Oxygen_absorber_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnOXASubmit);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.ox_foodWeight);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.ox_height);
            this.splitContainer2.Panel1.Controls.Add(this.ox_width);
            this.splitContainer2.Panel1.Controls.Add(this.ox_length);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OX_PackageVolume);
            this.splitContainer2.Panel2.Controls.Add(this.OX_Oxygen_Absorber_Volume);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(755, 343);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // btnOXASubmit
            // 
            this.btnOXASubmit.Location = new System.Drawing.Point(52, 270);
            this.btnOXASubmit.Name = "btnOXASubmit";
            this.btnOXASubmit.Size = new System.Drawing.Size(75, 23);
            this.btnOXASubmit.TabIndex = 14;
            this.btnOXASubmit.Text = "Submit";
            this.btnOXASubmit.UseVisualStyleBackColor = true;
            this.btnOXASubmit.Click += new System.EventHandler(this.btnOXASubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Food weight (g)";
            // 
            // ox_foodWeight
            // 
            this.ox_foodWeight.DecimalPlaces = 2;
            this.ox_foodWeight.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ox_foodWeight.Location = new System.Drawing.Point(5, 203);
            this.ox_foodWeight.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ox_foodWeight.Name = "ox_foodWeight";
            this.ox_foodWeight.Size = new System.Drawing.Size(152, 23);
            this.ox_foodWeight.TabIndex = 12;
            this.ox_foodWeight.ValueChanged += new System.EventHandler(this.ox_foodWeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Height (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Width (cm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Length (cm)";
            // 
            // ox_height
            // 
            this.ox_height.DecimalPlaces = 2;
            this.ox_height.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ox_height.Location = new System.Drawing.Point(5, 142);
            this.ox_height.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ox_height.Name = "ox_height";
            this.ox_height.Size = new System.Drawing.Size(152, 23);
            this.ox_height.TabIndex = 8;
            this.ox_height.ValueChanged += new System.EventHandler(this.ox_height_ValueChanged);
            // 
            // ox_width
            // 
            this.ox_width.DecimalPlaces = 2;
            this.ox_width.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ox_width.Location = new System.Drawing.Point(4, 83);
            this.ox_width.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ox_width.Name = "ox_width";
            this.ox_width.Size = new System.Drawing.Size(152, 23);
            this.ox_width.TabIndex = 7;
            this.ox_width.ValueChanged += new System.EventHandler(this.ox_width_ValueChanged);
            // 
            // ox_length
            // 
            this.ox_length.DecimalPlaces = 2;
            this.ox_length.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ox_length.Location = new System.Drawing.Point(5, 21);
            this.ox_length.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ox_length.Name = "ox_length";
            this.ox_length.Size = new System.Drawing.Size(152, 23);
            this.ox_length.TabIndex = 6;
            this.ox_length.ValueChanged += new System.EventHandler(this.ox_length_ValueChanged);
            // 
            // OX_PackageVolume
            // 
            this.OX_PackageVolume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OX_PackageVolume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OX_PackageVolume.Location = new System.Drawing.Point(26, 42);
            this.OX_PackageVolume.Name = "OX_PackageVolume";
            this.OX_PackageVolume.ReadOnly = true;
            this.OX_PackageVolume.Size = new System.Drawing.Size(231, 35);
            this.OX_PackageVolume.TabIndex = 5;
            // 
            // OX_Oxygen_Absorber_Volume
            // 
            this.OX_Oxygen_Absorber_Volume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OX_Oxygen_Absorber_Volume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OX_Oxygen_Absorber_Volume.Location = new System.Drawing.Point(26, 117);
            this.OX_Oxygen_Absorber_Volume.Name = "OX_Oxygen_Absorber_Volume";
            this.OX_Oxygen_Absorber_Volume.ReadOnly = true;
            this.OX_Oxygen_Absorber_Volume.Size = new System.Drawing.Size(231, 35);
            this.OX_Oxygen_Absorber_Volume.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Oxygen Absorber Volume (CC)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(35, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Package Volume (CC)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(206, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 45);
            this.label12.TabIndex = 1;
            this.label12.Text = "Packaging Calculation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(612, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "by Settawat Boriruklert";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "v.0.11";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 307);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(770, 447);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(786, 486);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packing Calcultion";
            this.Load += new System.EventHandler(this.Form1_Load);
            Main.ResumeLayout(false);
            this.Slilca_gen.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sg_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sg_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sg_Length)).EndInit();
            this.Oxygen_absorber.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ox_foodWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ox_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage Oxygen_absorber;
        private SplitContainer splitContainer2;
        private Label label7;
        private NumericUpDown ox_foodWeight;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown ox_height;
        private NumericUpDown ox_width;
        private NumericUpDown ox_length;
        private TabPage Slilca_gen;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown sg_height;
        private NumericUpDown sg_width;
        private NumericUpDown sg_Length;
        private Label label8;
        private MaskedTextBox OX_PackageVolume;
        private MaskedTextBox OX_Oxygen_Absorber_Volume;
        private Label label10;
        private Label label11;
        private MaskedTextBox SG_SilicaGelVolume;
        private MaskedTextBox SG_PackageVolume;
        private Label label9;
        private Label label12;
        private Label label13;
        private Button btnOXASubmit;
        private Button btnSGSubmit;
        private PictureBox pictureBox1;
        private Label label14;
        private PictureBox pictureBox2;
    }
}