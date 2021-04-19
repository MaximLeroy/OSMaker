using System;
using System.ComponentModel;
using System.Diagnostics;

namespace OSMaker.My
{
    internal static partial class MyProject
    {
        
        internal partial class MyForms
        {
           

           

          

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreen1 m_SplashScreen1;

            public SplashScreen1 SplashScreen1
            {
                [DebuggerHidden]
                get
                {
                    m_SplashScreen1 = Create__Instance__(m_SplashScreen1);
                    return m_SplashScreen1;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, SplashScreen1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreen1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TestDesignervb m_TestDesignervb;

            public TestDesignervb TestDesignervb
            {
                [DebuggerHidden]
                get
                {
                    m_TestDesignervb = Create__Instance__(m_TestDesignervb);
                    return m_TestDesignervb;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TestDesignervb))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TestDesignervb);
                }
            }
        }
    }
}