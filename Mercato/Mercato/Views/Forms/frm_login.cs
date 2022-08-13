using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNFPA.Handlers;
using UNFPA.Models;
using UNFPA.Connections;

namespace UNFPA.Clients.Forms
{
    public partial class frm_login : Form
    {
        Logins login = new Logins();
        LoginSettings logsettings = new LoginSettings();
        clsLogins handlerLogin = new clsLogins();
        
        clsNotif notif = new clsNotif();
        public frm_login()
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "" || txt_username.Text == "")
            {
                Shake(this);
                notif.notifier("Veuillez completer votre nom d'utilisateur ainsi que votre mot de passe!");
            }
            else
            {
                login.Noms = txt_username.Text;
                login.Usercode = txt_password.Text;

                handlerLogin.search_login(login);

                if(login.Id_level=="Admin")
                {
                    this.Hide();
                    var fr = new frm_main();
                    
                    fr.lbl_user.Text = login.Noms;
                    var adm = new frm_admin();
                    notif.notifier("Bienvenu(e) " + login.Noms);
                    adm.lbl_user.Text = login.Noms;
                    fr.btn_admin.Enabled = true;
                    fr.btn_admin.Visible = true;
                    fr.Show();
                    
                }  
                else if(login.Id_level == "User")
                {
                    this.Hide();
                    var fr = new frm_main();
                    fr.lbl_user.Text = login.Noms;
                    fr.btn_admin.Enabled = false;
                    fr.btn_admin.Visible = false;
                    fr.Show();
                }
                else
                {                    
                    Shake(this);
                    notif.notifier("Vous n'avez pas les accès pour cette application! Veuillez consulter l'administrateur!");
                }
            }            
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
    }
}
