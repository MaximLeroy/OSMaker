Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.Diagnostics

Namespace OSMaker
    ''' <summary>
    ''' This is responsible for naming the components as they are created.
    ''' This is added as a servide by the HostSurfaceManager
    ''' </summary>
    Public Class NameCreationService
        Implements INameCreationService

        Public Sub New()
        End Sub

        Private Function CreateName(ByVal container As IContainer, ByVal type As Type) As String Implements INameCreationService.CreateName
            Dim cc = container.Components
            Dim min = Integer.MaxValue
            Dim max = Integer.MinValue
            Dim count = 0

            For i = 0 To cc.Count - 1
                Dim comp As Component = TryCast(cc(i), Component)

                If comp.GetType() Is type Then
                    count += 1
                    Dim name = comp.Site.Name

                    If name.StartsWith(type.Name) Then

                        Try
                            Dim value = Integer.Parse(name.Substring(type.Name.Length))
                            If value < min Then min = value
                            If value > max Then max = value
                        Catch ex As Exception
                            Trace.WriteLine(ex.ToString())
                        End Try
                    End If
                End If
            Next ' for
            If count = 0 Then
                Return type.Name & "1"
            ElseIf min > 1 Then
                Dim j = min - 1
                Return type.Name & j.ToString()
            Else
                Dim j = max + 1
                Return type.Name & j.ToString()
            End If
        End Function

        Private Function IsValidName(ByVal name As String) As Boolean Implements INameCreationService.IsValidName
            Return True
        End Function

        Private Sub ValidateName(ByVal name As String) Implements INameCreationService.ValidateName
            Return
        End Sub
    End Class ' class
End Namespace ' namespace

