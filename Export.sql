-- ========================================
-- Database_library_manager
-- Author: Lukáš Dvoøák
-- ========================================

USE master;
GO

-- =====================
-- CREATE DATABASE
-- =====================
IF DB_ID('dvorak13') IS NULL
BEGIN
    CREATE DATABASE dvorak13;
END
GO

USE dvorak13;
GO

-- =====================
-- DATABASE SETTINGS
-- =====================
ALTER DATABASE dvorak13 SET COMPATIBILITY_LEVEL = 150;
ALTER DATABASE dvorak13 SET AUTO_CLOSE OFF;
ALTER DATABASE dvorak13 SET AUTO_SHRINK OFF;
ALTER DATABASE dvorak13 SET RECOVERY FULL;
ALTER DATABASE dvorak13 SET PAGE_VERIFY CHECKSUM;
GO

-- =====================
-- TABLES
-- =====================

IF OBJECT_ID('BDBgenre','U') IS NULL
CREATE TABLE BDBgenre (
    id INT IDENTITY(1,1) PRIMARY KEY,
    genre VARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID('BDBauthor','U') IS NULL
CREATE TABLE BDBauthor (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID('BDBuser','U') IS NULL
CREATE TABLE BDBuser (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE
);
GO

IF OBJECT_ID('BDBbooks','U') IS NULL
CREATE TABLE BDBbooks (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL CHECK (price >= 0),
    available BIT NOT NULL DEFAULT 1,
    state VARCHAR(50) NOT NULL,
    genre_id INT NOT NULL,
    author_id INT NOT NULL,
    CONSTRAINT CK_BDBbooks_state 
        CHECK (state IN ('Used','Torn','Damaged','New'))
);
GO

IF OBJECT_ID('BDBloan','U') IS NULL
CREATE TABLE BDBloan (
    id INT IDENTITY(1,1) PRIMARY KEY,
    pickUpDate DATE NOT NULL,
    returnDate DATE NULL,
    us_id INT NOT NULL,
    book_id INT NOT NULL,
    CONSTRAINT CK_BDBloan_dates 
        CHECK (returnDate IS NULL OR returnDate >= pickUpDate)
);
GO

-- =====================
-- FOREIGN KEYS
-- =====================

ALTER TABLE BDBbooks
ADD CONSTRAINT FK_BDBbooks_author
FOREIGN KEY (author_id) REFERENCES BDBauthor(id);
GO

ALTER TABLE BDBbooks
ADD CONSTRAINT FK_BDBbooks_genre
FOREIGN KEY (genre_id) REFERENCES BDBgenre(id);
GO

ALTER TABLE BDBloan
ADD CONSTRAINT FK_BDBloan_book
FOREIGN KEY (book_id) REFERENCES BDBbooks(id);
GO

ALTER TABLE BDBloan
ADD CONSTRAINT FK_BDBloan_user
FOREIGN KEY (us_id) REFERENCES BDBuser(id);
GO

-- =====================
-- VIEWS
-- =====================

CREATE OR ALTER VIEW bookLoanView AS
SELECT
    b.title AS BookTitle,
    g.genre AS Genre,
    COUNT(l.id) AS LoanCount,
    MIN(l.pickUpDate) AS FirstLoan,
    MAX(l.returnDate) AS LastReturn
FROM BDBbooks b
JOIN BDBgenre g ON b.genre_id = g.id
LEFT JOIN BDBloan l ON l.book_id = b.id
GROUP BY b.title, g.genre;
GO

CREATE OR ALTER VIEW authorLoanView AS
SELECT
    a.firstName + ' ' + a.lastName AS AuthorName,
    COUNT(l.id) AS LoanCount,
    MIN(l.pickUpDate) AS FirstLoan,
    MAX(l.pickUpDate) AS LastLoan
FROM BDBauthor a
JOIN BDBbooks b ON b.author_id = a.id
JOIN BDBloan l ON l.book_id = b.id
GROUP BY a.firstName, a.lastName;
GO