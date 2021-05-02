using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Tools.Graphs;
using Microsoft.Tools.Graphs.Bars;
using Microsoft.Tools.Graphs.Legends;
using Microsoft.Tools.Graphs.Pies;

namespace WindowConceptor.Host
{
    /// <summary>
    /// Demonstrates how to write a custom RootDesigner. This designer has a View
    /// of a Graph - it shows the number of components added to the designer
    /// in a pie/bar chart.
    /// </summary>
    public class MyRootDesigner : ComponentDesigner, IRootDesigner, IToolboxUser
    {
        private MyRootControl _rootView;


        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public object GetView(ViewTechnology technology)
        {
            var monmenustrip = new ContextMenuStrip();
            _rootView = new MyRootControl(this);
            return _rootView;
        }

        public ViewTechnology[] SupportedTechnologies
        {
            get
            {
                return new ViewTechnology[] { ViewTechnology.Default };
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void ToolPicked(ToolboxItem tool)
        {
            _rootView.InvokeToolboxItem(tool);
        }

        public bool GetToolSupported(ToolboxItem tool)
        {
            return true;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        public new object GetService(Type type)
        {
            return base.GetService(type);
        }



        /* TODO ERROR: Skipped RegionDirectiveTrivia */        /// <summary>
        /// This is the View of the RootDesigner.
        /// </summary>
        public class MyRootControl : ScrollableControl
        {
            internal enum GraphStype
            {
                Pie = 1,
                Bar = 2
            }

            private string _displayString = "Pie Graph Representation of components added.";
            private MyRootDesigner _rootDesigner;
            private Hashtable _componentInfoTable;
            private int _totalComponents = 0;
            private LinkLabel _linkLabel;
            private int _graphStyle = (int)GraphStype.Pie;

            public MyRootControl(MyRootDesigner rootDesigner)
            {
                _rootDesigner = rootDesigner;
                _componentInfoTable = new Hashtable();
                _linkLabel = new LinkLabel();
                _linkLabel.Text = "Graph Style";
                _linkLabel.Location = new Point(10, 5);
                _linkLabel.Visible = false;
                _linkLabel.Click += new EventHandler(_linkLabel_Click);
                Controls.Add(_linkLabel);
                Resize += new EventHandler(MyRootControl_Resize);
                for (int i = 1, loopTo = _rootDesigner.Component.Site.Container.Components.Count - 1; i <= loopTo; i++)
                    UpdateTable(_rootDesigner.Component.Site.Container.Components[i].GetType());
                Invalidate();
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                try
                {
                    if (_componentInfoTable.Count == 0)
                    {
                        _linkLabel.Visible = false;
                        string s = "Add objects from the toolbox on to this custom Graphical RootDesigner";
                        var sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        pe.Graphics.FillRectangle(new LinearGradientBrush(Bounds, Color.White, Color.Orange, 45.0f), Bounds);
                        pe.Graphics.DrawString(s, base.Font, new SolidBrush(Color.Black), Bounds, sf);
                    }
                    else
                    {
                        _linkLabel.Visible = true;
                        pe.Graphics.FillRectangle(new SolidBrush(Color.White), Bounds);
                        Image image = null;
                        if (_graphStyle == (int)GraphStype.Pie)
                        {
                            image = GetPieGraph();
                        }
                        else
                        {
                            image = GetBarGraph();
                        }

                        pe.Graphics.DrawImage(image, Bounds);
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
            } // OnPaint

            public void InvokeToolboxItem(ToolboxItem tool)
            {
                var newComponents = tool.CreateComponents(DesignerHost);
                _displayString = "Last Component added: " + newComponents[0].GetType().ToString();
                UpdateTable(newComponents[0].GetType());
                Invalidate();
            }

            private void UpdateTable(Type type)
            {
                if (_componentInfoTable[type] is null)
                {
                    var ci = new ComponentInfo();
                    var ru = new RandomUtil();
                    ci.Type = type;
                    ci.Color = ru.GetColor();
                    ci.Count = 1;
                    _componentInfoTable.Add(type, ci);
                    _totalComponents += 1;
                }
                else
                {
                    ComponentInfo ci = (ComponentInfo)_componentInfoTable[type];
                    _componentInfoTable.Remove(type);
                    ci.Count += 1;
                    _componentInfoTable.Add(type, ci);
                }
            }

            public IDesignerHost DesignerHost
            {
                get
                {
                    return (IDesignerHost)_rootDesigner.GetService(typeof(IDesignerHost));
                }
            }

            public IToolboxService ToolboxService
            {
                get
                {
                    return (IToolboxService)_rootDesigner.GetService(typeof(IToolboxService));
                }
            }

            private Image GetPieGraph()
            {
                var ru = new RandomUtil();
                var pg = new PieGraph(Size);
                pg.Color = Color.White;
                pg.ColorGradient = Color.Orange;
                var legend = new Legend(Width, 70);
                legend.Text = string.Empty;
                pg.Text = _displayString + " Total: " + _totalComponents.ToString();
                var keys = _componentInfoTable.Keys;
                var ie = keys.GetEnumerator();
                while (ie.MoveNext())
                {
                    Type key = (Type)ie.Current;
                    ComponentInfo ci = (ComponentInfo)_componentInfoTable[key];
                    var ps = new PieSlice(ci.Count, ci.Color);
                    pg.Slices.Add(ps);
                    var le = new LegendEntry(ci.Color, ci.Type.Name.ToString().Trim());
                    legend.LegendEntryCollection.Add(le);
                }

                return GraphRenderer.DrawGraphAndLegend(pg, legend, Size);
            }

            private Image GetBarGraph()
            {
                var ru = new RandomUtil();
                var bg = new BarGraph(Size);
                bg.Color = Color.White;
                bg.ColorGradient = Color.Orange;
                var legend = new Legend(Width, 70);
                legend.Text = string.Empty;
                bg.Text = _displayString + " Total: " + _totalComponents.ToString();
                var keys = _componentInfoTable.Keys;
                var ie = keys.GetEnumerator();
                while (ie.MoveNext())
                {
                    Type key = (Type)ie.Current;
                    ComponentInfo ci = (ComponentInfo)_componentInfoTable[key];
                    var bs = new BarSlice(ci.Count, ci.Color);
                    bg.BarSliceCollection.Add(bs);
                    var le = new LegendEntry(ci.Color, ci.Type.Name.ToString().Trim());
                    legend.LegendEntryCollection.Add(le);
                }

                return GraphRenderer.DrawGraphAndLegend(bg, legend, Size);
            }

            private class ComponentInfo
            {
                public Type Type;
                public Color Color;
                public int Count;
            }

            private void MyRootControl_Resize(object sender, EventArgs e)
            {
                Invalidate();
            }

            private void _linkLabel_Click(object sender, EventArgs e)
            {
                if (_graphStyle == (int)GraphStype.Pie)
                {
                    _graphStyle = (int)GraphStype.Bar;
                }
                else
                {
                    _graphStyle = (int)GraphStype.Pie;
                }

                Invalidate();
            }
        } // class MyRootControl
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    } // class MyRootDesigner
} // namespace
