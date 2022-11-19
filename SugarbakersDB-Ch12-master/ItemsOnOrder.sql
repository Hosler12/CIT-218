 CREATE TABLE ItemsonOrder(
	[OrdersID] int NOT NULL,
	[ProductsID] int NOT NULL,
	Quantity int NULL,
	UnitPrice money NULL,
	LineItemTotal AS UnitPrice * Quantity,
	ShipDate datetime NULL,
 CONSTRAINT PK_itemsonorder PRIMARY KEY CLUSTERED ([OrdersID],[ProductsID]),
 CONSTRAINT FK_OrdersItems FOREIGN KEY(OrdersID) REFERENCES Orders(OrdersID),
 CONSTRAINT FK_ProductItems FOREIGN KEY(ProductsID) REFERENCES Products(ProductsID));