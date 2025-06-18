
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
