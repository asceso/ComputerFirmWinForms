﻿CREATE TABLE [dbo].[Permissions] (
    [ID] [uniqueidentifier] NOT NULL DEFAULT newsequentialid(),
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Permissions] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[PositionPermissions] (
    [ID] [uniqueidentifier] NOT NULL DEFAULT newsequentialid(),
    [Permission_ID] [uniqueidentifier],
    [Position_ID] [uniqueidentifier],
    CONSTRAINT [PK_dbo.PositionPermissions] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_Permission_ID] ON [dbo].[PositionPermissions]([Permission_ID])
CREATE INDEX [IX_Position_ID] ON [dbo].[PositionPermissions]([Position_ID])
CREATE TABLE [dbo].[Positions] (
    [ID] [uniqueidentifier] NOT NULL DEFAULT newsequentialid(),
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Positions] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[UserInfos] (
    [ID] [uniqueidentifier] NOT NULL DEFAULT newsequentialid(),
    [FirstName] [nvarchar](max),
    [SecondName] [nvarchar](max),
    [LastName] [nvarchar](max),
    [ContactNumber] [nvarchar](max),
    CONSTRAINT [PK_dbo.UserInfos] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Users] (
    [ID] [uniqueidentifier] NOT NULL DEFAULT newsequentialid(),
    [Login] [nvarchar](max) NOT NULL,
    [Password] [nvarchar](max) NOT NULL,
    [UserInfoID] [uniqueidentifier],
    [PositionID] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_UserInfoID] ON [dbo].[Users]([UserInfoID])
CREATE INDEX [IX_PositionID] ON [dbo].[Users]([PositionID])
ALTER TABLE [dbo].[PositionPermissions] ADD CONSTRAINT [FK_dbo.PositionPermissions_dbo.Permissions_Permission_ID] FOREIGN KEY ([Permission_ID]) REFERENCES [dbo].[Permissions] ([ID])
ALTER TABLE [dbo].[PositionPermissions] ADD CONSTRAINT [FK_dbo.PositionPermissions_dbo.Positions_Position_ID] FOREIGN KEY ([Position_ID]) REFERENCES [dbo].[Positions] ([ID])
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [FK_dbo.Users_dbo.Positions_PositionID] FOREIGN KEY ([PositionID]) REFERENCES [dbo].[Positions] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [FK_dbo.Users_dbo.UserInfos_UserInfoID] FOREIGN KEY ([UserInfoID]) REFERENCES [dbo].[UserInfos] ([ID])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202011290024077_InitialCreate', N'EFCore.Migrations.Configuration',  0x1F8B0800000000000400ED5CDB6EDC36107D2FD07F10F4D416CECA765F5A633781BBB603A3F1055E27E85B404BF49AA8446D44CA5DA3E897F5A19FD45F28A92BC58B44692FDEB8468020A6C899E1CC90339C39CEBF7FFF337EB78C42E7112604C578E21E8CF65D07623F0E109E4FDC94DEBFF9C97DF7F6DB6FC6A741B4743E95F37EE4F3D84A4C26EE03A58B23CF23FE038C001945C84F6212DFD3911F471E0862EF707FFF67EFE0C0838C84CB6839CEF826C5144530FB81FD388DB10F173405E1451CC09014E3ECCB2CA3EA5C82089205F0E1C43D3D9BC609749DE31001C67D06C37BD70118C7145026DBD14702673489F17CB6600320BC7D5A4036EF1E840416321FD5D36DC5DF3FE4E27BF5C292949F121A473D091EFC58E8C393970FD2AA5BE98B69EC9469963EF15D675A9BB8D730891021197199DDD1344CF8D452ADA36C35826454AFDA73F26F7B95F99997F03F7BCE340D699AC00986294D40B8E75CA77721F27F854FB7F1EF104F701A86A2704C3CF6AD31C086AE93780113FA7403EF0B91CF4F5CC76BAEF3E485D532614DBE95F7290A5CE792F1067721AC4C2FEC7A46D97EDE430C134061700D288509B3DC790033E529CC2556FCEF9219F33576545CE7022C3F403CA70F1397FDD375CED01206E54821C1478CD8C9628B6892C22E262790F8095AE44EB1565E63AFF69176CF8909E2FC077A90B2FAD593C697E011CDB3A5125351C73730CCA69007B4C86F388D323F8B2BCE9238BA8943ADCD84899F67719AF8DC77639BD9B7209943DA630F0535EB1D54F3DBE52F86ACA42FE7EA64EFEDF843DCFDD5C9FFAFD725CB3C92737C1FF7F19A72CDABD7C8ACCE5042E8565C6706FD18075B61F5016C694F2CA3A6C0A79769740793E73C107D0FC3EB41507C269EA375DC698A88ED6CAF01217FC449B07DCEE59D28EBB843DE22FE765A662DD90C97519BBF343E28194BF36BDFFCAA0E302689EA199244E507BD44D5D73E59D33121B18F32318CEF0531496D6EF214074EAF8C3577427D26C9BC92DD0D68C16E0326E8C4FD41D1A92DBB5201223B239BFDD1E840D695A095FECA2AFDA98FEC8AAB6D5251B2E76A98AD5549CD636692D470E66AD9F24064BF75FD31B5D8EC812B879B2B7C024348A173ECE7E5A129203E08D47B889DB2A039C222144C788C00210BE784C53C84A91ACE10F6D102846DA24B8B2CA32017AA222F7F39810B8879046BB3810D5FF1DE56F9576C246575E9A6AF8F551767AB4BA8B7E88A3EA65CBC12C1FC2EEF3A502BF98A2CC2B67C45D6A50D5F3133D882AFE4712F4BA511CBDE0A214ECF4E00057C142EA926BD654216192E291220D90538D519A44AE587B84E1D6A35D147F125899072616B096A828225E136729D444ADBE988D4AE6E41C44440592C58B54D498D429AB0C6AAF2263B61DFB4A6DAA0C17C8A97F74D64440666C28D23C0260F5464E50B766AD4C6F5DE09CF9A5528477D0DF975A84F7A40A80A6B497D2C921F41EAE2CCB4A8419FEE6C72E3F581376C5C1F8F2D2272FF8D2B315822515C5AD61B2FDF4B55DCA8BB995EDECE2CDB9E9EA1EF39BE008B057B6C0B7DD062C499E54DD0E99B59FF4E6194D3F07CA2691856D2569C689C803994BEF2CA5200B3DA1C8F827780BFA8A741A44C6B4649C3AD5EF25203A16AB3F2C62FD7F07F9701392B23996FE55A7F676C4B114F44B29A8CF66E5417676D6810824453039AC6611A617356645E9D9701C5F5F9883D8546C95B24D4F8A0D21B7B9236944C4AD1B6F254691AD0CEBC9ACB798899D5FC6580B92D88AC66F66756F24AAA5D41A1AFA7674386AD23D100C39AA2A98561CD4B376358A1ED23121186ED69898D1D9198386E4FADEEDD88B4EA517B4A52734624277DDA29F71BEC7A03DD6E5B2E5734581A56CD87EC69D4DD12914C3D6A4F49AC7188B4DA6A1F2D7209D5B586642D55B7CD3B593377EE4A131A0F748B7CA031BF7FE4E7EF0383165B9FDAAA16AD7C5520A42F6B09E2AC2AA9B1D436F854B58AC72EB32093C63927BC0D57B5E0ACF72F3FB3D6E24DD5A3DBCA97AAD91BF3A4CE62BD9D1F956436E4459DA5FDE7F421F3DEBB3D4879AFCB53AADBB07AB74BEFF371F156EE062F2B8FE77C8AEBB0ED3FA2803F9C674F84C268C4278C665FC26988D8FD5B4FB80018DD434273C8837BB87F702861A1770797EC1112849A5A831E9CDC34DB16901B29465F52883218C63DE2E9562752A327924184FAE04790F80F20F92E02CBEF454A03D16D3DE8AD02F87D815691228E89ADD2D839C7015C4EDC3F333247CEF96F9F1B94F69CAB841DD02367DFF9ABAF7D1B17D82A02D574ECC5E90F8B7D814EF1B51D5543C3FA45D842817EAE641015DEB9123919C2B912312D4C7353EEF2125DA5018E342A6E10E071356A2A8871D0855E93594778595374310BA351CDC6E183527160006ACF69EF09AF8CA91B04CE69ED6FAC1D9263D555D180B7BA8A175BC06FAD02A41C8860DC4D8731776F76C65DDA6B14DB02FBADD73DD68AF96C621306000C77DE750C0D81AF1A189A43598662379FC7E62D3DC1E7B3F94E003C55848B6C2F1380B303BF9917FB266E70C7BD25CF98DA4079DD004F4B7CA796713756CE28402B0EB48D59378BFAE4B4A044752CCC502D1D0B2386D4445A25FBCCF052C507641C533FE063078EF26B038C6AB7B3732A591B0874F8B6C5C35077DE770CE6295E084D54CA26B7D603C8A93680585412FE8F1B1611099AD724785B0B43BF118FAA397C63656894242AA748EFFB0B4841C082D571C25EF3C0A7ECB30F9993F2DFD7FC04C2944D398DEE60708EAF52BA4829DB328CEEC2C6AF9EF2F0DAC63F43AB36651E5F65654EB28E2D303111DB02BCC2BFA4280C2AB9CF34150503091EB78BD212B725E525A6F95345E932C696840AF555E9C62D8C16212346AEF00C3CC221B231D7FB00E7C07F2AFB786622DD8668AA7D7C82C03C01112968D4EBD98FCC878368F9F63F5B2452B2EA490000 , N'6.2.0-61023')
