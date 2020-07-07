Imports System

Namespace ToolboxLibrary
    ''' <summary>
    ''' ToolboxItem.
    ''' </summary>
    Public Class ToolboxItem
        Private m_name As String = Nothing
        Private m_type As Type = Nothing

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

        Public Property Type As Type
            Get
                Return m_type
            End Get
            Set(ByVal value As Type)
                m_type = value
            End Set
        End Property
    End Class
End Namespace
