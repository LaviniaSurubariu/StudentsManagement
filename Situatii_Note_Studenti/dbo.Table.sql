CREATE TABLE [dbo].[Detalii_Studenti]
(
	[Id_detalii] INT NOT NULL PRIMARY KEY, 
    [id_stud] INT NULL, 
    [id_disc] INT NULL, 
    [nota] NCHAR(10) NULL, 
    CONSTRAINT [FK_Detalii_Studenti_ToStudenti] FOREIGN KEY ([id_stud]) REFERENCES [Studenti](Id_Student), 
    CONSTRAINT [FK_Detalii_Studenti_ToDiscipline] FOREIGN KEY ([id_disc]) REFERENCES [Discipline]([Id_disciplina])

)
