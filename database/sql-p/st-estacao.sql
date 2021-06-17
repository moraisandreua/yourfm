-- IF Object_Id('dbo.estacaoList', 'P') IS NOT NULL DROP PROCEDURE dbo.estacaoList
CREATE PROC dbo.estacaoList @PageNumber AS INT = 1,@RowsPerPage AS INT = 15
AS 
    SELECT 
        u.nome, u.foto
    FROM [dbo].[user] u
        INNER JOIN dbo.estacao e
    ON u.userid = e.estacaoid
    ORDER BY e.frequencia DESC
    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY


    -- EXEC estacaoList
