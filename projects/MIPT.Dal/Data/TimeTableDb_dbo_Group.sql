create table [Group]
(
    Id   int identity
        constraint Group_pk
            primary key nonclustered,
    Name nvarchar(128)
)
go

INSERT INTO TimeTableDb.dbo.[Group] (Name) VALUES (N'М05-13А');
INSERT INTO TimeTableDb.dbo.[Group] (Name) VALUES (N'М05-13Б');