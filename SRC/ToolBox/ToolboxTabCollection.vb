Imports System
Imports System.Collections

Namespace ToolboxLibrary


    '  Project   : ToolboxLibrary
    '  Class     : ToolboxTabCollection
    ' 
    '  Copyright (C) 2002, Microsoft Corporation
    ' ------------------------------------------------------------------------------
    '  <summary>
    '  Strongly-typed collection of ToolboxTab objects
    '  </summary>
    '  <remarks></remarks>
    '  <history>
    '      [dineshc] 3/26/2003  Created
    '  </history>
    <Serializable()>
    Public Class ToolboxTabCollection
        Inherits CollectionBase


        '''  <summary>
        '''       Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        '''  </summary>
        '''  <remarks></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub New()
        End Sub


        '''  <summary>
        '''       Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/> based on another <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        '''  </summary>
        '''  <paramname="value">
        '''       A <seecref="ToolboxLibrary.ToolboxTabCollection"/> from which the contents are copied
        '''  </param>
        '''  <remarks></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub New(ByVal value As ToolboxTabCollection)
            AddRange(value)
        End Sub


        '''  <summary>
        '''       Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/> containing any array of <seecref="ToolboxLibrary.ToolboxTab"/> objects.
        '''  </summary>
        '''  <paramname="value">
        '''       A array of <seecref="ToolboxLibrary.ToolboxTab"/> objects with which to intialize the collection
        '''  </param>
        '''  <remarks></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub New(ByVal value As ToolboxTab())
            AddRange(value)
        End Sub


        '''  <summary>
        '''  Represents the entry at the specified index of the <seecref="ToolboxLibrary.ToolboxTab"/>.
        '''  </summary>
        '''  <paramname="index">The zero-based index of the entry to locate in the collection.</param>
        '''  <value>
        '''  The entry at the specified index of the collection.
        '''  </value>
        '''  <remarks><exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="index"/> is outside the valid range of indexes for the collection.</exception></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Default Public Property Item(ByVal index As Integer) As ToolboxTab
            Get
                Return CType(List(index), ToolboxTab)
            End Get
            Set(ByVal value As ToolboxTab)
                List(index) = value
            End Set
        End Property


        '''  <summary>
        '''    Adds a <seecref="ToolboxLibrary.ToolboxTab"/> with the specified value to the 
        '''    <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        '''  </summary>
        '''  <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to add.</param>
        '''  <returns>
        '''    The index at which the new element was inserted.
        '''  </returns>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.AddRange"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Function Add(ByVal value As ToolboxTab) As Integer
            Return List.Add(value)
        End Function


        '''  <summary>
        '''  Copies the elements of an array to the end of the <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        '''  </summary>
        '''  <paramname="value">
        '''    An array of type <seecref="ToolboxLibrary.ToolboxTab"/> containing the objects to add to the collection.
        '''  </param>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub AddRange(ByVal value As ToolboxTab())
            Dim i = 0

            While i < value.Length
                Add(value(i))
                i = i + 1
            End While
        End Sub


        '''  <summary>
        '''     
        '''       Adds the contents of another <seecref="ToolboxLibrary.ToolboxTabCollection"/> to the end of the collection.
        '''    
        '''  </summary>
        '''  <paramname="value">
        '''    A <seecref="ToolboxLibrary.ToolboxTabCollection"/> containing the objects to add to the collection.
        '''  </param>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub AddRange(ByVal value As ToolboxTabCollection)
            Dim i = 0

            While i < value.Count
                Add(value(i))
                i = i + 1
            End While
        End Sub


        '''  <summary>
        '''  Gets a value indicating whether the 
        '''    <seecref="ToolboxLibrary.ToolboxTabCollection"/> contains the specified <seecref="ToolboxLibrary.ToolboxTab"/>.
        '''  </summary>
        '''  <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to locate.</param>
        '''  <returns>
        '''  <seelangword="true"/> if the <seecref="ToolboxLibrary.ToolboxTab"/> is contained in the collection; 
        '''   otherwise, <seelangword="false"/>.
        '''  </returns>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.IndexOf"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Function Contains(ByVal value As ToolboxTab) As Boolean
            Return List.Contains(value)
        End Function


        '''  <summary>
        '''  Copies the <seecref="ToolboxLibrary.ToolboxTabCollection"/> values to a one-dimensional <seecref="System.Array"/> instance at the 
        '''    specified index.
        '''  </summary>
        '''  <paramname="array">The one-dimensional <seecref="System.Array"/> that is the destination of the values copied from <seecref="ToolboxLibrary.ToolboxTabCollection"/> .</param>
        '''  <paramname="index">The index in <paramrefname="array"/> where copying begins.</param>
        '''  <remarks><exceptioncref="System.ArgumentException"><paramrefname="array"/> is multidimensional. <para>-or-</para> <para>The number of elements in the <seecref="ToolboxLibrary.ToolboxTabCollection"/> is greater than the available space between <paramrefname="arrayIndex"/> and the end of <paramrefname="array"/>.</para></exception>
        '''  <exceptioncref="System.ArgumentNullException"><paramrefname="array"/> is <seelangword="null"/>. </exception>
        '''  <exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="arrayIndex"/> is less than <paramrefname="array"/>"s lowbound. </exception>
        '''  <seealsocref="System.Array"/>
        '''  </remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub CopyTo(ByVal array As ToolboxTab(), ByVal index As Integer)
            List.CopyTo(array, index)
        End Sub


        '''  <summary>
        '''    Returns the index of a <seecref="ToolboxLibrary.ToolboxTab"/> in 
        '''       the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        '''  </summary>
        '''  <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to locate.</param>
        '''  <returns>
        '''  The index of the <seecref="ToolboxLibrary.ToolboxTab"/> of <paramrefname="value"/> in the 
        '''  <seecref="ToolboxLibrary.ToolboxTabCollection"/>, if found; otherwise, -1.
        '''  </returns>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Contains"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Function IndexOf(ByVal value As ToolboxTab) As Integer
            Return List.IndexOf(value)
        End Function


        '''  <summary>
        '''  Inserts a <seecref="ToolboxLibrary.ToolboxTab"/> into the <seecref="ToolboxLibrary.ToolboxTabCollection"/> at the specified index.
        '''  </summary>
        '''  <paramname="index">The zero-based index where <paramrefname="value"/> should be inserted.</param>
        '''  <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to insert.</param>
        '''  <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub Insert(ByVal index As Integer, ByVal value As ToolboxTab)
            List.Insert(index, value)
        End Sub


        '''  <summary>
        '''    Returns an enumerator that can iterate through 
        '''       the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        '''  </summary>
        '''  <returns>An enumerator for the collection</returns>
        '''  <remarks><seealsocref="System.Collections.IEnumerator"/></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Overloads Function GetEnumerator() As ToolboxTabEnumerator
            Return New ToolboxTabEnumerator(Me)
        End Function


        '''  <summary>
        '''     Removes a specific <seecref="ToolboxLibrary.ToolboxTab"/> from the 
        '''    <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        '''  </summary>
        '''  <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to remove from the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .</paramname>
        '''  <remarks><exceptioncref="System.ArgumentException"><paramrefname="value"/> is not found in the Collection. </exception></remarks>
        '''  <history>
        '''      [dineshc] 3/26/2003  Created
        '''  </history>
        Public Sub Remove(ByVal value As ToolboxTab)
            List.Remove(value)
        End Sub

        Public Class ToolboxTabEnumerator
            Inherits Object
            Implements IEnumerator

            Private baseEnumerator As IEnumerator
            Private temp As IEnumerable

            Public Sub New(ByVal mappings As ToolboxTabCollection)
                temp = mappings
                baseEnumerator = temp.GetEnumerator()
            End Sub

            Public ReadOnly Property p_Current As ToolboxTab
                Get
                    Return CType(baseEnumerator.Current, ToolboxTab)
                End Get
            End Property

            Private ReadOnly Property Current As Object Implements IEnumerator.Current
                Get
                    Return baseEnumerator.Current
                End Get
            End Property

            ' Public Function MoveNext() As Boolean
            'Return baseEnumerator.MoveNext()
            ' End Function

            Private Function MoveNext() As Boolean Implements IEnumerator.MoveNext
                Return baseEnumerator.MoveNext()
            End Function

            '  Public Sub Reset()
            '  baseEnumerator.Reset()
            ' End Sub

            Private Sub Reset() Implements IEnumerator.Reset
                baseEnumerator.Reset()
            End Sub
        End Class
    End Class
End Namespace

