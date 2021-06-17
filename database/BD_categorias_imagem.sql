USE [yourfm]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id] [int] NOT NULL,
	[designacao] [varchar](100) NOT NULL,
	[popularidade] [real] NOT NULL,
	[imagem] [varchar](256) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[classificacao]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classificacao](
	[id] [int] NOT NULL,
	[designacao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_classificacao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[episodio]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[episodio](
	[id_programa] [int] NOT NULL,
	[n_episodio] [int] NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[data_ini] [datetime] NOT NULL,
	[data_fim] [datetime] NOT NULL,
	[duracao] [float] NOT NULL,
 CONSTRAINT [PK_episodio] PRIMARY KEY CLUSTERED 
(
	[id_programa] ASC,
	[n_episodio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estacao]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estacao](
	[estacaoid] [int] NOT NULL,
	[frequencia] [varchar](8) NULL,
	[regiaoid] [int] NOT NULL,
 CONSTRAINT [PK_estacao] PRIMARY KEY CLUSTERED 
(
	[estacaoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estacao_categoria]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estacao_categoria](
	[estacao] [int] NOT NULL,
	[categoria] [int] NOT NULL,
 CONSTRAINT [PK_estacao_categoria] PRIMARY KEY CLUSTERED 
(
	[estacao] ASC,
	[categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[follow]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[follow](
	[followed] [int] NOT NULL,
	[follower] [int] NOT NULL,
 CONSTRAINT [PK_follow] PRIMARY KEY CLUSTERED 
(
	[followed] ASC,
	[follower] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[listareproducao]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[listareproducao](
	[id] [int] NOT NULL,
	[designacao] [varchar](80) NOT NULL,
	[descricao] [varchar](80) NOT NULL,
	[userid] [int] NOT NULL,
	[foto] [varchar](256) NOT NULL,
 CONSTRAINT [PK_listareproducao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[locutor]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[locutor](
	[userid] [int] NOT NULL,
	[estacao] [int] NOT NULL,
 CONSTRAINT [PK_locutor] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mensagem]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mensagem](
	[id] [int] NOT NULL,
	[mensagem] [varchar](180) NOT NULL,
	[data] [datetime] NOT NULL,
	[estacao] [int] NOT NULL,
	[userid] [int] NOT NULL,
 CONSTRAINT [PK_mensagem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[programa]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programa](
	[id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](280) NOT NULL,
	[classificacao] [int] NOT NULL,
	[estacao] [int] NOT NULL,
	[foto] [varchar](256) NOT NULL,
 CONSTRAINT [PK_programa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[programa_categoria]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programa_categoria](
	[programa] [int] NOT NULL,
	[categoria] [int] NOT NULL,
 CONSTRAINT [PK_programa_categoria] PRIMARY KEY CLUSTERED 
(
	[programa] ASC,
	[categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[programa_listareproducao]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programa_listareproducao](
	[programa] [int] NOT NULL,
	[listareproducao] [int] NOT NULL,
 CONSTRAINT [PK_programa_listareproducao] PRIMARY KEY CLUSTERED 
(
	[programa] ASC,
	[listareproducao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[regiao]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[regiao](
	[id] [int] NOT NULL,
	[designacao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_regiao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 17/06/2021 22:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[userid] [int] NOT NULL,
	[username] [varchar](18) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[email] [varchar](60) NOT NULL,
	[data_nasc] [date] NULL,
	[nome] [varchar](45) NOT NULL,
	[foto] [varchar](256) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[episodio]  WITH CHECK ADD  CONSTRAINT [FK_episodio_programa] FOREIGN KEY([id_programa])
REFERENCES [dbo].[programa] ([id])
GO
ALTER TABLE [dbo].[episodio] CHECK CONSTRAINT [FK_episodio_programa]
GO
ALTER TABLE [dbo].[estacao]  WITH CHECK ADD  CONSTRAINT [FK_estacao_regiao] FOREIGN KEY([regiaoid])
REFERENCES [dbo].[regiao] ([id])
GO
ALTER TABLE [dbo].[estacao] CHECK CONSTRAINT [FK_estacao_regiao]
GO
ALTER TABLE [dbo].[estacao]  WITH CHECK ADD  CONSTRAINT [FK_estacao_user] FOREIGN KEY([estacaoid])
REFERENCES [dbo].[user] ([userid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[estacao] CHECK CONSTRAINT [FK_estacao_user]
GO
ALTER TABLE [dbo].[estacao_categoria]  WITH CHECK ADD  CONSTRAINT [FK_estacao_categoria_categoria] FOREIGN KEY([categoria])
REFERENCES [dbo].[categoria] ([id])
GO
ALTER TABLE [dbo].[estacao_categoria] CHECK CONSTRAINT [FK_estacao_categoria_categoria]
GO
ALTER TABLE [dbo].[estacao_categoria]  WITH CHECK ADD  CONSTRAINT [FK_estacao_categoria_estacao] FOREIGN KEY([estacao])
REFERENCES [dbo].[estacao] ([estacaoid])
GO
ALTER TABLE [dbo].[estacao_categoria] CHECK CONSTRAINT [FK_estacao_categoria_estacao]
GO
ALTER TABLE [dbo].[follow]  WITH CHECK ADD  CONSTRAINT [FK_follow_user] FOREIGN KEY([followed])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[follow] CHECK CONSTRAINT [FK_follow_user]
GO
ALTER TABLE [dbo].[follow]  WITH CHECK ADD  CONSTRAINT [FK_follow_user1] FOREIGN KEY([follower])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[follow] CHECK CONSTRAINT [FK_follow_user1]
GO
ALTER TABLE [dbo].[listareproducao]  WITH CHECK ADD  CONSTRAINT [FK_listareproducao_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[listareproducao] CHECK CONSTRAINT [FK_listareproducao_user]
GO
ALTER TABLE [dbo].[locutor]  WITH CHECK ADD  CONSTRAINT [FK_locutor_estacao] FOREIGN KEY([estacao])
REFERENCES [dbo].[estacao] ([estacaoid])
GO
ALTER TABLE [dbo].[locutor] CHECK CONSTRAINT [FK_locutor_estacao]
GO
ALTER TABLE [dbo].[locutor]  WITH CHECK ADD  CONSTRAINT [FK_locutor_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[locutor] CHECK CONSTRAINT [FK_locutor_user]
GO
ALTER TABLE [dbo].[mensagem]  WITH CHECK ADD  CONSTRAINT [FK_mensagem_estacao] FOREIGN KEY([estacao])
REFERENCES [dbo].[estacao] ([estacaoid])
GO
ALTER TABLE [dbo].[mensagem] CHECK CONSTRAINT [FK_mensagem_estacao]
GO
ALTER TABLE [dbo].[mensagem]  WITH CHECK ADD  CONSTRAINT [FK_mensagem_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[mensagem] CHECK CONSTRAINT [FK_mensagem_user]
GO
ALTER TABLE [dbo].[programa]  WITH CHECK ADD  CONSTRAINT [FK_programa_classificacao] FOREIGN KEY([classificacao])
REFERENCES [dbo].[classificacao] ([id])
GO
ALTER TABLE [dbo].[programa] CHECK CONSTRAINT [FK_programa_classificacao]
GO
ALTER TABLE [dbo].[programa]  WITH CHECK ADD  CONSTRAINT [FK_programa_estacao] FOREIGN KEY([estacao])
REFERENCES [dbo].[estacao] ([estacaoid])
GO
ALTER TABLE [dbo].[programa] CHECK CONSTRAINT [FK_programa_estacao]
GO
ALTER TABLE [dbo].[programa_categoria]  WITH CHECK ADD  CONSTRAINT [FK_programa_categoria_categoria] FOREIGN KEY([categoria])
REFERENCES [dbo].[categoria] ([id])
GO
ALTER TABLE [dbo].[programa_categoria] CHECK CONSTRAINT [FK_programa_categoria_categoria]
GO
ALTER TABLE [dbo].[programa_categoria]  WITH CHECK ADD  CONSTRAINT [FK_programa_categoria_programa] FOREIGN KEY([programa])
REFERENCES [dbo].[programa] ([id])
GO
ALTER TABLE [dbo].[programa_categoria] CHECK CONSTRAINT [FK_programa_categoria_programa]
GO
ALTER TABLE [dbo].[programa_listareproducao]  WITH CHECK ADD  CONSTRAINT [FK_programa_listareproducao_listareproducao] FOREIGN KEY([listareproducao])
REFERENCES [dbo].[listareproducao] ([id])
GO
ALTER TABLE [dbo].[programa_listareproducao] CHECK CONSTRAINT [FK_programa_listareproducao_listareproducao]
GO
ALTER TABLE [dbo].[programa_listareproducao]  WITH CHECK ADD  CONSTRAINT [FK_programa_listareproducao_programa] FOREIGN KEY([programa])
REFERENCES [dbo].[programa] ([id])
GO
ALTER TABLE [dbo].[programa_listareproducao] CHECK CONSTRAINT [FK_programa_listareproducao_programa]
GO
