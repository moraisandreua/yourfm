DROP INDEX IF EXISTS IX_mensagem;
CREATE INDEX IX_mensagem ON dbo.mensagem ([data],estacao)