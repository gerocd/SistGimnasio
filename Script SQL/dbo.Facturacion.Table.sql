USE [dbGimnasio]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 12/11/2022 19:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[Id] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Pack] [varchar](50) NOT NULL,
	[Precio_Unitario] [float] NOT NULL,
	[Importe_Final]  AS ([Cantidad]*[Precio_Unitario])
) ON [PRIMARY]
GO
