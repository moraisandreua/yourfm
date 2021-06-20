--IF Object_Id('dbo.addMensagem', 'P') IS NOT NULL DROP PROCEDURE dbo.addMensagem
CREATE PROC dbo.addMensagem
    @userid AS INT, @mensagem AS VARCHAR(180), @estacaoid AS INT
AS 
BEGIN
    BEGIN TRAN
        BEGIN TRY 
            INSERT INTO dbo.mensagem(mensagem,[data], estacao,userid) VALUES (@mensagem,GETDATE(),@estacaoid,@userid)
        END TRY
        BEGIN CATCH
            RAISERROR('Erro ao inserir',16,1)
        END CATCH 
    COMMIT TRAN
END

EXEC dbo.addMensagem 1,'Olá mundo', 50 