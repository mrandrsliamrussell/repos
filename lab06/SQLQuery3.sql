

/*select COUNT(*) from Customers WHERE City = 'London'*/
/*select * from Employees WHERE TitleOfCourtesy = 'Dr.'*/
/*select * from Employees*/
/*select COUNT(*) from Products WHERE Discontinued = 1*/
/*select TOP 5* from Customers order by ContactName desc*/
/*select * from products WHERE Discontinued = 0 AND (CategoryID = 1 OR CategoryID > 3)
select * from products WHERE UnitsInStock > ReorderLevel
select * from Categories*/

/*select DISTINCT city from customers order by city desc*/
/*select * from products where ProductName LIKE '%ch%'*/
/*select * from products where ProductName LIKE '%[A]%'*/
/*select * from products where ProductName LIKE 'c______%'
select * from products where CategoryID BETWEEN 3 and 6*/
/*select * from Customers where region <> 'NULL'
select * from Customers where region in('bc', 'sp', 'or')*/

/*select ProductName from products where UnitPrice < 5.00

select * from Categories where CategoryName  LIKE '[B, S]%'

select COUNT(*) from Orders where EmployeeID in(5,7)*/

/*Select CustomerID AS ID, Address + ' ' + City + Country AS Location from customers*/
select DISTINCT Country from customers where Region is NOT NULL
select Count(DISTINCT Country) from customers where Region is NOT NULL



