namespace Magazyn.Kartoteki
{
    partial class WykrojeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WykrojeEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teNazwa = new DevExpress.XtraEditors.TextEdit();
            this.Przycisk_Zapisz = new DevExpress.XtraEditors.SimpleButton();
            this.Przycisk_Anuluj = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.caSzerokosc = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.caWysokosc = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNazwa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSzerokosc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caWysokosc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.caWysokosc);
            this.layoutControl1.Controls.Add(this.caSzerokosc);
            this.layoutControl1.Controls.Add(this.teNazwa);
            this.layoutControl1.Controls.Add(this.Przycisk_Zapisz);
            this.layoutControl1.Controls.Add(this.Przycisk_Anuluj);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(834, 162, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(448, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teNazwa
            // 
            this.teNazwa.Location = new System.Drawing.Point(82, 7);
            this.teNazwa.Name = "teNazwa";
            this.teNazwa.Size = new System.Drawing.Size(359, 20);
            this.teNazwa.StyleController = this.layoutControl1;
            this.teNazwa.TabIndex = 5;
            // 
            // Przycisk_Zapisz
            // 
            this.Przycisk_Zapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Przycisk_Zapisz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Zapisz.ImageOptions.Image")));
            this.Przycisk_Zapisz.Location = new System.Drawing.Point(338, 93);
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
            this.Przycisk_Anuluj.Location = new System.Drawing.Point(231, 93);
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
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(448, 122);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Przycisk_Anuluj;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(224, 86);
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
            this.layoutControlItem1.Location = new System.Drawing.Point(331, 86);
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 86);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(224, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teNazwa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem3.Text = "Nazwa";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(438, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // caSzerokosc
            // 
            this.caSzerokosc.Location = new System.Drawing.Point(82, 31);
            this.caSzerokosc.Name = "caSzerokosc";
            this.caSzerokosc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caSzerokosc.Properties.DisplayFormat.FormatString = "f2";
            this.caSzerokosc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caSzerokosc.Properties.EditFormat.FormatString = "f2";
            this.caSzerokosc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caSzerokosc.Properties.Mask.EditMask = "f2";
            this.caSzerokosc.Properties.Precision = 2;
            this.caSzerokosc.Size = new System.Drawing.Size(140, 20);
            this.caSzerokosc.StyleController = this.layoutControl1;
            this.caSzerokosc.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.caSzerokosc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(219, 24);
            this.layoutControlItem4.Text = "Szerokość [cm]";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
            // 
            // caWysokosc
            // 
            this.caWysokosc.Location = new System.Drawing.Point(301, 31);
            this.caWysokosc.Name = "caWysokosc";
            this.caWysokosc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caWysokosc.Properties.DisplayFormat.FormatString = "f2";
            this.caWysokosc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caWysokosc.Properties.EditFormat.FormatString = "f2";
            this.caWysokosc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.caWysokosc.Properties.Mask.EditMask = "f2";
            this.caWysokosc.Properties.Precision = 2;
            this.caWysokosc.Size = new System.Drawing.Size(140, 20);
            this.caWysokosc.StyleController = this.layoutControl1;
            this.caWysokosc.TabIndex = 7;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.caWysokosc;
            this.layoutControlItem5.Location = new System.Drawing.Point(219, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(219, 24);
            this.layoutControlItem5.Text = "Wysokość [cm]";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
            // 
            // WykrojeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 122);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "WykrojeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wykrój";
            this.Load += new System.EventHandler(this.WykrojeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNazwa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSzerokosc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caWysokosc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit teNazwa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CalcEdit caWysokosc;
        private DevExpress.XtraEditors.CalcEdit caSzerokosc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}