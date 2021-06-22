-- IF Object_Id('dbo.estacaoList', 'P') IS NOT NULL DROP PROCEDURE dbo.estacaoList

-- frontend implemented
CREATE PROC dbo.estacaoList @PageNumber AS INT = 1,@RowsPerPage AS INT = 15
AS 
    SELECT 
        u.userid, u.nome, u.foto, e.estacaoid
    FROM [dbo].[user] u
        INNER JOIN dbo.estacao e
    ON u.userid = e.estacaoid
    ORDER BY e.frequencia DESC
    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY


    -- EXEC estacaoList
