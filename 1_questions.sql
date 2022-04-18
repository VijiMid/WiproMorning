CREATE TABLE Manufacturers (
  Code INTEGER,
  Name VARCHAR(255) NOT NULL,
  PRIMARY KEY (Code)   
);

CREATE TABLE Products (
  Code INTEGER,
  Name VARCHAR(255) NOT NULL ,
  Price DECIMAL NOT NULL ,
  Manufacturer INTEGER NOT NULL,
  PRIMARY KEY (Code), 
  FOREIGN KEY (Manufacturer) REFERENCES Manufacturers(Code)
)  

INSERT INTO Manufacturers(Code,Name) VALUES(1,'Sony');
INSERT INTO Manufacturers(Code,Name) VALUES(2,'Creative Labs');
INSERT INTO Manufacturers(Code,Name) VALUES(3,'Hewlett-Packard');
INSERT INTO Manufacturers(Code,Name) VALUES(4,'Iomega');
INSERT INTO Manufacturers(Code,Name) VALUES(5,'Fujitsu');
INSERT INTO Manufacturers(Code,Name) VALUES(6,'Winchester');

INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(1,'Hard drive',240,5);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(2,'Memory',120,6);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(3,'ZIP drive',150,4);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(4,'Floppy disk',5,6);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(5,'Monitor',240,1);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(6,'DVD drive',180,2);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(7,'CD drive',90,2);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(8,'Printer',270,3);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(9,'Toner cartridge',66,3);
INSERT INTO Products(Code,Name,Price,Manufacturer) VALUES(10,'DVD burner',180,2);

Questions :

1. Select the names of all the products in the store.
    
2.Select the names and the prices of all the products in the store.

3.Select the name of the products with a price less than or equal to rs 200.
4.Select all the products with a price between rs 60 and rs 120.
5.Select the name and price in cents (i.e., the price must be multiplied by 100).
6.Compute the average price of all the products.
7.Compute the average price of all products with manufacturer code equal to 2.
8.Compute the number of products with a price larger than or equal to rs 180.
9.Select the name and price of all products with a price larger than or equal to rs 180, and sort first by price (in descending order), and then by name (in ascending order).
10. Select all the data from the products, including all the data for each product's manufacturer.
11.Select the product name, price, and manufacturer name of all the products.
12.Select the average price of each manufacturer's products, showing only the manufacturer's code.
13.Select the average price of each manufacturer's products, showing the manufacturer's name.
Select the names of manufacturer whose products have an average price larger than or equal to rs 150.
14.Select the name and price of the cheapest product.
15.Select the name of each manufacturer along with the name and price of its most expensive product.
16. Add a new product: Loudspeakers, rs 70, manufacturer 2.
17. Update the name of product 8 to "Laser Printer".
18. Apply a 10% discount to all products.
19. Apply a 10% discount to all products with a price larger than or equal to rs 120.
