create database DoAn3;
use DoAn3;
CREATE TABLE CreateAcc (
    Id int,
    Names varchar(255),
    LastName varchar(255),
    UserName varchar(255),
    Email varchar(255),
	PassWordAcc varchar(255),
    ConfirmPassWordAcc varchar(255)
);
CREATE TABLE Login (
    Id int,
    Email varchar(255),
	PassWordAcc varchar(255),
);
CREATE TABLE ProductPopular (
    Id int,
    Title varchar(255),
    Img varchar(255),
    Color varchar(255),
    Size varchar(255),
	CreateAt varchar(255),
);
select * from ProductPopular
