--IF Object_Id('dbo.selectedGenero', 'P') IS NOT NULL DROP PROCEDURE dbo.selectedGenero

-- Método para ir buscar os programas de uma dada categoria
CREATE PROC dbo.selectedGenero 
    @selGeneroId as int = null, @selGeneroNome as varchar(100) = null
AS

BEGIN
    IF @selGeneroId <> ''
        BEGIN 
            SELECT p.nome,p.descricao,p.foto 
                FROM categoria c
                    INNER JOIN programa_categoria pc
                        ON c.id = pc.categoria
                    INNER JOIN programa p
                        ON p.id = pc.programa
                WHERE c.id = @selGeneroId
        END
    ELSE IF @selGeneroNome <> '' 
        BEGIN
            SELECT 
                p.nome,p.descricao,p.foto 
            FROM categoria c
                INNER JOIN programa_categoria pc
                    ON c.id = pc.categoria
                INNER JOIN programa p
                    ON p.id = pc.programa
            WHERE c.designacao = @selGeneroNome
        END 
    ELSE
        BEGIN
            PRINT 'ERRO!'
            RETURN 0
        END 
END

EXEC dbo.selectedGenero @selGeneroId = 32; -- |@selGeneroNome = 'Afrosoul'
EXEC dbo.selectedGenero @selGeneroNome = 'afro soul'



