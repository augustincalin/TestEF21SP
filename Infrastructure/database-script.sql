USE [TestEF]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 03.06.2018 19:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 03.06.2018 19:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 03.06.2018 19:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NULL,
	[GroupId] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentClass]    Script Date: 03.06.2018 19:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentClass](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
 CONSTRAINT [PK_StudentClass] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 
GO
INSERT [dbo].[Class] ([Id], [Name]) VALUES (1, N'Class 1')
GO
INSERT [dbo].[Class] ([Id], [Name]) VALUES (2, N'Class 2')
GO
INSERT [dbo].[Class] ([Id], [Name]) VALUES (3, N'Class 3')
GO
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 
GO
INSERT [dbo].[Group] ([Id], [Name]) VALUES (1, N'Group RO')
GO
INSERT [dbo].[Group] ([Id], [Name]) VALUES (2, N'Group EN')
GO
INSERT [dbo].[Group] ([Id], [Name]) VALUES (3, N'Group DE')
GO
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (2, N'Popescu', NULL, 1, NULL)
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (3, N'John', CAST(N'2011-01-01T00:00:00.000' AS DateTime), 2, N'123')
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (4, N'Ionescu', CAST(N'1972-10-10T00:00:00.000' AS DateTime), 1, N'444-5555')
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (5, N'Fritz', NULL, 3, N'999-696969')
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (6, N'Mike', CAST(N'1981-07-07T00:00:00.000' AS DateTime), 2, N'001-002-33')
GO
INSERT [dbo].[Student] ([Id], [Name], [BirthDate], [GroupId], [PhoneNumber]) VALUES (7, N'Mark', NULL, 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentClass] ON 
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (3, 2, 1)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (4, 2, 3)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (5, 3, 1)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (6, 3, 2)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (7, 3, 3)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (8, 4, 1)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (9, 5, 2)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (10, 5, 3)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (11, 6, 3)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (12, 7, 1)
GO
INSERT [dbo].[StudentClass] ([Id], [StudentId], [ClassId]) VALUES (13, 7, 2)
GO
SET IDENTITY_INSERT [dbo].[StudentClass] OFF
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD  CONSTRAINT [FK_StudentClass_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([Id])
GO
ALTER TABLE [dbo].[StudentClass] CHECK CONSTRAINT [FK_StudentClass_Class]
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD  CONSTRAINT [FK_StudentClass_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[StudentClass] CHECK CONSTRAINT [FK_StudentClass_Student]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsFromClass]    Script Date: 03.06.2018 19:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetStudentsFromClass]
	@ClassId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select s.Name as StudentName, G.Name as GroupName, C.Name as ClassName from Student s inner join [Group] G on S.GroupId=G.Id inner join StudentClass SC on S.Id = SC.StudentId inner join Class C on SC.ClassId = C.Id where C.Id = @ClassId
END
GO
