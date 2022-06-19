use master;
go
drop database db_mercato
go
if not exists(select * from sys.databases where name='db_mercato')
	create database db_mercato;
go
use db_mercato;
go
create table t_fournisseurs
(
    id_fournisseurs nvarchar(50),
    designation_fournisseurs nvarchar(100),
    telephone nvarchar(50),
    constraint pk_fournisseurs primary key(id_fournisseurs)
)
go
create table t_depot
(
    id_depot nvarchar(50),
    designation_depot nvarchar(100),
    telephone nvarchar(50),
    constraint pk_depot primary key(id_depot)
)
go
create table t_clients
(
    id_clients nvarchar(50),
    noms nvarchar(100),
    adresse nvarchar(max),
    telephone_mobile nvarchar(50),
    telephone_work nvarchar(50),
    constraint pk_clients primary key(id_clients)
)
go
create table t_boutique
(
    id_boutique nvarchar(50),
    designation nvarchar(100),
    mot_de_passe Binary,
    constraint pk_boutique primary key(id_boutique)
)
go
create table t_approvisionnement
(
    num_approvisionnement int identity,
    date_approvisionnement date,
    constraint pk_approvisionnement primary key(num_approvisionnement)
)
go
create table t_paquetage
(
    id_paquetage nvarchar(50),
    designation_paquetage nvarchar(100),
    constraint pk_paquetage primary key(id_paquetage)
)
go
create table t_types_articles
(
    id_types_articles nvarchar(50),
    designation_types_articles nvarchar(100),
    constraint pk_types_articles primary key(id_types_articles)
)
go
create table t_categories_articles
(
    id_categories_articles nvarchar(50),
    designation_categories_articles nvarchar(100),
    constraint pk_categories_articles primary key(id_categories_articles)
)
go
create table t_articles
(
    id_article nvarchar(50),
    designation_article nvarchar(100),
    id_categories_articles nvarchar(50),
    id_types_articles nvarchar(50),
    id_paquetage nvarchar(50),
    description_articles nvarchar(max),
    constraint pk_articles primary key(id_article),
    constraint fk_article_paquetage foreign key(id_paquetage) references t_paquetage(id_paquetage),
    constraint fk_article_categorie foreign key(id_categories_articles) references t_categories_articles(id_categories_articles),
    constraint fk_article_types foreign key(id_types_articles) references t_types_articles(id_types_articles)
)
go
create table t_ventes
(
    num_vente int identity,
    date_vente date,
    id_boutique nvarchar(50),
    id_clients nvarchar(50),
    description_ventes nvarchar(100),
    constraint pk_ventes primary key(num_vente),
    constraint fk_vente_boutique foreign key(id_boutique) references t_boutique(id_boutique),
    constraint fk_vente_client foreign key(id_clients) references t_clients(id_clients)
)
go
create table t_details_approvisionnement
(
    num_details int identity,
    num_approvisionnement int,
    date_details date,
    id_article nvarchar(50),
    prix_achat_$ decimal,
    prix_achat_fc decimal,
    qte_entree decimal,
    id_fournisseurs nvarchar(50),
    date_expiration date,
    date_debut_solde date,
    date_fin_solde date,
    prix_vente_$ decimal,
    prix_vente_fc decimal,
    prix_solde_$ decimal,
    prix_solde_fc decimal,
    id_depot nvarchar(50),
    status_vente nvarchar(50) -----to be sold, on hold, expired
    constraint pk_details_approv primary key(num_details),
    constraint fk_approv_details foreign key(num_approvisionnement) references t_approvisionnement(num_approvisionnement),
    constraint fk_approvisionnement_fournisseur foreign key(id_fournisseurs) references t_fournisseurs(id_fournisseurs),
    constraint fk_details_depot foreign key(id_depot) references t_depot(id_depot),
    constraint fk_article_details_approv foreign key(id_article) references t_articles(id_article)
)
go
create table t_details_vente
(
    num_details_vente int identity,
    date_details_vente date,
    num_vente int,
    num_details int,
    qte_sortie int,
    constraint pk_details_vente primary key(num_details_vente),
    constraint fk_details_num_vente foreign key(num_vente) references t_ventes(num_vente),
    constraint fk_details_details foreign key(num_details) references t_details_approvisionnement(num_details) 
)
go
create table t_paiement
(
    num_paiement int identity,
    date_paiement date,
    num_vente int,
    montant_paye_$ decimal,
    montant_paye_fc decimal,
    solde_restant decimal,
    constraint pk_paiement primary key(num_paiement),
    constraint fk_vente_paiement foreign key(num_vente) references t_ventes(num_vente)
)