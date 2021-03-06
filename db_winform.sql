USE [master]
GO
/****** Object:  Database [db_winform]    Script Date: 20/01/2021 15:12:22 ******/
CREATE DATABASE [db_winform]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_winform', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_winform.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_winform_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_winform_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_winform].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_winform] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_winform] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_winform] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_winform] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_winform] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_winform] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_winform] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_winform] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_winform] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_winform] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_winform] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_winform] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_winform] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_winform] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_winform] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_winform] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_winform] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_winform] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_winform] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_winform] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_winform] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_winform] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_winform] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_winform] SET  MULTI_USER 
GO
ALTER DATABASE [db_winform] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_winform] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_winform] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_winform] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_winform] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_winform]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nvarchar](10) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportProduct]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportProduct](
	[ImportID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[CreatedAt] [datetime] NULL,
 CONSTRAINT [PK_ImportProduct] PRIMARY KEY CLUSTERED 
(
	[ImportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportProductDetail]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportProductDetail](
	[ProductID] [int] NOT NULL,
	[ImportID] [int] NOT NULL,
	[Amount] [int] NULL,
	[BuyPrice] [int] NULL,
 CONSTRAINT [PK_ImportProductDetail] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ImportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[ProductID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[CatID] [int] NULL,
	[Price] [int] NULL,
	[Img] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](20) NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypeDetail]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypeDetail](
	[ProductID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
 CONSTRAINT [PK_ProductTypeDetail] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[Phone] [nvarchar](10) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20/01/2021 15:12:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Address], [Phone]) VALUES (2, N'Nguyễn Thị Như Quỳnh', N'TPHCM', N'0987632541')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[ImportProduct] ON 

INSERT [dbo].[ImportProduct] ([ImportID], [SupplierID], [CreatedAt]) VALUES (1, 2, CAST(N'2021-01-19T20:51:02.900' AS DateTime))
SET IDENTITY_INSERT [dbo].[ImportProduct] OFF
GO
INSERT [dbo].[ImportProductDetail] ([ProductID], [ImportID], [Amount], [BuyPrice]) VALUES (2, 1, 600, 50000)
INSERT [dbo].[ImportProductDetail] ([ProductID], [ImportID], [Amount], [BuyPrice]) VALUES (3, 1, 800, 50000)
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [CreatedAt], [CustomerID], [UserID], [Status]) VALUES (8, CAST(N'2021-01-19T14:29:33.353' AS DateTime), 2, 1, 0)
INSERT [dbo].[Order] ([OrderID], [CreatedAt], [CustomerID], [UserID], [Status]) VALUES (9, CAST(N'2021-01-19T14:51:49.357' AS DateTime), 2, 1, 0)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([ProductID], [OrderID], [Amount]) VALUES (2, 8, 2)
INSERT [dbo].[OrderDetail] ([ProductID], [OrderID], [Amount]) VALUES (2, 9, 15)
INSERT [dbo].[OrderDetail] ([ProductID], [OrderID], [Amount]) VALUES (3, 8, 2)
INSERT [dbo].[OrderDetail] ([ProductID], [OrderID], [Amount]) VALUES (3, 9, 15)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [CatID], [Price], [Img], [CreatedAt], [CreatedBy], [Status]) VALUES (1, N'Quần Jean Nam', 3, 120000, NULL, CAST(N'2021-01-16T20:11:17.850' AS DateTime), 1, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [CatID], [Price], [Img], [CreatedAt], [CreatedBy], [Status]) VALUES (2, N'Quần Jean Nữ', 4, 60000, NULL, CAST(N'2021-01-16T20:32:16.747' AS DateTime), 1, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [CatID], [Price], [Img], [CreatedAt], [CreatedBy], [Status]) VALUES (3, N'Áo thun', 2, 35000, NULL, CAST(N'2021-01-16T20:32:36.257' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (1, N'Quần', 0)
INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (2, N'Áo', 0)
INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (3, N'Quần Nam', 1)
INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (4, N'Quần Nữ', 1)
INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (5, N'Áo Nam', 2)
INSERT [dbo].[ProductCategory] ([CatID], [CatName], [ParentID]) VALUES (6, N'Áo Nữ', 2)
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Quản trị viên')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Nhân viên bán hàng')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Nhân viên kho')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Phone], [Address]) VALUES (1, N'Pros', N'0985632415', N'Hà Nội')
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [Phone], [Address]) VALUES (2, N'Styze', N'0978546235', N'TPHCM')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FullName], [Address], [Email], [Username], [Password], [CreatedAt], [CreatedBy], [RoleID]) VALUES (1, N'Nguyễn Thanh Tú', N'HCM City', N'ntt11052000@gmail.com', N'TuNguyen16', N'123', CAST(N'2021-01-15T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[User] ([UserID], [FullName], [Address], [Email], [Username], [Password], [CreatedAt], [CreatedBy], [RoleID]) VALUES (2, N'Nguyễn Thanh Tuấn', N'Vĩnh Long', N'ntt29092009@gmail.com', N'TuanPro8', N'555', CAST(N'2021-01-15T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[User] ([UserID], [FullName], [Address], [Email], [Username], [Password], [CreatedAt], [CreatedBy], [RoleID]) VALUES (3, N'Diệp Thế Duy', N'HCM City', N'dieptheduy2000@gmail.com', N'theduy', N'1412', CAST(N'2021-01-15T00:00:00.000' AS DateTime), NULL, 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[ImportProduct]  WITH CHECK ADD  CONSTRAINT [FK_ImportProduct_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[ImportProduct] CHECK CONSTRAINT [FK_ImportProduct_Supplier]
GO
ALTER TABLE [dbo].[ImportProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportProductDetail_ImportProduct] FOREIGN KEY([ImportID])
REFERENCES [dbo].[ImportProduct] ([ImportID])
GO
ALTER TABLE [dbo].[ImportProductDetail] CHECK CONSTRAINT [FK_ImportProductDetail_ImportProduct]
GO
ALTER TABLE [dbo].[ImportProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportProductDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ImportProductDetail] CHECK CONSTRAINT [FK_ImportProductDetail_Product]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductCategory] FOREIGN KEY([CatID])
REFERENCES [dbo].[ProductCategory] ([CatID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductCategory]
GO
ALTER TABLE [dbo].[ProductTypeDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductTypeDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ProductTypeDetail] CHECK CONSTRAINT [FK_ProductTypeDetail_Product]
GO
ALTER TABLE [dbo].[ProductTypeDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductTypeDetail_ProductType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[ProductType] ([TypeID])
GO
ALTER TABLE [dbo].[ProductTypeDetail] CHECK CONSTRAINT [FK_ProductTypeDetail_ProductType]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [db_winform] SET  READ_WRITE 
GO
