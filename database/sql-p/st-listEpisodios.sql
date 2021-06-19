-- IF Object_Id('dbo.listEpisodios', 'P') IS NOT NULL DROP PROCEDURE dbo.listEpisodios
CREATE PROC dbo.listEpisodios @id AS INT, @PageNumber AS INT = 1,@RowsPerPage AS INT = 15
AS 
    SELECT 
        e.titulo, e.n_episodio,e.data_ini,e.data_fim
    FROM episodio e
    WHERE e.id_programa = @id
    ORDER BY e.n_episodio
    OFFSET (@PageNumber-1)*@RowsPerPage ROWS
    FETCH NEXT @RowsPerPage ROWS ONLY

-- EXEC dbo.listEpisodios 3