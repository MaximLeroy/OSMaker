using System;
using System.Collections;

namespace ToolBox.ToolboxLibrary
{


    // Project   : ToolboxLibrary
    // Class     : ToolboxTabCollection
    // 
    // Copyright (C) 2002, Microsoft Corporation
    // ------------------------------------------------------------------------------
    // <summary>
    // Strongly-typed collection of ToolboxTab objects
    // </summary>
    // <remarks></remarks>
    // <history>
    // [dineshc] 3/26/2003  Created
    // </history>
    [Serializable()]
    public class ToolboxTabCollection : CollectionBase
    {


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        /// </summary>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxTabCollection()
        {
        }


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/> based on another <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        /// </summary>
        /// <paramname="value">
        /// A <seecref="ToolboxLibrary.ToolboxTabCollection"/> from which the contents are copied
        /// </param>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxTabCollection(ToolboxTabCollection value)
        {
            AddRange(value);
        }


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxTabCollection"/> containing any array of <seecref="ToolboxLibrary.ToolboxTab"/> objects.
        /// </summary>
        /// <paramname="value">
        /// A array of <seecref="ToolboxLibrary.ToolboxTab"/> objects with which to intialize the collection
        /// </param>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxTabCollection(ToolboxTab[] value)
        {
            AddRange(value);
        }


        /// <summary>
        /// Represents the entry at the specified index of the <seecref="ToolboxLibrary.ToolboxTab"/>.
        /// </summary>
        /// <paramname="index">The zero-based index of the entry to locate in the collection.</param>
        /// <value>
        /// The entry at the specified index of the collection.
        /// </value>
        /// <remarks><exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="index"/> is outside the valid range of indexes for the collection.</exception></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxTab this[int index]
        {
            get
            {
                return (ToolboxTab)List[index];
            }

            set
            {
                List[index] = value;
            }
        }


        /// <summary>
        /// Adds a <seecref="ToolboxLibrary.ToolboxTab"/> with the specified value to the
        /// <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to add.</param>
        /// <returns>
        /// The index at which the new element was inserted.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.AddRange"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public int Add(ToolboxTab value)
        {
            return List.Add(value);
        }


        /// <summary>
        /// Copies the elements of an array to the end of the <seecref="ToolboxLibrary.ToolboxTabCollection"/>.
        /// </summary>
        /// <paramname="value">
        /// An array of type <seecref="ToolboxLibrary.ToolboxTab"/> containing the objects to add to the collection.
        /// </param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void AddRange(ToolboxTab[] value)
        {
            int i = 0;
            while (i < value.Length)
            {
                Add(value[i]);
                i = i + 1;
            }
        }


        /// <summary>
        /// 
        /// Adds the contents of another <seecref="ToolboxLibrary.ToolboxTabCollection"/> to the end of the collection.
        /// 
        /// </summary>
        /// <paramname="value">
        /// A <seecref="ToolboxLibrary.ToolboxTabCollection"/> containing the objects to add to the collection.
        /// </param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void AddRange(ToolboxTabCollection value)
        {
            int i = 0;
            while (i < value.Count)
            {
                Add(value[i]);
                i = i + 1;
            }
        }


        /// <summary>
        /// Gets a value indicating whether the
        /// <seecref="ToolboxLibrary.ToolboxTabCollection"/> contains the specified <seecref="ToolboxLibrary.ToolboxTab"/>.
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to locate.</param>
        /// <returns>
        /// <seelangword="true"/> if the <seecref="ToolboxLibrary.ToolboxTab"/> is contained in the collection;
        /// otherwise, <seelangword="false"/>.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.IndexOf"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public bool Contains(ToolboxTab value)
        {
            return List.Contains(value);
        }


        /// <summary>
        /// Copies the <seecref="ToolboxLibrary.ToolboxTabCollection"/> values to a one-dimensional <seecref="System.Array"/> instance at the
        /// specified index.
        /// </summary>
        /// <paramname="array">The one-dimensional <seecref="System.Array"/> that is the destination of the values copied from <seecref="ToolboxLibrary.ToolboxTabCollection"/> .</param>
        /// <paramname="index">The index in <paramrefname="array"/> where copying begins.</param>
        /// <remarks><exceptioncref="System.ArgumentException"><paramrefname="array"/> is multidimensional. <para>-or-</para> <para>The number of elements in the <seecref="ToolboxLibrary.ToolboxTabCollection"/> is greater than the available space between <paramrefname="arrayIndex"/> and the end of <paramrefname="array"/>.</para></exception>
        /// <exceptioncref="System.ArgumentNullException"><paramrefname="array"/> is <seelangword="null"/>. </exception>
        /// <exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="arrayIndex"/> is less than <paramrefname="array"/>"s lowbound. </exception>
        /// <seealsocref="System.Array"/>
        /// </remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void CopyTo(ToolboxTab[] array, int index)
        {
            List.CopyTo(array, index);
        }


        /// <summary>
        /// Returns the index of a <seecref="ToolboxLibrary.ToolboxTab"/> in
        /// the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to locate.</param>
        /// <returns>
        /// The index of the <seecref="ToolboxLibrary.ToolboxTab"/> of <paramrefname="value"/> in the
        /// <seecref="ToolboxLibrary.ToolboxTabCollection"/>, if found; otherwise, -1.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Contains"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public int IndexOf(ToolboxTab value)
        {
            return List.IndexOf(value);
        }


        /// <summary>
        /// Inserts a <seecref="ToolboxLibrary.ToolboxTab"/> into the <seecref="ToolboxLibrary.ToolboxTabCollection"/> at the specified index.
        /// </summary>
        /// <paramname="index">The zero-based index where <paramrefname="value"/> should be inserted.</param>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to insert.</param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxTabCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void Insert(int index, ToolboxTab value)
        {
            List.Insert(index, value);
        }


        /// <summary>
        /// Returns an enumerator that can iterate through
        /// the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        /// </summary>
        /// <returns>An enumerator for the collection</returns>
        /// <remarks><seealsocref="System.Collections.IEnumerator"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public new ToolboxTabEnumerator GetEnumerator()
        {
            return new ToolboxTabEnumerator(this);
        }


        /// <summary>
        /// Removes a specific <seecref="ToolboxLibrary.ToolboxTab"/> from the
        /// <seecref="ToolboxLibrary.ToolboxTabCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxTab"/> to remove from the <seecref="ToolboxLibrary.ToolboxTabCollection"/> .</paramname>
        /// <remarks><exceptioncref="System.ArgumentException"><paramrefname="value"/> is not found in the Collection. </exception></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void Remove(ToolboxTab value)
        {
            List.Remove(value);
        }

        public class ToolboxTabEnumerator : object, IEnumerator
        {
            private IEnumerator baseEnumerator;
            private IEnumerable temp;

            public ToolboxTabEnumerator(ToolboxTabCollection mappings)
            {
                temp = mappings;
                baseEnumerator = temp.GetEnumerator();
            }

            public ToolboxTab p_Current
            {
                get
                {
                    return (ToolboxTab)baseEnumerator.Current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return baseEnumerator.Current;
                }
            }

            // Public Function MoveNext() As Boolean
            // Return baseEnumerator.MoveNext()
            // End Function

            bool IEnumerator.MoveNext()
            {
                return baseEnumerator.MoveNext();
            }

            // Public Sub Reset()
            // baseEnumerator.Reset()
            // End Sub

            void IEnumerator.Reset()
            {
                baseEnumerator.Reset();
            }
        }
    }
}