create database db_SGCP;

use db_SGCP;

create table tb_usuario(
            id int not null auto_increment,
            nome varchar(20) not null,
            usuario varchar(20) not null unique,
            senha varchar(20) not null,
            nivel int default 0,
            email varchar(40) not null unique,            
            primary key(id)
            );
            
            insert into tb_usuario
            (nome, usuario, senha, nivel, email)
            values
            ('Moises Brito', 'admin', 'fuentes',1,'moisesbritofuentes@gmail.com');
            
            create table tb_vara(
            id int not null auto_increment,
            nome varchar(100) not null,
            juiz varchar(100) not null,
            cidade varchar(50) not null,
            estado varchar(50) not null,
            primary key(id)
            );
            
            create table tb_processo(
            id int not null auto_increment,
            vara int not null,
            numero varchar(20) not null unique,
            juiz varchar(20) not null,
            intimacao varchar(10) not null,
            inicio_trabalhos varchar(10),
            entrega varchar(50),
            requerente varchar(20) not null,
            requerido varchar(20) not null,
            honorario_pro varchar(20),
            honorario varchar(20),
            situacao varchar(30),
            obs varchar(100),
            primary key(id)
            );
            