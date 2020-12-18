use ene_aiep
go

-- exec AsignarResuelto 1


alter  proc AsignarResuelto(@idReq int)
as begin

  if exists ( select *  from requerimiento where idRequeriminto = @idReq)
	begin 
	  update requerimiento
	  set estado = 'R'
	  where idRequeriminto = @idReq

	  select 0 as CodigoRet,'Requerimiento Resuelto.' as MensajeRet 
	end
   else
	  select 1 as CodigoRet,'Numero de requerimiento no existe.' as MensajeRet 
end