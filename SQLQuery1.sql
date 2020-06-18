create database HmindMap
go
use HmindMap
go
create table Users
(
	Username varchar(20) primary key,
	Pass varchar(30) not null
)
create table MapUsers
(
	Username varchar(20) ,
	MapName nvarchar(20) primary key,
	Content nvarchar(max)
	FOREIGN KEY (Username) REFERENCES Users (Username) 

)