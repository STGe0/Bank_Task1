create database Bank_Task1;

create table Currency(
id_currency int identity not null,
code_currency int not null,
currency_korotko varchar(10) not null,
name_currency varchar(150) not null,
curs_currency varchar(50) not null,
nom_currency int not null
);