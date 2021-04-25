using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace Host
{
    /// <summary>
    /// Uses the custom RootDesigner (MyRootDesigner)
    /// </summary>
    [Designer(typeof(MyRootDesigner), typeof(IRootDesigner))]
	[Designer(typeof(ComponentDesigner))]
	public class MyTopLevelComponent : Component
	{
        public MyTopLevelComponent()
		{
		}
	}

}// namespace
