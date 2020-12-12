use sistema_req
go
-- exec ValidarUsuario 'juan',''

alter  procedure ValidarUsuario(@usuario varchar(30),
								@clave   varchar(32))
as begin
  
  -- verificar que el usuario existe
  if exists ( select *  from usuario where idUsuario = @usuario )
      select 0 as CodigoRet, 'Usuario existe' as MensajeRet
  else
      select 1 as CodigoRet, 'Usuario No existe' as MensajeRet
end