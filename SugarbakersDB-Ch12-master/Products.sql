CREATE TABLE Products(
	[ProductsID] int NOT NULL,
	[Name] nvarchar(50) NULL,
	[Description] nvarchar(255) NULL,
 CONSTRAINT PK_Products PRIMARY KEY CLUSTERED ([ProductsID]));