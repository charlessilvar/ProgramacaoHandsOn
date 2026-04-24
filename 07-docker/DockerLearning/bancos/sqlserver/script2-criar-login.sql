CREATE LOGIN usuario
    WITH PASSWORD =N'@Usuario2019', DEFAULT_DATABASE = bancodedados
GO

CREATE USER usuario FOR LOGIN usuario;
GO

GRANT ALTER ANY SCHEMA TO usuario
GO

GRANT EXECUTE TO usuario
GRANT ALL TO usuario
GO

EXEC sp_addrolemenber N'db_datareader', N'usuario';
EXEC sp_addrolemenber N'db_datawriter', N'usuario';
EXEC sp_addrolemenber N'db_ddladmin', N'usuario';
GO

ALTER ROLE db_owner ADD MEMBER usuario
GO
