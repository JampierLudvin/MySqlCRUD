/* ==============================================================
 DESCRIPCION:    INSERTar Devoluciones de productos
 FECHA:			 GCRE 20180713
 MODIFICACION : APAREJA 20190910 SE AGREGAR TIPODOCUMENTO, SERIE, CORRELATIVO, UNIDADMEDIDA
 MODIFICACION : APAREJAJ 20201031 SE CAMBIO EL COSTO PROMEDIO DEACUERDO AL COMPROBANTE GIRADO
 MODIFICACION : APAREJAJ 20201104 SER CAMBIO LAS VARIABLES DE COSTO A DECIMAL(16,6)
 MODIFICACION : APAREJAJ 20201120 SE AGREGO CONDICIONANTE DE STOCK 0
 MODIFICACION : APAREJAJ 20201212 SE AGREGO CONDICIONANTE DE ANULACION DE NOTA DE CREDITO
 MODIFICACION : NCUSIC 20210713 SE MODIFICO LA VALIDACION DE SERIE POR TIPODOC Y SE AGREGO NUEVOS CAMPOS AL INSERT INVENTARIOy tfechaEmision
 MODIFICACION : DGARCIAG 20220510 SE MODIFICA PARA QUE GUARDE EL TIPO DE DOCUMENTO DE PERSONA EN INVENTARIO
 MODIFICACION : DGARCIAG 20220513 SE MODIFICA PARA QUE TRABAJE CON LA TABLA DE COMPROBANTES EN LA FUSION
 MODIFICACION : APAREJAJ 20220819 SE AGREGO CONDICION PARA SALIDA DE PRODUCTOS QUE SON KIT
 MODIFICACION : ASOLORZANOH 20220909 SE INGRESA UNA CONSULTA PARA INGRESAR LA MONEDA AL MOMENTO DE LA ANULACION
 MODIFICACION : APAREJAJ 20221129 SE AGREGO LOS NUEVO ATRIBUTOS EN INVENTARIO
 MODIFICACION : APAREJAJ 20230110 SE CAMBIA EL TIPO OPERACION PARA ANULAR TRASLADO A DE 5 A 15
 MODIFICACION : JMANSILLAS 20230213 SE REEMPLAZA PROCEDIMIENTO PARA INSERTAR AL INVENTARIO
 MODIFICACION : JMANSILLAS 20230321 NUEVO INVENTARIO CON OPERACIONES DIFERENCIADAS
 MODIFICACION : JMANSILLAS 20230401 OPERACION DE SALIDA PARA KIT AUTOMATICO
 MODIFICACION : JMANSILLAS 20230419 BAJA PARA TRASLADO DE KIT AUTOMATICO
 MODIFICACION : JMANSILLAS 20230605 AGREGADO ID DEL DETALLE COMPROBANTE PARA PRECIO DE COMPRA
 MODIFICACION : JMANSILLAS 20230614 AJUSTE PARA ANULACIONES Y MODIFICACIONES DE TRASLADOS
 MODIFICACION : JMANSILLAS 20230623 SE AGREGA BIT PARA SABER SI FUE UN DOCUMENTO MODIFICADO O NO
 MODIFICACION : JMANSILLAS 20230719 CORRECION DE CAMPO PARA CANTIDAD UNIDAD DE MEDIDA EN PRC
 EJECUCION: prc_Inventario_DevolucionProductosAnulacion 1,'Prod00003','NIU',3,'01','F001',196,9702 a
============================================================== */
CREATE OR ALTER PROCEDURE [dbo].[prc_Inventario_DevolucionProductosAnulacion]
	@nItem INT,
	@sProductoCod VARCHAR(15),
	@sCodigoUnidadMedida VARCHAR(3),
	@dCantidad DECIMAL(14,6),
	@sTipoDoc VARCHAR(2),
	@sSerie VARCHAR(4),
	@sCorrelativo VARCHAR(10),
	@nSucursalId INT,
	@nIDDetalle INT,
	@bDocumentoModificado BIT
AS
BEGIN	
SET NOCOUNT ON
	DECLARE @bIndicador INT
	DECLARE @nInventarioPrecioUnitario DECIMAL(16,6)
	DECLARE @nValorUnitarioNeto DECIMAL(16,6)
	DECLARE @sRUCDNIDoc VARCHAR(11)
	DECLARE @sPersona_TipoDocIdentidad VARCHAR(1)
	DECLARE @sInventarioAfectacionIGVCodigo VARCHAR(2)
	DECLARE @bTipoComprobante BIT = 0
	DECLARE @bTipoOperacion BIT
	DECLARE @sMoneda_Cod VARCHAR(3)
	DECLARE @nPrecioId INT
	DECLARE @CodOperacion VARCHAR(3) = '24'
	DECLARE @tfechaEmision DATETIME 
	DECLARE @nTipoOperacionInventario INT
	DECLARE @nInventarioIdReferencialNuevo BIGINT
	DECLARE @dCUEntradaSalida DECIMAL (14,6)
	DECLARE @dCantidadUnidadMedida DECIMAL (14,6)
	DECLARE @tDetalleTemporal TABLE (sProductoCodigo VARCHAR(15),sUnidadMedidaCodigo VARCHAR(3),nItem smallint,dPrecioCompra DECIMAL(14,6))
		insert into @tDetalleTemporal
		SELECT top 1 sProductoCodigo,sUnidadMedidaCodigo,nItem,dPrecioCompra FROM tComprobanteDetalle WHERE nID = @nIDDetalle

		--verificar anular como NOTa de credito
		--SET @nPrecioId = (SELECT nPrecioId FROM tPrecio WHERE sProductoCod = @sProductoCod AND sCodigoUnidadMedida = @sCodigoUnidadMedida AND nSucursalId = @nSucursalId AND bEstado = 1)
		SELECT TOP 1 @nPrecioId = nPrecioId,
		@nInventarioPrecioUnitario = nInventarioPrecioUnitario,
		@sRUCDNIDoc = sRUCDNIDoc,
		@tfechaEmision = tFechaEmision,
		@sPersona_TipoDocIdentidad = sPersona_TipoDocIdentidad,
		@sMoneda_Cod = sMoneda,
		@nValorUnitarioNeto = nValorUnitarioNeto,
		@sInventarioAfectacionIGVCodigo = sInventarioAfectacionIGVCodigo,
		@nTipoOperacionInventario = nTipoOperacion,
		@nInventarioIdReferencialNuevo = nInventarioId,
		@dCUEntradaSalida = dCUEntradaSalida,
		@dCantidadUnidadMedida = dCantidadUnidadMedida
		FROM tInventario I
		LEFT JOIN @tDetalleTemporal D ON I.sProductoCod=D.sProductoCodigo AND I.sUnidadMedida = D.sUnidadMedidaCodigo AND I.nItemDoc = D.nItem 
		AND ISNULL(I.dPrecioCompraComprobante,0) = ISNULL(D.dPrecioCompra,0)
		WHERE 
		sProductoCod = @sProductoCod 
		AND nSucursalId = @nSucursalId 
		AND sSerieDoc = @sSerie 
		AND sCorrelativoDoc = @sCorrelativo 
		AND sUnidadMedida = @sCodigoUnidadMedida 
		AND nItemDoc = @nItem
		AND sTipoDoc = @sTipoDoc	
		ORDER BY tFechaActualizacion DESC, nItemDoc DESC

	SET @bIndicador = 0
	
	IF EXISTS (SELECT sInventarioProductoCodigo FROM tInventarioProducto WITH(NOLOCK) WHERE sInventarioProductoCodigo = @sProductoCod AND bKit = 1 AND bTipoKit = 0)
	BEGIN
		DECLARE @Operacion BIGINT =IIF(@nTipoOperacionInventario = 19, 45, IIF(@nTipoOperacionInventario = 53, 58, 51))
		EXEC prc_Inventario_Insertar 
		@sProductoCod,--@sProductoCodNuevo  varchar(15),
		@nInventarioPrecioUnitario,--@nInventarioPrecioUnitarioNuevo  decimal(14,6),
		@nValorUnitarioNeto,--@nValorUnitarioNetoNuevo  decimal(14,6),--COSTO UNITARIO MOV
		@sInventarioAfectacionIGVCodigo,--@sInventarioAfectacionIGVCodigoNuevo varchar(2),
		@nSucursalId,--@nSucursalIdNuevo  int,
		@Operacion,--@nTipoOperacionNuevo  int,
		@dCantidad,--@dCantidadEntradaSalidaNuevo  decimal(14,6),
		@sTipoDoc,--@sTipoDocNuevo  varchar(2),
		@sSerie,--@sSerieDocNuevo  varchar(4),
		@sCorrelativo,--@sCorrelativoDocNuevo  varchar(11),
		@sRUCDNIDoc,--@sRUCDNIDocNuevo  varchar(15), 385396
		@nItem,--@nItemDocNuevo  int,
		@sCodigoUnidadMedida,--@sUnidadMedidaNuevo  varchar(3),
		@tfechaEmision,--@tFechaEmisionNuevo  datetime,
		@sMoneda_Cod,--@sMonedaNuevo  varchar(3),
		@nPrecioId,--@nPrecioIdNuevo  int,
		@CodOperacion,--@sTipoInventarioSunatNuevo  varchar(2),
		@sPersona_TipoDocIdentidad,--@sPersona_TipoDocIdentidadNuevo  varchar(1),
		@nSucursalId,--@nSucursalIdRefNuevo  int--Para movimientos entre sucursales
		@nInventarioIdReferencialNuevo,
		0
	END
/*CONSULTAR TTIPOOPERACIONINVENTARIO PARA INFO*/
	SET @nTipoOperacionInventario = CASE @nTipoOperacionInventario
		WHEN 8	THEN 15 
		WHEN 14	THEN 20 
		WHEN 17	THEN 21 
		WHEN 18	THEN 25 
		WHEN 4 	THEN 26 
		WHEN 19	THEN 27 
		WHEN 24	THEN 29 
		WHEN 30	THEN 31 
		WHEN 53 	THEN 59
		ELSE 5 END
	SET @nInventarioPrecioUnitario = IIF(@nTipoOperacionInventario IN (15), @dCUEntradaSalida, @nInventarioPrecioUnitario)
	EXEC prc_Inventario_Insertar 
	@sProductoCod,--@sProductoCodNuevo  varchar(15),
	@nInventarioPrecioUnitario,--@nInventarioPrecioUnitarioNuevo  decimal(14,6),
	@nValorUnitarioNeto,--@nValorUnitarioNetoNuevo  decimal(14,6),--COSTO UNITARIO MOV
	@sInventarioAfectacionIGVCodigo,--@sInventarioAfectacionIGVCodigoNuevo varchar(2),
	@nSucursalId,--@nSucursalIdNuevo  int,
	@nTipoOperacionInventario,--@nTipoOperacionNuevo  int,
	@dCantidad,--@dCantidadEntradaSalidaNuevo  decimal(14,6),
	@sTipoDoc,--@sTipoDocNuevo  varchar(2),
	@sSerie,--@sSerieDocNuevo  varchar(4),
	@sCorrelativo,--@sCorrelativoDocNuevo  varchar(11),
	@sRUCDNIDoc,--@sRUCDNIDocNuevo  varchar(15),
	@nItem,--@nItemDocNuevo  int,
	@sCodigoUnidadMedida,--@sUnidadMedidaNuevo  varchar(3),
	@tfechaEmision,--@tFechaEmisionNuevo  datetime,
	@sMoneda_Cod,--@sMonedaNuevo  varchar(3),
	@nPrecioId,--@nPrecioIdNuevo  int,
	@CodOperacion,--@sTipoInventarioSunatNuevo  varchar(2),
	@sPersona_TipoDocIdentidad,--@sPersona_TipoDocIdentidadNuevo  varchar(1),
	@nSucursalId,--@nSucursalIdRefNuevo  int--Para movimientos entre sucursales
	@nInventarioIdReferencialNuevo,
	0
	

	IF (@nTipoOperacionInventario = 59)
	BEGIN
		DECLARE @KitDetalles TABLE (
			nKitDetalleCodigo int,
			nKitCodigo int,
			nItem int,
			sProductoCod varchar (15),
			dCantidad decimal (14,6),
			sCodigoUnidadMedida varchar (3)
		)
		INSERT INTO @KitDetalles
		SELECT TKD.* FROM tKit TK
		JOIN tKitDetalle TKD ON TK.nKitCodigo=TKD.nKitCodigo
		WHERE TK.sProductoCod = @sProductoCod

		WHILE EXISTS(SELECT 1 FROM @KitDetalles)
		BEGIN
			DECLARE @dCantidadDetalle DECIMAL(14,6)
			DECLARE @nPrecioIdDetalle INT
			DECLARE @nKitDetalleCodigo INT

			SELECT 
			@nKitDetalleCodigo = nKitDetalleCodigo,
			@sProductoCod = sProductoCod,
			@sCodigoUnidadMedida = sCodigoUnidadMedida,
			@dCantidadDetalle = dCantidad
			FROM @KitDetalles ORDER BY nKitDetalleCodigo DESC

			SELECT TOP 1 @nPrecioId = nPrecioId,
			@nInventarioPrecioUnitario = nInventarioPrecioUnitario,
			@sRUCDNIDoc = sRUCDNIDoc,
			@tfechaEmision = tFechaEmision,
			@sPersona_TipoDocIdentidad = sPersona_TipoDocIdentidad,
			@sMoneda_Cod = sMoneda,
			@nValorUnitarioNeto = nValorUnitarioNeto,
			@sInventarioAfectacionIGVCodigo = sInventarioAfectacionIGVCodigo,
			@nTipoOperacionInventario = nTipoOperacion,
			@nInventarioIdReferencialNuevo = nInventarioId,
			@dCUEntradaSalida = dCUEntradaSalida,
			@nItem = nItemDoc
			FROM tInventario
			WHERE 
			sProductoCod = @sProductoCod 
			AND nSucursalId = @nSucursalId 
			AND sSerieDoc = @sSerie 
			AND sCorrelativoDoc = @sCorrelativo 
			AND sUnidadMedida = @sCodigoUnidadMedida 
			AND nTipoOperacion = 54
			ORDER BY tFechaActualizacion ASC, nItemDoc DESC

			SET @dCantidadDetalle = @dCantidadDetalle * (@dCantidad * @dCantidadUnidadMedida)

			EXEC prc_Inventario_Insertar
			@sProductoCod,--@sProductoCodNuevo  varchar(15),
			@nInventarioPrecioUnitario,--@nInventarioPrecioUnitarioNuevo  decimal(14,6),
			@nValorUnitarioNeto,--@nValorUnitarioNetoNuevo  decimal(14,6),--COSTO UNITARIO MOV
			@sInventarioAfectacionIGVCodigo,--@sInventarioAfectacionIGVCodigoNuevo varchar(2),
			@nSucursalId,--@nSucursalIdNuevo  int,
			60,--@nTipoOperacionNuevo  int,
			@dCantidadDetalle,--@dCantidadEntradaSalidaNuevo  decimal(14,6),
			@sTipoDoc,--@sTipoDocNuevo  varchar(2),
			@sSerie,--@sSerieDocNuevo  varchar(4),
			@sCorrelativo,--@sCorrelativoDocNuevo  varchar(11),
			@sRUCDNIDoc,--@sRUCDNIDocNuevo  varchar(15),
			@nItem,--@nItemDocNuevo  int,
			@sCodigoUnidadMedida,--@sUnidadMedidaNuevo  varchar(3),
			@tfechaEmision,--@tFechaEmisionNuevo  datetime,
			@sMoneda_Cod,--@sMonedaNuevo  varchar(3),
			@nPrecioId,--@nPrecioIdNuevo  int,
			@CodOperacion,--@sTipoInventarioSunatNuevo  varchar(2),
			@sPersona_TipoDocIdentidad,--@sPersona_TipoDocIdentidadNuevo  varchar(1),
			@nSucursalId,--@nSucursalIdRefNuevo  int--Para movimientos entre sucursales
			@nInventarioIdReferencialNuevo,
			0
			DELETE FROM @KitDetalles WHERE nKitDetalleCodigo = @nKitDetalleCodigo
		END
	END

	SET @bIndicador = 1
	SELECT @bIndicador [bIndicador]
	SET NOCOUNT OFF
END