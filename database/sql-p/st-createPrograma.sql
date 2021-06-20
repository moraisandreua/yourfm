--IF Object_Id('dbo.seleccreateProgramatedEstacao', 'P') IS NOT NULL DROP PROCEDURE dbo.createPrograma
CREATE PROC dbo.createPrograma
    @userid AS INT, @nome AS VARCHAR(50),@descricao AS VARCHAR(280), @classificacao AS VARCHAR(100), @foto AS VARCHAR(256)
AS
BEGIN
    IF EXISTS(SELECT estacaoid FROM estacao WHERE estacaoid = @userid)
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    INSERT INTO programa VALUES (@nome,@descricao,(SELECT id FROM classificacao WHERE classificacao.designacao = @descricao),@userid,@foto)
                    COMMIT TRAN
            END TRY
            BEGIN CATCH
                PRINT @@ERROR
                    ROLLBACK TRANSACTION T1
                    RETURN 0
            END CATCH 
        END 
    ELSE
        BEGIN
            RETURN 0
        END 
END 