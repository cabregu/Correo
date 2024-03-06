Imports MySql.Data.MySqlClient
Imports System.Transactions
Imports System.IO
Imports System.Data.OleDb
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class CN_Correo
    Public Shared CadenaDeConeccionProduccion As String = ""
    Public Shared CadenaDeConeccionAnterior As String = ""
    Public Shared CadenaWeb As String = "server=sql221.main-hosting.eu;User Id=u905475182_cga;password=H159753cga_1;database=u905475182_lxs;Persist Security Info=True"


    Public Shared Function ConsultarRecorridosParaEnviarWeb(ByVal Planilla As String) As DataTable
        Dim sql As String = "Select * from recorridos where PLANILLA_RECORRIDO='" & Planilla & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtServ As New DataTable
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        DtServ = ds.Tables("recorridos")
        Return DtServ
    End Function
    Public Shared Function InstertarRecorridosWeb(ByVal Texto As String) As Boolean

        Using tx3 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))
            Dim cadenac As New System.Text.StringBuilder
            Dim cadenav As New System.Text.StringBuilder
            Dim detallecadenac As New System.Text.StringBuilder
            Dim detallecadenav As New System.Text.StringBuilder

            Dim cn As New MySqlConnection(CadenaWeb & ";Connection Timeout=60")
            Dim SQLINSERT As String = "insert into recorridos (NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, ZONA, REMITENTE, TRABAJO, FECHA_TRABAJO, NOMBRE_APELLIDO, CP, CALLE, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CARTA2, ORDEN_LECT, ESTADO, IDENTIFICADOR, RECORRIDO) values " & Texto
            cn.Open()

            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cm.ExecuteNonQuery()
            cn.Close()

            tx3.Complete()
            Return True
        End Using

    End Function
    Public Shared Function Obtenerdatoweb() As String
        Dim nivel As String = ""
        Dim sql As String = "Select Confirmacion from coneccion where dato='INFORMAR'"
        Dim cn As New MySqlConnection(CadenaWeb)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        nivel = cm.ExecuteScalar
        cn.Close()

        Return nivel

    End Function
    Public Shared Function ObtenerNroCartaDeEstadosParaDevueltaAnalisis() As DataTable

        'Cargar insert sql
        Dim sql As String = "Select motivo_devo, devo_plani, cartas.nro_carta From devueltas inner join cartas on devueltas.nro_carta=cartas.Nro_carta Where cartas.estado='ESP_PROG'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt


        cn.Close()
    End Function
    Public Shared Function ObtenerNroCartaDeEstadosParaEntregadaAnalisis() As DataTable

        'Cargar insert sql
        Dim sql As String = "Select Nro_carta from cartas where estado='DEVUELTA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt
        cn.Close()
    End Function
    Public Shared Function ObtenerMotivos() As DataTable

        'Cargar insert sql
        Dim sql As String = "Select * from motivos"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt
        cn.Close()
    End Function
    Public Shared Function ActualizarEstadoDevolucionDesdeAnalisis(ByVal nro_carta As Integer) As Boolean

        Dim sql As String = "UPDATE cartas SET ESTADO='DEVUELTA' WHERE NRO_CARTA=" & nro_carta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function ObtenerUltmiestadorecorrido(ByVal Carta As Integer) As String
        'Cargar insert sq
        Dim sqlNumero As String = "Select estado From recorridos Where nro_carta='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim estado As String
        cn.Open()
        estado = cm.ExecuteScalar
        cn.Close()
        Return estado

    End Function
    Public Shared Function ActualizarEstadoRecorridoParaDevoDesdeAnalisis(ByVal nro_carta As Integer) As Boolean

        Dim sql As String = "UPDATE recorridos SET ESTADO='DEVUELTA' WHERE NRO_CARTA=" & nro_carta & " ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function ConsultarRecorridosParaReleer(ByVal Planilla As String) As DataTable
        Dim sql As String = "Select * from recorridos where PLANILLA_RECORRIDO='" & Planilla & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtServ As New DataTable
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        DtServ = ds.Tables("recorridos")
        Return DtServ
    End Function


    'para crear
    Public Shared Function InsertarAlerta(ByVal nro_carta As String, ByVal comentario As String) As Boolean
        Try
            Dim sqlinsert As String = "INSERT INTO alertas (nro_carta, comentario, estado) VALUES (" & "'" & nro_carta & "'" & ", " & "'" & comentario & "', 'ingresado')"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlinsert, cn)

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function
    Public Shared Function VerificarAlerta(ByVal nro_carta As String) As String
        'a
        Dim Sql As String = "Select comentario from alertas Where nro_carta='" & nro_carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return resultado
        Else
            Return ""
        End If

    End Function
    Public Shared Function VerificarEstadoAlerta(ByVal nro_carta As String, ByVal NuevoEstado As String) As String
        'a
        Dim Sql As String = "Select estado from alertas Where nro_carta='" & nro_carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()


        If resultado = "ingresado" Then
            ENVIARMAILINTERNO(nro_carta, NuevoEstado)
            ActualizarAlertas(nro_carta, NuevoEstado)
        End If



    End Function
    Public Shared Function ENVIARMAILINTERNO(ByVal carta As String, ByVal estado As String)
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        'Dim adjunto As System.Net.Mail.Attachment

        With smtp
            .Port = 587
            .Host = "smtp.hostinger.com.ar"
            .Credentials = New System.Net.NetworkCredential("sistemas@lexs.com.ar", "lxs159753")
            .EnableSsl = False
        End With
        'adjunto = New System.Net.Mail.Attachment("C:\Temp\Adjunto.pdf")
        With correo
            .From = New System.Net.Mail.MailAddress("sistemas@lexs.com.ar")
            .To.Add("ingresos@lexs.com.ar;guillermo.a@lexs.com.ar;operaciones@lexs.com.ar")
            .Subject = "Alerta en Carta Nro " & carta
            .Body = "<strong>El numero de carta del asunto cambio de estado a " & estado & "</strong>"
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
            '.Attachments.Add(adjunto)
        End With

        Try
            smtp.Send(correo)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Shared Function ActualizarAlertas(ByVal nro_carta As String, ByVal Estado As String) As Boolean
        Dim sql As String = "UPDATE alertas SET estado='" & Estado & "' WHERE nro_carta=" & nro_carta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function




    'Arraylist 
    Public Shared Function ObtenerNroCartaPorSocio(ByVal Socioylote As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select nro_carta From cartas where NRO_CART2 LIKE '%" & Socioylote & "%'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function

    Public Shared Function CargarUsuarios() As ArrayList
        Dim ArrUsuarios As New ArrayList

        Dim sql As String = "Select Nombre from usuario"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()

        da.Fill(ds, "usuario")
        cn.Close()
        For Each row As DataRow In ds.Tables("usuario").Rows
            ArrUsuarios.Add(row("Nombre"))
        Next
        Return ArrUsuarios
    End Function
    Public Shared Function CargarClientes() As ArrayList
        Dim ArrClientes As New ArrayList

        Dim sql As String = "Select Nombre_Cliente from clientes"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "clientes")
        cn.Close()
        For Each row As DataRow In ds.Tables("clientes").Rows
            ArrClientes.Add(row("Nombre_Cliente"))
        Next
        Return ArrClientes
    End Function
    Public Shared Function CargarTipoServicio(ByVal Cliente As String) As ArrayList
        Dim ArrServicios As New ArrayList
        Dim sql As String = "Select Remitente from Remitentes where Cliente='" & Cliente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "Remitentes")
        cn.Close()
        For Each row As DataRow In ds.Tables("Remitentes").Rows
            ArrServicios.Add(row("Remitente"))
        Next
        Return ArrServicios

    End Function
    Public Shared Function CargarServicio() As ArrayList
        Dim ArrServicios As New ArrayList

        Dim sql As String = "Select CodigoServicio from servicio"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "servicio")
        cn.Close()
        For Each row As DataRow In ds.Tables("servicio").Rows
            ArrServicios.Add(row("CodigoServicio"))
        Next
        Return ArrServicios

    End Function
    Public Shared Function CargarTodoslosServicios() As ArrayList
        Dim ArrServicios As New ArrayList
        Dim sql As String = "Select Remitente from remitentes"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "remitentes")
        cn.Close()
        For Each row As DataRow In ds.Tables("remitentes").Rows
            ArrServicios.Add(row("remitente"))
        Next
        Return ArrServicios

    End Function
    Public Shared Function RemitosdeCte(ByVal Servicio As String) As ArrayList
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT Nro_Remito FROM remitos WHERE TipoRemitente ='" & Servicio & "'" & " AND Estado ='PENDIENTE'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "remitos")
        cn.Close()
        For Each row As DataRow In ds.Tables("remitos").Rows
            ArrServicios.Add(row("Nro_Remito"))
        Next
        Return ArrServicios

    End Function

    Public Shared Function RemitosdeCteremitosLexsImportado(ByVal Remitente As String) As ArrayList
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT NroRemito FROM remitoslexs WHERE Remitente ='" & Remitente & "' AND Estado='Importado'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "remitoslexs")
        cn.Close()
        For Each row As DataRow In ds.Tables("remitoslexs").Rows
            ArrServicios.Add(row("NroRemito"))
        Next
        Return ArrServicios

    End Function
    Public Shared Function RemitosdeCteremitosLexsIngresado(ByVal Remitente As String) As ArrayList
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT NroRemito FROM remitoslexs WHERE Remitente ='" & Remitente & "' AND Estado='Ingresado'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "remitoslexs")
        cn.Close()
        For Each row As DataRow In ds.Tables("remitoslexs").Rows
            ArrServicios.Add(row("NroRemito"))
        Next
        Return ArrServicios

    End Function

    Public Shared Sub CambiarEstadoRemitosLexs(ByVal NroRemito As Integer, ByVal estado As String)
        Dim sql As String = "UPDATE remitoslexs SET Estado = @estado WHERE NroRemito = @nroRemito"
        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cm As New MySqlCommand(sql, cn)
                cm.Parameters.AddWithValue("@estado", estado)
                cm.Parameters.AddWithValue("@nroRemito", NroRemito)
                cn.Open()
                cm.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub


    Public Shared Function CargarTodoslosremitente() As ArrayList
        Try


            Dim ArrListaRemitentes As New ArrayList
            Dim Consultasql As String = "Select Remitente From remitentes"

            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim CmSql As New MySqlCommand(Consultasql, cn)
            Dim da As New MySqlDataAdapter(CmSql)
            Dim dt As New DataTable
            cn.Open()
            da.Fill(dt)
            cn.Close()

            For Each rw As DataRow In dt.Rows
                ArrListaRemitentes.Add(rw("Remitente"))
            Next

            Return ArrListaRemitentes
        Catch ex As Exception

        End Try
    End Function
    'Public Shared Function ObtenerRemitosPendientesImpresion(ByVal Remitente As String) As ArrayList
    '    Dim ArrListaPendientes As New ArrayList
    '    Dim Consultasql As String = "Select Nro_Remito From remitos Where Estado='PEND_IMPR' And TipoRemitente= '" & Remitente & "'"

    '    Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
    '    Dim CmSql As New MySqlCommand(Consultasql, cn)
    '    Dim da As New MySqlDataAdapter(CmSql)
    '    Dim dt As New DataTable
    '    cn.Open()
    '    da.Fill(dt)
    '    cn.Close()

    '    For Each rw As DataRow In dt.Rows
    '        ArrListaPendientes.Add(rw("Nro_Remito"))
    '    Next

    '    Return ArrListaPendientes

    'End Function
    Public Shared Function ObtenerTodoslosRemitos(ByVal Remitente As String) As ArrayList
        Dim ArrListaPendientes As New ArrayList
        Dim Consultasql As String = "Select Nro_Remito From remitos Where TipoRemitente= '" & Remitente & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmSql As New MySqlCommand(Consultasql, cn)
        Dim da As New MySqlDataAdapter(CmSql)
        Dim dt As New DataTable
        cn.Open()
        da.Fill(dt)
        cn.Close()

        For Each rw As DataRow In dt.Rows
            ArrListaPendientes.Add(rw("Nro_Remito"))
        Next

        Return ArrListaPendientes

    End Function
    Public Shared Function Creararraydeconsultas(ByVal Nrocarta1 As String, ByVal Nrocarta2 As String, ByVal NOMBRE As String, ByVal CALLE As String, ByVal EMPRESA As String, ByVal NRO_CART2 As String, ByVal OBS As String, ByVal OBS2 As String, ByVal OBS3 As String, ByVal OBS4 As String, ByVal CPDESDE As String, ByVal CPHASTA As String) As ArrayList
        Dim ArrdatosConsultados As New ArrayList

        If Len(Nrocarta1) > 0 Then
            ArrdatosConsultados.Add("Nro_Carta>= '" & Nrocarta1 & "'")
        End If

        If Len(Nrocarta2) > 0 Then
            ArrdatosConsultados.Add("Nro_Carta<= '" & Nrocarta2 & "'")
        End If

        If Len(NOMBRE) > 0 Then
            ArrdatosConsultados.Add("APELLIDO LIKE '%" & NOMBRE & "%'")
        End If
        If Len(CALLE) > 0 Then
            ArrdatosConsultados.Add("CALLE LIKE '%" & CALLE & "%'")
        End If
        If Len(EMPRESA) > 0 Then
            ArrdatosConsultados.Add("EMPRESA LIKE '%" & EMPRESA & "%'")
        End If
        If Len(NRO_CART2) > 0 Then
            ArrdatosConsultados.Add("NRO_CART2 LIKE '%" & NRO_CART2 & "%'")
        End If
        If Len(OBS) > 0 Then
            ArrdatosConsultados.Add("OBS LIKE '%" & OBS & "%'")
        End If
        If Len(OBS2) > 0 Then
            ArrdatosConsultados.Add("OBS2 LIKE '%" & OBS2 & "%'")
        End If
        If Len(OBS3) > 0 Then
            ArrdatosConsultados.Add("OBS3 LIKE '%" & OBS3 & "%'")
        End If
        If Len(OBS4) > 0 Then
            ArrdatosConsultados.Add("OBS4 LIKE '%" & OBS4 & "%'")
        End If

        If Len(CPDESDE) > 0 Then
            If Len(CPHASTA) > 0 Then
                ArrdatosConsultados.Add("CP >='" & Val(CPDESDE) & "' And CP <='" & Val(CPHASTA) & "'")
            Else
                ArrdatosConsultados.Add("CP >='" & Val(CPDESDE) & "'")
            End If
        End If


        Return ArrdatosConsultados

    End Function
    Public Shared Function CargarTipoCarteros() As ArrayList
        Dim ArrListaRemitentes As New ArrayList
        Dim Consultasql As String = "Select TipoCartero From TiposCarteros"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmSql As New MySqlCommand(Consultasql, cn)
        Dim da As New MySqlDataAdapter(CmSql)
        Dim dt As New DataTable
        cn.Open()
        da.Fill(dt)
        cn.Close()

        For Each rw As DataRow In dt.Rows
            ArrListaRemitentes.Add(rw("TipoCartero"))
        Next

        Return ArrListaRemitentes
    End Function
    Public Shared Function CargarCarteros() As ArrayList
        Dim ArrCarteros As New ArrayList
        Dim sql As String = "Select idCarteros from carteros"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "carteros")
        cn.Close()
        For Each row As DataRow In ds.Tables("carteros").Rows
            ArrCarteros.Add(row("idCarteros"))
        Next
        Return ArrCarteros
    End Function
    Public Shared Function CargarMotivos() As ArrayList
        Dim ArrMotivos As New ArrayList
        Dim sql As String = "Select IdMotivo, Motivo from Motivos"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "Motivos")
        cn.Close()
        For Each row As DataRow In ds.Tables("Motivos").Rows
            ArrMotivos.Add(row("IdMotivo") & "-" & row("Motivo"))
        Next
        Return ArrMotivos
    End Function
    Public Shared Function cargarFeriados() As ArrayList
        Dim sql As String = "Select * from criteriostrferiados"
        Dim arrlista As New ArrayList

        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "criteriostrferiados")
        cn.Close()
        dt = ds.Tables("criteriostrferiados")


        For Each drw As DataRow In dt.Rows
            arrlista.Add(drw("dia"))
        Next

        Return arrlista

    End Function
    Public Shared Function cargarCarterosmail() As ArrayList
        Dim sql As String = "Select * from carterosmail"
        Dim arrlista As New ArrayList

        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "carterosmail")
        cn.Close()
        dt = ds.Tables("carterosmail")


        For Each drw As DataRow In dt.Rows
            arrlista.Add(drw("CODIGO"))
        Next

        Return arrlista

    End Function
    Public Shared Function BuscarEntregada() As ArrayList

        Dim f1 As Date = Now.ToShortDateString
        Dim f2 As Date = Now.ToShortDateString
        f1 = f1.AddDays(-100)
        f2 = f2.ToShortDateString
        Dim fecha1 As String
        Dim fecha2 As String
        fecha1 = Converfecha(f1)
        fecha2 = Converfecha(f2)

        Dim Arr As New ArrayList
        Dim sql As String = "Select nro_carta From entregadas Where fech_trab between '" & fecha1 & "' and " & "'" & fecha2 & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "entregadas")
        cn.Close()
        For Each row As DataRow In ds.Tables("entregadas").Rows
            Dim Nrocart As Integer = row("nro_carta")
            Arr.Add(Nrocart)
        Next
        Return Arr

    End Function
    Public Shared Function BuscarTransito() As ArrayList

        Dim f1 As Date = Now.ToShortDateString
        Dim f2 As Date = Now.ToShortDateString
        f1 = f1.AddDays(-100)
        f2 = f2.ToShortDateString
        Dim fecha1 As String
        Dim fecha2 As String
        fecha1 = Converfecha(f1)
        fecha2 = Converfecha(f2)



        Dim ArrClientes As New ArrayList

        Dim sql As String = "Select NRO_CARTA From cartastr2 Where fech_trab between '" & fecha1 & "' and " & "'" & fecha2 & "' AND (ESTADO<>'ENTREGADA' OR ESTADO<>'DEVUELTA' OR ESTADO<>'ENT_COD13' OR ESTADO<>'EN_DEVOLUCION')"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartastr2")
        cn.Close()

        For Each row As DataRow In ds.Tables("cartastr2").Rows
            Dim Nrocart As Integer = row("NRO_CARTA").ToString
            ArrClientes.Add(Nrocart)
        Next

        Return ArrClientes

    End Function
    Public Shared Function Buscarporfecha() As ArrayList


        Dim f1 As Date = Now.ToShortDateString
        Dim f2 As Date = Now.ToShortDateString
        f1 = f1.AddDays(-15)
        f2 = f2.ToShortDateString
        Dim fecha1 As String
        Dim fecha2 As String
        fecha1 = Converfecha(f1)
        fecha2 = Converfecha(f2)
        Dim ArrClientes As New ArrayList

        Dim sql As String = "Select nro_carta From cartas Where fech_trab between '" & fecha1 & "' and " & "'" & fecha2 & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()

        For Each row As DataRow In ds.Tables("CARTAS").Rows
            Dim Nrocart As Integer = row("NRO_CARTA").ToString

            ArrClientes.Add(Nrocart)
        Next
        Return ArrClientes




    End Function
    Public Shared Function CargarRecorridospl() As DataTable
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT * FROM recorridospl ORDER BY id DESC LIMIT 30"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridospl")
        cn.Close()
        Dim Dt As New DataTable

        Dt = ds.Tables("recorridospl")

        Return Dt
    End Function
    Public Shared Function CargarRecorridosplFecha(ByVal Fecha As String) As DataTable
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT * FROM recorridospl where fecharecorrido='" & Converfecha(Fecha) & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridospl")
        cn.Close()
        Dim Dt As New DataTable

        Dt = ds.Tables("recorridospl")

        Return Dt
    End Function
    Public Shared Function CargarPlanillasDev() As DataTable
        Dim ArrMotivos As New ArrayList
        Dim year As Integer = DateTime.Now.Year ' Obtener el año actual
        Dim sql As String = "SELECT Plani_devo FROM devueltaspl WHERE YEAR(Fecha_plani) = " & year & " AND TRIM(Plani_devo) <> ''"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "devueltaspl")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("devueltaspl")

        Return dt
    End Function


    Public Shared Function CargarCarterosMailParaZonales() As DataTable

        Dim ArrMotivos As New ArrayList
        Dim sql As String = "Select CODIGO from carterosmail"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "carterosmail")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("carterosmail")

        Return dt
    End Function
    Public Shared Function CargarPlanillasParaZonales(ByVal Cartero As String) As DataTable

        Dim ArrMotivos As New ArrayList
        Dim sql As String = "Select nroplanilla from recorridospl where cartero='" & Cartero & "' AND estado='EN_DISTRIBUCION'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridospl")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("recorridospl")

        Return dt
    End Function
    Public Shared Function ActualizarPlanillaZonales(ByVal PLanilla As Integer) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE recorridospl SET estado='ENVIADO'" & " Where nroplanilla='" & PLanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function CargarPlanillasParaEnviar(ByVal Planilla As String) As DataTable

        Dim ArrMotivos As New ArrayList
        Dim sql As String = "Select nro_carta, remitente, Nombre_apellido, cp, calle, localidad, provincia, planilla_recorrido, empresa, nro_carta2 ,fecha_recorrido, cartero from recorridos where PLANILLA_RECORRIDO='" & Planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("recorridos")

        Return dt
    End Function
    Public Shared Function CargarPlanillasDevParaTxt(ByVal desde As String, ByVal Hasta As String) As DataTable


        Dim sql As String = "Select * from devueltas where devo_plani>=" & desde & " and devo_plani<= " & Hasta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "devueltas")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("devueltas")
        Return dt
    End Function
    Public Shared Function CargarPlanillasDevParaSeprit(ByVal desde As String, ByVal Hasta As String) As DataTable


        Dim sql As String = "Select apellido, calle, cp, localidad, fech_devo fecha, devo_plani planilla, nro_carta from devueltas where devo_plani>=" & desde & " and devo_plani<= " & Hasta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "devueltas")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("devueltas")
        Return dt
    End Function


    Public Shared Function BuscarEmpresaSocioNrocart2(ByVal nro_carta As String) As DataTable

        'Cargar insert sql
        Dim sql As String = "Select Empresa, socio, nro_cart2 from cartas where nro_carta='" & nro_carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt


        cn.Close()
    End Function

    Public Shared Function CargarRecorridosCarteroFecha(ByVal Cartero As String, ByVal fechadesde As String, ByVal fechahasta As String) As DataTable
        'fech_trab between '" & fechaantes & "' and " & "'" & fechadespues & "'"
        'nro_carta, remitente, Nombre_apellido, cp, calle, localidad, provincia, planilla_recorrido, empresa, fecha_recorrido, cartero
        Dim sql As String = "Select * from recorridos where cartero='" & Cartero & "' and fecha_recorrido between '" & Converfecha(fechadesde) & "' and '" & Converfecha(fechahasta) & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("recorridos")

        Return dt
    End Function

    Public Shared Function CargarRecorridosParaTransoft(ByVal NroPLanilla As String) As DataTable

        Dim sql As String = "Select * from recorridos where planilla_recorrido='" & NroPLanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        Dim dt As New DataTable
        dt = ds.Tables("recorridos")

        Return dt
    End Function



    Public Shared Function VerificarCpDeAsignaciones(ByVal Cp As Integer) As Boolean
        Dim sqlNumero As String = "SELECT cp FROM asignaciones WHERE cp = @Cp"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        cm.Parameters.AddWithValue("@Cp", Cp)
        Dim existeCp As Boolean = False
        Try
            cn.Open()
            Dim resultado As Object = cm.ExecuteScalar()
            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                existeCp = True
            End If
        Catch ex As Exception

        Finally
            cn.Close()
        End Try
        Return existeCp
    End Function


    'mysql Integer
    Public Shared Function ClaveUsuario(ByVal usuario As String, ByVal clave As String) As Integer
        Dim nivel As Integer = 0
        Dim sql As String = "Select Nivel from usuario where Nombre='" & usuario & "'" & " And Clave='" & clave & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        nivel = cm.ExecuteScalar
        cn.Close()

        Return nivel

    End Function
    Public Shared Function ObtenerNroCarta() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_CARTA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function
    Public Shared Function ObtenerDiasServicio(ByVal CodServ As String) As Integer
        Dim sql As String = "Select Cant_dias from servicio Where CodigoServicio='" & CodServ & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim Cm As New MySqlCommand(sql, cn)
        Dim Cantdias As Integer
        cn.Open()
        Cantdias = Cm.ExecuteScalar
        cn.Close()
        Return Cantdias
    End Function
    Public Shared Function ActualizarEstado(ByVal Remito As String, ByVal Remitente As String, ByVal Estado As String) As Boolean
        Dim sql As String = "UPDATE cartas SET ESTADO='" & Estado & "' WHERE TRABAJO='" & Remito & "'" & " AND REMITENTE='" & Remitente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ConvertAño(ByVal valor As String) As String

        Try
            Dim año As String = valor.Substring(valor.LastIndexOf("/") + 1, 4)
            Dim mes As String = valor.Substring(3, 2)
            Dim dia As String = valor.Substring(0, 2)

            Return año
        Catch ex As Exception
            Return "2019"

        End Try


    End Function
    Public Shared Function ObtenerNroPlanillarecorrido() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_PLANILLA_RECO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function
    Public Shared Function ObtenerNroPlanillaConfirmacionAcuse() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_PLANILLA_CONF_ACUSE'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function
    Public Shared Function FuncionLevenshteinPorcentaje(ByVal s1 As String, ByVal s2 As String) As Integer
        Dim coste As Integer = 0
        Dim n1 As Integer = s1.Length
        Dim n2 As Integer = s2.Length
        Dim m As Integer(,) = New Integer(n1, n2) {}
        For i As Integer = 0 To n1
            m(i, 0) = i
        Next
        For i As Integer = 0 To n2
            m(0, i) = i
        Next
        For i1 As Integer = 1 To n1
            For i2 As Integer = 1 To n2
                coste = If((s1(i1 - 1) = s2(i2 - 1)), 0, 1)
                m(i1, i2) = Math.Min(Math.Min(m(i1 - 1, i2) + 1, m(i1, i2 - 1) + 1), m(i1 - 1, i2 - 1) + coste)
            Next
        Next
        Return m(n1, n2)
    End Function
    Public Shared Function ObtenerCantDiasCP(ByVal CP As Integer) As Integer

        Dim sql As String = "Select * from criteriostrcp"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "criteriostr")
        cn.Close()
        dt = ds.Tables("criteriostr")
        Dim CantDCP As Integer = 0

        For Each drw As DataRow In dt.Rows
            If CP >= drw("desde") And CP <= drw("hasta") Then
                CantDCP = drw("cant").ToString
            End If
        Next

        Return CantDCP

    End Function
    Public Shared Function ObtenerNroVisitada() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_VISITADAS'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim nro As String
        cn.Open()
        nro = cm.ExecuteScalar
        cn.Close()

        Return nro


    End Function
    Public Shared Function ObtenerNroDevuelta() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_DEVUELTAS'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim nro As String
        cn.Open()
        nro = cm.ExecuteScalar
        cn.Close()

        Return nro


    End Function
    Public Shared Function ActualizarNroDevuelta(ByVal NUMERO As Integer) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE configuracion SET desde='" & NUMERO + 1 & "'" & " Where operacion='NRO_DEVUELTAS'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ContarPlanillas(ByVal planilla As String) As Integer

        Dim sql As String = "SELECT COUNT(nro_carta) FROM cartas where nro_planil='" & planilla & "'"
        Dim cantidad As Integer = 0
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        cm.CommandTimeout = 0
        cn.Open()
        cantidad = cm.ExecuteScalar
        cn.Close()

        Return cantidad
    End Function
    Public Shared Function ObtenerNroPlanillaDevolucion() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_PLANILLA_DEVO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim Numero As Integer
        cn.Open()
        Numero = cm.ExecuteScalar
        cn.Close()
        Return Numero

    End Function

    Public Shared Function ObtenerNroPlanillaOrdenDeRetiro() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NUMEROORDENDERETIRO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim Numero As Integer
        cn.Open()
        Numero = cm.ExecuteScalar
        cn.Close()
        Return Numero

    End Function

    Public Shared Function ActualizarMotivos(ByVal IDMotivo As Integer, ByVal Motivo As String, ByVal reprogramacion As String, ByVal ident As Integer) As Boolean
        Dim sql As String = "UPDATE motivos SET idMotivo='" & IDMotivo & "', " & "Motivo= '" & Motivo & "', " & "reprogramacion='" & reprogramacion & "' WHERE id=" & ident & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function InsertarMotivos(ByVal IDMotivo As Integer, ByVal Motivo As String, ByVal reprogramacion As String) As Boolean
        Dim sqlinsert As String = "INSERT INTO motivos (idmotivo, motivo, reprogramacion) VALUES (" & "'" & IDMotivo & "'" & ", " & "'" & Motivo & "'" & ", '" & reprogramacion & "')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function

    'funcion string

    'Public Shared Function Converfecha(ByVal valor As String) As String

    '    Try
    '        Dim año As String = valor.Substring(valor.LastIndexOf("/") + 1, 4)
    '        Dim mes As String = valor.Substring(3, 2)
    '        Dim dia As String = valor.Substring(0, 2)
    '        Dim fecha As String = año & "-" & mes & "-" & dia

    '        If fecha = "1899-12-30" Then
    '            Return "0000-00-00"
    '        Else
    '            If IsDate(fecha) Then
    '                Return fecha
    '            Else
    '                Return "0000-00-00"
    '            End If
    '        End If

    '    Catch ex As Exception

    '        Return "0000-00-00"
    '    End Try

    'End Function

    Public Shared Function Converfecha(ByVal valor As String) As String
        Dim formatos As String() = {"dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "dd/MM/yy", "d/MM/yy", "dd/M/yy", "d/M/yy"}

        Dim fecha As DateTime
        If DateTime.TryParseExact(valor, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, fecha) Then
            Return fecha.ToString("yyyy-MM-dd")
        Else
            Return "0000-00-00"
        End If
    End Function



    Public Shared Function Converfechaescaneo(ByVal valor As String) As String
        Try
            Dim año As String = valor.Substring(valor.LastIndexOf("/") + 1, 4)
            Dim mes As String = valor.Substring(3, 2)
            Dim dia As String = valor.Substring(0, 2)
            Dim fecha As String = dia & "_" & mes & "_" & año
            Return fecha
        Catch ex As Exception
            Return "0000_00_00"
        End Try

    End Function
    Public Shared Function ObtenerFechaRemito(ByVal NroRemito As String, ByVal Remitente As String) As String
        Dim Fechasql As String = "Select Fecha_Retiro from Remitos Where Nro_Remito='" & NroRemito & "'" & " And TipoRemitente ='" & Remitente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(Fechasql, cn)
        Dim Fecha As String
        cn.Open()
        Fecha = CmFecha.ExecuteScalar
        cn.Close()
        Return Fecha
    End Function
    Public Shared Function ObtenerServicio(ByVal NroRemito As String, ByVal Remitente As String) As String
        Dim Fechasql As String = "Select Servicio from Remitos Where Nro_Remito='" & NroRemito & "'" & " And TipoRemitente ='" & Remitente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(Fechasql, cn)
        Dim Servi As String
        cn.Open()
        Servi = CmFecha.ExecuteScalar
        cn.Close()
        Return Servi
    End Function
    Public Shared Function VerificarVisita(ByVal NroCarta As String) As String
        Dim Sql As String = "Select Tema1, Tema2, Tema3 from cartas Where NRO_CARTA='" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(Sql, cn)
        Dim Dr As MySqlDataReader
        Dim T1 As String = ""
        Dim T2 As String = ""
        Dim T3 As String = ""
        cn.Open()
        Dr = cm.ExecuteReader

        While Dr.Read
            If IsDBNull(Dr("Tema1")) Then
                T1 = "Vacio"
            Else
                If Dr("Tema1") = "" Then
                    T1 = "Vacio"
                Else
                    T1 = "VISITADO"
                End If
            End If

            If IsDBNull(Dr("Tema2")) Then
                T2 = "Vacio"
            Else
                If Dr("Tema2") = "" Then
                    T2 = "Vacio"
                Else
                    T2 = "VISITADO"
                End If
            End If

            If IsDBNull(Dr("Tema3")) Then
                T3 = "Vacio"
            Else
                If Dr("Tema3") = "" Then
                    T3 = "Vacio"
                Else
                    T3 = "VISITADO"
                End If

            End If
        End While
        cn.Close()


        If T1 = "Vacio" Then
            Return "SinVisitas"
        Else
            If T2 = "Vacio" Then
                Return "1VISIT"
            Else
                If T3 = "Vacio" Then
                    Return "2VISIT"
                Else
                    Return "3VISIT"
                End If
            End If
        End If
    End Function
    Public Shared Function VerificarLimite(ByVal Cartero As String) As String
        Dim Sql As String = "Select LIMITE_FECHA from carterosmail Where CODIGO='" & Cartero & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        Return resultado

    End Function
    '    Public Shared Function ObtenerNroDevoPlani2()
    '() As String
    '        'Cargar insert sql
    '        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_PLANILLA_DEVO'"
    '        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
    '        Dim cm As New MySqlCommand(sqlNumero, cn)
    '        Dim nro As String
    '        cn.Open()
    '        nro = cm.ExecuteScalar
    '        cn.Close()

    '        Return nro


    '    End Function
    Public Shared Function ObtenerNroPlanillaEscaner() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NRO_PLANILLA_ESCANER'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim nro As String
        cn.Open()
        nro = cm.ExecuteScalar
        cn.Close()

        Return nro


    End Function

    Public Shared Function ObtenerNroPendiente(ByVal CARTERO As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select NROARCHIVO From carterosmail Where CODIGO='" & CARTERO & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado

    End Function
    Public Shared Function ObtenerMails(ByVal CARTERO As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select MAIL From carterosmail Where CODIGO='" & CARTERO & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado

    End Function
    Public Shared Function BuscarContra(ByVal NroSocio As String) As String
        Try
            Dim DTRef As New DataTable
            Dim sqlNumero As String = "Select NRO_CART2, ESTADOF from cartastr2 where NRO_CART2 LIKE '%" & NroSocio & "%'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlNumero, cn)
            Dim CMRef As New MySqlCommand(sqlNumero, cn)
            Dim DaRef As New MySqlDataAdapter(CMRef)
            DaRef.Fill(DTRef)
            cn.Close()

            For Each Drw As DataRow In DTRef.Rows
                If Drw("ESTADOF").ToString = "ENTREGADA" Then
                    Return "ENTREGADA"
                ElseIf Drw("ESTADOF").ToString = "ENT_COD13" Then
                    Return "ENT_COD13"
                Else

                End If

            Next

        Catch ex As Exception

        End Try



    End Function
    Public Shared Function ObtenerTextoMails(ByVal CARTERO As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select TEXTOMAIL From carterosmail Where CODIGO='" & CARTERO & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado

    End Function
    Public Shared Function ObtenerRutaDBF() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select OtroDato From configuracion Where Operacion='RUTA_DBF'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim Ruta As String
        cn.Open()
        Ruta = cm.ExecuteScalar
        cn.Close()
        Return Ruta

    End Function
    Public Shared Function ObtenerRutaEscaneo() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Otrodato From configuracion Where operacion='RUTA_ESCANEO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerRutaEscaneoLectura() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Otrodato From configuracion Where operacion='RUTA_ESCANEO_LECTURA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerRutaDeArchivos(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select RutaCompleta From escaneocontrol Where Nro_Planilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerRutaDeArchivosConArchivos(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select RutaCompleta From escaneocontrol Where Nro_Planilla='" & planilla & "' and estado='CON_ARCHIVOS'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerCantArch() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Otrodato From configuracion Where operacion='CANTIDAD_ESCANEO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function ObtenerRutaArchivosScaner() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Otrodato From configuracion Where operacion='RUTA_ARCHIVOS_SCANER'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function ObtenerPlanillaLibre(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Estado From escaneocontrol Where Nro_Planilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        If Len(resultado) > 0 Then
            Return resultado
        Else
            Return ""

        End If



    End Function
    Public Shared Function ObtenerCantidadArchivosPlanillaLibre(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Cantidad From escaneocontrol Where Nro_Planilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function ObtenerUltimaFechaImpo() As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Otrodato From configuracion Where operacion='FECHA_ULTIMA_IMPORTACION'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function VerificarEstadoUltimaPlanilla(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Estado From escaneocontrol Where Nro_Planilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function ObtenerCalleCartaEscaneo(ByVal Carta As String) As String
        'Try
        Dim sqlNumero As String = "Select Estado From cartas Where NRO_CARTA='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado

        'Catch ex As Exception
        '    Return "No_encontrado"
        'End Try

    End Function
    Public Shared Function ObtenerCalleCartaEscaneoPorNroCart2(ByVal Carta As String) As String
        'Try
        Dim sqlNumero As String = "Select NRO_CARTA From cartas Where NRO_CART2='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado

        'Catch ex As Exception
        '    Return "No_encontrado"
        'End Try

    End Function

    Public Shared Function ObtenerEstadoScan(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Estado From escaneocontrol Where Nro_Planilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()

        Return resultado


    End Function
    Public Shared Function ObtenerRutaPorCarta(ByVal Carta As String, ByVal año As String) As String
        Dim ruta As String = ""

        Dim DT As New DataTable
        Dim sql As String = "Select * From escaneocartas Where NroCartaLeido='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "escaneocartas")
        cn.Close()
        DT = ds.Tables("escaneocartas")
        For Each DRW As DataRow In DT.Rows
            If año = ConvertAño(DRW("FECHA_ESCANEO").ToString) Then
                ruta = DRW("ruta_archivo").ToString
            End If
        Next

        Return ruta
    End Function
    Public Shared Function ObtenerNroCart2ID(ByVal NroId As Integer) As String

        Dim sqlNumero As String = "Select Nro_cart2 From cartastr2 Where ID=" & NroId & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado

    End Function
    Public Shared Function VerificarSiFueVisitada(ByVal Socio As String, ByVal Lote As String) As String
        'a
        Dim Sql As String = "Select fech1 from visitadas Where socio='" & Socio & "' And Lote LIKE '%" & Lote.TrimStart("0") & "%'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return resultado
        Else
            Return ""
        End If

    End Function
    Public Shared Function ObtenerFechaEntregadaEnRecorrido(ByVal nrocarta As String) As String
        'a
        Dim Sql As String = "Select FechaF from recorridos Where nro_carta='" & nrocarta & "' and estado='ENTREGADA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()

        Dim value As Object = cmconsult.ExecuteScalar()
        cn.Close()
        If IsDBNull(value) Then
            Return ""
        Else
            Return Convert.ToString(value)
        End If


    End Function
    Public Shared Function ObtenerPrimeraVisitaEnRecorrido(ByVal nrocarta As String) As String
        'a
        Dim Sql As String = "Select FECHA_RECORRIDO from recorridos Where nro_carta='" & nrocarta & "' and recorrido=1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado

    End Function
    Public Shared Function Normalizar2(ByVal Dato As String) As String

        Dato = Dato.Replace("(", "")
        Dato = Dato.Replace(")", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("12:00:00 a.m.", "")
        Dato = Dato.Replace("12:0-00-12", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace("- ", "")
        Return Dato
    End Function
    Public Shared Function Normalizar3(ByVal Dato As String) As String

        Dato = Dato.Replace(" ", "")
        Dato = Dato.Replace("-", "")
        Return Dato
    End Function
    Public Shared Function UnificarEstado(ByVal Dato As String) As String
        Dato = Dato.Replace("DEVO_SUC", "DEVOLUCION")
        Dato = Dato.Replace("ESCANEADO", "ENTREGADA")
        Dato = Dato.Replace("CONF.ENTRE", "ENTREGADA")
        Dato = Dato.Replace("ENTR_SUCU", "ENTREGADA")
        Dato = Dato.Replace("ENTREGADA", "ENTREGADA")
        Return Dato
    End Function
    Public Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("(", "")
        Dato = Dato.Replace(")", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Dato = Dato.Replace("12:00:00 a.m.", "")

        Return Dato

    End Function
    Public Shared Function ObtenerClientePorRemitente(ByVal remitente As String) As String
        Dim Fechasql As String = "Select cliente from remitentes Where remitente='" & remitente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(Fechasql, cn)
        Dim Servi As String
        cn.Open()
        Servi = CmFecha.ExecuteScalar
        cn.Close()
        Return Servi
    End Function
    Public Shared Function ObtenerMailCartero(ByVal Cartero As String) As String
        Dim Fechasql As String = "Select mail from carterosmail Where codigo='" & Cartero & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(Fechasql, cn)
        Dim Servi As String
        cn.Open()
        Servi = CmFecha.ExecuteScalar
        cn.Close()
        Return Servi
    End Function
    Public Shared Function ObtenerServicio(ByVal Remito As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select Servicio From remitos Where Nro_Remito='" & Remito & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado
    End Function
    Public Shared Function VerificarRecorridoPorCarta(ByVal NRO_CARTA As String) As String
        'SELECT * FROM Tabla 
        Dim sql As String = "Select PLANILLA_RECORRIDO from recorridos where NRO_CARTA='" & NRO_CARTA & "' AND estado='EN_DISTRIBUCION' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado

    End Function
    Public Shared Function ObtenerFechaEnVisitadas(ByVal nrocarta As String) As String
        'a
        Dim Sql As String = "Select fech1 from visitadas Where nro_carta='" & nrocarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado

    End Function
    'mysql boolean
    Public Shared Function InsertarRecorridosplanillas(ByVal fecharecorrido As String, ByVal nroplanilla As String, ByVal zona As String, ByVal cantidad As String, ByVal cartero As String, ByVal servicio As String)
        Dim sqlinsert As String = "INSERT INTO recorridospl (fecharecorrido, nroplanilla, zona, cantidad, cartero, estado, servicio) VALUES (" & "'" & Converfecha(fecharecorrido) & "', '" & nroplanilla & "', '" & zona & "', '" & cantidad & "', " & "'" & cartero & "', '" & "EN_DISTRIBUCION" & "', '" & servicio & "')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function InsertarRemitente(ByVal Cliente As String, ByVal remitente As String) As Boolean
        Try
            Dim SQLINSERT As String = "insert into remitentes (CLIENTE, REMITENTE) values ('" & Cliente & "', '" & remitente & "')"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Shared Function InsertarRemito(ByVal Cliente As String, ByVal TipoRemitente As String, ByVal Fecha_Retiro As String, ByVal Nro_Remito As String, ByVal Servicio As String, ByVal Fecha_ingreso As String) As Boolean
        Dim sqlinsert As String = "INSERT INTO remitos (Cliente, TipoRemitente, Fecha_Retiro, Nro_Remito, Servicio, Estado, Fecha_ingreso, Cantidad) VALUES (" & "'" & Cliente & "'" & ", " & "'" & TipoRemitente & "'" & ", " & Fecha_Retiro & ", " & "'" & Nro_Remito & "', '" & Servicio & "', " & "'PENDIENTE' , " & Fecha_ingreso & ", '0'" & ")"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function RemitoYaingreso(ByVal Remito As String, ByVal Servicio As String) As Boolean
        Dim sqlcondultaingreso As String = "SELECT Nro_remito FROM remitos WHERE Nro_remito ='" & Remito & "'" & " AND TipoRemitente ='" & Servicio & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlcondultaingreso, cn)
        Dim ResutRemito As String
        cn.Open()
        ResutRemito = cm.ExecuteScalar
        cn.Close()
        If Len(ResutRemito) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function EliminarRemito(ByVal Remito As String, ByVal Servicio As String) As String
        Try
            Dim sqlr As String = "DELETE FROM remitos WHERE Nro_remito='" & Remito & "'" & " AND TipoRemitente='" & Servicio & "'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlr, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return "OK"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function
    Public Shared Function InstertarCARTAS(ByVal BUCLE As String) As Boolean

        Using tx3 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into cartas (NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, ESTADO, NRO_CART2, EMPRESA, SOCIO, AÑO, OBS, OBS2, OBS3, OBS4) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx3.Complete()
            Return True
        End Using

    End Function


    Public Shared Function InsertarRegistroCartas(ByVal nroCarta As String, ByVal remitente As String, ByVal trabajo As String, ByVal fechTrab As Date, ByVal apellido As String, ByVal cp As String, ByVal calle As String, ByVal pisoDepto As String, ByVal localidad As String, ByVal provincia As String, ByVal nroCart2 As String, ByVal empresa As String, ByVal socio As String, ByVal obs As String, ByVal obs2 As String, ByVal obs3 As String, ByVal obs4 As String) As Boolean
        Dim estado As String = "ESPERA_IMPRESION"
        Dim año As Integer = DateTime.Now.Year

        Dim fechaTrabajo As String = fechTrab.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ' Formato de fecha para MySQL

        Dim sql As String = "INSERT INTO cartas (NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, ESTADO, NRO_CART2, EMPRESA, SOCIO, AÑO, OBS, OBS2, OBS3, OBS4) VALUES (@nroCarta, @remitente, @trabajo, @fechTrab, @apellido, @cp, @calle, @nro, @pisoDepto, @localidad, @provincia, @estado, @nroCart2, @empresa, @socio, @año, @obs, @obs2, @obs3, @obs4)"


        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cm As New MySqlCommand(sql, cn)
                cm.Parameters.AddWithValue("@nroCarta", nroCarta)
                cm.Parameters.AddWithValue("@remitente", remitente)
                cm.Parameters.AddWithValue("@trabajo", trabajo)
                cm.Parameters.AddWithValue("@fechTrab", fechaTrabajo) ' Uso de la fecha formateada
                cm.Parameters.AddWithValue("@apellido", apellido)
                cm.Parameters.AddWithValue("@cp", cp)
                cm.Parameters.AddWithValue("@calle", calle)
                cm.Parameters.AddWithValue("@nro", "")
                cm.Parameters.AddWithValue("@pisoDepto", pisoDepto)
                cm.Parameters.AddWithValue("@localidad", localidad)
                cm.Parameters.AddWithValue("@provincia", provincia)
                cm.Parameters.AddWithValue("@estado", estado)
                cm.Parameters.AddWithValue("@nroCart2", nroCart2)
                cm.Parameters.AddWithValue("@empresa", empresa)
                cm.Parameters.AddWithValue("@socio", socio)
                cm.Parameters.AddWithValue("@año", año)
                cm.Parameters.AddWithValue("@obs", obs)
                cm.Parameters.AddWithValue("@obs2", obs2)
                cm.Parameters.AddWithValue("@obs3", obs3)
                cm.Parameters.AddWithValue("@obs4", obs4)

                cn.Open()
                Dim rowsAffected As Integer = cm.ExecuteNonQuery()
                cn.Close()

                Return rowsAffected > 0
            End Using
        End Using
    End Function


    Public Shared Function ActualizarNroCarta(ByVal NroCarta As String) As Boolean
        'Cargar insert sql
        'Try
        Dim sqlCarta As String = "UPDATE configuracion SET Desde='" & NroCarta & "'" & " Where Operacion='NRO_CARTA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
        Return True

        'Catch ex As Exception
        '    Return False
        'End Try


    End Function
    Public Shared Function IngresarCartero(ByVal idCarteros As String, ByVal Nombre As String, ByVal Apellido As String, ByVal TipoDocumento As String, ByVal NroDocumento As String, ByVal Direccion As String, ByVal Cp As String, ByVal Localidad As String, ByVal Provincia As String, ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal FechaIngreso As String, ByVal Vehiculo As String, ByVal Tipo As String, ByVal Marca As String, ByVal Patente As String, ByVal Gps As String, ByVal Nombre_Propietario As String, ByVal Direccion_Propietario As String, ByVal Telefono_Propietario As String, ByVal Email_Propietario As String, ByVal Fecha_Baja As String) As Boolean
        Dim sqlinsert As String = "INSERT INTO carteros (idCarteros, Nombre, Apellido, TipoDocumento, NroDocumento, Direccion, Cp, Localidad, Provincia, Telefono, Celular, Email, FechaIngreso, Vehiculo, Tipo, Marca, Patente, Gps, Nombre_Propietario, Direccion_Propietario, Telefono_Propietario, Email_Propietario, Baja, Fecha_Baja) VALUES (" _
        & "'" & idCarteros & "'" & ", " _
        & "'" & Nombre & "'" & ", " _
        & "'" & Apellido & "'" & ", " _
        & "'" & TipoDocumento & "'" & ", " _
        & "'" & NroDocumento & "'" & ", " _
        & "'" & Direccion & "'" & ", " _
        & "'" & Cp & "'" & ", " _
        & "'" & Localidad & "'" & ", " _
        & "'" & Provincia & "'" & ", " _
        & "'" & Telefono & "'" & ", " _
        & "'" & Celular & "'" & ", " _
        & "'" & Email & "'" & ", " _
        & "'" & FechaIngreso & "'" & ", " _
        & "'" & Vehiculo & "'" & ", " _
        & "'" & Tipo & "'" & ", " _
        & "'" & Marca & "'" & ", " _
        & "'" & Patente & "'" & ", " _
        & "'" & Gps & "'" & ", " _
        & "'" & Nombre_Propietario & "'" & ", " _
        & "'" & Direccion_Propietario & "'" & ", " _
        & "'" & Telefono_Propietario & "'" & ", " _
        & "'" & Email_Propietario & "'" & ", " _
        & "'NO'" & ", " _
        & "'" & Fecha_Baja & "'" & ")"


        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarNroPlanillarecorrido(ByVal NroActual As String) As Boolean
        'Cargar insert sql
        Dim sqlNumero As String = "UPDATE configuracion SET Desde='" & NroActual + 1 & "'" & " Where Operacion='NRO_PLANILLA_RECO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function
    Public Shared Function ActualizarNroPlanillaConfirmacionAcuse(ByVal NroActual As String) As Boolean
        'Cargar insert sql
        Dim sqlNumero As String = "UPDATE configuracion SET Desde='" & NroActual + 1 & "'" & " Where Operacion='NRO_PLANILLA_CONF_ACUSE'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function


    Public Shared Function VerificarSiEstaCreadoElMotivo(ByVal ident As Integer) As Boolean
        Dim Sql As String = "Select id from motivos Where id=" & ident & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteNonQuery()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function


    Public Shared Function Crearindice() As Boolean
        Dim con As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim comando As New MySqlCommand("CrearIndice", con)
        comando.CommandType = CommandType.StoredProcedure
        con.Open()
        comando.ExecuteNonQuery()
        con.Close()
    End Function
    Public Shared Function Eliminarindice() As Boolean
        Dim con As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim comando As New MySqlCommand("EliminarIndice", con)
        comando.CommandType = CommandType.StoredProcedure
        con.Open()
        comando.ExecuteNonQuery()
        con.Close()
    End Function
    Public Shared Function CrearArchivo() As Boolean
        Dim sql As String = "Select * from Cartas"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim D_reader As MySqlDataReader
        Dim sw As New StreamWriter("c:\c.txt")

        cn.Open()
        D_reader = cm.ExecuteReader()
        sw.Write("NRO_CARTA" & ";" & "REMITENTE" & ";" & "TRABAJO" & ";" & "FECH_TRAB" & ";" & "NOMBRE_APELLIDO" & ";" & "CP" & ";" & "CALLE" & ";" & "LOCALIDAD" & ";" & "PROVINCIA" & ";" & "ESTADO" & ";" & "NRO_PLANILLA" & ";" & "FECHA_PLANILLA" & ";" & "CARTERO" & ";" & "FECHA_ENTREGA" & ";" & "ACUSE" & ";" & "FECHA1" & ";" & "PLANILLA1" & ";" & "TEMA1" & ";" & "CARTERO1" & ";" & "FECHA2" & ";" & "PLANILLA2" & ";" & "TEMA2" & ";" & "CARTERO2" & ";" & "FECHA3" & ";" & "PLANILLA3" & ";" & "TEMA3" & ";" & "CARTERO3" & ";" & "MOTIVO" & ";" & "FECHA_DEVOLUCION" & ";" & "PLANILLA_DEVOLUCION" & ";" & "DEVOLUCION_ACUSE" & ";" & "FECHA_DEVO_ACUSE" & ";" & "NRO_ORDEN" & ";" & "REMINOM" & ";" & "RECIBIO" & ";" & "TIPO_DOC" & ";" & "DOCUMENTO" & ";" & "OBS" & ";" & "D_ENTRY" & ";" & "ZONA" & ";" & "EMPRESA" & ";" & "NRO_CARTA2" & ";" & "SERVICIO" & ";" & "PRECIO" & ";" & "F_LIMITE" & ";" & "SOCIO" & ";" & "AUDITORIA" & ";" & "PLANILLA_AUDITORIA" & ";" & "ARTICULO" & ";" & "VALOR" & ";" & "COBRAR" & ";" & "LAT_IZQ" & ";" & "LAT_DER" & ";" & "MOTIVO_ANT" & ";" & "FECHA_MOT_ANT" & ";" & "ERR" & ";" & "OBS2" & ";" & "OBS3" & ";" & "OBS4" & ";" & "FECHA_IMPORTACION" & ";" & "CAMPO_MODIFICADO" & ";" & "MODIFICACION")
        sw.Write(sw.NewLine)
        Dim Ncol As Integer = D_reader.FieldCount - 1
        Dim Nro As Integer = 1
        While D_reader.Read
            sw.WriteLine(D_reader("NRO_CARTA") & ";" & D_reader("REMITENTE") & ";" & D_reader("TRABAJO") & ";" & D_reader("FECH_TRAB") & ";" & D_reader("NOMBRE_APELLIDO") & ";" & D_reader("CP") & ";" & D_reader("CALLE") & ";" & D_reader("LOCALIDAD") & ";" & D_reader("PROVINCIA") & ";" & D_reader("ESTADO") & ";" & D_reader("NRO_PLANILLA") & ";" & D_reader("FECHA_PLANILLA") & ";" & D_reader("CARTERO") & ";" & D_reader("FECHA_ENTREGA") & ";" & D_reader("ACUSE") & ";" & D_reader("FECHA1") & ";" & D_reader("PLANILLA1") & ";" & D_reader("TEMA1") & ";" & D_reader("CARTERO1") & ";" & D_reader("FECHA2") & ";" & D_reader("PLANILLA2") & ";" & D_reader("TEMA2") & ";" & D_reader("CARTERO2") & ";" & D_reader("FECHA3") & ";" & D_reader("PLANILLA3") & ";" & D_reader("TEMA3") & ";" & D_reader("CARTERO3") & ";" & D_reader("MOTIVO") & ";" & D_reader("FECHA_DEVOLUCION") & ";" & D_reader("PLANILLA_DEVOLUCION") & ";" & D_reader("DEVOLUCION_ACUSE") & ";" & D_reader("FECHA_DEVO_ACUSE") & ";" & D_reader("NRO_ORDEN") & ";" & D_reader("REMINOM") & ";" & D_reader("RECIBIO") & ";" & D_reader("TIPO_DOC") & ";" & D_reader("DOCUMENTO") & ";" & D_reader("OBS") & ";" & D_reader("D_ENTRY") & ";" & D_reader("ZONA") & ";" & D_reader("EMPRESA") & ";" & D_reader("NRO_CARTA2") & ";" & D_reader("SERVICIO") & ";" & D_reader("PRECIO") & ";" & D_reader("F_LIMITE") & ";" & D_reader("SOCIO") & ";" & D_reader("AUDITORIA") & ";" & D_reader("PLANILLA_AUDITORIA") & ";" & D_reader("ARTICULO") & ";" & D_reader("VALOR") & ";" & D_reader("COBRAR") & ";" & D_reader("LAT_IZQ") & ";" & D_reader("LAT_DER") & ";" & D_reader("MOTIVO_ANT") & ";" & D_reader("FECHA_MOT_ANT") & ";" & D_reader("ERR") & ";" & D_reader("OBS2") & ";" & D_reader("OBS3") & ";" & D_reader("OBS4") & ";" & D_reader("FECHA_IMPORTACION") & ";" & D_reader("CAMPO_MODIFICADO") & ";" & D_reader("MODIFICACION"))
            Nro = Nro + 1
        End While
        sw.Close()

    End Function
    Public Shared Function Verificaringtemp(ByVal NroCarta As String) As Boolean
        Dim Sql As String = "Select NRO_CARTA from tempcartas Where NRO_CARTA='" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteNonQuery()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Shared Function AgregarABasetemporalMysql(ByVal NRO_CARTA As String, ByVal REMITENTE As String, ByVal TRABAJO As String, ByVal FECH_TRAB As String, ByVal NOMBRE As String, ByVal APELLIDO As String, ByVal CALLE As String, ByVal CP As String, ByVal PISO_DEPTO As String, ByVal LOCALIDAD As String, ByVal PROVINCIA As String, ByVal ESTADO As String, ByVal FECHA_ENTR As String, ByVal CARTERO As String, ByVal NRO_PLANIL As String, ByVal FECH_PLANI As String, ByVal FECH1 As String, ByVal TEMA1 As String, ByVal FECH2 As String, ByVal TEMA2 As String, ByVal FECH3 As String, ByVal TEMA3 As String, ByVal FECH4 As String, ByVal TEMA4 As String, ByVal FECH_DEVO As String, ByVal DEVO_PLANI As String, ByVal EMPRESA As String, ByVal NRO_CART2 As String, ByVal MOTIVO_ANT As String, ByVal VINCULO As String, ByVal TRAMITE As String) As Boolean

        Dim TXTFECH_TRAB As String = "0000-00-00"
        Dim TXTFECHA_ENTR As String = "0000-00-00"
        Dim TXTFECH_PLANI As String = "0000-00-00"
        Dim TXTFECH1 As String = "0000-00-00"
        Dim TXTFECH2 As String = "0000-00-00"
        Dim TXTFECH3 As String = "0000-00-00"
        Dim TXTFECH4 As String = "0000-00-00"
        Dim TXTFECH_DEVO As String = "0000-00-00"


        If FECH_TRAB = "" Then
        Else
            TXTFECH_TRAB = Converfecha(FECH_TRAB)
        End If
        If FECHA_ENTR = "" Then
        Else
            TXTFECHA_ENTR = Converfecha(FECHA_ENTR)
        End If
        If FECH_PLANI = "" Then
        Else
            TXTFECH_PLANI = Converfecha(FECH_PLANI)
        End If
        If FECH1 = "" Then
        Else
            TXTFECH1 = Converfecha(FECH1)
        End If
        If FECH2 = "" Then
        Else
            TXTFECH2 = Converfecha(FECH2)
        End If
        If FECH3 = "" Then
        Else
            TXTFECH3 = Converfecha(FECH3)
        End If
        If FECH4 = "" Then
        Else
            TXTFECH4 = Converfecha(FECH4)
        End If
        If FECH_DEVO = "" Then
        Else
            TXTFECH_DEVO = Converfecha(FECH_DEVO)
        End If


        NOMBRE = Replace(NOMBRE, "'", "")
        APELLIDO = Replace(APELLIDO, "'", "")
        CALLE = Replace(CALLE, "'", "")
        LOCALIDAD = Replace(LOCALIDAD, "'", "")
        EMPRESA = Replace(EMPRESA, "'", "")
        NRO_CART2 = Replace(NRO_CART2, "'", "")


        NOMBRE = Replace(NOMBRE, ",", ",")
        APELLIDO = Replace(APELLIDO, ",", ".")
        CALLE = Replace(CALLE, ",", ".")
        LOCALIDAD = Replace(LOCALIDAD, ",", ".")
        EMPRESA = Replace(EMPRESA, ",", ".")
        NRO_CART2 = Replace(NRO_CART2, ",", ".")

        Dim SqlInsert As String

        SqlInsert = "INSERT INTO tempcartas (NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, NOMBRE, APELLIDO, CALLE, CP, PISO_DEPTO, LOCALIDAD, ESTADO, FECHA_ENTR, CARTERO,NRO_PLANIL, FECH_PLANI, FECH1, TEMA1, FECH2, TEMA2, FECH3, TEMA3, FECH4, TEMA4, FECH_DEVO, DEVO_PLANI, EMPRESA, NRO_CART2, MOTIVO_ANT, VINCULO, TRAMITE) VALUES (" _
        & "'" & NRO_CARTA & "'" & ", " _
        & "'" & REMITENTE & "'" & ", " _
        & "'" & TRABAJO & "'" & ", " _
        & "'" & TXTFECH_TRAB & "'" & ", " _
        & "'" & NOMBRE & "'" & ", " _
        & "'" & APELLIDO & "'" & ", " _
        & "'" & CALLE & "'" & ", " _
        & "'" & CP & "'" & ", " _
        & "'" & PISO_DEPTO & "'" & ", " _
        & "'" & LOCALIDAD & "'" & ", " _
        & "'" & ESTADO & "'" & ", " _
        & "'" & TXTFECHA_ENTR & "'" & ", " _
        & "'" & CARTERO & "'" & ", " _
        & "'" & NRO_PLANIL & "'" & ", " _
        & "'" & TXTFECH_PLANI & "'" & ", " _
        & "'" & TXTFECH1 & "'" & ", " _
        & "'" & TEMA1 & "'" & ", " _
        & "'" & TXTFECH2 & "'" & ", " _
        & "'" & TEMA2 & "'" & ", " _
        & "'" & TXTFECH3 & "'" & ", " _
        & "'" & TEMA3 & "'" & ", " _
        & "'" & TXTFECH4 & "'" & ", " _
        & "'" & TEMA4 & "'" & ", " _
        & "'" & TXTFECH_DEVO & "'" & ", " _
        & "'" & DEVO_PLANI & "'" & ", " _
        & "'" & EMPRESA & "'" & ", " _
        & "'" & NRO_CART2 & "'" & ", " _
        & "'" & MOTIVO_ANT & "'" & ", " _
        & "'" & VINCULO & "'" & ", " _
        & "'" & TRAMITE & "'" & ")"

        Dim cnbasetemp As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cminsert As New MySqlCommand(SqlInsert, cnbasetemp)
        cnbasetemp.Open()
        cminsert.ExecuteNonQuery()
        cnbasetemp.Close()

    End Function
    Public Shared Function Loaddatainfile(ByVal Ruta As String) As Boolean

        'Dim Str As String = "LOAD DATA LOCAL INFILE '" & Ruta & "'INTO TABLE tempcartas FIELDS TERMINATED BY ';' OPTIONALLY ENCLOSED BY '' LINES TERMINATED BY '\n' IGNORE 1 LINES"

        Dim CN As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim loader As New MySqlBulkLoader(CN)
        loader.Timeout = 10 * 60
        loader.TableName = "tempcartas"
        loader.FieldTerminator = ";"
        loader.FileName = Ruta
        loader.Local = True
        loader.LineTerminator = "\r\n"

        'loader.NumberOfLinesToSkip = 0
        loader.Load()


    End Function
    Public Shared Function InstertarRegistroTRANSITO(ByVal BUCLE As String) As Boolean

        Using tx2 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into cartastr (NRO_CARTA, REMITENTE, FECH_TRAB, APELLIDO, CALLE, CP, LOCALIDAD, PROVINCIA, FECHA_ENTR, NRO_PLANIL, FECH_PLANI, ESTADO, CARTERO, TEMA4, FECH4, NRO_CART2, SOCIOLOTE, MOTIVO_ANT, TRAMITE, EMPRESA) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx2.Complete()
            Return True
        End Using

    End Function
    Public Shared Function InstertarRegistroCARTAS(ByVal BUCLE As String) As Boolean

        Using tx2 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into cartas (NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, NOMBRE_APELLIDO, CP, CALLE, OBS2, OBS3, LOCALIDAD, PROVINCIA, ESTADO, NRO_PLANILLA, FECHA_PLANILLA, CARTERO, FECHA_ENTREGA, FECHA1, PLANILLA1, TEMA1, CARTERO1, FECHA2, PLANILLA2, TEMA2, CARTERO2, FECHA3, PLANILLA3, TEMA3, CARTERO3, MOTIVO, FECHA_DEVOLUCION, NRO_CARTA2, EMPRESA) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx2.Complete()
            Return True
        End Using

    End Function
    Public Shared Function ActualizarFechaBaseTR(ByVal Fecha As String) As Boolean

        Dim sqlNumero As String = "UPDATE cartasfechatr2 SET fecha='" & Fecha & "'" & " Where Dato='FECHABASE'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function ActualizarFechaImportCarta(ByVal Fecha As String) As Boolean

        Dim sqlNumero As String = "UPDATE configuracion SET otrodato='" & Fecha & "'" & " Where Operacion='FECHA_ULTIMA_IMPORTACION'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function InstertarRegistroTR_ANALIZADO(ByVal BUCLE As String) As Boolean

        Using tx2 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into cartastr2 (NRO_CARTA, REMITENTE, FECH_TRAB, APELLIDO, CALLE, CP, LOCALIDAD, PROVINCIA, FECHA_ENTR, NRO_PLANIL, FECH_PLANI, ESTADO, CARTERO, TEMA4, FECH4, NRO_CART2, FECHA_ULT_ESTADO, DENO_ESTADO, ESTADOF, MOTIVOF, FECHAF, ARCHIVO, FECHA_REGISTRO) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=160")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx2.Complete()
            Return True
        End Using
    End Function
    Public Shared Function Eliminardatostablatemporal() As Boolean

        Try
            Dim sql As String = "DELETE FROM cartastr"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sql, cn)

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Shared Function VerificarFeriado(ByVal dia As String) As Boolean
        Dim Sql As String = "Select dia from criteriostrferiados Where dia='" & dia & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Shared Function InsertarFeriado(ByVal detalle As String, ByVal dia As String) As Boolean
        Try
            If VerificarFeriado(dia) = False Then
                Dim sqlinsert As String = "INSERT INTO criteriostrferiados (Detalle, dia) VALUES (" & "'" & detalle & "'" & ", " & "'" & dia & "')"
                Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
                Dim cm As New MySqlCommand(sqlinsert, cn)

                cn.Open()
                cm.ExecuteNonQuery()
                cn.Close()
                Return True
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function Verificar_ING_ARCH(ByVal ARCHIVO As String) As Boolean
        Dim Sql As String = "Select ARCHIVO from cartastr2 Where ARCHIVO='" & ARCHIVO & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Shared Function ActualizarNroVisitada(ByVal NUMERO As Integer) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE configuracion SET desde='" & NUMERO & "'" & " Where operacion='NRO_VISITADAS'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarNroPlaniDevo(ByVal NUMERO As Integer) As Boolean
        Try
            'NRO_PLANILLA_ESCANER
            'Cargar insert sql
            Dim sqlCarta As String = "UPDATE configuracion SET desde='" & NUMERO & "'" & " Where operacion='NRO_PLANILLA_DEVO'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlCarta, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Shared Function ActualizarNroRemitoConfig(ByVal NUMERO As Integer) As Boolean
        Try
            'NRO_PLANILLA_ESCANER
            'Cargar insert sql
            Dim sqlCarta As String = "UPDATE configuracion SET desde='" & NUMERO & "'" & " Where operacion='NUMEROORDENDERETIRO'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlCarta, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Shared Function ActualizarNroPlaniEscaner(ByVal NUMERO As Integer) As Boolean
        Try
            'NRO_PLANILLA_ESCANER
            'Cargar insert sql
            Dim sqlCarta As String = "UPDATE configuracion SET desde='" & NUMERO & "'" & " Where operacion='NRO_PLANILLA_ESCANER'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlCarta, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function

    Public Shared Function InstertarVisitadas(ByVal BUCLE As String) As Boolean

        Using tx3 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into visitadas (socio, lote, integrante, fech_trab, apellido, calle, cp, localidad, fech1, tema1, fech2, tema2, nro_carta, remitente, NroRendicion, FechaRendicion) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx3.Complete()
            Return True
        End Using

    End Function
    Public Shared Function InstertarEntregada(ByVal BUCLE As String) As Boolean

        Using tx3 As New TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5))

            Dim SQLINSERT As String = "insert into entregadas (socio, lote, integrante, fech_trab, apellido, calle, cp, localidad, fech1, tema1, fech2, tema2, fecha_entr, nro_carta, remitente, NroRendicion, FechaRendicion) values " & BUCLE
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Connection Timeout=60")
            Dim cm As New MySqlCommand(SQLINSERT, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            tx3.Complete()
            Return True
        End Using

    End Function
    Public Shared Function ActualizarNroPendiente(ByVal CARTERO As String, ByVal NUMERO As String) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE carterosmail SET NROARCHIVO='" & NUMERO & "'" & " Where CODIGO='" & CARTERO & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function VerificarVisitadaEnElDiario(ByVal nro_carta As String) As Boolean
        Dim Sql As String = "Select nro_carta from visitadas Where nro_carta='" & nro_carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function BuscarPorNrosocioDtTransito() As DataTable

        Dim FechaD As Date = Now
        Dim FechaA As Date = Now
        FechaD = FechaD.AddDays(-60)
        Dim FD As String = Converfecha(FechaD.ToShortDateString)
        Dim FA As String = Converfecha(FechaA.ToShortDateString)


        Dim DTRef As New DataTable
        Dim sqlNumero As String = "Select NRO_CARTA, ESTADOF from cartastr2 where FECH_TRAB between '" & FD & "' and " & "'" & FA & "' and estadof<>'EN_PROCESO' OR estadof<>'EN_RENDICION'"
        Dim cn As New MySqlConnection(CadenaDeConeccionAnterior & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartastr2")
        cn.Close()
        Dim Dt As New DataTable

        Dt = ds.Tables("cartastr2")

        Return Dt
    End Function
    Public Shared Function BuscarPorNrosocioDtTransitoEntregadas() As DataTable

        Dim FechaD As Date = Now
        Dim FechaA As Date = Now
        FechaD = FechaD.AddDays(-60)
        Dim FD As String = Converfecha(FechaD.ToShortDateString)
        Dim FA As String = Converfecha(FechaA.ToShortDateString)


        Dim DTRef As New DataTable
        Dim sql As String = "Select NRO_CARTA, ESTADOF from cartastr2 where FECH_TRAB between '" & FD & "' and " & "'" & FA & "' and (estadof<>'EN_PROCESO' or estadof<>'EN_RENDICION')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        cn.Open()
        DaRef.Fill(DTRef)
        cn.Close()
        MsgBox(DTRef.Rows.Count)

        Return DTRef


    End Function

    Public Shared Function ObtenerRemitosLexs() As DataTable
        Dim sqlSelect As String = "SELECT NroRemito, DATE_FORMAT(Fecha, '%d/%m/%Y') AS FechaFormateada FROM remitoslexs ORDER BY Fecha DESC"


        Dim dataTable As New DataTable()

        Using connection As New MySqlConnection(CadenaDeConeccionProduccion)
            Using command As New MySqlCommand(sqlSelect, connection)
                connection.Open()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    Public Shared Sub InsertarRemitoLexs(nroRemito As String, remitente As String, fecha As String, archivoBytes As Byte(), estado As String)
        Dim sqlInsert As String = "INSERT INTO remitoslexs (NroRemito, Remitente, Fecha, Archivo, Estado) VALUES (@NroRemito, @Remitente, @Fecha, @Archivo, @Estado)"

        Using connection As New MySqlConnection(CadenaDeConeccionProduccion)
            Using command As New MySqlCommand(sqlInsert, connection)
                command.Parameters.AddWithValue("@NroRemito", nroRemito)
                command.Parameters.AddWithValue("@Remitente", remitente)
                command.Parameters.AddWithValue("@Fecha", fecha)
                command.Parameters.AddWithValue("@Archivo", archivoBytes)
                command.Parameters.AddWithValue("@Estado", estado)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function ObtenerArchivosPorNroRemito(nroRemito As String) As List(Of Byte())
        Dim archivos As New List(Of Byte())

        Dim sqlSelect As String = "SELECT Archivo FROM remitoslexs WHERE NroRemito = @NroRemito"
        Using connection As New MySqlConnection(CadenaDeConeccionProduccion)
            Using command As New MySqlCommand(sqlSelect, connection)
                command.Parameters.AddWithValue("@NroRemito", nroRemito)

                connection.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim archivoBytes As Byte() = DirectCast(reader("Archivo"), Byte())
                        archivos.Add(archivoBytes)
                    End While
                End Using
            End Using
        End Using

        Return archivos
    End Function

    Public Shared Function VerifiVisitadaRECRED(ByVal NroCarta As String) As Boolean
        Dim Sql As String = "Select nro_carta from visitadas Where nro_carta='" & NroCarta & "' and Remitente='SWRECR'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Shared Function InsertarPlanillaEscaneo(ByVal Fecha2 As String, ByVal Nro_Planilla2 As String, ByVal Cantidad2 As String, ByVal Ruta As String) As Boolean
        Dim sqlinsert As String = "INSERT INTO escaneocontrol (Fecha, Nro_Planilla, Cantidad, Estado, RutaCompleta) VALUES ('" & Fecha2 & "', '" & Nro_Planilla2 & "', '" & Cantidad2 & "', 'SIN_ARCHIVOS', ' " & Ruta & " ')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarPlanillaSinArchivos(ByVal Planilla As String) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE escaneocontrol SET Estado='CON_ARCHIVOS'" & " Where Nro_Planilla='" & Planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarRutaCompleta(ByVal Planilla As String, ByVal Ruta As String) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE escaneocontrol SET RutaCompleta='" & Ruta & "'" & " Where Nro_Planilla='" & Planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function InsertarCartaLeida(ByVal NroCartaLeido As String, ByVal Estado As String, ByVal Fecha_Entrega As String, ByVal Fecha_Escaneo As String, ByVal Ruta_Archivo As String, ByVal planilla As String) As Boolean
        Ruta_Archivo = Ruta_Archivo.Replace("\", "\\")

        Dim sqlinsert As String = "INSERT INTO escaneocartas (NroCartaLeido, Estado, Fecha_Entrega, Fecha_Escaneo, Ruta_Archivo, planilla) VALUES ('" & NroCartaLeido & "', '" & Estado & "', '" & Fecha_Entrega & "', '" & Fecha_Escaneo & "', '" & Ruta_Archivo & "', '" & planilla & " ')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarEstadoEscaneoControl(ByVal Planilla As String) As Boolean
        'Cargar insert sql
        Dim sqlCarta As String = "UPDATE escaneocontrol SET Estado='ESCANEADO' where Nro_Planilla='" & Planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarCartaInformado(ByVal NroCartaLeido As String) As Boolean

        Dim sqlCarta As String = "UPDATE escaneocartas SET ESTADO='Entregada_xls'" & " Where NroCartaLeido='" & NroCartaLeido & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function EliminarPlanillaEscaneo(ByVal NroPlanilla As String) As Boolean

        Try
            Dim sqlr As String = "DELETE FROM escaneocontrol WHERE Nro_Planilla='" & NroPlanilla & "'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlr, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function ActualizarNroCart2ID(ByVal Socio As String, ByVal Id As Integer) As Boolean

        Dim sqlCarta As String = "UPDATE cartastr2 SET Socio='" & Socio & "' Where ID=" & Id & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function VerificarSiFueEntregadaEnDiarioParaDiario(ByVal NroCarta As String) As Boolean


        Dim Sql As String = "Select socio from entregadas Where nro_carta='" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function VerificarSiFueEntregadaEnTransitoParaDiario(ByVal Socio As String, ByVal Lote As String) As Boolean


        Dim Sql As String = "Select socio from cartastr2 Where SOCIO='" & Socio & "' And NRO_CART2 LIKE '%" & Lote & "%'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Shared Function Obteneractualizarplanillas() As Boolean
        'Where fech_trab between '" & fechaantes & "' and " & "'" & fechadespues & "'"
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM escaneocartas"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "escaneocartas")
        cn.Close()
        dt = CrearDatatable()

        For Each drw As DataRow In ds.Tables("escaneocartas").Rows
            Dim planilla As String = drw("Ruta_Archivo").ToString

            planilla = planilla.Substring(22, 6)
            ActualizarplanillaescaneoID(planilla, drw("id").ToString)
        Next


    End Function
    Public Shared Function ActualizarplanillaescaneoID(ByVal planilla As String, ByVal Id As Integer) As Boolean

        Dim sqlCarta As String = "UPDATE escaneocartas SET planilla='" & planilla & "' Where ID=" & Id & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarCartaPorId(ByVal NRO_CART2 As String, ByVal APELLIDO As String, ByVal CALLE As String, ByVal CP As String, ByVal LOCALIDAD As String, ByVal PROVINCIA As String, ByVal EMPRESA As String, ByVal SOCIO As String, ByVal OBS As String, ByVal OBS2 As String, ByVal OBS3 As String, ByVal OBS4 As String, ByVal Id As String) As Boolean
        Try
            Dim sqlCarta As String = "UPDATE cartas SET NRO_CART2 ='" & NRO_CART2 & "', APELLIDO='" & APELLIDO & "', CALLE='" & CALLE & "', CP='" & CP & "', LOCALIDAD='" & LOCALIDAD & "', PROVINCIA='" & PROVINCIA & "', EMPRESA='" & EMPRESA & "', SOCIO='" & SOCIO & "', OBS='" & OBS & "', OBS2='" & OBS2 & "', OBS3='" & OBS3 & "', OBS4='" & OBS4 & "' Where ID=" & Id & ""
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlCarta, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function BuscarCartaPorNroCarta(ByVal NRO_CARTA As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select * from cartas where NRO_CARTA='" & NRO_CARTA & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function InsertarPlanillaDevo(ByVal Fecha_plani As String, ByVal Plani_devo As String, ByVal cantidad As Integer, ByVal usuario As String) As Boolean
        Try
            Dim sqlinsert As String = "INSERT INTO devueltaspl (Fecha_plani, Plani_devo, cantidad, usuario) VALUES ('" _
                                       & Converfecha(Fecha_plani) & "', '" & Plani_devo & "', '" & cantidad & "', '" & usuario & "')"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlinsert, cn)

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Shared Function InsertarDevolucionDetalle(ByVal asociado As String, ByVal lote As String, ByVal integrante As String, ByVal fech_trab As String, ByVal tema1 As String, ByVal fecha1 As String, ByVal tema2 As String, ByVal fecha2 As String, ByVal motivo_devo As String, ByVal fech_devo As String, ByVal devo_plani As String, ByVal apellido As String, ByVal calle As String, ByVal cp As String, ByVal localidad As String, ByVal nro_carta As String) As Boolean

        Dim sqlCheck As String = "SELECT COUNT(*) FROM devueltas WHERE devo_plani = @devo_plani AND nro_carta = @nro_carta"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmCheck As New MySqlCommand(sqlCheck, cn)
        cmCheck.Parameters.AddWithValue("@devo_plani", devo_plani)
        cmCheck.Parameters.AddWithValue("@nro_carta", nro_carta)

        Dim count As Integer = 0

        Try
            cn.Open()
            count = Convert.ToInt32(cmCheck.ExecuteScalar())
            If count > 0 Then
                Return False ' Si ya existe el nro_carta para la misma devo_plani, devolvemos False
            End If
        Catch ex As Exception
            ' Manejar la excepción si ocurre alguna
            Return False ' Devolver False en caso de error
        Finally
            cn.Close()
        End Try

        Dim sqlInsert As String = "INSERT INTO devueltas (asociado, lote, integrante, fech_trab, tema1, fecha1, tema2, fecha2, motivo_devo, fech_devo, devo_plani, apellido, calle, cp, localidad, nro_carta) VALUES ('" & asociado & "', '" & lote & "', '" & integrante & "', '" & fech_trab & "', '" & tema1 & "', '" & fecha1 & "', '" & tema2 & "', '" & fecha2 & "', '" & motivo_devo & "', '" & fech_devo & "', '" & devo_plani & "', '" & apellido & "', '" & Trim(calle) & "', '" & cp & "', '" & localidad & "', '" & nro_carta & "')"
        Dim cmInsert As New MySqlCommand(sqlInsert, cn)

        Try
            cn.Open()
            cmInsert.ExecuteNonQuery()
            Return True ' Si la inserción se realizó con éxito, devolvemos True
        Catch ex As Exception
            ' Manejar la excepción si ocurre alguna
            Return False ' Devolver False en caso de error
        Finally
            cn.Close()
        End Try
    End Function



    Public Shared Function NumeroCartaYaIngresadoEnDevolucion(ByVal nro_carta As String) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM devueltas WHERE nro_carta = @nro_carta"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cm.Parameters.AddWithValue("@nro_carta", nro_carta)

        Dim count As Integer = 0

        cn.Open()
        count = Convert.ToInt32(cm.ExecuteScalar())
        cn.Close()


        If count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Shared Function ActualizarCantidadEnPlanillaDeDevolucion(ByVal NroPlanilla As String) As Boolean
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim sql As String = "UPDATE devueltaspl SET cantidad = cantidad + 1 WHERE Plani_devo = @NroPlanilla"
        Dim cm As New MySqlCommand(sql, cn)
        cm.Parameters.AddWithValue("@NroPlanilla", NroPlanilla)

        Try
            cn.Open()
            cm.ExecuteNonQuery()
            Return True ' Si la actualización se realizó con éxito, devolvemos True
        Catch ex As Exception
            ' Manejar la excepción si ocurre alguna
            Return False ' Devolver False en caso de error
        Finally
            cn.Close()
        End Try
    End Function



    Public Shared Function ActualizarNroPlanillaDevolucion(ByVal NroActual As String) As Boolean
        'Cargar insert sql
        Dim sqlNumero As String = "UPDATE configuracion SET Desde='" & NroActual + 1 & "'" & " Where Operacion='NRO_PLANILLA_DEVO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function
    Public Shared Function ActualizarEstadoDevolucion(ByVal nro_carta As String) As Boolean

        Dim sql As String = "UPDATE cartas SET ESTADO='DEVUELTA' WHERE NRO_CARTA='" & nro_carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
        ActualizarEstadoEnRecorridoParaDevolucion(nro_carta)

    End Function
    Private Shared Function ActualizarEstadoEnRecorridoParaDevolucion(ByVal nro_carta As String) As Boolean

        Dim sql As String = "UPDATE recorridos SET ESTADO='DEVUELTA' WHERE NRO_CARTA='" & nro_carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function



    Public Shared Function BuscarCartaPorNroCart2(ByVal NRO_CART2 As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select * from cartas where NRO_CART2='" & NRO_CART2 & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function EliminarCartaDePlanillaDevolucion(ByVal NroCarta As String) As Boolean

        Try
            Dim sqlr As String = "DELETE FROM devueltas WHERE nro_carta='" & NroCarta & "'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlr, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function VerificarCartaEnDevolucion(ByVal NroCarta As String) As Boolean
        Dim Sql As String = "Select nro_carta from devueltas Where nro_carta='" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Shared Function InsertarAvisoDeVisita(ByVal calle As String, ByVal cp As String, ByVal localidad As String, ByVal provincia As String, ByVal obs As String, ByVal nro_carta As String, ByVal fecha As Date) As Boolean


        Dim sqlinsert As String = "INSERT INTO avisos ( calle, cp, localidad, provincia, obs,  nro_carta, fecha) VALUES ('" _
                                  & Trim(calle) & "', '" & cp & "', '" & Normalizar(localidad) & "', '" & Normalizar(provincia) & "', '" & Normalizar(obs) & "', '" & nro_carta & "', '" & Converfecha(fecha.ToShortDateString) & "')"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlinsert, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
        Return True

    End Function
    Public Shared Function EliminarCartaDeRecorridoPorCartaYPlanilla(ByVal NroCarta As String, ByVal Planilla As String) As Boolean

        Try
            Dim sqlr As String = "DELETE FROM recorridos WHERE NRO_CARTA='" & NroCarta & "' And PLANILLA_RECORRIDO='" & Planilla & "'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlr, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()

            DescontarDePlanilla(Planilla)

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Shared Function DescontarDePlanilla(ByVal Planilla As String) As Boolean

        Try

            Dim sqlr As String = "UPDATE recorridospl SET cantidad = cantidad - 1 where nroplanilla = '" & Planilla & "'"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sqlr, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Shared Function AgregarUnoAPlanilla(ByVal Planilla As Integer) As Boolean


        Dim sqlr As String = "UPDATE recorridospl SET cantidad = cantidad + 1 where nroplanilla =" & Planilla & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlr, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()


    End Function


    'mysql datatble

    Public Shared Function ConsultaZonalesParaImportacionyAsignacion(ByVal cp As String) As String
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim sql As String = "SELECT nombreetiqueta FROM asignaciones WHERE cp = '" & cp & "'"

        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        Dim result As Object = cm.ExecuteScalar()
        cn.Close()

        If result IsNot Nothing Then
            Return result.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Public Shared Function ConsultaAsignacionSeprit(ByVal cp As String) As String
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim sql As String = "SELECT Item FROM asignaciones_seprit WHERE cp = '" & cp & "'"

        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        Dim result As Object = cm.ExecuteScalar()
        cn.Close()

        If result IsNot Nothing Then
            Return result.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Public Shared Function CargarRemitosPendientes() As DataTable
        Dim sql As String = "Select TipoRemitente, Nro_Remito, Fecha_Retiro, Cliente, Servicio from remitos where Estado='PENDIENTE'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtServ As New DataTable
        cn.Open()
        da.Fill(ds, "remitos")
        cn.Close()
        DtServ = ds.Tables("remitos")
        Return DtServ
    End Function
    Public Shared Function LlenarDatatableImprimir(ByVal Remito As String) As DataTable

        Dim sql As String = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, NRO_CART2, EMPRESA, SOCIO, OBS, OBS2, OBS3, OBS4 from cartas where TRABAJO='" & Remito & "' AND OBS2<>'ARM' AND OBS2<>'MODO S' AND OBS2<>'REFEREN'"


        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtCartasImprimir As New DataTable
        cn.Open()
        da.Fill(ds, "remitos")
        cn.Close()
        DtCartasImprimir = ds.Tables("remitos")
        Return DtCartasImprimir


    End Function
    Public Shared Function LlenarDatatableImprimirSoloModoS(ByVal Remito As String) As DataTable

        Dim sql As String = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, NRO_CART2, EMPRESA, SOCIO, OBS, OBS2, OBS3, OBS4 from cartas where TRABAJO='" & Remito & "' AND OBS2='MODO S'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtCartasImprimir As New DataTable
        cn.Open()
        da.Fill(ds, "remitos")
        cn.Close()
        DtCartasImprimir = ds.Tables("remitos")
        Return DtCartasImprimir


    End Function

    Public Shared Function LlenarDatatableImprimirSoloReferenciado(ByVal Remito As String) As DataTable

        Dim sql As String = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, NRO_CART2, EMPRESA, SOCIO, OBS, OBS2, OBS3, OBS4 from cartas where TRABAJO='" & Remito & "' AND OBS2='REFEREN'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtCartasImprimir As New DataTable
        cn.Open()
        da.Fill(ds, "remitos")
        cn.Close()
        DtCartasImprimir = ds.Tables("remitos")
        Return DtCartasImprimir


    End Function

    Public Shared Function LlenarDatatableImprimirArm(ByVal Remito As String) As DataTable

        Dim sql As String = "SELECT COUNT(CALLE) AS CANTIDAD, TRABAJO, EMPRESA, CALLE, CP, LOCALIDAD, PROVINCIA " &
                        "FROM cartas " &
                        "WHERE TRABAJO='" & Remito & "' AND OBS2='ARM' " &
                        "GROUP BY EMPRESA, CALLE, CP, LOCALIDAD, PROVINCIA " &
                        "ORDER BY EMPRESA, CALLE"


        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtCartasImprimir As New DataTable
        cn.Open()
        da.Fill(ds, "ARM")
        cn.Close()
        DtCartasImprimir = ds.Tables("ARM")

        Return DtCartasImprimir
    End Function


    Public Shared Function LlenarDatatableImprimirArmPorEmpresaYCalle(ByVal Empresa As String, ByVal Calle As String, ByVal Remito As Integer) As DataTable

        Dim sql As String = "SELECT NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CALLE, NRO, PISO_DEPTO, CP, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CART2, SOCIO, OBS, OBS2, OBS3, OBS4 FROM cartas " &
        "WHERE TRABAJO='" & Remito & "' AND EMPRESA='" & Empresa & " ' AND CALLE='" & Calle & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtCartasImprimir As New DataTable
        cn.Open()
        da.Fill(ds, "ARM")
        cn.Close()
        DtCartasImprimir = ds.Tables("ARM")

        Return DtCartasImprimir
    End Function

    Public Shared Function ConsultaCompleja(ByVal Consulta As String) As DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim DtResultado As New DataTable
        Dim sql As String = Consulta

        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(DtResultado)
        cn.Close()

        Return DtResultado

    End Function
    Public Shared Function ConsultarUndato(ByVal idconsultado As Integer) As DataTable

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim DtCartas As New DataTable
        Dim sql As String = "Select * from cartas where id=" & idconsultado & ""
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        cn.Open()
        da.Fill(DtCartas)
        cn.Close()

        Return DtCartas
    End Function
    Public Shared Function Buscarpornrodecarta(ByVal NRO_CARTA As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select ID, NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CART2 from cartas where NRO_CARTA='" & NRO_CARTA & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function Buscarpornrodearm(ByVal arm As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CP, CALLE, NRO, PISO_DEPTO, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CART2, ARM from armdetalle where arm='" & arm & "' ORDER by NRO_CARTA DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable

        cn.Open()
        da.Fill(Dt)
        cn.Close()

        Return Dt
    End Function
    Public Shared Function Buscarporarmenplanilla(ByVal arm As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select * from armplanilla where Numeroarm=" & arm
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()


    End Function


    Public Shared Function BuscarpornrodecartaParaPlanillado(ByVal NRO_CARTA As String) As DataTable
        'SELECT * FROM Tabla 
        Dim sql As String = "Select * from cartas where NRO_CARTA='" & NRO_CARTA & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function CrearDTdeExcel(ByVal Ruta As String, ByVal NombreHoja As String) As DataTable
        Dim Dt As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Ruta + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(Dt)
        mconn.Close()
        Return Dt

    End Function
    Private Shared Function ObtenerPorNrocarta(ByVal NRO_CARTA As String) As DataTable
        Dim sql As String = "Select * from cartastr where NRO_CARTA = '" & NRO_CARTA & "'"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartastr")
        cn.Close()

        dt = ds.Tables("cartastr")
        Return dt

    End Function
    Public Shared Function ObtenerMAXIMA(ByVal Socio As String, ByVal lote As String) As DataTable
        'Try
        'ORDER BY id DESC LIMIT 1
        Dim dt As New DataTable
        Dim dt2 As New DataTable

        Dim sql As String = "SELECT * FROM cartas where SOCIO = '" & Socio & "'" & " AND NRO_CART2 LIKE '%" & lote & "%' ORDER BY id DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cm.CommandTimeout = 0
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = ds.Tables("cartas")
        Dim OK As Integer
        For Each drw As DataRow In dt.Rows
            If drw("Nro_cart2").ToString.Contains(lote) Then
                OK = 1
            Else
                OK = 0
            End If
        Next
        If OK = 1 Then
            Return dt
        Else

            Dim sql2 As String = "SELECT * FROM cartas where SOCIO = '" & Socio.TrimStart("0") & "'" & " AND NRO_CART2 LIKE '%" & lote & "%' ORDER BY id DESC LIMIT 1"
            Dim cn2 As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
            Dim cm2 As New MySqlCommand(sql2, cn2)
            Dim da2 As New MySqlDataAdapter(cm2)
            Dim ds2 As New DataSet
            cm2.CommandTimeout = 0
            cn2.Open()
            da2.Fill(ds2, "cartas")
            cn2.Close()
            dt2 = ds2.Tables("cartas")

            Return dt2
        End If



    End Function


    Public Shared Function ObtenerTodosLosDatosUltimos240Dias() As Dictionary(Of String, String)
        Dim resultados As New Dictionary(Of String, String)()

        Try
            Dim fechaDesde As Date = Date.Now.AddDays(-240)
            Dim fechaHasta As Date = Date.Now
            Dim fechaDesdetxt As String = fechaDesde.ToString("yyyy-MM-dd")
            Dim fechaHastatxt As String = fechaHasta.ToString("yyyy-MM-dd")

            Dim sql As String = "SELECT NRO_CART2, CONCAT(Nro_carta, ';', REMITENTE, ';', FECH_TRAB, ';', APELLIDO, ';', CALLE, ';', CP, ';', PISO_DEPTO, ';', LOCALIDAD, ';', PROVINCIA, ';', ESTADO, ';', OBS2, ';', NRO_CART2) FROM cartas WHERE FECH_TRAB BETWEEN '" & fechaDesdetxt & "' AND '" & fechaHastatxt & "' AND remitente='SWISSC'"

            Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
                cn.Open()
                Using cm As New MySqlCommand(sql, cn)
                    Using reader As MySqlDataReader = cm.ExecuteReader()
                        While reader.Read()
                            Dim nroCart2 As String = reader.GetString(0)
                            Dim concatenatedData As String = reader.GetString(1)

                            If resultados.ContainsKey(nroCart2) Then
                                ' La clave ya existe, actualizar los datos
                                resultados(nroCart2) = concatenatedData
                            Else
                                ' La clave no existe, agregar una nueva entrada
                                resultados.Add(nroCart2, concatenatedData)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción aquí o imprimir un mensaje de error
        End Try

        Return resultados
    End Function



    Public Shared Function ObtenerMotivoDevoDeCorreoProduccion(ByVal Carta As String) As String
        Dim Sql As String = "Select Motivo_devo from devueltas Where nro_carta='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado
    End Function

    Public Shared Function ObtenerCarteroDeCorreoProduccion(ByVal Carta As String) As String
        Dim Sql As String = "Select cartero from recorridos Where nro_carta='" & Carta & "'  ORDER BY ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerFechaDevoDeCorreoProduccion(ByVal Carta As String) As String
        Dim Sql As String = "Select Fech_devo from devueltas Where nro_carta='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerEstadoenRecorrido(ByVal Carta As String) As String
        Dim Sql As String = "Select estado from recorridos Where nro_carta='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerEstadoenPlanilladas(ByVal Carta As String) As String
        Dim Sql As String = "Select estado from planillado Where nro_carta='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado
    End Function
    Public Shared Function ObtenerEstadoenentregadas(ByVal Carta As String) As String
        Dim Sql As String = "Select NroRendicion from entregadas Where nro_carta='" & Carta & "' ORDER by identregadas DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 1 Then

            Return "ENTREGADA"

        End If

    End Function

    Public Shared Function ObtenerEstadoenVisitadas(ByVal Carta As String) As String
        Dim Sql As String = "Select NroRendicion from visitadas Where nro_carta='" & Carta & "' ORDER by idVisitadas DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 1 Then

            Return "VISITADAS"

        End If

    End Function
    Public Shared Function ObtenerEstadoenTransito(ByVal Carta As String) As String
        Dim Sql As String = "Select estadof from cartastr2 Where nro_carta='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        Return resultado


    End Function

    Public Shared Function ObtenerCRITERIOS(ByVal Estado As String) As DataTable
        Dim sql As String = "Select * from criteriostr Where estado = '" & Estado & "'"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "criteriostr")
        cn.Close()
        dt = ds.Tables("criteriostr")
        Return dt

    End Function
    Public Shared Function ObtenerPendeintesPorCartero(ByVal Cartero As String) As DataTable

        '***   condiciones para carteros choferes sin limite de dias

        Dim fechahasta As Date = Now.ToShortDateString

        If VerificarLimite(Cartero) = "SI" Then
            fechahasta = fechahasta.AddDays(-10)
            fechahasta = fechahasta.ToShortDateString
        Else
            fechahasta = fechahasta.ToShortDateString
        End If


        Dim txd As String
        Dim txh As String


        Dim FechaDesde As Date = Now.ToShortDateString
        FechaDesde = FechaDesde.AddDays(-90)
        FechaDesde = FechaDesde.ToShortDateString
        txd = Converfecha(FechaDesde)
        txh = Converfecha(fechahasta)

        '    
        Dim sql As String = "SELECT nro_carta, fecha_trabajo, remitente, nombre_apellido, calle, cp, localidad, provincia, planilla_recorrido, fecha_recorrido FROM recorridos WHERE Cartero='" & Cartero & "' AND ESTADO= 'EN_DISTRIBUCION' AND fecha_recorrido between '" & txd & "' and '" & txh & "'"

        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = ds.Tables("cartas")
        dt.Columns.Add("Obs2")

        For Each dr As DataRow In dt.Rows
            dr("Obs2") = ObtenerObs2(dr("nro_carta"))
        Next




        Return dt

    End Function
    Public Shared Function ObtenerObs2(ByVal Nrocarta As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select OBS2 From cartas Where nro_carta='" & Nrocarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim resultado As String
        cn.Open()
        resultado = cm.ExecuteScalar
        cn.Close()
        Return resultado

    End Function
    Public Shared Function BuscarRecorridopornrodecartaParaConsultaGeneral(ByVal NRO_CARTA As String) As DataTable
        'SELECT * FROM Tabla ENTRE_SUCU
        Dim sql As String = "Select NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, RECORRIDO, FECHAF, ESTADO, MOTIVO from RECORRIDOS where NRO_CARTA='" & NRO_CARTA & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function ObtenerTransitoPorFechas(ByVal FechaDesde As String, ByVal FechaHasta As String) As DataTable

        Dim sql As String = "SELECT * FROM cartastr2 WHERE FECH_TRAB between '" & Converfecha(FechaDesde) & "' and " & "'" & Converfecha(FechaHasta) & "'"

        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionAnterior)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartastr2")
        cn.Close()
        dt = ds.Tables("cartastr2")

        Return dt

    End Function


    Public Shared Function ObtenerFeriados() As DataTable
        Dim sql As String = "Select detalle, dia from criteriostrferiados"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "criteriostrferiados")
        cn.Close()

        dt = ds.Tables("criteriostrferiados")
        Return dt

    End Function

    Public Shared Function Obtenerfitrocaba() As DataTable
        Dim sql As String = "SELECT * from fitrocaba"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "fitrocaba")
        cn.Close()

        dt = ds.Tables("fitrocaba")
        Return dt
    End Function


    Public Shared Function ObtenerVisitadas(ByVal Fecha As String) As DataTable
        Dim fechahasta As Date = Now.ToShortDateString
        fechahasta = fechahasta.AddDays(-5)

        Dim fecha1 As String = Converfecha(fechahasta)


        Dim sql As String = "SELECT * FROM CARTAS WHERE ESTADO='EN_DISTRIBUCION' OR ESTADO='ESP_PROG' AND FECH_TRAB between '" & Fecha & "' and " & "'" & fecha1 & "' and empresa =''"

        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "CARTAS")
        cn.Close()
        dt = ds.Tables("CARTAS")

        '******************************************************************

        Dim ArrayCalleRepetidos As New ArrayList
        Dim ArrayCalleRepetidosCartas As New ArrayList
        Dim ArrayRepetidosCartas As New ArrayList

        For Each drw As DataRow In dt.Rows
            If ArrayCalleRepetidos.Contains(drw("calle").ToString) Then

                ArrayRepetidosCartas.Add(drw("Nro_carta").ToString)
            Else
                ArrayCalleRepetidos.Add(drw("calle").ToString)

            End If
        Next

        Dim dt2 As New DataTable

        dt2.Columns.Add("nro_cart2")
        dt2.Columns.Add("fecha_trabajo")
        dt2.Columns.Add("apellido")
        dt2.Columns.Add("calle")
        dt2.Columns.Add("cp")
        dt2.Columns.Add("localidad")
        dt2.Columns.Add("remitente")
        dt2.Columns.Add("nro_carta")



        For Each drw2 As DataRow In dt.Rows
            If Not ArrayRepetidosCartas.Contains(drw2("Nro_Carta").ToString) Then
                dt2.Rows.Add(drw2("nro_cart2"), drw2("fech_trab"), drw2("apellido"), drw2("calle"), drw2("cp"), drw2("localidad"), drw2("remitente"), drw2("nro_carta"))

            End If
        Next

        '***********************************************************


        Return dt2

    End Function
    Public Shared Function ObtenerVisitadasSwrecr() As DataTable


        Dim sql As String = "SELECT nro_cart2, fech_trab, apellido, calle, cp, localidad, remitente, nro_carta FROM cartastr WHERE ESTADO= 'Distrib.' AND REMITENTE='SWRECR'"


        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartastr")
        cn.Close()
        dt = ds.Tables("cartastr")

        Return dt

    End Function
    Public Shared Function ObtenerEntregadas(ByVal Fecha As String) As DataTable

        Dim fecha1 As Date = Now.ToShortDateString
        Dim fecha3 As String
        fecha3 = Converfecha(fecha1)

        Dim sql As String = "SELECT nro_carta, fech_trab, apellido, calle, cp, localidad, remitente, nro_cart2, estado FROM cartas WHERE (ESTADO='ENTREGADA' OR ESTADO='ENTRE_SUCU' OR ESTADO='ESCANEADO' OR ESTADO='CONFIRMADO' OR ESTADO='PLANILLADA') AND fech_trab between '" & Fecha & "' and " & "'" & fecha3 & "' AND REMITENTE<>'SWEMPF' AND REMITENTE<>'SWRECR'"


        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = ds.Tables("cartas")

        Return dt

    End Function
    Public Shared Function ObtenerEntregadasRemitente() As DataTable



        Dim FechaDesdeEntreg As Date = Now.ToShortDateString
        FechaDesdeEntreg = FechaDesdeEntreg.AddDays(-180)
        FechaDesdeEntreg = FechaDesdeEntreg.ToShortDateString
        Dim fecha As String = Converfecha(FechaDesdeEntreg)


        Dim fecha1 As Date = Now.ToShortDateString
        Dim fecha3 As String
        fecha3 = Converfecha(fecha1)

        Dim sql As String = "SELECT nro_cart2, fech_trab, apellido, calle, cp, localidad, remitente, nro_carta, estado, fecha_entr FROM cartas WHERE (ESTADO='ENTREGADA' OR ESTADO='CONF.ENTRE' OR ESTADO='ESCANEADO' OR ESTADO='ENTR_SUCU' OR ESTADO='CONFIRMADO') AND REMITENTE='SWRECR'" & " AND fech_trab between '" & fecha & "' and " & "'" & fecha3 & "' "


        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True;Connect Timeout=100")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = ds.Tables("cartas")

        Return dt

    End Function
    Public Shared Function ObtenerMailClientes(ByVal Cliente As String) As DataTable
        Dim DTCliente As New DataTable
        Dim sql As String = "Select email from clientesmail where Cliente='" & Cliente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(DTCliente)
        cn.Close()
        Return DTCliente

    End Function
    Public Shared Function ObtenerMailCarteros(ByVal Dato As String) As DataTable
        Dim DTCliente As New DataTable
        Dim sql As String = "Select MAIL from carterosmail where Codigo='" & Dato & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(DTCliente)
        cn.Close()
        Return DTCliente

    End Function
    Public Shared Function BuscarPorNrosocio(ByVal NroSocio As String) As DataTable
        Dim DTRef As New DataTable
        Dim sqlNumero As String = "Select NRO_CART2, ESTADOF, MOTIVOF, FECHAF, ARCHIVO, FECHA_REGISTRO from cartastr2 where NRO_CART2 LIKE '%" & NroSocio & "%'"
        Dim cn As New MySqlConnection(CadenaDeConeccionAnterior)
        Dim cm As New MySqlCommand(sqlNumero, cn)

        Dim CMRef As New MySqlCommand(sqlNumero, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(DTRef)
        cn.Close()
        Return DTRef
    End Function
    Public Shared Function ConsultarEscaneo() As DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim DtCartas As New DataTable
        Dim sql As String = "Select NroCartaLeido, Estado, Fecha_Entrega, Ruta_Archivo from escaneocartas where Estado='Entregada'"

        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        cn.Open()
        da.Fill(DtCartas)
        cn.Close()

        Return DtCartas
    End Function
    Public Shared Function ObtenerRutas() As DataTable
        Dim sql As String = "Select ID, Ruta_Archivo from escaneocartas"
        Dim dt As New DataTable
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "escaneocartas")
        cn.Close()
        dt = ds.Tables("escaneocartas")
        Return dt

    End Function
    Public Shared Function CrearDatatable() As DataTable

        Dim DTNew As New DataTable

        DTNew.Columns.Add("NRO_CARTA")
        DTNew.Columns.Add("REMITENTE")
        DTNew.Columns.Add("TRABAJO")
        DTNew.Columns.Add("FECH_TRAB")
        DTNew.Columns.Add("APELLIDO")
        DTNew.Columns.Add("CP")
        DTNew.Columns.Add("CALLE")
        DTNew.Columns.Add("NRO")
        DTNew.Columns.Add("PISO_DEPTO")
        DTNew.Columns.Add("LOCALIDAD")
        DTNew.Columns.Add("PROVINCIA")
        DTNew.Columns.Add("ESTADO")
        DTNew.Columns.Add("NRO_PLANIL")
        DTNew.Columns.Add("FECH_PLANI")
        DTNew.Columns.Add("CARTERO")
        DTNew.Columns.Add("FECHA_ENTR")
        DTNew.Columns.Add("FECH1")
        DTNew.Columns.Add("PLANILLA1")
        DTNew.Columns.Add("TEMA1")
        DTNew.Columns.Add("CARTERO1")
        DTNew.Columns.Add("FECH2")
        DTNew.Columns.Add("PLANILLA2")
        DTNew.Columns.Add("TEMA2")
        DTNew.Columns.Add("CARTERO2")
        DTNew.Columns.Add("FECH3")
        DTNew.Columns.Add("PLANILLA3")
        DTNew.Columns.Add("TEMA3")
        DTNew.Columns.Add("CARTERO3")
        DTNew.Columns.Add("TEMA4")
        DTNew.Columns.Add("FECH4")
        DTNew.Columns.Add("NRO_CART2")
        DTNew.Columns.Add("EMPRESA")
        DTNew.Columns.Add("SOCIO")
        DTNew.Columns.Add("AÑO")

        Return DTNew

    End Function
    Public Shared Function ObtenerInformeMensual(ByVal fecha1 As String, ByVal fecha2 As String) As DataTable
        Dim fechaantes As String
        Dim fechadespues As String

        fechaantes = Converfecha(fecha1)
        fechadespues = Converfecha(fecha2)
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM cartas Where fech_trab between '" & fechaantes & "' and " & "'" & fechadespues & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = CrearDatatable()

        For Each drw As DataRow In ds.Tables("cartas").Rows
            Dim lote As String = drw("NRO_CART2")
            If Len(lote) > 15 Then
                lote = lote.Substring(8, 7)
            End If
            Dim FechaEntr As String = VerificarSiFueEntregadaEnDiario(drw("socio"), lote.TrimStart("0"))
            'Dim fechatransito As String = VerificarSiFueEntregadaEnTransito(drw("socio"), lote.TrimStart("0"), drw("nro_carta"))
            Dim fechafinal As String = drw("FECHA_ENTR")

            If Len(FechaEntr) > 0 Then
                fechafinal = FechaEntr
            End If

            dt.Rows.Add(drw("NRO_CARTA"), drw("REMITENTE"), drw("TRABAJO"), Normalizar2(drw("FECH_TRAB")), drw("APELLIDO"), drw("CP"), drw("CALLE"), drw("NRO"), drw("PISO_DEPTO"), drw("LOCALIDAD"), drw("PROVINCIA"),
                        UnificarEstado(drw("ESTADO")), drw("NRO_PLANIL"), Normalizar2(drw("FECH_PLANI")), drw("CARTERO"), Normalizar2(fechafinal), Normalizar2(drw("FECH1")), drw("PLANILLA1"), drw("TEMA1"), drw("CARTERO1"), Normalizar2(drw("FECH2")), drw("PLANILLA2"), drw("TEMA2"), drw("CARTERO2"),
                        Normalizar2(drw("FECH3")), drw("PLANILLA3"), drw("TEMA3"), drw("CARTERO3"), drw("TEMA4"), Normalizar2(drw("FECH4")), drw("NRO_CART2"), drw("EMPRESA"), drw("SOCIO"))
        Next

        Return dt

    End Function
    Public Shared Function ObtenerCarteros(ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable

        Dim fechaantes As String
        Dim fechadespues As String
        fechaantes = Converfecha(Fecha1)
        fechadespues = Converfecha(Fecha2)
        Dim dt As New DataTable
        Dim sql As String = "SELECT DISTINCT CARTERO FROM cartas Where fech_trab between '" & fechaantes & "' and " & "'" & fechadespues & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=True")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "cartas")
        cn.Close()
        dt = ds.Tables("cartas")

        Return dt
    End Function
    Public Shared Function BuscarRecorridopornrodecarta(ByVal NRO_CARTA As String) As DataTable
        'SELECT * FROM Tabla ENTRE_SUCU
        Dim sql As String = "Select ID, IDENTIFICADOR, NRO_CARTA, PLANILLA_RECORRIDO, CARTERO, NRO_CARTA2 from RECORRIDOS where NRO_CARTA='" & NRO_CARTA & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function ConsultarRecorridos(ByVal Planilla As String) As DataTable
        Dim sql As String = "Select nro_carta, remitente, calle, localidad, cp from recorridos where PLANILLA_RECORRIDO='" & Planilla & "'"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        Dim DtServ As New DataTable
        cn.Open()
        da.Fill(ds, "recorridos")
        cn.Close()
        DtServ = ds.Tables("recorridos")
        Return DtServ
    End Function
    Public Shared Function ObtenerRecorridosPorCarta(ByVal Carta As Integer) As DataTable
        Dim Dtrecorridos As New DataTable


        Dim sql As String = "Select ESTADO, MOTIVO, FECHAF, FECHA_RECORRIDO, PLANILLA_RECORRIDO, CARTERO, ZONA, RECORRIDO from recorridos where Nro_carta=" & Carta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function
    Public Shared Function ObtenerNroPLanillaYFechaPorCarta(ByVal NroCarta As String) As DataTable
        Dim Dtrecorridos As New DataTable
        Dim sql As String = "Select nro_planilla, fecha_planilla from planillado where Nro_carta=" & NroCarta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function
    Public Shared Function ObtenerArm(ByVal NroCarta As String) As DataTable
        Dim Dtrecorridos As New DataTable
        Dim sql As String = "Select nro_planilla, fecha_planilla from planillado where Nro_carta=" & NroCarta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function

    Public Shared Function ObtenerDevueltasPorCarta(ByVal Carta As Integer) As DataTable


        Dim Dtrecorridos As New DataTable
        Dim sql As String = "Select MOTIVO_DEVO, FECH_DEVO, DEVO_PLANI from devueltas where NRO_CARTA='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()


        Dim DtRecFinal As New DataTable
        DtRecFinal.Columns.Add("ESTADO")
        DtRecFinal.Columns.Add("MOTIVO_DEVO")
        DtRecFinal.Columns.Add("FECH_DEVO")
        DtRecFinal.Columns.Add("DEVO_PLANI")


        For Each drw As DataRow In Dtrecorridos.Rows
            Dim Fecha As Date = drw("FECH_DEVO").ToString
            DtRecFinal.Rows.Add("DEVUELTA", drw("MOTIVO_DEVO").ToString, Fecha.ToShortDateString, drw("DEVO_PLANI").ToString)
        Next

        Return DtRecFinal



    End Function
    Public Shared Function BuscarPorNroCartaImpresion(ByVal NroCarta As String) As DataTable

        Dim sql As String = "Select * FROM CARTAS where NRO_CARTA = '" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function
    Public Shared Function ConsultarDevueltas(ByVal Nroplanilla As String) As DataTable

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim DtCartas As New DataTable
        Dim sql As String = "Select * from devueltas where devo_plani='" & Nroplanilla & "'"

        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        cn.Open()
        da.Fill(DtCartas)
        cn.Close()

        Return DtCartas

    End Function
    Public Shared Function ObtenerAvisoDeVisita(ByVal Carta As Integer) As DataTable
        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select * from avisos where nro_carta='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function
    Public Shared Function ObtenerAvisoDeVisitaPorFecha(ByVal Fecha As String) As DataTable
        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select * from avisos where fecha='" & Converfecha(Fecha) & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function
    Public Shared Function ObtenerVisitadasParaConsultaDeUnDato(ByVal Carta As Integer) As DataTable


        Dim DtRecFinal As New DataTable
        DtRecFinal.Columns.Add("INFORME")
        DtRecFinal.Columns.Add("FECHA")
        DtRecFinal.Columns.Add("RENDICION")
        DtRecFinal.Columns.Add("FECHA_RENDICION")

        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select fech1, NroRendicion, FechaRendicion from visitadas where NRO_CARTA='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        cn.Open()
        DaRef.Fill(Dtrecorridos)
        cn.Close()

        For Each drw As DataRow In Dtrecorridos.Rows
            DtRecFinal.Rows.Add("VISITADAS", drw("fech1").ToString, drw("NroRendicion").ToString, drw("FechaRendicion").ToString)
        Next

        Return DtRecFinal

    End Function
    Public Shared Function ObtenerEntregadasParaConsultaDeUnDato(ByVal Carta As Integer) As DataTable


        Dim DtRecFinal As New DataTable
        DtRecFinal.Columns.Add("INFORME")
        DtRecFinal.Columns.Add("FECHA")
        DtRecFinal.Columns.Add("RENDICION")
        DtRecFinal.Columns.Add("FECHA_RENDICION")

        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select fecha_entr, NroRendicion, FechaRendicion from entregadas where NRO_CARTA='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        cn.Open()
        DaRef.Fill(Dtrecorridos)
        cn.Close()

        For Each drw As DataRow In Dtrecorridos.Rows
            DtRecFinal.Rows.Add("Entregadas", drw("fecha_entr").ToString, drw("NroRendicion").ToString, drw("FechaRendicion").ToString)
        Next

        Return DtRecFinal

    End Function
    Public Shared Function ObtenerEnTransitoPorCarta(ByVal Carta As Integer) As DataTable

        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select NRO_CART2, ESTADOF, MOTIVOF, FECHAF, FECHA_REGISTRO from cartastr2 where NRO_CARTA='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        cn.Open()
        DaRef.Fill(Dtrecorridos)
        cn.Close()

        Return Dtrecorridos

    End Function




    Public Shared Function BuscarPorNroCartaParaConfEntreYdevo(ByVal NroCarta As String) As DataTable

        Dim sql As String = "Select * FROM recorridos where NRO_CARTA = '" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        Return Dt

        cn.Close()
    End Function

    Public Shared Function BuscarPorNroCartaParaConfEntre(ByVal NroCarta As String) As String

        Dim sql As String = "Select estado FROM cartas where NRO_CARTA = '" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado

    End Function

    Public Shared Function BuscarEnTransitoPorNroCartaParaDevuelta(ByVal NroCarta As String) As String

        Dim sql As String = "Select estadof FROM cartastr2 where NRO_CARTA = '" & NroCarta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If resultado = Nothing Then
            Return ""
        Else
            Return resultado
        End If


    End Function

    Public Shared Function BuscarEnTransitoPorNroCartaParaDevueltaPorCarta2(ByVal NroCarta2 As String) As String

        Dim sql As String = "Select nro_carta FROM cartastr2 where NRO_CART2 = '" & NroCarta2 & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If resultado = Nothing Then
            Return ""
        Else
            Return resultado
        End If


    End Function

    Public Shared Function BuscarNroCartaParaDevueltaPorCarta2(ByVal NroCarta2 As String) As String

        Dim sql As String = "Select nro_carta FROM cartas where NRO_CART2 = '" & NroCarta2 & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If resultado = Nothing Then
            Return ""
        Else
            Return resultado
        End If


    End Function


    Public Shared Function ActualizarPorCartaRecorrido(ByVal NroCarta As String, ByVal Estado As String, ByVal Fecha As String) As Boolean
        Dim Fechadate As Date
        Fechadate = Fecha

        Dim sql As String = "UPDATE RECORRIDOS SET ESTADO='" & Estado & "', Fechaf='" & Converfecha(Fechadate.ToShortDateString) & "' WHERE Nro_Carta=" & NroCarta & " ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
        ActualizarPorCartaEstadoEnCartas(NroCarta, Estado)

        Return True

    End Function

    Public Shared Function ActualizarPorCartaEstadoEnCartasActualizadoConfEntreDeoSucu(ByVal NroCarta As String, ByVal Estado As String, ByVal Fecha As String)
        Dim sql As String = "UPDATE Cartas SET ESTADO='" & Estado & "' WHERE Nro_carta=" & NroCarta & " ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

        ActualizarPorCartaRecorridoDevoEntre(NroCarta, Estado, Fecha)
    End Function
    'Public Shared Function ActualizarPorCartaEstadoEnCartasActualizadoCampoEspecifico(ByVal NroCarta As String, ByVal Campo As String, ByVal Dato As String)
    '    Try
    '        Dim sql As String = "UPDATE Cartas SET " & Campo & "='" & Dato & "' WHERE Nro_carta=" & NroCarta & " ORDER by ID DESC LIMIT 1"
    '        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
    '        Dim cm As New MySqlCommand(sql, cn)
    '        cn.Open()
    '        cm.ExecuteNonQuery()
    '        cn.Close()
    '    Catch ex As Exception

    '    End Try


    'End Function

    Public Shared Sub ActualizarPorCartaEstadoEnCartasActualizadoCampoEspecifico(ByVal NroCarta As String, ByVal Campo As String, ByVal Dato As String)
        Try
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            cn.Open()
            Dim sql As String = "UPDATE Cartas SET " & Campo & "='" & Dato & "' WHERE Nro_carta=" & NroCarta
            Dim cm As New MySqlCommand(sql, cn)
            cm.ExecuteNonQuery()

            If Campo = "NRO_CART2" Then
                Dim sql2 As String = "UPDATE recorridos SET NRO_CARTA2='" & Dato & "' WHERE NRO_CARTA=" & NroCarta
                Dim cm2 As New MySqlCommand(sql2, cn)
                cm2.ExecuteNonQuery()
            End If

            cn.Close()
        Catch ex As Exception
            MsgBox("Error capture este dato para el administrador er ActualizarPorCartaEstadoEnCartasActualizadoCampoEspecifico otrodato devosucu " & ex.ToString)
        End Try
    End Sub


    Private Shared Function ActualizarPorCartaRecorridoDevoEntre(ByVal NroCarta As String, ByVal Estado As String, ByVal Fecha As String) As Boolean
        Dim Fechadate As Date
        Fechadate = Fecha

        Dim sql As String = "UPDATE RECORRIDOS SET ESTADO='" & Estado & "', Fechaf='" & Converfecha(Fechadate.ToShortDateString) & "' WHERE Nro_Carta=" & NroCarta & " ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

        Return True

    End Function


    Public Shared Function ActualizarPorCartaEstadoEnCartas(ByVal NroCarta As String, ByVal Estado As String)
        Dim sql As String = "UPDATE Cartas SET ESTADO='" & Estado & "' WHERE Nro_carta=" & NroCarta & " ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ObtenerEscaneoPorCarta(ByVal Carta As Integer) As DataTable
        Dim Dtrecorridos As New DataTable
        Dim sql As String = "Select NroCartaLeido, planilla, Fecha_Escaneo, ruta_archivo from escaneocartas where NroCartaLeido='" & Carta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)
        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function


    Public Shared Function ObtenerFechaRecorridoPorCarta(ByVal nrocarta As String) As Date
        'a
        Dim Sql As String = "Select fecha_recorrido from recorridos Where nro_carta='" & nrocarta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()

        Dim value As Object = cmconsult.ExecuteScalar()
        Dim fecha As Date = Nothing
        cn.Close()
        If IsDBNull(value) Then
            Return fecha
        Else
            If Convert.ToString(value) = "" Then
            Else
                fecha = Convert.ToString(value)
            End If


            Return fecha

        End If


    End Function

    'date
    Public Shared Function AgregardiaFeriado(ByVal Fecha As Date) As Date
        Fecha = Fecha.ToShortDateString

        Dim arrayfechas As New ArrayList
        arrayfechas = cargarFeriados()
        For i As Integer = 0 To arrayfechas.Count - 1
            Dim FechaFeriado As Date = arrayfechas.Item(i).ToString
            FechaFeriado = FechaFeriado.ToShortDateString
            If Fecha = FechaFeriado Then
                Fecha = Fecha.AddDays(1)
            End If
        Next

        Return Fecha


    End Function
    Public Shared Function Sabadoydomingo(ByVal Fecha As Date) As Date
        Fecha = Fecha.ToShortDateString

        If Weekday(Fecha) = 7 Then
            Fecha = Fecha.AddDays(2)
        ElseIf Weekday(Fecha) = 1 Then
            Fecha = Fecha.AddDays(1)
        End If

        Return Fecha


    End Function
    Public Shared Function FechaEntregadaOriginal(ByVal FechaOriginal As Date, ByVal FechaSugerida As Date, ByVal CP As Integer) As Date
        If CP >= "1000" And CP <= "1899" Then
            If FechaOriginal < FechaSugerida Then
                Return FechaOriginal
            Else
                Return FechaSugerida
            End If
        Else
            Return FechaSugerida
        End If
    End Function


    'Public Shared Function VerificarSiFueEntregadaEnTransito(ByVal Socio As String, ByVal Lote As String) As Date

    '    Dim Sql As String = "Select FECHAF from cartastr2 Where Nro_cart2 LIKE '%" & Socio & "-" & Lote & "%'"
    '    Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
    '    Dim cmconsult As New MySqlCommand(Sql, cn)
    '    cn.Open()
    '    Dim resultado As String = ""
    '    resultado = cmconsult.ExecuteScalar()
    '    cn.Close()

    '    If Len(resultado) > 0 Then
    '        Return resultado
    '    Else
    '        Return Nothing
    '    End If


    'End Function



    Public Shared Function VerificarSiFueEntregadaEnDiario(ByVal Socio As String, ByVal Lote As String) As Date


        Dim Sql As String = "Select fecha_entr from entregadas Where socio='" & Socio & "' And Lote LIKE '%" & Lote.TrimStart("0") & "%'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        If Len(resultado) > 0 Then
            Return resultado
        Else
            Return Nothing
        End If

    End Function
    Public Shared Function ObtenerRemitentesDeRecorrido(ByVal NroPLanilla As Integer) As DataTable
        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select DISTINCT REMITENTE from recorridos where planilla_recorrido='" & NroPLanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function

    Public Shared Function ObtenerRecorridoDeRemitenteYplanilla(ByVal NroPLanilla As Integer, ByVal remitente As String) As DataTable
        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select NRO_CARTA, CALLE, ORDEN_LECT from recorridos where planilla_recorrido='" & NroPLanilla & "' and remitente='" & remitente & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function
    Public Shared Function ObtenerRecorridoDeplanilla(ByVal NroPLanilla As Integer) As DataTable
        Dim Dtrecorridos As New DataTable

        Dim sql As String = "Select NRO_CARTA, CALLE, ORDEN_LECT from recorridos where planilla_recorrido='" & NroPLanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CMRef As New MySqlCommand(sql, cn)
        Dim DaRef As New MySqlDataAdapter(CMRef)

        DaRef.Fill(Dtrecorridos)
        cn.Close()
        Return Dtrecorridos

    End Function

    'Planificacion
    Public Shared Function IngresarNuevoRecorrido(ByVal NroCarta As String, ByVal PlanillaRecorrido As String, ByVal Fecha_recorrido As String, ByVal cartero As String, ByVal Zona As String, ByVal REMITENTE As String, ByVal TRABAJO As String, ByVal FECH_TRAB As String, ByVal APELLIDO As String, ByVal CP As String, ByVal CALLE As String, ByVal LOCALIDAD As String, ByVal PROVINCIA As String, ByVal EMPRESA As String, ByVal NRO_CARTA2 As String, ByVal Orden As String, ByVal id As String) As Boolean

        'Try
        Dim Recorrido As Integer = ContarCantRecorridos(NroCarta) + 1
            Dim InsSq As String
            InsSq = "INSERT INTO recorridos (NRO_CARTA, PLANILLA_RECORRIDO, FECHA_RECORRIDO, CARTERO, ZONA, REMITENTE, TRABAJO, FECHA_TRABAJO, NOMBRE_APELLIDO, CP, CALLE, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CARTA2, ORDEN_LECT, ESTADO, IDENTIFICADOR, RECORRIDO) VALUES (" &
          "'" & NroCarta & "'" & ", " &
          "'" & PlanillaRecorrido & "'" & ", " &
          "'" & Converfecha(Fecha_recorrido) & "'" & ", " &
          "'" & cartero & "'" & ", " &
          "'" & Zona & "'" & ", " &
          "'" & REMITENTE & "'" & ", " &
          "'" & TRABAJO & "'" & ", " &
          "'" & Converfecha(FECH_TRAB) & "'" & ", " &
          "'" & APELLIDO & "'" & ", " &
          "'" & CP & "'" & ", " &
          "'" & CALLE & "'" & ", " &
          "'" & LOCALIDAD & "'" & ", " &
          "'" & PROVINCIA & "'" & ", " &
          "'" & EMPRESA & "'" & ", " &
          "'" & NRO_CARTA2 & "'" & ", " &
          "'" & Orden & "', " &
          "'EN_DISTRIBUCION', " &
          "" & id & ", " &
          "" & Recorrido & ")"

            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(InsSq, cn)

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()

            Return True
        'Catch ex As Exception
        '    Return False

        'End Try




    End Function
    Public Shared Function ContarCantRecorridos(ByVal NroCarta As String) As Integer
        'select count(*) from libros
        'where editorial='Planeta';
        Dim sql As String = "Select count(nro_carta) from recorridos Where nro_carta='" & NroCarta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(sql, cn)
        Dim cant As Integer
        cn.Open()
        cant = CmFecha.ExecuteScalar
        cn.Close()

        Return cant

    End Function
    Public Shared Function ActualizarCartas(ByVal Id As Integer) As Boolean
        Dim sqlCarta As String = "UPDATE cartas SET Estado='EN_DISTRIBUCION' Where ID=" & Id & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function ActualizarEstadoCartaPorCartaEnEsperaDeRecorrido(ByVal Carta As String) As Boolean
        Dim sqlCarta As String = "UPDATE cartas SET Estado='EN_ESPERA_DE_RECORRIDO' Where Nro_carta=" & Carta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
    End Function
    Public Shared Function BuscaCartaPorCartaEnEsperaDeRecorrido(ByVal Carta As String) As Boolean
        Dim sqlCarta As String = "Select nro_carta from cartas where nro_carta ='" & Carta & "' and Estado='EN_ESPERA_DE_RECORRIDO'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlCarta, cn)
        Dim Resultado As String
        cn.Open()
        Resultado = cm.ExecuteScalar
        cn.Close()
        If Len(Resultado) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function ContarCantidadcartasenrecorrido(ByVal nroplanilla As String) As Integer
        'select count(*) from libros
        'where editorial='Planeta';
        Dim sql As String = "Select count(nro_carta) from recorridos Where planilla_recorrido='" & nroplanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim CmFecha As New MySqlCommand(sql, cn)
        Dim cant As Integer
        cn.Open()
        cant = CmFecha.ExecuteScalar
        cn.Close()

        Return cant

    End Function
    Public Shared Function VerificarEstadoCarta(ByVal Carta As String) As String
        Dim Sql As String = "Select Estado from cartas Where nro_carta='" & Carta & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()

        Return resultado

    End Function
    Public Shared Function ActualizarCarteroPorCartero(ByVal Cartero As String, ByVal Planilla As String) As Boolean
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim sqlCartero As String = "UPDATE recorridospl SET cartero ='" & Cartero & "' Where nroplanilla =" & Planilla & ""
        Dim sqlcartero2 As String = "UPDATE recorridos SET CARTERO ='" & Cartero & "' Where PLANILLA_RECORRIDO =" & Planilla & ""
        Dim cm As New MySqlCommand(sqlCartero, cn)
        Dim cm2 As New MySqlCommand(sqlcartero2, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cm2.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function IngresarNuevoPLanillaConfAcuse(ByVal NroCarta As String, ByVal REMITENTE As String, ByVal TRABAJO As String, ByVal FECH_TRAB As String, ByVal APELLIDO As String, ByVal CP As String, ByVal CALLE As String, ByVal LOCALIDAD As String, ByVal PROVINCIA As String, ByVal EMPRESA As String, ByVal NRO_CARTA2 As String, ByVal ESTADO As String, ByVal NRO_PLANILLA As String, ByVal FECHA_PLANILLA As String) As Boolean
        'ESTADO, NRO_PLANILLA, FECHA_PLANILLA

        'Try

        Dim InsSq As String
        InsSq = "INSERT INTO planillado (NRO_CARTA, REMITENTE, TRABAJO, FECHA_TRABAJO, APELLIDO, CP, CALLE, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CART2, ESTADO, NRO_PLANILLA, FECHA_PLANILLA) VALUES (" &
      "'" & NroCarta & "'" & ", " &
      "'" & REMITENTE & "'" & ", " &
      "'" & TRABAJO & "'" & ", " &
      "'" & Converfecha(FECH_TRAB) & "'" & ", " &
      "'" & APELLIDO & "'" & ", " &
      "'" & CP & "'" & ", " &
      "'" & CALLE & "'" & ", " &
      "'" & LOCALIDAD & "'" & ", " &
      "'" & PROVINCIA & "'" & ", " &
      "'" & EMPRESA & "'" & ", " &
      "'" & NRO_CARTA2 & "'" & ", " &
      "'" & ESTADO & "', " &
      "'" & NRO_PLANILLA & "', " &
      "'" & Converfecha(FECHA_PLANILLA) & "')"

        ActualizarEstadoEnCartasDesdePLanillado(NroCarta, "PLANILLADA")
        ConfigCorreo.CN_Correo.VerificarEstadoAlerta(NroCarta, "PLANILLADA")

        Dim EstadoReco As String = VerificarEstadoEnRecorrido(NroCarta)
        If EstadoReco = "EN_DISTRIBUCION" Or EstadoReco = "PARA_REPROGRAMACION" Then
            ActualizarEstadoRecorridoDesdePlanillado(NroCarta, "ENTREGADA", Converfecha(FECHA_PLANILLA))
        End If


        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(InsSq, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

        Return True
        'Catch ex As Exception
        '    Return False

        'End Try

    End Function
    Public Shared Function VerificarEstadoEnRecorrido(ByVal NroCarta As String) As String
        Dim Sql As String = "Select estado from recorridos Where nro_carta='" & NroCarta & "' ORDER by ID DESC LIMIT 1"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cmconsult As New MySqlCommand(Sql, cn)
        cn.Open()
        Dim resultado As String = ""
        resultado = cmconsult.ExecuteScalar()
        cn.Close()
        Return resultado

    End Function
    Public Shared Function ObtenerservicioSimpleyconacuse(ByVal planilla As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select servicio From recorridospl Where nroplanilla='" & planilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim servicio As String
        cn.Open()
        servicio = cm.ExecuteScalar
        cn.Close()
        Return servicio

    End Function
    Public Shared Function Obtenercantidadesendistrib(ByVal numeroplani As String) As Integer
        'Cargar insert sql

        Dim sqlNumero As String = "Select count(*) From recorridos Where PLANILLA_RECORRIDO='" & numeroplani & "' and estado='EN_DISTRIBUCION'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim numero As Integer
        cn.Open()
        numero = cm.ExecuteScalar
        cn.Close()
        Return numero

    End Function


    Private Shared Function ActualizarEstadoEnCartasDesdePLanillado(ByVal NRO_CARTA As String, ByVal ESTADO As String) As Boolean

        Dim sql As String = "UPDATE CARTAS SET ESTADO='" & ESTADO & "' WHERE NRO_CARTA=" & NRO_CARTA & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()
        Return True

    End Function
    Public Shared Function ActualizarEstadoRecorridoDesdePlanillado(ByVal nro_carta As String, ByVal Estado As String, ByVal Fecha As String) As Boolean
        Try
            Dim sql As String = "UPDATE RECORRIDOS SET ESTADO='" & Estado & "', Fechaf='" & Fecha & "' WHERE nro_carta='" & nro_carta & "' ORDER by ID DESC LIMIT 1"
            Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Dim cm As New MySqlCommand(sql, cn)
            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception

        End Try

    End Function
    Public Shared Function ObtenerServisoSimpleConAcuse(ByVal nroplanilla As String) As DataTable

        Dim sql As String = "Select servicio, cantidad,  fecharecorrido from recorridospl Where nroplanilla='" & nroplanilla & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridospl")
        cn.Close()
        Dim Dt As New DataTable

        Dt = ds.Tables("recorridospl")

        Return Dt

    End Function

    Public Shared Function ObtenerPrecioPorCartero(ByVal Cartero As String, ByVal Servicio As String) As Decimal

        Dim sql As String = "Select simple, conacuse from carteros Where idCarteros='" & Cartero & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "carteros")
        cn.Close()
        Dim Dt As New DataTable
        Dt = ds.Tables("carteros")

        If Servicio = "SIMPLE" Then

            Return Dt.Rows(0)("simple").ToString

        ElseIf Servicio = "CON ACUSE" Then

            Return Dt.Rows(0)("conacuse").ToString
        Else
            Return "0.00"
        End If


    End Function


    Public Shared Function ActualizarEstadoRecorrido(ByVal nro_carta As String, ByVal Estado As String, ByVal Motivo As String, ByVal Fecha As String) As Boolean

        Dim sql As String = "UPDATE RECORRIDOS SET ESTADO='" & Estado & "', MOTIVO='" & Motivo & "', Fechaf='" & Fecha & "' WHERE nro_carta = '" & nro_carta & "' ORDER BY id DESC LIMIT 1"

        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)

        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

        ActualizarEstadoEnCartas(nro_carta, Estado)
        Return True

    End Function

    Private Shared Function ActualizarEstadoEnCartas(ByVal nro_carta As String, ByVal Estado As String)

        Dim sql As String = "UPDATE Cartas SET ESTADO='" & Estado & "' WHERE nro_carta=" & nro_carta & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

    End Function
    Public Shared Function VerificarParaReprogramacion(ByVal dosdigitos As String) As String
        'Cargar insert sql
        Dim sqlNumero As String = "Select reprogramacion From motivos Where IdMotivo='" & dosdigitos & "'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim Repro As String = ""

        cn.Open()
        Repro = cm.ExecuteScalar
        cn.Close()
        Return Repro

    End Function


    'funcion temporal de actualizacion de planilla pl zona a con acuse y simple
    Public Shared Function CargarRecorridosplanillaparaaveriguarZona() As DataTable
        Dim ArrServicios As New ArrayList
        Dim sqln As String = "SELECT * FROM recorridospl"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion & ";Convert Zero Datetime=true")
        Dim cm As New MySqlCommand(sqln, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        cn.Open()
        da.Fill(ds, "recorridospl")
        cn.Close()
        Dim Dt As New DataTable

        Dt = ds.Tables("recorridospl")

        Return Dt
    End Function

    Public Shared Function ActualizarServicioSimpleyconacuse(ByVal nroplanilla As String, ByVal servicio As String) As Boolean

        Dim sql As String = "UPDATE recorridospl SET Servicio='" & servicio & "' WHERE nroplanilla=" & nroplanilla & ""
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        cn.Open()
        cm.ExecuteNonQuery()
        cn.Close()

        Return True

    End Function
    Public Shared Function ObtenerEntregadasTodo() As DataTable
        Dim sql As String = "SELECT * FROM recorridos WHERE fecha_recorrido > '2023-01-01' and estado='ENTREGADA'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sql, cn)
        Dim da As New MySqlDataAdapter(cm)
        Dim Dt As New DataTable
        cn.Open()
        da.Fill(Dt)
        cn.Close()
        Return Dt
    End Function

    Public Shared Function ReemplazarPalabras() As Dictionary(Of String, String)
        Dim palabras As New Dictionary(Of String, String)()

        palabras.Add("AV", "")
        palabras.Add("N°", "")
        palabras.Add("AV.", "")
        palabras.Add("AVDA", "")
        palabras.Add("CMTE", "")
        palabras.Add("CORONEL", "CNEL")
        palabras.Add("GENERAL", "GRAL")
        palabras.Add("MANUEL AUGUSTO", "")
        palabras.Add("MANUEL BELGRANO", "BELGRANO")
        palabras.Add("MARIANO BOEDO", "BOEDO")
        palabras.Add("REGIMIENTO DE", "")
        palabras.Add("PRES HIPOLITO YRIGOYEN", "HIPOLITO YRIGOYEN")
        palabras.Add("AVENI", "")
        palabras.Add("AVENIDA", "")
        palabras.Add("°", "")
        palabras.Add("CALLE", "")
        palabras.Add("CARLOS", "C")
        palabras.Add("GOBERNADOR", "GDOR")
        palabras.Add(".", "")
        palabras.Add("Ã‘", "N")
        palabras.Add("PRESIDENTE", "PRES")
        palabras.Add("PROFESOR", "PROF")
        palabras.Add("REMEDIOS", "R")
        palabras.Add("REPUBLICA", "REP")
        palabras.Add("Âº", "")
        palabras.Add("Â", "")
        palabras.Add("Ãƒâ€˜", "N")
        palabras.Add("ALICIA JUSTO", "ALICIA M JUSTO")
        palabras.Add("ALICIA MOREAU DE JUSTO", "ALICIA M JUSTO")
        palabras.Add("ALICIA MOROE DE JUSTO", "ALICIA M JUSTO")
        palabras.Add("AV ALICIA MOREAU DE JUSTO", "ALICIA M JUSTO")
        palabras.Add("A MOREAU DE JUSTO", "ALICIA M JUSTO")
        palabras.Add("IÃƒâ€˜", "N")
        palabras.Add("NÂ°", "")
        palabras.Add("Ã al final", "")
        palabras.Add("Ã‰", "")
        palabras.Add("ARRIBE?OS", "ARRIBENOS")
        palabras.Add("ARRIBEÃƒâ€˜OS", "ARRIBENOS")
        palabras.Add("ARRIBEÃ‘OS", "ARRIBENOS")
        palabras.Add("arribeÃ±os", "ARRIBENOS")
        palabras.Add(" EDIF", "")
        palabras.Add("CASTAÃ‘ARES", "CASTANARES")
        palabras.Add("CATAÃ‘ARES", "CASTANARES")
        palabras.Add("CERVI?O", "CERVINO")
        palabras.Add("CERVIÃƒâ€˜O", "CERVINO")
        palabras.Add("CERVIÃ‘O", "CERVINO")
        palabras.Add("CNGRESO", "CONGRESO")
        palabras.Add("PORTERIA", "")
        palabras.Add("DOCTOR ", "DR ")
        palabras.Add("R DE ESCALADA", "R E SAN MARTIN")
        palabras.Add("R DE ESCALADA DE S MARTIN", "R E SAN MARTIN")
        palabras.Add("R DE ESCALADA DE SAN MARTIN", "R E SAN MARTIN")
        palabras.Add("R DE ESCALADA DE SAN MARTN", "R E SAN MARTIN")
        palabras.Add("R E DE SAN MARTIN", "R E SAN MARTIN")
        palabras.Add("R E S MARTIN", "R E SAN MARTIN")
        palabras.Add("R ESCALADA DE SAN MARTIN", "R E SAN MARTIN")
        palabras.Add("R ESCALADA DE SAN MARTN", "R E SAN MARTIN")
        palabras.Add("R ESCALADA SAN MARTIN", "R E SAN MARTIN")
        palabras.Add("ENIDA ", "")
        '




        Return palabras

    End Function

    Public Shared Function ObtenerNroPlanillaArm() As Integer
        'Cargar insert sql
        Dim sqlNumero As String = "Select Desde From configuracion Where Operacion='NUMEROARM'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function

    Public Shared Function ActualizarNroPlanillaArm(ByVal NroActual As String) As Boolean
        'Cargar insert sql
        Dim sqlNumero As String = "UPDATE configuracion SET Desde='" & NroActual + 1 & "'" & " Where Operacion='NUMEROARM'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlNumero, cn)
        Dim NumeroCarta As Integer
        cn.Open()
        NumeroCarta = cm.ExecuteScalar
        cn.Close()
        Return NumeroCarta

    End Function

    Public Shared Function InsertarEnArmPlanilla(dtppalDatos As DataTable) As Boolean
        Try
            Using connection As New MySqlConnection(CadenaDeConeccionProduccion)
                connection.Open()

                For Each row In dtppalDatos.Rows
                    Dim trabajo As String = row("TRABAJO").ToString()

                    Dim queryInsert As String = "INSERT INTO armplanilla (CANTIDAD, TRABAJO, EMPRESA, CALLE, CP, LOCALIDAD, PROVINCIA, NumeroArm) VALUES (@CANTIDAD, @TRABAJO, @EMPRESA, @CALLE, @CP, @LOCALIDAD, @PROVINCIA, @NumeroArm)"
                    Using cmdInsert As New MySqlCommand(queryInsert, connection)
                        cmdInsert.Parameters.AddWithValue("@CANTIDAD", row("CANTIDAD"))
                        cmdInsert.Parameters.AddWithValue("@TRABAJO", trabajo)
                        cmdInsert.Parameters.AddWithValue("@EMPRESA", row("EMPRESA"))
                        cmdInsert.Parameters.AddWithValue("@CALLE", row("CALLE"))
                        cmdInsert.Parameters.AddWithValue("@CP", row("CP"))
                        cmdInsert.Parameters.AddWithValue("@LOCALIDAD", row("LOCALIDAD"))
                        cmdInsert.Parameters.AddWithValue("@PROVINCIA", row("PROVINCIA"))
                        cmdInsert.Parameters.AddWithValue("@NumeroArm", row("NumeroArm"))
                        cmdInsert.ExecuteNonQuery()
                    End Using

                Next

                connection.Close()
                Return True
            End Using
        Catch ex As Exception
            ' Handle the exception if any error occurs during the insertion
            Return False
        End Try
    End Function

    Public Shared Function InsertarEnArmDetalle(dtDatosDetalle As DataTable, ByVal arm As String) As Boolean
        Try
            Using connection As New MySqlConnection(CadenaDeConeccionProduccion)
                connection.Open()

                For Each row In dtDatosDetalle.Rows
                    Dim trabajo As String = row("TRABAJO").ToString()

                    Dim queryInsert As String = "INSERT INTO armdetalle (NRO_CARTA, REMITENTE, TRABAJO, FECH_TRAB, APELLIDO, CALLE, NRO, PISO_DEPTO, CP, LOCALIDAD, PROVINCIA, EMPRESA, NRO_CART2, SOCIO, OBS, OBS2, OBS3, OBS4, ARM) VALUES (@NRO_CARTA, @REMITENTE, @TRABAJO, @FECH_TRAB, @APELLIDO, @CALLE, @NRO, @PISO_DEPTO, @CP, @LOCALIDAD, @PROVINCIA, @EMPRESA, @NRO_CART2, @SOCIO, @OBS, @OBS2, @OBS3, @OBS4, @ARM)"
                    Using cmdInsert As New MySqlCommand(queryInsert, connection)
                        cmdInsert.Parameters.AddWithValue("@NRO_CARTA", row("NRO_CARTA"))
                        cmdInsert.Parameters.AddWithValue("@REMITENTE", row("REMITENTE"))
                        cmdInsert.Parameters.AddWithValue("@TRABAJO", trabajo)
                        cmdInsert.Parameters.AddWithValue("@FECH_TRAB", row("FECH_TRAB"))
                        cmdInsert.Parameters.AddWithValue("@APELLIDO", row("APELLIDO"))
                        cmdInsert.Parameters.AddWithValue("@CALLE", row("CALLE"))
                        cmdInsert.Parameters.AddWithValue("@NRO", row("NRO"))
                        cmdInsert.Parameters.AddWithValue("@PISO_DEPTO", row("PISO_DEPTO"))
                        cmdInsert.Parameters.AddWithValue("@CP", row("CP"))
                        cmdInsert.Parameters.AddWithValue("@LOCALIDAD", row("LOCALIDAD"))
                        cmdInsert.Parameters.AddWithValue("@PROVINCIA", row("PROVINCIA"))
                        cmdInsert.Parameters.AddWithValue("@EMPRESA", row("EMPRESA"))
                        cmdInsert.Parameters.AddWithValue("@NRO_CART2", row("NRO_CART2"))
                        cmdInsert.Parameters.AddWithValue("@SOCIO", row("SOCIO"))
                        cmdInsert.Parameters.AddWithValue("@OBS", row("OBS"))
                        cmdInsert.Parameters.AddWithValue("@OBS2", row("OBS2"))
                        cmdInsert.Parameters.AddWithValue("@OBS3", row("OBS3"))
                        cmdInsert.Parameters.AddWithValue("@OBS4", row("OBS4"))
                        cmdInsert.Parameters.AddWithValue("@ARM", arm) ' New parameter for the ARM field
                        cmdInsert.ExecuteNonQuery()
                    End Using

                Next

                connection.Close()
                Return True
            End Using
        Catch ex As Exception
            ' Handle the exception if any error occurs during the insertion
            Return False
        End Try
    End Function



    '*****************Combinadas para actualizar ARM**********************
    Public Shared Function VerificarSiExisteArm(ByVal trabajo As String) As Boolean
        Dim existe As Boolean = False

        Dim sql As String = "SELECT COUNT(*) FROM armplanilla WHERE trabajo = @trabajo"
        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmconsult As New MySqlCommand(sql, cn)
                cmconsult.Parameters.AddWithValue("@trabajo", trabajo)
                Try
                    cn.Open()
                    Dim count As Integer = Convert.ToInt32(cmconsult.ExecuteScalar())
                    existe = (count > 0)
                Catch ex As Exception
                    ' Manejar la excepción adecuadamente (por ejemplo, registrarla)
                    existe = False
                End Try
            End Using
        End Using

        Return existe
    End Function

    Public Shared Function VerificarSiEsArm(ByVal NroArm As String) As Boolean
        Dim sql As String = "SELECT Numeroarm FROM armplanilla WHERE Numeroarm = @trabajo"
        Dim esArm As Boolean = False

        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmconsult As New MySqlCommand(sql, cn)
                cmconsult.Parameters.AddWithValue("@trabajo", NroArm)
                Try
                    cn.Open()
                    Dim resultado As Object = cmconsult.ExecuteScalar()
                    If resultado IsNot Nothing AndAlso resultado.ToString() = NroArm Then
                        esArm = True
                    End If
                Catch ex As Exception
                End Try
            End Using
        End Using

        Return esArm


    End Function
    Public Shared Function ActualizarEstadoArm(ByVal arm As String, ByVal estado As String) As Boolean
        Dim sql As String = "UPDATE armdetalle SET estado = @estado WHERE arm = @arm"
        Dim rowsAffected As Integer = 0
        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@arm", arm)
                cmd.Parameters.AddWithValue("@estado", estado)
                Try
                    cn.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Dim numerosCarta As List(Of String) = ObtenerNroCartaPorArm(arm)
                        If numerosCarta IsNot Nothing AndAlso numerosCarta.Count > 0 Then
                            Dim actualizacionExitosa As Boolean = ActualizarEstadoCartas(estado, numerosCarta)
                            Return actualizacionExitosa
                        End If
                    End If
                Catch ex As Exception

                End Try
            End Using
        End Using

        Return False
    End Function
    Public Shared Function ObtenerNroCartaPorArm(ByVal arm As String) As List(Of String)
        Dim sql As String = "SELECT nro_carta FROM armdetalle WHERE arm = @arm"
        Dim resultados As New List(Of String)()

        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@arm", arm)
                Try
                    cn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()

                        resultados.Add(reader("nro_carta").ToString())
                    End While
                    reader.Close()
                Catch ex As Exception

                End Try
            End Using
        End Using

        Return resultados
    End Function
    Public Shared Function ActualizarEstadoCartas(ByVal estado As String, ByVal numerosCarta As List(Of String)) As Boolean
        Dim sqlUpdate As String = "UPDATE cartas SET estado = @estado WHERE nro_carta = @nro_carta"
        Dim rowsAffected As Integer = 0

        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            cn.Open()
            Dim transaction As MySqlTransaction = cn.BeginTransaction()

            Try
                Using cmdUpdate As New MySqlCommand(sqlUpdate, cn)
                    cmdUpdate.Parameters.Add("@estado", MySqlDbType.VarChar)
                    cmdUpdate.Parameters.Add("@nro_carta", MySqlDbType.VarChar)

                    For Each numeroCarta As String In numerosCarta
                        cmdUpdate.Parameters("@estado").Value = estado
                        cmdUpdate.Parameters("@nro_carta").Value = numeroCarta
                        rowsAffected += cmdUpdate.ExecuteNonQuery()
                    Next
                End Using


                transaction.Commit()
            Catch ex As Exception

                transaction.Rollback()
            End Try
        End Using

        Return rowsAffected > 0
    End Function

    '**********************************
    Public Shared Function ObtenerArchivoPdf() As Byte()
        Dim sqlSelect As String = "SELECT archivo FROM configuracion WHERE operacion = 'ARCHIVOARM'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlSelect, cn)

        cn.Open()
        Dim pdfData As Byte() = DirectCast(cm.ExecuteScalar(), Byte())
        cn.Close()

        Return pdfData
    End Function
    Public Shared Function GuardarFuenteTemporal(fuenteData As Byte()) As String
        Dim rutaTemporal As String = "C:\temp\3OF9.TTF" ' Asigna una ruta temporal adecuada

        If Not File.Exists(rutaTemporal) Then
            File.WriteAllBytes(rutaTemporal, fuenteData)
        End If

        Return rutaTemporal
    End Function
    Public Shared Function ObtenerRutaFuenteTemporal() As String
        Dim sqlSelect As String = "SELECT ARCHIVO FROM CONFIGURACION WHERE OPERACION = 'FUENTEBARCODE'"
        Dim cn As New MySqlConnection(CadenaDeConeccionProduccion)
        Dim cm As New MySqlCommand(sqlSelect, cn)

        cn.Open()
        Dim fuenteData As Byte() = DirectCast(cm.ExecuteScalar(), Byte())
        cn.Close()

        If fuenteData IsNot Nothing AndAlso fuenteData.Length > 0 Then
            Return GuardarFuenteTemporal(fuenteData)
        End If

        Return Nothing
    End Function

    '**********************************

    Public Shared Function VerificarSiEstaIngresadoEnCartas(ByVal Trabajo As String) As Boolean
        Dim sql As String = "SELECT TRABAJO FROM CARTAS WHERE TRABAJO = @trabajo"
        Dim esArm As Boolean = False

        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmconsult As New MySqlCommand(sql, cn)
                cmconsult.Parameters.AddWithValue("@trabajo", Trabajo)
                Try
                    cn.Open()
                    Dim resultado As Object = cmconsult.ExecuteScalar()
                    If resultado IsNot Nothing AndAlso resultado.ToString() = Trabajo Then
                        esArm = True
                    End If
                Catch ex As Exception
                    ' Manejar la excepción según tus necesidades
                End Try
            End Using
        End Using

        Return esArm
    End Function

    Public Shared Function VerificarSiEstaMarcadoParaNoIngresarRemito(ByVal NroRemito As String) As Boolean
        Dim sql As String = "SELECT NroRemito FROM RemitosLexs WHERE NroRemito = @NroRemito AND ESTADO='Marcado'"
        Dim esArm As Boolean = False

        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmconsult As New MySqlCommand(sql, cn)
                cmconsult.Parameters.AddWithValue("@NroRemito", NroRemito)
                Try
                    cn.Open()
                    Dim resultado As Object = cmconsult.ExecuteScalar()
                    If resultado IsNot Nothing AndAlso resultado.ToString() = NroRemito Then
                        esArm = True
                    End If
                Catch ex As Exception

                End Try
            End Using
        End Using

        Return esArm
    End Function


    Public Shared Function ActualizarEstadoPorRemito(ByVal remito As String) As Boolean
        Dim sql As String = "UPDATE remitoslexs SET estado = 'Marcado' WHERE nroremito = @remito"
        Dim rowsAffected As Integer = 0
        Using cn As New MySqlConnection(CadenaDeConeccionProduccion)
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@remito", remito)
                Try
                    cn.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                Catch ex As Exception

                End Try
            End Using
        End Using

        Return False
    End Function



End Class
