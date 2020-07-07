Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.Serialization
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports System.CodeDom.Compiler
Imports System.CodeDom
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic

Namespace Loader
    ''' <summary>
    ''' Inherits from CodeDomDesignerLoader. It can generate C# or VB code
    ''' for a HostSurface. This loader does not support parsing a 
    ''' C# or VB file.
    ''' </summary>
    Public Class CodeDomHostLoader
        Inherits CodeDomDesignerLoader

        Private _csCodeProvider As CSharpCodeProvider = New CSharpCodeProvider()
        Private codeCompileUnit As CodeCompileUnit = Nothing
        Private cg As CodeGen = Nothing
        Private _trs As TypeResolutionService = Nothing
        Private executable As String
        Private f_Run As Process

        Public Sub New()
            _trs = New TypeResolutionService()
        End Sub

        Protected Overrides ReadOnly Property TypeResolutionService As ITypeResolutionService
            Get
                Return _trs
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeDomProvider As CodeDomProvider
            Get
                Return _csCodeProvider
            End Get
        End Property


        ''' <summary>
        ''' Bootstrap method - loads a blank Form
        ''' </summary>
        ''' <returns></returns>
        Protected Overrides Function Parse() As CodeCompileUnit
            Dim ccu As CodeCompileUnit = Nothing
            Dim ds As DesignSurface = New DesignSurface()
            ds.BeginLoad(GetType(Form))
            Dim idh = CType(ds.GetService(GetType(IDesignerHost)), IDesignerHost)
            idh.RootComponent.Site.Name = "Form1"
            cg = New CodeGen()
            ccu = cg.GetCodeCompileUnit(idh)
            Dim names As AssemblyName() = Assembly.GetExecutingAssembly().GetReferencedAssemblies()

            For i = 0 To names.Length - 1
                Dim assembly = System.Reflection.Assembly.Load(names(i))
                ccu.ReferencedAssemblies.Add(assembly.Location)
            Next

            codeCompileUnit = ccu
            Return ccu
        End Function


        ''' <summary>
        ''' When the Loader is Flushed this method is called. The base class
        ''' (CodeDomDesignerLoader) creates the CodeCompileUnit. We
        ''' simply cache it and use this when we need to generate code from it.
        ''' To generate the code we use CodeProvider.
        ''' </summary>
        Protected Overrides Sub Write(ByVal unit As CodeCompileUnit)
            codeCompileUnit = unit
        End Sub

        Protected Overrides Sub OnEndLoad(ByVal successful As Boolean, ByVal errors As ICollection)
            MyBase.OnEndLoad(successful, errors)

            If errors IsNot Nothing Then
                Dim ie As IEnumerator = errors.GetEnumerator()

                While ie.MoveNext()
                    Trace.WriteLine(ie.Current.ToString())
                End While
            End If
        End Sub


#Region "Public methods"

        ''' <summary>
        ''' Flushes the host and returns the updated CodeCompileUnit
        ''' </summary>
        ''' <returns></returns>
        Public Function GetCodeCompileUnit() As CodeCompileUnit
            Flush()
            Return codeCompileUnit
        End Function


        ''' <summary>
        ''' This method writes out the contents of our designer in C# and VB.
        ''' It generates code from our codeCompileUnit using CodeRpovider
        ''' </summary>
        Public Function GetCode(ByVal context As String) As String
            Flush()
            Dim o As CodeGeneratorOptions = New CodeGeneratorOptions()
            o.BlankLinesBetweenMembers = True
            o.BracingStyle = "C"
            o.ElseOnClosing = False
            o.IndentString = "    "

            If Equals(context, "C#") Then
                Dim swCS As StringWriter = New StringWriter()
                Dim cs As CSharpCodeProvider = New CSharpCodeProvider()
                cs.GenerateCodeFromCompileUnit(codeCompileUnit, swCS, o)
                Dim code As String = swCS.ToString()
                swCS.Close()
                Return code
            ElseIf Equals(context, "VB") Then
                Dim swVB As StringWriter = New StringWriter()
                Dim vb As VBCodeProvider = New VBCodeProvider()
                vb.GenerateCodeFromCompileUnit(codeCompileUnit, swVB, o)
                Dim code As String = swVB.ToString()
                swVB.Close()
                Return code
            End If

            Return String.Empty
        End Function



#End Region

#Region "Build and Run"

        ''' <summary>
        ''' Called when we want to build an executable. Returns true if we succeeded.
        ''' </summary>
        Public Function Build() As Boolean
            Flush()


            ' If we haven't already chosen a spot to write the executable to,
            ' do so now.
            If Equals(executable, Nothing) Then
                Dim dlg As SaveFileDialog = New SaveFileDialog()
                dlg.DefaultExt = "exe"
                dlg.Filter = "Executables|*.exe"

                If dlg.ShowDialog() = DialogResult.OK Then
                    executable = dlg.FileName
                End If
            End If

            If Not Equals(executable, Nothing) Then
                ' We need to collect the parameters that our compiler will use.
                Dim cp As CompilerParameters = New CompilerParameters()
                Dim assemblyNames As AssemblyName() = Assembly.GetEntryAssembly().GetReferencedAssemblies()

                For Each an In assemblyNames
                    Dim assembly = System.Reflection.Assembly.Load(an)
                    cp.ReferencedAssemblies.Add(assembly.Location)
                Next

                cp.GenerateExecutable = True
                cp.OutputAssembly = executable

                ' Remember our main class is not Form, but Form1 (or whatever the user calls it)!
                cp.MainClass = "DesignerHostSample." & LoaderHost.RootComponent.Site.Name
                Dim cc As CSharpCodeProvider = New CSharpCodeProvider()
                Dim cr = cc.CompileAssemblyFromDom(cp, codeCompileUnit)

                If cr.Errors.HasErrors Then
                    Dim errors = ""

                    For Each [error] As CompilerError In cr.Errors
                        errors += [error].ErrorText & Microsoft.VisualBasic.Constants.vbLf
                    Next

                    MessageBox.Show(errors, "Errors during compile.")
                End If

                Return Not cr.Errors.HasErrors
            End If

            Return False
        End Function


        ''' <summary>
        ''' Here we build the executable and then run it. We make sure to not start
        ''' two of the same process.
        ''' </summary>
        Public Sub Run()
            If f_Run Is Nothing OrElse f_Run.HasExited Then

                If Build() Then
                    f_Run = New Process()
                    f_Run.StartInfo.FileName = executable
                    f_Run.Start()
                End If
            End If
        End Sub


        ''' <summary>
        ''' Just in case the red X in the upper right isn't good enough,
        ''' we can kill our process here.
        ''' </summary>
        Public Sub [Stop]()
            If f_Run IsNot Nothing AndAlso Not f_Run.HasExited Then
                f_Run.Kill()
            End If
        End Sub

#End Region

    End Class ' class
End Namespace ' namespace

