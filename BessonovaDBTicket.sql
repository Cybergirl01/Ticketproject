USE [master]
GO
/****** Object:  Database [DBTicket]    Script Date: 18.01.2022 18:06:54 ******/
CREATE DATABASE [DBTicket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTicket', FILENAME = N'E:\sql\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBTicket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBTicket_log', FILENAME = N'E:\sql\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBTicket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBTicket] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTicket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTicket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTicket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTicket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTicket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTicket] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTicket] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBTicket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTicket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTicket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTicket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTicket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTicket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTicket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTicket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTicket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBTicket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTicket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTicket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTicket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTicket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTicket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTicket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTicket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBTicket] SET  MULTI_USER 
GO
ALTER DATABASE [DBTicket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTicket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTicket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTicket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBTicket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBTicket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBTicket] SET QUERY_STORE = OFF
GO
USE [DBTicket]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[IDGender] [int] NOT NULL,
	[Birthday] [date] NOT NULL,
	[PhoneNumber] [char](16) NOT NULL,
	[Wallet] [decimal](18, 0) NOT NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventPlace]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventPlace](
	[ID] [int] NOT NULL,
	[Title] [varchar](50) NULL,
 CONSTRAINT [PK_EventPlace] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Films]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[ID] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[ViewingTime] [time](7) NOT NULL,
	[room] [int] NOT NULL,
	[Place] [int] NOT NULL,
	[Price] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](64) NOT NULL,
	[Action] [varchar](50) NOT NULL,
	[Time] [time](7) NOT NULL,
	[Result] [bit] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IceSkateEvent]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IceSkateEvent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[ViewingTime] [time](7) NOT NULL,
	[Room] [int] NOT NULL,
	[Place] [int] NOT NULL,
	[Price] [nchar](10) NOT NULL,
 CONSTRAINT [PK_IceSkateEvent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IceSkating]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IceSkating](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDEventplace] [int] NOT NULL,
	[IDTitle] [int] NOT NULL,
 CONSTRAINT [PK_IceSkating] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organaisers]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organaisers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IDGender] [int] NOT NULL,
	[IDEventPlace] [int] NOT NULL,
	[PhoneNumber] [char](16) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_Organaisers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IDGender] [int] NOT NULL,
	[Birthday] [date] NOT NULL,
	[IDEventPlace] [int] NOT NULL,
	[PhoneNumber] [char](16) NOT NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_Seller] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Theater]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theater](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDEventplace] [int] NOT NULL,
	[IDFilm] [int] NOT NULL,
 CONSTRAINT [PK_Theater] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketClient]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketClient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDclient] [int] NOT NULL,
	[IDEventPlace] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Viewtime] [time](7) NOT NULL,
	[Room] [int] NOT NULL,
	[Row] [int] NOT NULL,
	[Place] [int] NOT NULL,
	[Price] [nchar](10) NOT NULL,
	[Activedate] [date] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_TicketClient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDEventPlace] [int] NOT NULL,
	[RoomNum] [int] NOT NULL,
	[RowNum] [int] NOT NULL,
	[Place] [int] NOT NULL,
	[ActiveDate] [date] NOT NULL,
	[Price] [nchar](10) NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18.01.2022 18:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](64) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IDRole] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Client] ([ID], [FirstName], [LastName], [IDGender], [Birthday], [PhoneNumber], [Wallet], [Photo]) VALUES (1, N'Валерина', N'Ромашкина', 1, CAST(N'2001-01-12' AS Date), N'+7(213)122-14-32', CAST(5000 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[EventPlace] ([ID], [Title]) VALUES (1, N'Кинотеатр')
INSERT [dbo].[EventPlace] ([ID], [Title]) VALUES (2, N'Ледниковый каток')
GO
INSERT [dbo].[Films] ([ID], [Title], [ViewingTime], [room], [Place], [Price]) VALUES (1, N'Человек-паук: нет пути домой', CAST(N'12:00:00' AS Time), 4, 8, N'350       ')
GO
INSERT [dbo].[Gender] ([ID], [Title]) VALUES (1, N'Женский')
INSERT [dbo].[Gender] ([ID], [Title]) VALUES (2, N'Мужской')
GO
SET IDENTITY_INSERT [dbo].[IceSkateEvent] ON 

INSERT [dbo].[IceSkateEvent] ([ID], [Title], [ViewingTime], [Room], [Place], [Price]) VALUES (1, N'Щелкунчик', CAST(N'10:00:00' AS Time), 2, 5, N'150       ')
SET IDENTITY_INSERT [dbo].[IceSkateEvent] OFF
GO
SET IDENTITY_INSERT [dbo].[IceSkating] ON 

INSERT [dbo].[IceSkating] ([ID], [IDEventplace], [IDTitle]) VALUES (1, 2, 1)
SET IDENTITY_INSERT [dbo].[IceSkating] OFF
GO
SET IDENTITY_INSERT [dbo].[Organaisers] ON 

INSERT [dbo].[Organaisers] ([ID], [FirstName], [LastName], [IDGender], [IDEventPlace], [PhoneNumber], [Birthday], [Photo]) VALUES (1, N'Роман', N'Туров', 2, 2, N'+7(911)092-12-12', CAST(N'2000-05-05' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Organaisers] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID], [Role]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([ID], [Role]) VALUES (2, N'Организатор')
INSERT [dbo].[Roles] ([ID], [Role]) VALUES (3, N'Продавец')
INSERT [dbo].[Roles] ([ID], [Role]) VALUES (4, N'Покупатель')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Seller] ON 

INSERT [dbo].[Seller] ([ID], [FirstName], [LastName], [IDGender], [Birthday], [IDEventPlace], [PhoneNumber], [Photo]) VALUES (1, N'Полина', N'Унова', 1, CAST(N'1999-06-15' AS Date), 1, N'+7(930)076-33-57', NULL)
SET IDENTITY_INSERT [dbo].[Seller] OFF
GO
SET IDENTITY_INSERT [dbo].[Theater] ON 

INSERT [dbo].[Theater] ([ID], [IDEventplace], [IDFilm]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[Theater] OFF
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([ID], [IDEventPlace], [RoomNum], [RowNum], [Place], [ActiveDate], [Price], [Inactive]) VALUES (1, 1, 2, 2, 5, CAST(N'2022-01-12' AS Date), N'350       ', 0)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Email], [Password], [IDRole]) VALUES (1, N'Admin@mail.ru', N'Admin123', 1)
INSERT [dbo].[Users] ([ID], [Email], [Password], [IDRole]) VALUES (2, N'Valerina@list.ru', N'ValerinaRom01', 4)
INSERT [dbo].[Users] ([ID], [Email], [Password], [IDRole]) VALUES (3, N'RomanTurov@gmail.com', N'RomOrganizator12', 2)
INSERT [dbo].[Users] ([ID], [Email], [Password], [IDRole]) VALUES (4, N'PolinaUnova@yandex.ru', N'UnovaLove!23', 3)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Gender] FOREIGN KEY([IDGender])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Gender]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Users] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Users]
GO
ALTER TABLE [dbo].[IceSkating]  WITH CHECK ADD  CONSTRAINT [FK_IceSkating_EventPlace] FOREIGN KEY([IDEventplace])
REFERENCES [dbo].[EventPlace] ([ID])
GO
ALTER TABLE [dbo].[IceSkating] CHECK CONSTRAINT [FK_IceSkating_EventPlace]
GO
ALTER TABLE [dbo].[IceSkating]  WITH CHECK ADD  CONSTRAINT [FK_IceSkating_IceSkateEvent] FOREIGN KEY([IDTitle])
REFERENCES [dbo].[IceSkateEvent] ([ID])
GO
ALTER TABLE [dbo].[IceSkating] CHECK CONSTRAINT [FK_IceSkating_IceSkateEvent]
GO
ALTER TABLE [dbo].[Organaisers]  WITH CHECK ADD  CONSTRAINT [FK_Organaisers_Gender] FOREIGN KEY([IDGender])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Organaisers] CHECK CONSTRAINT [FK_Organaisers_Gender]
GO
ALTER TABLE [dbo].[Seller]  WITH CHECK ADD  CONSTRAINT [FK_Seller_EventPlace] FOREIGN KEY([IDEventPlace])
REFERENCES [dbo].[EventPlace] ([ID])
GO
ALTER TABLE [dbo].[Seller] CHECK CONSTRAINT [FK_Seller_EventPlace]
GO
ALTER TABLE [dbo].[Seller]  WITH CHECK ADD  CONSTRAINT [FK_Seller_Gender] FOREIGN KEY([IDGender])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Seller] CHECK CONSTRAINT [FK_Seller_Gender]
GO
ALTER TABLE [dbo].[Theater]  WITH CHECK ADD  CONSTRAINT [FK_Theater_EventPlace] FOREIGN KEY([IDEventplace])
REFERENCES [dbo].[EventPlace] ([ID])
GO
ALTER TABLE [dbo].[Theater] CHECK CONSTRAINT [FK_Theater_EventPlace]
GO
ALTER TABLE [dbo].[Theater]  WITH CHECK ADD  CONSTRAINT [FK_Theater_Films] FOREIGN KEY([IDFilm])
REFERENCES [dbo].[Films] ([ID])
GO
ALTER TABLE [dbo].[Theater] CHECK CONSTRAINT [FK_Theater_Films]
GO
ALTER TABLE [dbo].[TicketClient]  WITH CHECK ADD  CONSTRAINT [FK_TicketClient_Client] FOREIGN KEY([IDclient])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[TicketClient] CHECK CONSTRAINT [FK_TicketClient_Client]
GO
ALTER TABLE [dbo].[TicketClient]  WITH CHECK ADD  CONSTRAINT [FK_TicketClient_EventPlace] FOREIGN KEY([IDEventPlace])
REFERENCES [dbo].[EventPlace] ([ID])
GO
ALTER TABLE [dbo].[TicketClient] CHECK CONSTRAINT [FK_TicketClient_EventPlace]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_EventPlace] FOREIGN KEY([IDEventPlace])
REFERENCES [dbo].[EventPlace] ([ID])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_EventPlace]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [DBTicket] SET  READ_WRITE 
GO
