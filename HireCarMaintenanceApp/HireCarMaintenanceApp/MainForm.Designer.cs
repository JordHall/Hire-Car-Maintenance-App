namespace HireCarMaintenanceApp
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lstCompany = new System.Windows.Forms.ListBox();
            this.lstCar = new System.Windows.Forms.ListBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtSearchComp = new System.Windows.Forms.TextBox();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.lblSearchComp = new System.Windows.Forms.Label();
            this.lblSearchCar = new System.Windows.Forms.Label();
            this.btnSearchComp = new System.Windows.Forms.Button();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(712, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hire Car Maintenance Management System";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(38, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(38, 111);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(159, 40);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Import Data";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lstCompany
            // 
            this.lstCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompany.FormattingEnabled = true;
            this.lstCompany.ItemHeight = 16;
            this.lstCompany.Location = new System.Drawing.Point(236, 149);
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.Size = new System.Drawing.Size(900, 148);
            this.lstCompany.TabIndex = 3;
            this.lstCompany.SelectedIndexChanged += new System.EventHandler(this.lstCompany_SelectedIndexChanged);
            // 
            // lstCar
            // 
            this.lstCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCar.FormattingEnabled = true;
            this.lstCar.ItemHeight = 16;
            this.lstCar.Location = new System.Drawing.Point(236, 341);
            this.lstCar.Name = "lstCar";
            this.lstCar.Size = new System.Drawing.Size(900, 164);
            this.lstCar.TabIndex = 4;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(232, 120);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(115, 24);
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "Companies";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(232, 311);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(52, 24);
            this.lblCar.TabIndex = 6;
            this.lblCar.Text = "Cars";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompany.Location = new System.Drawing.Point(38, 181);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(159, 40);
            this.btnAddCompany.TabIndex = 7;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompany.Location = new System.Drawing.Point(38, 251);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(159, 40);
            this.btnEditCompany.TabIndex = 8;
            this.btnEditCompany.Text = "Edit Company";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(38, 321);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(159, 40);
            this.btnAddCar.TabIndex = 9;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(38, 391);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(159, 40);
            this.btnEditCar.TabIndex = 10;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(38, 461);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(159, 40);
            this.btnDeleteCar.TabIndex = 11;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtSearchComp
            // 
            this.txtSearchComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchComp.Location = new System.Drawing.Point(900, 118);
            this.txtSearchComp.Name = "txtSearchComp";
            this.txtSearchComp.Size = new System.Drawing.Size(184, 26);
            this.txtSearchComp.TabIndex = 12;
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCar.Location = new System.Drawing.Point(900, 309);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(184, 26);
            this.txtSearchCar.TabIndex = 13;
            // 
            // lblSearchComp
            // 
            this.lblSearchComp.AutoSize = true;
            this.lblSearchComp.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchComp.Location = new System.Drawing.Point(819, 118);
            this.lblSearchComp.Name = "lblSearchComp";
            this.lblSearchComp.Size = new System.Drawing.Size(75, 24);
            this.lblSearchComp.TabIndex = 14;
            this.lblSearchComp.Text = "Search";
            // 
            // lblSearchCar
            // 
            this.lblSearchCar.AutoSize = true;
            this.lblSearchCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCar.Location = new System.Drawing.Point(819, 311);
            this.lblSearchCar.Name = "lblSearchCar";
            this.lblSearchCar.Size = new System.Drawing.Size(75, 24);
            this.lblSearchCar.TabIndex = 15;
            this.lblSearchCar.Text = "Search";
            // 
            // btnSearchComp
            // 
            this.btnSearchComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchComp.Location = new System.Drawing.Point(1090, 118);
            this.btnSearchComp.Name = "btnSearchComp";
            this.btnSearchComp.Size = new System.Drawing.Size(46, 26);
            this.btnSearchComp.TabIndex = 16;
            this.btnSearchComp.Text = "Go";
            this.btnSearchComp.UseVisualStyleBackColor = true;
            this.btnSearchComp.Click += new System.EventHandler(this.btnSearchComp_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCar.Location = new System.Drawing.Point(1090, 309);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(46, 26);
            this.btnSearchCar.TabIndex = 17;
            this.btnSearchCar.Text = "Go";
            this.btnSearchCar.UseVisualStyleBackColor = true;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnSearchCar);
            this.Controls.Add(this.btnSearchComp);
            this.Controls.Add(this.lblSearchCar);
            this.Controls.Add(this.lblSearchComp);
            this.Controls.Add(this.txtSearchCar);
            this.Controls.Add(this.txtSearchComp);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnEditCompany);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lstCar);
            this.Controls.Add(this.lstCompany);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hire Car Maintenance - Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ListBox lstCompany;
        private System.Windows.Forms.ListBox lstCar;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.TextBox txtSearchComp;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.Label lblSearchComp;
        private System.Windows.Forms.Label lblSearchCar;
        private System.Windows.Forms.Button btnSearchComp;
        private System.Windows.Forms.Button btnSearchCar;
    }
}

