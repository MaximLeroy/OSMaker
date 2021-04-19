using System.ComponentModel;
using System.ComponentModel.Design;

namespace OSMLoader.Host
{
    /// <summary>
    /// Uses the custom RootDesigner (MyRootDesigner)
    /// </summary>
    [Designer(typeof(MyRootDesigner), typeof(IRootDesigner))]
    [Designer(typeof(ComponentDesigner))]
    public  class MyTopLevelComponent : Component
    {
        public MyTopLevelComponent()
        {
        }
    }
} // namespace
