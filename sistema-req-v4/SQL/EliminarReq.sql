use ene_aiep
go
-- exec EliminarReq 90
alter proc EliminarReq(@idReq int)
as begin
  delete from requerimiento where idRequeriminto = @idReq
  select 0 as CodigoRet,'Requerimiento ' + convert(varchar(10),@idReq ) +' fue eliminado' as MensajeRet
end