namespace Test_Application
{
    partial class FormCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculate));
            this.radianLabel = new System.Windows.Forms.Label();
            this.radianBox = new System.Windows.Forms.TextBox();
            this.degriesBox = new System.Windows.Forms.TextBox();
            this.degriesLabel = new System.Windows.Forms.Label();
            this.smallDivideAngleBox = new System.Windows.Forms.TextBox();
            this.smallDivideAngleLabel = new System.Windows.Forms.Label();
            this.degriesRadio = new System.Windows.Forms.RadioButton();
            this.smallDivideAngelRadio = new System.Windows.Forms.RadioButton();
            this.radianRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.LegLabel = new System.Windows.Forms.Label();
            this.legBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.angleFieldLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radianLabel
            // 
            this.radianLabel.AutoSize = true;
            this.radianLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.radianLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radianLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radianLabel.Location = new System.Drawing.Point(137, 84);
            this.radianLabel.Name = "radianLabel";
            this.radianLabel.Size = new System.Drawing.Size(44, 14);
            this.radianLabel.TabIndex = 0;
            this.radianLabel.Text = "Радианы";
            this.radianLabel.Click += new System.EventHandler(this.RadiansLabel_Click);
            // 
            // radianBox
            // 
            this.radianBox.AcceptsTab = true;
            this.radianBox.Enabled = false;
            this.radianBox.Location = new System.Drawing.Point(131, 100);
            this.radianBox.Name = "radianBox";
            this.radianBox.Size = new System.Drawing.Size(63, 20);
            this.radianBox.TabIndex = 2;
            this.radianBox.TextChanged += new System.EventHandler(this.RadianBox_TextChanged);
            // 
            // degriesBox
            // 
            this.degriesBox.Location = new System.Drawing.Point(130, 61);
            this.degriesBox.MaxLength = 6;
            this.degriesBox.Name = "degriesBox";
            this.degriesBox.Size = new System.Drawing.Size(64, 20);
            this.degriesBox.TabIndex = 3;
            this.degriesBox.TextChanged += new System.EventHandler(this.DegriesBox_TextChanged);
            // 
            // degriesLabel
            // 
            this.degriesLabel.AutoSize = true;
            this.degriesLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.degriesLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degriesLabel.Location = new System.Drawing.Point(138, 45);
            this.degriesLabel.Name = "degriesLabel";
            this.degriesLabel.Size = new System.Drawing.Size(43, 14);
            this.degriesLabel.TabIndex = 4;
            this.degriesLabel.Text = "Градусы";
            this.degriesLabel.Click += new System.EventHandler(this.Degries_Label_Click);
            // 
            // smallDivideAngleBox
            // 
            this.smallDivideAngleBox.Enabled = false;
            this.smallDivideAngleBox.Location = new System.Drawing.Point(130, 22);
            this.smallDivideAngleBox.Name = "smallDivideAngleBox";
            this.smallDivideAngleBox.Size = new System.Drawing.Size(64, 20);
            this.smallDivideAngleBox.TabIndex = 5;
            this.smallDivideAngleBox.TextChanged += new System.EventHandler(this.SmallDivideAngleBox_TextChanged);
            // 
            // smallDivideAngleLabel
            // 
            this.smallDivideAngleLabel.AutoSize = true;
            this.smallDivideAngleLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.smallDivideAngleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.smallDivideAngleLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallDivideAngleLabel.Location = new System.Drawing.Point(146, 6);
            this.smallDivideAngleLabel.Name = "smallDivideAngleLabel";
            this.smallDivideAngleLabel.Size = new System.Drawing.Size(26, 14);
            this.smallDivideAngleLabel.TabIndex = 6;
            this.smallDivideAngleLabel.Text = "МДУ";
            this.smallDivideAngleLabel.Click += new System.EventHandler(this.SmallDivideAngleLabel_Click);
            // 
            // degriesRadio
            // 
            this.degriesRadio.AutoSize = true;
            this.degriesRadio.Checked = true;
            this.degriesRadio.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degriesRadio.Location = new System.Drawing.Point(16, 40);
            this.degriesRadio.Name = "degriesRadio";
            this.degriesRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.degriesRadio.Size = new System.Drawing.Size(61, 18);
            this.degriesRadio.TabIndex = 7;
            this.degriesRadio.TabStop = true;
            this.degriesRadio.Text = "Градусы";
            this.degriesRadio.UseVisualStyleBackColor = true;
            this.degriesRadio.CheckedChanged += new System.EventHandler(this.DegriesRadioBtn_CheckedChanged);
            // 
            // smallDivideAngelRadio
            // 
            this.smallDivideAngelRadio.AutoSize = true;
            this.smallDivideAngelRadio.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallDivideAngelRadio.Location = new System.Drawing.Point(16, 19);
            this.smallDivideAngelRadio.Name = "smallDivideAngelRadio";
            this.smallDivideAngelRadio.Size = new System.Drawing.Size(44, 18);
            this.smallDivideAngelRadio.TabIndex = 8;
            this.smallDivideAngelRadio.TabStop = true;
            this.smallDivideAngelRadio.Text = "МДУ";
            this.smallDivideAngelRadio.UseVisualStyleBackColor = true;
            this.smallDivideAngelRadio.CheckedChanged += new System.EventHandler(this.SmallDevideAngleBox_CheckedChanged);
            // 
            // radianRadio
            // 
            this.radianRadio.AutoSize = true;
            this.radianRadio.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radianRadio.Location = new System.Drawing.Point(16, 61);
            this.radianRadio.Name = "radianRadio";
            this.radianRadio.Size = new System.Drawing.Size(62, 18);
            this.radianRadio.TabIndex = 9;
            this.radianRadio.TabStop = true;
            this.radianRadio.Text = "Радианы";
            this.radianRadio.UseVisualStyleBackColor = true;
            this.radianRadio.CheckedChanged += new System.EventHandler(this.radianRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radianRadio);
            this.groupBox1.Controls.Add(this.smallDivideAngelRadio);
            this.groupBox1.Controls.Add(this.degriesRadio);
            this.groupBox1.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размерность";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // logBox
            // 
            this.logBox.AllowDrop = true;
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.SystemColors.Info;
            this.logBox.Font = new System.Drawing.Font("GOST type A", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 17;
            this.logBox.Location = new System.Drawing.Point(211, 26);
            this.logBox.Name = "logBox";
            this.logBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.logBox.Size = new System.Drawing.Size(261, 157);
            this.logBox.TabIndex = 11;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.logBox_SelectedIndexChanged);
            // 
            // distanceBox
            // 
            this.distanceBox.AcceptsTab = true;
            this.distanceBox.AccessibleName = "dist";
            this.distanceBox.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceBox.Location = new System.Drawing.Point(19, 141);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(63, 21);
            this.distanceBox.TabIndex = 12;
            this.distanceBox.TextChanged += new System.EventHandler(this.DistanceBox_TextChanged);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.distanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.distanceLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceLabel.Location = new System.Drawing.Point(16, 125);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(68, 14);
            this.distanceLabel.TabIndex = 13;
            this.distanceLabel.Text = "Дистанция, м";
            // 
            // LegLabel
            // 
            this.LegLabel.AutoSize = true;
            this.LegLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.LegLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LegLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegLabel.Location = new System.Drawing.Point(137, 125);
            this.LegLabel.Name = "LegLabel";
            this.LegLabel.Size = new System.Drawing.Size(49, 14);
            this.LegLabel.TabIndex = 15;
            this.LegLabel.Text = "Катет, м";
            this.LegLabel.Click += new System.EventHandler(this.LegLabel_Click);
            // 
            // legBox
            // 
            this.legBox.AcceptsTab = true;
            this.legBox.AccessibleName = "dist";
            this.legBox.Enabled = false;
            this.legBox.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legBox.Location = new System.Drawing.Point(130, 141);
            this.legBox.Name = "legBox";
            this.legBox.Size = new System.Drawing.Size(63, 21);
            this.legBox.TabIndex = 14;
            // 
            // heightBox
            // 
            this.heightBox.AcceptsTab = true;
            this.heightBox.AccessibleName = "dist";
            this.heightBox.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightBox.Location = new System.Drawing.Point(19, 181);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(63, 21);
            this.heightBox.TabIndex = 16;
            this.heightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.heightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.heightLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(24, 165);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(53, 14);
            this.heightLabel.TabIndex = 17;
            this.heightLabel.Text = "Высота, м";
            // 
            // angleBox
            // 
            this.angleBox.AcceptsTab = true;
            this.angleBox.AccessibleName = "dist";
            this.angleBox.Enabled = false;
            this.angleBox.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleBox.Location = new System.Drawing.Point(130, 181);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(63, 21);
            this.angleBox.TabIndex = 18;
            // 
            // angleFieldLabel
            // 
            this.angleFieldLabel.AutoSize = true;
            this.angleFieldLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.angleFieldLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.angleFieldLabel.Font = new System.Drawing.Font("GOST type A", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleFieldLabel.Location = new System.Drawing.Point(127, 165);
            this.angleFieldLabel.Name = "angleFieldLabel";
            this.angleFieldLabel.Size = new System.Drawing.Size(75, 14);
            this.angleFieldLabel.TabIndex = 19;
            this.angleFieldLabel.Text = "Простр. угол, ⁰";
            this.angleFieldLabel.Click += new System.EventHandler(this.AngleFieldLabel_Click);
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.angleFieldLabel);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.LegLabel);
            this.Controls.Add(this.legBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smallDivideAngleLabel);
            this.Controls.Add(this.smallDivideAngleBox);
            this.Controls.Add(this.degriesLabel);
            this.Controls.Add(this.degriesBox);
            this.Controls.Add(this.radianBox);
            this.Controls.Add(this.radianLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculate";
            this.Text = "Калькулятор углов";
            this.Load += new System.EventHandler(this.FormCalculate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radianLabel;
        private System.Windows.Forms.TextBox radianBox;
        private System.Windows.Forms.TextBox degriesBox;
        private System.Windows.Forms.Label degriesLabel;
        private System.Windows.Forms.TextBox smallDivideAngleBox;
        private System.Windows.Forms.Label smallDivideAngleLabel;
        private System.Windows.Forms.RadioButton degriesRadio;
        private System.Windows.Forms.RadioButton smallDivideAngelRadio;
        private System.Windows.Forms.RadioButton radianRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label LegLabel;
        private System.Windows.Forms.TextBox legBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.Label angleFieldLabel;
    }
}

