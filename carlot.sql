-- create database carlot;

-- create table cars(
-- id int primary key auto_increment not null,
-- make nvarchar(20),
-- model nvarchar(20),
-- `year` int,
-- isNew bool);

-- insert into cars
-- values(0, 'Ford', 'F150', 2001, false),
-- (0, 'Chevy', 'Malibu', 2015, false),
-- (0, 'Fiat', '500X', 2018, false),
-- (0, 'Ford', 'F150', 2022, true);

-- create table carowners(
-- id int primary key not null auto_increment,
-- firstname nvarchar(30),
-- lastname nvarchar(30)
-- );

-- ALTER TABLE cars
-- ADD belongsto int;
-- ALTER TABLE cars
-- add FOREIGN KEY (belongsto) REFERENCES carowners(Id);

select * from cars;