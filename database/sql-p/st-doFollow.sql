--IF Object_Id('dbo.doFollow', 'P') IS NOT NULL DROP PROCEDURE dbo.doFollow
-- ERRO 2: O follow já existe


CREATE PROC dbo.doFollow 
    @followedUserID AS INT, @followerUserID AS INT 
AS 
BEGIN
    DECLARE @alreadyFollows AS INT
    IF @followedUserID <> @followerUserID AND EXISTS (SELECT userid FROM [user] WHERE userid = @followedUserID) AND EXISTS (SELECT userid FROM [user] WHERE userid = @followerUserID)
        BEGIN
            SET @alreadyFollows = (SELECT dbo.checkFollow (@followedUserID,@followerUserID))
            IF (@alreadyFollows = 0)
                BEGIN
                    BEGIN TRAN
                        BEGIN TRY
                            INSERT into dbo.follow VALUES (@followedUserID, @followerUserID)
                        END TRY
                        BEGIN CATCH
                            RAISERROR('Falhou ao inserir',16,1)
                        END CATCH
                    COMMIT TRAN
                END
            ELSE 
                BEGIN
                    PRINT 'ERRO! Relação já existe'
                    RETURN 2
                END 
        END
    ELSE
        BEGIN
            RETURN 0
        END 
END

EXEC dbo.doFollow 1,8

--TODO é preciso verificar se já existe essa relação!
-- Caso exista não acontece nada, o mesmo para remover
-- Criar uma udf para verificar isso