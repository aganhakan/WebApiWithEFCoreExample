Create Database Odev2

Create table Category
(
CategoryId int primary key identity(1,1) not null,
CategoryName nvarchar(50),
)

Create table Products
(
ProductId int primary key identity(1,1) not null,
ProductName nvarchar(50),
ProductPrice money,
UnitsInStock int,
CategoryId int foreign key references Category(CategoryId) not null,
)

Create table ProductFeature
(
ProductFeatureId int primary key identity(1,1) not null,
ProductFeatureName nvarchar(50),
ProductId int unique foreign key references Products(ProductId)
)

Select * from Products
Select * from Category
Select * from ProductFeature

Select ProductName from Products p
inner join Category c on p.CategoryId = c.CategoryId

Select ProductFeatureName from ProductFeature pf
inner join Products p on p.ProductId = pf.ProductId

Select ProductName,ProductPrice from Products
where ProductPrice >= 30

Select ProductName,ProductPrice from Products
where ProductPrice >= 30 and ProductPrice <= 50

Select * from ProductFeature order by ProductFeatureName desc

Select ProductName,ProductPrice from Products
where ProductPrice between 30 and 50 order by ProductName desc

Select ProductId from Products
where ProductName like '[A-K]%'
order by ProductId

----ProductId'lerinde ilk harfi A ile K arasında olan productları listeleyiniz
Select ProductId from Products
where ProductName like '[A-K]%'
order by ProductId

----ProductId'lerinde ilk harfi A olmayan productları listeleyiniz
Select ProductId from Products
where ProductId not like 'A%'

----Fiyatı 50'den büyük kac tane urunumuz vardır ?
Select COUNT (ProductID) from Products
where ProductPrice > 50

----Depoda ücret bazlı olarak toplam ne kadarlık ürünüm kalmıştır?
Select SUM(ProductPrice * UnitsInStock) from Products

----Stoğu 15 den küçük olan kaç tane ürün vardır
Select COUNT(ProductName) from Products
where UnitsInStock < 15

---- A - D arasında ismi olan kaç adet product var?
Select Count(ProductId) from Products
where ProductName like '[A-D]%'

--View örneği
go
create view Kategorimsiler
as
Select* from Category
go

--Stored Procedur örneği

CREATE PROCEDURE sp_GetWithSp
AS
SELECT * FROM Products 

EXEC sp_GetWithSp


