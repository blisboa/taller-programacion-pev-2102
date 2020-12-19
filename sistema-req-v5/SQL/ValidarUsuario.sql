use ene_aiep
go
/*
exec ValidarUsuario '',''
exec ValidarUsuario 'gmoyaNN',''
exec ValidarUsuario 'gmoya','aaaa'
exec ValidarUsuario 'gmoya','123456'
*/

alter proc ValidarUsuario(@IdUsuario varchar(30), @clave varchar(30))
as begin

 if not exists ( select *  from usuario where IdUsuario = @IdUsuario)
	 begin
		select 1 as CodigoRet,
			   'Usuario incorrecto' as MensajeRet
			   return
	 end

 if not exists ( select *  from usuario where IdUsuario = @IdUsuario and clave = @clave)
	 begin
		select 2 as CodigoRet,
			   'Clave incorrecta' as MensajeRet
			   return
	 end

select 0 as CodigoRet,
		'Usuario autorizado' as MensajeRet

end