create database JewelleryShop;
use JewelleryShop;
create table SubCategory
( SubCid int primary key,
SubName varchar(50)); 
insert into SubCategory values(101, "Rings");
insert into SubCategory values(102, "Earrings");
insert into SubCategory values(103, "Bracelet");
insert into SubCategory values(104, "MangalSutra");
insert into SubCategory values(105, "Pendents & Necklaces");
insert into SubCategory values(106, "Chains");
insert into SubCategory values(107, "Coins");
insert into SubCategory values(108, "Others");
create table roles(
roleid int primary key,
rolename varchar(25)
 );

 create table authentication(
 authid int primary key,
 mailid varchar(25) ,
 passWord varchar(25),
 roleid int,
 constraint foreign key(roleid) references roles(roleid)
 );
 
 insert into roles values(1,"Customer");
  insert into roles values(2,"Manager");
   insert into roles values(3,"Staff");
   
    insert into authentication values(1,"gourav.sapkale@gmail.com","gourav123",1);
  insert into authentication values(2,"santosh.jadhav@gmail.com","santosh123",1);