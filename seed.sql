USE PamirPlastikDb;

-- 1. TEMIZLIK
DELETE FROM ProductColors;
DELETE FROM ProductImages;
DELETE FROM Products;
DELETE FROM Colors;

-- 2. IDENTITY SIFIRLAMA
DBCC CHECKIDENT ('Products', RESEED, 0);
DBCC CHECKIDENT ('Colors', RESEED, 0);
DBCC CHECKIDENT ('ProductImages', RESEED, 0);
DBCC CHECKIDENT ('ProductColors', RESEED, 0);

-- 3. RENKLER
INSERT INTO Colors (Name_TR, Name_EN, HexCode) VALUES
('Kırmızı', 'Red', '#ef4444'),
('Mavi', 'Blue', '#3b82f6'),
('Antrasit', 'Anthracite', '#334155'),
('Beyaz', 'White', '#ffffff'),
('Siyah', 'Black', '#0f172a'),
('Şeffaf', 'Transparent', '#f8fafc');

-- 4. URUN GORSELLERI (Masaustunden alinanlar)
DECLARE @Images TABLE (Id INT IDENTITY(1,1), FileName NVARCHAR(255), CategoryId INT, ProductName NVARCHAR(255));
INSERT INTO @Images (FileName, CategoryId, ProductName) VALUES
('ASTERİA 12 MANDAL İMAJ.jpg', 12, 'Asteria Mandal Seti 12''li'),
('BAYKUŞ-TEPSİ-2.jpg', 9, 'Baykuş Desenli Tepsi'),
('BELLA KEPÇE SETİ (3).jpg', 6, 'Bella Kepçe Seti 3''lü'),
('DANTE WC İMAJ.jpg', 5, 'Dante WC Fırçası'),
('ELİS ORGANİZER (1).jpg', 2, 'Elis Makyaj Organizeri'),
('FELXY KESİM MATI.jpg', 7, 'Flexy Kesim Matı'),
('GALAXY ASKI İMAJ.jpg', 11, 'Galaxy Elbise Askısı'),
('kırmızı altıgen kulluk.jpg', 10, 'Altıgen Küllük Kırmızı'),
('mavi kare kulluk.jpg', 10, 'Kare Küllük Mavi'),
('MELEK ASKI İMAJ.jpg', 11, 'Melek Elbise Askısı'),
('SMART KAŞIKLIK İMAJ.jpg', 8, 'Smart Kaşıklık');

-- 5. DONGU ILE 30 URUN
DECLARE @i INT = 1;
WHILE @i <= 30
BEGIN
    DECLARE @RandomImgId INT = (ABS(CHECKSUM(NEWID())) % 11) + 1;
    
    DECLARE @FileName NVARCHAR(255);
    DECLARE @CatId INT;
    DECLARE @BaseName NVARCHAR(255);
    
    SELECT @FileName = FileName, @CatId = CategoryId, @BaseName = ProductName 
    FROM @Images WHERE Id = @RandomImgId;
    
    DECLARE @ProductName NVARCHAR(255) = @BaseName + ' - PRM' + CAST(@i AS NVARCHAR);
    DECLARE @ProductCode NVARCHAR(50) = 'PMR-' + RIGHT('000' + CAST(@i AS NVARCHAR), 4);
    
    DECLARE @BoxCount INT = (ABS(CHECKSUM(NEWID())) % 5 + 1) * 12;
    
    -- Gida guvenligi, bulasik makinesi gibi alanlari randomize
    DECLARE @IsFoodSafe BIT = CASE WHEN @CatId IN (6,8,9) THEN 1 ELSE 0 END;
    DECLARE @IsDishwasherSafe BIT = CASE WHEN @CatId IN (6,8,9) THEN 1 ELSE 0 END;
    
    INSERT INTO Products (
        Name_TR, Name_EN, 
        ShortDescription_TR, ShortDescription_EN, 
        FullDescription_TR, FullDescription_EN,
        ProductCode, BoxCount, Capacity, Material, BoxSize, BoxWeight,
        IsDishwasherSafe, IsFoodSafe, MainImageUrl, IsFeatured, Status, CategoryID, [Order]
    )
    VALUES (
        @ProductName, @ProductName + ' (EN)',
        'Pamir Plastik yüksek kalite ve ergonomik tasarım. Uzun ömürlü kullanım sunar.', 'Premium quality and ergonomic design.',
        'Pamir Plastik kalitesiyle üretilmiş bu ürün, %100 yerli üretimdir. Ergonomik tasarımı sayesinde kullanımı kolaydır ve uzun ömürlüdür. BPA içermez, sağlığa zararlı maddeler barındırmaz.', 
        'Produced with Pamir Plastik quality, 100% domestic production. Ergonomic design makes it easy to use.',
        @ProductCode, @BoxCount, 'Standart', 'PP (Polipropilen)', '40x60x40 cm', CAST((ABS(CHECKSUM(NEWID())) % 10 + 5) AS NVARCHAR) + ' kg',
        @IsDishwasherSafe, @IsFoodSafe, '/images/products/' + @FileName, 
        CASE WHEN @i % 5 = 0 THEN 1 ELSE 0 END, -- Her 5 urunden 1'i vitrin (IsFeatured = true)
        1, @CatId, @i
    );
    
    DECLARE @NewProdId INT = SCOPE_IDENTITY();
    
    -- Urun Renkleri Atamasi (Rastgele 1-3 renk)
    INSERT INTO ProductColors (ProductID, ColorID)
    SELECT @NewProdId, ColorID FROM Colors WHERE ColorID IN (
        (ABS(CHECKSUM(NEWID())) % 6) + 1,
        (ABS(CHECKSUM(NEWID())) % 6) + 1,
        (ABS(CHECKSUM(NEWID())) % 6) + 1
    ) GROUP BY ColorID;
    
    -- Galeri Resimleri
    INSERT INTO ProductImages (ProductID, ImageUrl)
    VALUES (@NewProdId, '/images/products/' + @FileName), 
           (@NewProdId, '/images/products/' + @FileName);
           
    SET @i = @i + 1;
END

PRINT 'Mevcut test verileri silindi, yeni 30 gercekci urun basariyla eklendi!';
