﻿Imports FastColoredTextBoxNS
Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace OSMaker
    Public Class TbInfo2
        Public bookmarksLineId As HashSet(Of Integer) = New HashSet(Of Integer)()

        Public bookmarks As List(Of Integer) = New List(Of Integer)()

        Public popupMenu As AutocompleteMenu
    End Class
End Namespace