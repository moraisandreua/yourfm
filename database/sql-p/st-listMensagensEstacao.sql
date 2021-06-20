-- IF Object_Id('dbo.listMensagensEstacao', 'P') IS NOT NULL DROP PROCEDURE dbo.listMensagensEstacao

CREATE PROC dbo.listMensagensEstacao 
    @estacaoid AS INT, @numMessages AS INT = 25
AS
BEGIN
    SELECT TOP(@numMessages) u.username, m.mensagem
    FROM mensagem m
        INNER JOIN [user] u
            ON u.userid = m.userid
    WHERE m.estacao = @estacaoid
    ORDER BY m.data DESC
END

EXEC dbo.listMensagensEstacao 50