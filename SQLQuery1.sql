--CREATE DATABASE InventoryManagement;

USE [InventoryManagement];

CREATE TABLE Categories(
	[pkCategoryId] INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Description] VARCHAR(50)
);

CREATE TABLE Products(
	[pkProductId] INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ProductName] VARCHAR(50),
	[Description] VARCHAR(100),
	[Price] FLOAT,
	[Quantity] INTEGER,
	[fkCategory] INTEGER NOT NULL,

	FOREIGN KEY (fkCategory) REFERENCES Categories(pkCategoryId)
);

-- Insert Dummy Data

INSERT INTO Categories 
	([Description]) 
VALUES 
	('Electronics'),
	('Clothing'),
	('Home and Kitchen'),
	('Books'),
	('Sports and Outdoors'),
	('Beauty'),
	('Toys and Games'),
	('Automotive'),
	('Health and Wellness'),
	('Office Supplies');

INSERT INTO Products 
	(ProductName, [Description], Price, Quantity, fkCategory) 
VALUES 
	('Laptop', '13" Intel Core i5, 8GB RAM, 256GB SSD', 999.99, 50, 1),
	('T-Shirt', 'Mens Large, Black', 19.99, 100, 2),
	('Blender', '800-Watt, 10-Speed Settings', 49.99, 20, 3),
	('Harry Potter and the Sorcerers Stone', 'Paperback, J.K. Rowling', 12.99, 80, 4),
	('Basketball', 'Official Size and Weight', 24.99, 30, 5),
	('Shampoo', 'Volumizing, 16 fl oz', 9.99, 75, 6),
	('Board Game', 'Family Fun, 2-6 Players', 29.99, 15, 7),
	('Car Battery', '12V, 650 CCA', 119.99, 10, 8),
	('Multivitamin', '120 Tablets', 14.99, 200, 9),
	('Ballpoint Pens', 'Black Ink, Pack of 10', 4.99, 50, 10),
	('Headphones', 'Wireless Bluetooth Headphones', 79.99, 25, 1),
	('Jeans', 'Womens Skinny Jeans, Blue', 39.99, 50, 2),
	('Coffee Maker', '12-Cup Programmable Coffee Maker', 29.99, 15, 3),
	('The Great Gatsby', 'Hardcover, F. Scott Fitzgerald', 9.99, 100, 4),
	('Yoga Mat', 'Non-Slip Exercise Mat', 19.99, 40, 5),
	('Lipstick', 'Matte Finish, Red Shade', 12.99, 80, 6),
	('Chess Set', 'Wooden Chess Board with Pieces', 49.99, 10, 7),
	('Motor Oil', '10W-30 Synthetic Blend, 5 Quarts', 24.99, 30, 8),
	('Vitamin C Supplement', '1000mg, 60 Tablets', 9.99, 120, 9),
	('Highlighters', 'Assorted Colors, Pack of 6', 3.99, 80, 10),
	('Smartphone', '6.5" Display, 128GB Storage', 699.99, 30, 1),
	('Dress', 'Womens Evening Dress, Red', 89.99, 20, 2),
	('Microwave Oven', '1000W Countertop Microwave', 129.99, 15, 3),
	('1984', 'Paperback, George Orwell', 8.99, 70, 4),
	('Tennis Racket', 'Graphite Composite, Strung', 79.99, 25, 5),
	('Face Moisturizer', 'SPF 30, 4 fl oz', 14.99, 60, 6),
	('Puzzle', '1000-Piece Jigsaw Puzzle', 19.99, 10, 7),
	('Motorcycle Helmet', 'DOT Certified, Matte Black', 129.99, 5, 8),
	('Fish Oil Supplement', 'Omega-3, 120 Softgels', 12.99, 100, 9),
	('Permanent Markers', 'Assorted Colors, Pack of 12', 7.99, 50, 10);