create table Subject
(
    Id    int identity
        constraint Subject_pk
            primary key nonclustered,
    Title nvarchar(128)
)
go

INSERT INTO TimeTableDb.dbo.Subject (Title) VALUES (N'Философия');
INSERT INTO TimeTableDb.dbo.Subject (Title) VALUES (N'Английский язык');
INSERT INTO TimeTableDb.dbo.Subject (Title) VALUES (N'Промышленное программирование');
INSERT INTO TimeTableDb.dbo.Subject (Title) VALUES (N'VR');
INSERT INTO TimeTableDb.dbo.Subject (Title) VALUES (N'Нейронные сети');