-- IF Object_Id('dbo.programasLocutor', 'P') IS NOT NULL DROP PROCEDURE dbo.programasLocutor
USE yourfm;
CREATE PROCEDURE dbo.programasLocutor @locutorId AS INT
AS
    SELECT p.nome, p.descricao,p.foto,u.nome AS estacao
            FROM dbo.programa p
        INNER JOIN dbo.estacao e 
        ON p.id = e.estacaoId
        INNER JOIN dbo.locutor l
        ON e.estacaoId = l.estacao
        INNER JOIN [dbo].[user] u
        ON  u.userid = e.estacaoid
        WHERE l.userid = @locutorId

-- exec programasLocutor 35