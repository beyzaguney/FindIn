
namespace FindInDX
{
    partial class IlanBasvuru
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnIleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnReddet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBaslik);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 48);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen İlan";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(6, 18);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Properties.Appearance.Options.UseBackColor = true;
            this.txtBaslik.Properties.Appearance.Options.UseFont = true;
            this.txtBaslik.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtBaslik.Size = new System.Drawing.Size(625, 24);
            this.txtBaslik.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMetin);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(22, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 156);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Başvuru Metni";
            // 
            // txtMetin
            // 
            this.txtMetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetin.Location = new System.Drawing.Point(6, 22);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(625, 126);
            this.txtMetin.TabIndex = 0;
            // 
            // btnIleri
            // 
            this.btnIleri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIleri.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnIleri.Appearance.Options.UseBackColor = true;
            this.btnIleri.Appearance.Options.UseFont = true;
            this.btnIleri.Appearance.Options.UseForeColor = true;
            this.btnIleri.Location = new System.Drawing.Point(507, 239);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(152, 44);
            this.btnIleri.TabIndex = 25;
            this.btnIleri.Text = "Başvur";
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Appearance.BackColor = System.Drawing.Color.White;
            this.btnReddet.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReddet.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReddet.Appearance.Options.UseBackColor = true;
            this.btnReddet.Appearance.Options.UseFont = true;
            this.btnReddet.Appearance.Options.UseForeColor = true;
            this.btnReddet.Location = new System.Drawing.Point(333, 239);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(152, 44);
            this.btnReddet.TabIndex = 26;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // IlanBasvuru
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 306);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::FindInDX.Properties.Resources.Fı__2_;
            this.Name = "IlanBasvuru";
            this.Load += new System.EventHandler(this.IlanBasvuru_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMetin;
        private DevExpress.XtraEditors.SimpleButton btnIleri;
        private DevExpress.XtraEditors.SimpleButton btnReddet;
    }
}