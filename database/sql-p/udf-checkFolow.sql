-- DROP FUNCTION dbo.checkFollow
CREATE FUNCTION dbo.checkFollow (@followedUserID INT, @followerUserID INT) RETURNS INT
AS 
BEGIN
    DECLARE @followStatus AS INT

    IF EXISTS (SELECT follower FROM dbo.follow WHERE followed = @followedUserID AND follower = @followerUserID)
        BEGIN
            SET @followStatus = 1
        END
    ELSE 
        BEGIN 
            SET @followStatus = 0
        END 
    RETURN @followStatus
END 

-- SELECT dbo.checkFollow (15,8)