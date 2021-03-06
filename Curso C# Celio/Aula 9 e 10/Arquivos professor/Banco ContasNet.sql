USE [master]
GO
/****** Object:  Database [ContasNet]    Script Date: 06/12/2014 09:09:20 ******/
/*CREATE DATABASE [ContasNet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ContasNet', FILENAME = N'C:\wamp\www\CSharp\Curso C# Celio\Aula 9 e 10\Arquivos professor\ContasNet.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ContasNet_log', FILENAME = N'C:\wamp\www\CSharp\Curso C# Celio\Aula 9 e 10\Arquivos professor\DATA\ContasNet_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
*/

GO
ALTER DATABASE [ContasNet] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContasNet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ContasNet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ContasNet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ContasNet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ContasNet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ContasNet] SET ARITHABORT OFF 
GO
ALTER DATABASE [ContasNet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ContasNet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ContasNet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ContasNet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ContasNet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ContasNet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ContasNet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ContasNet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ContasNet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ContasNet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ContasNet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ContasNet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ContasNet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ContasNet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ContasNet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ContasNet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ContasNet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ContasNet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ContasNet] SET  MULTI_USER 
GO
ALTER DATABASE [ContasNet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ContasNet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ContasNet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ContasNet] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ContasNet] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ContasNet]
GO
/****** Object:  Table [dbo].[bairro]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bairro](
	[bai_id] [int] IDENTITY(1,1) NOT NULL,
	[bai_nome] [varchar](255) NOT NULL,
 CONSTRAINT [PK_bairro] PRIMARY KEY CLUSTERED 
(
	[bai_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_nome] [varchar](255) NOT NULL,
	[cat_categoriamae] [int] NULL,
	[usu_id] [int] NOT NULL,
	[cat_meta] [money] NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cep]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cep](
	[cep_id] [int] NOT NULL,
	[cid_id] [int] NULL,
	[lgd_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cidade]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cidade](
	[cid_id] [int] NOT NULL,
	[cid_nome] [varchar](255) NOT NULL,
	[ufe_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[conta]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[conta](
	[con_id] [int] NOT NULL,
	[con_nome] [varchar](255) NOT NULL,
	[pco_id] [int] NOT NULL,
	[usu_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[email]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[email](
	[ema_id] [int] NOT NULL,
	[ema_email] [varchar](255) NOT NULL,
	[pes_id] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[endereco]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[endereco](
	[end_id] [int] NOT NULL,
	[end_logradouro] [varchar](255) NULL,
	[end_numero] [varchar](20) NULL,
	[end_complemento] [varchar](50) NULL,
	[end_caixapostal] [varchar](20) NULL,
	[end_bairro] [varchar](255) NULL,
	[end_cep] [int] NULL,
	[end_cidade] [varchar](255) NULL,
	[end_unidadefederal] [varchar](2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formapagamento]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[formapagamento](
	[fpa_id] [int] NOT NULL,
	[fpa_nome] [varchar](255) NOT NULL,
	[usu_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formapagamento_perfilconta]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formapagamento_perfilconta](
	[fpa_id] [int] NOT NULL,
	[pco_id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lancamento]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lancamento](
	[lan_id] [int] NOT NULL,
	[lan_valor] [money] NOT NULL,
	[lan_datavencimento] [datetime] NOT NULL,
	[lan_datarealizado] [datetime] NULL,
	[lan_tipolancamento] [char](1) NOT NULL,
	[lan_autopagamento] [bit] NOT NULL,
	[fpa_id] [int] NOT NULL,
	[sta_id] [int] NOT NULL,
	[con_id] [int] NOT NULL,
	[cat_id] [int] NOT NULL,
	[pes_id] [int] NOT NULL,
	[lan_descricao] [varchar](255) NOT NULL,
	[pre_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lancamentoprevisto]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lancamentoprevisto](
	[pre_id] [int] NOT NULL,
	[pre_descricao] [varchar](255) NOT NULL,
	[pre_dataInicio] [datetime] NOT NULL,
	[pre_datafim] [datetime] NULL,
	[pre_valor] [money] NOT NULL,
	[pre_diasintervalo] [int] NULL,
	[per_id] [int] NOT NULL,
	[con_id] [int] NOT NULL,
	[pes_id] [int] NOT NULL,
	[cat_id] [int] NOT NULL,
	[fpa_id] [int] NOT NULL,
	[pre_autopagamento] [bit] NOT NULL,
	[pre_tipolancamento] [char](1) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[logradouro]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logradouro](
	[lgd_id] [int] NOT NULL,
	[lgd_logradouro] [varchar](255) NOT NULL,
	[bai_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[perfilconta]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[perfilconta](
	[pco_id] [int] NOT NULL,
	[pco_nome] [varchar](255) NOT NULL,
	[usu_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[periodicidade]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[periodicidade](
	[per_id] [int] NOT NULL,
	[per_nome] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pessoalancamento]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pessoalancamento](
	[pes_id] [int] NOT NULL,
	[pes_nome] [varchar](255) NOT NULL,
	[tpe_id] [int] NOT NULL,
	[end_id] [int] NOT NULL,
	[usu_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[statuslancamento]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[statuslancamento](
	[sta_id] [int] NOT NULL,
	[sta_nome] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[statususuario]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[statususuario](
	[stu_id] [int] NOT NULL,
	[stu_nome] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[telefone]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[telefone](
	[tel_id] [int] NOT NULL,
	[tel_numero] [varchar](20) NOT NULL,
	[tte_id] [int] NOT NULL,
	[pes_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipopessoalancamento]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipopessoalancamento](
	[tpe_id] [int] NOT NULL,
	[tpe_nome] [varchar](255) NOT NULL,
	[usu_id] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipotelefone]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipotelefone](
	[tte_id] [int] NOT NULL,
	[tte_nome] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidadefederal]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidadefederal](
	[ufe_id] [int] NOT NULL,
	[ufe_nome] [varchar](255) NOT NULL,
	[ufe_sigla] [varchar](2) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 06/12/2014 09:09:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[usu_id] [int] NOT NULL,
	[usu_nome] [varchar](255) NOT NULL,
	[usu_login] [varchar](255) NOT NULL,
	[usu_senha] [varchar](50) NOT NULL,
	[usu_datacadastro] [datetime] NOT NULL,
	[usu_dataconfirmacao] [datetime] NULL,
	[usu_receberesumodiario] [bit] NOT NULL,
	[usu_exiberesumotela] [bit] NOT NULL,
	[stu_id] [int] NOT NULL,
	[end_id] [int] NOT NULL,
	[usu_ultimoacesso] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[lancamento] ADD  DEFAULT ((1)) FOR [lan_autopagamento]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [usu_receberesumodiario]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [usu_exiberesumotela]
GO
USE [master]
GO
ALTER DATABASE [ContasNet] SET  READ_WRITE 
GO
