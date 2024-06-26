USE [master]
GO
/****** Object:  Database [cs6232-g2]    Script Date: 4/16/2024 4:34:11 PM ******/
CREATE DATABASE [cs6232-g2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-g2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-g2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g2] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g2', N'ON'
GO
ALTER DATABASE [cs6232-g2] SET QUERY_STORE = OFF
GO
USE [cs6232-g2]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[Sex] [nvarchar](6) NULL,
	[DateOfBirth] [date] NULL,
	[StreetAddress] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](10) NULL,
	[ContactPhone] [nvarchar](10) NULL,
	[Role] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[FurnitureID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryName] [nvarchar](50) NULL,
	[StyleName] [nvarchar](50) NULL,
	[DailyRentalRate] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
	[InStockNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[Sex] [nvarchar](6) NULL,
	[DateOfBirth] [date] NULL,
	[StreetAddress] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](10) NULL,
	[ContactPhone] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalItem]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalItem](
	[RentalItemID] [int] IDENTITY(1,1) NOT NULL,
	[RentalTransactionID] [int] NULL,
	[FurnitureID] [int] NULL,
	[Quantity] [int] NULL,
	[DailyRate] [decimal](10, 2) NULL,
	[QuantityReturned] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentalItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransaction](
	[RentalTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NULL,
	[EmployeeID] [int] NULL,
	[RentalDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[TotalCost] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[RentalTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnedItem]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnedItem](
	[ReturnedItemID] [int] IDENTITY(1,1) NOT NULL,
	[ReturnTransactionID] [int] NULL,
	[RentalItemID] [int] NULL,
	[QuantityReturned] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReturnedItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransaction](
	[ReturnTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[MemberID] [int] NULL,
	[ReturnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReturnTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Style](
	[StyleName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StyleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ('Employee') FOR [Role]
GO
ALTER TABLE [dbo].[RentalItem] ADD  DEFAULT ((0)) FOR [QuantityReturned]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD FOREIGN KEY([CategoryName])
REFERENCES [dbo].[Category] ([CategoryName])
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD FOREIGN KEY([StyleName])
REFERENCES [dbo].[Style] ([StyleName])
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalItem]  WITH CHECK ADD FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furniture] ([FurnitureID])
GO
ALTER TABLE [dbo].[RentalItem]  WITH CHECK ADD FOREIGN KEY([RentalTransactionID])
REFERENCES [dbo].[RentalTransaction] ([RentalTransactionID])
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[ReturnedItem]  WITH CHECK ADD FOREIGN KEY([RentalItemID])
REFERENCES [dbo].[RentalItem] ([RentalItemID])
GO
ALTER TABLE [dbo].[ReturnedItem]  WITH CHECK ADD FOREIGN KEY([ReturnTransactionID])
REFERENCES [dbo].[ReturnTransaction] ([ReturnTransactionID])
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Role]='Employee' OR [Role]='Administrator'))
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Sex]='Other' OR [Sex]='F' OR [Sex]='M'))
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD CHECK  (([Sex]='Other' OR [Sex]='F' OR [Sex]='M'))
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/16/2024 4:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
    @startDate DATE,
    @endDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Total rental transactions for each furniture item during the specified period
    WITH TransactionCounts AS (
        SELECT 
            ri.FurnitureID,
            COUNT(DISTINCT ri.RentalTransactionID) AS TotalTransactions
        FROM RentalTransaction rt
        JOIN RentalItem ri ON rt.RentalTransactionID = ri.RentalTransactionID
        WHERE rt.RentalDate BETWEEN @startDate AND @endDate
        GROUP BY ri.FurnitureID
        HAVING COUNT(DISTINCT ri.RentalTransactionID) >= 2
    ), TotalTransactions AS (
        SELECT COUNT(DISTINCT RentalTransactionID) AS TotalAllTransactions
        FROM RentalTransaction
        WHERE RentalDate BETWEEN @startDate AND @endDate
    ), AgeDemographics AS (
        SELECT 
            ri.FurnitureID,
            COUNT(DISTINCT CASE WHEN YEAR(m.DateOfBirth) BETWEEN YEAR(GETDATE()) - 29 AND YEAR(GETDATE()) - 18 THEN rt.RentalTransactionID END) AS YoungRenters,
            COUNT(DISTINCT rt.RentalTransactionID) AS TotalRenters
        FROM RentalTransaction rt
        JOIN Member m ON rt.MemberID = m.MemberID
        JOIN RentalItem ri ON rt.RentalTransactionID = ri.RentalTransactionID
        WHERE rt.RentalDate BETWEEN @startDate AND @endDate
        GROUP BY ri.FurnitureID
    )
    SELECT 
        f.FurnitureID,
        c.CategoryName AS FurnitureCategory,
        f.Name AS FurnitureName,
        tc.TotalTransactions,
        tt.TotalAllTransactions,
        CAST(tc.TotalTransactions * 100.0 / tt.TotalAllTransactions AS DECIMAL(10,2)) AS PercentageOfTotalRentals,
        CAST(ad.YoungRenters * 100.0 / ad.TotalRenters AS DECIMAL(10,2)) AS PercentageAged18to29,
        CAST((ad.TotalRenters - ad.YoungRenters) * 100.0 / ad.TotalRenters AS DECIMAL(10,2)) AS PercentageOutside18to29
    FROM Furniture f
    JOIN Category c ON f.CategoryName = c.CategoryName
    JOIN TransactionCounts tc ON f.FurnitureID = tc.FurnitureID
    CROSS JOIN TotalTransactions tt
    LEFT JOIN AgeDemographics ad ON f.FurnitureID = ad.FurnitureID
    ORDER BY tc.TotalTransactions DESC, f.FurnitureID DESC
END
GO
USE [master]
GO
ALTER DATABASE [cs6232-g2] SET  READ_WRITE 
GO
