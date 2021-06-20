CREATE PROC dbo.createPlaylist
    @designacao AS VARCHAR(80),@descricao AS VARCHAR(80),@userid AS INT, @foto AS VARCHAR(256)
AS 
    IF EXISTS (SELECT userid FROM [user] u WHERE u.userid = @userid)
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    INSERT INTO dbo.listareproducao VALUES (@designacao,@descricao,@userid, @foto)

                COMMIT TRAN
                RETURN 1                    
            END TRY
            BEGIN CATCH
                PRINT @@ERROR
                ROLLBACK TRAN
                RETURN 0        
            END CATCH
        END 

EXEC dbo.createPlaylist 'Bom Comer', 'Cenas sobre comida', 12, "https://i.pickadummy.com/300x100"