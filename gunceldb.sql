
drop table Module 
drop table Courses 
drop table Categories
drop table Employees
drop table Instructors
drop table Statuses
drop table Users
drop table CourseDetails
drop table Applicants
drop table Applications

create table Module(
Id int primary key identity(1,1)
)

create table Users(
Id int primary key identity(1,1),
FirstName varchar(250),
LastName varchar(250),
NationalIdentity varchar(250),
DateOfBirth Datetime,
Email varchar(250),
Password varchar(250)
)

create table Categories(
Id int primary key identity(1,1),
Name varchar(250)
)

create table Instructors(
Id int primary key identity(1,1),
UserId int foreign key references Users(Id),
Description varchar(250),
Image varchar(250),
)

create table Applicants(
Id int primary key identity(1,1),
UserId int foreign key references Users(Id)
)

create table Statuses(
Id int primary key identity(1,1),
Name varchar(50)
)

create table Courses(
Id int primary key identity(1,1),
ModuleId int foreign key references Module(Id),
)

create table Applications(
Id int primary key identity(1,1),
ApplicantId int foreign key references Applicants(Id),
CourseId int foreign key references Courses(Id),
StatusId int foreign key references Statuses(Id)
)



create table CourseDetails(
Id int primary key identity(1,1) references Courses(Id),
CategoryId int foreign key references Categories(Id),
InstructorId int foreign key references Instructors(Id),
StatusId int foreign key references Statuses(Id),
Description varchar(250),
Image varchar(250),
CourseName varchar(250)
)

