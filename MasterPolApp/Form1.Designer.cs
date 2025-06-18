namespace MasterPolApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePartners = new System.Windows.Forms.TabPage();
            this.buttonDeletePartner = new System.Windows.Forms.Button();
            this.dataGridViewPartners = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshPartners = new System.Windows.Forms.Button();
            this.buttonGoToAddPartner = new System.Windows.Forms.Button();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.comboBoxHistory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAddPartner = new System.Windows.Forms.TabPage();
            this.tabPageUpdatePartner = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAddPartnerName = new System.Windows.Forms.TextBox();
            this.textBoxAddPertnerDirector = new System.Windows.Forms.TextBox();
            this.textBoxAddPartnerEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddParentAddress = new System.Windows.Forms.TextBox();
            this.textBoxAddPartnerINN = new System.Windows.Forms.TextBox();
            this.textBoxAddPartnerPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddPartnerRating = new System.Windows.Forms.TextBox();
            this.buttonAddPartner = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPagePartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.tabPageAddPartner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePartners);
            this.tabControlMain.Controls.Add(this.tabPageHistory);
            this.tabControlMain.Controls.Add(this.tabPageAddPartner);
            this.tabControlMain.Controls.Add(this.tabPageUpdatePartner);
            this.tabControlMain.Location = new System.Drawing.Point(3, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1029, 547);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
           

            // 
            // tabPagePartners
            // 
            this.tabPagePartners.Controls.Add(this.buttonDeletePartner);
            this.tabPagePartners.Controls.Add(this.dataGridViewPartners);
            this.tabPagePartners.Controls.Add(this.pictureBox1);
            this.tabPagePartners.Controls.Add(this.label1);
            this.tabPagePartners.Controls.Add(this.buttonRefreshPartners);
            this.tabPagePartners.Controls.Add(this.buttonGoToAddPartner);
            this.tabPagePartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPagePartners.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartners.Name = "tabPagePartners";
            this.tabPagePartners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePartners.Size = new System.Drawing.Size(1021, 521);
            this.tabPagePartners.TabIndex = 0;
            this.tabPagePartners.Text = "Партнеры";
            this.tabPagePartners.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePartner
            // 
            this.buttonDeletePartner.Location = new System.Drawing.Point(909, 42);
            this.buttonDeletePartner.Name = "buttonDeletePartner";
            this.buttonDeletePartner.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePartner.TabIndex = 5;
            this.buttonDeletePartner.Text = "Удалить";
            this.buttonDeletePartner.UseVisualStyleBackColor = true;
            this.buttonDeletePartner.Click += new System.EventHandler(this.buttonDeletePartner_Click);
            // 
            // dataGridViewPartners
            // 
            this.dataGridViewPartners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.dataGridViewPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartners.Location = new System.Drawing.Point(3, 71);
            this.dataGridViewPartners.Name = "dataGridViewPartners";
            this.dataGridViewPartners.Size = new System.Drawing.Size(1015, 444);
            this.dataGridViewPartners.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MasterPolApp.Properties.Resources.Мастер_пол3;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мастер пол партнеры";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRefreshPartners
            // 
            this.buttonRefreshPartners.Location = new System.Drawing.Point(827, 42);
            this.buttonRefreshPartners.Name = "buttonRefreshPartners";
            this.buttonRefreshPartners.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshPartners.TabIndex = 1;
            this.buttonRefreshPartners.Text = "Обновить";
            this.buttonRefreshPartners.UseVisualStyleBackColor = true;
            this.buttonRefreshPartners.Click += new System.EventHandler(this.buttonRefreshPartners_Click);
            // 
            // buttonGoToAddPartner
            // 
            this.buttonGoToAddPartner.Location = new System.Drawing.Point(734, 42);
            this.buttonGoToAddPartner.Name = "buttonGoToAddPartner";
            this.buttonGoToAddPartner.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToAddPartner.TabIndex = 0;
            this.buttonGoToAddPartner.Text = "Добавить";
            this.buttonGoToAddPartner.UseVisualStyleBackColor = true;
            this.buttonGoToAddPartner.Click += new System.EventHandler(this.buttonGoToAddPartner_Click);
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.dataGridViewHistory);
            this.tabPageHistory.Controls.Add(this.comboBoxHistory);
            this.tabPageHistory.Controls.Add(this.label3);
            this.tabPageHistory.Controls.Add(this.label2);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(1021, 521);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "История продаж";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            this.tabPageHistory.Click += new System.EventHandler(this.tabPageHistory_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(6, 75);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.Size = new System.Drawing.Size(1008, 435);
            this.dataGridViewHistory.TabIndex = 3;
            // 
            // comboBoxHistory
            // 
            this.comboBoxHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHistory.FormattingEnabled = true;
            this.comboBoxHistory.Location = new System.Drawing.Point(580, 30);
            this.comboBoxHistory.Name = "comboBoxHistory";
            this.comboBoxHistory.Size = new System.Drawing.Size(316, 25);
            this.comboBoxHistory.TabIndex = 2;
            this.comboBoxHistory.SelectedIndexChanged += comboBoxHistory_SelectedIndexChanged;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(496, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Партнер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(65, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Мастер Пол История Продаж";
            // 
            // tabPageAddPartner
            // 
            this.tabPageAddPartner.Controls.Add(this.buttonAddPartner);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPartnerRating);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPartnerPhone);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPartnerINN);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddParentAddress);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPartnerEmail);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPertnerDirector);
            this.tabPageAddPartner.Controls.Add(this.textBoxAddPartnerName);
            this.tabPageAddPartner.Controls.Add(this.label12);
            this.tabPageAddPartner.Controls.Add(this.label11);
            this.tabPageAddPartner.Controls.Add(this.label10);
            this.tabPageAddPartner.Controls.Add(this.label9);
            this.tabPageAddPartner.Controls.Add(this.label8);
            this.tabPageAddPartner.Controls.Add(this.label7);
            this.tabPageAddPartner.Controls.Add(this.label5);
            this.tabPageAddPartner.Controls.Add(this.label4);
            this.tabPageAddPartner.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddPartner.Name = "tabPageAddPartner";
            this.tabPageAddPartner.Size = new System.Drawing.Size(1021, 521);
            this.tabPageAddPartner.TabIndex = 2;
            this.tabPageAddPartner.Text = "Добавление партнера";
            this.tabPageAddPartner.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdatePartner
            // 
            this.tabPageUpdatePartner.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdatePartner.Name = "tabPageUpdatePartner";
            this.tabPageUpdatePartner.Size = new System.Drawing.Size(1021, 521);
            this.tabPageUpdatePartner.TabIndex = 3;
            this.tabPageUpdatePartner.Text = "Редактирование партнера";
            this.tabPageUpdatePartner.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(65, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление партнера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(74, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название партнера:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(124, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Директор:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(148, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(144, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Адрес:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(150, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "ИНН:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(129, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Телефон:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(133, 287);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Рейтинг:";
            // 
            // textBoxAddPartnerName
            // 
            this.textBoxAddPartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPartnerName.Location = new System.Drawing.Point(208, 96);
            this.textBoxAddPartnerName.Name = "textBoxAddPartnerName";
            this.textBoxAddPartnerName.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPartnerName.TabIndex = 9;
            // 
            // textBoxAddPertnerDirector
            // 
            this.textBoxAddPertnerDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPertnerDirector.Location = new System.Drawing.Point(205, 127);
            this.textBoxAddPertnerDirector.Name = "textBoxAddPertnerDirector";
            this.textBoxAddPertnerDirector.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPertnerDirector.TabIndex = 11;
            // 
            // textBoxAddPartnerEmail
            // 
            this.textBoxAddPartnerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPartnerEmail.Location = new System.Drawing.Point(205, 159);
            this.textBoxAddPartnerEmail.Name = "textBoxAddPartnerEmail";
            this.textBoxAddPartnerEmail.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPartnerEmail.TabIndex = 12;
            // 
            // textBoxAddParentAddress
            // 
            this.textBoxAddParentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddParentAddress.Location = new System.Drawing.Point(205, 191);
            this.textBoxAddParentAddress.Name = "textBoxAddParentAddress";
            this.textBoxAddParentAddress.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddParentAddress.TabIndex = 13;
            // 
            // textBoxAddPartnerINN
            // 
            this.textBoxAddPartnerINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPartnerINN.Location = new System.Drawing.Point(205, 223);
            this.textBoxAddPartnerINN.Name = "textBoxAddPartnerINN";
            this.textBoxAddPartnerINN.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPartnerINN.TabIndex = 14;
            // 
            // textBoxAddPartnerPhone
            // 
            this.textBoxAddPartnerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPartnerPhone.Location = new System.Drawing.Point(205, 255);
            this.textBoxAddPartnerPhone.Name = "textBoxAddPartnerPhone";
            this.textBoxAddPartnerPhone.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPartnerPhone.TabIndex = 15;
            // 
            // textBoxAddPartnerRating
            // 
            this.textBoxAddPartnerRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddPartnerRating.Location = new System.Drawing.Point(205, 287);
            this.textBoxAddPartnerRating.Name = "textBoxAddPartnerRating";
            this.textBoxAddPartnerRating.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddPartnerRating.TabIndex = 16;
            // 
            // buttonAddPartner
            // 
            this.buttonAddPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.buttonAddPartner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPartner.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddPartner.Location = new System.Drawing.Point(205, 328);
            this.buttonAddPartner.Name = "buttonAddPartner";
            this.buttonAddPartner.Size = new System.Drawing.Size(111, 32);
            this.buttonAddPartner.TabIndex = 17;
            this.buttonAddPartner.Text = "Добавить";
            this.buttonAddPartner.UseVisualStyleBackColor = false;
            this.buttonAddPartner.Click += new System.EventHandler(this.buttonAddPartner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 547);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Мастер пол";
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePartners.ResumeLayout(false);
            this.tabPagePartners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageHistory.ResumeLayout(false);
            this.tabPageHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.tabPageAddPartner.ResumeLayout(false);
            this.tabPageAddPartner.PerformLayout();
            this.ResumeLayout(false);

          


        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPagePartners;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Button buttonGoToAddPartner;
        private System.Windows.Forms.TabPage tabPageAddPartner;
        private System.Windows.Forms.TabPage tabPageUpdatePartner;
        private System.Windows.Forms.Button buttonRefreshPartners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPartners;
        private System.Windows.Forms.Button buttonDeletePartner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.ComboBox comboBoxHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddPartnerRating;
        private System.Windows.Forms.TextBox textBoxAddPartnerPhone;
        private System.Windows.Forms.TextBox textBoxAddPartnerINN;
        private System.Windows.Forms.TextBox textBoxAddParentAddress;
        private System.Windows.Forms.TextBox textBoxAddPartnerEmail;
        private System.Windows.Forms.TextBox textBoxAddPertnerDirector;
        private System.Windows.Forms.TextBox textBoxAddPartnerName;
        private System.Windows.Forms.Button buttonAddPartner;
    }
}

