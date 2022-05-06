
CREATE DATABASE [Usuarios]
*************************************************************

USE [Usuarios]
GO

/****** Object:  Table [dbo].[users]    Script Date: 5/05/2022 10:51:12 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](15) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
