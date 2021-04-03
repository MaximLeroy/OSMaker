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
            public DESIGN m_DESIGN;

            public DESIGN DESIGN
            {
                [DebuggerHidden]
                get
                {
                    m_DESIGN = Create__Instance__(m_DESIGN);
                    return m_DESIGN;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DESIGN))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DESIGN);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Fenetre m_Fenetre;

            public Fenetre Fenetre
            {
                [DebuggerHidden]
                get
                {
                    m_Fenetre = Create__Instance__(m_Fenetre);
                    return m_Fenetre;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Fenetre))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Fenetre);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form2 m_Form2;

            public Form2 Form2
            {
                [DebuggerHidden]
                get
                {
                    m_Form2 = Create__Instance__(m_Form2);
                    return m_Form2;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form2))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form2);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Objets m_Objets;

            public Objets Objets
            {
                [DebuggerHidden]
                get
                {
                    m_Objets = Create__Instance__(m_Objets);
                    return m_Objets;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Objets))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Objets);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Parametres m_Parametres;

            public Parametres Parametres
            {
                [DebuggerHidden]
                get
                {
                    m_Parametres = Create__Instance__(m_Parametres);
                    return m_Parametres;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Parametres))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Parametres);
                }
            }

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
                    if (ReferenceEquals(value, m_SplashScreen1))
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