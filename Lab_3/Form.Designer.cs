namespace Lab_3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cityLabel = new System.Windows.Forms.Label();
            this.citySelected = new System.Windows.Forms.ComboBox();
            this.universGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.cityyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.univerPic = new System.Windows.Forms.PictureBox();
            this.строкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addInfolabel = new System.Windows.Forms.Label();
            this.newNameField = new System.Windows.Forms.TextBox();
            this.newCityField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPicBtn = new System.Windows.Forms.Button();
            this.imageField = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chanPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.OK2btn = new System.Windows.Forms.Button();
            this.chanImageField = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chanCityLabel = new System.Windows.Forms.Label();
            this.chanNameLabel = new System.Windows.Forms.Label();
            this.chanCityField = new System.Windows.Forms.TextBox();
            this.chanNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chanUniverPic = new System.Windows.Forms.PictureBox();
            this.imagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.univerPic)).BeginInit();
            this.addPanel.SuspendLayout();
            this.chanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chanUniverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.citySelected);
            this.splitContainer1.Panel1.Controls.Add(this.universGridView);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addPanel);
            this.splitContainer1.Panel2.Controls.Add(this.cityField);
            this.splitContainer1.Panel2.Controls.Add(this.nameField);
            this.splitContainer1.Panel2.Controls.Add(this.cityyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.univerPic);
            this.splitContainer1.Panel2.Controls.Add(this.imagePath);
            this.splitContainer1.Size = new System.Drawing.Size(1268, 636);
            this.splitContainer1.SplitterDistance = 824;
            this.splitContainer1.TabIndex = 0;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.cityLabel.Location = new System.Drawing.Point(27, 50);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(56, 18);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "Город:";
            // 
            // citySelected
            // 
            this.citySelected.FormattingEnabled = true;
            this.citySelected.Location = new System.Drawing.Point(98, 49);
            this.citySelected.Name = "citySelected";
            this.citySelected.Size = new System.Drawing.Size(213, 24);
            this.citySelected.TabIndex = 5;
            // 
            // universGridView
            // 
            this.universGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.universGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.universGridView.Location = new System.Drawing.Point(0, 79);
            this.universGridView.Name = "universGridView";
            this.universGridView.RowHeadersWidth = 51;
            this.universGridView.RowTemplate.Height = 24;
            this.universGridView.Size = new System.Drawing.Size(824, 557);
            this.universGridView.TabIndex = 0;
            this.universGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.universGridView_CellContentDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выйтиToolStripMenuItem,
            this.справкаОПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкуToolStripMenuItem1});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкуToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // справкаОПрограммеToolStripMenuItem
            // 
            this.справкаОПрограммеToolStripMenuItem.Name = "справкаОПрограммеToolStripMenuItem";
            this.справкаОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.справкаОПрограммеToolStripMenuItem.Text = "Справка (О программе)";
            this.справкаОПрограммеToolStripMenuItem.Click += new System.EventHandler(this.справкаОПрограммеToolStripMenuItem_Click);
            // 
            // cityField
            // 
            this.cityField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.cityField.Location = new System.Drawing.Point(168, 171);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(212, 24);
            this.cityField.TabIndex = 6;
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.nameField.Location = new System.Drawing.Point(168, 112);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(212, 24);
            this.nameField.TabIndex = 5;
            // 
            // cityyLabel
            // 
            this.cityyLabel.AutoSize = true;
            this.cityyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.cityyLabel.Location = new System.Drawing.Point(78, 171);
            this.cityyLabel.Name = "cityyLabel";
            this.cityyLabel.Size = new System.Drawing.Size(66, 20);
            this.cityyLabel.TabIndex = 4;
            this.cityyLabel.Text = "Город:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.nameLabel.Location = new System.Drawing.Point(48, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название:";
            // 
            // univerPic
            // 
            this.univerPic.Location = new System.Drawing.Point(146, 274);
            this.univerPic.Name = "univerPic";
            this.univerPic.Size = new System.Drawing.Size(158, 158);
            this.univerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.univerPic.TabIndex = 0;
            this.univerPic.TabStop = false;
            // 
            // строкуToolStripMenuItem
            // 
            this.строкуToolStripMenuItem.Name = "строкуToolStripMenuItem";
            this.строкуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.строкуToolStripMenuItem.Text = "Строку";
            this.строкуToolStripMenuItem.Click += new System.EventHandler(this.строкуToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // строкуToolStripMenuItem1
            // 
            this.строкуToolStripMenuItem1.Name = "строкуToolStripMenuItem1";
            this.строкуToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.строкуToolStripMenuItem1.Text = "Строку";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.chanPanel);
            this.addPanel.Controls.Add(this.button1);
            this.addPanel.Controls.Add(this.OKbtn);
            this.addPanel.Controls.Add(this.imageField);
            this.addPanel.Controls.Add(this.addPicBtn);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.newCityField);
            this.addPanel.Controls.Add(this.newNameField);
            this.addPanel.Controls.Add(this.addInfolabel);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(440, 636);
            this.addPanel.TabIndex = 7;
            this.addPanel.Visible = false;
            // 
            // addInfolabel
            // 
            this.addInfolabel.AutoSize = true;
            this.addInfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInfolabel.Location = new System.Drawing.Point(113, 106);
            this.addInfolabel.Name = "addInfolabel";
            this.addInfolabel.Size = new System.Drawing.Size(210, 36);
            this.addInfolabel.TabIndex = 0;
            this.addInfolabel.Text = "Новая строка";
            // 
            // newNameField
            // 
            this.newNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.newNameField.Location = new System.Drawing.Point(146, 204);
            this.newNameField.Name = "newNameField";
            this.newNameField.Size = new System.Drawing.Size(212, 26);
            this.newNameField.TabIndex = 1;
            this.newNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newNameField_KeyPress);
            // 
            // newCityField
            // 
            this.newCityField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.newCityField.Location = new System.Drawing.Point(146, 271);
            this.newCityField.Name = "newCityField";
            this.newCityField.Size = new System.Drawing.Size(212, 26);
            this.newCityField.TabIndex = 2;
            this.newCityField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newCityField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(44, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(74, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город:";
            // 
            // addPicBtn
            // 
            this.addPicBtn.Location = new System.Drawing.Point(26, 382);
            this.addPicBtn.Name = "addPicBtn";
            this.addPicBtn.Size = new System.Drawing.Size(172, 38);
            this.addPicBtn.TabIndex = 5;
            this.addPicBtn.Text = "Добавить изображение";
            this.addPicBtn.UseVisualStyleBackColor = true;
            this.addPicBtn.Click += new System.EventHandler(this.addPicBtn_Click);
            // 
            // imageField
            // 
            this.imageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.imageField.Location = new System.Drawing.Point(216, 391);
            this.imageField.Name = "imageField";
            this.imageField.Size = new System.Drawing.Size(212, 22);
            this.imageField.TabIndex = 6;
            // 
            // OKbtn
            // 
            this.OKbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.OKbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OKbtn.Location = new System.Drawing.Point(78, 532);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(120, 45);
            this.OKbtn.TabIndex = 7;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = false;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(248, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chanPanel
            // 
            this.chanPanel.Controls.Add(this.chanNameField);
            this.chanPanel.Controls.Add(this.chanNameLabel);
            this.chanPanel.Controls.Add(this.closeBtn);
            this.chanPanel.Controls.Add(this.OK2btn);
            this.chanPanel.Controls.Add(this.chanImageField);
            this.chanPanel.Controls.Add(this.button4);
            this.chanPanel.Controls.Add(this.chanCityLabel);
            this.chanPanel.Controls.Add(this.chanCityField);
            this.chanPanel.Controls.Add(this.label5);
            this.chanPanel.Controls.Add(this.chanUniverPic);
            this.chanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chanPanel.Location = new System.Drawing.Point(0, 0);
            this.chanPanel.Name = "chanPanel";
            this.chanPanel.Size = new System.Drawing.Size(440, 636);
            this.chanPanel.TabIndex = 9;
            this.chanPanel.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(248, 532);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 45);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // OK2btn
            // 
            this.OK2btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.OK2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.OK2btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OK2btn.Location = new System.Drawing.Point(78, 532);
            this.OK2btn.Name = "OK2btn";
            this.OK2btn.Size = new System.Drawing.Size(120, 45);
            this.OK2btn.TabIndex = 16;
            this.OK2btn.Text = "OK";
            this.OK2btn.UseVisualStyleBackColor = false;
            this.OK2btn.Click += new System.EventHandler(this.OK2btn_Click);
            // 
            // chanImageField
            // 
            this.chanImageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chanImageField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chanImageField.Location = new System.Drawing.Point(216, 452);
            this.chanImageField.Name = "chanImageField";
            this.chanImageField.Size = new System.Drawing.Size(212, 22);
            this.chanImageField.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Добавить изображение";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chanCityLabel
            // 
            this.chanCityLabel.AutoSize = true;
            this.chanCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chanCityLabel.Location = new System.Drawing.Point(74, 231);
            this.chanCityLabel.Name = "chanCityLabel";
            this.chanCityLabel.Size = new System.Drawing.Size(66, 20);
            this.chanCityLabel.TabIndex = 13;
            this.chanCityLabel.Text = "Город:";
            // 
            // chanNameLabel
            // 
            this.chanNameLabel.AutoSize = true;
            this.chanNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chanNameLabel.Location = new System.Drawing.Point(44, 164);
            this.chanNameLabel.Name = "chanNameLabel";
            this.chanNameLabel.Size = new System.Drawing.Size(96, 20);
            this.chanNameLabel.TabIndex = 12;
            this.chanNameLabel.Text = "Название:";
            // 
            // chanCityField
            // 
            this.chanCityField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chanCityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chanCityField.Location = new System.Drawing.Point(146, 229);
            this.chanCityField.Name = "chanCityField";
            this.chanCityField.Size = new System.Drawing.Size(212, 26);
            this.chanCityField.TabIndex = 11;
            // 
            // chanNameField
            // 
            this.chanNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chanNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chanNameField.Location = new System.Drawing.Point(146, 162);
            this.chanNameField.Name = "chanNameField";
            this.chanNameField.Size = new System.Drawing.Size(212, 26);
            this.chanNameField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Изменение строки";
            // 
            // chanUniverPic
            // 
            this.chanUniverPic.Location = new System.Drawing.Point(168, 300);
            this.chanUniverPic.Name = "chanUniverPic";
            this.chanUniverPic.Size = new System.Drawing.Size(120, 120);
            this.chanUniverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chanUniverPic.TabIndex = 18;
            this.chanUniverPic.TabStop = false;
            // 
            // imagePath
            // 
            this.imagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.imagePath.Location = new System.Drawing.Point(123, 495);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(212, 22);
            this.imagePath.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 636);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Универститеты";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.universGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.univerPic)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.chanPanel.ResumeLayout(false);
            this.chanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chanUniverPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView universGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаОПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label cityyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox univerPic;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox citySelected;
        private System.Windows.Forms.ToolStripMenuItem строкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкуToolStripMenuItem1;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label addInfolabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newCityField;
        private System.Windows.Forms.TextBox newNameField;
        private System.Windows.Forms.TextBox imageField;
        private System.Windows.Forms.Button addPicBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Panel chanPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button OK2btn;
        private System.Windows.Forms.TextBox chanImageField;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label chanCityLabel;
        private System.Windows.Forms.Label chanNameLabel;
        private System.Windows.Forms.TextBox chanCityField;
        private System.Windows.Forms.TextBox chanNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox chanUniverPic;
        private System.Windows.Forms.TextBox imagePath;
    }
}

