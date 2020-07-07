Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.Serialization
Imports System.Collections
Imports System.Windows.Forms
Imports System.CodeDom

Namespace OSMaker
    ''' <summary>
    ''' This is used by the CodeDomHostLoader to generate the CodeCompleUnit
    ''' </summary>
    Friend Class CodeGen
        Private codeCompileUnit As CodeCompileUnit
        Private ns As CodeNamespace
        Private myDesignerClass As CodeTypeDeclaration = New CodeTypeDeclaration()
        Private initializeComponent As CodeMemberMethod = New CodeMemberMethod()
        Private host As IDesignerHost
        Private root As IComponent
        Private Shared ReadOnly propertyAttributes As Attribute() = New Attribute() {DesignOnlyAttribute.No}


        ''' <summary>
        ''' This function generates the default CodeCompileUnit template
        ''' </summary>
        Public Function GetCodeCompileUnit(ByVal host As IDesignerHost) As CodeCompileUnit
            Me.host = host
            Dim idh = CType(Me.host.GetService(GetType(IDesignerHost)), IDesignerHost)
            root = idh.RootComponent
            Dim nametable As Hashtable = New Hashtable(idh.Container.Components.Count)
            ns = New CodeNamespace("DesignerHostSample")
            myDesignerClass = New CodeTypeDeclaration()
            initializeComponent = New CodeMemberMethod()
            Dim code As CodeCompileUnit = New CodeCompileUnit()

            ' Imports
            ns.Imports.Add(New CodeNamespaceImport("System"))
            ns.Imports.Add(New CodeNamespaceImport("System.ComponentModel"))
            ns.Imports.Add(New CodeNamespaceImport("System.Windows.Forms"))
            code.Namespaces.Add(ns)
            myDesignerClass = New CodeTypeDeclaration(root.Site.Name)
            myDesignerClass.BaseTypes.Add(GetType(Form).FullName)
            Dim manager As IDesignerSerializationManager = TryCast(host.GetService(GetType(IDesignerSerializationManager)), IDesignerSerializationManager)
            ns.Types.Add(myDesignerClass)

            ' Constructor
            Dim con As CodeConstructor = New CodeConstructor()
            con.Attributes = MemberAttributes.Public
            con.Statements.Add(New CodeMethodInvokeExpression(New CodeMethodReferenceExpression(New CodeThisReferenceExpression(), "InitializeComponent")))
            myDesignerClass.Members.Add(con)

            ' Main
            Dim main As CodeEntryPointMethod = New CodeEntryPointMethod()
            main.Name = "Main"
            main.Attributes = MemberAttributes.Public Or MemberAttributes.Static
            main.CustomAttributes.Add(New CodeAttributeDeclaration("System.STAThreadAttribute"))
            main.Statements.Add(New CodeMethodInvokeExpression(New CodeMethodReferenceExpression(New CodeTypeReferenceExpression(GetType(Application)), "Run"), New CodeExpression() {New CodeObjectCreateExpression(New CodeTypeReference(root.Site.Name))}))
            myDesignerClass.Members.Add(main)

            ' InitializeComponent
            initializeComponent.Name = "InitializeComponent"
            initializeComponent.Attributes = MemberAttributes.Private
            ''' Cannot convert AssignmentExpressionSyntax, System.InvalidCastException: Impossible d'effectuer un cast d'un objet de type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' en type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
            '''    à ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
            '''    à Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
            '''    à Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
            '''    à ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
            ''' 
            ''' Input:
            '''             this.initializeComponent.ReturnType = new System.CodeDom.CodeTypeReference(typeof(void))
            ''' 
            myDesignerClass.Members.Add(initializeComponent)
            codeCompileUnit = code
            Return codeCompileUnit
        End Function
    End Class ' class
End Namespace ' namespace
