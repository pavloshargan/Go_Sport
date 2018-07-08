Select * From Tokens
Select * From UnconfirmedUsers
Select * From Users


select * from Routes
select * from ActivityTypes
select * from Activities


select * from Cities
select * from Countries

select * from Images
select * from Points



delete from ActivityTypes where id>35

delete from Tokens where Id>12
delete from Users where Id>24
delete from UnconfirmedUsers where Id>38

drop database [DAL.DataModel]



insert into Countries
values
('Ukraine'),
('Poland')

insert into Cities
values
('Rivne',1),
('Lviv',1),
('Warsaw',2)


insert into ActivityTypes
values
('Ride'),
('Run'),
('Walk'),
('Crossfit'),
('Yoga'),
('E-Bike ride'),
('Canoeing')