-- Cosntrait para evitar que existam usernames repetidos
ALTER TABLE dbo.[user] 
ADD CONSTRAINT C_username UNIQUE(username);

UPDATE [user] SET [password] = HASHBYTES('SHA2_256',[password])