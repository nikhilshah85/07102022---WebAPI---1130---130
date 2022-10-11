create database productsWebAPIDB

use productsWebAPIDB

create table products
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)
insert into products values(101,'Pepsi','Cold-Drink',50,1)
insert into products values(102,'Iphone','Electronics',145000,1)
insert into products values(103,'Air-Pods','Electronics',28000,0)
insert into products values(104,'Appy','Cold-Drink',75,1)
insert into products values(105,'Nike','Shoes',8500,0)
insert into products values(106,'Puma','Shoes',8500,0)
insert into products values(107,'RedTape','Shoes',8500,0)


select * from products




create table customers
(
	cId int primary key,
	cName varchar(20),
	cWalletBalance int,
	cCity varchar(20),
	cIsActive bit
)
insert into customers values(501,'Nikhil',800,'Mumbai',1)
insert into customers values(502,'Rahul',800,'Mumbai',1)
insert into customers values(503,'Karan',800,'Mumbai',1)
insert into customers values(504,'Akshay',800,'Mumbai',1)
insert into customers values(505,'Mayur',800,'Mumbai',1)






