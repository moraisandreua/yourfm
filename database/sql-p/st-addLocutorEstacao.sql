--IF Object_Id('dbo.addLocutorEstacao', 'P') IS NOT NULL DROP PROCEDURE dbo.addLocutorEstacao

CREATE PROC dbo.addLocutorEstacao 
    @userid AS INT, @estacaoid AS INT 
AS
BEGIN
    IF EXISTS (SELECT userid FROM [user] WHERE userid = @userid) AND EXISTS(SELECT estacaoid FROM estacao WHERE estacaoid = @estacaoid)
        BEGIN
            BEGIN TRY
                BEGIN TRAN 
                    INSERT INTO locutor VALUES (@userid,@estacaoid)
                    COMMIT TRAN
            END TRY
            BEGIN CATCH
                PRINT @@ERROR
                ROLLBACK TRAN
            END CATCH 
        END
    ELSE 
        BEGIN
            RETURN 0
        END 
END 

EXEC dbo.addLocutorEstacao 1,50