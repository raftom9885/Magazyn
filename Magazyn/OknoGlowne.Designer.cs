namespace Magazyn
{
    partial class OknoGlowne
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.KrojczeTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.KrawcoweTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SlownikiTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.RaportyBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.UstawieniaTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sbKrojczaZwrot = new DevExpress.XtraEditors.SimpleButton();
            this.sbKrojczaPobierz = new DevExpress.XtraEditors.SimpleButton();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sbKrawcowaZwrot = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sbSlownikiWykroje = new DevExpress.XtraEditors.SimpleButton();
            this.sbSlownikiMaterialy = new DevExpress.XtraEditors.SimpleButton();
            this.sbSlownikiPracownicy = new DevExpress.XtraEditors.SimpleButton();
            this.sbSlownikiMagazynTkanin = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sbRaportKrojcza = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sbUstawieniaBazyDanych = new DevExpress.XtraEditors.SimpleButton();
            this.sbRaportKrawcowa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage3.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 7;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(770, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.KrojczeTileBarItem);
            this.tileBarGroupTables.Items.Add(this.KrawcoweTileBarItem);
            this.tileBarGroupTables.Items.Add(this.SlownikiTileBarItem);
            this.tileBarGroupTables.Items.Add(this.RaportyBarItem);
            this.tileBarGroupTables.Items.Add(this.UstawieniaTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // KrojczeTileBarItem
            // 
            this.KrojczeTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.Text = "Krojcze";
            this.KrojczeTileBarItem.Elements.Add(tileItemElement1);
            this.KrojczeTileBarItem.Id = 2;
            this.KrojczeTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.KrojczeTileBarItem.Name = "KrojczeTileBarItem";
            // 
            // KrawcoweTileBarItem
            // 
            this.KrawcoweTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.Text = "Krawcowe";
            this.KrawcoweTileBarItem.Elements.Add(tileItemElement2);
            this.KrawcoweTileBarItem.Id = 3;
            this.KrawcoweTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.KrawcoweTileBarItem.Name = "KrawcoweTileBarItem";
            // 
            // SlownikiTileBarItem
            // 
            this.SlownikiTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.Text = "Słowniki";
            this.SlownikiTileBarItem.Elements.Add(tileItemElement3);
            this.SlownikiTileBarItem.Id = 4;
            this.SlownikiTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.SlownikiTileBarItem.Name = "SlownikiTileBarItem";
            // 
            // RaportyBarItem
            // 
            this.RaportyBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.Text = "Raporty";
            this.RaportyBarItem.Elements.Add(tileItemElement4);
            this.RaportyBarItem.Id = 6;
            this.RaportyBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RaportyBarItem.Name = "RaportyBarItem";
            // 
            // UstawieniaTileBarItem
            // 
            this.UstawieniaTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.Text = "Ustawienia";
            this.UstawieniaTileBarItem.Elements.Add(tileItemElement5);
            this.UstawieniaTileBarItem.Id = 5;
            this.UstawieniaTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.UstawieniaTileBarItem.Name = "UstawieniaTileBarItem";
            this.UstawieniaTileBarItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.UstawieniaTileBarItem_ItemClick);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Controls.Add(this.navigationPage3);
            this.navigationFrame.Controls.Add(this.navigationPage2);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage,
            this.navigationPage1,
            this.navigationPage3,
            this.navigationPage2});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(770, 451);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.sbKrojczaZwrot);
            this.employeesNavigationPage.Controls.Add(this.sbKrojczaPobierz);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(770, 451);
            // 
            // sbKrojczaZwrot
            // 
            this.sbKrojczaZwrot.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbKrojczaZwrot.Location = new System.Drawing.Point(0, 80);
            this.sbKrojczaZwrot.Name = "sbKrojczaZwrot";
            this.sbKrojczaZwrot.Size = new System.Drawing.Size(770, 80);
            this.sbKrojczaZwrot.TabIndex = 1;
            this.sbKrojczaZwrot.Text = "Zwróć wykroje";
            this.sbKrojczaZwrot.Click += new System.EventHandler(this.sbKrojczaZwrot_Click);
            // 
            // sbKrojczaPobierz
            // 
            this.sbKrojczaPobierz.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbKrojczaPobierz.Location = new System.Drawing.Point(0, 0);
            this.sbKrojczaPobierz.Name = "sbKrojczaPobierz";
            this.sbKrojczaPobierz.Size = new System.Drawing.Size(770, 80);
            this.sbKrojczaPobierz.TabIndex = 0;
            this.sbKrojczaPobierz.Text = "Pobierz tkaninę";
            this.sbKrojczaPobierz.Click += new System.EventHandler(this.sbKrojczaPobierz_Click);
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.sbKrawcowaZwrot);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(770, 451);
            // 
            // sbKrawcowaZwrot
            // 
            this.sbKrawcowaZwrot.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbKrawcowaZwrot.Location = new System.Drawing.Point(0, 0);
            this.sbKrawcowaZwrot.Name = "sbKrawcowaZwrot";
            this.sbKrawcowaZwrot.Size = new System.Drawing.Size(770, 80);
            this.sbKrawcowaZwrot.TabIndex = 1;
            this.sbKrawcowaZwrot.Text = "Zwrot poszewek";
            this.sbKrawcowaZwrot.Click += new System.EventHandler(this.sbKrawcowaZwrot_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.AllowTouchScroll = true;
            this.navigationPage1.AutoScroll = true;
            this.navigationPage1.Controls.Add(this.sbSlownikiWykroje);
            this.navigationPage1.Controls.Add(this.sbSlownikiMaterialy);
            this.navigationPage1.Controls.Add(this.sbSlownikiPracownicy);
            this.navigationPage1.Controls.Add(this.sbSlownikiMagazynTkanin);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(770, 451);
            // 
            // sbSlownikiWykroje
            // 
            this.sbSlownikiWykroje.AutoSize = true;
            this.sbSlownikiWykroje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sbSlownikiWykroje.Location = new System.Drawing.Point(0, 385);
            this.sbSlownikiWykroje.Name = "sbSlownikiWykroje";
            this.sbSlownikiWykroje.Size = new System.Drawing.Size(770, 22);
            this.sbSlownikiWykroje.TabIndex = 7;
            this.sbSlownikiWykroje.Text = "Wykroje";
            this.sbSlownikiWykroje.Click += new System.EventHandler(this.sbSlownikiWykroje_Click);
            // 
            // sbSlownikiMaterialy
            // 
            this.sbSlownikiMaterialy.AutoSize = true;
            this.sbSlownikiMaterialy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sbSlownikiMaterialy.Location = new System.Drawing.Point(0, 407);
            this.sbSlownikiMaterialy.Name = "sbSlownikiMaterialy";
            this.sbSlownikiMaterialy.Size = new System.Drawing.Size(770, 22);
            this.sbSlownikiMaterialy.TabIndex = 6;
            this.sbSlownikiMaterialy.Text = "Materiały";
            this.sbSlownikiMaterialy.Click += new System.EventHandler(this.sbSlownikiMaterialy_Click);
            // 
            // sbSlownikiPracownicy
            // 
            this.sbSlownikiPracownicy.AutoSize = true;
            this.sbSlownikiPracownicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sbSlownikiPracownicy.Location = new System.Drawing.Point(0, 429);
            this.sbSlownikiPracownicy.Name = "sbSlownikiPracownicy";
            this.sbSlownikiPracownicy.Size = new System.Drawing.Size(770, 22);
            this.sbSlownikiPracownicy.TabIndex = 5;
            this.sbSlownikiPracownicy.Text = "Pracownicy";
            this.sbSlownikiPracownicy.Click += new System.EventHandler(this.sbSlownikiPracownicy_Click);
            // 
            // sbSlownikiMagazynTkanin
            // 
            this.sbSlownikiMagazynTkanin.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbSlownikiMagazynTkanin.Location = new System.Drawing.Point(0, 0);
            this.sbSlownikiMagazynTkanin.Name = "sbSlownikiMagazynTkanin";
            this.sbSlownikiMagazynTkanin.Size = new System.Drawing.Size(770, 80);
            this.sbSlownikiMagazynTkanin.TabIndex = 3;
            this.sbSlownikiMagazynTkanin.Text = "Magazyn tkanin";
            this.sbSlownikiMagazynTkanin.Click += new System.EventHandler(this.sbSlownikiMagazynTkanin_Click);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Controls.Add(this.sbRaportKrawcowa);
            this.navigationPage3.Controls.Add(this.sbRaportKrojcza);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(770, 451);
            // 
            // sbRaportKrojcza
            // 
            this.sbRaportKrojcza.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbRaportKrojcza.Location = new System.Drawing.Point(0, 0);
            this.sbRaportKrojcza.Name = "sbRaportKrojcza";
            this.sbRaportKrojcza.Size = new System.Drawing.Size(770, 80);
            this.sbRaportKrojcza.TabIndex = 1;
            this.sbRaportKrojcza.Text = "Raport - krojcza";
            this.sbRaportKrojcza.Click += new System.EventHandler(this.sbRaportKrojcza_Click);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.sbUstawieniaBazyDanych);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(770, 451);
            // 
            // sbUstawieniaBazyDanych
            // 
            this.sbUstawieniaBazyDanych.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbUstawieniaBazyDanych.Location = new System.Drawing.Point(0, 0);
            this.sbUstawieniaBazyDanych.Name = "sbUstawieniaBazyDanych";
            this.sbUstawieniaBazyDanych.Size = new System.Drawing.Size(770, 80);
            this.sbUstawieniaBazyDanych.TabIndex = 0;
            this.sbUstawieniaBazyDanych.Text = "Ustawienia bazy danych i folderów";
            this.sbUstawieniaBazyDanych.Click += new System.EventHandler(this.sbUstawieniaBazyDanych_Click);
            // 
            // sbRaportKrawcowa
            // 
            this.sbRaportKrawcowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbRaportKrawcowa.Location = new System.Drawing.Point(0, 80);
            this.sbRaportKrawcowa.Name = "sbRaportKrawcowa";
            this.sbRaportKrawcowa.Size = new System.Drawing.Size(770, 80);
            this.sbRaportKrawcowa.TabIndex = 2;
            this.sbRaportKrawcowa.Text = "Raport - krawcowa";
            this.sbRaportKrawcowa.Click += new System.EventHandler(this.sbRaportKrawcowa_Click);
            // 
            // OknoGlowne
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(770, 561);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.KeyPreview = true;
            this.Name = "OknoGlowne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OknoGlowne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem KrojczeTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraBars.Navigation.TileBarItem KrawcoweTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem SlownikiTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem UstawieniaTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SimpleButton sbKrojczaZwrot;
        private DevExpress.XtraEditors.SimpleButton sbKrojczaPobierz;
        private DevExpress.XtraEditors.SimpleButton sbKrawcowaZwrot;
        private DevExpress.XtraEditors.SimpleButton sbSlownikiMagazynTkanin;
        private DevExpress.XtraEditors.SimpleButton sbSlownikiWykroje;
        private DevExpress.XtraEditors.SimpleButton sbSlownikiMaterialy;
        private DevExpress.XtraEditors.SimpleButton sbSlownikiPracownicy;
        private DevExpress.XtraEditors.SimpleButton sbUstawieniaBazyDanych;
        private DevExpress.XtraBars.Navigation.TileBarItem RaportyBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraEditors.SimpleButton sbRaportKrojcza;
        private DevExpress.XtraEditors.SimpleButton sbRaportKrawcowa;
    }
}