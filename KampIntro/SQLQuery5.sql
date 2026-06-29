--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insentive = büyük küçük harf duyarlılığı yok
seLect * from Products where categoryId=1 or categoryId=3

seLect * from Products where categoryId=1 And UnitPrice>=10

select * from Products order by categoryId,ProductName

select * from products order by UnitPrice desc --ascending=artan --descending=azalan

select * from products where categoryId=1 order by UnitPrice desc

select count(*) Adet from Products where categoryId=2 --count= hesaplama

select categoryId,count(*) from products where UnitPrice>20 group by categoryId having count(*)<10

select products.ProductID, products.ProductName, Products.UnitPrice, categories.categoryName
from products inner join categories
on products.categoryID = categories.CategoryId --on birleştirme koşulu
where products.unitPrice>10

--DTO Data Transformation object 

Select * from products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o 
on o.orderId = od.OrderID

select * from Customers c left join orders o
on c.customerId = o.customerId
where o.customerId is null
