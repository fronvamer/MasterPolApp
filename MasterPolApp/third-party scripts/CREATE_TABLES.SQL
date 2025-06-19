
CREATE TABLE ProductTypes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Rate FLOAT NOT NULL
);

CREATE TABLE Partners (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Director NVARCHAR(255) NULL,
    Email NVARCHAR(255) NULL,
    Address NVARCHAR(255) NULL,
    INN NVARCHAR(50) NULL,
    Phone NVARCHAR(50) NULL,
    Rating INT NOT NULL

);

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Article NVARCHAR(100) NULL,
    ProductTypeId INT NOT NULL,
    Price FLOAT NOT NULL,
    CONSTRAINT FK_Products_ProductTypes FOREIGN KEY (ProductTypeId) REFERENCES ProductTypes(Id)
);

CREATE TABLE PartnerProducts (
    Id INT PRIMARY KEY IDENTITY(1,1),
    PartnerId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    SaleDate DATE NOT NULL,
    CONSTRAINT FK_PartnerProducts_Partners FOREIGN KEY (PartnerId) REFERENCES Partners(Id),
    CONSTRAINT FK_PartnerProducts_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
);

-- OldQuery

-- Создание таблицы партнеров
CREATE TABLE Partners (
    PartnerId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerType NVARCHAR(50),
    CompanyName NVARCHAR(255),
    LegalAddress NVARCHAR(MAX),
    INN NVARCHAR(12),
    DirectorName NVARCHAR(255),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Logo NVARCHAR(MAX), -- Путь или base64
    Rating INT
);

-- Места продаж партнера
CREATE TABLE SalesLocations (
    SalesLocationId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    LocationName NVARCHAR(255),
    LocationType NVARCHAR(50)
);

-- История реализации продукции
CREATE TABLE SalesHistory (
    SaleId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    ProductName NVARCHAR(255),
    Quantity INT,
    TotalAmount DECIMAL(18, 2),
    SaleDate DATE
);

-- История изменения рейтингов
CREATE TABLE RatingHistory (
    RatingChangeId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    OldRating INT,
    NewRating INT,
    ChangedBy NVARCHAR(255),
    ChangeDate DATETIME DEFAULT GETDATE()
);
