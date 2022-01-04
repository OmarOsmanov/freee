USE [freeDB]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Fulname], [Email], [Phone], [Password], [CreatedDate]) VALUES (1, N'OmarOsmanov', N'Omar494@gmail.com', N'0555044555', N'123456', CAST(N'2021-10-15T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[PortFolios] ON 

INSERT [dbo].[PortFolios] ([PortfolioId], [PortTittle], [PortContent], [PortImage], [UserId]) VALUES (4, N'dykdyrdydytdytytd', N'uctclutultfufi77tg;gtt7itgig7g;7g7gu7g;', N'25de571b-cc23-4aae-852a-4656dbd8e96a-circus.png', 1)
INSERT [dbo].[PortFolios] ([PortfolioId], [PortTittle], [PortContent], [PortImage], [UserId]) VALUES (5, N'iuhieruhiuerhgiuerg', N'kjerngkerngkerngvkenkvnekvnkefnv i hervierhvie viuh vehvteogghroghrt', N'cabin.png', 1)
SET IDENTITY_INSERT [dbo].[PortFolios] OFF
GO
