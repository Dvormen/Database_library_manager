create table BDBauthor(
id int primary key identity(1,1),
firstName varchar(50) not null,
lastName varchar(50) not null
)

create table BDBgenre(
id int primary key identity(1,1),
genre varchar(50) not null
)

create table BDBuser(
id int primary key identity(1,1),
username varchar(50) not null,
email varchar(50) not null
)

create table BDBbooks(
id int primary key identity(1,1),
title varchar(50) not null,
price decimal(10,2) not null,
available bit not null,
state varchar(50) not null           
check (state IN ('New', 'Damaged', 'Torn', 'Used')),
genre_id int foreign key references BDBgenre(id),
author_id int foreign key references BDBauthor(id)
)

create table BDBloan(
id int primary key identity(1,1),
pickUpDate date not null,
returnDate date,
us_id int foreign key references BDBuser(id),
book_id int foreign key references BDBbooks(id)
)

go
create view authorLoanView as
select BDBauthor.firstName + ' ' + BDBauthor.lastName as AuthorName, count(BDBloan.id) as LoanCount, min(BDBloan.PickUpDate) as FirstLoan, max(BDBloan.PickUpDate) as LastLoan from BDBauthor
join BDBbooks ON BDBbooks.author_id = BDBauthor.id
join BDBloan ON BDBloan.book_id = BDBbooks.id
group by BDBauthor.firstName, BDBauthor.lastName;
go

go
create view bookLoanView as
select BDBbooks.title as BookTitle, BDBgenre.genre as Genre, count(BDBloan.id) as LoanCount, min(BDBloan.pickUpDate) as FirstLoan, max(BDBloan.returnDate) as LastReturn from BDBbooks
join BDBgenre on BDBbooks.genre_id = BDBgenre.id
left join BDBloan on BDBloan.book_id = BDBbooks.id
group by BDBbooks.title, BDBgenre.genre;
go
