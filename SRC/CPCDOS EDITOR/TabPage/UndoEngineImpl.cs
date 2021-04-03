using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace OSMaker.OSMaker
{
    public class UndoEngineImpl : UndoEngine
    {
        private List<UndoUnit> undoUnitList = new List<UndoUnit>();
        private int currentPos = 0;

        public UndoEngineImpl(IServiceProvider provider) : base(provider)
        {
        }

        public void DoUndo()
        {
            if (currentPos > 0)
            {
                var undoUnit = undoUnitList[currentPos - 1];
                undoUnit.Undo();
                currentPos -= 1;
            }

            UpdateUndoRedoMenuCommandsStatus();
        }

        public void DoRedo()
        {
            if (currentPos < undoUnitList.Count)
            {
                var undoUnit = undoUnitList[currentPos];
                undoUnit.Undo();
                currentPos += 1;
            }

            UpdateUndoRedoMenuCommandsStatus();
        }

        private void UpdateUndoRedoMenuCommandsStatus()
        {
            MenuCommandService menuCommandService = GetService(typeof(MenuCommandService)) as MenuCommandService;
            var undoMenuCommand = menuCommandService.FindCommand(StandardCommands.Undo);
            var redoMenuCommand = menuCommandService.FindCommand(StandardCommands.Redo);
            if (undoMenuCommand is object)
                undoMenuCommand.Enabled = currentPos > 0;
            if (redoMenuCommand is object)
                redoMenuCommand.Enabled = currentPos < undoUnitList.Count;
        }

        protected override void AddUndoUnit(UndoUnit unit)
        {
            undoUnitList.RemoveRange(currentPos, undoUnitList.Count - currentPos);
            undoUnitList.Add(unit);
            currentPos = undoUnitList.Count;
        }

        protected override UndoUnit CreateUndoUnit(string name, bool primary)
        {
            return base.CreateUndoUnit(name, primary);
        }

        protected override void DiscardUndoUnit(UndoUnit unit)
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