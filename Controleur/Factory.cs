using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modele;
using MySql.Data.MySqlClient.Memcached;

namespace Controleur
{
    public class Factory
    {
        static MySqlConnection conn = null;

        public static void initialiserConn()
        {
            string password = "Umukama153";
            string chaine = "Server=localhost; Database=newbar; port=3306; User Id= Umukama; Password = " + password;
            conn = new MySqlConnection(chaine);
        }

        #region Utilisateur
        public static void AjouterUtilisateur(UtilisateurM uti)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO utilisateurs (Matricule, Nom, Prenom, Age, Phone, Email, Sexe, Profil, Username, Password, Adresse) VALUES (@matricule, @nom, @prenom, @age, @phone, @email, @sexe, @profil, @username, @password, @adresse)";
                cmd.Parameters.Add(new MySqlParameter("@matricule", uti.Matricule));
                cmd.Parameters.Add(new MySqlParameter("@nom", uti.Nom));
                cmd.Parameters.Add(new MySqlParameter("@prenom", uti.Prenom));
                cmd.Parameters.Add(new MySqlParameter("@age", uti.Age));
                cmd.Parameters.Add(new MySqlParameter("@phone", uti.Phone));
                cmd.Parameters.Add(new MySqlParameter("@email", uti.Email));
                cmd.Parameters.Add(new MySqlParameter("@sexe", uti.Sexe));
                cmd.Parameters.Add(new MySqlParameter("@profil", uti.Profil));
                cmd.Parameters.Add(new MySqlParameter("@username", uti.Username));
                cmd.Parameters.Add(new MySqlParameter("@password", uti.Password));
                cmd.Parameters.Add(new MySqlParameter("@adresse", uti.Adresse));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public static ArrayList obtenirTousUtilisateurs()
        {
            initialiserConn();
            ArrayList utulisateurs = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM utilisateurs";
            MySqlDataReader dtr = cmd.ExecuteReader();

            UtilisateurM uti = null;
            try
            {
                while (dtr.Read())
                {
                    uti = new UtilisateurM();
                    uti.Matricule = dtr["matricule"].ToString();
                    uti.Nom = dtr["nom"].ToString();
                    uti.Prenom = dtr["prenom"].ToString();
                    uti.Age = int.Parse(dtr["age"].ToString());
                    uti.Phone = dtr["phone"].ToString();
                    uti.Email = dtr["email"].ToString();
                    uti.Sexe = dtr["sexe"].ToString();
                    uti.Profil = dtr["profil"].ToString();
                    uti.Username = dtr["username"].ToString();
                    uti.Password = dtr["password"].ToString();
                    uti.Adresse = dtr["adresse"].ToString();
                    utulisateurs.Add(uti);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return utulisateurs;
        }


        public static UtilisateurM obtenirUtilisateurParMatricule(string matricule)
        {
            UtilisateurM uti = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM utilisateurs WHERE Matricule = @mat";
            cmd.Parameters.Add(new MySqlParameter("@mat", matricule));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    uti = new UtilisateurM();
                    uti.Matricule = dtr["matricule"].ToString();
                    uti.Nom = dtr["nom"].ToString();
                    uti.Prenom = dtr["prenom"].ToString();
                    uti.Age = int.Parse(dtr["age"].ToString());
                    uti.Phone = dtr["phone"].ToString();
                    uti.Email = dtr["email"].ToString();
                    uti.Sexe = dtr["sexe"].ToString();
                    uti.Profil = dtr["profil"].ToString();
                    uti.Username = dtr["username"].ToString();
                    uti.Password = dtr["password"].ToString();
                    uti.Adresse = dtr["adresse"].ToString();

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return uti;
        }


        public static void supprimerUtilisateur(UtilisateurM uti)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM utilisateurs WHERE Matricule = @ma";
            cmd.Parameters.Add(new MySqlParameter("@ma", uti.Matricule));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ModifierUtilisateur(UtilisateurM uti)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "UPDATE utilisateurs SET Nom=@nom, Prenom=@prenom, Age=@age, Phone=@phone, Email=@email, Sexe=@sexe, Profil=@profil, Username=@username, Password=@password, Adresse=@adresse WHERE Matricule = @ma";
            commande.Parameters.Add(new MySqlParameter("@ma", uti.Matricule));
            commande.Parameters.Add(new MySqlParameter("@nom", uti.Nom));
            commande.Parameters.Add(new MySqlParameter("@prenom", uti.Prenom));
            commande.Parameters.Add(new MySqlParameter("@age", uti.Age));
            commande.Parameters.Add(new MySqlParameter("@phone", uti.Phone));
            commande.Parameters.Add(new MySqlParameter("@email", uti.Email));
            commande.Parameters.Add(new MySqlParameter("@sexe", uti.Sexe));
            commande.Parameters.Add(new MySqlParameter("@profil", uti.Profil));
            commande.Parameters.Add(new MySqlParameter("@username", uti.Username));
            commande.Parameters.Add(new MySqlParameter("@password", uti.Password));
            commande.Parameters.Add(new MySqlParameter("@adresse", uti.Adresse));
            commande.ExecuteNonQuery();
            conn.Close();
        }

        public static UtilisateurM userLogin(string username, string password)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM utilisateurs WHERE Username = @username AND Password = @password";
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@password", password));
            MySqlDataReader dr = cmd.ExecuteReader();

            UtilisateurM ut = null;
            try
            {
                if (dr.Read())
                {
                    ut = new UtilisateurM();
                    ut.Matricule = dr["matricule"].ToString();
                    ut.Nom = dr["nom"].ToString();
                    ut.Prenom = dr["prenom"].ToString();
                    ut.Age = int.Parse(dr["age"].ToString());
                    ut.Phone = dr["phone"].ToString();
                    ut.Email = dr["email"].ToString();
                    ut.Sexe = dr["sexe"].ToString();
                    ut.Profil = dr["profil"].ToString();
                    ut.Username = dr["username"].ToString();
                    ut.Password = dr["password"].ToString();
                    ut.Adresse = dr["adresse"].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dr.Close();
                conn.Close();
                throw excpt;
            }
            return ut;
        }
        #endregion

        #region Client
        public static void AjouterClient(ClientM cli)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO clients (ID, Nom, Prenom, Phone, Adresse, Nationalite, Sexe) VALUES (@id, @nom, @prenom, @phone, @adresse, @nationalite, @sexe)";
                cmd.Parameters.Add(new MySqlParameter("@id", cli.Id));
                cmd.Parameters.Add(new MySqlParameter("@nom", cli.Nom));
                cmd.Parameters.Add(new MySqlParameter("@prenom", cli.Prenom));
                cmd.Parameters.Add(new MySqlParameter("@phone", cli.Phone));
                cmd.Parameters.Add(new MySqlParameter("@adresse", cli.Adresse));
                cmd.Parameters.Add(new MySqlParameter("@nationalite", cli.Nationalite));
                cmd.Parameters.Add(new MySqlParameter("@sexe", cli.Sexe));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public static ArrayList obtenirTousClients()
        {
            initialiserConn();
            ArrayList clients = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM clients";
            MySqlDataReader dtr = cmd.ExecuteReader();

            ClientM cli = null;
            try
            {
                while (dtr.Read())
                {
                    cli = new ClientM();
                    cli.Id = dtr["id"].ToString();
                    cli.Nom = dtr["nom"].ToString();
                    cli.Prenom = dtr["prenom"].ToString();
                    cli.Phone = dtr["phone"].ToString();
                    cli.Adresse = dtr["adresse"].ToString();
                    cli.Nationalite = dtr["nationalite"].ToString();
                    cli.Sexe = dtr["sexe"].ToString();
                    clients.Add(cli);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return clients;
        }


        public static ClientM obtenirClientParId(string id)
        {
            ClientM cli = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM clients WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    cli = new ClientM();
                    cli.Id = dtr["id"].ToString();
                    cli.Nom = dtr["nom"].ToString();
                    cli.Prenom = dtr["prenom"].ToString();
                    cli.Phone = dtr["phone"].ToString();
                    cli.Adresse = dtr["adresse"].ToString();
                    cli.Nationalite = dtr["nationalite"].ToString();
                    cli.Sexe = dtr["sexe"].ToString();

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return cli;
        }


        public static ClientM obtenirID(string nomClient)
        {
            ClientM cli = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from clients WHERE Nom=@nom";
            cmd.Parameters.Add(new MySqlParameter("@nom", nomClient));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    cli = new ClientM();
                    cli.Id = dtr["id"].ToString();
                    cli.Nom = dtr["nom"].ToString();
                    cli.Prenom = dtr["prenom"].ToString();
                    cli.Phone = dtr["phone"].ToString();
                    cli.Adresse = dtr["adresse"].ToString();
                    cli.Nationalite = dtr["nationalite"].ToString();
                    cli.Sexe = dtr["sexe"].ToString();

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return cli;
        }


        public static void supprimerClient(ClientM cli)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM clients WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", cli.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void ModifierClient(ClientM cli)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "UPDATE clients SET Nom=@nom, Prenom=@prenom, Phone=@phone, Adresse=@adresse, Nationalite=@nationalite, Sexe=@sexe WHERE ID = @id";
            commande.Parameters.Add(new MySqlParameter("@id", cli.Id));
            commande.Parameters.Add(new MySqlParameter("@nom", cli.Nom));
            commande.Parameters.Add(new MySqlParameter("@prenom", cli.Prenom));
            commande.Parameters.Add(new MySqlParameter("@phone", cli.Phone));
            commande.Parameters.Add(new MySqlParameter("@adresse", cli.Adresse));
            commande.Parameters.Add(new MySqlParameter("@nationalite", cli.Nationalite));
            commande.Parameters.Add(new MySqlParameter("@sexe", cli.Sexe));

            commande.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region Produts
        public static void AjouterProduit(ProduitM pro)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO produits (ID, Nom, Quantite, PrixUnitaire, Volume, DateExpiration) VALUES (@id, @nom, @quantite, @prixUnitaire, @volume, @dateExpiration)";
                cmd.Parameters.Add(new MySqlParameter("@id", pro.ID));
                cmd.Parameters.Add(new MySqlParameter("@nom", pro.Nom));
                cmd.Parameters.Add(new MySqlParameter("@quantite", pro.Quantite));
                cmd.Parameters.Add(new MySqlParameter("@prixUnitaire", pro.PrixUnitaire));
                cmd.Parameters.Add(new MySqlParameter("@volume", pro.Volume));
                cmd.Parameters.Add(new MySqlParameter("@dateExpiration", pro.DateExpiration));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }



        public static ArrayList obtenirTousProduits()
        {
            initialiserConn();
            ArrayList produits = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM produits";
            MySqlDataReader dtr = cmd.ExecuteReader();

            ProduitM pro = null;
            try
            {
                while (dtr.Read())
                {
                    pro = new ProduitM();
                    pro.ID = dtr["id"].ToString();
                    pro.Nom = dtr["nom"].ToString();
                    pro.Quantite = int.Parse(dtr["quantite"].ToString());
                    pro.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    pro.Volume = float.Parse(dtr["volume"].ToString());
                    pro.DateExpiration = DateTime.Parse(dtr["dateExpiration"].ToString());
                    produits.Add(pro);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return produits;
        }


        public static ArrayList obtenirTousProduitsVersVentes()
        {
            initialiserConn();
            ArrayList produits = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM produits";
            MySqlDataReader dtr = cmd.ExecuteReader();

            ProduitM pro = null;
            try
            {
                while (dtr.Read())
                {
                    pro = new ProduitM();
                    pro.ID = dtr["id"].ToString();
                    pro.Nom = dtr["nom"].ToString();
                    produits.Add(pro);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return produits;
        }


        public static ProduitM obtenirProduitParId(string id)
        {
            ProduitM pro = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM produits WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    pro = new ProduitM();
                    pro.ID = dtr["id"].ToString();
                    pro.Nom = dtr["nom"].ToString();
                    pro.Quantite = int.Parse(dtr["quantite"].ToString());
                    pro.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    pro.Volume = float.Parse(dtr["volume"].ToString());
                    pro.DateExpiration = DateTime.Parse(dtr["dateExpiration"].ToString());

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return pro;
        }


        public static void supprimerProduit(ProduitM pro)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM produits WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", pro.ID));
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void ModifierProduit(ProduitM pro)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "UPDATE produits SET Nom=@nom, Quantite=@quantite, PrixUnitaire=@prixUnitaire, Volume=@volume, DateExpiration=@dateExpiration WHERE ID = @id";
            commande.Parameters.Add(new MySqlParameter("@id", pro.ID));
            commande.Parameters.Add(new MySqlParameter("@nom", pro.Nom));
            commande.Parameters.Add(new MySqlParameter("@quantite", pro.Quantite));
            commande.Parameters.Add(new MySqlParameter("@prixUnitaire", pro.PrixUnitaire));
            commande.Parameters.Add(new MySqlParameter("@volume", pro.Volume));
            commande.Parameters.Add(new MySqlParameter("@dateExpiration", pro.DateExpiration));

            commande.ExecuteNonQuery();
            conn.Close();
        }

        public static ProduitM obtenirPU(string nomProduit)
        {
            ProduitM pro = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from produits WHERE Nom=@nom";
            cmd.Parameters.Add(new MySqlParameter("@nom", nomProduit));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    pro = new ProduitM();
                    pro.ID = dtr["id"].ToString();
                    pro.Nom = dtr["nom"].ToString();
                    pro.Quantite = int.Parse(dtr["quantite"].ToString());
                    pro.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    pro.Volume = float.Parse(dtr["volume"].ToString());
                    pro.DateExpiration = DateTime.Parse(dtr["dateExpiration"].ToString());

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return pro;
        }

        #endregion

        #region Vente
        public static void AjouterVente(VenteM ve)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO ventes (ID, Client, Produit, Quantite, PrixUnitaire, PrixTotal, DateOperation) VALUES (@id, @client, @produit, @quantite, @prixUnitaire, @prixTotal, @dateOperation)";
                cmd.Parameters.Add(new MySqlParameter("id", ve.Id));
                cmd.Parameters.Add(new MySqlParameter("@client", ve.Client));
                cmd.Parameters.Add(new MySqlParameter("@produit", ve.Produit));
                cmd.Parameters.Add(new MySqlParameter("@quantite", ve.Quantite));
                cmd.Parameters.Add(new MySqlParameter("@prixUnitaire", ve.PrixUnitaire));
                cmd.Parameters.Add(new MySqlParameter("@prixTotal", ve.PrixTotal));
                cmd.Parameters.Add(new MySqlParameter("@dateOperation", ve.DateOperation));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public static ArrayList obtenirTousVentes()
        {
            initialiserConn();
            ArrayList ventes = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ventes";
            MySqlDataReader dtr = cmd.ExecuteReader();

            VenteM ve = null;
            try
            {
                while (dtr.Read())
                {
                    ve = new VenteM();
                    ve.Id = dtr["ID"].ToString();
                    ve.Client = dtr["client"].ToString();
                    ve.Produit = dtr["produit"].ToString();
                    ve.Quantite = int.Parse(dtr["quantite"].ToString());
                    ve.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    ve.PrixTotal = float.Parse(dtr["prixTotal"].ToString());
                    ve.DateOperation = DateTime.Parse(dtr["dateOperation"].ToString());
                    ventes.Add(ve);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return ventes;
        }


        public static VenteM obtenirVenteParId(string id)
        {
            VenteM ve = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ventes WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", id));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    ve = new VenteM();
                    ve.Id = dtr["id"].ToString();
                    ve.Client = dtr["client"].ToString();
                    ve.Produit = dtr["produit"].ToString();
                    ve.Quantite = int.Parse(dtr["quantite"].ToString());
                    ve.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    ve.PrixTotal = float.Parse(dtr["prixTotal"].ToString());
                    ve.DateOperation = DateTime.Parse(dtr["dateOperation"].ToString());

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return ve;
        }

        /*public static VenteM obtenirVentesParProduit(string produit)
        {
            VenteM ve = null;
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ventes WHERE produit = @produit";
            cmd.Parameters.Add(new MySqlParameter("@produit", produit));

            MySqlDataReader dtr = cmd.ExecuteReader();

            try
            {
                if (dtr.Read())
                {
                    ve = new VenteM();
                    ve.Id = dtr["id"].ToString();
                    ve.Client = dtr["client"].ToString();
                    ve.Produit = dtr["produit"].ToString();
                    ve.Quantite = int.Parse(dtr["quantite"].ToString());
                    ve.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    ve.PrixTotal = float.Parse(dtr["prixTotal"].ToString());
                    ve.DateOperation = DateTime.Parse(dtr["dateOperation"].ToString());

                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception excpt)
            {
                dtr.Close();
                conn.Close();
                throw excpt;
            }
            return ve;
        }*/

        public static ArrayList obtenirTousVentesParProduit(string produit)
        {
            initialiserConn();
            ArrayList ventes = new ArrayList();
            if (conn.State != ConnectionState.Open) conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ventes WHERE produit = @produit";
            cmd.Parameters.Add(new MySqlParameter("@produit", produit));
            MySqlDataReader dtr = cmd.ExecuteReader();

            VenteM ve = null;
            try
            {
                while (dtr.Read())
                {
                    ve = new VenteM();
                    ve.Id = dtr["ID"].ToString();
                    ve.Client = dtr["client"].ToString();
                    ve.Produit = dtr["produit"].ToString();
                    ve.Quantite = int.Parse(dtr["quantite"].ToString());
                    ve.PrixUnitaire = double.Parse(dtr["prixUnitaire"].ToString());
                    ve.PrixTotal = float.Parse(dtr["prixTotal"].ToString());
                    ve.DateOperation = DateTime.Parse(dtr["dateOperation"].ToString());
                    ventes.Add(ve);
                }
                dtr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                dtr.Close();
                conn.Close();
                throw exc;
            }
            return ventes;
        }

        public static void supprimerVente(VenteM ve)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM ventes WHERE ID = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", ve.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void ModifierVente(VenteM ve)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "UPDATE ventes SET Client = @client, Produit = @produit, Quantite = @quantite, PrixUnitaire = @pu, PrixTotal = @pt WHERE ID = @id";
            commande.Parameters.Add(new MySqlParameter("@id", ve.Id));
            commande.Parameters.Add(new MySqlParameter("@client", ve.Client));
            commande.Parameters.Add(new MySqlParameter("@produit", ve.Produit));
            commande.Parameters.Add(new MySqlParameter("@quantite", ve.Quantite));
            commande.Parameters.Add(new MySqlParameter("@pu", ve.PrixUnitaire));
            commande.Parameters.Add(new MySqlParameter("@pt", ve.PrixTotal));

            commande.ExecuteNonQuery();
            conn.Close();
        }


        public static void QuantiteRestante(ProduitM pro)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "UPDATE produits SET Quantite = @quantite WHERE Nom = @nom";
            commande.Parameters.Add(new MySqlParameter("@nom", pro.Nom));
            commande.Parameters.Add(new MySqlParameter("@quantite", pro.Quantite));

            commande.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
    }
}
