﻿namespace iLyncBookManage
{
    partial class frmBookDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.btnStartPhoto = new System.Windows.Forms.Button();
            this.btnCloseCamera = new System.Windows.Forms.Button();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBookTypeTwo = new System.Windows.Forms.ComboBox();
            this.cboBookTypeOne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBookPress = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStorageInNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblInventoryNum = new System.Windows.Forms.Label();
            this.lblBorrowedNum = new System.Windows.Forms.Label();
            this.lblStorageInDate = new System.Windows.Forms.Label();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(938, 3);
            this.label2.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "【Modify Press】";
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClearPhoto.FlatAppearance.BorderSize = 0;
            this.btnClearPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClearPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPhoto.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearPhoto.ForeColor = System.Drawing.Color.White;
            this.btnClearPhoto.Location = new System.Drawing.Point(692, 107);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(149, 33);
            this.btnClearPhoto.TabIndex = 58;
            this.btnClearPhoto.Text = "Clear Choice";
            this.btnClearPhoto.UseVisualStyleBackColor = false;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSelectPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectPhoto.FlatAppearance.BorderSize = 0;
            this.btnSelectPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPhoto.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSelectPhoto.Location = new System.Drawing.Point(693, 62);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(148, 33);
            this.btnSelectPhoto.TabIndex = 57;
            this.btnSelectPhoto.Text = "Choice Picture";
            this.btnSelectPhoto.UseVisualStyleBackColor = false;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // btnStartPhoto
            // 
            this.btnStartPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStartPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStartPhoto.FlatAppearance.BorderSize = 0;
            this.btnStartPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStartPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPhoto.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartPhoto.ForeColor = System.Drawing.Color.White;
            this.btnStartPhoto.Location = new System.Drawing.Point(693, 242);
            this.btnStartPhoto.Name = "btnStartPhoto";
            this.btnStartPhoto.Size = new System.Drawing.Size(148, 33);
            this.btnStartPhoto.TabIndex = 61;
            this.btnStartPhoto.Text = "Photograph";
            this.btnStartPhoto.UseVisualStyleBackColor = false;
            this.btnStartPhoto.Click += new System.EventHandler(this.btnStartPhoto_Click);
            // 
            // btnCloseCamera
            // 
            this.btnCloseCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCloseCamera.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCloseCamera.FlatAppearance.BorderSize = 0;
            this.btnCloseCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCloseCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCloseCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCamera.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseCamera.ForeColor = System.Drawing.Color.White;
            this.btnCloseCamera.Location = new System.Drawing.Point(693, 197);
            this.btnCloseCamera.Name = "btnCloseCamera";
            this.btnCloseCamera.Size = new System.Drawing.Size(148, 33);
            this.btnCloseCamera.TabIndex = 60;
            this.btnCloseCamera.Text = "Close the camera";
            this.btnCloseCamera.UseVisualStyleBackColor = false;
            this.btnCloseCamera.Click += new System.EventHandler(this.btnCloseCamera_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStartCamera.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStartCamera.FlatAppearance.BorderSize = 0;
            this.btnStartCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStartCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCamera.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCamera.ForeColor = System.Drawing.Color.White;
            this.btnStartCamera.Location = new System.Drawing.Point(693, 152);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(148, 33);
            this.btnStartCamera.TabIndex = 59;
            this.btnStartCamera.Text = "Start the camera";
            this.btnStartCamera.UseVisualStyleBackColor = false;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Navy;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(24, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(900, 3);
            this.label24.TabIndex = 64;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(24, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 3);
            this.label25.TabIndex = 63;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(20, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 19);
            this.label26.TabIndex = 62;
            this.label26.Text = "Book Picture：";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(24, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 3);
            this.label22.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Navy;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(24, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(900, 3);
            this.label16.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(20, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 19);
            this.label15.TabIndex = 76;
            this.label15.Text = "Core information：";
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookISBN.Location = new System.Drawing.Point(204, 345);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(150, 26);
            this.txtBookISBN.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(121, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "ISBN：";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookName.Location = new System.Drawing.Point(441, 345);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(402, 26);
            this.txtBookName.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(366, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Name：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(634, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Id：";
            // 
            // cboBookTypeTwo
            // 
            this.cboBookTypeTwo.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBookTypeTwo.FormattingEnabled = true;
            this.cboBookTypeTwo.Location = new System.Drawing.Point(372, 311);
            this.cboBookTypeTwo.Name = "cboBookTypeTwo";
            this.cboBookTypeTwo.Size = new System.Drawing.Size(224, 27);
            this.cboBookTypeTwo.TabIndex = 68;
            this.cboBookTypeTwo.Text = "Please select subcategories";
            this.cboBookTypeTwo.SelectedValueChanged += new System.EventHandler(this.cboBookTypeTwo_SelectedValueChanged);
            // 
            // cboBookTypeOne
            // 
            this.cboBookTypeOne.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBookTypeOne.FormattingEnabled = true;
            this.cboBookTypeOne.Location = new System.Drawing.Point(204, 311);
            this.cboBookTypeOne.Name = "cboBookTypeOne";
            this.cboBookTypeOne.Size = new System.Drawing.Size(162, 27);
            this.cboBookTypeOne.TabIndex = 67;
            this.cboBookTypeOne.Text = "Please select the book category.";
            this.cboBookTypeOne.SelectedValueChanged += new System.EventHandler(this.cboBookTypeOne_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Btype：";
            // 
            // cboBookPress
            // 
            this.cboBookPress.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBookPress.FormattingEnabled = true;
            this.cboBookPress.Location = new System.Drawing.Point(204, 430);
            this.cboBookPress.Name = "cboBookPress";
            this.cboBookPress.Size = new System.Drawing.Size(243, 27);
            this.cboBookPress.TabIndex = 80;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Navy;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(24, 470);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(900, 3);
            this.label23.TabIndex = 100;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Navy;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(24, 382);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(900, 3);
            this.label21.TabIndex = 99;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(25, 498);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 3);
            this.label19.TabIndex = 98;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(12, 473);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 19);
            this.label20.TabIndex = 97;
            this.label20.Text = "Inventory statistics:";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(24, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 3);
            this.label17.TabIndex = 96;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(12, 385);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 19);
            this.label18.TabIndex = 95;
            this.label18.Text = "Basic Information：";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishDate.Location = new System.Drawing.Point(638, 434);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(203, 26);
            this.dtpPublishDate.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(128, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 93;
            this.label13.Text = "Storage time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(521, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 94;
            this.label10.Text = "Publish Date：";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookPrice.Location = new System.Drawing.Point(638, 394);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(205, 26);
            this.txtBookPrice.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(575, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 92;
            this.label9.Text = "Price：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(137, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "Press：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(634, 491);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 19);
            this.label14.TabIndex = 89;
            this.label14.Text = "The number of times borrowed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(360, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 19);
            this.label12.TabIndex = 88;
            this.label12.Text = "Current inventory:";
            // 
            // txtStorageInNum
            // 
            this.txtStorageInNum.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStorageInNum.Location = new System.Drawing.Point(257, 491);
            this.txtStorageInNum.Name = "txtStorageInNum";
            this.txtStorageInNum.Size = new System.Drawing.Size(90, 26);
            this.txtStorageInNum.TabIndex = 83;
            this.txtStorageInNum.TextChanged += new System.EventHandler(this.txtStorageInNum_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(128, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 87;
            this.label11.Text = "Storage volume:";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookAuthor.Location = new System.Drawing.Point(213, 399);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(354, 26);
            this.txtBookAuthor.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(149, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 90;
            this.label7.Text = "Author：";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(938, 3);
            this.label3.TabIndex = 101;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(818, 578);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 33);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(675, 578);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(106, 33);
            this.btnCommit.TabIndex = 102;
            this.btnCommit.Text = "Submit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBookId.Location = new System.Drawing.Point(683, 307);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(158, 31);
            this.lblBookId.TabIndex = 104;
            this.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventoryNum
            // 
            this.lblInventoryNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInventoryNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInventoryNum.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInventoryNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInventoryNum.Location = new System.Drawing.Point(503, 486);
            this.lblInventoryNum.Name = "lblInventoryNum";
            this.lblInventoryNum.Size = new System.Drawing.Size(101, 31);
            this.lblInventoryNum.TabIndex = 105;
            this.lblInventoryNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedNum
            // 
            this.lblBorrowedNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBorrowedNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorrowedNum.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBorrowedNum.Location = new System.Drawing.Point(708, 522);
            this.lblBorrowedNum.Name = "lblBorrowedNum";
            this.lblBorrowedNum.Size = new System.Drawing.Size(158, 31);
            this.lblBorrowedNum.TabIndex = 106;
            this.lblBorrowedNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorageInDate
            // 
            this.lblStorageInDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStorageInDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStorageInDate.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStorageInDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStorageInDate.Location = new System.Drawing.Point(248, 528);
            this.lblStorageInDate.Name = "lblStorageInDate";
            this.lblStorageInDate.Size = new System.Drawing.Size(249, 31);
            this.lblStorageInDate.TabIndex = 107;
            this.lblStorageInDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCurrentImage.Location = new System.Drawing.Point(204, 61);
            this.pbCurrentImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(181, 221);
            this.pbCurrentImage.TabIndex = 66;
            this.pbCurrentImage.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(454, 61);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(186, 221);
            this.pbImage.TabIndex = 65;
            this.pbImage.TabStop = false;
            // 
            // frmBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(944, 623);
            this.Controls.Add(this.lblStorageInDate);
            this.Controls.Add(this.lblBorrowedNum);
            this.Controls.Add(this.lblInventoryNum);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBookPress);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStorageInNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBookTypeTwo);
            this.Controls.Add(this.cboBookTypeOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.btnStartPhoto);
            this.Controls.Add(this.btnCloseCamera);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnStartPhoto;
        private System.Windows.Forms.Button btnCloseCamera;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBookTypeTwo;
        private System.Windows.Forms.ComboBox cboBookTypeOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBookPress;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStorageInNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblInventoryNum;
        private System.Windows.Forms.Label lblBorrowedNum;
        private System.Windows.Forms.Label lblStorageInDate;
    }
}