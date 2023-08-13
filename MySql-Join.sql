Select * From bestbuy.products;
/* joins: select all the computers from the products table:
using the products table and the categories table, return the product name and the category name */
Select P.Name as ProductName, C.Name as CategoryName 
From products as P
Inner Join Categories as C
On C.CategoryID = P.CategoryID
Where C.Name = 'Computers';
/* joins: find all product names, product prices, and products ratings that have a rating of 5 */
 Select products.Name as ProductName, products.Price as Price, reviews.rating as Ratings
 From products
 Inner Join reviews On Reviews.ProductID = Products.ProductID
 Where reviews.Rating = 5;
/* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
Select E.FirstName, E.LastName, sum(s.quantity) as Total
From Sales as s
Inner Join employees as e On E.EmployeeID = S.EmployeeID
Group By e.EmployeeID
Order By Total Desc
Limit 2;

/* joins: find the name of the department, and the name of the category for Appliances and Games */
Select d.Name as DepartmentName, c.Name as CategoryName
From categories as C
Inner Join departments as D On d.DepartmentID = c.DepartmentID
Where c.Name = 'Appliances' Or c.Name = 'Games';
/* joins: find the product name, total # sold, and total price sold,
 for Eagles: Hotel California --You may need to use SUM() */
Select p.Name, sum(s.quantity) as 'Total Sold', sum(s.quantity * s.priceperunit) as 'Total Price'
From products as P
Inner Join Sales as S On S.ProductID = P.ProductID
Where P.ProductID = 97;
-- Verify
Select * From Sales Where ProductID = 97;
/* joins: find Product name, reviewer name, rating, and comment on the Visio TV. (only return for the lowest rating!) */
Select p.Name, r.Reviewer, r.Rating
From Products as P
Inner Join Reviews as R ON P.ProductID = R.ProductID
Where P.ProductID = 857 And R.Rating = 1;

-- ------------------------------------------ Extra - May be difficult
/* Your goal is to write a query that serves as an employee sales report.
This query should return:
-  the employeeID
-  the employee's first and last name
-  the name of each product
-  and how many of that product they sold */
Select e.EmployeeID, e.FirstName, e.LastName, p.Name, sum(s.quantity) as 'Amount Sold'
From employees as E
Inner Join Sales as S On s.EmployeeID = e.EmployeeID
Inner Join products as P On p.ProductID = s.ProductID
Group BY e.EmployeeID, p.ProductID
order by e.FirstName Desc;