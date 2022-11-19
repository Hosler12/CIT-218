CREATE TABLE Payments(
	[CustomerID] int NOT NULL,
	PmtDate datetime NOT NULL,
	Amt money NULL,
 CONSTRAINT PK_payments PRIMARY KEY CLUSTERED ([CustomerID],PmtDate),
 CONSTRAINT FK_PaymentsCustomer FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);