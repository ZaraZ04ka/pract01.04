create database pract
use pract

create table product
(
sku int primary key ,
[name] nvarchar(max),
category nvarchar (max),
manufacturer nvarchar(max),
[description] nvarchar(max),
short_description nvarchar(max),
product_url nvarchar (max)
)

select  category  into category
from product

ALTER TABLE product
DROP COLUMN category

ALTER TABLE category
ADD  CatId INT PRIMARY KEY identity ;

ALTER TABLE category ADD FOREIGN KEY (CatId) REFERENCES product(sku)

ALTER TABLE product
ADD category NVARCHAR(50) 

select category
from product

