USE [registro_civil]
GO
/****** Object:  User [mecanica]    Script Date: 06/03/2015 06:23:20 p.m. ******/
CREATE USER [mecanica] FOR LOGIN [mecanica] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mecanica]
GO
/****** Object:  Table [dbo].[codigoelectoral]    Script Date: 06/03/2015 06:23:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[codigoelectoral](
	[codelec] [varchar](30) NOT NULL,
	[provincia] [varchar](30) NOT NULL,
	[canton] [varchar](30) NOT NULL,
	[distrito] [varchar](30) NOT NULL,
 CONSTRAINT [pk_codigoelectoral_1] PRIMARY KEY CLUSTERED 
(
	[codelec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[persona]    Script Date: 06/03/2015 06:23:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[persona](
	[cedula] [varchar](30) NOT NULL,
	[nombrecompleto] [varchar](200) NOT NULL,
	[sexo] [int] NOT NULL,
	[codelec] [varchar](30) NOT NULL,
 CONSTRAINT [pk_codigoelectoral] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [FK_persona_codigoelectoral] FOREIGN KEY([codelec])
REFERENCES [dbo].[codigoelectoral] ([codelec])
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [FK_persona_codigoelectoral]
GO
