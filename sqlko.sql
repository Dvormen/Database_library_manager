create table BDBauthor(
id int primary key identity(1,1),
firstName varchar(50),
lastName varchar(50)
)

create table BDBgenre(
id int primary key identity(1,1),
genre varchar(50)
)

create table BDBuser(
id int primary key identity(1,1),
username varchar(50),
email varchar(50)
)

create table BDBbooks(
id int primary key identity(1,1),
title varchar(50),
price decimal(10,2),
available bit,
state varchar(50) not null           
check (state IN ('New', 'Damaged', 'Torn', 'Used')),
genre_id int foreign key references BDBgenre(id),
author_id int foreign key references BDBauthor(id)
)

create table BDBloan(
id int primary key identity(1,1),
pickUpDate date,
returnDate date,
us_id int foreign key references BDBuser(id),
book_id int foreign key references BDBbooks(id)
)

create view authorLoanView as
select BDBauthor.firstName + ' ' + BDBauthor.lastName as AuthorName, count(BDBloan.id) as LoanCount, min(BDBloan.PickUpDate) as FirstLoan, max(BDBloan.PickUpDate) as LastLoan from BDBauthor
join BDBbooks ON BDBbooks.author_id = BDBauthor.id
join BDBloan ON BDBloan.book_id = BDBbooks.id
group by BDBauthor.firstName, BDBauthor.lastName;

create view bookLoanView as
select BDBbooks.title as BookTitle, BDBgenre.genre as Genre, count(BDBloan.id) as LoanCount, min(BDB.loanDate) as FirstLoan, max(BDBloan.returnDate) as LastReturn from BDBbooks
join BDBgenre on BDBbooks.genre_id = BDBgenre.id
left join BDBloan on BDBloan.book_id = BDBbooks.id
group by BDBbooks.title, BDBgenre.genre;

drop table BDBloan

drop table BDBbooks