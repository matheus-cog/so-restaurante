create database bd_soRestaurante;
use bd_soRestaurante;

create table receitas(
	id_receita int not null identity (1,1) primary key,
	nome varchar(100),
	categoria varchar (150),
	tempo_duracao time,
	grau_dificuldade varchar(1),
	numero_servidos int,
	ingredientes varchar,
	modo_preparo varchar 
);