Imports System
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Reflection
Imports System.Windows.Forms

Namespace Loader
    ''' <summary>
    ''' This service resolved the types and is required when using the
    ''' CodeDomHostLoader
    ''' </summary>
    Public Class TypeResolutionService
        Implements ITypeResolutionService

        Private ht As Hashtable = New Hashtable()

        Public Sub New()
        End Sub

        Public Function GetAssembly(ByVal name As AssemblyName) As Assembly Implements ITypeResolutionService.GetAssembly
            Return GetAssembly(name, True)
        End Function

        Public Function GetAssembly(ByVal name As AssemblyName, ByVal throwOnErrors As Boolean) As Assembly Implements ITypeResolutionService.GetAssembly
            Return Assembly.GetAssembly(GetType(Form))
        End Function

        Public Function GetPathOfAssembly(ByVal name As AssemblyName) As String Implements ITypeResolutionService.GetPathOfAssembly
            Return Nothing
        End Function

        Public Overloads Function [GetType](ByVal name As String) As Type Implements ITypeResolutionService.GetType
            Return [GetType](name, True)
        End Function

        Public Overloads Function [GetType](ByVal name As String, ByVal throwOnError As Boolean) As Type Implements ITypeResolutionService.GetType
            Return [GetType](name, throwOnError, False)
        End Function


        ''' <summary>
        ''' This method is called when dropping controls from the toolbox
        ''' to the host that is loaded using CodeDomHostLoader. For
        ''' simplicity we just go through System.Windows.Forms assembly
        ''' </summary>
        Public Overloads Function [GetType](ByVal name As String, ByVal throwOnError As Boolean, ByVal ignoreCase As Boolean) As Type Implements ITypeResolutionService.GetType
            If ht.ContainsKey(name) Then Return CType(ht(name), Type)
            Dim winForms = Assembly.GetAssembly(GetType(Button))
            Dim types As Type() = winForms.GetTypes()
            Dim typeName = String.Empty

            For Each type In types
                typeName = "system.windows.forms." & type.Name.ToLower()

                If Equals(typeName, name.ToLower()) Then
                    ht(name) = type
                    Return type
                End If
            Next

            Return Type.GetType(name)
        End Function

        Public Sub ReferenceAssembly(ByVal name As AssemblyName) Implements ITypeResolutionService.ReferenceAssembly
        End Sub
    End Class ' class
End Namespace ' namespace


