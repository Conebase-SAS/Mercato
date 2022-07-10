use master;
go
drop database db_mercato
go
if not exists(select * from sys.databases where name='db_mercato')
	create database db_mercato;
go
use db_mercato;
go
------------------------------------------FOURNISSEURS------------------------------------------------------------------
create table t_fournisseurs
(
    id_fournisseurs nvarchar(50),
    designation_fournisseurs nvarchar(100),
    telephone nvarchar(50),
    constraint pk_fournisseurs primary key(id_fournisseurs)
)
go
create procedure afficher_fournisseurs
as
select top 50 
    id_fournisseurs as 'ID',
    designation_fournisseurs as 'Designation',
    telephone as 'Télephone'
from t_fournisseurs
    order by id_fournisseurs asc
go
create procedure charger_fournisseurs
as
select 
    id_fournisseurs
from t_fournisseurs
    order by id_fournisseurs asc
go
create procedure enregistrer_fournisseurs
@id_fournisseurs nvarchar(50),
@designation_fournisseurs nvarchar(100),
@telephone nvarchar(50)
as
    merge into t_fournisseurs
	using(select @id_fournisseurs as x_id) as x_source
	on (x_source.x_id=t_fournisseurs.id_fournisseurs)
	when matched then	
		update set
            designation_fournisseurs=@designation_fournisseurs,
            telephone=@telephone
    when not matched then
        insert
            (id_fournisseurs, designation_fournisseurs, telephone)
        values
            (@id_fournisseurs, @designation_fournisseurs, @telephone);
go
create procedure supprimer_fournisseur
@id_fournisseurs nvarchar(50)
as
    delete from t_fournisseurs
        where id_fournisseurs like @id_fournisseurs
go
-----------------------------------------FIN FOURNISSEURS---------------------------------------------------------------
------------------------------------------DEBUT CODE DEPOT -------------------------------------------------------------
create table t_depot
(
    id_depot nvarchar(50),
    designation_depot nvarchar(100),
    telephone nvarchar(50),
    constraint pk_depot primary key(id_depot)
)
go
create procedure afficher_depot
as
    select top 50 
        id_depot as 'ID',
        designation_depot as 'Designation',
        telephone as 'Télephone'
    from t_depot
        order by id_depot asc
go
create procedure charger_depot
as
    select id_depot from t_depot
    order by id_depot asc
go
create procedure enregistrer_depot
@id_depot nvarchar(50),
@designation_depot nvarchar(100),
@telephone nvarchar(50)
as
    merge into t_depot
	using(select @id_depot as x_nif) as x_source
	on (x_source.x_nif=t_depot.id_depot)
	when matched then	
		update set
            designation_depot=@designation_depot,
            telephone=@telephone
    when not matched then
        insert
            (id_depot, designation_depot, telephone)
        values
            (@id_depot, @designation_depot, @telephone);
go
create procedure supprimer_depot
@id_depot nvarchar(50)
as
    delete from t_depot
        where id_depot like @id_depot
go
----------------------------------------FIN CODE DEPOT----------------------------------------------------------------

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
---------------------------------------CODES POUR PAQUETAGE--------------------------------------------------------
create table t_paquetage
(
    id_paquetage nvarchar(50),
    designation_paquetage nvarchar(100),
    constraint pk_paquetage primary key(id_paquetage)
)
go
create procedure afficher_paquetage
as
select top 50
    id_paquetage as 'ID',
    designation_paquetage as 'Designation'
from t_paquetage
    order by id_paquetage asc
go
create procedure charger_paquetage
as
select 
    id_paquetage 
from t_paquetage
    order by id_paquetage asc
go
create procedure enregistrer_paquetage
@id_paquetage nvarchar(50),
@designation_paquetage nvarchar(100)
as
    merge into t_paquetage
	using(select @id_paquetage as x_id) as x_source
	on (x_source.x_id=t_paquetage.id_paquetage)
	when matched then	
		update set
            designation_paquetage=@designation_paquetage
    when not matched then
        insert
            (id_paquetage, designation_paquetage)
        values
            (@id_paquetage, @designation_paquetage);
go
create procedure supprimer_paquetage
@id_paquetage nvarchar(50)
as
    delete from t_paquetage
        where id_paquetage like @id_paquetage
go
---------------------------------------Fin des codes pour paquetage-----------------------------------------------
---------------------------------------Debut des codes pour types articles----------------------------------------
create table t_types_articles
(
    id_types_articles nvarchar(50),
    designation_types_articles nvarchar(100),
    constraint pk_types_articles primary key(id_types_articles)
)
go
create procedure afficher_types_articles
as
select top 50
    id_types_articles as 'ID',
    designation_types_articles as 'Designation'
from t_types_articles
    order by id_types_articles asc
go
create procedure charger_types_articles
as
select 
    id_types_articles 
from t_types_articles
    order by id_types_articles asc
go
create procedure enregistrer_types_articles
@id_types_articles nvarchar(50),
@designation_types_articles nvarchar(100)
as
    merge into t_types_articles
	using(select @id_types_articles as x_id) as x_source
	on (x_source.x_id=t_types_articles.id_types_articles)
	when matched then	
		update set
            designation_types_articles=@designation_types_articles
    when not matched then
        insert
            (id_types_articles, designation_types_articles)
        values
            (@id_types_articles, @designation_types_articles);
go
create procedure supprimer_types_articles
@id_types_articles nvarchar(50)
as
    delete from t_types_articles
        where id_types_articles like @id_types_articles
go
---------------------------------------Fin des codes pour types articles------------------------------------------
---------------------------------------Début des codes pour catégories articles ----------------------------------
create table t_categories_articles
(
    id_categories_articles nvarchar(50),
    designation_categories_articles nvarchar(100),
    constraint pk_categories_articles primary key(id_categories_articles)
)
go
create procedure afficher_catégorie_articles
as
select top 50 
    id_categories_articles as 'ID',
    designation_categories_articles as 'Désignation'
from t_categories_articles
    order by
        id_categories_articles asc
go
create procedure charger_categories_articles
as
select 
    id_categories_articles
from t_categories_articles 
    order by id_categories_articles asc
go
create procedure enregistrer_categories_articles
@id_categories_articles nvarchar(50),
@designation_categories_articles nvarchar(100)
as
    merge into t_categories_articles
	using(select @id_categories_articles as x_id) as x_source
	on (x_source.x_id=t_categories_articles.id_categories_articles)
	when matched then	
		update set
            designation_categories_articles=@designation_categories_articles
    when not matched then
        insert
            (id_categories_articles, designation_categories_articles)
        values
            (@id_categories_articles, @designation_categories_articles);
go
create procedure supprimer_categories_articles
@id_categories_articles nvarchar(50)
as
    delete from t_categories_articles
        where @id_categories_articles like @id_categories_articles
go
--------------------------------------Fin des codes pour catégories d'articles------------------------------------
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
create procedure afficher_articles
as
select top 50
    id_article as 'ID',
    designation_article as 'Designation'
from t_articles
    order by id_article asc
go
create procedure charger_listbox_article
as
select top 50 
    id_article as 'ID'
from t_articles
order by id_article asc
go
create procedure enregistrer_articles
@id_article nvarchar(50),
@designation_article nvarchar(100),
@id_categories_articles nvarchar(50),
@id_types_articles nvarchar(50),
@id_paquetage nvarchar(50),
@description_articles nvarchar(max)
as
    merge into t_articles
	using(select @id_article as x_id) as x_source
	on (x_source.x_id=t_articles.id_article)
	when matched then	
		update set
            designation_article=@designation_article,
            id_categories_articles=@id_categories_articles,
            id_types_articles=@id_types_articles,
            id_paquetage=@id_paquetage,
            description_articles=@description_articles
    when not matched then
        insert
            (id_article, designation_article, id_categories_articles, id_types_articles, id_paquetage, description_articles)
        values
            (@id_article,@designation_article, @id_categories_articles, @id_types_articles, @id_paquetage, @description_articles);
go
create procedure supprimer_articles
@id_article nvarchar(50)
as
    delete from t_articles
        where id_article like @id_article
go
------ Concernant la vente des produits --------------------------------------------
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
create table t_approvisionnement
(
    num_details int identity,
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
    points int,
    status_vente nvarchar(50) -----to be sold, on hold, expired
    constraint pk_details_approv primary key(num_details),
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
    constraint fk_details_details foreign key(num_details) references t_approvisionnement(num_details) 
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
    constraint fk_vente_paiement foreign key(num_vente) references t_ventes(num_vente) on update cascade
)
go
-------------------Fin de la partie concernant les produits ------------------------------------------------------
-------------------Debut de la vente des services et autres ------------------------------------------------------
create table t_composants
(
    id_composant nvarchar(50),
    designation nvarchar(max),
    constraint pk_composant primary key(id_composant)
)
go
create table t_approv_composants
(
    num_approv_composant int identity,
    id_composant nvarchar(50),
    date_approv date,
    qte_entree int,
    date_expiration date,
    constraint pk_approv_composant primary key(num_approv_composant),
    constraint fk_composant_approv foreign key(id_composant) references t_composants(id_composant) on update cascade
)
go
create table t_menu
(
    id_menu nvarchar(50),
    designation nvarchar(50),
    constraint pk_menu primary key(id_menu)
)
go
create table t_composition_menu
(
    num_composition int identity,
    date_composition date,
    num_approv_composant int,
    id_menu nvarchar(50),
    qte_composee int,
    constraint pk_composition primary key(num_composition),
    constraint fk_menu_approv foreign key(id_menu) references t_menu(id_menu),
    constraint fk_approv_composant foreign key(num_approv_composant) references t_approv_composants(num_approv_composant)
)
go
create table t_agents
(
    id_agent nvarchar(50),
    noms nvarchar(100),
    constraint pk_agents primary key(id_agent)
)
go
create table t_commandes
(
    num_commandes int identity,
    id_clients nvarchar(50),
    date_commandes date,
    id_agent nvarchar(50),
    constraint pk_commandes primary key(num_commandes),
    constraint fk_agent foreign key(id_agent) references t_agents(id_agent),
    constraint fk_client_commandes foreign key (id_clients) references t_clients(id_clients)
)
go
create table t_details_commandes 
(
    num_details_commandes int identity,
    num_commandes int,
    id_menu nvarchar(50),
    qte int,
    prix_actuel decimal,
    constraint pk_details_commandes primary key(num_details_commandes),
    constraint fk_commandes_details foreign key(num_commandes) references t_commandes(num_commandes),
    constraint fk_details_menu foreign key(id_menu) references t_menu(id_menu)
)
go
create table t_paiement_commande
(
    num_paiement int identity,
    date_paiement date,
    num_commandes int,
    montant_paye decimal,
    reste decimal,
    constraint pk_paiement_commande primary key(num_paiement),
    constraint fk_commande_paie foreign key(num_commandes) references t_commandes(num_commandes)
)
go
