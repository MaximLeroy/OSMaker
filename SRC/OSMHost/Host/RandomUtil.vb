Imports System
Imports System.Drawing

Namespace OSMaker
    ''' <summary>
    ''' Generated random color. It is used by MyRootDesigner
    ''' </summary>
    Public Class RandomUtil
        Friend Const MaxRGBInt = 255
        Private Shared rand As Random = Nothing

        Public Sub New()
            If rand Is Nothing Then InitializeRandoms(New Random().Next())
        End Sub

        Private Sub InitializeRandoms(ByVal seed As Integer)
            rand = New Random(seed)
        End Sub

        Public Overridable Function GetColor() As Color
            Dim rval, gval, bval As Byte
            rval = CByte(GetRange(0, MaxRGBInt))
            gval = CByte(GetRange(0, MaxRGBInt))
            bval = CByte(GetRange(0, MaxRGBInt))
            Dim c = Color.FromArgb(rval, gval, bval)
            Return c
        End Function

        Public Function GetRange(ByVal nMin As Integer, ByVal nMax As Integer) As Integer
            ' Swap max and min if min > max
            If nMin > nMax Then
                Dim nTemp = nMin
                nMin = nMax
                nMax = nTemp
            End If

            If nMax <> Integer.MaxValue Then Threading.Interlocked.Increment(nMax)
            Dim retVal = rand.Next(nMin, nMax)
            Return retVal
        End Function
    End Class
End Namespace
