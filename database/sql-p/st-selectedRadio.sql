--IF Object_Id('dbo.selectedEstacao', 'P') IS NOT NULL DROP PROCEDURE dbo.selectedEstacao

-- Método para ir buscar os programas de uma dada Estacao
CREATE PROC dbo.selectedEstacao
    @selEstacaoId as int = null, @selEstacaoNome as varchar(100) = null
AS

BEGIN
    DECLARE @table as TABLE(nome varchar(50),descricao varchar(280), foto varchar(256))
    PRINT @selEstacaoId;
    IF @selEstacaoId <> ''
        BEGIN 
            INSERT INTO @table SELECT 
                p.nome,p.descricao,p.foto
            FROM estacao e
                INNER JOIN programa p
                        ON p.estacao = e.estacaoid
            WHERE e.estacaoid = @selEstacaoId
        END
    ELSE IF @selEstacaoNome <> '' 
        BEGIN
            INSERT INTO @table SELECT 
                p.nome,p.descricao,p.foto
            FROM estacao e
                INNER JOIN programa p
                        ON p.estacao = e.estacaoid
                INNER JOIN [dbo].[user] u
                        ON u.userid = e.estacaoid
            WHERE u.username = @selEstacaoNome
        END 
    ELSE
        BEGIN
            PRINT 'ERRO!'
            RETURN 0
        END 

    SELECT * FROM @table;
END

EXEC dbo.selectedEstacao @selEstacaoNome = 'vswinburn4' --@selEstacaoId = 93; -- |@selEstacaoNome = 'vswinburn4' !São de tuplos diferentes


