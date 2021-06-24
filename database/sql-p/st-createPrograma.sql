--IF Object_Id('dbo.createPrograma', 'P') IS NOT NULL DROP PROCEDURE dbo.createPrograma
CREATE PROC dbo.createPrograma
    @userid AS INT, @nome AS VARCHAR(50),@descricao AS VARCHAR(280), @classificacao AS VARCHAR(100), @foto AS VARCHAR(256)
AS
BEGIN
    DECLARE @classificacaoid as INT
    SET @classificacaoid = (SELECT id FROM classificacao WHERE classificacao.designacao = TRIM(@classificacao))


    IF EXISTS(SELECT estacaoid FROM estacao WHERE estacaoid = @userid) AND NOT EXISTS (SELECT id from programa WHERE programa.nome = @nome)
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    INSERT INTO programa([nome],[descricao],[classificacao],[estacao],[foto]) VALUES (@nome,@descricao,@classificacaoid,@userid,@foto)
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
            PRINT 0
        END
END

EXEC dbo.createPrograma 60,'Temp','Olá mundo','jovem','http://www.google.com'