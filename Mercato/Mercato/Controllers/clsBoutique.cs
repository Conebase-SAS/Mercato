using Mercato.Handlers;
using Mercato.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercato.Controllers
{
    class clsBoutique
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        Boutique boutique = new Boutique();
        Notification_Center notify = new Notification_Center();
        public void rechercher_login(Boutique boutique)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_login", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_boutique", SqlDbType.NVarChar)).Value = boutique.Id_boutique;
                cmd.Parameters.Add(new SqlParameter("mot_de_passe", SqlDbType.NVarChar)).Value = boutique.Password;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    boutique.Id_boutique = Convert.ToString(dr[0]);
                    boutique.Designation = Convert.ToString(dr[1]);
                    boutique.Id_compagnie = Convert.ToString(dr[4]);
                    boutique.Admin_level = Convert.ToString(dr[6]);
                }                
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Souhaitez vous lire le message d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_boutique(Boutique boutique)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_boutique", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_boutique", SqlDbType.NVarChar)).Value = boutique.Id_boutique;
                cmd.Parameters.Add(new SqlParameter("designation", SqlDbType.NVarChar)).Value = boutique.Designation;
                cmd.Parameters.Add(new SqlParameter("mot_de_passe", SqlDbType.NVarChar)).Value = boutique.Password;
                cmd.Parameters.Add(new SqlParameter("id_compagnie", SqlDbType.NVarChar)).Value = boutique.Id_compagnie;
                cmd.Parameters.Add(new SqlParameter("admin_level", SqlDbType.NVarChar)).Value = boutique.Admin_level;

                cmd.ExecuteNonQuery();
                notify.notifier("Enregistrement avec succès!");
                MessageBox.Show("Enregistrement avec succès!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Echec d'enregistrement \nVoulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_login(Boutique boutique, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_login", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_compagnie", SqlDbType.NVarChar)).Value = boutique.Id_compagnie;

                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                //MessageBox.Show("Enregistrement avec succès!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
    }
}
