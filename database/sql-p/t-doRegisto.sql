/*
    0 - ERRO ao efetuar a TRANSACTION

    3 - Username já está em uso


*/

--IF Object_Id('dbo.doRegisto', 'P') IS NOT NULL DROP PROCEDURE dbo.doRegisto
--? Será que vale a pena fazer alguma validação nos parâmetros de entrada. Por exemplo imagens

-- frontend implemented
CREATE PROC dbo.doRegisto 
    @username AS VARCHAR(18), @password AS VARCHAR(32), @email AS VARCHAR (60), @data_nasc AS DATE, @nome AS VARCHAR(45), @foto AS varchar(256),
    @tipoUser AS VARCHAR(8) = "user"
AS 

BEGIN 
    DECLARE @userid AS INT
    DECLARE @data AS TABLE(id INT, utype VARCHAR(8))
    --Verificar se o username está em uso
    IF NOT EXISTS (SELECT username FROM [user] WHERE username=@username)
        BEGIN
            BEGIN TRAN T1
                BEGIN TRY
                    INSERT INTO [dbo].[user]
                        (username,[password], email,data_nasc,nome,foto)
                    VALUES 
                        (@username, HASHBYTES('SHA2_256',@password),@email,CAST(@data_nasc AS DATE),@nome,@foto);
                    COMMIT TRAN T1
                END TRY
                
                BEGIN CATCH
                    PRINT @@ERROR
                    ROLLBACK TRANSACTION T1
                    RETURN 0
                END CATCH;
            
            SET @userid = (SELECT userid FROM [user] WHERE username = @username)
            
            IF @tipoUser = 'station'
                BEGIN
                    BEGIN TRAN T2
                        BEGIN TRY
                            INSERT INTO estacao 
                                (estacaoid,frequencia) 
                            VALUES
                                (@userid,CAST((112+1000) AS DECIMAL(8,2)) / 10)
                            COMMIT TRAN T2
                        END TRY
                        BEGIN CATCH
                            PRINT @@ERROR
                            ROLLBACK TRANSACTION T2
                            RETURN 0        
                        END CATCH
                END
            
            INSERT INTO @data VALUES (@userid,@tipoUser)
            SELECT * FROM @data
        END 
    ELSE
        BEGIN
            PRINT 'Erro username em uso'
            RETURN 3
        END  
END

-- Registo de um user
--EXEC dbo.doRegisto 'vb022','ocaminhodosjustos','vb@12.com','1993-07-11','Vicente','temp'
-- Registo de uma rádio
--EXEC dbo.doRegisto 'radio01', 'radioteste', 'radio01@gmail.com',NULL,'Rádio Macau', 'URLHERE','station'

-- REMOVER VALOR DE TESTE
-- DELETE FROM estacao WHERE estacaoid = (SELECT userid FROM [user] WHERE username = 'radio01')
-- DELETE FROM [user] WHERE username = 'radio01';

