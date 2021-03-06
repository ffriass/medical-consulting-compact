USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[SIUD_USUARIO]    Script Date: 26/11/2018 12:02:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SIUD_USUARIO]
   
   @Control				VARCHAR(1) = NULL,
   @Sub_Control         INT = NULL,
   @Busqueda			VARCHAR(6) = NULL,

   @Us_Usuario			VARCHAR(20) = NULL,
   @Us_Password			VARCHAR(20) = NULL,
   @Doc_ID				INT = NULL,
   @Us_Foto				IMAGE = NULL,
   @Us_Email			VARCHAR(60) = NULL,
   @Us_Estatus			CHAR(1) = NULL,
   @Us_ID				INT = NULL 
 
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
				BEGIN
					SELECT 
						  Us_Usuario,
						  Doc_Nombre,
						  Doc_Apellido, 
						  Doc_Codico,
						  Doc_Email,
						  Doc_Telefono,
						  Us_Estatus								  			  
					FROM Usuario U INNER JOIN Doctor D
					ON U.Doc_ID = D.Doc_ID		
				END
			IF(@Sub_Control =  2)
				BEGIN
					SELECT 
						  Us_Usuario,
						  Doc_Nombre,
						  Doc_Apellido, 
						  Us_Foto,
						  Us_Estatus,
						  Doc_Email								  			  
					FROM Usuario U INNER JOIN Doctor D
					ON U.Doc_ID = D.Doc_ID
					WHERE ((U.Us_Usuario = @Us_Usuario OR D.Doc_Email = @Us_Usuario) AND (U.Us_Contrasena = @Us_Password ))												
				END			
			IF(@Sub_Control =  3)
				BEGIN
					SELECT 
						  Us_Usuario,
						  Doc_Nombre,
						  Doc_Apellido, 
						  Us_Foto,
						  Us_Estatus, 
						  Doc_Email								  			  
					FROM Usuario U INNER JOIN Doctor D
					ON U.Doc_ID = D.Doc_ID
					WHERE (U.Us_Usuario = @Us_Usuario OR D.Doc_Email = @Us_Usuario) 												
				END					
		END

	IF (@Control =  'I')
	BEGIN

		INSERT INTO Usuario
           (
			   [Us_Usuario]
			   ,Us_Contrasena
			   ,Us_Foto
			   ,Us_Estatus
			)
     VALUES
			 (
		   @Us_Usuario,
		   @Us_Password,
		   @Us_Foto,
		   @Us_Estatus
			)	
		SELECT 
			Us_ID
		FROM Usuario
		WHERE Us_ID = @@IDENTITY

	END

	IF (@Control =  'U')
		BEGIN
		UPDATE Usuario
		SET
		Us_Usuario  = @Us_Usuario,
		Us_Contrasena = @Us_Password,
		Us_Foto = @Us_Foto,
		Us_Estatus = @Us_Estatus,
		Doc_ID = @Doc_ID

		WHERE Us_ID = @Us_ID

   END

END
