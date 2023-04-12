
namespace FindInDX
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnUyeOl = new DevExpress.XtraEditors.SimpleButton();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.SnapControl = null;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(-61, -36);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(823, 254);
            this.pictureEdit1.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.Location = new System.Drawing.Point(384, 285);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(94, 44);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUyeOl.Appearance.Options.UseFont = true;
            this.btnUyeOl.Appearance.Options.UseForeColor = true;
            this.btnUyeOl.Location = new System.Drawing.Point(284, 285);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUyeOl.Size = new System.Drawing.Size(94, 44);
            this.btnUyeOl.TabIndex = 3;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(13, 22);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEposta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Properties.Appearance.Options.UseBackColor = true;
            this.txtEposta.Properties.Appearance.Options.UseFont = true;
            this.txtEposta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtEposta.Size = new System.Drawing.Size(232, 28);
            this.txtEposta.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(227, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-Posta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(227, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(13, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Size = new System.Drawing.Size(232, 28);
            this.textEdit1.TabIndex = 4;
            // 
            // FormGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pictureEdit1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormGiris.IconOptions.Image")));
            this.Name = "FormGiris";
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.SimpleButton btnUyeOl;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

