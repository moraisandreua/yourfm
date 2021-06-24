--IF Object_Id('dbo.updatePrograma', 'P') IS NOT NULL DROP PROCEDURE dbo.updatePrograma
CREATE PROC dbo.updatePrograma
    @userid AS INT, @nome AS VARCHAR(50),@descricao AS VARCHAR(280), @classificacao AS VARCHAR(100), @foto AS VARCHAR(256), @programaid AS INT
AS
BEGIN
    DECLARE @classificacaoid as INT
    SET @classificacaoid = (SELECT id FROM classificacao WHERE classificacao.designacao = TRIM(@classificacao))
    IF EXISTS(SELECT estacaoid FROM estacao WHERE estacaoid = @userid) AND EXISTS(SELECT id FROM programa WHERE id =@programaid)
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    UPDATE programa SET nome = @nome, descricao = @descricao,classificacao = @classificacaoid,foto = @foto WHERE id = @programaid
                    COMMIT TRAN
            END TRY
            BEGIN CATCH
                PRINT @@ERROR
                    ROLLBACK TRAN
                    RETURN 0
            END CATCH 
        END 
    ELSE
        BEGIN
            RETURN 0
        END
END

EXEC dbo.updatePrograma 60, 'Deitei tarde acordei late', 'Mais um poema da autoria do mui nobre chico da tina', 'b','http://dummyimage.com/207x220.png/dddddd/000000',7