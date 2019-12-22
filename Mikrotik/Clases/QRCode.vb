Imports ThoughtWorks.QRCode.Codec
Public Class QRCode
    Private colorFondoQR As Integer = Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer = Color.FromArgb(255, 0, 0, 0).ToArgb

    Public Function GenerarQR(ByVal URL As String) As Bitmap
        Dim Imagen As New Bitmap(10, 10)
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder

        generarCodigoQR.QRCodeEncodeMode =
        QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = 4

        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M

        'La versión "0" calcula automáticamente el tamaño
        generarCodigoQR.QRCodeVersion = 0

        generarCodigoQR.QRCodeBackgroundColor = Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = Color.FromArgb(colorQR)

        Try
            Imagen = generarCodigoQR.Encode(URL, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
        Return Imagen
    End Function
End Class
