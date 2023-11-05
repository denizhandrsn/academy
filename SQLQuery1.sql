

create table Users(
Id int identity(1,1) primary key,
FirstName varchar(250),
LastName varchar(250),
NationalIdentity varchar(250),
DateOfBirth DateTime,
Email varchar(250),
Password varchar(250)
)


create table Categories(
Id int primary Key identity(1,1),
Name varchar(200),
)

create table Instructors(
Id int primary key identity(1,1),
UserId int foreign key references Users(Id),
Name varchar(200)

)
create table Status(
Id int primary key identity(1,1),
Name varchar(250),
Description varchar(250)
)
create table Employees(
Id int primary key identity(1,1),
UserId int foreign key references Users(Id),
Role varchar(250)
)




create table Courses(
Id int primary key identity(1,1),
CategoryId int foreign key references Categories(Id),
InstructorId int foreign key references Instructors(Id),
StatusId int foreign key references Status(Id),
CourseName varchar(200),
CoursePrice int
)



insert into Categories values ('Programming')
insert into Instructors values ('Denizhan')
insert into Instructors values ('İrem')
insert into Instructors values ('Engin')
insert into Status values ('Active','States that this row is active')
insert into Status values ('Deactive','States that this row is deactive')
insert into Courses values (1,1,1,'C#',65)
insert into Courses values (1,2,1,'Java',65)
insert into Courses values (1,3,1,'Python',65)


