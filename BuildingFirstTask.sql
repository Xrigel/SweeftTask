
create table Teacher(
Teacher_ID int Primary key identity(1,1),
First_Name nvarchar(20),
Last_Name nvarchar(20),
Sex nvarchar(10),
Subject nvarchar(25)
);

create table Pupil(
Pupil_ID int primary key identity(1,1),
First_Name nvarchar(20),
Last_name nvarchar(20),
Sex nvarchar(10),
Class nvarchar(5));


CREATE TABLE PupilAndTeacher (
  Teacher_ID int,
  Pupil_ID int,
  foreign key (Teacher_ID) references  Teacher(Teacher_ID),
  foreign key (Pupil_ID) references  Pupil(Pupil_ID)
);