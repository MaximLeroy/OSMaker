Imports FastColoredTextBoxNS
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports System.Xml
Imports System.Text

Public Module ModuleCpcDosCplus
        Public Sub GenTextCpc(stringXML As String)
            LoadWinToCpcControls()
            sb = New StringBuilder
            doc = New XmlDocument()

            'le code qui suit remets en place le noeud xml "RACINE" xml 
            ' comme  deja car la prop GetCode dans BasicHostLoader la supprime
            Dim cleandown As String = stringXML
            cleandown = "<DOCUMENT_ELEMENT>" + stringXML + "</DOCUMENT_ELEMENT>"

            doc.LoadXml(cleandown)

            Dim root As XmlNode = doc.DocumentElement
            For Each node As XmlNode In root.ChildNodes
                WriteNodeObject(node, sb)

            Next

            Dim cpcFileName As String = GetFileNameToSave() 'obtient le nom de fichier CPC à sauvegarder
            If cpcFileName IsNot Nothing Then
                File.WriteAllText(cpcFileName, sb.ToString)

            End If

        End Sub
        Private Moncurrentnode As XmlNode
        Private Monsbuilder As StringBuilder
    Public Property parametrescheckB As Boolean
    Public Property bordtextS As String
    Public nameTypes() As String = {}
    Private Sub WriteNodeObject(currentNode As XmlNode, sbuilder As StringBuilder)

        Dim names() As String = {}


            If currentNode.Name = "Object" Then ' c'est un node Object i.e. un Control
                nameTypes = currentNode.Attributes.GetNamedItem("type").Value.Split(New Char() {","})
                names = currentNode.Attributes.GetNamedItem("name").Value.Split(New Char() {","})

            Select Case nameTypes(0)

                    Case WinToCpcControls.Keys(0)

                    sbuilder.Append(WinToCpcControls.Values(0))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        'XPATH  un autre operateut  XML fait des miracles 
                        'lit tou les nodes "Property" sous le currentNode
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                    'If parametrescheckB = True Then
                    '    sbuilder.AppendLine(".   Parameters" + "   " + " = """ + bordtextS & ctntextS & typetextS & "OMBRE:" & ombretextS + """")
                    'End If
                    'If OpacitetextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   Opacite" + "      " + " = """ + OpacitetextS + """")
                    'End If
                    '    If CouleurfenetretextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   WindowColor" + "  " + " = """ + CouleurfenetretextS + """")
                    'End If
                    '    If couleurtitretextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   TitleColor" + "   " + " = """ + couleurtitretextS + """")
                    'End If
                    '    If couleurfondtextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   BackColor" + "    " + " = """ + couleurfondtextS + """")

                    'End If
                    '    If iconetextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   Icone" + "        " + " = """ + iconetextS + """")
                    'End If
                    '    If imgtitretextS = Nothing Then
                    '    Else
                    '    sbuilder.AppendLine(".   ImgTitre" + "     " + " = """ + imgtitretextS + """")
                    'End If
                    sbuilder.AppendLine("@#" & HandletextS & " Create/ ")

                    sbuilder.AppendLine(CpcDebutToFins.Values(0))
                    Case WinToCpcControls.Keys(1)
                        sbuilder.Append(WinToCpcControls.Values(1))
                        sbuilder.AppendLine(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(1))
                    Case WinToCpcControls.Keys(2)
                        sbuilder.Append(WinToCpcControls.Values(2))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(2))
                    Case WinToCpcControls.Keys(3)
                        sbuilder.Append(WinToCpcControls.Values(3))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(3))
                    Case WinToCpcControls.Keys(4)
                        sbuilder.Append(WinToCpcControls.Values(4))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(4))
                    Case WinToCpcControls.Keys(5)
                        sbuilder.Append(WinToCpcControls.Values(5))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(5))
                    Case WinToCpcControls.Keys(6)
                        sbuilder.Append(WinToCpcControls.Values(6))
                        sbuilder.Append(" " + names(0))
                        sbuilder.AppendLine()
                        Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                        For Each item As XmlNode In childrops
                            WriteNodeProperty(item, sbuilder)
                        Next
                        sbuilder.AppendLine("Create/")
                        sbuilder.AppendLine(CpcDebutToFins.Values(6))
                End Select
                sbuilder.AppendLine()
                For Each itemNode In currentNode.ChildNodes
                    WriteNodeObject(itemNode, sbuilder) 'appel recurif car XML genere en fait un tree
                Next
            End If
            Dim code As String = sbuilder.ToString()
            tbS = code
        End Sub
    Private Lesparametres As String = ""
    Public CTNnum As String = "1"
    Public TYPEnum As String = "0"
    Private Sub WriteNodeProperty(currentNode As XmlNode, sbuilder As StringBuilder)
            Dim name As String
            Dim propertyValues() As String
            Dim propertyValues2 As String


        propertyValues = currentNode.InnerText.Split(New Char() {","})
        propertyValues2 = currentNode.InnerText
        name = currentNode.Attributes.GetNamedItem("name").Value


        If name = "Text" Then
            sbuilder.AppendLine("   .Text" + "         " + " = """ + propertyValues(0) + """")

        ElseIf name = "HANDLEFENETRE" Then
            HandletextS = propertyValues(0)

        ElseIf name = "CTN" Then
            If (propertyValues2 = "True") Then
                CTNnum = "0"

            ElseIf (propertyValues2 = "False") Then
                CTNnum = "1"
            ElseIf (propertyValues2 = Nothing) Then 'False par défaut donc valeur nulle
                CTNnum = "0"
            End If
        ElseIf name = "Type" Then
            If (propertyValues2 = "Sans_conteneur_visible") Then
                TYPEnum = "1"


            ElseIf (propertyValues2 = Nothing) Then
                TYPEnum = "0"
            ElseIf (propertyValues2 = "Normale") Then
                TYPEnum = "0"
            ElseIf (propertyValues2 = "Sans_bitmap_de_titre") Then
                TYPEnum = "2"
            ElseIf (propertyValues2 = "Sans_bitmap_de_titre_et_sans_conteneur_visible") Then
                TYPEnum = "3"
            ElseIf (propertyValues2 = "Sans_barre_de_titre") Then
                TYPEnum = "4"
            ElseIf (propertyValues2 = "Sans_barre_de_titre_et_sans_conteneur_visible") Then
                TYPEnum = "5"

            End If

        ElseIf name = "Parameters" Then
            If propertyValues2 = Nothing Then
            ElseIf (propertyValues2 = "True") Then

                sbuilder.Append("   .Parameters" + "   " + " = """)
                sbuilder.Append("CTN:" + CTNnum)
                sbuilder.Append("TYPE:" + TYPEnum)
                sbuilder.Append("BORD:" + TYPEnum)
                sbuilder.Append("SHADOW:" + TYPEnum)
                sbuilder.Append("MOVE:" + TYPEnum)
                sbuilder.Append("SIZ:" + TYPEnum)
                sbuilder.Append("SIZBTN:" + TYPEnum)
                sbuilder.Append("REDUCT:" + TYPEnum)
                sbuilder.Append("CLOSE:" + TYPEnum)
                sbuilder.Append("TASKBAR:" + TYPEnum)
                sbuilder.Append("""")
                sbuilder.AppendLine()
            End If



        ElseIf name = "Handle" Then

            HandletextS = propertyValues2

            sbuilder.AppendLine("   .Handle" + "       " + " = """ + "%" & HandletextS & "%" + """")

        ElseIf name = "Location" Then
                sbuilder.Append("   .PX" + "           " + " = """ + propertyValues(0).Trim + """")
                sbuilder.AppendLine()
                sbuilder.AppendLine("   .PY" + "           " + " = """ + propertyValues(1).Trim + """")
            ElseIf name = "ClientSize" Or name = "Size" Then
                sbuilder.Append("   .SX" + "           " + " = """ + propertyValues(0).Trim + """")
                sbuilder.AppendLine()
                sbuilder.AppendLine("   .SY" + "           " + " = """ + propertyValues(1).Trim + """")

            ElseIf name = "BackColor" Then
                Dim r As String = "0"
                Dim g As String = "0"
                Dim b As String = "0"
                Dim colorname As Color
                Dim rgb As String()
                Try
                    colorname = Color.FromName(propertyValues2)

                    r = colorname.R.ToString
                    g = colorname.G.ToString
                    b = colorname.B.ToString


                Catch
                End Try

                If r = "0" Then
                    Try
                        rgb = propertyValues2.Trim.Replace(" ", String.Empty).Split(",")
                        r = Integer.Parse(rgb(0))
                        g = Integer.Parse(rgb(1))
                        b = Integer.Parse(rgb(2))
                    Catch
                    End Try
                End If

                Dim red As Integer = String.Format("{0:D3}", r)
                Dim green As Integer = String.Format("{0:D3}", g)
                Dim blue As Integer = String.Format("{0:D3}", b)


                If propertyValues2 = Nothing Then
                Else
                    sbuilder.Append("   .BackColor" + "    " + " = """ + String.Format("{0:D3}", red) + "," + String.Format("{0:D3}", green) + "," + String.Format("{0:D3}", blue) + """")
                    sbuilder.AppendLine()

                End If

            ElseIf name = "ForeColor" Then
                Dim r As String = ""
                Dim g As String = ""
                Dim b As String = ""
                Dim colorname As Color
                Dim rgb As String()
                Try
                    colorname = Color.FromName(propertyValues2)

                    r = colorname.R.ToString
                    g = colorname.G.ToString
                    b = colorname.B.ToString


                Catch
                End Try

                If r = "0" Then
                    Try
                        rgb = propertyValues2.Trim.Replace(" ", String.Empty).Split(",")
                        r = Integer.Parse(rgb(0))
                        g = Integer.Parse(rgb(1))
                        b = Integer.Parse(rgb(2))
                    Catch
                    End Try
                End If

                Dim red As Integer = String.Format("{0:D3}", r)
                Dim green As Integer = String.Format("{0:D3}", g)
                Dim blue As Integer = String.Format("{0:D3}", b)


                If propertyValues2 = Nothing Then
                Else
                    sbuilder.Append("   .TextColor" + "    " + " = """ + String.Format("{0:D3}", red) + "," + String.Format("{0:D3}", green) + "," + String.Format("{0:D3}", blue) + """")
                    sbuilder.AppendLine()
                End If
            ElseIf name = "Checked" Then
                Dim valeur As String = If(propertyValues(0) = "True", "1", "0")
                sbuilder.AppendLine("   .Value" + "        " + " = """ + valeur + """")
            ElseIf name = "EVENT_PATH" Then
                If propertyValues2 = Nothing Then
                Else
                    sbuilder.Append("   .Event" + "        " + " = """ + propertyValues2.Trim + """")
                    sbuilder.AppendLine()
                End If
            ElseIf name = "IMGAUTO" Then
                If propertyValues2 = Nothing Then
                Else
                    IMGAUTO1 = "IMGAUTO:" & propertyValues2
                End If
            ElseIf name = "COL" Then
                If propertyValues2 = Nothing Then
                Else
                    COL1 = "COL:" & propertyValues2
                End If
            ElseIf name = "UPD" Then
                If propertyValues2 = True Then

                    UPD1 = "UPD:1"
                End If


            ElseIf name = "Image" Then
                If propertyValues2 = Nothing Then
                Else
                    sbuilder.Append("   .Image" + "        " + " = """ + propertyValues2 + """")
                    sbuilder.AppendLine()
                End If

        End If


    End Sub

    Private IMGAUTO1 As String
        Private MULTILINES1 As String
        Private COL1 As String
        Private UPD1 As String
        Private Sub LoadWinToCpcControls()

            WinToCpcControls = New Dictionary(Of String, String)
        WinToCpcControls.Add("ToolBox.Window", "Window/")
        WinToCpcControls.Add("ToolBox.PictureBox", "PictureBox/")
            WinToCpcControls.Add("ToolBox.CheckBox", "CheckBox/")
            WinToCpcControls.Add("ToolBox.Button", "Button/")
            WinToCpcControls.Add("ToolBox.TextBox", "TextBox/")
            WinToCpcControls.Add("ToolBox.TextBlock", "TextBlock/")
            WinToCpcControls.Add("ToolBox.ProgressBar", "ProgressBar/")

            CpcDebutToFins = New Dictionary(Of String, String)
            CpcDebutToFins.Add("Window/", "End/ Window")
            CpcDebutToFins.Add("PictureBox/", "End/ PictureBox")
            CpcDebutToFins.Add("CheckBox/", "End/ CheckBox")
            CpcDebutToFins.Add("Button/", "End/ Button")
            CpcDebutToFins.Add("TextBox/", "End/ TextBox")
            CpcDebutToFins.Add("TextBlock/", "End/ TextBlock")
            CpcDebutToFins.Add("ProgressBar/", "End/ ProgressBar")
        End Sub
        Private Function GetFileNameToSave() As String
            Dim fileName As String = Nothing
            If NomFichierCpc = Nothing Then
                Dim dlgSaveFile As New SaveFileDialog
                dlgSaveFile.Filter = "Files(.*cpc)|*.cpc"


                If dlgSaveFile.ShowDialog = DialogResult.OK Then
                    fileName = dlgSaveFile.FileName
                    NomFichierCpc = fileName

                    If fileName.Length <> 0 Then
                        Return fileName

                    End If
                End If
            Else
                fileName = NomFichierCpc
            End If
            Return fileName

        End Function

        Private root As IComponent
        Public Property WinToCpcControls As Dictionary(Of String, String)
        Public Property CpcDebutToFins As Dictionary(Of String, String)
        Public Property sb As StringBuilder
        Public Property ctntextS As String = ""
        Public Property typetextS As String = ""
        Public Property ombretextS As String = ""
        Public Property OpacitetextS As String = ""
        Public Property CouleurfenetretextS As String = ""
        Public Property couleurtitretextS As String = ""
        Public Property couleurfondtextS As String = ""
        Public Property iconetextS As String = ""
        Public Property imgtitretextS As String = ""

        Public Property HandletextS As String = ""
        Public Property doc As XmlDocument
        Public Property tbS As String = "tesxdelatb"
        Public Property NomFichierCpc As String = "Monfichier"
        'AJOUT => UN SAVEDIALOG


    End Module

