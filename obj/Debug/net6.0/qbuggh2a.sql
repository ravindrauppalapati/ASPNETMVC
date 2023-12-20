IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF SCHEMA_ID(N'Master') IS NULL EXEC(N'CREATE SCHEMA [Master];');
GO

CREATE TABLE [Grade] (
    [GradeId] int NOT NULL IDENTITY,
    [GradeName] nvarchar(max) NULL,
    [Section] nvarchar(max) NULL,
    CONSTRAINT [PK_Grade] PRIMARY KEY ([GradeId])
);
GO

CREATE TABLE [standards] (
    [Id] int NOT NULL IDENTITY,
    [StandardName] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_standards] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Master].[StudentInfo] (
    [StudentId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [DOB] datetime2 NULL,
    [Photo] varbinary(max) NULL,
    [Height] decimal(18,2) NULL,
    [Weight] real NULL,
    [IsPassout] bit NOT NULL,
    [StandardId] int NULL,
    [GradeId] int NOT NULL,
    CONSTRAINT [PK_StudentInfo] PRIMARY KEY ([StudentId]),
    CONSTRAINT [FK_StudentInfo_Grade_GradeId] FOREIGN KEY ([GradeId]) REFERENCES [Grade] ([GradeId]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentInfo_standards_StandardId] FOREIGN KEY ([StandardId]) REFERENCES [standards] ([Id])
);
GO

CREATE INDEX [IX_StudentInfo_GradeId] ON [Master].[StudentInfo] ([GradeId]);
GO

CREATE INDEX [IX_StudentInfo_StandardId] ON [Master].[StudentInfo] ([StandardId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215140113_CreateDotnetHelpLineContext', N'6.0.0');
GO

COMMIT;
GO

