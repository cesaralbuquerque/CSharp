USE [CursoCSharp]
GO

/****** Object:  Table [dbo].[Fornecedores]    Script Date: 30/10/2014 23:22:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].Fornecedores(
	[Codigo] [int]  IDENTITY(1,1) NOT NULL,
	[CFP_CNPJ] [nvarchar](15) NULL,
	[Nome] [nvarchar](50) NULL,
	[TipoPessoa] int null,
	[SobreNome] [nvarchar](50) NULL,
	[Endereco] [nvarchar](50) NULL,
	[Bairro] [nvarchar](30) NULL,
	[Cidade] [nvarchar](50) NULL,
	[UF] [nvarchar](2) NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [CursoCSharp]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 30/10/2014 23:28:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Codigo] [int]  IDENTITY(1,1) NOT NULL,
	[CPF] [nvarchar] (15) NULL,
	[Nome] [nvarchar](50) NULL,
	[SobreNome] [nvarchar](50) NULL,
	[Endereco] [nvarchar](50) NULL,
	[Bairro] [nvarchar](30) NULL,
	[Cidade] [nvarchar](50) NULL,
	[UF] [nvarchar](2) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Codigo]  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


