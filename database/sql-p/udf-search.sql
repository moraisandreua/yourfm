--DROP FUNCTION dbo.doSearch;

CREATE FUNCTION dbo.doSearch (@searchQuery AS VARCHAR(100) = '', @resultNumber AS INT) RETURNS @datatable TABLE (id INT ,nome VARCHAR(100), datatype VARCHAR(100))
AS
    BEGIN
        IF @searchQuery <> '' 
            BEGIN
                --Procurar por programas 
                INSERT @datatable SELECT TOP(@resultNumber) id,nome, 'programa' FROM programa WHERE nome LIKE '%'+@searchQuery+'%'
                --Procurar por playlist
                INSERT @datatable SELECT TOP (@resultNumber) id,designacao,'playlist' FROM listareproducao WHERE designacao LIKE '%'+@searchQuery+'%'
                --Procurar por user
                INSERT @datatable SELECT TOP (@resultNumber) userid,username,'user' FROM [user] WHERE username LIKE '%'+@searchQuery+'%'
                --Procurar por Géneros
                INSERT @datatable SELECT TOP (@resultNumber) id,designacao,'genero' FROM categoria WHERE designacao LIKE '%'+@searchQuery+'%' ORDER BY popularidade
            END
        
        RETURN
    END
GO

SELECT * FROM dbo.doSearch('as',4);

SELECT * FROM dbo.doSearch('as',4) WHERE datatype = 'user';