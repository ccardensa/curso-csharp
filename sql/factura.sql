USE [Factura]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 10/29/2022 5:40:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](500) NULL,
	[Cantidad] [int] NULL,
	[IdFactura] [int] NOT NULL,
	[CodigoItem] [int] NULL,
	[PrecioUnitario] [int] NULL,
	[ImpuestoUnico] [int] NULL,
	[ImpuestoDos] [int] NULL,
	[ImpuestoTres] [int] NULL,
	[Descuento] [int] NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 10/29/2022 5:40:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NULL,
	[Direccion] [varchar](250) NULL,
	[Giro] [varchar](250) NULL,
	[NumeroFactura] [int] NULL,
	[IdVendedor] [int] NULL,
	[TipoVenta] [varchar](250) NULL,
	[IdCliente] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [datetime2](7) NULL,
	[UpdateDate] [datetime2](7) NULL,
	[DeleteDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura1] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Factura] ([IdFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura1]
GO
