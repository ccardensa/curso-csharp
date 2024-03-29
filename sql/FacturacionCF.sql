USE [FacturacionCF]
GO
/****** Object:  Schema [Producto]    Script Date: 10/29/2022 5:40:11 PM ******/
CREATE SCHEMA [Producto]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Rut] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](max) NULL,
	[Cantidad] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
	[CodigoItem] [int] NULL,
	[PrecioUnitario] [int] NULL,
	[ImpuestoUnico] [int] NULL,
	[ImpuestoDos] [int] NULL,
	[ImpuestoTres] [int] NULL,
	[Descuento] [int] NULL,
 CONSTRAINT [PK_Detalles] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoTributarios]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoTributarios](
	[IdDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
	[DeleteDate] [datetime2](7) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdTipoDocumento] [int] NOT NULL,
 CONSTRAINT [PK_DocumentoTributarios] PRIMARY KEY CLUSTERED 
(
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentos]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentos](
	[IdTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[Timestamp] [time](7) NOT NULL,
 CONSTRAINT [PK_TipoDocumentos] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Producto].[ListaPrecios]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Producto].[ListaPrecios](
	[IdListaPrecio] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [int] NOT NULL,
	[Temporada] [nvarchar](max) NULL,
	[IdProducto] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_ListaPrecios] PRIMARY KEY CLUSTERED 
(
	[IdListaPrecio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Producto].[Productos]    Script Date: 10/29/2022 5:40:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Producto].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Codigo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_DocumentoTributarios_IdDocumento] FOREIGN KEY([IdDocumento])
REFERENCES [dbo].[DocumentoTributarios] ([IdDocumento])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalles] CHECK CONSTRAINT [FK_Detalles_DocumentoTributarios_IdDocumento]
GO
ALTER TABLE [dbo].[DocumentoTributarios]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoTributarios_Clientes_IdCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocumentoTributarios] CHECK CONSTRAINT [FK_DocumentoTributarios_Clientes_IdCliente]
GO
ALTER TABLE [dbo].[DocumentoTributarios]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoTributarios_TipoDocumentos_IdTipoDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumentos] ([IdTipoDocumento])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocumentoTributarios] CHECK CONSTRAINT [FK_DocumentoTributarios_TipoDocumentos_IdTipoDocumento]
GO
ALTER TABLE [Producto].[ListaPrecios]  WITH CHECK ADD  CONSTRAINT [FK_ListaPrecios_Productos] FOREIGN KEY([IdProducto])
REFERENCES [Producto].[Productos] ([IdProducto])
GO
ALTER TABLE [Producto].[ListaPrecios] CHECK CONSTRAINT [FK_ListaPrecios_Productos]
GO
