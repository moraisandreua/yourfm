-- IF Object_Id('dbo.detailsPrograma', 'P') IS NOT NULL DROP PROCEDURE dbo.detailsPrograma

--? Será que vale a pena fazer um inner join com estação sabendo que é a mesma coisa? 
-- frontend implemented
CREATE PROC dbo.detailsPrograma
    @id as int
AS
    SELECT 
       p.nome,p.descricao,c.designacao as classificacao,p.foto,u.nome as estacao, AVG(ep.duracao) as duracao, COUNT(ep.id_programa) as numero_episodios
    FROM programa p
        INNER JOIN classificacao c
            ON p.classificacao = c.id
        INNER JOIN estacao e
            ON p.estacao = e.estacaoid
        INNER JOIN [user] u
            ON e.estacaoid = u.userid
        INNER JOIN episodio ep
            ON ep.id_programa = p.id
    WHERE p.id = @id
    GROUP BY p.nome,p.descricao,c.designacao,p.foto,u.nome


--EXEC dbo.detailsPrograma 1 

