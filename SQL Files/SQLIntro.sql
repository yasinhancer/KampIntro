--SQL CASE INSENSITIVE >>> SQL büyük küçük harf DUYARSIZDIR
selecT ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
--Adi,SirketAdi ve City; bu kolonları bana bu isimle getir anlamındadır.

--NOT: metinler ANSII standartlarına göre tek tırnak içinde yazılır.
-- * :tümü
--where şart oluşturmak,eleme yapmak amacıyla kullanılır

Select * from Customers where City = 'London'
--Şehri londra olanları göster

selEct * from Products where categoryID=1 or CategoryID=3 -- or:iki şarttan birinin geçerli olması YETERLİ

select * from Products where categoryId=1 and UnitPrice>=10 -- and:iki şart da geçerli olması GEREKLİ

-- order by : sırala
select * from Products order by ProductName -- tüm ürünleri seç, ürün ismine göre sırala (alfabetik veya sayısal)

select * from Products order by CategoryId,ProductName 
--önce categoryId ye göre, onlar arasında da productName'e göre sırala

select * from Products order by UnitPrice desc

select * from Products where CategoryID=2 order by UnitPrice desc
--categoryId'si 2 olanları, fiyatına göre tersten sırala

-- asc >>> ascending : artan / default olarak zaten bu yazılmıştır, yazmaya gerek yok
-- desc >>> descending : azalan
 
select count(*) from Products --kaç ürün olduğunu say

select count(*) Adet from Products  where CategoryID=2
--categoryID'si 2 olanları say ve 'Adet' takma adıyla bana göster

select CategoryID,count(*) [Gruptaki Ürün Sayısı] from products group by CategoryID --group by: grupla
--categorilerdeki ürünleri say, categoryId'sine göre ayır ve hesapla, 
--yani ürün sayılarını kategorilerine göre ayırır ve sıralar 
--NOT: Takma adımın arasına boşluk koyabilmek için, parantez içine aldım.

select CategoryID,count(*) from products group by CategoryID having count(*)<10
--ürün sayısı 10dan az olanları kategorilerine göre ayırır ve sıralar 

select CategoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10
--birim fiyatı 20den büyük olan ürünleri içeren kategorileri, içindeki ürün sayısı 10dan az olanlar arasında, 
--categoryId ye göre ayır ve sırala

--DTO >>> DATA TRANSFORMATION OBJECT

-- JOIN >>> Tabloları birleştirmek:
select *
from Products inner join Categories --inner join sadece iki tarafta da eşitlik sağlanan ürünleri gösterir 
on Products.CategoryID = Categories.CategoryID --on: şartında/durumunda
--ürünlerin kategori numarası ile, kategorilerin kategori numarası aynı olanları bana göster

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories --products ve categories tablosunu birleştir, 
on Products.CategoryID = Categories.CategoryID --bu şarta uyanları bana göster
where products.UnitPrice>10 --birim fiyatı 10dan büyük olanlar

select * from products left join [Order Details] --left join: inner join + solda(products) olup sağda(order details) olmayanları da getir
on products.ProductID = [Order Details].ProductID

--aşağıdaki kod sayesinde üye olup ürün satın almayan kişileri gördüm
select * from Customers c left join orders o --müşterilerde olup , sağda(siparişler) olmayan, yani sipariş vermeyenleri de dahil et
on c.CustomerID = o.CustomerID
where o.CustomerID is null --orders'ta customerId'si boş olanlar, yani sipariş vermeyenler 

--ikiden fazla tabloyu join etme
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID