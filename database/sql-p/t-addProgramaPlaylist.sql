--IF Object_Id('dbo.selectedEstacao', 'P') IS NOT NULL DROP PROCEDURE dbo.selectedEstacao


CREATE PROC dbo.addProgramaPlaylist
    @programaid AS INT, @userid AS INT
AS
    BEGIN
        IF EXISTS (SELECT id FROM programa WHERE id = @programaid) AND EXISTS(SELECT userid FROM [user] WHERE userid = @userid)
            BEGIN
                BEGIN TRY
                    BEGIN TRAN T1
                        INSERT INTO programa_listareproducao VALUES (@programaid,@userid)
                    COMMIT TRAN T1
                END TRY 
                BEGIN CATCH
                    PRINT @@ERROR
                    ROLLBACK TRANSACTION T1
                    RETURN 0
                END CATCH
            END 
    END