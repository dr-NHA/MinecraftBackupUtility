namespace Minecraft_Backup_Utility
{
    partial class MBUSGCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBUSGCC));
            this.Title = new System.Windows.Forms.Label();
            this.CloseMBU = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MinimizeMBU = new System.Windows.Forms.Button();
            this.BackupList = new System.Windows.Forms.ListBox();
            this.TopPan = new System.Windows.Forms.Panel();
            this.CenPan = new System.Windows.Forms.Panel();
            this.CopyAllBackToGame = new System.Windows.Forms.Button();
            this.BackupAll = new System.Windows.Forms.Button();
            this.DeleteSave = new System.Windows.Forms.Button();
            this.DeleteBackup = new System.Windows.Forms.Button();
            this.SplitingPanel = new System.Windows.Forms.Panel();
            this.DoBackupFromSelected = new System.Windows.Forms.Button();
            this.InjectSelectedBackup = new System.Windows.Forms.Button();
            this.SaveGameList = new System.Windows.Forms.ListBox();
            this.Toperpan = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReloadGameSaves = new System.Windows.Forms.Button();
            this.ReloadBKPan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ReloadBackups = new System.Windows.Forms.Button();
            this.InfoPanel0 = new System.Windows.Forms.Panel();
            this.InfoText1 = new System.Windows.Forms.TextBox();
            this.InfoText0 = new System.Windows.Forms.TextBox();
            this.BottomPan = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.YoutubeLink = new System.Windows.Forms.LinkLabel();
            this.Author = new System.Windows.Forms.Label();
            this.DiscordLink = new System.Windows.Forms.LinkLabel();
            this.CabconLink = new System.Windows.Forms.LinkLabel();
            this.Se7sinsLink = new System.Windows.Forms.LinkLabel();
            this.TitleLogoBox = new System.Windows.Forms.PictureBox();
            this.UpdateLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.TopPan.SuspendLayout();
            this.CenPan.SuspendLayout();
            this.Toperpan.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ReloadBKPan.SuspendLayout();
            this.InfoPanel0.SuspendLayout();
            this.BottomPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(10)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(0, 0, 140, 0);
            this.Title.Size = new System.Drawing.Size(800, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "NHA\'s Minecraft Backup Utility -SGCC-";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // CloseMBU
            // 
            this.CloseMBU.BackColor = System.Drawing.Color.Black;
            this.CloseMBU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMBU.Font = new System.Drawing.Font("Segoe UI Symbol", 7F, System.Drawing.FontStyle.Bold);
            this.CloseMBU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.CloseMBU.Location = new System.Drawing.Point(77, 3);
            this.CloseMBU.Name = "CloseMBU";
            this.CloseMBU.Size = new System.Drawing.Size(52, 30);
            this.CloseMBU.TabIndex = 1;
            this.CloseMBU.Text = "Close";
            this.CloseMBU.UseVisualStyleBackColor = true;
            this.CloseMBU.Click += new System.EventHandler(this.CloseMBU_Click);
            this.CloseMBU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.CloseMBU);
            this.flowLayoutPanel1.Controls.Add(this.MinimizeMBU);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(664, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 38);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // MinimizeMBU
            // 
            this.MinimizeMBU.BackColor = System.Drawing.Color.Black;
            this.MinimizeMBU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeMBU.Font = new System.Drawing.Font("Segoe UI Symbol", 7F, System.Drawing.FontStyle.Bold);
            this.MinimizeMBU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.MinimizeMBU.Location = new System.Drawing.Point(7, 3);
            this.MinimizeMBU.Name = "MinimizeMBU";
            this.MinimizeMBU.Size = new System.Drawing.Size(64, 30);
            this.MinimizeMBU.TabIndex = 2;
            this.MinimizeMBU.Text = "Minimize";
            this.MinimizeMBU.UseVisualStyleBackColor = true;
            this.MinimizeMBU.Click += new System.EventHandler(this.MinimizeMBU_Click);
            this.MinimizeMBU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // BackupList
            // 
            this.BackupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupList.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackupList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackupList.FormattingEnabled = true;
            this.BackupList.Location = new System.Drawing.Point(0, 0);
            this.BackupList.Name = "BackupList";
            this.BackupList.Size = new System.Drawing.Size(301, 248);
            this.BackupList.TabIndex = 3;
            this.BackupList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // TopPan
            // 
            this.TopPan.BackColor = System.Drawing.Color.Black;
            this.TopPan.Controls.Add(this.CenPan);
            this.TopPan.Controls.Add(this.SaveGameList);
            this.TopPan.Controls.Add(this.BackupList);
            this.TopPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPan.Location = new System.Drawing.Point(0, 120);
            this.TopPan.Name = "TopPan";
            this.TopPan.Size = new System.Drawing.Size(800, 248);
            this.TopPan.TabIndex = 4;
            this.TopPan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // CenPan
            // 
            this.CenPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.CenPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CenPan.Controls.Add(this.CopyAllBackToGame);
            this.CenPan.Controls.Add(this.BackupAll);
            this.CenPan.Controls.Add(this.DeleteSave);
            this.CenPan.Controls.Add(this.DeleteBackup);
            this.CenPan.Controls.Add(this.SplitingPanel);
            this.CenPan.Controls.Add(this.DoBackupFromSelected);
            this.CenPan.Controls.Add(this.InjectSelectedBackup);
            this.CenPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenPan.Location = new System.Drawing.Point(301, 0);
            this.CenPan.Name = "CenPan";
            this.CenPan.Size = new System.Drawing.Size(234, 248);
            this.CenPan.TabIndex = 4;
            this.CenPan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // CopyAllBackToGame
            // 
            this.CopyAllBackToGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyAllBackToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyAllBackToGame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyAllBackToGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CopyAllBackToGame.Location = new System.Drawing.Point(2, 41);
            this.CopyAllBackToGame.Name = "CopyAllBackToGame";
            this.CopyAllBackToGame.Size = new System.Drawing.Size(100, 30);
            this.CopyAllBackToGame.TabIndex = 6;
            this.CopyAllBackToGame.Text = "Copy All Back";
            this.CopyAllBackToGame.UseVisualStyleBackColor = true;
            this.CopyAllBackToGame.Click += new System.EventHandler(this.CopyAllBackToGame_Click);
            this.CopyAllBackToGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // BackupAll
            // 
            this.BackupAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BackupAll.Location = new System.Drawing.Point(111, 41);
            this.BackupAll.Name = "BackupAll";
            this.BackupAll.Size = new System.Drawing.Size(119, 30);
            this.BackupAll.TabIndex = 5;
            this.BackupAll.Text = "Backup All Saves";
            this.BackupAll.UseVisualStyleBackColor = true;
            this.BackupAll.Click += new System.EventHandler(this.BackupAll_Click);
            this.BackupAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // DeleteSave
            // 
            this.DeleteSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.DeleteSave.Location = new System.Drawing.Point(111, 142);
            this.DeleteSave.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteSave.Name = "DeleteSave";
            this.DeleteSave.Size = new System.Drawing.Size(119, 30);
            this.DeleteSave.TabIndex = 4;
            this.DeleteSave.Text = "Delete";
            this.DeleteSave.UseVisualStyleBackColor = true;
            this.DeleteSave.Click += new System.EventHandler(this.DeleteSave_Click);
            this.DeleteSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // DeleteBackup
            // 
            this.DeleteBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.DeleteBackup.Location = new System.Drawing.Point(2, 142);
            this.DeleteBackup.Name = "DeleteBackup";
            this.DeleteBackup.Size = new System.Drawing.Size(100, 30);
            this.DeleteBackup.TabIndex = 3;
            this.DeleteBackup.Text = "Delete";
            this.DeleteBackup.UseVisualStyleBackColor = true;
            this.DeleteBackup.Click += new System.EventHandler(this.DeleteBackup_Click);
            this.DeleteBackup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // SplitingPanel
            // 
            this.SplitingPanel.BackColor = System.Drawing.Color.Black;
            this.SplitingPanel.Location = new System.Drawing.Point(104, -11);
            this.SplitingPanel.Name = "SplitingPanel";
            this.SplitingPanel.Size = new System.Drawing.Size(5, 271);
            this.SplitingPanel.TabIndex = 2;
            this.SplitingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // DoBackupFromSelected
            // 
            this.DoBackupFromSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBackupFromSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoBackupFromSelected.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBackupFromSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.DoBackupFromSelected.Location = new System.Drawing.Point(111, 8);
            this.DoBackupFromSelected.Name = "DoBackupFromSelected";
            this.DoBackupFromSelected.Size = new System.Drawing.Size(119, 30);
            this.DoBackupFromSelected.TabIndex = 1;
            this.DoBackupFromSelected.Text = "Backup From Game";
            this.DoBackupFromSelected.UseVisualStyleBackColor = true;
            this.DoBackupFromSelected.Click += new System.EventHandler(this.DoBackupFromSelected_Click);
            this.DoBackupFromSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // InjectSelectedBackup
            // 
            this.InjectSelectedBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectSelectedBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectSelectedBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.InjectSelectedBackup.Location = new System.Drawing.Point(2, 8);
            this.InjectSelectedBackup.Name = "InjectSelectedBackup";
            this.InjectSelectedBackup.Size = new System.Drawing.Size(100, 30);
            this.InjectSelectedBackup.TabIndex = 0;
            this.InjectSelectedBackup.Text = "Copy To Game";
            this.InjectSelectedBackup.UseVisualStyleBackColor = true;
            this.InjectSelectedBackup.Click += new System.EventHandler(this.InjectSelectedBackup_Click);
            this.InjectSelectedBackup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // SaveGameList
            // 
            this.SaveGameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SaveGameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveGameList.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveGameList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGameList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.SaveGameList.FormattingEnabled = true;
            this.SaveGameList.Location = new System.Drawing.Point(535, 0);
            this.SaveGameList.Name = "SaveGameList";
            this.SaveGameList.Size = new System.Drawing.Size(265, 248);
            this.SaveGameList.TabIndex = 5;
            this.SaveGameList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // Toperpan
            // 
            this.Toperpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(12)))));
            this.Toperpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Toperpan.Controls.Add(this.panel4);
            this.Toperpan.Controls.Add(this.ReloadBKPan);
            this.Toperpan.Controls.Add(this.InfoPanel0);
            this.Toperpan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toperpan.Location = new System.Drawing.Point(0, 44);
            this.Toperpan.Name = "Toperpan";
            this.Toperpan.Size = new System.Drawing.Size(800, 76);
            this.Toperpan.TabIndex = 5;
            this.Toperpan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ReloadGameSaves);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(534, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 28);
            this.panel4.TabIndex = 5;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Saves";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // ReloadGameSaves
            // 
            this.ReloadGameSaves.AutoSize = true;
            this.ReloadGameSaves.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReloadGameSaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadGameSaves.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadGameSaves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ReloadGameSaves.Location = new System.Drawing.Point(189, 0);
            this.ReloadGameSaves.Name = "ReloadGameSaves";
            this.ReloadGameSaves.Size = new System.Drawing.Size(75, 28);
            this.ReloadGameSaves.TabIndex = 3;
            this.ReloadGameSaves.Text = "Reload";
            this.ReloadGameSaves.UseVisualStyleBackColor = true;
            this.ReloadGameSaves.Click += new System.EventHandler(this.ReloadGameSaves_Click);
            this.ReloadGameSaves.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // ReloadBKPan
            // 
            this.ReloadBKPan.Controls.Add(this.label2);
            this.ReloadBKPan.Controls.Add(this.ReloadBackups);
            this.ReloadBKPan.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReloadBKPan.Location = new System.Drawing.Point(0, 46);
            this.ReloadBKPan.Name = "ReloadBKPan";
            this.ReloadBKPan.Size = new System.Drawing.Size(300, 28);
            this.ReloadBKPan.TabIndex = 4;
            this.ReloadBKPan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup Saves";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // ReloadBackups
            // 
            this.ReloadBackups.AutoSize = true;
            this.ReloadBackups.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReloadBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadBackups.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBackups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ReloadBackups.Location = new System.Drawing.Point(225, 0);
            this.ReloadBackups.Name = "ReloadBackups";
            this.ReloadBackups.Size = new System.Drawing.Size(75, 28);
            this.ReloadBackups.TabIndex = 2;
            this.ReloadBackups.Text = "Reload";
            this.ReloadBackups.UseVisualStyleBackColor = true;
            this.ReloadBackups.Click += new System.EventHandler(this.ReloadBackups_Click);
            this.ReloadBackups.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // InfoPanel0
            // 
            this.InfoPanel0.BackColor = System.Drawing.Color.Black;
            this.InfoPanel0.Controls.Add(this.InfoText1);
            this.InfoPanel0.Controls.Add(this.InfoText0);
            this.InfoPanel0.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel0.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel0.Name = "InfoPanel0";
            this.InfoPanel0.Size = new System.Drawing.Size(798, 46);
            this.InfoPanel0.TabIndex = 6;
            this.InfoPanel0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // InfoText1
            // 
            this.InfoText1.BackColor = System.Drawing.Color.Black;
            this.InfoText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoText1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InfoText1.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoText1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InfoText1.Location = new System.Drawing.Point(219, 0);
            this.InfoText1.Multiline = true;
            this.InfoText1.Name = "InfoText1";
            this.InfoText1.Size = new System.Drawing.Size(579, 46);
            this.InfoText1.TabIndex = 1;
            this.InfoText1.Text = "Please Update Via Github Only! (Others May Be Rats/Virus\'s)\r\nMore To Come.\r\nPaid " +
    "Version Will Be Avaliable With Memory Modifications!\r\n";
            this.InfoText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoText1.WordWrap = false;
            this.InfoText1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseDown);
            this.InfoText1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            this.InfoText1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseUp);
            // 
            // InfoText0
            // 
            this.InfoText0.BackColor = System.Drawing.Color.Black;
            this.InfoText0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoText0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InfoText0.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoText0.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InfoText0.Location = new System.Drawing.Point(0, 0);
            this.InfoText0.Multiline = true;
            this.InfoText0.Name = "InfoText0";
            this.InfoText0.Size = new System.Drawing.Size(219, 46);
            this.InfoText0.TabIndex = 0;
            this.InfoText0.Text = "Minecraft Windows 10 Edition\r\nSavegame Manager And Backup\r\nTool With Extras";
            this.InfoText0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoText0.WordWrap = false;
            this.InfoText0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseDown);
            this.InfoText0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            this.InfoText0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseUp);
            // 
            // BottomPan
            // 
            this.BottomPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BottomPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPan.Controls.Add(this.UpdateLink);
            this.BottomPan.Controls.Add(this.LogoBox);
            this.BottomPan.Controls.Add(this.YoutubeLink);
            this.BottomPan.Controls.Add(this.Author);
            this.BottomPan.Controls.Add(this.DiscordLink);
            this.BottomPan.Controls.Add(this.CabconLink);
            this.BottomPan.Controls.Add(this.Se7sinsLink);
            this.BottomPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPan.Location = new System.Drawing.Point(0, 368);
            this.BottomPan.Name = "BottomPan";
            this.BottomPan.Size = new System.Drawing.Size(800, 82);
            this.BottomPan.TabIndex = 6;
            this.BottomPan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::Minecraft_Backup_Utility.Properties.Resources.APPIMG;
            this.LogoBox.Location = new System.Drawing.Point(626, 2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(163, 76);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 3;
            this.LogoBox.TabStop = false;
            this.LogoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // YoutubeLink
            // 
            this.YoutubeLink.ActiveLinkColor = System.Drawing.Color.Pink;
            this.YoutubeLink.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.YoutubeLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YoutubeLink.Location = new System.Drawing.Point(423, -7);
            this.YoutubeLink.Name = "YoutubeLink";
            this.YoutubeLink.Size = new System.Drawing.Size(160, 28);
            this.YoutubeLink.TabIndex = 1;
            this.YoutubeLink.TabStop = true;
            this.YoutubeLink.Text = "dr NHA\'s YouTube";
            this.YoutubeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YoutubeLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YoutubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YoutubeLink_LinkClicked);
            this.YoutubeLink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // Author
            // 
            this.Author.Dock = System.Windows.Forms.DockStyle.Left;
            this.Author.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Author.Location = new System.Drawing.Point(0, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(409, 80);
            this.Author.TabIndex = 0;
            this.Author.Text = "Tool Created By: dr NHA";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Author.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // DiscordLink
            // 
            this.DiscordLink.ActiveLinkColor = System.Drawing.Color.Pink;
            this.DiscordLink.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.DiscordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DiscordLink.Location = new System.Drawing.Point(422, 10);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(160, 32);
            this.DiscordLink.TabIndex = 2;
            this.DiscordLink.TabStop = true;
            this.DiscordLink.Text = "dr NHA\'s Discord";
            this.DiscordLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiscordLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLink_LinkClicked);
            this.DiscordLink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // CabconLink
            // 
            this.CabconLink.ActiveLinkColor = System.Drawing.Color.Pink;
            this.CabconLink.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.CabconLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CabconLink.Location = new System.Drawing.Point(405, 31);
            this.CabconLink.Name = "CabconLink";
            this.CabconLink.Size = new System.Drawing.Size(195, 32);
            this.CabconLink.TabIndex = 4;
            this.CabconLink.TabStop = true;
            this.CabconLink.Text = "dr NHA\'s CabconModding";
            this.CabconLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CabconLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CabconLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CabconLink_LinkClicked);
            // 
            // Se7sinsLink
            // 
            this.Se7sinsLink.ActiveLinkColor = System.Drawing.Color.Pink;
            this.Se7sinsLink.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.Se7sinsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Se7sinsLink.Location = new System.Drawing.Point(403, 51);
            this.Se7sinsLink.Name = "Se7sinsLink";
            this.Se7sinsLink.Size = new System.Drawing.Size(195, 32);
            this.Se7sinsLink.TabIndex = 5;
            this.Se7sinsLink.TabStop = true;
            this.Se7sinsLink.Text = "dr NHA\'s se7ensins";
            this.Se7sinsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Se7sinsLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Se7sinsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Se7ensinsLink_LinkClicked);
            // 
            // TitleLogoBox
            // 
            this.TitleLogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(10)))));
            this.TitleLogoBox.Image = global::Minecraft_Backup_Utility.Properties.Resources.APPIMG;
            this.TitleLogoBox.Location = new System.Drawing.Point(0, 3);
            this.TitleLogoBox.Name = "TitleLogoBox";
            this.TitleLogoBox.Size = new System.Drawing.Size(46, 41);
            this.TitleLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleLogoBox.TabIndex = 4;
            this.TitleLogoBox.TabStop = false;
            this.TitleLogoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            // 
            // UpdateLink
            // 
            this.UpdateLink.ActiveLinkColor = System.Drawing.Color.Pink;
            this.UpdateLink.Font = new System.Drawing.Font("Segoe UI Light", 10.25F, System.Drawing.FontStyle.Bold);
            this.UpdateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UpdateLink.Location = new System.Drawing.Point(105, 51);
            this.UpdateLink.Name = "UpdateLink";
            this.UpdateLink.Size = new System.Drawing.Size(195, 32);
            this.UpdateLink.TabIndex = 6;
            this.UpdateLink.TabStop = true;
            this.UpdateLink.Text = "Update Github";
            this.UpdateLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLink_LinkClicked);
            // 
            // MBUSGCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleLogoBox);
            this.Controls.Add(this.BottomPan);
            this.Controls.Add(this.TopPan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Toperpan);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MBUSGCC";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "MBU SGCC";
            this.Load += new System.EventHandler(this.MBUSGCC_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveAbleWindow_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.TopPan.ResumeLayout(false);
            this.CenPan.ResumeLayout(false);
            this.Toperpan.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ReloadBKPan.ResumeLayout(false);
            this.ReloadBKPan.PerformLayout();
            this.InfoPanel0.ResumeLayout(false);
            this.InfoPanel0.PerformLayout();
            this.BottomPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseMBU;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MinimizeMBU;
        private System.Windows.Forms.ListBox BackupList;
        private System.Windows.Forms.Panel TopPan;
        private System.Windows.Forms.Panel CenPan;
        private System.Windows.Forms.Button DoBackupFromSelected;
        private System.Windows.Forms.Button InjectSelectedBackup;
        private System.Windows.Forms.ListBox SaveGameList;
        private System.Windows.Forms.Panel Toperpan;
        private System.Windows.Forms.Panel BottomPan;
        private System.Windows.Forms.Panel SplitingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ReloadGameSaves;
        private System.Windows.Forms.Panel ReloadBKPan;
        private System.Windows.Forms.Button ReloadBackups;
        private System.Windows.Forms.Panel InfoPanel0;
        private System.Windows.Forms.Button DeleteSave;
        private System.Windows.Forms.Button DeleteBackup;
        private System.Windows.Forms.Button BackupAll;
        private System.Windows.Forms.Button CopyAllBackToGame;
        private System.Windows.Forms.TextBox InfoText0;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.LinkLabel DiscordLink;
        private System.Windows.Forms.LinkLabel YoutubeLink;
        private System.Windows.Forms.TextBox InfoText1;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.PictureBox TitleLogoBox;
        private System.Windows.Forms.LinkLabel CabconLink;
        private System.Windows.Forms.LinkLabel Se7sinsLink;
        private System.Windows.Forms.LinkLabel UpdateLink;
    }
}

