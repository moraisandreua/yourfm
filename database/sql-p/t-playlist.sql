--IF Object_Id('dbo.dropProgramasRelacoes', 'P') IS NOT NULL DROP TRIGGER dbo.dropProgramasRelacoes

CREATE TRIGGER dropProgramasRelacoes ON dbo.programa
    AFTER DELETE
AS
BEGIN
    DECLARE @programaid AS INT 
    SELECT @programaid = id FROM deleted;
    BEGIN TRY
        BEGIN TRAN T1
            DELETE FROM episodio WHERE id_programa = @programaid
            COMMIT TRAN T1

        BEGIN TRAN T2
            DELETE FROM programa_categoria WHERE programa = @programaid
            COMMIT TRAN T2
        BEGIN TRAN T3
            DELETE FROM programa_listareproducao WHERE programa = @programaid
            COMMIT TRAN T3
        
    END TRY
    BEGIN CATCH 
        PRINT @@ERROR
        ROLLBACK TRAN T1
        ROLLBACK TRAN T2
        ROLLBACK TRAN T3
    END CATCH 
END 