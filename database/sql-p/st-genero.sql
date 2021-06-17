-- IF Object_Id('dbo.generoList', 'P') IS NOT NULL DROP PROCEDURE dbo.generoList
USE yourfm;
CREATE PROCEDURE dbo.generoList @PageNumber AS INT = 1,@RowsPerPage AS INT = 15
AS
    SELECT 
        designacao, imagem
            FROM dbo.categoria
    ORDER BY popularidade DESC
    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY



/*
Devolve apenas os top 15 da primeira página
EXEC GeneroListb 

Devolve os top A da página B
EXEC GeneroList A, B
*/