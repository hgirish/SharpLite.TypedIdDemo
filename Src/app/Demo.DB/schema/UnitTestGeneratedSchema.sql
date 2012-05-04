
    if exists (select * from dbo.sysobjects where id = object_id(N'Book_Shelf') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Book_Shelf

    if exists (select * from dbo.sysobjects where id = object_id(N'Products') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Products

    create table Book_Shelf (
        BookID UNIQUEIDENTIFIER not null,
       BookName NVARCHAR(255) null,
       primary key (BookID)
    )

    create table Products (
        Id INT IDENTITY NOT NULL,
       Name NVARCHAR(255) null,
       primary key (Id)
    )
