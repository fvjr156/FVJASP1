CREATE DATABASE DB_Store;
USE DB_Store;
CREATE TABLE tblProducts (
    ProductID INT PRIMARY KEY IDENTITY(10000, 1),
    ProductName VARCHAR(512) NOT NULL,
    BrandName VARCHAR(512) NOT NULL,
    Price FLOAT NOT NULL,
);

INSERT INTO tblProducts (ProductName, BrandName, Price)
VALUES
  ('T-Shirt', 'Aoyama', 19.99),
  ('Laptop', 'Aoki', 799.99),
  ('Headphones', 'Aoki', 49.95),
  ('Coffee Maker', 'Aonuma', 39.99),
  ('Water Bottle', 'Aozora', 14.99),
  ('Mouse', 'Aoki', 24.99),
  ('Keyboard', 'Aoki', 34.99),
  ('Book', 'Aozora', 12.99),
  ('Pen Set', 'Aonuma', 7.99),
  ('Notebook', 'Aonuma', 9.99);
