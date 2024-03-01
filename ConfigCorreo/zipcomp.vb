Imports System.IO
Imports ICSharpCode.SharpZipLib.Core
Imports ICSharpCode.SharpZipLib.Zip
Public Class zipcomp
    'Public ARCH As String

    'Public Shared Function ZIPEAR(ByVal archivo As String) As Boolean
    '    'Dim astrFileNames() As String = Directory.GetFiles(CARP)
    '    Dim strmZipOutputStream As ZipOutputStream
    '    'strmZipOutputStream = New ZipOutputStream(File.Create(archivo2))
    '    Try

    '        strmZipOutputStream.SetLevel(9)
    '        Dim strFile As String = archivo
    '        Dim abyBuffer(4096) As Byte ' 4096
    '        'For Each strFile In astrFileNames
    '        Dim strmFile As FileStream = File.OpenRead(strFile)
    '        Try
    '            Dim D As String = strFile.Substring(strFile.LastIndexOf("\") + 1).ToString
    '            Dim objZipEntry As ZipEntry = New ZipEntry(D)
    '            objZipEntry.DateTime = DateTime.Now
    '            objZipEntry.Size = strmFile.Length
    '            strmZipOutputStream.PutNextEntry(objZipEntry)
    '            StreamUtils.Copy(strmFile, strmZipOutputStream, abyBuffer)
    '        Finally
    '            strmFile.Close()
    '        End Try
    '        'Next
    '        strmZipOutputStream.Finish()
    '    Finally
    '        strmZipOutputStream.Close()
    '    End Try
    '    strmZipOutputStream.Dispose()

    'End Function



End Class
