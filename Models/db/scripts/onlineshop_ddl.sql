create database if not exists db_onlineshop collate utf8mb4_general_ci;

use db_onlineshop;

create table articles (
	article_id int unsigned not null auto_increment,
    name varchar(200) not null,
    price decimal(6,2) not null,
    decription varchar(5000) null,
    releasedate date null,
    category int not null,
    constraint article_id_PK primary key(article_id)
) engine=InnoDb;

insert into articles values(null, "Mac Laptop", 599.90, "toller Laptop", "2019-12-20", 1);
insert into articles values(null, "Samsung Galaxy S30", 899.99, "cooles smarphone", "2020-05-13", 3);

select * from articles;