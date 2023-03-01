namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Percent = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Equality = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.DarkBackground = new System.Windows.Forms.RadioButton();
            this.LightBackground = new System.Windows.Forms.RadioButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Percent
            // 
            this.Percent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Percent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Percent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Percent.Location = new System.Drawing.Point(182, 117);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(80, 80);
            this.Percent.TabIndex = 13;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // CE
            // 
            this.CE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(96, 117);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(80, 80);
            this.CE.TabIndex = 12;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(10, 117);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 80);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Division
            // 
            this.Division.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Division.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(268, 117);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(80, 80);
            this.Division.TabIndex = 17;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Multiplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplication.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplication.Location = new System.Drawing.Point(268, 203);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(80, 80);
            this.Multiplication.TabIndex = 16;
            this.Multiplication.Text = "×";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Subtraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtraction.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtraction.Location = new System.Drawing.Point(268, 289);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(80, 80);
            this.Subtraction.TabIndex = 15;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Addition
            // 
            this.Addition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Addition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addition.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addition.Location = new System.Drawing.Point(268, 375);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(80, 80);
            this.Addition.TabIndex = 14;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Equality
            // 
            this.Equality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Equality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Equality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equality.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equality.Location = new System.Drawing.Point(266, 470);
            this.Equality.Name = "Equality";
            this.Equality.Size = new System.Drawing.Size(80, 80);
            this.Equality.TabIndex = 18;
            this.Equality.Text = "=";
            this.Equality.UseVisualStyleBackColor = false;
            this.Equality.Click += new System.EventHandler(this.Equality_Click);
            // 
            // Label
            // 
            this.Label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(10, 40);
            this.Label.MaximumSize = new System.Drawing.Size(340, 50);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(340, 50);
            this.Label.TabIndex = 20;
            this.Label.Text = "0";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label.Click += new System.EventHandler(this.Label_Click);
            this.Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            // 
            // DarkBackground
            // 
            this.DarkBackground.AutoSize = true;
            this.DarkBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkBackground.Location = new System.Drawing.Point(10, 12);
            this.DarkBackground.Name = "DarkBackground";
            this.DarkBackground.Size = new System.Drawing.Size(49, 20);
            this.DarkBackground.TabIndex = 21;
            this.DarkBackground.Text = "Dark";
            this.DarkBackground.UseVisualStyleBackColor = true;
            this.DarkBackground.Click += new System.EventHandler(this.DarkBackground_Click);
            // 
            // LightBackground
            // 
            this.LightBackground.AutoSize = true;
            this.LightBackground.Checked = true;
            this.LightBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LightBackground.Location = new System.Drawing.Point(66, 12);
            this.LightBackground.Name = "LightBackground";
            this.LightBackground.Size = new System.Drawing.Size(50, 20);
            this.LightBackground.TabIndex = 22;
            this.LightBackground.TabStop = true;
            this.LightBackground.Text = "Light";
            this.LightBackground.UseVisualStyleBackColor = true;
            this.LightBackground.Click += new System.EventHandler(this.LightBackground_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(0, 90);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(375, 475);
            this.Panel.TabIndex = 23;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.LightBackground);
            this.Panel2.Controls.Add(this.DarkBackground);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(375, 90);
            this.Panel2.TabIndex = 24;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ZeroButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZeroButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroButton.Location = new System.Drawing.Point(10, 470);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(166, 80);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OneButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.Location = new System.Drawing.Point(10, 375);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(80, 80);
            this.OneButton.TabIndex = 2;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TwoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TwoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TwoButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.Location = new System.Drawing.Point(96, 375);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(80, 80);
            this.TwoButton.TabIndex = 3;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ThreeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThreeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.Location = new System.Drawing.Point(182, 375);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(80, 80);
            this.ThreeButton.TabIndex = 4;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FourButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FourButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.Location = new System.Drawing.Point(10, 289);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(80, 80);
            this.FourButton.TabIndex = 5;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FiveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiveButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.Location = new System.Drawing.Point(96, 289);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 80);
            this.FiveButton.TabIndex = 6;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SixButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SixButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.Location = new System.Drawing.Point(182, 289);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(80, 80);
            this.SixButton.TabIndex = 7;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SevenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SevenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SevenButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.Location = new System.Drawing.Point(10, 203);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(80, 80);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EightButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.Location = new System.Drawing.Point(96, 203);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(80, 80);
            this.EightButton.TabIndex = 9;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NineButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NineButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.Location = new System.Drawing.Point(182, 203);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(80, 80);
            this.NineButton.TabIndex = 10;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // Point
            // 
            this.Point.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Point.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Point.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point.Location = new System.Drawing.Point(182, 470);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(80, 80);
            this.Point.TabIndex = 19;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(360, 557);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Equality);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 600);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Equality;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RadioButton DarkBackground;
        private System.Windows.Forms.RadioButton LightBackground;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

