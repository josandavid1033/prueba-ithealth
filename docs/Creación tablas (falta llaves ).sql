CREATE TABLE Patients(
	Id int NOT NULL IDENTITY,
	Document_type_id int,
	Document_num bigint,
	Name varchar(100),
	Birthday Date,
	Email varchar(30),
	Gender_id int,
	Address varchar(40),
	Phone_number int,
	State int
	CONSTRAINT [PK_Patients] PRIMARY KEY ([Id]),
    --CONSTRAINT [FK_Patients_Genders_GendersId] FOREIGN KEY ([Gender_id]) REFERENCES [Genders] ([ID]) ON DELETE CASCADE
);

CREATE TABLE Genders(
	Id int NOT NULL IDENTITY,
	Name varchar(15)
);

CREATE TABLE Documents_type(
	Id int NOT NULL IDENTITY,
	Document_type varchar(10),
);

CREATE TABLE Doctors(
	Id int NOT NULL IDENTITY,
	Name varchar,
	Patient_id int
)