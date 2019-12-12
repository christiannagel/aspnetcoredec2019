IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Books] (
    [BookId] int NOT NULL IDENTITY,
    [Title] nvarchar(30) NOT NULL,
    [Publisher] nvarchar(20) NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([BookId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191211122728_InitBooks', N'3.1.0');

GO

ALTER TABLE [Books] ADD [Isbn] nvarchar(20) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191211123124_AddIsbn', N'3.1.0');

GO

ALTER TABLE [Books] ADD [Bar] nvarchar(max) NULL;

GO

ALTER TABLE [Books] ADD [Foo] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191211123255_AddSomeMore', N'3.1.0');

GO

