namespace DailyManager.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelCreatorInfo = new System.Windows.Forms.Label();
            this.labelVersionInfo = new System.Windows.Forms.Label();
            this.groupBoxDaily = new System.Windows.Forms.GroupBox();
            this.buttonDailyList = new System.Windows.Forms.Button();
            this.buttonCreateDaily = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.buttonCompanyList = new System.Windows.Forms.Button();
            this.buttonCreateCompany = new System.Windows.Forms.Button();
            this.groupBoxDaily.SuspendLayout();
            this.groupBoxCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Image = global::DailyManager.UI.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(12, 310);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(35, 35);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // labelCreatorInfo
            // 
            this.labelCreatorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreatorInfo.AutoSize = true;
            this.labelCreatorInfo.Location = new System.Drawing.Point(224, 310);
            this.labelCreatorInfo.Name = "labelCreatorInfo";
            this.labelCreatorInfo.Size = new System.Drawing.Size(144, 13);
            this.labelCreatorInfo.TabIndex = 1;
            this.labelCreatorInfo.Text = "Created by Euclydes Uchoas";
            // 
            // labelVersionInfo
            // 
            this.labelVersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersionInfo.AutoSize = true;
            this.labelVersionInfo.Location = new System.Drawing.Point(290, 332);
            this.labelVersionInfo.Name = "labelVersionInfo";
            this.labelVersionInfo.Size = new System.Drawing.Size(78, 13);
            this.labelVersionInfo.TabIndex = 2;
            this.labelVersionInfo.Text = "Version 1.0.0.0";
            // 
            // groupBoxDaily
            // 
            this.groupBoxDaily.Controls.Add(this.buttonDailyList);
            this.groupBoxDaily.Controls.Add(this.buttonCreateDaily);
            this.groupBoxDaily.Location = new System.Drawing.Point(12, 70);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(356, 100);
            this.groupBoxDaily.TabIndex = 0;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Daily";
            // 
            // buttonDailyList
            // 
            this.buttonDailyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDailyList.Location = new System.Drawing.Point(129, 55);
            this.buttonDailyList.Name = "buttonDailyList";
            this.buttonDailyList.Size = new System.Drawing.Size(100, 30);
            this.buttonDailyList.TabIndex = 1;
            this.buttonDailyList.Text = "Daily List";
            this.buttonDailyList.UseVisualStyleBackColor = false;
            this.buttonDailyList.Click += new System.EventHandler(this.ButtonDailyList_Click);
            // 
            // buttonCreateDaily
            // 
            this.buttonCreateDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateDaily.Location = new System.Drawing.Point(129, 19);
            this.buttonCreateDaily.Name = "buttonCreateDaily";
            this.buttonCreateDaily.Size = new System.Drawing.Size(100, 30);
            this.buttonCreateDaily.TabIndex = 0;
            this.buttonCreateDaily.Text = "Create Daily";
            this.buttonCreateDaily.UseVisualStyleBackColor = false;
            this.buttonCreateDaily.Click += new System.EventHandler(this.ButtonCreateDaily_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(380, 50);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "DAILY MANAGER";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCompany
            // 
            this.groupBoxCompany.Controls.Add(this.buttonCompanyList);
            this.groupBoxCompany.Controls.Add(this.buttonCreateCompany);
            this.groupBoxCompany.Location = new System.Drawing.Point(12, 190);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.groupBoxCompany.Size = new System.Drawing.Size(356, 100);
            this.groupBoxCompany.TabIndex = 1;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "Company";
            // 
            // buttonCompanyList
            // 
            this.buttonCompanyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCompanyList.Location = new System.Drawing.Point(129, 55);
            this.buttonCompanyList.Name = "buttonCompanyList";
            this.buttonCompanyList.Size = new System.Drawing.Size(100, 30);
            this.buttonCompanyList.TabIndex = 3;
            this.buttonCompanyList.Text = "Company List";
            this.buttonCompanyList.UseVisualStyleBackColor = false;
            // 
            // buttonCreateCompany
            // 
            this.buttonCreateCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateCompany.Location = new System.Drawing.Point(129, 19);
            this.buttonCreateCompany.Name = "buttonCreateCompany";
            this.buttonCreateCompany.Size = new System.Drawing.Size(100, 30);
            this.buttonCreateCompany.TabIndex = 2;
            this.buttonCreateCompany.Text = "Create Company";
            this.buttonCreateCompany.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.groupBoxCompany);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxDaily);
            this.Controls.Add(this.labelVersionInfo);
            this.Controls.Add(this.labelCreatorInfo);
            this.Controls.Add(this.buttonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Manager";
            this.groupBoxDaily.ResumeLayout(false);
            this.groupBoxCompany.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelCreatorInfo;
        private System.Windows.Forms.Label labelVersionInfo;
        private System.Windows.Forms.GroupBox groupBoxDaily;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private System.Windows.Forms.Button buttonCreateDaily;
        private System.Windows.Forms.Button buttonDailyList;
        private System.Windows.Forms.Button buttonCompanyList;
        private System.Windows.Forms.Button buttonCreateCompany;
    }
}

