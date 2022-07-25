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
    class clsVentes
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        Ventes ventes = new Ventes();
        Notification_Center notify = new Notification_Center();

        public void afficher_vente(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
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
        public void enregistrer_vente(Ventes ventes )
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("num_vente", SqlDbType.Int)).Value = ventes.Num_vente;
                cmd.Parameters.Add(new SqlParameter("date_vente", SqlDbType.DateTime)).Value = ventes.Date_vente;
                cmd.Parameters.Add(new SqlParameter("vente_id", SqlDbType.NVarChar)).Value = ventes.Vente_id;
                cmd.Parameters.Add(new SqlParameter("id_boutique", SqlDbType.NVarChar)).Value = ventes.Id_boutique;
                cmd.Parameters.Add(new SqlParameter("id_clients", SqlDbType.NVarChar)).Value = ventes.Id_clients;
                cmd.Parameters.Add(new SqlParameter("description_ventes", SqlDbType.NVarChar)).Value = ventes.Description_ventes;
                cmd.Parameters.Add("@num_vente", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                ventes.Num_vente=Convert.ToInt32(cmd.Parameters["@num_vente"].Value);
                notify.notifier("Enregistrement avec succès!");
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
        public void supprimer_vente(Ventes ventes)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_vente", SqlDbType.Int)).Value = ventes.Num_vente;

                cmd.ExecuteNonQuery();
                notify.notifier("Enregistrement avec succès!");
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
