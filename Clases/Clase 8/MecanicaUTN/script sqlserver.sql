CREATE TABLE [dbo].[repuesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[modelo] [varchar](100) NOT NULL,
	[marca] [varchar](100) NOT NULL,
	[cantidad] [float] NOT NULL,
	[precio] [numeric](18, 0) NOT NULL,
	[impuesto] [float] NOT NULL,
	[gravado] [bit] NOT NULL,
 CONSTRAINT [PK_repuesto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
