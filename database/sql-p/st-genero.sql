-- IF Object_Id('dbo.generoList', 'P') IS NOT NULL DROP PROCEDURE dbo.generoList

-- frontend implemented
CREATE PROCEDURE dbo.generoList @PageNumber AS INT = 1,@RowsPerPage AS INT = 16
AS
    SELECT 
        c.designacao, c.imagem
    FROM dbo.categoria c
        RIGHT JOIN dbo.programa_categoria pc
            ON c.id = pc.categoria
        GROUP BY c.designacao, c.imagem,popularidade
        ORDER BY popularidade DESC

    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY



/*
Devolve apenas os top 15 da primeira página
EXEC GeneroList 1

Devolve os top A da página B
EXEC GeneroList A, B
*/