namespace Magazyn.Ustawienia
{
    partial class UstawieniaBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UstawieniaBD));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teBD = new DevExpress.XtraEditors.TextEdit();
            this.teHaslo = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.teNazwaSerwera = new DevExpress.XtraEditors.TextEdit();
            this.Przycisk_Zapisz = new DevExpress.XtraEditors.SimpleButton();
            this.Przycisk_Anuluj = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teZdjeciaLokalne = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbWyborFolderZdjecia = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHaslo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNazwaSerwera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teZdjeciaLokalne.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbWyborFolderZdjecia);
            this.layoutControl1.Controls.Add(this.teBD);
            this.layoutControl1.Controls.Add(this.teHaslo);
            this.layoutControl1.Controls.Add(this.teLogin);
            this.layoutControl1.Controls.Add(this.teNazwaSerwera);
            this.layoutControl1.Controls.Add(this.Przycisk_Zapisz);
            this.layoutControl1.Controls.Add(this.Przycisk_Anuluj);
            this.layoutControl1.Controls.Add(this.teZdjeciaLokalne);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(834, 162, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(513, 241);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teBD
            // 
            this.teBD.Location = new System.Drawing.Point(130, 109);
            this.teBD.Name = "teBD";
            this.teBD.Size = new System.Drawing.Size(364, 20);
            this.teBD.StyleController = this.layoutControl1;
            this.teBD.TabIndex = 8;
            // 
            // teHaslo
            // 
            this.teHaslo.Location = new System.Drawing.Point(130, 85);
            this.teHaslo.Name = "teHaslo";
            this.teHaslo.Properties.PasswordChar = '*';
            this.teHaslo.Size = new System.Drawing.Size(364, 20);
            this.teHaslo.StyleController = this.layoutControl1;
            this.teHaslo.TabIndex = 7;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(130, 61);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(364, 20);
            this.teLogin.StyleController = this.layoutControl1;
            this.teLogin.TabIndex = 6;
            // 
            // teNazwaSerwera
            // 
            this.teNazwaSerwera.Location = new System.Drawing.Point(130, 37);
            this.teNazwaSerwera.Name = "teNazwaSerwera";
            this.teNazwaSerwera.Size = new System.Drawing.Size(364, 20);
            this.teNazwaSerwera.StyleController = this.layoutControl1;
            this.teNazwaSerwera.TabIndex = 5;
            // 
            // Przycisk_Zapisz
            // 
            this.Przycisk_Zapisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Przycisk_Zapisz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Przycisk_Zapisz.ImageOptions.Image")));
            this.Przycisk_Zapisz.Location = new System.Drawing.Point(403, 212);
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
            this.Przycisk_Anuluj.Location = new System.Drawing.Point(296, 212);
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
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(513, 241);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Przycisk_Anuluj;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(289, 205);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem2.Text = "layoutControlItem1";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Przycisk_Zapisz;
            this.layoutControlItem1.Location = new System.Drawing.Point(396, 205);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 205);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(289, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(503, 205);
            this.layoutControlGroup2.Text = "Baza produkcyjna";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(479, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teNazwaSerwera;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem3.Text = "Nazwa serwera";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teLogin;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem4.Text = "Login";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teHaslo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem5.Text = "Hasło";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teBD;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem6.Text = "Baza danych";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 13);
            // 
            // teZdjeciaLokalne
            // 
            this.teZdjeciaLokalne.Location = new System.Drawing.Point(19, 176);
            this.teZdjeciaLokalne.Name = "teZdjeciaLokalne";
            this.teZdjeciaLokalne.Properties.ReadOnly = true;
            this.teZdjeciaLokalne.Size = new System.Drawing.Size(395, 20);
            this.teZdjeciaLokalne.StyleController = this.layoutControl1;
            this.teZdjeciaLokalne.TabIndex = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.teZdjeciaLokalne;
            this.layoutControlItem7.CustomizationFormText = "Zdjęcia - folder lokalny";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(399, 40);
            this.layoutControlItem7.Text = "Zdjęcia - folder lokalny";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(108, 13);
            // 
            // sbWyborFolderZdjecia
            // 
            this.sbWyborFolderZdjecia.Location = new System.Drawing.Point(418, 174);
            this.sbWyborFolderZdjecia.Name = "sbWyborFolderZdjecia";
            this.sbWyborFolderZdjecia.Size = new System.Drawing.Size(76, 22);
            this.sbWyborFolderZdjecia.StyleController = this.layoutControl1;
            this.sbWyborFolderZdjecia.TabIndex = 9;
            this.sbWyborFolderZdjecia.Text = "Wybierz";
            this.sbWyborFolderZdjecia.Click += new System.EventHandler(this.sbWyborFolderZdjecia_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sbWyborFolderZdjecia;
            this.layoutControlItem8.Location = new System.Drawing.Point(399, 137);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(399, 123);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(80, 14);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UstawieniaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 241);
            this.Controls.Add(this.layoutControl1);
            this.Name = "UstawieniaBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia bazy danych";
            this.Load += new System.EventHandler(this.UstawieniaBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHaslo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNazwaSerwera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teZdjeciaLokalne.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit teBD;
        private DevExpress.XtraEditors.TextEdit teHaslo;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.TextEdit teNazwaSerwera;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton sbWyborFolderZdjecia;
        private DevExpress.XtraEditors.TextEdit teZdjeciaLokalne;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}