
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

ALTER TABLE ProductTypes
ADD WastePercentage FLOAT NOT NULL DEFAULT 0;


  UPDATE ProductTypes SET WastePercentage = 2.5 WHERE Id = 1;
UPDATE ProductTypes SET WastePercentage = 3.0 WHERE Id = 2;
UPDATE ProductTypes SET WastePercentage = 4.0 WHERE Id = 3;
UPDATE ProductTypes SET WastePercentage = 5.5 WHERE Id = 4;

INSERT INTO MaterialTypes (Id, Name, WastePercentage) VALUES (1, 'Материал A', 2.5);
INSERT INTO MaterialTypes (Id, Name, WastePercentage) VALUES (2, 'Материал B', 3.0);
INSERT INTO MaterialTypes (Id, Name, WastePercentage) VALUES (3, 'Материал C', 4.0);
INSERT INTO MaterialTypes (Id, Name, WastePercentage) VALUES (4, 'Материал D', 5.5);



CREATE TABLE Partners (
    PartnerId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerType NVARCHAR(50),
    CompanyName NVARCHAR(255),
    LegalAddress NVARCHAR(MAX),
    INN NVARCHAR(12),
    DirectorName NVARCHAR(255),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Logo NVARCHAR(MAX), 
    Rating INT
);


CREATE TABLE SalesLocations (
    SalesLocationId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    LocationName NVARCHAR(255),
    LocationType NVARCHAR(50)
);


CREATE TABLE SalesHistory (
    SaleId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    ProductName NVARCHAR(255),
    Quantity INT,
    TotalAmount DECIMAL(18, 2),
    SaleDate DATE
);


CREATE TABLE RatingHistory (
    RatingChangeId INT IDENTITY(1,1) PRIMARY KEY,
    PartnerId INT FOREIGN KEY REFERENCES Partners(PartnerId) ON DELETE CASCADE,
    OldRating INT,
    NewRating INT,
    ChangedBy NVARCHAR(255),
    ChangeDate DATETIME DEFAULT GETDATE()
);
