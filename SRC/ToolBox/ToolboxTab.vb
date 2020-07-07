Namespace ToolboxLibrary
    ''' <summary>
    ''' ToolboxTabs.
    ''' </summary>
    Public Class ToolboxTab
        Private m_name As String = Nothing
        Private m_toolboxItemCollection As ToolboxItemCollection = Nothing

        Public Sub New()
        End Sub

        Public Property Name As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property

        Public Property ToolboxItems As ToolboxItemCollection
            Get
                Return m_toolboxItemCollection
            End Get
            Set(ByVal value As ToolboxItemCollection)
                m_toolboxItemCollection = value
            End Set
        End Property
    End Class
End Namespace
