USE [master]
GO
/****** Object:  Database [general]    Script Date: 2020/04/16 16:40:46 ******/
CREATE DATABASE [general]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'General', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\general.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'General_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\general_0.ldf' , SIZE = 2880KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [general] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [general].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [general] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [general] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [general] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [general] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [general] SET ARITHABORT OFF 
GO
ALTER DATABASE [general] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [general] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [general] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [general] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [general] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [general] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [general] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [general] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [general] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [general] SET  DISABLE_BROKER 
GO
ALTER DATABASE [general] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [general] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [general] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [general] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [general] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [general] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [general] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [general] SET RECOVERY FULL 
GO
ALTER DATABASE [general] SET  MULTI_USER 
GO
ALTER DATABASE [general] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [general] SET DB_CHAINING OFF 
GO
ALTER DATABASE [general] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [general] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [general] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'general', N'ON'
GO
ALTER DATABASE [general] SET QUERY_STORE = OFF
GO
USE [general]
GO
/****** Object:  Table [dbo].[ActivityLog]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityLog](
	[Id] [uniqueidentifier] NOT NULL,
	[ActivityName] [nvarchar](max) NOT NULL,
	[Method] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[CreationTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[IsMenu] [bit] NOT NULL,
	[SysResource] [nvarchar](400) NOT NULL,
	[ResouceID] [nvarchar](500) NOT NULL,
	[FatherResource] [nvarchar](500) NULL,
	[FatherID] [nvarchar](500) NULL,
	[Controller] [nvarchar](500) NULL,
	[Action] [nvarchar](500) NULL,
	[RouteName] [nvarchar](500) NULL,
	[CssClass] [nvarchar](500) NULL,
	[Sort] [int] NOT NULL,
	[IsDisabled] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysDomain]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysDomain](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DomainType] [int] NOT NULL,
	[Domain] [nvarchar](500) NOT NULL,
	[CreationTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysLog]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysLog](
	[Id] [uniqueidentifier] NOT NULL,
	[Level] [int] NOT NULL,
	[ShortMessage] [nvarchar](max) NOT NULL,
	[FullMessage] [nvarchar](max) NULL,
	[IpAddress] [nvarchar](50) NULL,
	[PageUrl] [nvarchar](max) NULL,
	[ReferrerUrl] [nvarchar](max) NULL,
	[CreationTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysPermission]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysPermission](
	[Id] [uniqueidentifier] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[Creator] [uniqueidentifier] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PermissionRecord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysRole]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysRole](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Creator] [uniqueidentifier] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[Modifier] [uniqueidentifier] NULL,
	[ModifiedTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysStore]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysStore](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[SslEnabled] [bit] NOT NULL,
	[Disabled] [bit] NOT NULL,
	[IconClass] [nvarchar](500) NOT NULL,
	[CompanyName] [nvarchar](500) NULL,
	[Creator] [uniqueidentifier] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[Modifier] [uniqueidentifier] NULL,
	[ModifiedTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUser](
	[Id] [uniqueidentifier] NOT NULL,
	[Account] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[MobilePhone] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Salt] [nvarchar](max) NOT NULL,
	[Sex] [nvarchar](2) NULL,
	[Enabled] [bit] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[LoginFailedNum] [int] NOT NULL,
	[AllowLoginTime] [datetime] NULL,
	[LoginLock] [bit] NOT NULL,
	[LastLoginTime] [datetime] NULL,
	[LastIpAddress] [nvarchar](50) NULL,
	[LastActivityTime] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedTime] [datetime] NULL,
	[ModifiedTime] [datetime] NULL,
	[Modifier] [uniqueidentifier] NULL,
	[Creator] [uniqueidentifier] NULL,
	[Avatar] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUserLoginLog]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserLoginLog](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[IpAddress] [nvarchar](50) NOT NULL,
	[LoginTime] [datetime] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUserRole]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserRole](
	[Id] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUserToken]    Script Date: 2020/04/16 16:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserToken](
	[Id] [uniqueidentifier] NOT NULL,
	[SysUserId] [uniqueidentifier] NOT NULL,
	[ExpireTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1, N'系统管理', 1, N'General.Mvc.Areas.Admin.Controllers.SystemManageController', N'0313551edcd115ae48eb7a6374b2c14c', NULL, N'', NULL, NULL, NULL, N'menu-icon fa fa-desktop', 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (3, N'系统用户', 1, N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'General.Mvc.Areas.Admin.Controllers.SystemManageController', N'0313551edcd115ae48eb7a6374b2c14c', N'User', N'UserIndex', N'userIndex', N'menu-icon fa fa-caret-right', 0, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1002, N'角色列表', 1, N'General.Mvc.Areas.Admin.Controllers.RoleController.RoleIndex', N'1aa866003b08f4f053d59ec235f13bca', N'General.Mvc.Areas.Admin.Controllers.SystemManageController', N'0313551edcd115ae48eb7a6374b2c14c', N'Role', N'RoleIndex', N'roleIndex', N'menu-icon fa fa-caret-right', 1, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1003, N'新增、修改角色', 0, N'General.Mvc.Areas.Admin.Controllers.RoleController.EditRole', N'0ef642448f09a922a11d194715d8808d', N'General.Mvc.Areas.Admin.Controllers.RoleController.RoleIndex', N'1aa866003b08f4f053d59ec235f13bca', N'Role', N'EditRole', N'editRole', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1004, N'删除角色', 0, N'General.Mvc.Areas.Admin.Controllers.RoleController.DeleteRole', N'4fb09bfa5c7d8a66393268fc2120f2e0', N'General.Mvc.Areas.Admin.Controllers.RoleController.RoleIndex', N'1aa866003b08f4f053d59ec235f13bca', N'Role', N'DeleteRole', N'deleteRole', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1005, N'角色权限设置', 0, N'General.Mvc.Areas.Admin.Controllers.RoleController.RolePermission', N'19b29a1929b234925c014223a40e3698', N'General.Mvc.Areas.Admin.Controllers.RoleController.RoleIndex', N'1aa866003b08f4f053d59ec235f13bca', N'Role', N'RolePermission', N'rolePermission', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1006, N'编辑系统用户', 0, N'General.Mvc.Areas.Admin.Controllers.UserController.EditUser', N'ed09a0415daaabc39b36f76b45b24577', N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'User', N'EditUser', N'editUser', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1007, N'设置启用与禁用账号', 0, N'General.Mvc.Areas.Admin.Controllers.UserController.Enabled', N'283b742f8f1ea4f6d837b0b5a2c30013', N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'User', N'Enabled', N'enabled', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1008, N'设置登录锁解锁与锁定', 0, N'General.Mvc.Areas.Admin.Controllers.UserController.LoginLock', N'fa355a2c51696ddce01f157e3625aad7', N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'User', N'LoginLock', N'loginLock', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1009, N'删除用户', 0, N'General.Mvc.Areas.Admin.Controllers.UserController.DeleteUser', N'e167a84b5d93cf399c64b215d78f9a18', N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'User', N'DeleteUser', N'deleteUser', NULL, 100, 0)
INSERT [dbo].[Category] ([Id], [Name], [IsMenu], [SysResource], [ResouceID], [FatherResource], [FatherID], [Controller], [Action], [RouteName], [CssClass], [Sort], [IsDisabled]) VALUES (1010, N'重置用密码', 0, N'General.Mvc.Areas.Admin.Controllers.UserController.ResetPassword', N'f3257be800d6f19f52962da399a81c0e', N'General.Mvc.Areas.Admin.Controllers.UserController.UserIndex', N'f331e06811f2c0d5934926b114e5b24a', N'User', N'ResetPassword', N'resetPassword', NULL, 100, 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'a26105f3-175f-452f-acb1-19ba42fb1075', 40, N'未将对象引用设置到对象的实例。', N'未将对象引用设置到对象的实例。', N'127.0.0.1', N'http://localhost:55503/admin', N'/admin', CAST(N'2017-09-05T15:47:26.387' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'120676cc-c9ec-47cc-b96e-459ebec155c1', 40, N'F:\gitstorage\Mangix.Mvc\Mangix.Mvc\Mangix.Admin\Areas\admin\Views\Shared\_NavbarPartial.cshtml(47): error CS1061: ''IWorkContext'' does not contain a definition for ''MyDescriperes'' and no extension method ''MyDescriperes'' accepting a first argument of type ''IWorkContext'' could be found (are you missing a using directive or an assembly reference?)', N'F:\gitstorage\Mangix.Mvc\Mangix.Mvc\Mangix.Admin\Areas\admin\Views\Shared\_NavbarPartial.cshtml(47): error CS1061: ''IWorkContext'' does not contain a definition for ''MyDescriperes'' and no extension method ''MyDescriperes'' accepting a first argument of type ''IWorkContext'' could be found (are you missing a using directive or an assembly reference?)', N'127.0.0.1', N'http://localhost:55503/admin/home', N'/admin', CAST(N'2017-09-05T15:39:57.703' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'ca8604f9-b201-4425-a4d8-538db82c657b', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-09-05T15:51:28.323' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'84689813-ba66-4571-91c7-6e1e7ecd81b8', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-07-09T22:11:09.467' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'19f410f3-230f-4e18-a069-769dc2dd3d26', 40, N'未将对象引用设置到对象的实例。', N'未将对象引用设置到对象的实例。', N'127.0.0.1', N'http://localhost:55503/admin', N'/admin', CAST(N'2017-09-05T15:39:45.173' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'24244efd-a8c9-4c22-ab58-81c76452f7e7', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-09-05T15:47:04.860' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'4b5ac0de-3384-4d0b-ba25-8e8f78aec7e4', 40, N'值不能为 null。
参数名: source', N'值不能为 null。
参数名: source', N'127.0.0.1', N'http://localhost:55503/admin/home', N'/admin', CAST(N'2017-09-05T15:47:47.037' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'b4abf9c2-f832-4deb-9330-927768b70bcc', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-07-09T22:06:12.737' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'19775571-77be-464a-b9d8-a92ae7f62862', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-09-05T15:39:25.407' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'c71078d9-b11a-457a-b1f2-b3b19a8713d8', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-09-05T15:53:29.720' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'02c13948-2e5c-4c32-bc4d-d2eb5a7162c4', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-07-09T22:07:40.807' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'c447ddd1-4e83-44d0-ae67-d2ec8a02004b', 20, N'Admin 系统启动', N'', N'', N'', N'', CAST(N'2017-07-09T22:01:32.860' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'75b942c3-9278-47b5-bb22-e98fb889c203', 40, N'未将对象引用设置到对象的实例。', N'未将对象引用设置到对象的实例。', N'127.0.0.1', N'http://localhost:55503/admin', N'/admin', CAST(N'2017-07-09T22:12:23.687' AS DateTime))
INSERT [dbo].[SysLog] ([Id], [Level], [ShortMessage], [FullMessage], [IpAddress], [PageUrl], [ReferrerUrl], [CreationTime]) VALUES (N'c7437b74-b2a0-439e-9489-fbf654833793', 40, N'未将对象引用设置到对象的实例。', N'未将对象引用设置到对象的实例。', N'127.0.0.1', N'http://localhost:55503/admin', N'/admin', CAST(N'2017-07-09T22:12:27.117' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'b304412a-1c17-4ada-b50e-0c2b188b1a60', 1004, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:23:41.527' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'0e2185c2-07ce-4385-b6b3-2614bd000f8f', 1, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:21:18.283' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'3bbd70e3-97e1-43a9-9492-3a8e21e2e508', 1003, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:23:41.523' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'a51d14cb-f21e-4d1a-91f1-424bbf9874d0', 1005, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:23:41.527' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'a5584192-702d-4649-965c-7a9402ada2a0', 1002, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:23:41.520' AS DateTime))
INSERT [dbo].[SysPermission] ([Id], [CategoryId], [RoleId], [Creator], [CreationTime]) VALUES (N'64d2e5fc-c88a-420c-b27b-e2fc3823c406', 3, N'264c4157-8414-4b9d-89c0-5671b0f61257', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-18T00:23:41.517' AS DateTime))
INSERT [dbo].[SysRole] ([Id], [Name], [Creator], [CreationTime], [Modifier], [ModifiedTime]) VALUES (N'264c4157-8414-4b9d-89c0-5671b0f61257', N'管理员', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-08T16:21:37.753' AS DateTime), N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-17T23:35:11.803' AS DateTime))
INSERT [dbo].[SysRole] ([Id], [Name], [Creator], [CreationTime], [Modifier], [ModifiedTime]) VALUES (N'32ce6463-25e7-4b8e-acd0-d8ca262270e4', N'编辑人员', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-17T01:07:22.333' AS DateTime), NULL, NULL)
INSERT [dbo].[SysUser] ([Id], [Account], [Name], [Email], [MobilePhone], [Password], [Salt], [Sex], [Enabled], [IsAdmin], [CreationTime], [LoginFailedNum], [AllowLoginTime], [LoginLock], [LastLoginTime], [LastIpAddress], [LastActivityTime], [IsDeleted], [DeletedTime], [ModifiedTime], [Modifier], [Creator], [Avatar]) VALUES (N'd5b9b094-f5cd-47e4-8e6d-054730883317', N'sdfdssdd', N'sdsd', NULL, NULL, N'ebb2ec43813cc013e7290a007f78772d', N'VemxiiJlhlEG3fN2yFH+1ar1coTYR4TS2+Lb9zYvJTA=', NULL, 1, 0, CAST(N'2017-10-26T11:49:15.247' AS DateTime), 0, NULL, 0, NULL, NULL, NULL, 0, NULL, NULL, NULL, N'0f42c190-d965-43f8-96f6-865d4dbb0a41', NULL)
INSERT [dbo].[SysUser] ([Id], [Account], [Name], [Email], [MobilePhone], [Password], [Salt], [Sex], [Enabled], [IsAdmin], [CreationTime], [LoginFailedNum], [AllowLoginTime], [LoginLock], [LastLoginTime], [LastIpAddress], [LastActivityTime], [IsDeleted], [DeletedTime], [ModifiedTime], [Modifier], [Creator], [Avatar]) VALUES (N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'admin', N'超级管理员', NULL, NULL, N'161e7675716c353c9673322b423acccd', N'tmSYU03KOXqEwjLPgG8nDV7CK8maQUPFA/czwfV3orI=', N'', 1, 1, CAST(N'2017-07-09T22:10:01.837' AS DateTime), 0, NULL, 0, CAST(N'2017-11-07T14:20:15.153' AS DateTime), N'', CAST(N'2017-09-05T15:53:44.557' AS DateTime), 0, NULL, CAST(N'2017-09-05T15:47:26.310' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'60a1c716-8ecf-4ca3-9fc5-0d6b492dad55', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-11-07T14:20:15.153' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'1f06914e-7820-4da6-a560-1cb72b40b281', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-24T22:25:26.317' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'87b9a61d-a482-46ab-89cf-247298faf460', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:32:55.153' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'ba914c67-be0c-4171-88ea-2b6b37592b87', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:02.930' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'685c8474-630a-4b34-ad73-2d4458400185', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:29:56.927' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'b5667710-0249-4ae8-8b91-2dd1bcfb6327', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T15:58:38.867' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'afa1818e-46bb-4fd9-8939-303abbf10859', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:30:34.527' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'd1c87fc2-f109-4656-a2fe-30f9ead559ac', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-24T23:11:38.137' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'e6960283-94b7-4783-a4eb-311c1a7fa4e4', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-11-07T14:20:03.873' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'723e5568-e4a0-4fa8-8a10-3fd64a9590ee', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:29:42.290' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'21073e98-ff04-4328-ac63-5a0bb54a3a40', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-10T00:21:35.323' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'fc73ae7d-ed0b-45c5-854f-5a6fb80e5946', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-24T22:25:23.150' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'505feb19-9236-4e84-81f9-65bd00552b19', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:22.537' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'8e749d16-55ea-4098-a2b9-74c22eb9aa9e', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:30:20.607' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'5039928d-bbfe-4859-afd8-84146c603e5a', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'127.0.0.1', CAST(N'2017-07-09T22:12:27.090' AS DateTime), N'登入：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'b9d414f4-c13a-4f1c-bbb6-87a9fd36ceb2', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'127.0.0.1', CAST(N'2017-09-05T15:39:45.120' AS DateTime), N'登入：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'6ba9a348-0c9c-4a7d-b9e4-8daadb85e1f1', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:29:19.367' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'65603f5c-0de4-4749-b0a5-92d504d5d8d7', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:27.930' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'855aca4d-b959-47c5-82de-9853d7db9a66', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-15T00:46:46.750' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'474290c9-e885-4928-abc5-995b4d05b31d', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T09:44:04.863' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'c8837aec-0aa3-4806-a328-9a92e057a39f', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'127.0.0.1', CAST(N'2017-07-09T22:12:23.623' AS DateTime), N'登入：失败')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'a2921dc5-9d02-44c6-a057-9d586b7000ce', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-17T00:41:47.087' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'565b7d61-c43c-4b63-94f1-a44fd0ee815e', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T15:10:14.117' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'296593ef-837a-4c3a-91d7-a4a746674cb7', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:25.493' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'e1c5d96f-4c08-41b7-8cf5-ae691ff0f07f', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-11-07T14:20:09.720' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'f9d15c37-0e5a-4365-934e-af2008bfb3cf', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-17T00:47:39.340' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'8abaf588-98f8-4831-a6bd-b1d539c2912e', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:30.620' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'0d947394-2b1a-49f7-b0a2-b2b82e34c2b7', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'127.0.0.1', CAST(N'2017-09-05T15:47:26.307' AS DateTime), N'登入：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'3925b2c2-e425-48a7-926c-c000a8f1cfd8', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:30:23.600' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'7ee83eb4-79ec-4f0c-baff-d40ebadd1f8d', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:14:43.417' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'3ef8d590-540c-466a-9a06-d659dc147b13', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-11-07T14:19:53.057' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'c530645e-e55e-42dd-897c-d8d253686e98', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-15T01:22:16.493' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'ebf66d31-80e3-45d6-b10d-dc763aa40c22', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:41:51.540' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'9d01cff9-4a33-4b11-a9c1-dccd866a045d', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-24T22:25:22.097' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'e18efff4-c961-4ade-9c7d-de8978fa2db0', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-17T23:35:04.653' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'7a6bc9cc-a1aa-4880-9f09-e0ab63f4ee7d', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T15:57:34.847' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'f7ea91db-c719-4354-95fa-eab7daa83e14', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-26T09:21:03.467' AS DateTime), N'登录：成功')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'0d7ce0db-d78f-4cc4-8ae5-edb8197ac188', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-07T22:40:16.887' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'1c227698-abdf-4958-8dd0-f02e9821594b', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-10-08T00:29:50.530' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserLoginLog] ([Id], [UserId], [IpAddress], [LoginTime], [Message]) VALUES (N'ab7aadb4-181c-4c6f-9774-f9b0df973c07', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', N'', CAST(N'2017-11-07T14:19:58.090' AS DateTime), N'登录：密码错误')
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'32687123-409c-41e5-b328-09a62e9255ab', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:30:23.600' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'b3990295-2e72-412e-a11d-1bcc11937649', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:30:34.527' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'21513f8d-5a6a-4ec7-8fcb-2cdd16dd91b6', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-09-20T15:47:26.390' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'5ddcf78a-ef96-4169-be98-32b28d312236', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:29:19.370' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'15c6c575-1420-4973-9c2c-345520807a39', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-22T14:20:15.153' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'49a3704d-abb5-4770-833d-3c90c252a0eb', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-08T23:11:38.137' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'49a5047a-dd15-4950-bc5a-3d5d54064c32', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:29:56.927' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'a47ca048-d664-46d6-8f52-48db3c3f1733', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:14:43.417' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'87e1689b-e9e8-42e0-a919-4ae292828b1d', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:30:20.607' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'9b263763-7474-454d-92d2-523ad5c47bc2', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-10T09:21:03.467' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'ce1762e1-54ab-4c5f-bb08-59bf2ebc5a40', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-30T00:46:46.750' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'1762a35b-f519-49e2-a43c-665196a22732', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-01T00:41:47.087' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'4f0fe4dc-37ce-4cd5-a212-6acc0854fb94', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-01T00:47:39.340' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'5c6fa56e-4f3b-4741-954f-72c7834d79c7', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T15:58:38.867' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'262f5bf8-8cb2-4379-901a-748e5af41943', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:29:42.290' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'0b192a4d-3ced-4345-8b78-8b88eaec3bdd', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T15:57:34.847' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'a4431d4d-fc18-49f9-80e8-ab38dce79030', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-08T22:25:26.317' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'e11bf7f2-e1de-47b4-9495-b0da078d3959', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-11-01T23:35:04.653' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'ef05ebe7-b737-469b-8102-b2a4f4805d11', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T15:10:14.117' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'fb45cbe9-0126-4123-973d-c336761fa9e0', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-22T22:41:51.543' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'd0c5ff81-c07c-4a4d-9804-cf045c0df9cf', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T09:44:04.863' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'a8314d41-0fae-4fbd-8cff-dc4855eeeb41', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-30T01:22:16.493' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'64a5bf51-8940-49ac-8bba-fbff2384fc1c', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-23T00:32:55.153' AS DateTime))
INSERT [dbo].[SysUserToken] ([Id], [SysUserId], [ExpireTime]) VALUES (N'73d04eda-29c0-4590-96fb-ffa1d4bb874a', N'0f42c190-d965-43f8-96f6-865d4dbb0a41', CAST(N'2017-10-25T00:21:35.323' AS DateTime))
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Category]    Script Date: 2020/04/16 16:40:47 ******/
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [IX_Category] UNIQUE NONCLUSTERED 
(
	[SysResource] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_Sort]  DEFAULT ((100)) FOR [Sort]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_IsDisabled]  DEFAULT ((0)) FOR [IsDisabled]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysDomain] ADD  CONSTRAINT [DF_SysDomain_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysLog] ADD  CONSTRAINT [DF_SysLog_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysLog] ADD  CONSTRAINT [DF_SysLog_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysPermission] ADD  CONSTRAINT [DF_PermissionRecord_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysPermission] ADD  CONSTRAINT [DF_PermissionRecord_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysRole] ADD  CONSTRAINT [DF_SysRole_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysRole] ADD  CONSTRAINT [DF_SysRole_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysStore] ADD  CONSTRAINT [DF_SysStore_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysStore] ADD  CONSTRAINT [DF_SysStore_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_Enabled]  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_CreationTime]  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_LoginFailedNum]  DEFAULT ((0)) FOR [LoginFailedNum]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_LoginLock]  DEFAULT ((0)) FOR [LoginLock]
GO
ALTER TABLE [dbo].[SysUser] ADD  CONSTRAINT [DF_SysUser_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[SysUserRole] ADD  CONSTRAINT [DF_SysUserRole_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ActivityLog]  WITH CHECK ADD  CONSTRAINT [FK_ActivityLog_SysUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[ActivityLog] CHECK CONSTRAINT [FK_ActivityLog_SysUser]
GO
ALTER TABLE [dbo].[SysPermission]  WITH CHECK ADD  CONSTRAINT [FK_PermissionRecord_SysRole] FOREIGN KEY([RoleId])
REFERENCES [dbo].[SysRole] ([Id])
GO
ALTER TABLE [dbo].[SysPermission] CHECK CONSTRAINT [FK_PermissionRecord_SysRole]
GO
ALTER TABLE [dbo].[SysPermission]  WITH CHECK ADD  CONSTRAINT [FK_PermissionRecord_SysUser] FOREIGN KEY([Creator])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysPermission] CHECK CONSTRAINT [FK_PermissionRecord_SysUser]
GO
ALTER TABLE [dbo].[SysPermission]  WITH CHECK ADD  CONSTRAINT [FK_SysPermission_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[SysPermission] CHECK CONSTRAINT [FK_SysPermission_Category]
GO
ALTER TABLE [dbo].[SysRole]  WITH CHECK ADD  CONSTRAINT [FK_SysRole_SysUser] FOREIGN KEY([Creator])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysRole] CHECK CONSTRAINT [FK_SysRole_SysUser]
GO
ALTER TABLE [dbo].[SysRole]  WITH CHECK ADD  CONSTRAINT [FK_SysRole_SysUser1] FOREIGN KEY([Modifier])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysRole] CHECK CONSTRAINT [FK_SysRole_SysUser1]
GO
ALTER TABLE [dbo].[SysStore]  WITH CHECK ADD  CONSTRAINT [FK_SysStore_SysUser] FOREIGN KEY([Creator])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysStore] CHECK CONSTRAINT [FK_SysStore_SysUser]
GO
ALTER TABLE [dbo].[SysStore]  WITH CHECK ADD  CONSTRAINT [FK_SysStore_SysUser_Modifier] FOREIGN KEY([Modifier])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysStore] CHECK CONSTRAINT [FK_SysStore_SysUser_Modifier]
GO
ALTER TABLE [dbo].[SysUser]  WITH CHECK ADD  CONSTRAINT [FK_SysUser_SysUser] FOREIGN KEY([Id])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysUser] CHECK CONSTRAINT [FK_SysUser_SysUser]
GO
ALTER TABLE [dbo].[SysUser]  WITH CHECK ADD  CONSTRAINT [FK_SysUser_SysUser_creator] FOREIGN KEY([Creator])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysUser] CHECK CONSTRAINT [FK_SysUser_SysUser_creator]
GO
ALTER TABLE [dbo].[SysUserLoginLog]  WITH CHECK ADD  CONSTRAINT [FK_SysUserLoginLog_SysUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysUserLoginLog] CHECK CONSTRAINT [FK_SysUserLoginLog_SysUser]
GO
ALTER TABLE [dbo].[SysUserRole]  WITH CHECK ADD  CONSTRAINT [FK_SysUserRole_SysRole] FOREIGN KEY([RoleId])
REFERENCES [dbo].[SysRole] ([Id])
GO
ALTER TABLE [dbo].[SysUserRole] CHECK CONSTRAINT [FK_SysUserRole_SysRole]
GO
ALTER TABLE [dbo].[SysUserRole]  WITH CHECK ADD  CONSTRAINT [FK_SysUserRole_SysUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysUserRole] CHECK CONSTRAINT [FK_SysUserRole_SysUser]
GO
ALTER TABLE [dbo].[SysUserToken]  WITH CHECK ADD  CONSTRAINT [FK_SysUserToken_SysUser] FOREIGN KEY([SysUserId])
REFERENCES [dbo].[SysUser] ([Id])
GO
ALTER TABLE [dbo].[SysUserToken] CHECK CONSTRAINT [FK_SysUserToken_SysUser]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'禁用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Category', @level2type=N'COLUMN',@level2name=N'IsDisabled'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色权限数据列表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysPermission'
GO
USE [master]
GO
ALTER DATABASE [general] SET  READ_WRITE 
GO
