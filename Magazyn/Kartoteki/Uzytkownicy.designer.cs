namespace Magazyn.Kartoteki
{
    partial class Uzytkownicy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uzytkownicy));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Przycisk_Wybierz = new DevExpress.XtraEditors.SimpleButton();
            this.Lista = new DevExpress.XtraGrid.GridControl();
            this.Dane = new DevExpress.Xpo.XPCollection(this.components);
            this.WidokListy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNieaktywny = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.Przycisk_Odswiez = new DevExpress.XtraBars.BarButtonItem();
            this.Przycisk_Dodaj = new DevExpress.XtraBars.BarButtonItem();
            this.Przycisk_Edytuj = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.Przycisk_EksportXLS = new DevExpress.XtraBars.BarButtonItem();
            this.Przycisk_ExsportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.sbZapiszListe = new DevExpress.XtraBars.BarButtonItem();
            this.sbZapiszListeDlaWielu = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.sbPodgladEtykieta = new DevExpress.XtraBars.BarButtonItem();
            this.sbDrukujEtykieta = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Przycisk_Anuluj = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlWybierz = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlAnuluj = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidokListy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlWybierz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAnuluj)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Przycisk_Wybierz);
            this.layoutControl1.Controls.Add(this.Lista);
            this.layoutControl1.Controls.Add(this.Przycisk_Anuluj);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(646, 389);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Przycisk_Wybierz
            // 
            this.Przycisk_Wybierz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Wybierz.ImageOptions.Image")));
            this.Przycisk_Wybierz.Location = new System.Drawing.Point(538, 365);
            this.Przycisk_Wybierz.Name = "Przycisk_Wybierz";
            this.Przycisk_Wybierz.Size = new System.Drawing.Size(106, 22);
            this.Przycisk_Wybierz.StyleController = this.layoutControl1;
            this.Przycisk_Wybierz.TabIndex = 5;
            this.Przycisk_Wybierz.Text = "Wybierz";
            // 
            // Lista
            // 
            this.Lista.DataSource = this.Dane;
            this.Lista.Location = new System.Drawing.Point(2, 2);
            this.Lista.MainView = this.WidokListy;
            this.Lista.MenuManager = this.Menu;
            this.Lista.Name = "Lista";
            this.Lista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.Lista.ShowOnlyPredefinedDetails = true;
            this.Lista.Size = new System.Drawing.Size(642, 359);
            this.Lista.TabIndex = 4;
            this.Lista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WidokListy});
            // 
            // Dane
            // 
            this.Dane.ObjectType = typeof(Magazyn.Model.Uzytkownicy);
            // 
            // WidokListy
            // 
            this.WidokListy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogin,
            this.colNieaktywny,
            this.gridColumn1});
            this.WidokListy.GridControl = this.Lista;
            this.WidokListy.Name = "WidokListy";
            this.WidokListy.OptionsBehavior.Editable = false;
            this.WidokListy.OptionsView.ColumnAutoWidth = false;
            this.WidokListy.OptionsView.ShowAutoFilterRow = true;
            this.WidokListy.OptionsView.ShowGroupPanel = false;
            this.WidokListy.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLogin, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Nazwa";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 0;
            this.colLogin.Width = 164;
            // 
            // colNieaktywny
            // 
            this.colNieaktywny.FieldName = "Nieaktywny";
            this.colNieaktywny.Name = "colNieaktywny";
            this.colNieaktywny.Visible = true;
            this.colNieaktywny.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kod kreskowy";
            this.gridColumn1.FieldName = "KodKreskowy";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 176;
            // 
            // Menu
            // 
            this.Menu.AllowCustomization = false;
            this.Menu.AllowQuickCustomization = false;
            this.Menu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.Menu.DockControls.Add(this.barDockControlTop);
            this.Menu.DockControls.Add(this.barDockControlBottom);
            this.Menu.DockControls.Add(this.barDockControlLeft);
            this.Menu.DockControls.Add(this.barDockControlRight);
            this.Menu.Form = this;
            this.Menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Przycisk_Odswiez,
            this.Przycisk_Dodaj,
            this.Przycisk_Edytuj,
            this.barSubItem1,
            this.Przycisk_EksportXLS,
            this.Przycisk_ExsportPDF,
            this.barSubItem2,
            this.sbZapiszListe,
            this.sbZapiszListeDlaWielu,
            this.barSubItem3,
            this.sbPodgladEtykieta,
            this.sbDrukujEtykieta});
            this.Menu.MaxItemId = 13;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Przycisk_Odswiez, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Przycisk_Dodaj, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Przycisk_Edytuj, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // Przycisk_Odswiez
            // 
            this.Przycisk_Odswiez.Caption = "Odśwież";
            this.Przycisk_Odswiez.Id = 0;
            this.Przycisk_Odswiez.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Odswiez.ImageOptions.Image")));
            this.Przycisk_Odswiez.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Przycisk_Odswiez.ImageOptions.LargeImage")));
            this.Przycisk_Odswiez.Name = "Przycisk_Odswiez";
            this.Przycisk_Odswiez.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Przycisk_Odswiez_ItemClick);
            // 
            // Przycisk_Dodaj
            // 
            this.Przycisk_Dodaj.Caption = "Dodaj";
            this.Przycisk_Dodaj.Id = 1;
            this.Przycisk_Dodaj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Dodaj.ImageOptions.Image")));
            this.Przycisk_Dodaj.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Przycisk_Dodaj.ImageOptions.LargeImage")));
            this.Przycisk_Dodaj.Name = "Przycisk_Dodaj";
            this.Przycisk_Dodaj.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Przycisk_Dodaj_ItemClick);
            // 
            // Przycisk_Edytuj
            // 
            this.Przycisk_Edytuj.Caption = "Edytuj";
            this.Przycisk_Edytuj.Id = 2;
            this.Przycisk_Edytuj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Edytuj.ImageOptions.Image")));
            this.Przycisk_Edytuj.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Przycisk_Edytuj.ImageOptions.LargeImage")));
            this.Przycisk_Edytuj.Name = "Przycisk_Edytuj";
            this.Przycisk_Edytuj.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Przycisk_Edytuj_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Eksportuj";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Przycisk_EksportXLS),
            new DevExpress.XtraBars.LinkPersistInfo(this.Przycisk_ExsportPDF)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // Przycisk_EksportXLS
            // 
            this.Przycisk_EksportXLS.Caption = "Eksport *.xls";
            this.Przycisk_EksportXLS.Id = 5;
            this.Przycisk_EksportXLS.Name = "Przycisk_EksportXLS";
            // 
            // Przycisk_ExsportPDF
            // 
            this.Przycisk_ExsportPDF.Caption = "Eksport *.pdf";
            this.Przycisk_ExsportPDF.Id = 6;
            this.Przycisk_ExsportPDF.Name = "Przycisk_ExsportPDF";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Ustawienia listy";
            this.barSubItem2.Id = 7;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sbZapiszListe),
            new DevExpress.XtraBars.LinkPersistInfo(this.sbZapiszListeDlaWielu)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // sbZapiszListe
            // 
            this.sbZapiszListe.Caption = "Zapisz ustawienia listy";
            this.sbZapiszListe.Id = 8;
            this.sbZapiszListe.Name = "sbZapiszListe";
            // 
            // sbZapiszListeDlaWielu
            // 
            this.sbZapiszListeDlaWielu.Caption = "Zapisz ustawienia listy dla wielu użytkowników";
            this.sbZapiszListeDlaWielu.Id = 9;
            this.sbZapiszListeDlaWielu.Name = "sbZapiszListeDlaWielu";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Etykieta";
            this.barSubItem3.Id = 10;
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            this.barSubItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.LargeImage")));
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sbPodgladEtykieta),
            new DevExpress.XtraBars.LinkPersistInfo(this.sbDrukujEtykieta)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // sbPodgladEtykieta
            // 
            this.sbPodgladEtykieta.Caption = "Podgląd";
            this.sbPodgladEtykieta.Id = 11;
            this.sbPodgladEtykieta.Name = "sbPodgladEtykieta";
            // 
            // sbDrukujEtykieta
            // 
            this.sbDrukujEtykieta.Caption = "Drukuj";
            this.sbDrukujEtykieta.Id = 12;
            this.sbDrukujEtykieta.Name = "sbDrukujEtykieta";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.Menu;
            this.barDockControlTop.Size = new System.Drawing.Size(646, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 420);
            this.barDockControlBottom.Manager = this.Menu;
            this.barDockControlBottom.Size = new System.Drawing.Size(646, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.Menu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(646, 31);
            this.barDockControlRight.Manager = this.Menu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // Przycisk_Anuluj
            // 
            this.Przycisk_Anuluj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Anuluj.ImageOptions.Image")));
            this.Przycisk_Anuluj.Location = new System.Drawing.Point(428, 365);
            this.Przycisk_Anuluj.Name = "Przycisk_Anuluj";
            this.Przycisk_Anuluj.Size = new System.Drawing.Size(106, 22);
            this.Przycisk_Anuluj.StyleController = this.layoutControl1;
            this.Przycisk_Anuluj.TabIndex = 5;
            this.Przycisk_Anuluj.Text = "Anuluj";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlWybierz,
            this.emptySpace,
            this.layoutControlAnuluj});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(646, 389);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Lista;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(646, 363);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlWybierz
            // 
            this.layoutControlWybierz.Control = this.Przycisk_Wybierz;
            this.layoutControlWybierz.Location = new System.Drawing.Point(536, 363);
            this.layoutControlWybierz.MaxSize = new System.Drawing.Size(110, 26);
            this.layoutControlWybierz.MinSize = new System.Drawing.Size(110, 26);
            this.layoutControlWybierz.Name = "layoutControlWybierz";
            this.layoutControlWybierz.Size = new System.Drawing.Size(110, 26);
            this.layoutControlWybierz.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlWybierz.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlWybierz.TextVisible = false;
            this.layoutControlWybierz.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpace
            // 
            this.emptySpace.AllowHotTrack = false;
            this.emptySpace.Location = new System.Drawing.Point(0, 363);
            this.emptySpace.Name = "emptySpace";
            this.emptySpace.Size = new System.Drawing.Size(426, 26);
            this.emptySpace.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpace.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlAnuluj
            // 
            this.layoutControlAnuluj.Control = this.Przycisk_Anuluj;
            this.layoutControlAnuluj.CustomizationFormText = "layoutControlItem2";
            this.layoutControlAnuluj.Location = new System.Drawing.Point(426, 363);
            this.layoutControlAnuluj.MaxSize = new System.Drawing.Size(110, 26);
            this.layoutControlAnuluj.MinSize = new System.Drawing.Size(110, 26);
            this.layoutControlAnuluj.Name = "layoutControlAnuluj";
            this.layoutControlAnuluj.Size = new System.Drawing.Size(110, 26);
            this.layoutControlAnuluj.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlAnuluj.Text = "layoutControlItem2";
            this.layoutControlAnuluj.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAnuluj.TextVisible = false;
            this.layoutControlAnuluj.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // Uzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 420);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Uzytkownicy";
            this.Text = "Użytkownicy";
            this.Load += new System.EventHandler(this.Uzytkownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidokListy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlWybierz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAnuluj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpace;
        private DevExpress.XtraBars.BarManager Menu;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem Przycisk_Odswiez;
        private DevExpress.XtraBars.BarButtonItem Przycisk_Dodaj;
        private DevExpress.XtraBars.BarButtonItem Przycisk_Edytuj;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem Przycisk_EksportXLS;
        private DevExpress.XtraBars.BarButtonItem Przycisk_ExsportPDF;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton Przycisk_Wybierz;
        private DevExpress.XtraGrid.GridControl Lista;
        private DevExpress.XtraGrid.Views.Grid.GridView WidokListy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlWybierz;
        private DevExpress.XtraEditors.SimpleButton Przycisk_Anuluj;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAnuluj;
        private DevExpress.Xpo.XPCollection Dane;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colNieaktywny;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem sbZapiszListe;
        private DevExpress.XtraBars.BarButtonItem sbZapiszListeDlaWielu;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem sbPodgladEtykieta;
        private DevExpress.XtraBars.BarButtonItem sbDrukujEtykieta;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}