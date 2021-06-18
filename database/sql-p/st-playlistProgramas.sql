--IF Object_Id('dbo.playlistProgramas', 'P') IS NOT NULL DROP PROCEDURE dbo.playlistProgramas

--! DEVE DAR PARA FAZER PARA OBTER UM JSON para as categorias de cada programa é ver se vale a pena!
CREATE PROC dbo.playlistProgramas 
     @id as int
AS
BEGIN
    SELECT 
        p.id as programa_id, p.nome, p.descricao, u.nome as estacao_nome, p.foto
    FROM programa p
        INNER JOIN programa_listareproducao p_l
            ON p.id = p_l.programa

        INNER JOIN listareproducao l
            ON p_l.listareproducao = l.id

        INNER JOIN estacao e
            ON p.estacao = e.estacaoid

        INNER JOIN [user] u
            ON e.estacaoid = u.userid

        WHERE l.id = @id
END 

EXEC dbo.playlistProgramas 1
