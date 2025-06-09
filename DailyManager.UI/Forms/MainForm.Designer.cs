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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreateDaily = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxDaily.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Image = global::DailyManager.UI.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(12, 514);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(35, 35);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // labelCreatorInfo
            // 
            this.labelCreatorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreatorInfo.AutoSize = true;
            this.labelCreatorInfo.Location = new System.Drawing.Point(428, 514);
            this.labelCreatorInfo.Name = "labelCreatorInfo";
            this.labelCreatorInfo.Size = new System.Drawing.Size(144, 13);
            this.labelCreatorInfo.TabIndex = 1;
            this.labelCreatorInfo.Text = "Created by Euclydes Uchoas";
            // 
            // labelVersionInfo
            // 
            this.labelVersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersionInfo.AutoSize = true;
            this.labelVersionInfo.Location = new System.Drawing.Point(494, 536);
            this.labelVersionInfo.Name = "labelVersionInfo";
            this.labelVersionInfo.Size = new System.Drawing.Size(78, 13);
            this.labelVersionInfo.TabIndex = 2;
            this.labelVersionInfo.Text = "Version 1.0.0.0";
            // 
            // groupBoxDaily
            // 
            this.groupBoxDaily.Controls.Add(this.button1);
            this.groupBoxDaily.Controls.Add(this.buttonCreateDaily);
            this.groupBoxDaily.Location = new System.Drawing.Point(12, 89);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(270, 100);
            this.groupBoxDaily.TabIndex = 3;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Daily";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Daily List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDaily
            // 
            this.buttonCreateDaily.Location = new System.Drawing.Point(99, 19);
            this.buttonCreateDaily.Name = "buttonCreateDaily";
            this.buttonCreateDaily.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDaily.TabIndex = 0;
            this.buttonCreateDaily.Text = "Create Daily";
            this.buttonCreateDaily.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(584, 37);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "DAILY MANAGER";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(302, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxDaily);
            this.Controls.Add(this.labelVersionInfo);
            this.Controls.Add(this.labelCreatorInfo);
            this.Controls.Add(this.buttonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Manager";
            this.groupBoxDaily.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelCreatorInfo;
        private System.Windows.Forms.Label labelVersionInfo;
        private System.Windows.Forms.GroupBox groupBoxDaily;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateDaily;
        private System.Windows.Forms.Button button1;
    }
}

