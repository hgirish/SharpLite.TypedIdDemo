
    if exists (select * from dbo.sysobjects where id = object_id(N'Book_Shelf') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Book_Shelf

    create table Book_Shelf (
        BookID UNIQUEIDENTIFIER not null,
       BookName NVARCHAR(255) null,
       primary key (BookID)
    )
