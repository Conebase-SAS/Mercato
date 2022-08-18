using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Handlers;
using Mercato.Controllers;
using Mercato.Models;
namespace Mercato.Views.Forms
{
    public partial class frm_logins : Form
    {
        Boutique boutique = new Boutique();
        clsBoutique cls_boutique = new clsBoutique();
        
        Notification_Center notif = new Notification_Center();
        public frm_logins()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                bunifuFlatButton1_Click(sender, e);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "" || txt_username.Text == "")
            {
                Shake(this);
                notif.notifier("Veuillez completer votre nom d'utilisateur ainsi que votre mot de passe!");
            }
            else
            {
                boutique.Id_boutique = txt_username.Text;
                boutique.Password = txt_password.Text;

                cls_boutique.rechercher_login(boutique);

                if (boutique.Admin_level == "Admin")
                {
                    this.Hide();
                    var fr = new frm_main();
                    fr.lbl_boutique.Text = boutique.Id_boutique;
                    fr.lbl_company.Text = boutique.Id_compagnie;
                    Properties.Settings.Default.Id_company = boutique.Id_compagnie;
                    Properties.Settings.Default.Id_boutique = boutique.Id_boutique;
                    notif.notifier("Bienvenu(e) " + boutique.Id_boutique);
                    fr.activate_admin(true);
                    fr.Show();
                }
                else if (boutique.Admin_level == "User")
                {
                    this.Hide();
                    var fr = new frm_main();
                    fr.lbl_boutique.Text = boutique.Id_boutique;
                    fr.lbl_company.Text = boutique.Id_compagnie;
                    Properties.Settings.Default.Id_company = boutique.Id_compagnie;
                    Properties.Settings.Default.Id_boutique = boutique.Id_boutique;
                    notif.notifier("Bienvenu(e) " + boutique.Id_boutique);
                    fr.activate_admin(false);
                    fr.Show();
                }
                else
                {
                    Shake(this);
                    notif.notifier("Vous n'avez pas les accès pour cette application! Veuillez consulter l'administrateur!");
                }
            }
        }
    }
}
