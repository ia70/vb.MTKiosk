﻿#Region "Importaciones"
Imports System.Drawing                  'Usado para el objeto Image
Imports System.Windows.Forms            'Usado para el DataGridView
Imports System.Drawing.Printing         'Usado para imprimir con PrintDocument

#End Region
Public Class cImpresoraTickets
#Region "Declaraciones de Datos del ticket"
    '***** DATOS DEL TICKET ***** DATOS DEL TICKET ***** DATOS DEL TICKET ***** DATOS DEL TICKET *****************

    Private _Logotipo As Image = Nothing                            'Logotipo de la empresa         ID ->1
    Private _BarCode_Text As String = ""                            'Code 39
    Private _Barcode_Ima As Image = Nothing                         'Imagen del código de barra     ID ->0
    Private _Tabla As DataGridView = Nothing                        'Número del codigo de barra
    Private _Fecha As String = ""                                   'Fecha en que se registra la transacción
    Private _Hora As String = ""                                    'Hora en que se registra la transacción
    Private _Empresa As String = ""
    Private _Operacion As String = ""
    Private _MostrarError As Boolean = False
    Private _QR As Image = Nothing                                  'Imagen QR a Imprimir
    Private _Prevosualizacion As Boolean = False                    'Indica si se mostrará previsualización o Imprimira
    Private _EspacioPie As Integer = 10                             'Espacios a imprimir al pie de pagina
    Public Plan As String = ""

#End Region
#Region "Declaraciones de Funcionamiento de Impresión"
    '***** FUNCIONAMIENTO ***** FUNCIONAMIENTO ***** FUNCIONAMIENTO ***** FUNCIONAMIENTO ***** FUNCIONAMIENTO *****
    Private WithEvents PD As New PrintDocument                      'Documento a imprimir
    Private PDBody As PrintPageEventArgs = Nothing                  'Cuerpo del documento
    Private _Impresora As String = "POS58"                         'Nombre de la impresora
    Private _ImagenPrint As Boolean = True                          'True imprime logotipo; false imprime código de barra
    Private _AnchoHoja As Decimal = 192                             'Ancho de la hoja de impresión
    Private _Espacio As Decimal = 5                                 'Espacio entre lineas
    Private _X As Integer = 0                                       'Posición X en la impresión
    Private _Y As Integer = 0                                       'Posición Y en la impresión
    Private _Usuario As String = ""
    Private _Password As String = ""
    Private AreaImpresion As Rectangle                              'Area de impresión
    Private fResta As New Font("Arial", 10, FontStyle.Strikeout)    'Fuente de Titulo
    Private fResultado As New Font("Arial", 12, FontStyle.Regular)  'Fuente de encabezado
    Private fEmpresa As New Font("Arial", 12, FontStyle.Bold)       'Fuente de encabezado
    Private fSuma As New Font("Arial", 10, FontStyle.Regular)       'Fuente de cuerpo
    Private fMultiplicacion As New Font("Arial", 12, FontStyle.Bold) 'Fuente de cuerpo
    Private fDivision As New Font("Arial", 10, FontStyle.Underline) 'Fuente de cuerpo
    Private fFecha As New Font("Arial", 10, FontStyle.Italic)       'Fuente de cuerpo
    Private fPie As New Font("Arial", 5, FontStyle.Italic)          'Fuente de cuerpo
    Private eCenter As New StringFormat()                           'Centra el texto
    Private eLeft As New StringFormat()                             'Alineación a la izquierda
    Private eRight As New StringFormat()                            'Alineación a la derecha
    Private _Aling As StringFormat                                  'Auxiliar para alineación
    Private _PrintView As New PrintPreviewDialog
#End Region

    'Contructor de clase
    Public Sub New()
        eCenter.Alignment = StringAlignment.Center
        eCenter.LineAlignment = StringAlignment.Center
        eLeft.Alignment = StringAlignment.Near
        eLeft.LineAlignment = StringAlignment.Center
        eRight.Alignment = StringAlignment.Far
        eRight.LineAlignment = StringAlignment.Center
    End Sub

#Region "Propiedades"
    ''' <summary>
    ''' Espacios al final de pagina
    ''' </summary>
    ''' <returns></returns>
    Public Property EspaciosFinPagina As Integer
        Get
            Return _EspacioPie
        End Get
        Set(value As Integer)
            _EspacioPie = value
        End Set
    End Property

    ''' <summary>
    ''' True -> Previsualizar / False -> Imprimir
    ''' </summary>
    ''' <returns></returns>
    Public Property Previsualizar As Boolean
        Get
            Return _Prevosualizacion
        End Get
        Set(value As Boolean)
            _Prevosualizacion = value
        End Set
    End Property

    ''' <summary>
    ''' Imagen QR a Imprimir
    ''' </summary>
    ''' <returns></returns>
    Public Property QR As Image
        Get
            Return _QR
        End Get
        Set(value As Image)
            _QR = value
        End Set
    End Property

    ''' <summary>
    ''' Tipo de operación
    ''' </summary>
    ''' <value>String</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Operacion As String
        Get
            Return _Operacion
        End Get
        Set(value As String)
            If Not value = "" Then
                _Operacion = value
            End If

        End Set
    End Property
    ''' <summary>
    ''' Nombre de la empresa 
    ''' </summary>
    ''' <value>String</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(value As String)
            If Not value = "" Then
                _Empresa = value
            End If

        End Set
    End Property
    ''' <summary>
    ''' Fecha en que se registra la transacción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            If Not value = "" Then
                _Fecha = value
            Else
                _Fecha = Format(CDate(Date.Today), "dd/MM/yyyy").ToString
            End If

        End Set
    End Property
    ''' <summary>
    ''' Hora en que se registra la transacción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Hora As String
        Get
            Return _Hora
        End Get
        Set(value As String)
            If Not value = "" Then
                _Hora = value
            Else
                _Hora = Format(CDate(Date.Today), "hh:mm tt")
            End If

        End Set
    End Property

    ''' <summary>
    ''' Espacio entre lineas
    ''' </summary>
    ''' <value>Decimal</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Espacio As String
        Get
            Return _Espacio
        End Get
        Set(value As String)
            _Espacio = value
        End Set
    End Property
    ''' <summary>
    ''' Ancho de la hoja de impresión en puntos
    ''' </summary>
    ''' <value>Decimal</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Ancho_Hoja As String
        Get
            Return _AnchoHoja
        End Get
        Set(value As String)
            _AnchoHoja = value
        End Set
    End Property

    ''' <summary>
    ''' Logotipo de la empresa
    ''' </summary>
    ''' <value>Image</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Logotipo As Image
        Get
            Return _Logotipo
        End Get
        Set(value As Image)
            _Logotipo = value
        End Set
    End Property
    Public Property BarCode_Text As String
        Get
            Return _BarCode_Text
        End Get
        Set(value As String)
            _BarCode_Text = value
        End Set
    End Property
    ''' <summary>
    ''' Imágen de código de barras
    ''' </summary>
    ''' <value>Image</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BarCode_Ima As Image
        Get
            Return _Barcode_Ima
        End Get
        Set(value As Image)
            _Barcode_Ima = value
        End Set
    End Property
    ''' <summary>
    ''' DataGridView donde esta el cuerpo del contenido del Ticket
    ''' </summary>
    ''' <value>DataGridView</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Tabla As DataGridView
        Get
            Return _Tabla
        End Get
        Set(value As DataGridView)
            _Tabla = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la impresora
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Impresora As String
        Get
            Return _Impresora
        End Get
        Set(value As String)
            _Impresora = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Usuario Mikrotik
    ''' </summary>
    ''' <returns></returns>
    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    ''' <summary>
    ''' Contraseña de usuario Mikrotik
    ''' </summary>
    ''' <returns></returns>
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

#End Region
#Region "Funciones públicas"
    ''' <summary>
    ''' Imprimir ticket
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ImprimirTicket()
        Imprimir()
    End Sub
    ''' <summary>
    ''' Convierte un número a texto especificando los pesos y centavos
    ''' </summary>
    ''' <param name="Num">Número a convertir a texto</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function NumeroToTexto(ByVal Num As Decimal) As String
        Dim Num2 As Integer
        Dim Cadena As String
        Num2 = Fix(Num)
        Cadena = NumToTex(Num2) + "pesos"
        Num2 = (Num - Num2) * 100
        If Num2 Then
            Cadena = Cadena + " y " + NumToTex(Num2) + "centavos"
        End If
        Return StrConv(Cadena, VbStrConv.ProperCase)
    End Function
#End Region
#Region "Funciones privadas"
#Region "Funciones generales"
    ''' <summary>
    ''' Recibe como parametro un numero y devuelve el numero expresado en cadena
    ''' </summary>
    ''' <param name="Num">Número a convertir a texto</param>
    ''' <returns>Cadena</returns>
    ''' <remarks></remarks>
    Private Function NumToTex(ByVal Num As String) As String
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim Cd As String = ""
        Dim ant As Boolean = False
        Num2 = Num
        While Not Num2 = 0
            If Num2 > 999 Then
                If Num2 < 2000 Then
                    Cd = "mil "
                ElseIf Num2 < 20000 Then
                    Cd = Numero(CInt(Num2 \ 1000)) + " " + Numero(1000) + " "
                Else
                    Num3 = CInt(Num2 \ 1000)
                    Cd = Numero(CInt(Num3 \ 10) * 10) + " "
                    Num3 = Num3 Mod 10
                    If Num3 Then
                        Cd = Cd + " y " + Numero(Num3) + " mil "
                    Else
                        Cd = Cd + " mil "
                    End If
                End If
                Num2 = Num2 Mod 1000
            ElseIf Num2 > 99 Then
                If Num2 = 100 Then
                    Cd = Cd + "cien "
                Else
                    Cd = Cd + Numero(CInt(Num2 \ 100) * 100) + " "
                End If
                Num2 = Num2 Mod 100
            ElseIf Num2 > 19 Then
                Cd = Cd + Numero(CInt(Num2 \ 10) * 10) + " "
                Num2 = Num2 Mod 10
                ant = True
            Else
                If ant Then
                    Cd = Cd + "y " + Numero(Num2) + " "
                Else
                    Cd = Cd + Numero(Num2) + " "
                End If

                Num2 = 0
            End If
        End While

        Return Cd
    End Function
    Private Function Numero(ByVal Num As Integer) As String
        Select Case Num
            Case 1
                Return "uno"
            Case 2
                Return "dos"
            Case 3
                Return "tres"
            Case 4
                Return "cuatro"
            Case 5
                Return "cinco"
            Case 6
                Return "seis"
            Case 7
                Return "siete"
            Case 8
                Return "ocho"
            Case 9
                Return "nueve"
            Case 10
                Return "diez"
            Case 11
                Return "once"
            Case 12
                Return "doce"
            Case 13
                Return "trece"
            Case 14
                Return "catorce"
            Case 15
                Return "quince"
            Case 16
                Return "dieciséis"
            Case 17
                Return "diecisiete"
            Case 18
                Return "dieciocho"
            Case 19
                Return "diecinueve"
            Case 20
                Return "veinte"
            Case 30
                Return "treinta"
            Case 40
                Return "cuarenta"
            Case 50
                Return "cincuenta"
            Case 60
                Return "sesenta"
            Case 70
                Return "setenta"
            Case 80
                Return "ochenta"
            Case 90
                Return "noventa"
            Case 100
                Return "ciento"
            Case 200
                Return "doscientos"
            Case 300
                Return "trescientos"
            Case 400
                Return "cuatrocientos"
            Case 500
                Return "quinientos"
            Case 600
                Return "seiscientos"
            Case 700
                Return "setecientos"
            Case 800
                Return "ochocientos"
            Case 900
                Return "novecientos"
            Case 1000
                Return "mil"
        End Select
        Return ""
    End Function
    Private Function DistribuirCadenas(ByVal Cadena1 As String, ByVal Cadena2 As String, ByVal Cadena3 As String) As String
        Dim C1L As Integer
        Dim C2L As Integer
        Dim i As Integer = 1
        Dim Aux1 As String = ""

        C2L = Cadena3.Length
        C1L = Cadena1.Length
        If C1L > 20 Then
            Cadena1 = Cadena1.Substring(0, 20) + " "
        Else
            Cadena1 = Cadena1 + "                    "
            Cadena1 = Cadena1.Substring(0, 21)
        End If

        C1L = Cadena2.Length
        If C1L = 1 Then
            Cadena2 = " " + Cadena2
            C1L = Cadena2.Length
        End If

        If (C1L + C2L) < 12 Then
            For i = 1 To (11 - (C1L + C2L))
                Aux1 = Aux1 + " "
            Next
            Cadena3 = Aux1 + Cadena3
        End If
        Cadena1 = Cadena1 + Cadena2 + Cadena3
        Return Cadena1
    End Function
#End Region
#Region "Operaciones basicas con la impresora"
    Private Function Imprimir() As Boolean
        'pd As New PrintDocument
        Try
            If PD.PrinterSettings.IsValid Then
                PD.DocumentName = "Ticket"
                PD.PrinterSettings.PrinterName = _Impresora
                PD.PrintController = New StandardPrintController

                AddHandler PD.PrintPage, AddressOf Mikrotik

                If _Prevosualizacion Then
                    _PrintView.Document = PD
                    _PrintView.Show()
                Else
                    PD.Print()
                End If
                '_PrintView.Document = PD
                '_PrintView.Show()
                'PD.Print()
            Else
                Return False
            End If

            PD = Nothing
            'PD.Dispose()
            PDBody = Nothing
            'PDBody.HasMorePages = False
            'PDBody.Cancel = True
            'PDBody.Graphics.Dispose()


            Return True
        Catch ex As Exception
            If _MostrarError Then
                MsgBox("¡Error al intentar imprimir!: " + ex.ToString, vbCritical)
            End If
            Return False
        End Try
    End Function

    Private Sub Mikrotik(sender As Object, e As PrintPageEventArgs)   '*****************************************************
        'Dim i As Integer
        Dim aux As Boolean = False

        StartPrint(e)
        eSpace(8)

        If _Logotipo IsNot Nothing Then
            PrintImage(_Logotipo)
            eSpace(5)
        End If

        If Not _Empresa = "" Then
            PrintText(_Empresa, fEmpresa, 1)
            'eSpace(5)
        End If

        If Not _Fecha = "" Then
            PrintText(_Fecha, fFecha, 1)
            eSpace(5)
        End If

        eLine()

        If _QR IsNot Nothing Then
            PrintImage(_QR)
            eSpace(5)
        End If

        eLine()

        If Not Plan = "" Then
            PrintText(Plan, fEmpresa, 1)
            eSpace(5)
        End If

        If Not _Usuario = "" And Not _Password = "" Then
            PrintText("Usuario: " & _Usuario, fEmpresa, 1)
        ElseIf Not _Usuario = "" Then
            PrintText("PIN: " & _Usuario, fEmpresa, 1)
        End If

        If Not _Password = "" Then
            PrintText("Password: " & _Password, fEmpresa, 1)
        End If

        eLine()

        eSpace(_EspacioPie)
        PrintText(".", fPie, 2)
        e = EndPrint()
        'PD.Dispose()
    End Sub

    Private Sub PrintDocu_PrintPage(sender As Object, e As PrintPageEventArgs)   '*****************************************************
        Dim i As Integer
        Dim Filas As Integer
        Dim aux As Boolean = False
        StartPrint(e)
        eSpace(15)
        Filas = Tabla.Rows.Count

        If Tabla(0, Filas - 1).Value = "" Then
            Filas -= 1
        End If

        If _Logotipo IsNot Nothing Then
            PrintImage(_Logotipo)
            eSpace(5)
        End If

        If Not _Fecha = "" Then
            PrintText(_Fecha, fFecha, 1)
            eSpace(5)
        End If

        'MsgBox(Tabla.Rows.Count)
        PrintText(Tabla(0, 0).Value, fResultado, 2)
        For i = 1 To Filas - 4
            PrintText(Tabla(0, i).Value, fSuma, 2)
        Next
        If Operacion = "*" Then
            Operacion = "x"
        End If
        PrintTextFinal(Operacion, fMultiplicacion, Tabla(0, i).Value, fSuma, 2)
        PrintText(Tabla(0, i + 1).Value, fMultiplicacion, 2)
        PrintText(Tabla(0, i + 2).Value, fResultado, 2)


        'MsgBox(i)

        'For Each row As DataGridViewRow In _Tabla.Rows
        'PrintText(row.Cells(0).Value, fSuma, 2)
        'Next



        If Not _Empresa = "" Then
            'eSpace(3)
            PrintText(_Empresa, fEmpresa, 1)
        End If

        eSpace(15)
        PrintText(".", fPie, 2)
        e = EndPrint()
        'PD.Dispose()
    End Sub

    ''' <summary>
    ''' Agrega una linea al documento. Alineación: 0-> Izquierda; 1->Centro; 2-> Derecha
    ''' </summary>
    ''' <param name="Texto">Texto a imprimir</param>
    ''' <param name="Fuente_Ope">Titulo; Encabezado; Cuerpo; Columna</param>
    ''' <param name="Alineacion">Alineación: 0-> Izquierda; 1->Centro; 2-> Derecha</param>
    ''' <remarks></remarks>

    Private Sub PrintTextFinal(ByVal Ope As String, ByVal Fuente_Ope As Font, ByVal Texto As String, ByVal Fuente_Texto As Font, Optional ByVal Alineacion As Integer = 1)
        Dim TFuente As Decimal = 12
        If Not IsNothing(PDBody) Then
            Select Case Alineacion
                Case 0
                    _Aling = eLeft
                Case 1
                    _Aling = eCenter
                Case 2
                    _Aling = eRight
                Case Else
                    _Aling = eCenter
            End Select
            TFuente = PDBody.Graphics.MeasureString(Texto, Fuente_Texto).Height
            If PDBody.Graphics.MeasureString(Texto, Fuente_Texto).Width > Ancho_Hoja Then
                If (PDBody.Graphics.MeasureString(Texto, Fuente_Texto).Width / _AnchoHoja) Mod 1 Then
                    TFuente = TFuente * (Fix((PDBody.Graphics.MeasureString(Texto, Fuente_Texto).Width / _AnchoHoja) + 1))
                Else
                    TFuente = TFuente * (PDBody.Graphics.MeasureString(Texto, Fuente_Texto).Width / _AnchoHoja)
                End If
            Else
                Fuente_Texto.GetHeight(PDBody.Graphics)
            End If
            AreaImpresion = New Rectangle(_X, _Y, Ancho_Hoja, TFuente)
            PDBody.Graphics.DrawString("     " + Ope, Fuente_Ope, Brushes.Black, AreaImpresion, eLeft)
            PDBody.Graphics.DrawString(Texto, Fuente_Texto, Brushes.Black, AreaImpresion, eRight)
            _Y = _Y + TFuente
        Else
            If _MostrarError Then
                MsgBox("¡No se ha indicado el inicio de documento al crear el Ticket!", vbOKOnly + vbExclamation, "Ticket")
            End If
        End If
    End Sub
    Private Sub PrintText(ByVal Texto As String, ByVal Fuente_F As Font, Optional ByVal Alineacion As Integer = 1)
        Dim TFuente As Decimal = 12
        If Not IsNothing(PDBody) Then
            Select Case Alineacion
                Case 0
                    _Aling = eLeft
                Case 1
                    _Aling = eCenter
                Case 2
                    _Aling = eRight
                Case Else
                    _Aling = eCenter
            End Select
            TFuente = PDBody.Graphics.MeasureString(Texto, Fuente_F).Height
            If PDBody.Graphics.MeasureString(Texto, Fuente_F).Width > Ancho_Hoja Then
                If (PDBody.Graphics.MeasureString(Texto, Fuente_F).Width / _AnchoHoja) Mod 1 Then
                    TFuente = TFuente * (Fix((PDBody.Graphics.MeasureString(Texto, Fuente_F).Width / _AnchoHoja) + 1))
                Else
                    TFuente = TFuente * (PDBody.Graphics.MeasureString(Texto, Fuente_F).Width / _AnchoHoja)
                End If
            Else
                Fuente_F.GetHeight(PDBody.Graphics)
            End If
            AreaImpresion = New Rectangle(_X, _Y, Ancho_Hoja, TFuente)
            PDBody.Graphics.DrawString(Texto, Fuente_F, Brushes.Black, AreaImpresion, _Aling)
            _Y = _Y + TFuente
        Else
            If _MostrarError Then
                MsgBox("¡No se ha indicado el inicio de documento al crear el Ticket!", vbOKOnly + vbExclamation, "Ticket")
            End If
        End If
    End Sub

    Private Sub PrintImage(ByVal Imagen As Image)
        Dim ImagenW As Integer
        Dim ImagenH As Integer
        Dim XPos As Integer
        Dim Alto As Integer
        Dim aux As Integer
        Dim AnchoDeseado As Integer

        aux = 0
        AnchoDeseado = 140
        Alto = (AnchoDeseado * Imagen.Height) / Imagen.Width
        Dim imagen2 As New Bitmap(New Bitmap(Imagen), AnchoDeseado, Alto)


        ImagenH = imagen2.Height
        ImagenW = imagen2.Width
        If _AnchoHoja > ImagenW Then
            XPos = (_AnchoHoja - imagen2.Width) \ 2
        Else
            XPos = 0
        End If

        XPos = (Ancho_Hoja - AnchoDeseado) / 2

        AreaImpresion = New Rectangle(XPos, _Y, imagen2.Width, imagen2.Height)
        PDBody.Graphics.DrawImage(Imagen, AreaImpresion)
        _Y = _Y + imagen2.Height

    End Sub
    ''' <summary>
    ''' Indica el termino de un impresión
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function EndPrint() As PrintPageEventArgs
        PDBody.HasMorePages = False
        Return PDBody
    End Function
    Private Sub eSpace(Optional ByVal num As Integer = 1)
        Dim Fuente_F As New Font("Arial", 10, FontStyle.Regular)
        Dim TFuente As Decimal
        'Dim Texto As String = "- - - - - - - - - - - - - - - - - - - - - - - - - - - -"

        TFuente = Fuente_F.GetHeight(PDBody.Graphics)
        AreaImpresion = New Rectangle(_X, _Y, Ancho_Hoja, _Espacio * num)
        PDBody.Graphics.DrawRectangle(Pens.White, AreaImpresion)
        _Y = _Y + (num * _Espacio)
    End Sub
    Private Sub eLine()
        Dim Fuente_F As New Font("Arial", 10, FontStyle.Regular)
        Dim TFuente As Decimal
        Dim Texto As String = "- - - - - - - - - - - - - - - - - - - - - - - - - - - -"
        TFuente = Fuente_F.GetHeight(PDBody.Graphics)
        AreaImpresion = New Rectangle(_X, _Y, Ancho_Hoja, TFuente)
        PDBody.Graphics.DrawString(Texto, Fuente_F, Brushes.Black, AreaImpresion, _Aling)
        _Y = _Y + TFuente
    End Sub
    ''' <summary>
    ''' Indica el inicio de la creación de un documento
    ''' </summary>
    ''' <param name="e">PrintPageEventArgs</param>
    ''' <remarks></remarks>
    Private Sub StartPrint(ByVal e As PrintPageEventArgs)
        'PDBody = Nothing
        PDBody = e
    End Sub
#End Region
#End Region
End Class
