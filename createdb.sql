USE [PamirPlastikDb];
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DeveloperSettings' and xtype='U')
BEGIN
    CREATE TABLE [DeveloperSettings] (
        [DeveloperSettingID] int NOT NULL IDENTITY,
        [SignatureText] nvarchar(max) NULL,
        [DeveloperName] nvarchar(max) NULL,
        [DeveloperUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_DeveloperSettings] PRIMARY KEY ([DeveloperSettingID])
    );
    INSERT INTO [DeveloperSettings] ([SignatureText], [DeveloperName], [DeveloperUrl])
    VALUES ('Bu web projesi gururla', 'AKU CODE', 'https://sametaku.com');
END
