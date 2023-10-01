namespace Mercato.Views.UserControls
{
    partial class uc_settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_settings));
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_types_articles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_articles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_taux = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_categories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_paquetage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_couleurs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_fournisseurs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_depot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.White;
            this.pnl_nav.Controls.Add(this.btn_types_articles);
            this.pnl_nav.Controls.Add(this.btn_articles);
            this.pnl_nav.Controls.Add(this.btn_taux);
            this.pnl_nav.Controls.Add(this.btn_categories);
            this.pnl_nav.Controls.Add(this.btn_paquetage);
            this.pnl_nav.Controls.Add(this.btn_couleurs);
            this.pnl_nav.Controls.Add(this.btn_fournisseurs);
            this.pnl_nav.Controls.Add(this.btn_depot);
            this.bunifuTransition1.SetDecoration(this.pnl_nav, BunifuAnimatorNS.DecorationType.None);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_nav.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_nav.Location = new System.Drawing.Point(0, 665);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(1289, 53);
            this.pnl_nav.TabIndex = 4;
            // 
            // btn_types_articles
            // 
            this.btn_types_articles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_types_articles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_types_articles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_types_articles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_types_articles.BorderRadius = 0;
            this.btn_types_articles.ButtonText = "   Types d\'articles";
            this.btn_types_articles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_types_articles, BunifuAnimatorNS.DecorationType.None);
            this.btn_types_articles.DisabledColor = System.Drawing.Color.Gray;
            this.btn_types_articles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_types_articles.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_types_articles.Iconimage = global::Mercato.Properties.Resources.magazine_104px;
            this.btn_types_articles.Iconimage_right = null;
            this.btn_types_articles.Iconimage_right_Selected = null;
            this.btn_types_articles.Iconimage_Selected = null;
            this.btn_types_articles.IconMarginLeft = 0;
            this.btn_types_articles.IconMarginRight = 0;
            this.btn_types_articles.IconRightVisible = true;
            this.btn_types_articles.IconRightZoom = 0D;
            this.btn_types_articles.IconVisible = true;
            this.btn_types_articles.IconZoom = 80D;
            this.btn_types_articles.IsTab = false;
            this.btn_types_articles.Location = new System.Drawing.Point(1100, 5);
            this.btn_types_articles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_types_articles.Name = "btn_types_articles";
            this.btn_types_articles.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_types_articles.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_types_articles.onHoverTextColor = System.Drawing.Color.White;
            this.btn_types_articles.selected = false;
            this.btn_types_articles.Size = new System.Drawing.Size(165, 44);
            this.btn_types_articles.TabIndex = 13;
            this.btn_types_articles.Text = "   Types d\'articles";
            this.btn_types_articles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types_articles.Textcolor = System.Drawing.Color.White;
            this.btn_types_articles.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_articles
            // 
            this.btn_articles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_articles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_articles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_articles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_articles.BorderRadius = 0;
            this.btn_articles.ButtonText = "   Articles";
            this.btn_articles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_articles, BunifuAnimatorNS.DecorationType.None);
            this.btn_articles.DisabledColor = System.Drawing.Color.Gray;
            this.btn_articles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articles.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_articles.Iconimage = global::Mercato.Properties.Resources.open_box_104px;
            this.btn_articles.Iconimage_right = null;
            this.btn_articles.Iconimage_right_Selected = null;
            this.btn_articles.Iconimage_Selected = null;
            this.btn_articles.IconMarginLeft = 0;
            this.btn_articles.IconMarginRight = 0;
            this.btn_articles.IconRightVisible = true;
            this.btn_articles.IconRightZoom = 0D;
            this.btn_articles.IconVisible = true;
            this.btn_articles.IconZoom = 80D;
            this.btn_articles.IsTab = false;
            this.btn_articles.Location = new System.Drawing.Point(22, 5);
            this.btn_articles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_articles.Name = "btn_articles";
            this.btn_articles.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_articles.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_articles.onHoverTextColor = System.Drawing.Color.White;
            this.btn_articles.selected = false;
            this.btn_articles.Size = new System.Drawing.Size(148, 44);
            this.btn_articles.TabIndex = 5;
            this.btn_articles.Text = "   Articles";
            this.btn_articles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_articles.Textcolor = System.Drawing.Color.White;
            this.btn_articles.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articles.Click += new System.EventHandler(this.btn_articles_Click);
            // 
            // btn_taux
            // 
            this.btn_taux.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_taux.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_taux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_taux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_taux.BorderRadius = 0;
            this.btn_taux.ButtonText = "   Taux";
            this.btn_taux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_taux, BunifuAnimatorNS.DecorationType.None);
            this.btn_taux.DisabledColor = System.Drawing.Color.Gray;
            this.btn_taux.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taux.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_taux.Iconimage = global::Mercato.Properties.Resources.currency_exchange_104px_;
            this.btn_taux.Iconimage_right = null;
            this.btn_taux.Iconimage_right_Selected = null;
            this.btn_taux.Iconimage_Selected = null;
            this.btn_taux.IconMarginLeft = 0;
            this.btn_taux.IconMarginRight = 0;
            this.btn_taux.IconRightVisible = true;
            this.btn_taux.IconRightZoom = 0D;
            this.btn_taux.IconVisible = true;
            this.btn_taux.IconZoom = 80D;
            this.btn_taux.IsTab = false;
            this.btn_taux.Location = new System.Drawing.Point(946, 5);
            this.btn_taux.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_taux.Name = "btn_taux";
            this.btn_taux.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_taux.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_taux.onHoverTextColor = System.Drawing.Color.White;
            this.btn_taux.selected = false;
            this.btn_taux.Size = new System.Drawing.Size(148, 44);
            this.btn_taux.TabIndex = 12;
            this.btn_taux.Text = "   Taux";
            this.btn_taux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taux.Textcolor = System.Drawing.Color.White;
            this.btn_taux.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_categories
            // 
            this.btn_categories.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_categories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_categories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_categories.BorderRadius = 0;
            this.btn_categories.ButtonText = "   Catégories";
            this.btn_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_categories, BunifuAnimatorNS.DecorationType.None);
            this.btn_categories.DisabledColor = System.Drawing.Color.Gray;
            this.btn_categories.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_categories.Iconimage = global::Mercato.Properties.Resources.alphabetical_sorting_104px;
            this.btn_categories.Iconimage_right = null;
            this.btn_categories.Iconimage_right_Selected = null;
            this.btn_categories.Iconimage_Selected = null;
            this.btn_categories.IconMarginLeft = 0;
            this.btn_categories.IconMarginRight = 0;
            this.btn_categories.IconRightVisible = true;
            this.btn_categories.IconRightZoom = 0D;
            this.btn_categories.IconVisible = true;
            this.btn_categories.IconZoom = 80D;
            this.btn_categories.IsTab = false;
            this.btn_categories.Location = new System.Drawing.Point(176, 4);
            this.btn_categories.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_categories.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_categories.onHoverTextColor = System.Drawing.Color.White;
            this.btn_categories.selected = false;
            this.btn_categories.Size = new System.Drawing.Size(148, 44);
            this.btn_categories.TabIndex = 7;
            this.btn_categories.Text = "   Catégories";
            this.btn_categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Textcolor = System.Drawing.Color.White;
            this.btn_categories.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_paquetage
            // 
            this.btn_paquetage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_paquetage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paquetage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_paquetage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paquetage.BorderRadius = 0;
            this.btn_paquetage.ButtonText = "   Paquetage";
            this.btn_paquetage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_paquetage, BunifuAnimatorNS.DecorationType.None);
            this.btn_paquetage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_paquetage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paquetage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_paquetage.Iconimage = global::Mercato.Properties.Resources.empty_box_104px;
            this.btn_paquetage.Iconimage_right = null;
            this.btn_paquetage.Iconimage_right_Selected = null;
            this.btn_paquetage.Iconimage_Selected = null;
            this.btn_paquetage.IconMarginLeft = 0;
            this.btn_paquetage.IconMarginRight = 0;
            this.btn_paquetage.IconRightVisible = true;
            this.btn_paquetage.IconRightZoom = 0D;
            this.btn_paquetage.IconVisible = true;
            this.btn_paquetage.IconZoom = 80D;
            this.btn_paquetage.IsTab = false;
            this.btn_paquetage.Location = new System.Drawing.Point(792, 4);
            this.btn_paquetage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_paquetage.Name = "btn_paquetage";
            this.btn_paquetage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_paquetage.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_paquetage.onHoverTextColor = System.Drawing.Color.White;
            this.btn_paquetage.selected = false;
            this.btn_paquetage.Size = new System.Drawing.Size(148, 44);
            this.btn_paquetage.TabIndex = 11;
            this.btn_paquetage.Text = "   Paquetage";
            this.btn_paquetage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paquetage.Textcolor = System.Drawing.Color.White;
            this.btn_paquetage.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_couleurs
            // 
            this.btn_couleurs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_couleurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_couleurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_couleurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_couleurs.BorderRadius = 0;
            this.btn_couleurs.ButtonText = "   Couleurs";
            this.btn_couleurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_couleurs, BunifuAnimatorNS.DecorationType.None);
            this.btn_couleurs.DisabledColor = System.Drawing.Color.Gray;
            this.btn_couleurs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_couleurs.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_couleurs.Iconimage = global::Mercato.Properties.Resources.paint_palette_104px;
            this.btn_couleurs.Iconimage_right = null;
            this.btn_couleurs.Iconimage_right_Selected = null;
            this.btn_couleurs.Iconimage_Selected = null;
            this.btn_couleurs.IconMarginLeft = 0;
            this.btn_couleurs.IconMarginRight = 0;
            this.btn_couleurs.IconRightVisible = true;
            this.btn_couleurs.IconRightZoom = 0D;
            this.btn_couleurs.IconVisible = true;
            this.btn_couleurs.IconZoom = 80D;
            this.btn_couleurs.IsTab = false;
            this.btn_couleurs.Location = new System.Drawing.Point(330, 5);
            this.btn_couleurs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_couleurs.Name = "btn_couleurs";
            this.btn_couleurs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_couleurs.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_couleurs.onHoverTextColor = System.Drawing.Color.White;
            this.btn_couleurs.selected = false;
            this.btn_couleurs.Size = new System.Drawing.Size(148, 44);
            this.btn_couleurs.TabIndex = 8;
            this.btn_couleurs.Text = "   Couleurs";
            this.btn_couleurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_couleurs.Textcolor = System.Drawing.Color.White;
            this.btn_couleurs.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_fournisseurs
            // 
            this.btn_fournisseurs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_fournisseurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fournisseurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_fournisseurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fournisseurs.BorderRadius = 0;
            this.btn_fournisseurs.ButtonText = "   Fournisseurs";
            this.btn_fournisseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_fournisseurs, BunifuAnimatorNS.DecorationType.None);
            this.btn_fournisseurs.DisabledColor = System.Drawing.Color.Gray;
            this.btn_fournisseurs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fournisseurs.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_fournisseurs.Iconimage = global::Mercato.Properties.Resources.shop_104px;
            this.btn_fournisseurs.Iconimage_right = null;
            this.btn_fournisseurs.Iconimage_right_Selected = null;
            this.btn_fournisseurs.Iconimage_Selected = null;
            this.btn_fournisseurs.IconMarginLeft = 0;
            this.btn_fournisseurs.IconMarginRight = 0;
            this.btn_fournisseurs.IconRightVisible = true;
            this.btn_fournisseurs.IconRightZoom = 0D;
            this.btn_fournisseurs.IconVisible = true;
            this.btn_fournisseurs.IconZoom = 80D;
            this.btn_fournisseurs.IsTab = false;
            this.btn_fournisseurs.Location = new System.Drawing.Point(638, 4);
            this.btn_fournisseurs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_fournisseurs.Name = "btn_fournisseurs";
            this.btn_fournisseurs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_fournisseurs.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_fournisseurs.onHoverTextColor = System.Drawing.Color.White;
            this.btn_fournisseurs.selected = false;
            this.btn_fournisseurs.Size = new System.Drawing.Size(148, 44);
            this.btn_fournisseurs.TabIndex = 10;
            this.btn_fournisseurs.Text = "   Fournisseurs";
            this.btn_fournisseurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fournisseurs.Textcolor = System.Drawing.Color.White;
            this.btn_fournisseurs.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_depot
            // 
            this.btn_depot.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_depot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_depot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_depot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_depot.BorderRadius = 0;
            this.btn_depot.ButtonText = "   Entreposage";
            this.btn_depot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_depot, BunifuAnimatorNS.DecorationType.None);
            this.btn_depot.DisabledColor = System.Drawing.Color.Gray;
            this.btn_depot.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depot.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_depot.Iconimage = global::Mercato.Properties.Resources.trolley_104px_;
            this.btn_depot.Iconimage_right = null;
            this.btn_depot.Iconimage_right_Selected = null;
            this.btn_depot.Iconimage_Selected = null;
            this.btn_depot.IconMarginLeft = 0;
            this.btn_depot.IconMarginRight = 0;
            this.btn_depot.IconRightVisible = true;
            this.btn_depot.IconRightZoom = 0D;
            this.btn_depot.IconVisible = true;
            this.btn_depot.IconZoom = 80D;
            this.btn_depot.IsTab = false;
            this.btn_depot.Location = new System.Drawing.Point(484, 4);
            this.btn_depot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_depot.Name = "btn_depot";
            this.btn_depot.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.btn_depot.onHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btn_depot.onHoverTextColor = System.Drawing.Color.White;
            this.btn_depot.selected = false;
            this.btn_depot.Size = new System.Drawing.Size(148, 44);
            this.btn_depot.TabIndex = 9;
            this.btn_depot.Text = "   Entreposage";
            this.btn_depot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depot.Textcolor = System.Drawing.Color.White;
            this.btn_depot.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnl_content
            // 
            this.pnl_content.BackgroundImage = global::Mercato.Properties.Resources.logo;
            this.pnl_content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pnl_content, BunifuAnimatorNS.DecorationType.None);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1289, 665);
            this.pnl_content.TabIndex = 5;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateonlyDifferences = true;
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
            // uc_settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_nav);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_settings";
            this.Size = new System.Drawing.Size(1289, 718);
            this.pnl_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_nav;
        private Bunifu.Framework.UI.BunifuFlatButton btn_articles;
        private Bunifu.Framework.UI.BunifuFlatButton btn_paquetage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_fournisseurs;
        private Bunifu.Framework.UI.BunifuFlatButton btn_depot;
        private Bunifu.Framework.UI.BunifuFlatButton btn_couleurs;
        private Bunifu.Framework.UI.BunifuFlatButton btn_categories;
        private System.Windows.Forms.Panel pnl_content;
        private Bunifu.Framework.UI.BunifuFlatButton btn_types_articles;
        private Bunifu.Framework.UI.BunifuFlatButton btn_taux;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
