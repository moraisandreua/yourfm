--IF Object_Id('dbo.doLogin', 'P') IS NOT NULL DROP PROCEDURE dbo.doLogin

/*
CREATE PROC dbo.doLogin
    @username AS VARCHAR(18) = NULL,
    @password AS VARCHAR(32) = NULL
AS

--username, nome, foto, id, type
*/

CREATE PROC dbo.doLogin
    @username AS VARCHAR(18) = NULL,
    @password AS VARCHAR(32) = NULL
AS

BEGIN
    IF EXISTS (SELECT username FROM [user] WHERE (username=@username OR email = @username) AND [password] = HASHBYTES('SHA2_256',@password))
        BEGIN
            SELECT * 
            FROM
            (
                        SELECT u.username, u.nome, u.foto, u.userid, 'locutor' as user_type
                        FROM [user] u 
                            JOIN locutor l 
                            ON l.userid = u.userid
                        WHERE u.username = @username
            UNION ALL 
                        SELECT u.username, u.nome, u.foto, u.userid, 'station' as user_type
                        FROM [user] u 
                            JOIN estacao e 
                            ON e.estacaoid = u.userid
                        WHERE u.username = @username
            UNION ALL
                        SELECT u.username, u.nome, u.foto, u.userid, 'user' as user_type
                        FROM [user] u 
                        WHERE u.username = @username
                        AND NOT EXISTS 
                            (SELECT * from estacao e
                            WHERE u.userid = e.estacaoid
                            )
                        AND NOT EXISTS
                            (SELECT * from locutor l
                            WHERE u.userid = l.userid
                            )
            ) as myvalues
        END
    ELSE
        BEGIN
            RETURN 0; 
        END 
END 




EXEC dbo.doLogin 'gcavaney0','wzUyyOwLqD';