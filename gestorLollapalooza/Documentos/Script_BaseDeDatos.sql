/* Creacion de tablas */

/* FESTIVAL */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[festival] (
	[idFestival] [INT] IDENTITY(1,1) NOT NULL,
	[anoEdicion] [INT] NOT NULL,
	[descuentoVentaAnticipada] [FLOAT] NULL,
	[fechaInicio] [DATETIME] NOT NULL,
	[fechaFin] [DATETIME] NOT NULL,
	[nombre] [varchar] (50) NULL,
	[porcentajeDevolucionPorAnulacion] [FLOAT] NULL,
	[vigente] [bit] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_idFestival] PRIMARY KEY CLUSTERED([idFestival] ASC)
)

/* Dia Festival */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[diaFestival](
	[idDiaFestival] [INT] IDENTITY(1,1) NOT NULL,
	[fecha] [DATETIME] NOT NULL,
	[fechaLimiteAnulacionEntrada] [DATETIME] NOT NULL,
	[fechaVtoVetaAnticipado] [DATETIME] NOT NULL,
	[idFestival] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_idDiaFestival] PRIMARY KEY CLUSTERED ([idDiaFestival] ASC)
)

/* Centro De Venta */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[centroVenta] (
	[idCentroVenta] [INT] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar] (50) NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_idCentroVenta] PRIMARY KEY CLUSTERED ( [idCentroVenta] ASC)
) 

/* Punto de Venta */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[puntoVenta] (
	[idPuntoVenta] [INT] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar] (50) NULL,
	[numero] [INT] NULL,
	[idCentroVenta] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_idPuntoVenta] PRIMARY KEY CLUSTERED ( [idpuntoVenta] ASC)
)

/* Tipo Entrada */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tipoEntrada] (
	[idTipoEntrada] [INT] IDENTITY (1,1) NOT NULL,
	[descripcion] [VARCHAR] (100) NULL,
	[nombre] [VARCHAR] (50) NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_tipoEntrada] PRIMARY KEY CLUSTERED ( [idTipoEntrada] ASC)
)

/*  Actuacion */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[actuacion] (
	[idActuacion] [INT] IDENTITY (1,1) NOT NULL,
	[duracionEstimada] [INT] NOT NULL,
	[numeroOrden] [INT] NULL,
	[idGrupoMusical] [INT] NULL,
	[idDiaFestival] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_actuacion] PRIMARY KEY CLUSTERED ( [idActuacion] ASC)
)

/* Precio Entrada */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[precioEntrada] (
	[idPrecioEntrada] [INT] IDENTITY (1,1) NOT NULL,
	[monto] [FLOAT] NOT NULL,
	[idFestival] [INT] NULL,
	[idTipoEntrada] [INT] NULL,
	[idSector] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_precioEntrada] PRIMARY KEY CLUSTERED ( [idPrecioEntrada] ASC)
)

/* Disponibiliad Butaca */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[disponibilidadButaca] (
	[idButaca] [INT] NOT NULL,
	[idDiaFestival] [INT] NOT NULL,
	[idEstado] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_disponibilidadButaca] PRIMARY KEY CLUSTERED ( [idButaca] ASC , [idDiaFestival] ASC)
)

/* Disponibilidad Estado */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[estado] (
	[idEstado] [INT] IDENTITY (1,1) NOT NULL,
	[descripcion] [VARCHAR] (100) NULL,
	[nombre] [VARCHAR] (50) NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED ( [idEstado] ASC)
)

/* Sector */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sector] (
	[idSector] [INT] IDENTITY (1,1) NOT NULL,
	[colorIdentificativo] [VARCHAR] (50) NULL,
	[nombre] [VARCHAR] (50) NULL,
	[ubicacion] [VARCHAR] (50) NOT NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_sector] PRIMARY KEY CLUSTERED ( [idSector] ASC)
)

/* Fila */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[fila] (
	[idFila] [INT] IDENTITY (1,1) NOT NULL,
	[numero] [INT] NOT NULL,
	[idSector] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_fila] PRIMARY KEY CLUSTERED ( [idFila] ASC)
)

/* perfiles */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[perfiles](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[nombrePerfil] [varchar](50) NOT NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_perfiles] PRIMARY KEY CLUSTERED ( [idPerfil] ASC)
)

/* Usuarios */

CREATE TABLE [dbo].[usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[idPerfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[nombre] [varchar] (50) NOT NULL,
    [apellido] [varchar] (50) NOT NULL,
	[email] [varchar](50) NOT NULL,	
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED ( [idUsuario] ASC)
)

/* Grupo Musical */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[grupoMusical] (
	[idGrupoMusical] [INT] IDENTITY (1,1) NOT NULL,
	[cantIntegrantes] [INT] NULL,
	[descripcion] [VARCHAR] (100)  NULL,
	[nombre] [VARCHAR] (50) NOT NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_grupoMusical] PRIMARY KEY CLUSTERED ( [idGrupoMusical] ASC)
)

/* Butaca*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[butaca] (
	[idButaca] [INT] IDENTITY (1,1) NOT NULL,
	[numero] [INT] NOT NULL,
	[idFila] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_butaca] PRIMARY KEY CLUSTERED ( [idButaca] ASC)
)

/* Entrada */

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[entrada] (
	[idEntrada] [INT] IDENTITY (1,1) NOT NULL,
	[codigoDeBarras] [INTEGER] NOT NULL,
	[fechaVenta] [DATETIME] NOT NULL,
	[monto] [FLOAT] NULL,
	[numeroTicket] [INTEGER] NOT NULL,
	[idButaca] [INT] NULL,
	[idDiaFestival] [INT] NULL,
	[idPuntoVenta] [INT] NULL,
	[borradoLogico] [BIT] DEFAULT ((0)) NULL,
	CONSTRAINT [PK_entrada] PRIMARY KEY CLUSTERED ( [idEntrada] ASC)
)


/* FK */

/* Entrada  FK */

ALTER TABLE [dbo].[entrada] WITH CHECK ADD CONSTRAINT [FK_entrada_butaca] FOREIGN KEY ([idButaca]) 
REFERENCES [dbo].[butaca] ([idButaca])

ALTER TABLE [dbo].[entrada] WITH CHECK ADD CONSTRAINT [FK_entrada_diaFestival] FOREIGN KEY ([idDiaFestival]) 
REFERENCES [dbo].[diaFestival] ([idDiaFestival])

ALTER TABLE [dbo].[entrada] WITH CHECK ADD CONSTRAINT [FK_entrada_puntoVenta] FOREIGN KEY ([idPuntoVenta]) 
REFERENCES [dbo].[puntoVenta] ([idPuntoVenta])

/* Butaca FK */

ALTER TABLE [dbo].[butaca] WITH CHECK ADD CONSTRAINT [FK_butaca_fila] FOREIGN KEY ([idFila]) 
REFERENCES [dbo].[fila] ([idFila])


/* Usuario FK */

ALTER TABLE [dbo].[usuarios] WITH CHECK ADD CONSTRAINT [FK_usuarios_perfiles] FOREIGN KEY ([idPerfil]) 
REFERENCES [dbo].[perfiles] ([idPerfil])

/* DIA Festival FK */

ALTER TABLE [dbo].[diaFestival] WITH CHECK ADD CONSTRAINT [FK_diaFestival_festival] FOREIGN KEY ([idFestival]) 
REFERENCES [dbo].[festival] ([idFestival])

/* precio_Entrada FK */

ALTER TABLE [dbo].[precioEntrada] WITH CHECK ADD CONSTRAINT [FK_precioEntrada_festival] FOREIGN KEY ([idFestival]) 
REFERENCES [dbo].[festival] ([idfestival])

ALTER TABLE [dbo].[precioEntrada] WITH CHECK ADD CONSTRAINT [FK_precioEntrada_sector] FOREIGN KEY ([idSector]) 
REFERENCES [dbo].[sector] ([idSector])

ALTER TABLE [dbo].[precioEntrada] WITH CHECK ADD CONSTRAINT [FK_precioEntrada_tipoEntrada] FOREIGN KEY ([idTipoEntrada]) 
REFERENCES [dbo].[tipoEntrada] ([idTipoEntrada])

/* Punto venta  FK */ 

ALTER TABLE [dbo].[puntoVenta] WITH CHECK ADD CONSTRAINT [FK_puntoVenta_centroVenta] FOREIGN KEY ([idCentroVenta]) 
REFERENCES [dbo].[centroVenta] ([idCentroVenta])

/* Fila FK*/

ALTER TABLE [dbo].[fila] WITH CHECK ADD CONSTRAINT [FK_fila_sector] FOREIGN KEY ([idSector]) 
REFERENCES [dbo].[sector] ([idSector])

/* ACTUACION FK */

ALTER TABLE [dbo].[actuacion] WITH CHECK ADD CONSTRAINT [FK_actuacion_grupoMusical] FOREIGN KEY ([idGrupoMusical])
REFERENCES [dbo].[grupoMusical] ([idGrupoMusical])

ALTER TABLE [dbo].[actuacion] WITH CHECK ADD CONSTRAINT [FK_actuacion_diaFestival] FOREIGN KEY ([idDiaFestival])
REFERENCES [dbo].[diaFestival] ([idDiaFestival])


/* Disponibilidad Butaca FK */

ALTER TABLE [dbo].[disponibilidadButaca] WITH CHECK ADD CONSTRAINT [FK_disponibilidadButaca_butaca] FOREIGN KEY ([idButaca])
REFERENCES [dbo].[butaca] ([idButaca])

ALTER TABLE [dbo].[disponibilidadButaca] WITH CHECK ADD CONSTRAINT [FK_disponibilidadButaca_diaFestival] FOREIGN KEY ([idDiaFestival])
REFERENCES [dbo].[diaFestival] ([idDiaFestival])

ALTER TABLE [dbo].[disponibilidadButaca] WITH CHECK ADD CONSTRAINT [FK_disponibilidadButaca_estado] FOREIGN KEY ([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])


ALTER TABLE [dbo].[festival]
add 	[cantEntradasVentidas] AS (  anoEdicion + idFestival * 145)

ALTER TABLE [dbo].[festival]
add 	[cantRecaudado] AS ( 25000.75 * anoEdicion + 15 * idFestival)

