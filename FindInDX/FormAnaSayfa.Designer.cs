
namespace FindInDX
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgIlanlar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.dgvIlanlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pgProfil = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBio = new DevExpress.XtraEditors.TextEdit();
            this.lblTamIs = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.pgIlanlarim = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dgvBasvurular = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnKaldır = new DevExpress.XtraEditors.SimpleButton();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.dgvIlanlarim = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.pgIlanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pgProfil.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBio.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.pgIlanlarim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasvurular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlarim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationPane1.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navigationPane1.Appearance.Options.UseBackColor = true;
            this.navigationPane1.Appearance.Options.UseFont = true;
            this.navigationPane1.Controls.Add(this.label2);
            this.navigationPane1.Controls.Add(this.label1);
            this.navigationPane1.Controls.Add(this.pgIlanlar);
            this.navigationPane1.Controls.Add(this.pgProfil);
            this.navigationPane1.Controls.Add(this.pgIlanlarim);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseBackColor = true;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pgIlanlar,
            this.pgProfil,
            this.pgIlanlarim});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1031, 577);
            this.navigationPane1.SelectedPage = this.pgProfil;
            this.navigationPane1.Size = new System.Drawing.Size(1031, 577);
            this.navigationPane1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // pgIlanlar
            // 
            this.pgIlanlar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pgIlanlar.Appearance.Options.UseBackColor = true;
            this.pgIlanlar.Appearance.Options.UseFont = true;
            this.pgIlanlar.Caption = "İlanlar";
            this.pgIlanlar.Controls.Add(this.label3);
            this.pgIlanlar.Controls.Add(this.cbKategori);
            this.pgIlanlar.Controls.Add(this.dgvIlanlar);
            this.pgIlanlar.Name = "pgIlanlar";
            this.pgIlanlar.Size = new System.Drawing.Size(936, 504);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Filtrele:";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(815, 3);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 28);
            this.cbKategori.TabIndex = 2;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // dgvIlanlar
            // 
            this.dgvIlanlar.EmbeddedNavigator.Appearance.Options.UseTextOptions = true;
            this.dgvIlanlar.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgvIlanlar.Location = new System.Drawing.Point(3, 31);
            this.dgvIlanlar.MainView = this.gridView1;
            this.dgvIlanlar.Name = "dgvIlanlar";
            this.dgvIlanlar.Size = new System.Drawing.Size(933, 473);
            this.dgvIlanlar.TabIndex = 1;
            this.dgvIlanlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.ColumnPanelRowHeight = 6;
            this.gridView1.GridControl = this.dgvIlanlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 45;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // pgProfil
            // 
            this.pgProfil.Caption = "Profil";
            this.pgProfil.Controls.Add(this.groupBox3);
            this.pgProfil.Controls.Add(this.lblTamIs);
            this.pgProfil.Controls.Add(this.labelControl6);
            this.pgProfil.Controls.Add(this.groupBox2);
            this.pgProfil.Controls.Add(this.groupBox1);
            this.pgProfil.Name = "pgProfil";
            this.pgProfil.Size = new System.Drawing.Size(936, 504);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBio);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(225, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 48);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biyografi";
            // 
            // txtBio
            // 
            this.txtBio.Enabled = false;
            this.txtBio.Location = new System.Drawing.Point(6, 18);
            this.txtBio.Name = "txtBio";
            this.txtBio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtBio.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBio.Properties.Appearance.Options.UseBackColor = true;
            this.txtBio.Properties.Appearance.Options.UseFont = true;
            this.txtBio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtBio.Size = new System.Drawing.Size(404, 24);
            this.txtBio.TabIndex = 4;
            // 
            // lblTamIs
            // 
            this.lblTamIs.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTamIs.Appearance.Options.UseFont = true;
            this.lblTamIs.Location = new System.Drawing.Point(405, 261);
            this.lblTamIs.Name = "lblTamIs";
            this.lblTamIs.Size = new System.Drawing.Size(8, 20);
            this.lblTamIs.TabIndex = 26;
            this.lblTamIs.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(231, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(152, 20);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Tamamlanan İş Sayısı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(443, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 48);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(6, 18);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseBackColor = true;
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSoyad.Size = new System.Drawing.Size(186, 24);
            this.txtSoyad.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(225, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(6, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAd.Size = new System.Drawing.Size(186, 24);
            this.txtAd.TabIndex = 4;
            // 
            // pgIlanlarim
            // 
            this.pgIlanlarim.Caption = "İlanlarım";
            this.pgIlanlarim.Controls.Add(this.dgvBasvurular);
            this.pgIlanlarim.Controls.Add(this.btnKaldır);
            this.pgIlanlarim.Controls.Add(this.btnOlustur);
            this.pgIlanlarim.Controls.Add(this.dgvIlanlarim);
            this.pgIlanlarim.Name = "pgIlanlarim";
            this.pgIlanlarim.Size = new System.Drawing.Size(936, 504);
            // 
            // dgvBasvurular
            // 
            this.dgvBasvurular.Location = new System.Drawing.Point(0, 246);
            this.dgvBasvurular.MainView = this.gridView3;
            this.dgvBasvurular.Name = "dgvBasvurular";
            this.dgvBasvurular.Size = new System.Drawing.Size(933, 258);
            this.dgvBasvurular.TabIndex = 4;
            this.dgvBasvurular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dgvBasvurular;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.RowHeight = 45;
            this.gridView3.DoubleClick += new System.EventHandler(this.gridView3_DoubleClick);
            // 
            // btnKaldır
            // 
            this.btnKaldır.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaldır.ImageOptions.Image")));
            this.btnKaldır.Location = new System.Drawing.Point(849, 3);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(39, 34);
            this.btnKaldır.TabIndex = 2;
            this.btnKaldır.Text = "simpleButton2";
            this.btnKaldır.Click += new System.EventHandler(this.btnKaldır_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOlustur.ImageOptions.Image")));
            this.btnOlustur.Location = new System.Drawing.Point(894, 3);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(39, 34);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "simpleButton1";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // dgvIlanlarim
            // 
            this.dgvIlanlarim.Location = new System.Drawing.Point(0, 0);
            this.dgvIlanlarim.MainView = this.gridView2;
            this.dgvIlanlarim.Name = "dgvIlanlarim";
            this.dgvIlanlarim.Size = new System.Drawing.Size(933, 248);
            this.dgvIlanlarim.TabIndex = 0;
            this.dgvIlanlarim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgvIlanlarim;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.RowHeight = 45;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // FormAnaSayfa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 577);
            this.Controls.Add(this.navigationPane1);
            this.IconOptions.Image = global::FindInDX.Properties.Resources.Fı__2_;
            this.Name = "FormAnaSayfa";
            this.Text = "FormAnaSayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPane1.PerformLayout();
            this.pgIlanlar.ResumeLayout(false);
            this.pgIlanlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pgProfil.ResumeLayout(false);
            this.pgProfil.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBio.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.pgIlanlarim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasvurular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlarim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage pgIlanlar;
        private DevExpress.XtraBars.Navigation.NavigationPage pgProfil;
        private DevExpress.XtraBars.Navigation.NavigationPage pgIlanlarim;
        private DevExpress.XtraGrid.GridControl dgvIlanlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl dgvIlanlarim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblTamIs;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnKaldır;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategori;
        private DevExpress.XtraGrid.GridControl dgvBasvurular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}