create table TimeTable
(
    GroupId   int            not null,
    SubjectId int            not null,
    StartAt   datetimeoffset not null,
    FinishAt  datetimeoffset not null,
    Id        int identity
        constraint TimeTable_pk
            primary key nonclustered
)
go

INSERT INTO TimeTableDb.dbo.TimeTable (GroupId, SubjectId, StartAt, FinishAt) VALUES (1, 1, N'0001-01-01 09:30:00.0000000 +00:00', N'0001-01-01 11:00:00.0000000 +00:00');
INSERT INTO TimeTableDb.dbo.TimeTable (GroupId, SubjectId, StartAt, FinishAt) VALUES (1, 2, N'0001-01-01 11:20:00.0000000 +00:00', N'0001-01-01 13:50:00.0000000 +00:00');
INSERT INTO TimeTableDb.dbo.TimeTable (GroupId, SubjectId, StartAt, FinishAt) VALUES (2, 1, N'0001-01-02 11:20:00.0000000 +00:00', N'0001-01-02 13:50:00.0000000 +00:00');
INSERT INTO TimeTableDb.dbo.TimeTable (GroupId, SubjectId, StartAt, FinishAt) VALUES (2, 3, N'0001-01-06 10:00:00.0000000 +00:00', N'0001-01-06 12:00:00.0000000 +00:00');