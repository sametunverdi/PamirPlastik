USE PamirPlastikDb;
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DeveloperSettings' and xtype='U')
BEGIN
    CREATE TABLE DeveloperSettings (
        DeveloperSettingID INT IDENTITY(1,1) PRIMARY KEY,
        SignatureText NVARCHAR(MAX),
        DeveloperName NVARCHAR(MAX),
        DeveloperUrl NVARCHAR(MAX)
    );
    INSERT INTO DeveloperSettings (SignatureText, DeveloperName, DeveloperUrl)
    VALUES ('Bu web projesi gururla', 'AKU CODE', 'https://sametaku.com');
END
