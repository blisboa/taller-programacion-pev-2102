USE [ene_aiep]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarReq]    Script Date: 17-12-2020 19:10:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--select * from requerimiento
--exec ConsultarReq 3,1,'P'
--exec ConsultarReq 3,1,'R'
--exec ConsultarReq 3,1,'T'
--exec ConsultarReq 0,0,'T'
-- @estado = P --> Pendientes
-- @estado = R --> Resueltos
-- @estado = T --> Todos


ALTER  procedure [dbo].[ConsultarReq] (	@tipoReq int, 
										@prioridad int, 
										@estado char(1))
as
begin
	select	r.idRequeriminto as 'Código',
	        tr.glosa as 'Tipo Requerimiento',
			r.descripcion as 'Descripción',
			r.estado as 'Estado',
			p.glosa as 'Prioridad',
			p.plazo as 'Plazo'

	from requerimiento r

	inner join tipoPrioridad p
	on r.idPrioridad = p.idPrioridad

	inner join tipoRequerimiento tr
	on tr.idTipo = r.idTipo

	where ( r.idTipo = @tipoReq or @tipoReq =0) 
	and   ( r.idPrioridad = @prioridad or @prioridad = 0)
	and   ( r.estado = @estado or @estado = 'T')
end
