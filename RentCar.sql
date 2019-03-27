USE [RentCar]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [varchar](20) NULL,
	[CedulaCliente] [varchar](15) NULL,
	[DireccionCliente] [varchar](35) NULL,
	[NoTarjetaCR] [varchar](15) NULL,
	[LimiteCredito] [money] NULL,
	[TipoPersona] [varchar](10) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](20) NULL,
	[CedulaEmpleado] [varchar](12) NULL,
	[TandaLabor] [varchar](15) NULL,
	[PorcientoComision] [varchar](10) NULL,
	[FechaIngreso] [date] NULL,
	[Estado] [nchar](10) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspeccionV]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspeccionV](
	[IdInspeccion] [int] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [int] NULL,
	[IdCliente] [int] NULL,
	[Ralladuras] [varchar](50) NULL,
	[CantidadCombustible] [varchar](50) NULL,
	[GomaRespuesto] [varchar](50) NULL,
	[Gato] [varchar](50) NULL,
	[RoturaCristal] [varchar](50) NULL,
	[EstadoGomas] [varchar](50) NULL,
	[FechaInspeccion] [datetime] NULL,
	[IdEmpleado] [int] NULL,
 CONSTRAINT [PK_InspeccionV] PRIMARY KEY CLUSTERED 
(
	[IdInspeccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Renta]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Renta](
	[IdRenta] [int] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [int] NULL,
	[IdEmpleado] [int] NULL,
	[IdCliente] [int] NULL,
	[FechaRenta] [varchar](15) NULL,
	[DepositoRenta] [varchar](10) NULL,
	[MontoXdia] [varchar](20) NULL,
	[CantidadDias] [varchar](10) NULL,
	[Comentario] [varchar](15) NULL,
	[FechaDevolucion] [varchar](15) NULL,
 CONSTRAINT [PK_Renta] PRIMARY KEY CLUSTERED 
(
	[IdRenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[IdVehiculos] [int] IDENTITY(1,1) NOT NULL,
	[MarcaVehiculos] [varchar](20) NULL,
	[ModeloVehiculos] [varchar](15) NULL,
	[TipoCombustible] [varchar](15) NULL,
	[TipoVehiculo] [varchar](10) NULL,
	[NoChasis] [varchar](20) NULL,
	[NoMotor] [varchar](20) NULL,
	[NoPlaca] [varchar](20) NULL,
	[DescripcionVehiculo] [varchar](30) NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[IdVehiculos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_TipoPersona]  DEFAULT (N'Fisica] or [Juridica') FOR [TipoPersona]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_Estado]  DEFAULT (N'Activo] or [Inactivo') FOR [Estado]
GO
ALTER TABLE [dbo].[InspeccionV]  WITH CHECK ADD  CONSTRAINT [FK_InspeccionV_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[InspeccionV] CHECK CONSTRAINT [FK_InspeccionV_Cliente]
GO
ALTER TABLE [dbo].[InspeccionV]  WITH CHECK ADD  CONSTRAINT [FK_InspeccionV_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[InspeccionV] CHECK CONSTRAINT [FK_InspeccionV_Empleado]
GO
ALTER TABLE [dbo].[InspeccionV]  WITH CHECK ADD  CONSTRAINT [FK_InspeccionV_Vehiculos] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculos] ([IdVehiculos])
GO
ALTER TABLE [dbo].[InspeccionV] CHECK CONSTRAINT [FK_InspeccionV_Vehiculos]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Cliente]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Empleado]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Vehiculos] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculos] ([IdVehiculos])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Vehiculos]
GO
/****** Object:  StoredProcedure [dbo].[ListadoVehiculos]    Script Date: 16/2/2019 6:04:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListadoVehiculos]
as
select IdVehiculos from Vehiculos
GO
