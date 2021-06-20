--IF Object_Id('dbo.listUserPlaylists', 'P') IS NOT NULL DROP PROCEDURE dbo.listUserPlaylists

CREATE PROC dbo.listUserPlaylists
    @userid AS INT
AS
    SELECT lp.id, lp.designacao FROM listareproducao lp where @userid = lp.userid

EXEC dbo.listUserPlaylists 12