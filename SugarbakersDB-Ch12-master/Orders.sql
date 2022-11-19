CREATE TABLE Orders(
	[OrdersID] int NOT NULL,
	CustomerID int NOT NULL,
	OrderDate datetime NULL,
	FreightCharge money NULL,
	TotalDue money NULL,
 CONSTRAINT PK_orders PRIMARY KEY CLUSTERED ([OrdersID]),
 CONSTRAINT FK_OrdersCustomer FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID));
