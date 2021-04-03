using System.Collections.Generic;
using FastColoredTextBoxNS;

namespace OSMaker.OSMaker
{
    public class TbInfo
    {
        public HashSet<int> bookmarksLineId = new HashSet<int>();
        public List<int> bookmarks = new List<int>();
        public AutocompleteMenu popupMenu;
    }
}