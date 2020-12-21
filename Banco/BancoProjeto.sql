create table empresa (
empresaId int identity primary Key,
uf char (2),
nomeFantasia varchar(80),
cnpj varchar(18));

create table fornecedor (
idfornecedor int identity primary Key,
empresaId int,
nome varchar(80),
pessoa varchar(20),
cpf_cnpj varchar(20),
rg varchar(20),
datahora datetime,
idade int,
telefone varchar(14),
constraint fk_empresaId foreign key (empresaId) references empresa(empresaId));

