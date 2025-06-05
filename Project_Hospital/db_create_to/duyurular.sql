USE [HastaneProje]
GO

/****** Object:  Table [dbo].[Tbl_Duyurular]    Script Date: 6/5/2025 2:43:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Duyurular](
	[Duyuruid] [smallint] IDENTITY(1,1) NOT NULL,
	[Duyuru] [varchar](200) NULL
) ON [PRIMARY]
GO


