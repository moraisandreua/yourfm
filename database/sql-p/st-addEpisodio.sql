--IF Object_Id('dbo.addEpisodio', 'P') IS NOT NULL DROP PROCEDURE dbo.addEpisodio

CREATE PROC dbo.addEpisodio 
    @id_programa AS INT, @titulo AS VARCHAR(50), @data_ini AS VARCHAR(80),@data_fim AS VARCHAR(80)
AS 
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO 
                episodio (id_programa,n_episodio,titulo,data_ini,data_fim,duracao)
            VALUES
                (@id_programa,(SELECT MAX(n_episodio) FROM episodio WHERE id_programa=@id_programa)+1,@titulo, CAST(@data_ini AS datetime), CAST(@data_fim AS datetime),DATEDIFF(hour,@data_ini,@data_fim))
        END TRY
        BEGIN CATCH
            RAISERROR('Erro ao inserir',16,1)
            PRINT @@ERROR
        END CATCH
    COMMIT TRAN 
END

EXEC dbo.addEpisodio 1,'Balas e Bolinhos', '2021-03-20 23:46:00.000','2021-03-21 15:46:00.000'