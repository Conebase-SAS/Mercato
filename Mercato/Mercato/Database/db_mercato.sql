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
    insert into t_fournisseurs
        (id_fournisseurs, designation_fournisseurs, telephone)
    values
        ('Dubai Mall','Dubai Big Mall','+243977551835'),
        ('Dubai Sharjah','Dubai Sharjah Big Mall','+243824212440')
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
    insert into t_depot
        (id_depot,designation_depot,telephone)
    values
        ('Rusina 1','Rusina Big Store','+243')
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
----------------------------------------Codes pour les clients--------------------------------------------------------
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
    insert into t_clients
        (id_clients,noms, adresse, telephone_mobile, telephone_work)
    values
        ('Client 0','Client ordinaire','Av.Tulipiers, 3','+24399','+24382')
go
create procedure afficher_clients
as
select top 50 
    id_clients as 'ID',
    noms as 'Noms',
    adresse as 'Adresse',
    telephone_mobile as 'Mobile n°1',
    telephone_work as 'Mobile n°2'
from t_clients
order by
    id_clients asc
go
alter procedure charger_clients
as
select
    id_clients
from t_clients
order by noms asc
go
create procedure rechercher_clients_by_noms
@search nvarchar(50)
as
select top 50 
    id_clients as 'ID',
    noms as 'Noms',
    adresse as 'Adresse',
    telephone_mobile as 'Mobile n°1',
    telephone_work as 'Mobile n°2'
from t_clients
    where noms like '%'+@search+'%'
order by
    id_clients asc
go
create procedure enregistrer_client
@id_clients nvarchar(100),
@noms nvarchar(100),
@adresse nvarchar(max),
@telephone_mobile nvarchar(50),
@telephone_work nvarchar(50)
as
merge into t_clients
	using(select @id_clients as x_id) as x_source
	on (x_source.x_id=t_clients.id_clients)
	when matched then	
		update set
            noms=@noms,
            adresse=@adresse,
            telephone_mobile=@telephone_mobile,
            telephone_work=@telephone_work
    when not matched then
        insert
            (id_clients, noms, adresse, telephone_mobile, telephone_work)
        values
            (@id_clients, @noms, @adresse, @telephone_mobile, @telephone_work);
go
create procedure recuperer_id_client
@noms nvarchar(50)
as
    select id_clients from t_clients where noms like @noms
go
create procedure supprimer_client
@id_clients nvarchar(50)
as
delete from t_clients where id_clients like '%'+@id_clients+'%'
go
---------------------------------------Fin des codes pour les clients------------------------------------------------
---------------------------------------Debut codes pour les compagnies-----------------------------------------------
create table t_compagnie
(
    id_compagnie nvarchar(50),
    designation nvarchar(100),
    telephone nvarchar(50),
    constraint pk_compagnie primary key(id_compagnie)
)
go
    insert into t_compagnie
        (id_compagnie,designation,telephone)
    values
        ('Conebase','Conebase SAS','+243'),
        ('one Horizon','one Horizon SAS', '+243')
go
create procedure afficher_compagnie
as
select top 50
    id_compagnie as 'ID Entreprise',
    designation as 'Description',
    telephone as 'Téléphone'
from t_compagnie
    order by id_compagnie asc
go
create procedure enregistrer_compagnie
@id_compagnie nvarchar(50),
@designation nvarchar(100),
@telephone nvarchar(50)
as
    merge into t_compagnie
    using(select @id_compagnie as x_id) as x_source
	on (x_source.x_id=t_compagnie.id_compagnie)
	when matched then	
		update set
            designation=@designation,
            telephone=@telephone
    when not matched then
        insert
            (id_compagnie, designation, telephone)
        values
            (@id_compagnie, @designation, @telephone);
go
create procedure supprimer_compagnie
@id_compagnie nvarchar(50)
as
    delete from t_compagnie
        where id_compagnie like @id_compagnie
go
insert into t_compagnie
    (id_compagnie, designation, telephone)
values
    ('Conebase SAS','Conebase SAS', '+243977551835');
go
--------------------------------------Fin des codes pour la comagnie------------------------------------------------
--------------------------------------Début codes pour la boutique -------------------------------------------------
create table t_boutique
(
    id_boutique nvarchar(50),
    designation nvarchar(100),
    mot_de_passe nvarchar(100),
    id_compagnie nvarchar(50),
    extension nvarchar(50),
    admin_level nvarchar(50),
    constraint pk_boutique primary key(id_boutique),
    constraint fk_boutique_compagnie foreign key(id_compagnie) references t_compagnie(id_compagnie) on update cascade on delete cascade
)
go
    insert into t_boutique
        (id_boutique,designation,mot_de_passe,id_compagnie,extension,admin_level)
    values
        ('Weka','Conebase - Weka project', '12345', 'Conebase', '647437HJSJSDBHSDQDQJ','Admin'),
        ('Rusina Shop','one Horizon - Weka project', '12345', 'one Horizon', '647437HJSJSDBHSDQDQJ','Admin')
go
create procedure enregistrer_boutique
@id_boutique nvarchar(50),
@designation nvarchar(100),
@mot_de_passe nvarchar(50),
@id_compagnie nvarchar(50),
@admin_level nvarchar(50) --between 1 to 4 -1 regular user, -2 company admin, -3 Conebase Management -4 Super Manager
as
    declare @extension uniqueidentifier=newid()
    merge into t_boutique
    using (select @id_boutique as x_id) as x_source
    on (x_source.x_id=t_boutique.id_boutique)
	when matched then	
		update set
            designation=@designation,
            mot_de_passe=@mot_de_passe,
            id_compagnie=@id_compagnie,
            extension=@extension,
            admin_level=@admin_level
    when not matched then
        insert
            (id_boutique, designation, mot_de_passe, extension, id_compagnie, admin_level)
        values
            (@id_boutique, @designation, @mot_de_passe, @extension, @id_compagnie, @admin_level);
go
create procedure rechercher_login
@id_boutique nvarchar(50),
@mot_de_passe varchar(50)
as
    select        
        t_boutique.id_boutique as 'ID', 
        t_boutique.designation as 'Designation', 
        t_boutique.mot_de_passe as 'Passkey', 
        t_boutique.extension as 'Extension ID', 
        t_compagnie.id_compagnie as 'Entreprise', 
        t_compagnie.telephone as 'Telephone',
        t_boutique.admin_level as 'Admin Rights'
    from
        t_boutique inner join
            t_compagnie on t_boutique.id_compagnie = t_compagnie.id_compagnie
    where 
        id_boutique like @id_boutique and mot_de_passe=@mot_de_passe;
go
create procedure afficher_login
@id_compagnie nvarchar(50)
as
    select        
        t_boutique.id_boutique as 'ID', 
        t_boutique.designation as 'Designation', 
        t_boutique.mot_de_passe as 'Passkey', 
        t_boutique.extension as 'Extension ID', 
        t_compagnie.id_compagnie as 'Entreprise', 
        t_compagnie.telephone as 'Telephone',
        t_boutique.admin_level as 'Admin Rights'
    from
        t_boutique inner join
            t_compagnie on t_boutique.id_compagnie = t_compagnie.id_compagnie
    where
        t_compagnie.id_compagnie like @id_compagnie
go
create procedure afficher_login_par_noms
@id_boutique nvarchar(50)
as
    select        
        t_boutique.id_boutique as 'ID', 
        t_boutique.designation as 'Designation', 
        t_boutique.mot_de_passe as 'Passkey', 
        t_boutique.extension as 'Extension ID', 
        t_compagnie.id_compagnie as 'Entreprise', 
        t_compagnie.telephone as 'Telephone',
        t_boutique.admin_level as 'Admin Rights'
    from
        t_boutique inner join
            t_compagnie on t_boutique.id_compagnie = t_compagnie.id_compagnie
    where
        t_boutique.id_boutique like @id_boutique
go
--------------------------------------Fin des codes pour la boutique------------------------------------------------
---------------------------------------CODES POUR PAQUETAGE--------------------------------------------------------
create table t_paquetage
(
    id_paquetage nvarchar(50),
    designation_paquetage nvarchar(100),
    constraint pk_paquetage primary key(id_paquetage)
)
go
    insert into t_paquetage
        (id_paquetage, designation_paquetage)
    values
        ('Pièce', 'Vente par pièces'),
        ('Paire','Vente par paire')
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
    insert into t_types_articles
        (id_types_articles, designation_types_articles)
    values
        ('Materiels informatiques', 'Materiels destinés à informatique'),
        ('Télépones portables', 'Téléphones portables')
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
    insert into t_categories_articles
        (id_categories_articles, designation_categories_articles)
    values
        ('Iphone','Apple Iphone'),
        ('Samsung', 'Samsung Mobile')
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
    designation_article as 'Designation',
    id_categories_articles as 'Catégorie',
    id_types_articles as 'Types',
    id_paquetage as 'Paquetage',
    description_articles as 'Description'
from t_articles
    order by id_article asc
go
create procedure rechercher_articles
@id_article nvarchar(50)
as
select top 50
    id_article as 'ID',
    designation_article as 'Designation',
    id_categories_articles as 'Catégorie',
    id_types_articles as 'Types',
    id_paquetage as 'Paquetage',
    description_articles as 'Description'
from t_articles
    where
        id_article like '%'+@id_article+'%'
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
create procedure rechercher_article
@search nvarchar(50)
as
select
    id_article as 'ID'
from t_articles
    where id_article like '%'+@search+'%'   
    order by id_article asc
go
--------------------------- Concernant la vente des produits --------------------------------------------
create table t_ventes
(
    num_vente int identity,
    vente_id nvarchar(50),
    date_vente date,
    id_boutique nvarchar(50),
    id_clients nvarchar(50),
    description_ventes nvarchar(100),
    constraint pk_ventes primary key(num_vente),
    constraint fk_vente_boutique foreign key(id_boutique) references t_boutique(id_boutique),
    constraint fk_vente_client foreign key(id_clients) references t_clients(id_clients)
)
go
create procedure afficher_vente
as
select top 50 
    num_vente as 'ID',
    vente_id as 'Code',
    date_vente as 'Date',
    id_boutique as 'Etablissement',
    id_clients as 'Client',
    description_ventes as 'Description'
from t_ventes
    order by num_vente desc
go
create procedure rechercher_vente_par_client
@id_clients nvarchar(50)
as
select top 50 
    num_vente as 'ID',
    vente_id as 'Code',
    date_vente as 'Date',
    id_boutique as 'Etablissement',
    id_clients as 'Client',
    description_ventes as 'Description'
from t_ventes
    where id_clients like '%'+@id_clients+'%'
    order by num_vente desc
go
create procedure enregistrer_vente
@num_vente int output,
@vente_id nvarchar(50),
@date_vente date,
@id_boutique nvarchar(50),
@id_clients nvarchar(50),
@description_ventes nvarchar(100)
as
    merge into t_ventes
	using(select @num_vente as x_id) as x_source
	on (x_source.x_id=t_ventes.num_vente)
	when matched then	
		update set
            id_boutique=@id_boutique,
            id_clients=@id_clients,            
            description_ventes=@description_ventes
    when not matched then
        insert
            (vente_id, date_vente, id_boutique, id_clients, description_ventes)
        values
            (@vente_id, getdate(), @id_boutique, @id_clients, @description_ventes);
        set @num_vente=SCOPE_IDENTITY()
        return @num_vente
        ;  
go
create procedure supprimer_vente
@num_vente int
as
    delete from t_ventes
        where num_vente like @num_vente
go

-----------------------------FIN VENTES DE PRODUITS---------------------------------
create table t_couleurs
(
    id_couleur nvarchar(50),
    designation_couleur nvarchar(100),
    constraint pk_couleur primary key(id_couleur)
)
go
    insert into t_couleurs
        (id_couleur, designation_couleur)
    values
        ('Blanche','Couleur blanche'),
        ('Noire','Couleur noire'),
        ('Rouge','Couleur rouge'),
        ('Rose','Couleur rose')
go
create procedure afficher_couleur
as
    select top 50
        id_couleur as 'Couleur',
        designation_couleur as 'Désignation'
    from t_couleurs
go
create procedure recuperer_couleur
as
    select id_couleur from t_couleurs
        order by id_couleur asc
go
create procedure enregistrer_couleur
@id_couleur nvarchar(50),
@designation_couleur nvarchar(100)
as
    merge into t_couleurs
	using(select @id_couleur as x_id) as x_source
	on (x_source.x_id=t_couleurs.id_couleur)
	when matched then	
		update set
            designation_couleur=@designation_couleur
    when not matched then
        insert
            (id_couleur, designation_couleur)
        values
            (@id_couleur, @designation_couleur);
go
create procedure supprimer_couleur
@id_couleur nvarchar(50)
as
    delete from t_couleurs
        where id_couleur=@id_couleur
go

--------------------------Debut du codes pour approvisionnement---------------------
create table t_approvisionnement
(
    num_details int identity,
    date_details date,
    id_article nvarchar(50),
    numero_serie nvarchar(50),
    id_couleur nvarchar(50),
    id_caracteristiques nvarchar(max),
    prix_achat_$ decimal,
    prix_achat_fc decimal,
    qte_entree decimal,
    id_fournisseurs nvarchar(50),
    date_expiration date,
    prix_vente_$ decimal,
    prix_vente_fc decimal,
    id_depot nvarchar(50),
    points int,
    status_vente nvarchar(50), -----to be sold, on hold, expired,
    id_compagnie nvarchar(50)
    constraint pk_details_approv primary key(num_details),
    constraint fk_couleur_approv foreign key(id_couleur) references t_couleurs(id_couleur),
    constraint fk_approvisionnement_fournisseur foreign key(id_fournisseurs) references t_fournisseurs(id_fournisseurs),
    constraint fk_details_depot foreign key(id_depot) references t_depot(id_depot),
    constraint fk_article_details_approv foreign key(id_article) references t_articles(id_article)
)
go
create procedure afficher_approvisionnement
@id_compagnie nvarchar(50)
as
select top 50 
    num_details as 'ID',
    date_details as 'Date',
    id_article as 'ID Articles',
    numero_serie as 'Numéro Série',
    id_couleur as 'Couleur',
    id_caracteristiques as 'Caractéristiques',
    prix_achat_$ as 'Prix (Achat) USD',
    prix_achat_fc as 'Prix (Achat) FC',
    qte_entree as 'Qte',
    id_fournisseurs as 'Fournisseur',
    date_expiration as 'Expiration',
    prix_vente_$ as 'Prix (Vente) USD',
    prix_vente_fc as 'Prx (Vente) FC',
    id_depot as 'Depot',
    points as 'Points',
    status_vente as 'Status'
from t_approvisionnement
    where id_compagnie like @id_compagnie
        order by num_details desc
go
create procedure rechercher_approvisionnement_fournisseur
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50 
    num_details as 'ID',
    date_details as 'Date',
    id_article as 'ID Articles',
    numero_serie as 'Numéro Série',
    id_couleur as 'Couleur',
    id_caracteristiques as 'Caractéristiques',
    prix_achat_$ as 'Prix (Achat) USD',
    prix_achat_fc as 'Prix (Achat) FC',
    qte_entree as 'Qte',
    id_fournisseurs as 'Fournisseur',
    date_expiration as 'Expiration',
    prix_vente_$ as 'Prix (Vente) USD',
    prix_vente_fc as 'Prx (Vente) FC',
    id_depot as 'Depot',
    points as 'Points',
    status_vente as 'Status'
from t_approvisionnement
    where id_fournisseurs like '%'+@search+'%' and id_compagnie like @id_compagnie
order by num_details desc
go
create procedure rechercher_approvisionnement_produit
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50 
    num_details as 'ID',
    date_details as 'Date',
    id_article as 'ID Articles',
    numero_serie as 'Numéro Série',
    id_couleur as 'Couleur',
    id_caracteristiques as 'Caractéristiques',
    prix_achat_$ as 'Prix (Achat) USD',
    prix_achat_fc as 'Prix (Achat) FC',
    qte_entree as 'Qte',
    id_fournisseurs as 'Fournisseur',
    date_expiration as 'Expiration',
    prix_vente_$ as 'Prix (Vente) USD',
    prix_vente_fc as 'Prx (Vente) FC',
    id_depot as 'Depot',
    points as 'Points',
    status_vente as 'Status'
from t_approvisionnement
    where id_article like '%'+@search+'%' and id_compagnie like @id_compagnie
order by num_details desc
go
create procedure rechercher_approvisionnement_details
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50 
    num_details as 'ID',
    date_details as 'Date',
    id_article as 'ID Articles',
    numero_serie as 'Numéro Série',
    id_couleur as 'Couleur',
    id_caracteristiques as 'Caractéristiques',
    prix_achat_$ as 'Prix (Achat) USD',
    prix_achat_fc as 'Prix (Achat) FC',
    qte_entree as 'Qte',
    id_fournisseurs as 'Fournisseur',
    date_expiration as 'Expiration',
    prix_vente_$ as 'Prix (Vente) USD',
    prix_vente_fc as 'Prx (Vente) FC',
    id_depot as 'Depot',
    points as 'Points',
    status_vente as 'Status'
from t_approvisionnement
    where num_details like '%'+@search+'%' and id_compagnie like @id_compagnie
order by num_details desc
go
create procedure rechercher_approvisionnement_vente
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50 
    num_details as 'ID',
    date_details as 'Date',
    id_article as 'ID Articles',
    numero_serie as 'Numéro Série',
    id_couleur as 'Couleur',
    id_caracteristiques as 'Caractéristiques',
    prix_achat_$ as 'Prix (Achat) USD',
    prix_achat_fc as 'Prix (Achat) FC',
    qte_entree as 'Qte',
    id_fournisseurs as 'Fournisseur',
    date_expiration as 'Expiration',
    prix_vente_$ as 'Prix (Vente) USD',
    prix_vente_fc as 'Prx (Vente) FC',
    id_depot as 'Depot',
    points as 'Points',
    status_vente as 'Status'
from t_approvisionnement
    where status_vente like '%'+@search+'%' and id_compagnie like @id_compagnie
order by num_details desc
go
create procedure update_stock_state
@id_compagnie nvarchar(50),
@num_details int,
@status_vente nvarchar(50)
as
    update t_approvisionnement
        set
            status_vente = @status_vente
        where
            id_compagnie like @id_compagnie and num_details like @num_details
go
create procedure enregistrer_approvisionement
@num_details int,
@id_article nvarchar(50),
@numero_serie nvarchar(50),
@id_couleur nvarchar(50),
@id_caracteristiques nvarchar(max),
@prix_achat_$ decimal,
@prix_achat_fc decimal,
@qte_entree decimal,
@id_fournisseurs nvarchar(50),
@date_expiration date,
@prix_vente_$ decimal,
@prix_vente_fc decimal,
@id_depot nvarchar(50),
@points int,
@status_vente nvarchar(50),
@id_compagnie nvarchar(50)
as
    merge into t_approvisionnement
	using(select @num_details as x_id) as x_source
	on (x_source.x_id=t_approvisionnement.num_details)
	when matched then	
		update set
            date_details=getdate(),
            id_article=@id_article,
            numero_serie=@numero_serie,
            id_couleur=@id_couleur,
            id_caracteristiques=@id_caracteristiques,
            prix_achat_$=@prix_achat_$,
            prix_achat_fc=@prix_achat_fc,
            qte_entree=@qte_entree,
            id_fournisseurs=@id_fournisseurs,
            date_expiration=@date_expiration,
            prix_vente_$=@prix_vente_$ ,
            prix_vente_fc=@prix_vente_fc,
            id_depot=@id_depot,
            points=@points,
            status_vente=@status_vente,
            id_compagnie=@id_compagnie
    when not matched then
        insert
            (
                date_details, id_article, numero_serie, id_couleur, id_caracteristiques, prix_achat_$, prix_achat_fc, qte_entree, id_fournisseurs, date_expiration, prix_vente_$, prix_vente_fc,
                id_depot, points, status_vente, id_compagnie
            )
        values
            (
                getdate(), @id_article, @numero_serie, @id_couleur, @id_caracteristiques, @prix_achat_$, @prix_achat_fc, @qte_entree, @id_fournisseurs, @date_expiration,  @prix_vente_$, 
                @prix_vente_fc, @id_depot, @points, @status_vente, @id_compagnie
            );
go
create procedure supprimer_approvisionnement
@num_details int
as
delete from t_approvisionnement
    where num_details like @num_details
go
---------------------------Fin du code d'approvisionnement--------------------------------------------------------------
---------------------------Debut code details vente---------------------------------------------------------------------
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
create procedure afficher_details_vente
as
    select top 50
        t_details_vente.num_details_vente, 
        t_details_vente.num_vente, 
        t_details_vente.num_details, 
        t_approvisionnement.id_article, 
        t_details_vente.qte_sortie
    from            
        t_approvisionnement 
            inner join
        t_details_vente on t_approvisionnement.num_details = t_details_vente.num_details 
            inner join
                t_ventes on t_details_vente.num_vente = t_ventes.num_vente
go
create procedure enregistrer_details_vente
@num_details_vente int,
@date_details_vente date,
@num_vente int,
@num_details int,
@qte_sortie int
as
    merge into t_details_vente
	using(select @num_details_vente as x_id) as x_source
	on (x_source.x_id=t_details_vente.num_details_vente)
	when matched then	
		update set
            date_details_vente=getdate(),
            num_vente=@num_vente,
            num_details=@num_details,
            qte_sortie=@qte_sortie
    when not matched then
        insert
            (
                date_details_vente, num_vente, num_details, qte_sortie
            )
        values
            (
                getdate(), @num_vente, @num_details, @qte_sortie
            );
go
create procedure supprimer_details_vente
@num_details_vente int
as
    delete from t_details_vente where num_details_vente like @num_details_vente
go
create procedure recuperer_factures
as
select        
	t_details_vente.num_details_vente,
	t_ventes.num_vente, 
	t_ventes.id_boutique, 
	t_ventes.id_clients, 
	t_approvisionnement.id_article, 
	t_paiement.montant_paye_$, 
	t_paiement.montant_paye_fc, 
    t_paiement.solde_restant, 
	t_paiement.status_paiement, 
	t_paiement.date_paiement

from            
	t_approvisionnement 
		inner join
			t_details_vente on t_approvisionnement.num_details = t_details_vente.num_details 
		inner join
			t_ventes on t_details_vente.num_vente = t_ventes.num_vente 
		inner join
			t_paiement on t_ventes.num_vente = t_paiement.num_vente
go
create procedure recuperer_facture_details
@num_vente int
as
select        
    t_details_vente.num_details_vente as 'ID Details', 
    t_details_vente.num_vente as 'ID vente',
    t_details_vente.num_details as 'ID Stock', 
    t_approvisionnement.id_article as 'Article', 
    t_approvisionnement.prix_vente_$ as 'Prix $', 
    t_approvisionnement.prix_vente_fc as 'Prix FC', 
    t_details_vente.qte_sortie as 'Qte',
    t_approvisionnement.prix_vente_$ * t_details_vente.qte_sortie as 'Total $',
    t_approvisionnement.prix_vente_fc * t_details_vente.qte_sortie as 'Total FC'
from            
    t_approvisionnement 
        inner join
            t_details_vente on t_approvisionnement.num_details = t_details_vente.num_details 
        inner join
            t_ventes on t_details_vente.num_vente = t_ventes.num_vente
where 
    t_details_vente.num_vente like @num_vente
go
create procedure recuperer_total_facture
@num_vente int
as
select sum(t_approvisionnement.prix_vente_$ * t_details_vente.qte_sortie), sum(t_approvisionnement.prix_vente_fc * t_details_vente.qte_sortie)     
from            
    t_approvisionnement 
        inner join
            t_details_vente on t_approvisionnement.num_details = t_details_vente.num_details 
        inner join
            t_ventes on t_details_vente.num_vente = t_ventes.num_vente
where 
    t_details_vente.num_vente like @num_vente
go
-----------------------------------Fin codes pour details vente------------------------------------
-----------------------------------Debut codes pour Paiement articles------------------------------
create table t_paiement
(
    num_paiement int identity,
    date_paiement date,
    num_vente int,
    montant_paye_$ decimal,
    montant_paye_fc decimal,
    solde_restant decimal,
    status_paiement nvarchar(50),
    constraint pk_paiement primary key(num_paiement),
    constraint fk_vente_paiement foreign key(num_vente) references t_ventes(num_vente) on update cascade
)
go
create procedure afficher_paiement
as
    select top 50 
        num_paiement as 'ID',
        date_paiement as 'Date',
        num_vente as 'Vente ID',
        montant_paye_$ as '$',
        montant_paye_fc as 'FC',
        solde_restant as 'Solde $',
        status_paiement as 'Status'
    from t_paiement
        order by num_paiement desc
go
create procedure enregistrer_paiement
@num_vente int,
@montant_dollars decimal,
@montant_fc decimal,
@solde_restant_dollars decimal,
@status_paiement nvarchar(50)
as
    insert into t_paiement
        (date_paiement, num_vente, montant_paye_$, montant_paye_fc, solde_restant, status_paiement)
    values
        (getdate(), @num_vente, @montant_dollars, @montant_fc, @solde_restant_dollars, @status_paiement)
go
create procedure supprimer_paiement
@num_paiement int
as
    delete from t_paiement
        where num_paiement like @num_paiement
go
create table t_taux
(
    id_taux int identity,
    valeur_dollar decimal,
    valeur_francs decimal,
    constraint pk_taux primary key(id_taux)
)
go
create procedure enregistrer_taux
@valeur_dollars decimal,
@valeur_francs decimal
as
insert into t_taux
    (valeur_dollar, valeur_francs)
values
    (@valeur_dollars, @valeur_francs)
go
insert into t_taux
values
 (1,2005)
go
create procedure recuperer_taux
as
select top 1 valeur_francs as 'taux' from t_taux
order by id_taux desc
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
------------------------------------------Menus------------------------------------------------------------------------
create table t_menu
(
    id_menu nvarchar(50),
    designation nvarchar(50),
    prix decimal,
    constraint pk_menu primary key(id_menu)
)
go
create procedure afficher_menu
as
select top 50 
    id_menu as 'ID',
    designation as 'Description',
    prix as 'Prix'
from t_menu
    order by id_menu asc
go
create procedure rechercher_menu
@id_menu nvarchar(50)
as
select top 50 
    id_menu as 'ID',
    designation as 'Description',
    prix as 'Prix'
from t_menu
    where id_menu like '%'+@id_menu+'%'
        order by id_menu asc
go
create procedure enregistrer_menu
@id_menu nvarchar(50),
@designation nvarchar(50),
@prix decimal
as
merge into t_menu
	using(select @id_menu as x_id) as x_source
	on (x_source.x_id=t_menu.id_menu)
	when matched then	
		update set
            designation=@designation,
            prix=@prix
    when not matched then
        insert
            (id_menu, designation, prix)
        values
             (@id_menu, @designation, @prix);  
go
create procedure recuperer_menu
as
select top 50 
    id_menu
from t_menu
    order by 
        id_menu asc
go
create procedure recuperer_prix_menu
@id_menu nvarchar(50)
as
    select 
        prix 
    from 
        t_menu 
    where id_menu like @id_menu
go
create procedure supprimer_menu
@id_menu nvarchar(50)
as
    delete from t_menu
        where id_menu like @id_menu
go
-----------------------------------------Menus-------------------------------------------------------------------------
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
--------------------------------Calculs spéciaux-----------------------------------------
create procedure inventaire_par_dates
@date_un date,
@date_deux date,
@id_compagnie nvarchar(50)
as
    select top 50
        t_paiement.date_paiement, 
        t_paiement.status_paiement, 
        t_boutique.id_compagnie, 
        t_boutique.id_boutique, 
        t_articles.id_article, 
        t_articles.designation_article, 
        t_approvisionnement.numero_serie, 
        t_approvisionnement.id_caracteristiques, 
        t_details_vente.qte_sortie, 
        t_approvisionnement.prix_vente_$, 
        t_approvisionnement.prix_vente_fc, 
        t_paiement.montant_paye_$, 
        t_paiement.montant_paye_fc,
        t_paiement.solde_restant
    from            
        t_paiement inner join
            t_ventes on t_paiement.num_vente = t_ventes.num_vente inner join
            t_boutique on t_ventes.id_boutique = t_boutique.id_boutique inner join
            t_details_vente on t_ventes.num_vente = t_details_vente.num_vente inner join
            t_approvisionnement on t_details_vente.num_details = t_approvisionnement.num_details inner join
            t_articles on t_approvisionnement.id_article = t_articles.id_article
    where
        t_paiement.date_paiement between @date_un and @date_deux and t_boutique.id_compagnie like @id_compagnie
go
create procedure recupérer_info_approv_vente
@search nvarchar(50)
as
    select top 1
        id_article, 
        num_details,
        prix_vente_$, 
        prix_vente_fc,
        qte_entree
    from t_approvisionnement
    where id_article like @search and status_vente='Vente'
go
create procedure retour_qte_vendue
@search nvarchar(50)
as
select 
    sum(qte_sortie)
from t_details_vente
    where
        num_details like @search
go

create procedure afficher_inventaire
as
select        
    t_approvisionnement.num_details as 'ID', 
    t_approvisionnement.id_article as 'Article', 
    t_approvisionnement.prix_vente_$ as 'Prix $', 
    t_approvisionnement.prix_vente_fc as 'Prix FC', 
    t_approvisionnement.qte_entree as 'Qte Entrée',
    t_details_vente.qte_sortie as 'Qte sortie',
    t_details_vente.date_details_vente as 'Date',
    t_approvisionnement.status_vente as 'Status'
from            
    t_approvisionnement 
        inner join
            t_details_vente 
                on t_approvisionnement.num_details = t_details_vente.num_details
go
create procedure afficher_articles_disponible
@id_compagnie nvarchar(50)
as
select top 50
    num_details as 'ID', 
    id_article as 'Article', 
    numero_serie as 'N° Série', 
    id_couleur as 'Couleur', 
    id_caracteristiques as 'Spéc.', 
    prix_vente_$ as 'Prix USD', 
    prix_vente_fc as 'Prix FC', 
    id_depot as 'Dépôt', 
    status_vente as 'Status'
from
    t_approvisionnement
    where status_vente like 'Vente' and id_compagnie like @id_compagnie
go
create procedure recuperer_qte_initiale
@num_details nvarchar(50)
as
    select qte_entree from t_approvisionnement
        where num_details like @num_details
go
create procedure rechercher_articles_disponible_nom
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50
    num_details as 'ID', 
    id_article as 'Article', 
    numero_serie as 'N° Série', 
    id_couleur as 'Couleur', 
    id_caracteristiques as 'Spéc.', 
    prix_vente_$ as 'Prix USD', 
    prix_vente_fc as 'Prix FC', 
    qte_entree as 'Qte initiale',
    id_depot as 'Dépôt', 
    status_vente as 'Status'
from
    t_approvisionnement
    where status_vente like 'Vente' and id_article like '%'+@search+'%' and id_compagnie like @id_compagnie
go
create procedure rechercher_articles_disponible_serie
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50
    num_details as 'ID', 
    id_article as 'Article', 
    numero_serie as 'N° Série', 
    id_couleur as 'Couleur', 
    id_caracteristiques as 'Spéc.', 
    prix_vente_$ as 'Prix USD', 
    prix_vente_fc as 'Prix FC', 
    id_depot as 'Dépôt', 
    status_vente as 'Status'
from
    t_approvisionnement
    where status_vente like 'Vente' and numero_serie like '%'+@search+'%' and id_compagnie like @id_compagnie
go
create procedure rechercher_articles_disponible_specs
@search nvarchar(50),
@id_compagnie nvarchar(50)
as
select top 50
    num_details as 'ID', 
    id_article as 'Article', 
    numero_serie as 'N° Série', 
    id_couleur as 'Couleur', 
    id_caracteristiques as 'Spéc.', 
    prix_vente_$ as 'Prix USD', 
    prix_vente_fc as 'Prix FC', 
    id_depot as 'Dépôt', 
    status_vente as 'Status'
from
    t_approvisionnement
    where status_vente like 'Vente' and id_caracteristiques like '%'+@search+'%' and id_compagnie like @id_compagnie
go
create procedure sortie_par_article
@num_details int
as
    select isnull(sum(qte_sortie),0) from t_details_vente
        where num_details like @num_details
go
create procedure recuperer_deja_payé
@num_vente int
as
select 
    sum(montant_paye_$) as 'Total'
    from t_paiement
        where num_vente like @num_vente
go
create procedure recuperer_inventaire
@id_compagnie nvarchar(50)
as
    select        
        t_approvisionnement.num_details as 'ID', 
        t_ventes.num_vente as 'Vente ID', 
        t_ventes.id_boutique as 'Shop', 
        t_ventes.id_clients as 'Client', 
        t_approvisionnement.id_article as 'Article', 
        t_approvisionnement.numero_serie as 'Unique ID', 
        t_approvisionnement.prix_vente_$ as 'Prix $',
        t_approvisionnement.qte_entree as 'Qte Init.', 
        t_details_vente.qte_sortie as 'Qte', 
        t_approvisionnement.status_vente as 'Etat Stock'
    from            
        t_approvisionnement 
            inner join
                t_details_vente on t_approvisionnement.num_details = t_details_vente.num_details 
                    inner join
                         t_ventes on t_details_vente.num_vente = t_ventes.num_vente
    where
        id_compagnie like @id_compagnie
go
--------------------------------Fin calculs spéciaux-------------------------------------