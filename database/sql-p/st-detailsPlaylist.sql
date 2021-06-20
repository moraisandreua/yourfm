--IF Object_Id('dbo.detailsPlaylist', 'P') IS NOT NULL DROP PROCEDURE dbo.detailsPlaylist

-- Devolve o nome, a descrição, a foto e o número de programas de uma dada playlist 
-- frontend implemented
CREATE PROC dbo.detailsPlaylist
@id as int 
AS 
BEGIN 
    SELECT 
        lp.designacao, lp.descricao, lp.foto, count(lp.id) AS numero_programas 
    FROM listareproducao lp
        INNER JOIN programa_listareproducao pl
            ON lp.id = pl.listareproducao
        INNER JOIN programa p
            ON p.id = pl.programa 
    WHERE lp.id = @id
    GROUP BY lp.designacao, lp.descricao, lp.foto
END

EXEC dbo.detailsPlaylist 2