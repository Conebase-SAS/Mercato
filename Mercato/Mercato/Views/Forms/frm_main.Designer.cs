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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_company = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_boutique = new System.Windows.Forms.Label();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_finances = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_settings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_users = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_inventory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_stock = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_customers = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_services = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_articles = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_dash = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_finances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_services)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_articles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dash)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_titre);
            this.pnl_header.Controls.Add(this.lbl_company);
            this.pnl_header.Controls.Add(this.bunifuImageButton1);
            this.pnl_header.Controls.Add(this.lbl_boutique);
            this.bunifuTransition1.SetDecoration(this.pnl_header, BunifuAnimatorNS.DecorationType.None);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1366, 50);
            this.pnl_header.TabIndex = 3;
            // 
            // lbl_titre
            // 
            this.lbl_titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbl_titre, BunifuAnimatorNS.DecorationType.None);
            this.lbl_titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(626, 5);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(220, 41);
            this.lbl_titre.TabIndex = 5;
            this.lbl_titre.Text = "Store Manager";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbl_company, BunifuAnimatorNS.DecorationType.None);
            this.lbl_company.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.ForeColor = System.Drawing.Color.White;
            this.lbl_company.Location = new System.Drawing.Point(9, 9);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(182, 32);
            this.lbl_company.TabIndex = 4;
            this.lbl_company.Text = "company name";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Mercato.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1316, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 41);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbl_boutique
            // 
            this.lbl_boutique.AutoSize = true;
            this.lbl_boutique.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbl_boutique, BunifuAnimatorNS.DecorationType.None);
            this.lbl_boutique.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_boutique.ForeColor = System.Drawing.Color.White;
            this.lbl_boutique.Location = new System.Drawing.Point(210, 14);
            this.lbl_boutique.Name = "lbl_boutique";
            this.lbl_boutique.Size = new System.Drawing.Size(118, 25);
            this.lbl_boutique.TabIndex = 2;
            this.lbl_boutique.Text = "lbl_boutique";
            this.lbl_boutique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.pnl_nav.Controls.Add(this.btn_logout);
            this.pnl_nav.Controls.Add(this.btn_finances);
            this.pnl_nav.Controls.Add(this.btn_settings);
            this.pnl_nav.Controls.Add(this.btn_users);
            this.pnl_nav.Controls.Add(this.btn_inventory);
            this.pnl_nav.Controls.Add(this.btn_stock);
            this.pnl_nav.Controls.Add(this.btn_customers);
            this.pnl_nav.Controls.Add(this.btn_services);
            this.pnl_nav.Controls.Add(this.btn_articles);
            this.pnl_nav.Controls.Add(this.btn_dash);
            this.bunifuTransition1.SetDecoration(this.pnl_nav, BunifuAnimatorNS.DecorationType.None);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_nav.Location = new System.Drawing.Point(0, 50);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(77, 718);
            this.pnl_nav.TabIndex = 4;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_logout, BunifuAnimatorNS.DecorationType.None);
            this.btn_logout.Image = global::Mercato.Properties.Resources.shutdown_120px;
            this.btn_logout.ImageActive = null;
            this.btn_logout.Location = new System.Drawing.Point(3, 661);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(70, 50);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 9;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 20;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_finances
            // 
            this.btn_finances.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_finances, BunifuAnimatorNS.DecorationType.None);
            this.btn_finances.Image = global::Mercato.Properties.Resources.finance;
            this.btn_finances.ImageActive = null;
            this.btn_finances.Location = new System.Drawing.Point(3, 458);
            this.btn_finances.Name = "btn_finances";
            this.btn_finances.Size = new System.Drawing.Size(70, 50);
            this.btn_finances.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_finances.TabIndex = 8;
            this.btn_finances.TabStop = false;
            this.btn_finances.Zoom = 20;
            this.btn_finances.Click += new System.EventHandler(this.btn_finances_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_settings, BunifuAnimatorNS.DecorationType.None);
            this.btn_settings.Image = global::Mercato.Properties.Resources.services_120px;
            this.btn_settings.ImageActive = null;
            this.btn_settings.Location = new System.Drawing.Point(4, 522);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(70, 50);
            this.btn_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_settings.TabIndex = 7;
            this.btn_settings.TabStop = false;
            this.btn_settings.Zoom = 20;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_users, BunifuAnimatorNS.DecorationType.None);
            this.btn_users.Image = global::Mercato.Properties.Resources.admin_settings_male_120px;
            this.btn_users.ImageActive = null;
            this.btn_users.Location = new System.Drawing.Point(3, 394);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(70, 50);
            this.btn_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_users.TabIndex = 6;
            this.btn_users.TabStop = false;
            this.btn_users.Zoom = 20;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click_1);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_inventory, BunifuAnimatorNS.DecorationType.None);
            this.btn_inventory.Image = global::Mercato.Properties.Resources.delivered_box_120px;
            this.btn_inventory.ImageActive = null;
            this.btn_inventory.Location = new System.Drawing.Point(3, 330);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(70, 50);
            this.btn_inventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_inventory.TabIndex = 5;
            this.btn_inventory.TabStop = false;
            this.btn_inventory.Zoom = 20;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_stock, BunifuAnimatorNS.DecorationType.None);
            this.btn_stock.Image = global::Mercato.Properties.Resources.box_120px;
            this.btn_stock.ImageActive = null;
            this.btn_stock.Location = new System.Drawing.Point(3, 266);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(70, 50);
            this.btn_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_stock.TabIndex = 4;
            this.btn_stock.TabStop = false;
            this.btn_stock.Zoom = 20;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_customers, BunifuAnimatorNS.DecorationType.None);
            this.btn_customers.Image = global::Mercato.Properties.Resources.profile_120px;
            this.btn_customers.ImageActive = null;
            this.btn_customers.Location = new System.Drawing.Point(3, 202);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(70, 50);
            this.btn_customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_customers.TabIndex = 3;
            this.btn_customers.TabStop = false;
            this.btn_customers.Zoom = 20;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_services
            // 
            this.btn_services.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_services, BunifuAnimatorNS.DecorationType.None);
            this.btn_services.Image = global::Mercato.Properties.Resources.service_120px;
            this.btn_services.ImageActive = null;
            this.btn_services.Location = new System.Drawing.Point(3, 138);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(70, 50);
            this.btn_services.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_services.TabIndex = 2;
            this.btn_services.TabStop = false;
            this.btn_services.Zoom = 20;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btn_articles
            // 
            this.btn_articles.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_articles, BunifuAnimatorNS.DecorationType.None);
            this.btn_articles.Image = global::Mercato.Properties.Resources.sales_white;
            this.btn_articles.ImageActive = null;
            this.btn_articles.Location = new System.Drawing.Point(3, 74);
            this.btn_articles.Name = "btn_articles";
            this.btn_articles.Size = new System.Drawing.Size(70, 50);
            this.btn_articles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_articles.TabIndex = 1;
            this.btn_articles.TabStop = false;
            this.btn_articles.Zoom = 20;
            this.btn_articles.Click += new System.EventHandler(this.btn_articles_Click);
            // 
            // btn_dash
            // 
            this.btn_dash.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_dash, BunifuAnimatorNS.DecorationType.None);
            this.btn_dash.Image = global::Mercato.Properties.Resources.dashboard_layout_120px;
            this.btn_dash.ImageActive = null;
            this.btn_dash.Location = new System.Drawing.Point(4, 10);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(70, 50);
            this.btn_dash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dash.TabIndex = 0;
            this.btn_dash.TabStop = false;
            this.btn_dash.Zoom = 20;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.pnl_body.BackgroundImage = global::Mercato.Properties.Resources.logo;
            this.pnl_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.pnl_body, BunifuAnimatorNS.DecorationType.None);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(77, 50);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1289, 718);
            this.pnl_body.TabIndex = 5;
            this.pnl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_body_Paint);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_finances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_services)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_articles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_nav;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnl_body;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lbl_boutique;
        private Bunifu.Framework.UI.BunifuImageButton btn_settings;
        private Bunifu.Framework.UI.BunifuImageButton btn_users;
        private Bunifu.Framework.UI.BunifuImageButton btn_inventory;
        private Bunifu.Framework.UI.BunifuImageButton btn_stock;
        private Bunifu.Framework.UI.BunifuImageButton btn_customers;
        private Bunifu.Framework.UI.BunifuImageButton btn_services;
        private Bunifu.Framework.UI.BunifuImageButton btn_articles;
        private Bunifu.Framework.UI.BunifuImageButton btn_dash;
        private Bunifu.Framework.UI.BunifuImageButton btn_finances;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        public System.Windows.Forms.Label lbl_company;
        public System.Windows.Forms.Label lbl_titre;
    }
}