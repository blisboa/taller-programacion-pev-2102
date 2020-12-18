use ene_aiep
go
--  exec GrabrarReq 1,'blisboa','req de pruebas dos',3

alter  proc GrabrarReq( @tipoReq int, 
						@usuario varchar(30),
						@desc varchar(300),
						@prioridad int)
as begin
 declare @idReq int,
		 @plazo int

 select @idReq  = isnull(max(idRequeriminto),0) + 1 from requerimiento
 select @plazo  = plazo  from tipoPrioridad where idPrioridad = @prioridad
 insert requerimiento select @idReq, @desc ,'P',@tipoReq,@prioridad, getdate(),@usuario
   select 0 as CodigoRet,'Requerimiento ' + convert(varchar(10),@idReq ) +' fue grabado, el plazo para resolverlo es ' + convert(varchar(10),@plazo) + ' dias'  as MensajeRet

end