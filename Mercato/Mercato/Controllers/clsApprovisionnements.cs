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
    class clsApprovisionnements
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        Approvisionnement approvisionnement = new Approvisionnement();
        Notification_Center notify = new Notification_Center();

        
        public void afficher_approvisionnement(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_approvisionnement", cnx)
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
        public void afficher_articles_disponible(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_articles_disponible", cnx)
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
        public void rechercher_articles_disponible_nom(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_articles_disponible_nom", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.Id_article;
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
        public void rechercher_articles_disponible_serie(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_articles_disponible_serie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.Numero_serie;
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
        public void rechercher_articles_disponible_specs(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_articles_disponible_specs", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.Caracteristiques;
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
        public void rechercher_approvisionnement_fournisseur(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_approvisionnement_fournisseur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.ID_fournisseurs;
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
        public void rechercher_approvisionnement_produit(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_approvisionnement_produit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.Id_article;
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
        public void rechercher_approvisionnement_details(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_approvisionnement_details", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.num_details;
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
        public void rechercher_approvisionnement_vente(DataGridView dtg, Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_approvisionnement_vente", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = approvisionnement.stats_vente;
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
        public void charger_listbox_article(ListBox lst)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_listbox_article", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
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
        public void enregistrer_approvisionement(Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_approvisionement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details", SqlDbType.Int)).Value = approvisionnement.num_details;
                cmd.Parameters.Add(new SqlParameter("id_article", SqlDbType.NVarChar)).Value = approvisionnement.Id_article;
                cmd.Parameters.Add(new SqlParameter("numero_serie", SqlDbType.NVarChar)).Value = approvisionnement.Numero_serie;
                cmd.Parameters.Add(new SqlParameter("id_couleur", SqlDbType.NVarChar)).Value = approvisionnement.Id_couleur;
                cmd.Parameters.Add(new SqlParameter("id_caracteristiques", SqlDbType.NVarChar)).Value = approvisionnement.Caracteristiques;
                cmd.Parameters.Add(new SqlParameter("prix_achat_$", SqlDbType.Decimal)).Value = approvisionnement.prix_achat_usd;
                cmd.Parameters.Add(new SqlParameter("prix_achat_fc", SqlDbType.Decimal)).Value = approvisionnement.prix_achat_fc;
                cmd.Parameters.Add(new SqlParameter("qte_entree", SqlDbType.Decimal)).Value = approvisionnement.qte_entree;
                cmd.Parameters.Add(new SqlParameter("id_fournisseurs", SqlDbType.NVarChar)).Value = approvisionnement.ID_fournisseurs;
                cmd.Parameters.Add(new SqlParameter("date_expiration", SqlDbType.DateTime)).Value = approvisionnement.Date_expriation;
                cmd.Parameters.Add(new SqlParameter("prix_vente_$", SqlDbType.Decimal)).Value = approvisionnement.prix_vente_usd;
                cmd.Parameters.Add(new SqlParameter("prix_vente_fc", SqlDbType.Decimal)).Value = approvisionnement.prix_vente_fc;
                cmd.Parameters.Add(new SqlParameter("id_depot", SqlDbType.NVarChar)).Value = approvisionnement.ID_Depot;
                cmd.Parameters.Add(new SqlParameter("points", SqlDbType.Int)).Value = approvisionnement.points;
                cmd.Parameters.Add(new SqlParameter("status_vente", SqlDbType.NVarChar)).Value = approvisionnement.stats_vente;

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
        public void supprimer_approvisionnement(Approvisionnement approvisionnement)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_approvisionnement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details", SqlDbType.Int)).Value = approvisionnement.num_details;

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
        public void sortie_par_article(Approvisionnement approvisionnement, Calculs calcul)
        {
            cnx = new SqlConnection(datas.getInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("sortie_par_article", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("num_details", SqlDbType.Int)).Value = approvisionnement.num_details;

                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if(dr[0]!=null)
                    {
                        calcul.Qte_sortie = Convert.ToInt32(dr[0]);
                    }
                    else
                    {
                        calcul.Qte_sortie = 0;
                    }
                }
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
