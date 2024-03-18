namespace Magazyn.Krojcza
{
    partial class KrojczaPobranie
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
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.chBelaUkonczona = new DevExpress.XtraEditors.CheckEdit();
            this.caIlosc = new DevExpress.XtraEditors.CalcEdit();
            this.teKodKreskowy = new DevExpress.XtraEditors.TextEdit();
            this.Lista = new DevExpress.XtraGrid.GridControl();
            this.DaneBele = new DevExpress.Xpo.XPCollection(this.components);
            this.WidokListy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKodKreskowy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSzerokosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDlugosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dymek = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chBelaUkonczona.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caIlosc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaneBele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidokListy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.chBelaUkonczona);
            this.layoutControl.Controls.Add(this.caIlosc);
            this.layoutControl.Controls.Add(this.teKodKreskowy);
            this.layoutControl.Controls.Add(this.Lista);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(784, 501);
            this.layoutControl.TabIndex = 1;
            // 
            // chBelaUkonczona
            // 
            this.chBelaUkonczona.Location = new System.Drawing.Point(646, 2);
            this.chBelaUkonczona.Name = "chBelaUkonczona";
            this.chBelaUkonczona.Properties.Caption = "Bela ukończona";
            this.chBelaUkonczona.Size = new System.Drawing.Size(96, 19);
            this.chBelaUkonczona.StyleController = this.layoutControl;
            this.chBelaUkonczona.TabIndex = 7;
            // 
            // caIlosc
            // 
            this.caIlosc.Location = new System.Drawing.Point(513, 2);
            this.caIlosc.Name = "caIlosc";
            this.caIlosc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caIlosc.Size = new System.Drawing.Size(129, 20);
            this.caIlosc.StyleController = this.layoutControl;
            this.caIlosc.TabIndex = 6;
            // 
            // teKodKreskowy
            // 
            this.teKodKreskowy.Location = new System.Drawing.Point(174, 2);
            this.teKodKreskowy.Name = "teKodKreskowy";
            this.teKodKreskowy.Size = new System.Drawing.Size(283, 20);
            this.teKodKreskowy.StyleController = this.layoutControl;
            this.teKodKreskowy.TabIndex = 5;
            // 
            // Lista
            // 
            this.Lista.DataSource = this.DaneBele;
            this.Lista.Location = new System.Drawing.Point(40, 24);
            this.Lista.MainView = this.WidokListy;
            this.Lista.Name = "Lista";
            this.Lista.ShowOnlyPredefinedDetails = true;
            this.Lista.Size = new System.Drawing.Size(704, 477);
            this.Lista.TabIndex = 2;
            this.Lista.ToolTipController = this.Dymek;
            this.Lista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WidokListy});
            // 
            // DaneBele
            // 
            this.DaneBele.CriteriaString = "[Ukonczona] = False";
            this.DaneBele.ObjectType = typeof(Magazyn.Model.Bela);
            // 
            // WidokListy
            // 
            this.WidokListy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKodKreskowy,
            this.gridColumn1,
            this.colSzerokosc,
            this.colDlugosc});
            this.WidokListy.GridControl = this.Lista;
            this.WidokListy.Name = "WidokListy";
            this.WidokListy.OptionsBehavior.Editable = false;
            this.WidokListy.OptionsCustomization.AllowColumnMoving = false;
            this.WidokListy.OptionsCustomization.AllowGroup = false;
            this.WidokListy.OptionsCustomization.AllowQuickHideColumns = false;
            this.WidokListy.OptionsMenu.EnableColumnMenu = false;
            this.WidokListy.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.WidokListy.OptionsSelection.MultiSelect = true;
            this.WidokListy.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.WidokListy.OptionsView.ShowAutoFilterRow = true;
            this.WidokListy.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.WidokListy.OptionsView.ShowGroupPanel = false;
            this.WidokListy.OptionsView.ShowIndicator = false;
            // 
            // colKodKreskowy
            // 
            this.colKodKreskowy.FieldName = "KodKreskowy";
            this.colKodKreskowy.Name = "colKodKreskowy";
            this.colKodKreskowy.Visible = true;
            this.colKodKreskowy.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Materiał";
            this.gridColumn1.FieldName = "Material.Nazwa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // colSzerokosc
            // 
            this.colSzerokosc.Caption = "Szerokość";
            this.colSzerokosc.FieldName = "Szerokosc";
            this.colSzerokosc.Name = "colSzerokosc";
            this.colSzerokosc.Visible = true;
            this.colSzerokosc.VisibleIndex = 3;
            // 
            // colDlugosc
            // 
            this.colDlugosc.Caption = "Długość";
            this.colDlugosc.FieldName = "Dlugosc";
            this.colDlugosc.Name = "colDlugosc";
            this.colDlugosc.Visible = true;
            this.colDlugosc.VisibleIndex = 4;
            // 
            // Dymek
            // 
            this.Dymek.AllowHtmlText = true;
            this.Dymek.AutoPopDelay = 30000;
            this.Dymek.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.Dymek_GetActiveObjectInfo);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemGrid,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 501);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.Lista;
            this.itemGrid.Location = new System.Drawing.Point(0, 24);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(704, 477);
            this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.itemGrid.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teKodKreskowy;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem1.Text = "Użytkownik - kod kreskowy";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.caIlosc;
            this.layoutControlItem2.Location = new System.Drawing.Point(419, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(185, 24);
            this.layoutControlItem2.Text = "Ilość [mb]";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(47, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chBelaUkonczona;
            this.layoutControlItem3.Location = new System.Drawing.Point(604, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            windowsUIButtonImageOptions2.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Zapisz", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Pobierz", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Zamknij", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Zamknij", -1, false)});
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 501);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(784, 60);
            this.windowsUIButtonPanel.TabIndex = 5;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // KrojczaPobranie
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.KeyPreview = true;
            this.Name = "KrojczaPobranie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chBelaUkonczona.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caIlosc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaneBele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidokListy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl Lista;
        private DevExpress.XtraGrid.Views.Grid.GridView WidokListy;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private DevExpress.XtraEditors.CalcEdit caIlosc;
        private DevExpress.XtraEditors.TextEdit teKodKreskowy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Xpo.XPCollection DaneBele;
        private DevExpress.XtraGrid.Columns.GridColumn colKodKreskowy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSzerokosc;
        private DevExpress.XtraGrid.Columns.GridColumn colDlugosc;
        private DevExpress.Utils.ToolTipController Dymek;
        private DevExpress.XtraEditors.CheckEdit chBelaUkonczona;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}