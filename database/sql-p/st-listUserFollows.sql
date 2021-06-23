--IF Object_Id('dbo.listUserFollows', 'P') IS NOT NULL DROP PROCEDURE dbo.listUserFollows

CREATE PROC dbo.listUserFollows
@userid AS INT
AS 
BEGIN
    SELECT u.userid, u.username, u.nome,u.foto FROM [user] u
        INNER JOIN estacao e
            ON u.userid = e.estacaoid
        INNER JOIN follow f
            ON f.followed = u.userid
    WHERE f.follower = @userid
END 

EXEC dbo.listUserFollows 2