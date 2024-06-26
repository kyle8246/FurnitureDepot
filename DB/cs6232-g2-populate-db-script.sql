USE [cs6232-g2]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [StreetAddress], [City], [State], [ZipCode], [ContactPhone], [Role]) VALUES (1, N'Smith', N'John', N'M', CAST(N'1990-03-15' AS Date), N'123 Pine Street', N'Atlanta', N'GA', N'30301', N'1234567890', N'Administrator')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [StreetAddress], [City], [State], [ZipCode], [ContactPhone], [Role]) VALUES (2, N'Doe', N'Jane', N'F', CAST(N'1995-01-11' AS Date), N'456 Oak Avenue', N'Seattle', N'WA', N'98101', N'1231231234', N'Employee')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[Login] ([Username], [Password], [EmployeeID]) VALUES (N'janedoe', N'$2a$10$fjRLCUcpGBsEBqcg.iQuvOZ9melTIF62yWZ1BJCjlfLBDz/NToR1G', 2)
INSERT [dbo].[Login] ([Username], [Password], [EmployeeID]) VALUES (N'johnsmith', N'$2a$10$ZWZYsRIDJgDrz/FHr94pY.dMLX5oaIO8XrNANiQy/Tx/Sji9TBvx.', 1)
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [StreetAddress], [City], [State], [ZipCode], [ContactPhone]) VALUES (1, N'Brown', N'Charlie', N'M', CAST(N'1990-09-15' AS Date), N'789 Maple Lane', N'Chicago', N'IL', N'60601', N'1112223333')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [StreetAddress], [City], [State], [ZipCode], [ContactPhone]) VALUES (2, N'Johnson', N'Lucy', N'F', CAST(N'1992-05-22' AS Date), N'321 Birch Road', N'Dallas', N'TX', N'75201', N'1234512345')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransaction] ON 

INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (1, 1, 1, CAST(N'2023-10-01T00:00:00.000' AS DateTime), CAST(N'2023-10-15T00:00:00.000' AS DateTime), CAST(75.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [MemberID], [EmployeeID], [RentalDate], [DueDate], [TotalCost]) VALUES (2, 2, 2, CAST(N'2023-10-05T00:00:00.000' AS DateTime), CAST(N'2023-10-19T00:00:00.000' AS DateTime), CAST(150.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalTransaction] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnTransaction] ON 

INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate]) VALUES (1, 2, 1, CAST(N'2023-10-16T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate]) VALUES (2, 1, 2, CAST(N'2023-10-20T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ReturnTransaction] OFF
GO
INSERT [dbo].[Style] ([StyleName]) VALUES (N'Contemporary')
INSERT [dbo].[Style] ([StyleName]) VALUES (N'Modern')
INSERT [dbo].[Style] ([StyleName]) VALUES (N'Traditional')
GO
INSERT [dbo].[Category] ([CategoryName]) VALUES (N'Chair')
INSERT [dbo].[Category] ([CategoryName]) VALUES (N'Desk')
INSERT [dbo].[Category] ([CategoryName]) VALUES (N'Table')
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (1, N'Executive Chair', N'Ergonomic office chair with adjustable lumbar support', N'Chair', N'Modern', CAST(5.00 AS Decimal(10, 2)), 100, 100)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (2, N'Wooden Desk', N'Solid oak desk with built-in drawers', N'Desk', N'Traditional', CAST(10.00 AS Decimal(10, 2)), 50, 50)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (3, N'Minimalist Work Desk', N'Sleek design with minimal storage', N'Desk', N'Modern', CAST(12.00 AS Decimal(10, 2)), 100, 100)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (4, N'Vintage Coffee Table', N'Round table with glass top', N'Table', N'Traditional', CAST(8.00 AS Decimal(10, 2)), 35, 35)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (5, N'Ergonomic Office Chair', N'Adjustable and comfortable for long hours', N'Chair', N'Contemporary', CAST(15.00 AS Decimal(10, 2)), 150, 150)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (6, N'Modular Shelving Unit', N'Flexible and stylish storage solution', N'Desk', N'Modern', CAST(10.00 AS Decimal(10, 2)), 70, 70)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (7, N'Conference Table', N'Large, spacious for meetings', N'Table', N'Traditional', CAST(25.00 AS Decimal(10, 2)), 30, 30)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (8, N'Leather Executive Chair', N'Premium quality and comfort', N'Chair', N'Contemporary', CAST(20.00 AS Decimal(10, 2)), 100, 100)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (9, N'Standing Desk', N'Height adjustable for standing or sitting', N'Desk', N'Modern', CAST(18.00 AS Decimal(10, 2)), 50, 50)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [CategoryName], [StyleName], [DailyRentalRate], [Quantity], [InStockNumber]) VALUES (10, N'Round Dining Table', N'Perfect for small spaces, seats four', N'Table', N'Traditional', CAST(12.00 AS Decimal(10, 2)), 60, 60)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalItem] ON 

INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate], [QuantityReturned]) VALUES (1, 1, 1, 1, CAST(5.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[RentalItem] ([RentalItemID], [RentalTransactionID], [FurnitureID], [Quantity], [DailyRate], [QuantityReturned]) VALUES (2, 2, 2, 2, CAST(10.00 AS Decimal(10, 2)), 0)
SET IDENTITY_INSERT [dbo].[RentalItem] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnedItem] ON 

INSERT [dbo].[ReturnedItem] ([ReturnedItemID], [ReturnTransactionID], [RentalItemID], [QuantityReturned]) VALUES (1, 1, 1, 1)
INSERT [dbo].[ReturnedItem] ([ReturnedItemID], [ReturnTransactionID], [RentalItemID], [QuantityReturned]) VALUES (2, 2, 2, 2)
SET IDENTITY_INSERT [dbo].[ReturnedItem] OFF
GO
