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
    class clsDetails_Ventes
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        Details_Ventes detail_vente = new Details_Ventes();
        Notification_Center notify = new Notification_Center();

        public void afficher_details_vente(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_details_vente", cnx)
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
        public void enregistrer_details_vente(Details_Ventes detail_vente)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_details_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_vente", SqlDbType.Int)).Value = detail_vente.Num_details_vente;
                cmd.Parameters.Add(new SqlParameter("date_details_vente", SqlDbType.DateTime)).Value = detail_vente.Date_details_vente;
                cmd.Parameters.Add(new SqlParameter("num_vente", SqlDbType.Int)).Value = detail_vente.Num_vente;
                cmd.Parameters.Add(new SqlParameter("num_details", SqlDbType.Int)).Value = detail_vente.Num_details;
                cmd.Parameters.Add(new SqlParameter("qte_sortie", SqlDbType.Int)).Value = detail_vente.Qte_sortie;
                cmd.ExecuteNonQuery();
                notify.notifier("Produit aouté dans le panier!");
                MessageBox.Show("Produit aouté dans le panier!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void recuperer_facture_details(Details_Ventes detail_vente, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_facture_details", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_vente", SqlDbType.Int)).Value = detail_vente.Num_vente;

                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                //notify.notifier("Article retiré!");
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
        public void recuperer_total_facture(Details_Ventes detail_vente)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_total_facture", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_vente", SqlDbType.Int)).Value = detail_vente.Num_vente;

                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    if(dr[0]!=DBNull.Value)
                    {
                        detail_vente.Total_facture_dollars = Convert.ToInt32(dr[0]);
                        detail_vente.Total_facture_fc = Convert.ToInt32(dr[1]);                        
                    }
                    else
                    {
                        detail_vente.Total_facture_dollars = 0;
                        detail_vente.Total_facture_fc = 0;
                    }
                    
                }
                //notify.notifier("Article retiré!");
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
        public void supprimer_details_vente(Details_Ventes detail_vente)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_details_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details_vente", SqlDbType.Int)).Value = detail_vente.Num_details_vente;

                cmd.ExecuteNonQuery();
                notify.notifier("Article retiré!");
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
