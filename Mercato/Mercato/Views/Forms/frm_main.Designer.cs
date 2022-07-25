namespace Mercato.Views.Forms
{
    partial class frm_main
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_inventaire = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnl_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.bunifuImageButton1);
            this.pnl_header.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.pnl_header, BunifuAnimatorNS.DecorationType.None);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1366, 50);
            this.pnl_header.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Mercato.Properties.Resources.multiply_104px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1316, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mercato - Dashboard";
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.pnl_nav.Controls.Add(this.button7);
            this.pnl_nav.Controls.Add(this.button6);
            this.pnl_nav.Controls.Add(this.btn_inventaire);
            this.pnl_nav.Controls.Add(this.button4);
            this.pnl_nav.Controls.Add(this.button3);
            this.pnl_nav.Controls.Add(this.button2);
            this.pnl_nav.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.pnl_nav, BunifuAnimatorNS.DecorationType.None);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_nav.Location = new System.Drawing.Point(0, 50);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(161, 718);
            this.pnl_nav.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(0, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 46);
            this.button7.TabIndex = 28;
            this.button7.Text = "Paramètres";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(0, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 46);
            this.button6.TabIndex = 27;
            this.button6.Text = "Clients";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_inventaire
            // 
            this.btn_inventaire.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_inventaire, BunifuAnimatorNS.DecorationType.None);
            this.btn_inventaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btn_inventaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_inventaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_inventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventaire.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventaire.ForeColor = System.Drawing.Color.White;
            this.btn_inventaire.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_inventaire.Location = new System.Drawing.Point(0, 269);
            this.btn_inventaire.Name = "btn_inventaire";
            this.btn_inventaire.Size = new System.Drawing.Size(161, 46);
            this.btn_inventaire.TabIndex = 26;
            this.btn_inventaire.Text = "Inventaire";
            this.btn_inventaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inventaire.UseVisualStyleBackColor = false;
            this.btn_inventaire.Click += new System.EventHandler(this.btn_inventaire_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(0, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 46);
            this.button4.TabIndex = 25;
            this.button4.Text = "Stock";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(0, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 46);
            this.button3.TabIndex = 24;
            this.button3.Text = "Vente Services";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "Vente Articles";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnl_body
            // 
            this.bunifuTransition1.SetDecoration(this.pnl_body, BunifuAnimatorNS.DecorationType.None);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(161, 50);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1205, 718);
            this.pnl_body.TabIndex = 5;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_nav);
            this.Controls.Add(this.pnl_header);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_nav;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_inventaire;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnl_body;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button7;
    }
}