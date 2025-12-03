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
CREATE TABLE [TBL_PRODUTOS] (
    [idProduto] int NOT NULL IDENTITY,
    [idUsuarioVendedor] int NOT NULL,
    [txtNome] varchar(200) NOT NULL,
    [idCategoria] int NOT NULL,
    [vlProduto] decimal(18,2) NOT NULL,
    [qtdEstoque] int NOT NULL,
    [txtDescricao] varchar(200) NOT NULL,
    [dtRegistro] datetime2 NOT NULL,
    [stAtivo] bit NOT NULL,
    CONSTRAINT [PK_TBL_PRODUTOS] PRIMARY KEY ([idProduto])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idProduto', N'dtRegistro', N'idCategoria', N'idUsuarioVendedor', N'qtdEstoque', N'stAtivo', N'txtDescricao', N'txtNome', N'vlProduto') AND [object_id] = OBJECT_ID(N'[TBL_PRODUTOS]'))
    SET IDENTITY_INSERT [TBL_PRODUTOS] ON;
INSERT INTO [TBL_PRODUTOS] ([idProduto], [dtRegistro], [idCategoria], [idUsuarioVendedor], [qtdEstoque], [stAtivo], [txtDescricao], [txtNome], [vlProduto])
VALUES (1, '2025-12-02T21:47:29.4950220-03:00', 1, 1, 3, CAST(1 AS bit), 'Produto n', 'Icaro', 200.0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idProduto', N'dtRegistro', N'idCategoria', N'idUsuarioVendedor', N'qtdEstoque', N'stAtivo', N'txtDescricao', N'txtNome', N'vlProduto') AND [object_id] = OBJECT_ID(N'[TBL_PRODUTOS]'))
    SET IDENTITY_INSERT [TBL_PRODUTOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251203004731_InitialCreate', N'9.0.9');

COMMIT;
GO

