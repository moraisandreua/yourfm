-- Cosntrait para evitar que existam usernames repetidos
ALTER TABLE dbo.[user] 
ADD CONSTRAINT C_username UNIQUE(username);