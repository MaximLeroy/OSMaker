using System;
using System.Collections;

namespace ToolBox.ToolboxLibrary
{


    // Project   : ToolboxLibrary
    // Class     : ToolboxItemCollection
    // 
    // Copyright (C) 2002, Microsoft Corporation
    // ------------------------------------------------------------------------------
    // <summary>
    // Strongly-typed collection of ToolboxItem objects
    // </summary>
    // <remarks></remarks>
    // <history>
    // [dineshc] 3/26/2003  Created
    // </history>
    [Serializable()]
    public class ToolboxItemCollection : CollectionBase
    {


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxItemCollection"/>.
        /// </summary>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxItemCollection()
        {
        }


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxItemCollection"/> based on another <seecref="ToolboxLibrary.ToolboxItemCollection"/>.
        /// </summary>
        /// <paramname="value">
        /// A <seecref="ToolboxLibrary.ToolboxItemCollection"/> from which the contents are copied
        /// </param>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxItemCollection(ToolboxItemCollection value)
        {
            AddRange(value);
        }


        /// <summary>
        /// Initializes a new instance of <seecref="ToolboxLibrary.ToolboxItemCollection"/> containing any array of <seecref="ToolboxLibrary.ToolboxItem"/> objects.
        /// </summary>
        /// <paramname="value">
        /// A array of <seecref="ToolboxLibrary.ToolboxItem"/> objects with which to intialize the collection
        /// </param>
        /// <remarks></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxItemCollection(ToolboxItem[] value)
        {
            AddRange(value);
        }


        /// <summary>
        /// Represents the entry at the specified index of the <seecref="ToolboxLibrary.ToolboxItem"/>.
        /// </summary>
        /// <paramname="index">The zero-based index of the entry to locate in the collection.</param>
        /// <value>
        /// The entry at the specified index of the collection.
        /// </value>
        /// <remarks><exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="index"/> is outside the valid range of indexes for the collection.</exception></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public ToolboxItem this[int index]
        {
            get
            {
                return (ToolboxItem)List[index];
            }

            set
            {
                List[index] = value;
            }
        }


        /// <summary>
        /// Adds a <seecref="ToolboxLibrary.ToolboxItem"/> with the specified value to the
        /// <seecref="ToolboxLibrary.ToolboxItemCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxItem"/> to add.</param>
        /// <returns>
        /// The index at which the new element was inserted.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.AddRange"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public int Add(ToolboxItem value)
        {
            return List.Add(value);
        }


        /// <summary>
        /// Copies the elements of an array to the end of the <seecref="ToolboxLibrary.ToolboxItemCollection"/>.
        /// </summary>
        /// <paramname="value">
        /// An array of type <seecref="ToolboxLibrary.ToolboxItem"/> containing the objects to add to the collection.
        /// </param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void AddRange(ToolboxItem[] value)
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
        /// Adds the contents of another <seecref="ToolboxLibrary.ToolboxItemCollection"/> to the end of the collection.
        /// 
        /// </summary>
        /// <paramname="value">
        /// A <seecref="ToolboxLibrary.ToolboxItemCollection"/> containing the objects to add to the collection.
        /// </param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void AddRange(ToolboxItemCollection value)
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
        /// <seecref="ToolboxLibrary.ToolboxItemCollection"/> contains the specified <seecref="ToolboxLibrary.ToolboxItem"/>.
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxItem"/> to locate.</param>
        /// <returns>
        /// <seelangword="true"/> if the <seecref="ToolboxLibrary.ToolboxItem"/> is contained in the collection;
        /// otherwise, <seelangword="false"/>.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.IndexOf"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public bool Contains(ToolboxItem value)
        {
            return List.Contains(value);
        }


        /// <summary>
        /// Copies the <seecref="ToolboxLibrary.ToolboxItemCollection"/> values to a one-dimensional <seecref="System.Array"/> instance at the
        /// specified index.
        /// </summary>
        /// <paramname="array">The one-dimensional <seecref="System.Array"/> that is the destination of the values copied from <seecref="ToolboxLibrary.ToolboxItemCollection"/> .</param>
        /// <paramname="index">The index in <paramrefname="array"/> where copying begins.</param>
        /// <remarks><exceptioncref="System.ArgumentException"><paramrefname="array"/> is multidimensional. <para>-or-</para> <para>The number of elements in the <seecref="ToolboxLibrary.ToolboxItemCollection"/> is greater than the available space between <paramrefname="arrayIndex"/> and the end of <paramrefname="array"/>.</para></exception>
        /// <exceptioncref="System.ArgumentNullException"><paramrefname="array"/> is <seelangword="null"/>. </exception>
        /// <exceptioncref="System.ArgumentOutOfRangeException"><paramrefname="arrayIndex"/> is less than <paramrefname="array"/>"s lowbound. </exception>
        /// <seealsocref="System.Array"/>
        /// </remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void CopyTo(ToolboxItem[] array, int index)
        {
            List.CopyTo(array, index);
        }


        /// <summary>
        /// Returns the index of a <seecref="ToolboxLibrary.ToolboxItem"/> in
        /// the <seecref="ToolboxLibrary.ToolboxItemCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxItem"/> to locate.</param>
        /// <returns>
        /// The index of the <seecref="ToolboxLibrary.ToolboxItem"/> of <paramrefname="value"/> in the
        /// <seecref="ToolboxLibrary.ToolboxItemCollection"/>, if found; otherwise, -1.
        /// </returns>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.Contains"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public int IndexOf(ToolboxItem value)
        {
            return List.IndexOf(value);
        }


        /// <summary>
        /// Inserts a <seecref="ToolboxLibrary.ToolboxItem"/> into the <seecref="ToolboxLibrary.ToolboxItemCollection"/> at the specified index.
        /// </summary>
        /// <paramname="index">The zero-based index where <paramrefname="value"/> should be inserted.</param>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxItem"/> to insert.</param>
        /// <remarks><seealsocref="ToolboxLibrary.ToolboxItemCollection.Add"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void Insert(int index, ToolboxItem value)
        {
            List.Insert(index, value);
        }


        /// <summary>
        /// Returns an enumerator that can iterate through
        /// the <seecref="ToolboxLibrary.ToolboxItemCollection"/> .
        /// </summary>
        /// <returns>An enumerator for the collection</returns>
        /// <remarks><seealsocref="System.Collections.IEnumerator"/></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public new ToolboxItemEnumerator GetEnumerator()
        {
            return new ToolboxItemEnumerator(this);
        }


        /// <summary>
        /// Removes a specific <seecref="ToolboxLibrary.ToolboxItem"/> from the
        /// <seecref="ToolboxLibrary.ToolboxItemCollection"/> .
        /// </summary>
        /// <paramname="value">The <seecref="ToolboxLibrary.ToolboxItem"/> to remove from the <seecref="ToolboxLibrary.ToolboxItemCollection"/> .</param>
        /// <remarks><exceptioncref="System.ArgumentException"><paramrefname="value"/> is not found in the Collection. </exceptioncref></remarks>
        /// <history>
        /// [dineshc] 3/26/2003  Created
        /// </history>
        public void Remove(ToolboxItem value)
        {
            List.Remove(value);
        }

        public class ToolboxItemEnumerator : object, IEnumerator
        {
            private IEnumerator baseEnumerator;
            private IEnumerable temp;

            public ToolboxItemEnumerator(ToolboxItemCollection mappings)
            {
                temp = mappings;
                baseEnumerator = temp.GetEnumerator();
            }

            public ToolboxItem p_Current
            {
                get
                {
                    return (ToolboxItem)baseEnumerator.Current;
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