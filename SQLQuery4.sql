/*select * from [Order Details]*/
/* product, price quantity  % discount*/

/*select *, UnitPrice * quantity as 'Gross price' from [Order Details]*/
/*include discounr*/
/*select *, (UnitPrice * 1-Discount) * quantity as 'Net order' from [Order Details] order by 'Net order'

select SUM(quantity) from [Order Details]
select AVG(quantity) from [Order Details]
select MIN(quantity) from [Order Details]
select MAX(quantity) from [Order Details]*/

/*select * from products
select SupplierID from products order by SupplierID*/
/*select supplierID,sum(unitsonorder) as 'to be ordered', sum(UnitsInStock) as stock, MAX(unitsonorder) as maxOrder from products  group by SupplierID order by stock desc
*/

/*select AVG(unitsonorder) from products group by CategoryID
select AVG(unitsonorder) as units from products group by categoryid order by Units desc */
/*select AVG(unitsonorder)
as units 
from products
where CategoryID =5 or CategoryID = 3
group by categoryid 
having AVG(unitsonorder) > 5 
order by Units desc 

select * from products where SupplierID < 6 order by UnitPrice*/






