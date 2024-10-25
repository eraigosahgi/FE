USE [DEV_FacturacionElectronica]
GO
/****** Object:  Table [dbo].[TblCorreosRecepcion]    Script Date: 10/09/2020 14:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCorreosRecepcion](
	[StrIdentificacion] [varchar](50) NOT NULL,
	[StrMailRegistrado] [varchar](200) NOT NULL,
	[DatFechaRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_TblCorreosRecepcion] PRIMARY KEY CLUSTERED 
(
	[StrIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
