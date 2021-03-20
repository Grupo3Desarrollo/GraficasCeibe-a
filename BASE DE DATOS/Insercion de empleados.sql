USE [GraficaLCB]
GO

INSERT INTO [dbo].[Empleados]
           ([Nombres]
           ,[Apellidos]
           ,[FechaNacimiento]
           ,[Tel]
           ,[Sexo]
           ,[Estado]
           ,[contrasenia]
           ,[DNIEmpleado]
           ,[rol])
     VALUES
           ('Jonathan Alexis'
           ,'Aleman Linares'
           ,'1998-05-09'
           ,'96693357'
           ,'M'
           ,'Activo'
           ,'Y8msdnxDm9U='
           ,'0101199804248'
           ,'Gerente'),
		   ('Hugo Geovany'
           ,'Murillo Urbina'
           ,'2000-02-17'
           ,'96693300'
           ,'M'
           ,'Activo'
           ,'Y8msdnxDm9U='
           ,'1807200000429'
           ,'Dependiente')
GO
