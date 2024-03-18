namespace Magazyn.Towar
{
    partial class BelaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelaEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.caDlugosc = new DevExpress.XtraEditors.CalcEdit();
            this.caSzerokosc = new DevExpress.XtraEditors.CalcEdit();
            this.teKodKreskowy = new DevExpress.XtraEditors.TextEdit();
            this.Przycisk_Zapisz = new DevExpress.XtraEditors.SimpleButton();
            this.Przycisk_Anuluj = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbMaterial = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaneMaterial = new DevExpress.Xpo.XPCollection(this.components);
            this.chUkonczona = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caDlugosc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSzerokosc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaneMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chUkonczona.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chUkonczona);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.cmbMaterial);
            this.layoutControl1.Controls.Add(this.caDlugosc);
            this.layoutControl1.Controls.Add(this.caSzerokosc);
            this.layoutControl1.Controls.Add(this.teKodKreskowy);
            this.layoutControl1.Controls.Add(this.Przycisk_Zapisz);
            this.layoutControl1.Controls.Add(this.Przycisk_Anuluj);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(834, 162, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(448, 362);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // caDlugosc
            // 
            this.caDlugosc.Location = new System.Drawing.Point(296, 31);
            this.caDlugosc.Name = "caDlugosc";
            this.caDlugosc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caDlugosc.Properties.DisplayFormat.FormatString = "f2";
            this.caDlugosc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caDlugosc.Properties.EditFormat.FormatString = "f2";
            this.caDlugosc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caDlugosc.Properties.Mask.EditMask = "f2";
            this.caDlugosc.Properties.Precision = 2;
            this.caDlugosc.Size = new System.Drawing.Size(145, 20);
            this.caDlugosc.StyleController = this.layoutControl1;
            this.caDlugosc.TabIndex = 7;
            // 
            // caSzerokosc
            // 
            this.caSzerokosc.Location = new System.Drawing.Point(77, 31);
            this.caSzerokosc.Name = "caSzerokosc";
            this.caSzerokosc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caSzerokosc.Properties.DisplayFormat.FormatString = "f2";
            this.caSzerokosc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caSzerokosc.Properties.EditFormat.FormatString = "f2";
            this.caSzerokosc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caSzerokosc.Properties.Mask.EditMask = "f2";
            this.caSzerokosc.Properties.Precision = 2;
            this.caSzerokosc.Size = new System.Drawing.Size(145, 20);
            this.caSzerokosc.StyleController = this.layoutControl1;
            this.caSzerokosc.TabIndex = 6;
            // 
            // teKodKreskowy
            // 
            this.teKodKreskowy.Location = new System.Drawing.Point(77, 7);
            this.teKodKreskowy.Name = "teKodKreskowy";
            this.teKodKreskowy.Size = new System.Drawing.Size(286, 20);
            this.teKodKreskowy.StyleController = this.layoutControl1;
            this.teKodKreskowy.TabIndex = 5;
            // 
            // Przycisk_Zapisz
            // 
            this.Przycisk_Zapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Przycisk_Zapisz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Zapisz.ImageOptions.Image")));
            this.Przycisk_Zapisz.Location = new System.Drawing.Point(338, 333);
            this.Przycisk_Zapisz.Name = "Przycisk_Zapisz";
            this.Przycisk_Zapisz.Size = new System.Drawing.Size(103, 22);
            this.Przycisk_Zapisz.StyleController = this.layoutControl1;
            this.Przycisk_Zapisz.TabIndex = 4;
            this.Przycisk_Zapisz.Text = "Zapisz";
            this.Przycisk_Zapisz.Click += new System.EventHandler(this.Przycisk_Zapisz_Click);
            // 
            // Przycisk_Anuluj
            // 
            this.Przycisk_Anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Przycisk_Anuluj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Anuluj.ImageOptions.Image")));
            this.Przycisk_Anuluj.Location = new System.Drawing.Point(231, 333);
            this.Przycisk_Anuluj.Name = "Przycisk_Anuluj";
            this.Przycisk_Anuluj.Size = new System.Drawing.Size(103, 22);
            this.Przycisk_Anuluj.StyleController = this.layoutControl1;
            this.Przycisk_Anuluj.TabIndex = 4;
            this.Przycisk_Anuluj.Text = "Anuluj";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(448, 362);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Przycisk_Anuluj;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(224, 326);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(107, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(107, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem1";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Przycisk_Zapisz;
            this.layoutControlItem1.Location = new System.Drawing.Point(331, 326);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(107, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(107, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 326);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(224, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teKodKreskowy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.Text = "Kod kreskowy";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.caSzerokosc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(219, 24);
            this.layoutControlItem4.Text = "Szerokość [m]";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.caDlugosc;
            this.layoutControlItem5.Location = new System.Drawing.Point(219, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(219, 24);
            this.layoutControlItem5.Text = "Długość [m]";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Location = new System.Drawing.Point(77, 55);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaterial.Properties.DataSource = this.DaneMaterial;
            this.cmbMaterial.Properties.DisplayMember = "Nazwa";
            this.cmbMaterial.Properties.NullText = "";
            this.cmbMaterial.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbMaterial.Properties.ValueMember = "Id";
            this.cmbMaterial.Size = new System.Drawing.Size(364, 20);
            this.cmbMaterial.StyleController = this.layoutControl1;
            this.cmbMaterial.TabIndex = 8;
            this.cmbMaterial.EditValueChanged += new System.EventHandler(this.cmbMaterial_EditValueChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbMaterial;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem6.Text = "Materiał";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(67, 13);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(7, 79);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(434, 250);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 9;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.pictureEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(438, 254);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nazwa";
            this.gridColumn1.FieldName = "Nazwa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // DaneMaterial
            // 
            this.DaneMaterial.ObjectType = typeof(Magazyn.Model.Material);
            // 
            // chUkonczona
            // 
            this.chUkonczona.Location = new System.Drawing.Point(367, 7);
            this.chUkonczona.Name = "chUkonczona";
            this.chUkonczona.Properties.Caption = "Ukończona";
            this.chUkonczona.Size = new System.Drawing.Size(74, 19);
            this.chUkonczona.StyleController = this.layoutControl1;
            this.chUkonczona.TabIndex = 10;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chUkonczona;
            this.layoutControlItem8.Location = new System.Drawing.Point(360, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(78, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // BelaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 362);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "BelaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bela";
            this.Load += new System.EventHandler(this.BelaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caDlugosc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSzerokosc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaneMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chUkonczona.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton Przycisk_Zapisz;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton Przycisk_Anuluj;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit teKodKreskowy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CalcEdit caDlugosc;
        private DevExpress.XtraEditors.CalcEdit caSzerokosc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.Xpo.XPCollection DaneMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.CheckEdit chUkonczona;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}