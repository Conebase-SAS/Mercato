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
    constraint pk_fournisseurs primary key(id_fournisseurs)
)
go
create table 