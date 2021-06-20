-- DROP FUNCTION dbo.getUserid 

CREATE FUNCTION dbo.getUserid (@username VARCHAR(18)) RETURNS INT
AS 
BEGIN
    DECLARE @userid AS INT
    SELECT @userid = userid FROM [user] WHERE username = @username
    RETURN @userid
END


-- ! Aqui a notação é diferente das UDFs table cuidado
-- SELECT dbo.getUserid ('ttison7')