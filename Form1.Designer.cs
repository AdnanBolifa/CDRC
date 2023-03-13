namespace CDRC
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
            System.Windows.Forms.GroupBox TeamsGroup;
            this.outputPower = new System.Windows.Forms.ListBox();
            this.outputSuperGirls = new System.Windows.Forms.ListBox();
            this.outputWinner = new System.Windows.Forms.ListBox();
            this.outputStars = new System.Windows.Forms.ListBox();
            this.outputDreamers = new System.Windows.Forms.ListBox();
            this.outputCreative = new System.Windows.Forms.ListBox();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sex = new System.Windows.Forms.DomainUpDown();
            this.Input = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pull = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TeamMembers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            TeamsGroup = new System.Windows.Forms.GroupBox();
            TeamsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamsGroup
            // 
            TeamsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TeamsGroup.Controls.Add(this.outputPower);
            TeamsGroup.Controls.Add(this.outputSuperGirls);
            TeamsGroup.Controls.Add(this.outputWinner);
            TeamsGroup.Controls.Add(this.outputStars);
            TeamsGroup.Controls.Add(this.outputDreamers);
            TeamsGroup.Controls.Add(this.outputCreative);
            TeamsGroup.Location = new System.Drawing.Point(278, 69);
            TeamsGroup.Name = "TeamsGroup";
            TeamsGroup.Size = new System.Drawing.Size(454, 496);
            TeamsGroup.TabIndex = 10;
            TeamsGroup.TabStop = false;
            TeamsGroup.Text = "Teams";
            // 
            // outputPower
            // 
            this.outputPower.FormattingEnabled = true;
            this.outputPower.ItemHeight = 15;
            this.outputPower.Location = new System.Drawing.Point(12, 22);
            this.outputPower.Name = "outputPower";
            this.outputPower.Size = new System.Drawing.Size(212, 139);
            this.outputPower.TabIndex = 6;
            // 
            // outputSuperGirls
            // 
            this.outputSuperGirls.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outputSuperGirls.FormattingEnabled = true;
            this.outputSuperGirls.ItemHeight = 15;
            this.outputSuperGirls.Location = new System.Drawing.Point(236, 179);
            this.outputSuperGirls.Name = "outputSuperGirls";
            this.outputSuperGirls.Size = new System.Drawing.Size(212, 139);
            this.outputSuperGirls.TabIndex = 5;
            // 
            // outputWinner
            // 
            this.outputWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputWinner.FormattingEnabled = true;
            this.outputWinner.ItemHeight = 15;
            this.outputWinner.Location = new System.Drawing.Point(12, 335);
            this.outputWinner.Name = "outputWinner";
            this.outputWinner.Size = new System.Drawing.Size(212, 139);
            this.outputWinner.TabIndex = 9;
            // 
            // outputStars
            // 
            this.outputStars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputStars.FormattingEnabled = true;
            this.outputStars.ItemHeight = 15;
            this.outputStars.Location = new System.Drawing.Point(236, 335);
            this.outputStars.Name = "outputStars";
            this.outputStars.Size = new System.Drawing.Size(212, 139);
            this.outputStars.TabIndex = 3;
            // 
            // outputDreamers
            // 
            this.outputDreamers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputDreamers.FormattingEnabled = true;
            this.outputDreamers.ItemHeight = 15;
            this.outputDreamers.Location = new System.Drawing.Point(12, 179);
            this.outputDreamers.Name = "outputDreamers";
            this.outputDreamers.Size = new System.Drawing.Size(212, 139);
            this.outputDreamers.TabIndex = 8;
            // 
            // outputCreative
            // 
            this.outputCreative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputCreative.FormattingEnabled = true;
            this.outputCreative.ItemHeight = 15;
            this.outputCreative.Location = new System.Drawing.Point(236, 22);
            this.outputCreative.Name = "outputCreative";
            this.outputCreative.Size = new System.Drawing.Size(212, 139);
            this.outputCreative.TabIndex = 7;
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.ItemHeight = 15;
            this.NameListBox.Location = new System.Drawing.Point(6, 57);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(248, 424);
            this.NameListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Sex);
            this.groupBox1.Controls.Add(this.Input);
            this.groupBox1.Controls.Add(this.NameListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Names";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(215, 23);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(39, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sex
            // 
            this.Sex.Items.Add("Male");
            this.Sex.Items.Add("Female");
            this.Sex.Location = new System.Drawing.Point(150, 23);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(64, 23);
            this.Sex.TabIndex = 4;
            this.Sex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sex_KeyDown);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(6, 22);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(138, 23);
            this.Input.TabIndex = 1;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(18, 510);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(248, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gender";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Pull);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.TeamMembers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // Pull
            // 
            this.Pull.Location = new System.Drawing.Point(340, 18);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(93, 23);
            this.Pull.TabIndex = 5;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = true;
            this.Pull.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(144, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Label";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TeamMembers
            // 
            this.TeamMembers.Location = new System.Drawing.Point(292, 18);
            this.TeamMembers.Name = "TeamMembers";
            this.TeamMembers.Size = new System.Drawing.Size(32, 23);
            this.TeamMembers.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Team Member";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Default";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(735, 566);
            this.Controls.Add(TeamsGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CDRC";
            TeamsGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox NameListBox;
        private GroupBox groupBox1;
        private TextBox Input;
        private Button Start;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button Add;
        private ListBox outputStars;
        private ListBox outputSuperGirls;
        private ListBox outputPower;
        private ListBox outputCreative;
        private ListBox outputDreamers;
        private ListBox outputWinner;
        private GroupBox TeamsGroup;
        private NumericUpDown TeamMembers;
        private Label label1;
        private DomainUpDown Sex;
        private Button Pull;
    }
}