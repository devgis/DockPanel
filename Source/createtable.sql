USE [gwd]
GO

/****** Object:  Table [dbo].[t_authority]    Script Date: 05/12/2013 22:17:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[t_authority](
	[authorityid] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[authoritytype] [int] NULL,
	[typetag] [varchar](50) NULL,
	[functag] [varchar](50) NULL,
	[remarks] [varchar](500) NULL,
 CONSTRAINT [PK_t_authority] PRIMARY KEY CLUSTERED 
(
	[authorityid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 类型权限 1单权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_authority', @level2type=N'COLUMN',@level2name=N'typetag'
GO

