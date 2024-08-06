create database ToDoList
use ToDoList

create table Task 
(
	id int identity(1,1) primary key not null,
	[description] nvarchar(MAX),
	create_at DATE,
	[status] bit default 0
)