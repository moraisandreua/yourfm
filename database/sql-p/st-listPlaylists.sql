-- IF Object_Id('dbo.listPlaylists', 'P') IS NOT NULL DROP PROCEDURE dbo.listPlaylists

CREATE PROCEDURE dbo.listPlaylists @PageNumber AS INT = 1,@RowsPerPage AS INT = 16
AS
    SELECT 
        l.designacao, l.foto
    FROM dbo.listareproducao l
        RIGHT JOIN dbo.programa_listareproducao pl
            ON l.id = pl.programa
        GROUP BY l.designacao, l.foto
        ORDER BY l.designacao
    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY

--EXEC dbo.listPlaylists 1