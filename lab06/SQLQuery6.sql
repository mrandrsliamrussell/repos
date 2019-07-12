/*select p.SupplierID, companyname, AVG(unitsonorder) as averageorder
from products p
inner join Suppliers s on p.SupplierID = s.SupplierID
group by p.SupplierID, CompanyName having AVG(unitsonorder) > 0
order by AVG(unitsonorder) desc*/

/*select * from products  inner join Suppliers on Products.SupplierID = Suppliers.SupplierID order by ProductID

select * from products  right join Suppliers on Products.SupplierID = Suppliers.SupplierID order by ProductID*/

select * from products 
inner join Suppliers on Products.SupplierID = suppliers.SupplierID 
inner join Categories on Products.CategoryID = Categories.CategoryID
