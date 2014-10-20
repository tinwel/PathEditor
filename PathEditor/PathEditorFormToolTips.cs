using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace PathEditor
{
    public partial class frmPathEditor : Form
    {
        private ToolTip toolTip;
        private StringDictionary tips = null;

        // This instantiates a ToolTip object and builds a handy dictionary of tips. 
        // If you have an object that needs a tooltip, wire its MouseOver event 
        // to the showToolTips method, and likewise MouseOut to hideToolTips.
        // Don't forget to add a tips dictionary entry here, or the magic will not work.
        private void initializeToolTIps()
        {
            toolTip = new ToolTip();

            tips = new StringDictionary();

            tips.Add("btnAdd", "Adds the path in the text box to the list\r\n(It must be a valid path, and not already in the list.)");
            tips.Add("btnBrowse", "Opens a dialog from which to choose a path to add to the list.");
            tips.Add("btnDelete", "Removes the selected item (if any) from the list.");
            tips.Add("btnExit", "Quit this program.\r\n(It will give you the option to save any changes, if any are detected.)");
            tips.Add("btnLoad", "Reloads the list from the path stored in the registry.\r\n(Any changes you have made will be lost unless you save them first.)");
            tips.Add("btnMoveDown", "Moves the selected item down in the list.");
            tips.Add("btnMoveUp", "Moves the selected item up in the list.");
            tips.Add("btnSave", "Saves the path changes back to the registry.");
            tips.Add("txtPathInput", "Enter a path in this line, then click Add to add it to the list.");
            tips.Add("txtStatus", "Shows the path string that would be built from the items in the list box.");
        }

        // wire this to any widget's event MouseEnter, and don't forget to 
        // write a tip and add it in initializeToolTips().
        private void MouseOver(object sender, EventArgs e = null)
        {
            if (menuItemTooltips.Checked)
            {
                Control cSender = (sender as Control);
                if (tips.ContainsKey(cSender.Name)) ;
                {
                    toolTip.Show(tips[cSender.Name], (IWin32Window)sender);
                }
            }
        }

        // wire this to any widget's event MouseLeave
        private void MouseOut(object sender, EventArgs e = null)
        {
            toolTip.Hide((IWin32Window)sender);
        }
   }
}


/*
 * Note to self (in case this happens again after it's forgotten):  
 * 
 * "Two output file names resolved to the same output path: "obj\Debug\
 * \PathEditor.frmPathEditor.resources"
 * 
 * If you see this error message, you probably double clicked the form 
 * for PathEditorFormToolTips.cs.  Tsk tsk.
 * 
 * Even though this is defined partial, it generates a dummy form somewhere.
 * It's just a basic blank form, and seems mostly harmless, but...
 * if you happen to open that form and double-click on it, Visual Studio
 * creates a resx entry in the solution tree, and adds some code in this file.
 * 
 * IF THIS HAPPENS, here's a way to recover:
 * 
 * Firstly, go back into the design view and press Ctrl-z.
 * 
 * Secondly, come in here and delete InitializeComponent, a method that was generated. 
 * (Ctrl-Z wasn't enough to undo everything, so we must do that.)
 * 
 * Finally, in the solution tree, expand PathEditorFormToolTips.cs, right click on
 * PathEditorFormToolTips.resx and choose "delete".  (Now you can build again.)
 * 
 */
