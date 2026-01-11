# Library Database

Windows Forms application for library database manipulation.

---

## Features

- Adding, deleting, updating data into 5 different tables.
- Importing data from CSV file into 2 different tables.
- Two reports for authors and books.

---

## Getting Started

### Dependencies

- .NET SDK (ideally latest)
- SQL Database (ideally MSSQL)

### NuGet packages

- System.Data.SqlClient

---

## Installing

1. Download the zip file from GitHub here:  
   https://github.com/Dvormen/Database_library_manager.git

2. Extract the zip file and open `BDbooks-exe` folder.

3. Open JSON file `appsettings.json` and enter:
   - **Server** – Your server  
   - **Database** – Enter the name of your database  
   - **User Id** – Your username  
   - **Password** – Your password  

4. Open SQL Server Management Studio and connect to your database.

5. Open the `Export.sql` from the zip file and execute it in the Studio.

6. Run the exe file in `BDbooks-exe` folder.

---

## After running the program

First thing you will see is the menu with links to access tables and reports.

---

## Tables

### 1. Books table

Table with all the books in the database.  
You can add, update and delete them.  
When updating, only filled values will get changed.

---

### 2. Authors table

Table with all the authors in the database.  
You can add, update and delete them.  
When updating, only filled values will get changed.

This table can also import data from the CSV file in this format:

```csv
firstName,lastName
ExampleFirstName,ExampleLastName
```

---

### 3. Genre table

Table with all the genres in the database.  
You can add, update and delete them.

This table can also import data from the CSV file in this format:

```csv
genre
ExampleGenre
```

---

### 4. User table

Table with all of the users in the database.  
You can add, update and delete members.  
When updating, only filled values will get changed.

---

### 5. Loans table

Table with all the loans in the database.  
You can pick up books and return books.  
You pick up books by inserting id of the user and id of the book.

---

## Reports

Reports are views from the database that show some statistics for authors and books.

---

### 1. Author report

This report show statistics of author like number of loaned books, first loan and last loan.

---

### 2. Book report

This report show statistics of books like number of loans, first loan and last return.

---

## Help

If you do not use MSSQL server, this app probably will not work.

If you need further help with this application, feel free to contact me at:

**dvorak13@spsejecna.cz**
