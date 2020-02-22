using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DaRT
{
	partial class GUImain
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			#region Init
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUImain));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.hosts = new System.Windows.Forms.Button();
			this.execute = new System.Windows.Forms.Button();
			this.settings = new System.Windows.Forms.Button();
			this.lastRefresh = new System.Windows.Forms.Label();
			this.refresh = new System.Windows.Forms.Button();
			this.disconnect = new System.Windows.Forms.Button();
			this.connect = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.portLabel = new System.Windows.Forms.Label();
			this.hostLabel = new System.Windows.Forms.Label();
			this.port = new System.Windows.Forms.TextBox();
			this.host = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.AdminsTab = new System.Windows.Forms.TabControl();
			this.playersTab = new System.Windows.Forms.TabPage();
			this.playerList = new System.Windows.Forms.ListView();
			this.bansTab = new System.Windows.Forms.TabPage();
			this.bansList = new System.Windows.Forms.ListView();
			this.playerdatabaseTab = new System.Windows.Forms.TabPage();
			this.playerDBList = new System.Windows.Forms.ListView();
			this.AdminListTab = new System.Windows.Forms.TabPage();
			this.playerCounter = new System.Windows.Forms.Label();
			this.adminList = new System.Windows.Forms.ListView();
			this.news = new System.Windows.Forms.Label();
			this.banCounter = new System.Windows.Forms.Label();
			this.adminCounter = new System.Windows.Forms.Label();
			this.counter = new System.Windows.Forms.Label();
			this.globalbanlist = new ListView();
			this.globalbans = new TabPage();
			this.allowMessages = new System.Windows.Forms.CheckBox();
			this.logTabs = new System.Windows.Forms.TabControl();
			this.tabAll = new System.Windows.Forms.TabPage();
			this.all = new DaRT.ExtendedRichTextBox();
			this.tabConsole = new System.Windows.Forms.TabPage();
			this.console = new DaRT.ExtendedRichTextBox();
			this.tabChat = new System.Windows.Forms.TabPage();
			this.chat = new DaRT.ExtendedRichTextBox();
			this.tabLog = new System.Windows.Forms.TabPage();
			this.logs = new DaRT.ExtendedRichTextBox();
			this.search = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.autoRefresh = new System.Windows.Forms.CheckBox();
			this.filter = new System.Windows.Forms.ComboBox();
			this.searchLabel = new System.Windows.Forms.Label();
			this.input = new System.Windows.Forms.TextBox();
			this.banner = new System.Windows.Forms.PictureBox();
			this.options = new System.Windows.Forms.ComboBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.AdminsTab.SuspendLayout();
			this.playersTab.SuspendLayout();
			this.bansTab.SuspendLayout();
			this.AdminListTab.SuspendLayout();
			this.adminList.SuspendLayout();
			this.playerdatabaseTab.SuspendLayout();
			this.logTabs.SuspendLayout();
			this.tabAll.SuspendLayout();
			this.tabConsole.SuspendLayout();
			this.tabChat.SuspendLayout();
			this.tabLog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
			this.SuspendLayout();
			#endregion
			// 
			#region splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(-1, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.hosts);
			this.splitContainer1.Panel1.Controls.Add(this.execute);
			this.splitContainer1.Panel1.Controls.Add(this.settings);
			this.splitContainer1.Panel1.Controls.Add(this.lastRefresh);
			this.splitContainer1.Panel1.Controls.Add(this.refresh);
			this.splitContainer1.Panel1.Controls.Add(this.disconnect);
			this.splitContainer1.Panel1.Controls.Add(this.connect);
			this.splitContainer1.Panel1.Controls.Add(this.password);
			this.splitContainer1.Panel1.Controls.Add(this.passwordLabel);
			this.splitContainer1.Panel1.Controls.Add(this.portLabel);
			this.splitContainer1.Panel1.Controls.Add(this.hostLabel);
			this.splitContainer1.Panel1.Controls.Add(this.port);
			this.splitContainer1.Panel1.Controls.Add(this.host);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1230, 571);
			this.splitContainer1.SplitterDistance = 139;
			this.splitContainer1.TabIndex = 0;
			#endregion
			// 
			// button1
			// 
			#region DarkMode
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(9, 414);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 32);
			this.button1.TabIndex = 23;
			this.button1.Text = "Dark/Light Theme";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.DarkModeToggle);
			#endregion
			// 
			// hosts
			// 
			#region Hosts
			this.hosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.hosts.Location = new System.Drawing.Point(9, 452);
			this.hosts.Name = "hosts";
			this.hosts.Size = new System.Drawing.Size(120, 32);
			this.hosts.TabIndex = 22;
			this.hosts.Text = "Load Servers";
			this.hosts.UseVisualStyleBackColor = true;
			#endregion
			// 
			#region Execute
			// execute
			// 
			this.execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.execute.Enabled = false;
			this.execute.Location = new System.Drawing.Point(9, 488);
			this.execute.Name = "execute";
			this.execute.Size = new System.Drawing.Size(120, 32);
			this.execute.TabIndex = 20;
			this.execute.Text = "Execute...";
			this.execute.UseVisualStyleBackColor = true;
			this.execute.Click += new System.EventHandler(this.execute_Click);
			#endregion
			// 
			#region Settings
			// settings
			// 
			this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.settings.Location = new System.Drawing.Point(9, 526);
			this.settings.Name = "settings";
			this.settings.Size = new System.Drawing.Size(120, 32);
			this.settings.TabIndex = 17;
			this.settings.Text = "Settings";
			this.settings.UseVisualStyleBackColor = true;
			this.settings.Click += new System.EventHandler(this.settings_Click);
			#endregion
			// 
			#region Refresh
			// lastRefresh
			// 
			this.lastRefresh.AutoSize = true;
			this.lastRefresh.Location = new System.Drawing.Point(3, 267);
			this.lastRefresh.Name = "lastRefresh";
			this.lastRefresh.Size = new System.Drawing.Size(135, 17);
			this.lastRefresh.TabIndex = 12;
			this.lastRefresh.Text = "Last refresh: 0s ago";
			
			// refresh
			// 
			this.refresh.Enabled = false;
			this.refresh.Location = new System.Drawing.Point(9, 219);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(120, 32);
			this.refresh.TabIndex = 9;
			this.refresh.Text = "Refresh (F5)";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.refresh_Click);

			#endregion    // 


			#region Disconnect/connect
			// disconnect
			// 
			this.disconnect.Enabled = false;
			this.disconnect.Location = new System.Drawing.Point(9, 181);
			this.disconnect.Name = "disconnect";
			this.disconnect.Size = new System.Drawing.Size(120, 32);
			this.disconnect.TabIndex = 8;
			this.disconnect.Text = "Disconnect";
			this.disconnect.UseVisualStyleBackColor = true;
			this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
			// 
			// connect
			// 
			this.connect.Location = new System.Drawing.Point(9, 143);
			this.connect.Name = "connect";
			this.connect.Size = new System.Drawing.Size(120, 32);
			this.connect.TabIndex = 6;
			this.connect.Text = "Connect";
			this.connect.UseVisualStyleBackColor = true;
			this.connect.Click += new System.EventHandler(this.connect_Click);
			#endregion
			// 
			#region Password
			// password
			// 
			this.password.Location = new System.Drawing.Point(9, 115);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(120, 22);
			this.password.TabIndex = 5;
			this.password.UseSystemPasswordChar = true;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 95);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(69, 17);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "Password";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;

			#endregion         // 
			#region Port/Host
			// portLabel
			// 
			this.portLabel.AutoSize = true;
			this.portLabel.Location = new System.Drawing.Point(12, 50);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size(34, 17);
			this.portLabel.TabIndex = 3;
			this.portLabel.Text = "Port";
			this.portLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// hostLabel
			// 
			this.hostLabel.AutoSize = true;
			this.hostLabel.Location = new System.Drawing.Point(12, 5);
			this.hostLabel.Name = "hostLabel";
			this.hostLabel.Size = new System.Drawing.Size(37, 17);
			this.hostLabel.TabIndex = 2;
			this.hostLabel.Text = "Host";
			this.hostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// port
			// 
			this.port.Location = new System.Drawing.Point(9, 70);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(120, 22);
			this.port.TabIndex = 1;
			// 
			// host
			// 
			this.host.Location = new System.Drawing.Point(9, 25);
			this.host.Name = "host";
			this.host.Size = new System.Drawing.Size(120, 22);
			this.host.TabIndex = 0;
			#endregion
			// 
			#region SplitContainer2

			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.AdminsTab);
			this.splitContainer2.Panel1.Controls.Add(this.playerCounter);
			this.splitContainer2.Panel1.Controls.Add(this.news);
			this.splitContainer2.Panel1.Controls.Add(this.banCounter);
			this.splitContainer2.Panel1.Controls.Add(this.adminCounter);
			this.splitContainer2.Panel1MinSize = 0;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.counter);
			this.splitContainer2.Panel2.Controls.Add(this.allowMessages);
			this.splitContainer2.Panel2.Controls.Add(this.logTabs);
			this.splitContainer2.Panel2.Controls.Add(this.search);
			this.splitContainer2.Panel2.Controls.Add(this.searchButton);
			this.splitContainer2.Panel2.Controls.Add(this.autoRefresh);
			this.splitContainer2.Panel2.Controls.Add(this.filter);
			this.splitContainer2.Panel2.Controls.Add(this.searchLabel);
			this.splitContainer2.Panel2.Controls.Add(this.input);
			this.splitContainer2.Panel2.Controls.Add(this.banner);
			this.splitContainer2.Panel2.Controls.Add(this.options);
			this.splitContainer2.Panel2MinSize = 50;
			this.splitContainer2.Size = new System.Drawing.Size(1087, 571);
			this.splitContainer2.SplitterDistance = 329;
			this.splitContainer2.TabIndex = 21;

			#endregion// 
			#region Admins/PlayersTab
			// AdminsTab
			// 
			this.AdminsTab.Controls.Add(this.playersTab);
			this.AdminsTab.Controls.Add(this.bansTab);
			this.AdminsTab.Controls.Add(this.playerdatabaseTab);
			this.AdminsTab.Controls.Add(this.AdminListTab);
			this.AdminsTab.Controls.Add(this.globalbans);
			this.AdminsTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AdminsTab.Location = new System.Drawing.Point(0, 0);
			this.AdminsTab.Name = "AdminsTab";
			this.AdminsTab.SelectedIndex = 0;
			this.AdminsTab.Size = new System.Drawing.Size(1087, 329);
			this.AdminsTab.TabIndex = 11;
			this.AdminsTab.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// playersTab
			// 

			this.playersTab.Controls.Add(this.playerList);
			this.playersTab.Location = new System.Drawing.Point(4, 25);
			this.playersTab.Name = "playersTab";
			this.playersTab.Size = new System.Drawing.Size(1079, 300);
			this.playersTab.TabIndex = 0;
			this.playersTab.Text = "Players";
			this.playersTab.UseVisualStyleBackColor = true;

			#endregion// 
			// playerList
			#region PlayerList/GlobalBanlist

			this.playerList.AllowColumnReorder = true;
			this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playerList.FullRowSelect = true;
			this.playerList.GridLines = true;
			this.playerList.HideSelection = false;
			this.playerList.Location = new System.Drawing.Point(0, 0);
			this.playerList.MultiSelect = false;
			this.playerList.Name = "playerList";
			this.playerList.Size = new System.Drawing.Size(1079, 300);
			this.playerList.TabIndex = 0;
			this.playerList.UseCompatibleStateImageBehavior = false;
			this.playerList.View = System.Windows.Forms.View.Details;
			this.playerList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerList_ColumnClick);
			this.playerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerList_MouseDown);
			// Admins List
			this.AdminListTab.Controls.Add(this.adminList);
			this.adminList.AllowColumnReorder = true;
			this.adminList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.adminList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.adminList.FullRowSelect = true;
			this.adminList.GridLines = true;
			this.adminList.HideSelection = false;
			this.adminList.Location = new System.Drawing.Point(0, 0);
			this.adminList.MultiSelect = false;
			this.adminList.Name = "playerList";
			this.adminList.Size = new System.Drawing.Size(1079, 300);
			this.adminList.TabIndex = 0;
			this.adminList.UseCompatibleStateImageBehavior = false;
			this.adminList.View = System.Windows.Forms.View.Details;
			this.adminList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerList_ColumnClick);
			this.adminList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerList_MouseDown);

			//Global Ban list
			this.AdminListTab.Controls.Add(this.globalbanlist);
			this.globalbanlist.AllowColumnReorder = true;
			this.globalbanlist.AllowColumnReorder = true;
			this.globalbanlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.globalbanlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.globalbanlist.FullRowSelect = true;
			this.globalbanlist.GridLines = true;
			this.globalbanlist.HideSelection = false;
			this.globalbanlist.Location = new System.Drawing.Point(0, 0);
			this.globalbanlist.MultiSelect = false;
			this.globalbanlist.Name = "GlobalBanList";
			this.globalbanlist.Size = new System.Drawing.Size(1079, 300);
			this.globalbanlist.TabIndex = 0;
			this.globalbanlist.UseCompatibleStateImageBehavior = false;
			this.globalbanlist.View = System.Windows.Forms.View.Details;
			//this.globalbanlist.VirtualMode = true;
			//this.globalbanlist.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerDBList_ColumnClick);
			//this.globalbanlist.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.playerDBList_RetrieveVirtualItem);
			//this.globalbanlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerDBList_MouseDown);
			//this.globalbanlist.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerDBList_ColumnClick);
			//this.globalbanlist.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.playerDBList_RetrieveVirtualItem);
			//this.globalbanlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerDBList_MouseDown);


			//this.globalbanlist.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerList_ColumnClick);
			//this.globalbanlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerList_MouseDown);
			this.globalbanlist.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.globalbanlist.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.globalbans.Controls.Add(this.globalbanlist);
			this.globalbans.Location = new System.Drawing.Point(4, 25);
			this.globalbans.Name = "globalbansTab";
			this.globalbans.Size = new System.Drawing.Size(1079, 300);
			this.globalbans.TabIndex = 1;
			this.globalbans.Text = "Global Bans";
			#endregion

			#region Bans
			// 
			// bansTab
			// 
			this.bansTab.Controls.Add(this.bansList);
			this.bansTab.Location = new System.Drawing.Point(4, 25);
			this.bansTab.Name = "bansTab";
			this.bansTab.Size = new System.Drawing.Size(1079, 300);
			this.bansTab.TabIndex = 1;
			this.bansTab.Text = "Bans";
			this.bansTab.UseVisualStyleBackColor = true;
			// 
			// bansList
			// 
			this.bansList.AllowColumnReorder = true;
			this.bansList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bansList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bansList.FullRowSelect = true;
			this.bansList.GridLines = true;
			this.bansList.HideSelection = false;
			this.bansList.Location = new System.Drawing.Point(0, 0);
			this.bansList.MultiSelect = false;
			this.bansList.Name = "bansList";
			this.bansList.Size = new System.Drawing.Size(1079, 300);
			this.bansList.TabIndex = 10;
			this.bansList.UseCompatibleStateImageBehavior = false;
			this.bansList.View = System.Windows.Forms.View.Details;
			this.bansList.VirtualMode = true;
			this.bansList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.bansList_ColumnClick);
			this.bansList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.bansList_RetrieveVirtualItem);
			this.bansList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bansList_MouseDown);
			//  
			#endregion
			#region PlayerDB
			// playerdatabaseTab
			// 
			this.playerdatabaseTab.Controls.Add(this.playerDBList);
			this.playerdatabaseTab.Location = new System.Drawing.Point(4, 25);
			this.playerdatabaseTab.Name = "playerdatabaseTab";
			this.playerdatabaseTab.Size = new System.Drawing.Size(1079, 300);
			this.playerdatabaseTab.TabIndex = 2;
			this.playerdatabaseTab.Text = "Player Database";
			this.playerdatabaseTab.UseVisualStyleBackColor = true;
			// 
			// playerDBList
			// 
			this.playerDBList.AllowColumnReorder = true;
			this.playerDBList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playerDBList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.playerDBList.FullRowSelect = true;
			this.playerDBList.GridLines = true;
			this.playerDBList.HideSelection = false;
			this.playerDBList.Location = new System.Drawing.Point(0, 0);
			this.playerDBList.MultiSelect = false;
			this.playerDBList.Name = "playerDBList";
			this.playerDBList.Size = new System.Drawing.Size(1079, 300);
			this.playerDBList.TabIndex = 11;
			this.playerDBList.UseCompatibleStateImageBehavior = false;
			this.playerDBList.View = System.Windows.Forms.View.Details;
			this.playerDBList.VirtualMode = true;
			this.playerDBList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerDBList_ColumnClick);
			this.playerDBList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.playerDBList_RetrieveVirtualItem);
			this.playerDBList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerDBList_MouseDown);
			//  
			#endregion
			// tabPage1
			// 
			this.AdminListTab.Location = new System.Drawing.Point(4, 25);
			this.AdminListTab.Name = "tabPage1";
			this.AdminListTab.Padding = new System.Windows.Forms.Padding(3);
			this.AdminListTab.Size = new System.Drawing.Size(1079, 300);
			this.AdminListTab.TabIndex = 3;
			this.AdminListTab.Text = "Admins";
			this.AdminListTab.UseVisualStyleBackColor = true;

			#region Counters
			// 
			// playerCounter
			// 
			this.playerCounter.AutoSize = true;
			this.playerCounter.Location = new System.Drawing.Point(780, 4);
			this.playerCounter.Name = "playerCounter";
			this.playerCounter.Size = new System.Drawing.Size(71, 17);
			this.playerCounter.TabIndex = 16;
			this.playerCounter.Text = "Players: 0";
			// 
			// news
			// 
			this.news.AutoSize = true;
			this.news.Location = new System.Drawing.Point(252, 4);
			this.news.Name = "news";
			this.news.Size = new System.Drawing.Size(0, 17);
			this.news.TabIndex = 19;
			this.news.Click += new System.EventHandler(this.news_Click);
			// 
			// banCounter
			// 
			this.banCounter.AutoSize = true;
			this.banCounter.Location = new System.Drawing.Point(860, 4);
			this.banCounter.Name = "banCounter";
			this.banCounter.Size = new System.Drawing.Size(56, 17);
			this.banCounter.TabIndex = 17;
			this.banCounter.Text = "Bans: 0";
			// 
			// adminCounter
			// 
			this.adminCounter.AutoSize = true;
			this.adminCounter.Location = new System.Drawing.Point(930, 4);
			this.adminCounter.Name = "adminCounter";
			this.adminCounter.Size = new System.Drawing.Size(70, 17);
			this.adminCounter.TabIndex = 18;
			this.adminCounter.Text = "Admins: 0";
			// 
			// counter
			// 
			this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.counter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.counter.Location = new System.Drawing.Point(92, 215);
			this.counter.Margin = new System.Windows.Forms.Padding(0);
			this.counter.Name = "counter";
			this.counter.Size = new System.Drawing.Size(50, 20);
			this.counter.TabIndex = 1;
			this.counter.Text = "0/400";
			this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//  
			#endregion
			// allowMessages
			// 
			this.allowMessages.AutoSize = true;
			this.allowMessages.Checked = true;
			this.allowMessages.CheckState = System.Windows.Forms.CheckState.Checked;
			this.allowMessages.Location = new System.Drawing.Point(622, 2);
			this.allowMessages.Name = "allowMessages";
			this.allowMessages.Size = new System.Drawing.Size(159, 21);
			this.allowMessages.TabIndex = 22;
			this.allowMessages.Text = "Allow new messages";
			this.allowMessages.UseVisualStyleBackColor = true;
			this.allowMessages.CheckedChanged += new System.EventHandler(this.autoScroll_CheckedChanged);
			// 
			#region Chat and stuff
			// logTabs
			// 
			this.logTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.logTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.logTabs.Controls.Add(this.tabAll);
			this.logTabs.Controls.Add(this.tabConsole);
			this.logTabs.Controls.Add(this.tabChat);
			this.logTabs.Controls.Add(this.tabLog);
			this.logTabs.Location = new System.Drawing.Point(0, 23);
			this.logTabs.Margin = new System.Windows.Forms.Padding(0);
			this.logTabs.Multiline = true;
			this.logTabs.Name = "logTabs";
			this.logTabs.Padding = new System.Drawing.Point(0, 0);
			this.logTabs.SelectedIndex = 0;
			this.logTabs.Size = new System.Drawing.Size(1093, 188);
			this.logTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.logTabs.TabIndex = 21;
			// 
			// tabAll
			// 
			this.tabAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabAll.Controls.Add(this.all);
			this.tabAll.Location = new System.Drawing.Point(46, 4);
			this.tabAll.Margin = new System.Windows.Forms.Padding(0);
			this.tabAll.Name = "tabAll";
			this.tabAll.Size = new System.Drawing.Size(1043, 180);
			this.tabAll.TabIndex = 0;
			this.tabAll.Text = "All";
			// 
			// all
			// 
			this.all.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.all.Dock = System.Windows.Forms.DockStyle.Fill;
			this.all.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.all.Location = new System.Drawing.Point(0, 0);
			this.all.Margin = new System.Windows.Forms.Padding(0);
			this.all.Name = "all";
			this.all.ReadOnly = true;
			this.all.Size = new System.Drawing.Size(1041, 178);
			this.all.TabIndex = 1;
			this.all.Text = "";
			this.all.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
			// 
			// tabConsole
			// 
			this.tabConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabConsole.Controls.Add(this.console);
			this.tabConsole.Location = new System.Drawing.Point(46, 4);
			this.tabConsole.Name = "tabConsole";
			this.tabConsole.Size = new System.Drawing.Size(1043, 180);
			this.tabConsole.TabIndex = 1;
			this.tabConsole.Text = "Console";
			// 
			// console
			// 
			this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.console.Dock = System.Windows.Forms.DockStyle.Fill;
			this.console.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.console.Location = new System.Drawing.Point(0, 0);
			this.console.Margin = new System.Windows.Forms.Padding(0);
			this.console.Name = "console";
			this.console.ReadOnly = true;
			this.console.Size = new System.Drawing.Size(1041, 178);
			this.console.TabIndex = 2;
			this.console.Text = "";
			this.console.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
			// 
			// tabChat
			// 
			this.tabChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabChat.Controls.Add(this.chat);
			this.tabChat.Location = new System.Drawing.Point(46, 4);
			this.tabChat.Name = "tabChat";
			this.tabChat.Size = new System.Drawing.Size(1043, 180);
			this.tabChat.TabIndex = 2;
			this.tabChat.Text = "Chat";
			// 
			// chat
			// 
			this.chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.chat.Location = new System.Drawing.Point(0, 0);
			this.chat.Margin = new System.Windows.Forms.Padding(0);
			this.chat.Name = "chat";
			this.chat.ReadOnly = true;
			this.chat.Size = new System.Drawing.Size(1041, 178);
			this.chat.TabIndex = 3;
			this.chat.Text = "";
			this.chat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
			// 
			// tabLog
			// 
			this.tabLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabLog.Controls.Add(this.logs);
			this.tabLog.Location = new System.Drawing.Point(46, 4);
			this.tabLog.Name = "tabLog";
			this.tabLog.Size = new System.Drawing.Size(1043, 180);
			this.tabLog.TabIndex = 3;
			this.tabLog.Text = "Log";
			// 
			// logs
			// 
			this.logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.logs.Location = new System.Drawing.Point(0, 0);
			this.logs.Margin = new System.Windows.Forms.Padding(0);
			this.logs.Name = "logs";
			this.logs.ReadOnly = true;
			this.logs.Size = new System.Drawing.Size(1041, 178);
			this.logs.TabIndex = 3;
			this.logs.Text = "";
			this.logs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.console_MouseDown);
			//  
			#endregion
			#region Search/Filter
			// search
			// 
			this.search.Location = new System.Drawing.Point(196, 1);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(337, 22);
			this.search.TabIndex = 13;
			this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
			this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(533, -3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(83, 26);
			this.searchButton.TabIndex = 20;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// autoRefresh
			// 
			this.autoRefresh.AutoSize = true;
			this.autoRefresh.Location = new System.Drawing.Point(787, 4);
			this.autoRefresh.Name = "autoRefresh";
			this.autoRefresh.Size = new System.Drawing.Size(113, 21);
			this.autoRefresh.TabIndex = 15;
			this.autoRefresh.Text = "Auto Refresh";
			this.autoRefresh.UseVisualStyleBackColor = true;
			// 
			
			// filter
			// 
			this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filter.FormattingEnabled = true;
			this.filter.Location = new System.Drawing.Point(54, 0);
			this.filter.Name = "filter";
			this.filter.Size = new System.Drawing.Size(136, 24);
			this.filter.TabIndex = 14;
			this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Location = new System.Drawing.Point(-3, 5);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(57, 17);
			this.searchLabel.TabIndex = 12;
			this.searchLabel.Text = "Search:"; 
			#endregion
			// 
			// input
			// 
			#region Input
			this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.input.AutoCompleteCustomSource.AddRange(new string[] {
			"ban",
			"addBan",
			"removeBan",
			"writeBans",
			"loadScripts",
			"missions",
			"kick",
			"RConPassword",
			"MaxPing",
			"say",
			"update"});
			this.input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.input.Enabled = false;
			this.input.Location = new System.Drawing.Point(145, 215);
			this.input.MaxLength = 400;
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(583, 22);
			this.input.TabIndex = 2;
			this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
			this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);

			#endregion
			#region Options

			// options
			// 
			this.options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.options.FormattingEnabled = true;
			this.options.Visible = true;
			this.options.Enabled = true;
			this.options.BringToFront();
			this.options.ResumeLayout();
			this.options.Items.AddRange(new object[] {
			"Say Global",
			"Console"});
			this.options.Location = new System.Drawing.Point(3, 214);
			this.options.Name = "options";
			this.options.Size = new System.Drawing.Size(86, 24);
			this.options.TabIndex = 3;
			this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged); 
			#endregion
			// 
			// timer
			// 
			//this.timer.Interval = 1000;
			//this.timer.Tick += new System.EventHandler(this.timer_Tick);
			#region DataBindings
			// Dark mode shit fml
			this.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.adminCounter.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.allowMessages.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.autoRefresh.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.banCounter.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.chat.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			//this.chatContextMenu.DataBindings.Add(new Binding("ForeColor", Program.ColorChangeshitBackGround, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			//this.adminCounter.Add(new Binding("")
			this.connect.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.connect.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.console.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.console.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.counter.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			//this.executeContextMenu.DataBindings.Add(new Binding("BackColor", Program.ColorChangeshitBackGround, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.filter.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.filter.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.host.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.host.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.hostLabel.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.hosts.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.hosts.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.input.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.input.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.lastRefresh.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.password.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.password.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.passwordLabel.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerCounter.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerCounter.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.port.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.port.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.portLabel.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.portLabel.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.refresh.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.refresh.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.searchButton.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.searchButton.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.search.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.search.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.searchLabel.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.searchLabel.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.settings.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.settings.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.splitContainer1.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.splitContainer1.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.splitContainer2.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.splitContainer2.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabAll.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabAll.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabChat.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabChat.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabConsole.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabConsole.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.AdminListTab.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.AdminListTab.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabLog.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabLog.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.execute.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.execute.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.disconnect.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.disconnect.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.button1.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.button1.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[0].DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[1].DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[2].DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[0].DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[1].DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			AdminsTab.Controls[2].DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerList.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerList.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabAll.Controls[0].DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.tabAll.Controls[0].DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.logs.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.logs.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.bansList.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.bansList.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerDBList.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.playerDBList.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.adminList.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.adminList.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.globalbans.DataBindings.Add(new Binding("BackColor", Program.UIBackGroundColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			this.globalbans.DataBindings.Add(new Binding("ForeColor", Program.UITextColor, "color", false, DataSourceUpdateMode.OnPropertyChanged));
			#endregion
			#region GUI Main
			// 
			// GUI Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1229, 571);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1000, 610);
			this.Name = "GUImain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rcon Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
			this.Load += new System.EventHandler(this.GUI_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.AdminsTab.ResumeLayout(false);
			this.playersTab.ResumeLayout(false);
			this.bansTab.ResumeLayout(false);
			this.playerdatabaseTab.ResumeLayout(false);
			this.logTabs.ResumeLayout(false);
			this.tabAll.ResumeLayout(false);
			this.tabConsole.ResumeLayout(false);
			this.tabChat.ResumeLayout(false);
			this.tabLog.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
			this.ResumeLayout(false);
			#endregion
		}

#endregion
		#region Variables
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.Label hostLabel;
		private System.Windows.Forms.Button disconnect;
		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.PictureBox banner;
		private System.Windows.Forms.ComboBox options;
		private System.Windows.Forms.Label lastRefresh;
		private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.ComboBox filter;
		private System.Windows.Forms.CheckBox autoRefresh;
		private ExtendedRichTextBox all;
		public System.Windows.Forms.Button connect;
		private System.Windows.Forms.Button settings;
		private System.Windows.Forms.Label banCounter;
		private System.Windows.Forms.Label playerCounter;
		private System.Windows.Forms.Label adminCounter;
		public System.Windows.Forms.TextBox password;
		public System.Windows.Forms.TextBox port;
		public System.Windows.Forms.TextBox host;
		private System.Windows.Forms.Label news;
		private System.Windows.Forms.Button execute;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.TabControl logTabs;
		private System.Windows.Forms.TabPage tabAll;
		private System.Windows.Forms.TabPage tabConsole;
		private System.Windows.Forms.TabPage tabChat;
		private System.Windows.Forms.TabPage tabLog;
		private ExtendedRichTextBox console;
		private ExtendedRichTextBox chat;
		private ExtendedRichTextBox logs;
		public System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Label counter;
		private System.Windows.Forms.TabControl AdminsTab;
		private TabPage globalbans;
		private System.Windows.Forms.TabPage playersTab;
		private System.Windows.Forms.ListView playerList;
		private System.Windows.Forms.ListView adminList;
		private System.Windows.Forms.TabPage bansTab;
		private System.Windows.Forms.ListView bansList;
		private System.Windows.Forms.TabPage playerdatabaseTab;
		private System.Windows.Forms.ListView playerDBList;
		private System.Windows.Forms.TabPage AdminListTab;
		private System.Windows.Forms.CheckBox allowMessages;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button hosts;
		private ListView globalbanlist;
		#endregion
	}
}

