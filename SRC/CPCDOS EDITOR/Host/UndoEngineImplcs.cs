using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;

namespace OSMaker.Host
{
    public class UndoEngineImpl : UndoEngine
    {
        List<UndoEngine.UndoUnit> undoUnitList = new List<UndoUnit>();

        // points to the command that should be executed for Redo
        int currentPos = 0;

        public UndoEngineImpl(IServiceProvider provider)
            : base(provider)
        {
        }

        public void DoUndo()
        {
            if (currentPos > 0)
            {
                UndoEngine.UndoUnit undoUnit = undoUnitList[currentPos - 1];
                undoUnit.Undo();
                currentPos--;
            }
            UpdateUndoRedoMenuCommandsStatus();
        }

        public void DoRedo()
        {
            if (currentPos < undoUnitList.Count)
            {
                UndoEngine.UndoUnit undoUnit = undoUnitList[currentPos];
                undoUnit.Undo();
                currentPos++;
            }
            UpdateUndoRedoMenuCommandsStatus();
        }

        private void UpdateUndoRedoMenuCommandsStatus()
        {
            // this components maybe cached.
            MenuCommandService menuCommandService = GetService(typeof(MenuCommandService)) as MenuCommandService;
            MenuCommand undoMenuCommand = menuCommandService.FindCommand(StandardCommands.Undo);
            MenuCommand redoMenuCommand = menuCommandService.FindCommand(StandardCommands.Redo);

            if (undoMenuCommand != null)
                undoMenuCommand.Enabled = currentPos > 0;
            if (redoMenuCommand != null)
                redoMenuCommand.Enabled = currentPos < this.undoUnitList.Count;
        }

        protected override void AddUndoUnit(UndoEngine.UndoUnit unit)
        {
            undoUnitList.RemoveRange(currentPos, undoUnitList.Count - currentPos);
            undoUnitList.Add(unit);
            currentPos = undoUnitList.Count;
        }

        protected override UndoEngine.UndoUnit CreateUndoUnit(string name, bool primary)
        {
            return base.CreateUndoUnit(name, primary);
        }

        protected override void DiscardUndoUnit(UndoEngine.UndoUnit unit)
        {
            undoUnitList.Remove(unit);
            base.DiscardUndoUnit(unit);
        }

        protected override void OnUndoing(EventArgs e)
        {
            base.OnUndoing(e);
        }

        protected override void OnUndone(EventArgs e)
        {
            base.OnUndone(e);
        }
    }
}

