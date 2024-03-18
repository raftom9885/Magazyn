namespace Magazyn.Kartoteki
{
    partial class UzytkownicyEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UzytkownicyEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chNieaktywny = new DevExpress.XtraEditors.CheckEdit();
            this.teKodKreskowy = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.Przycisk_Zapisz = new DevExpress.XtraEditors.SimpleButton();
            this.Przycisk_Anuluj = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chNieaktywny.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chNieaktywny);
            this.layoutControl1.Controls.Add(this.teKodKreskowy);
            this.layoutControl1.Controls.Add(this.teLogin);
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
            // chNieaktywny
            // 
            this.chNieaktywny.Location = new System.Drawing.Point(254, 7);
            this.chNieaktywny.Name = "chNieaktywny";
            this.chNieaktywny.Properties.Caption = "Nieaktywny";
            this.chNieaktywny.Size = new System.Drawing.Size(187, 19);
            this.chNieaktywny.StyleController = this.layoutControl1;
            this.chNieaktywny.TabIndex = 9;
            // 
            // teKodKreskowy
            // 
            this.teKodKreskowy.Location = new System.Drawing.Point(76, 31);
            this.teKodKreskowy.Name = "teKodKreskowy";
            this.teKodKreskowy.Size = new System.Drawing.Size(365, 20);
            this.teKodKreskowy.StyleController = this.layoutControl1;
            this.teKodKreskowy.TabIndex = 6;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(76, 7);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(174, 20);
            this.teLogin.StyleController = this.layoutControl1;
            this.teLogin.TabIndex = 5;
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
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.emptySpaceItem1});
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
            this.layoutControlItem3.Control = this.teLogin;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem3.Text = "Login";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teKodKreskowy;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem4.Text = "Kod kreskowy";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.chNieaktywny;
            this.layoutControlItem7.Location = new System.Drawing.Point(247, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(191, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(438, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UzytkownicyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 122);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "UzytkownicyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Użytkownik";
            this.Load += new System.EventHandler(this.UzytkownicyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chNieaktywny.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKodKreskowy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit teKodKreskowy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.CheckEdit chNieaktywny;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}