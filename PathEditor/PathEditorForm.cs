using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Copyright (c) 2014 C. Emryss

/*
 * This program exists because I wanted (1) an easier way to edit my PATH variable when a Windows user, 
 * and (2) to learn and practice programming in C#.  Sort of a "Hello, World."
 */

/* TODO:  (Things to do, (maybe))
 * add font picker to Options, and maybe other UI customization options.
 * enable Ctrl-A to select all text in the txtStatus input.
 * Generally fix colors and highlighting.
 * Fix close-intercept cancel behaviour.
 * Give better looking Help and About windows.
 * Maybe move some strings into resources.
 */
namespace PathEditor
{
    public partial class frmPathEditor : Form
    {
        string title = "Path Editor rev. 0.01";
        bool closeWithoutSaving = false;

        public frmPathEditor()
        {
            InitializeComponent();
            initializeToolTIps();
            InitializeContent();
        }

        private void InitializeContent()
        {
            populateListBox(getPathFromRegistry());
            txtPathInput.Select();
        }

        public void setPathInputText(string text)
        {
            txtPathInput.Text = text;
        }

        public string getPathInputText()
        {
            return txtPathInput.Text;
        }

        private void cleanUpAndExit()
        {
            this.Close();
            this.Dispose();
        }

        public List<string> pathStringToList(string path)
        {
            Char[] sepchars = new Char[] { ';' };
            string[] arr = path.Split(sepchars);
            List<string> list = arr.ToList<string>();

            // apparently splitting an empty string results in a list with one emty string item, so.
            list.RemoveAll(s => s == "");

            return list;
        }

        public string pathListToString(List<string> list)
        {
            return String.Join(";", list);
        }

        public string getPathFromRegistry(string keyName = "HKEY_CURRENT_USER\\ENVIRONMENT",
            string subKey = "PATH")
        {
            return Microsoft.Win32.Registry.GetValue(keyName, subKey, "").ToString();
        }

        public void savePathToRegistry(string newPath,
            EnvironmentVariableTarget target = EnvironmentVariableTarget.User,
            string subKey = "PATH")
        {
            Environment.SetEnvironmentVariable(subKey, newPath, target);
        }

        public void populateListBox(List<string> source)
        {
            listBoxPathComponents.Items.Clear();
            foreach (string item in source)
            {
                listBoxPathComponents.Items.Add(item);
            }
            updateStatus();
        }

        public void populateListBox(string pathString)
        {
            List<string> pathList = pathStringToList(pathString);
            populateListBox(pathList);
        }

        public string getPathFromListBox()
        {
            List<string> pathList = new List<string>();

            for (int i = 0; i < listBoxPathComponents.Items.Count; ++i )
            {
                string pathel = listBoxPathComponents.Items[i].ToString();
                pathList.Add(pathel);
            }
            return pathListToString(pathList);
        }

        public bool isPath (string pathel) 
        {
           bool result = false;
           try
           {
               FileAttributes fattr = File.GetAttributes(pathel);
               if ((fattr & FileAttributes.Directory) == FileAttributes.Directory)
               {
                   result = true;
               }
           }
           catch (Exception ex)
           {
               result = false;
           }
           return result;
        }

        // called by the 'browse' button and menu item handlers
        private void addPathFromDialog()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (listBoxPathComponents.SelectedIndex != -1)
            {
                fbd.SelectedPath = listBoxPathComponents.SelectedItem.ToString();
            }
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.Description = "Select a folder to add to the User Path, then clik OK";
            fbd.ShowDialog();
            addPathToList(fbd.SelectedPath);
            fbd.Dispose();
        }

        /* click event handlers */

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            addPathFromDialog();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            cleanUpAndExit();
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            populateListBoxFromRegistryPath();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addPathToList(txtPathInput.Text);
        }

        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            addPathToList(txtPathInput.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSelectedItem();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            deleteSelectedItem();
        }

        private void menuItemBrowse_Click(object sender, EventArgs e)
        {
            addPathFromDialog();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }


        private void menuItemTooltips_Click(object sender, EventArgs e)
        {
            menuItemTooltips.Checked = !menuItemTooltips.Checked;
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            string message = "This displays and edits the User Environment PATH variable's contents.\r\n"
                + "This refers to PATH in HKEY_CURRENT_USER\\ENVIRONMENT in the registry.\r\n\r\n"
                + "Changes saved by this tool should be available to shells opened subsequently.\r\n\r\n"
                + "For specific help with any widget, mouse over it; maybe the tips will help.\r\n\r\n"
                + "This version does not enable editing the System path, just the User path.";
                
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            string message = "Source for this program is released at https://github.com/tinwel/PathEditor\r\n under"
+ "\r\n"
+ "the MIT License (MIT)\r\n"
+ "\r\n"
+ "Copyright (c) 2014 C. Emryss\r\n"
+ "\r\n"
+ "Permission is hereby granted, free of charge, to any person obtaining a copy\r\n"
+ "of this software and associated documentation files (the \"Software\"), to deal\r\n"
+ "in the Software without restriction, including without limitation the rights\r\n"
+ "to use, copy, modify, merge, publish, distribute, sublicense, and/or sell\r\n"
+ "copies of the Software, and to permit persons to whom the Software is\r\n"
+ "furnished to do so, subject to the following conditions:\r\n"
+ "\r\n"
+ "The above copyright notice and this permission notice shall be included in all\r\n"
+ "copies or substantial portions of the Software.\r\n"
+ "\r\n"
+ "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\n"
+ "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\n"
+ "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\n"
+ "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\n"
+ "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\n"
+ "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\n"
+ "SOFTWARE.";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (changesExist() 
                && (MessageBox.Show("This will discard your changes.  Proceed anyway?", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK))
            {
                populateListBoxFromRegistryPath();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cleanUpAndExit();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            moveItemUp();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            moveItemDown();
        }

        private void listBoxPathComponents_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPathComponents.SelectedIndex != -1)
            {
                setPathInputText(listBoxPathComponents.SelectedItem.ToString());
            }
        }

        /* end click event handlers */



        public bool changesExist() {
            string registryPath = getPathFromRegistry();
            string formPath = getPathFromListBox();
            return (registryPath != formPath);
        }

        private void populateListBoxFromRegistryPath()
        {
            populateListBox(getPathFromRegistry());
        }


        public void saveChanges()
        {
            if (changesExist())
            {
                savePathToRegistry(getPathFromListBox());
                updateStatus();
            }
        }

        // check for unsaved changes when closing
        private void frmPathEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeWithoutSaving == false)
            {
                string registryPath = getPathFromRegistry();
                string formPath = getPathFromListBox();
                if (formPath != registryPath)
                {
                    DialogResult res = MessageBox.Show(e.CloseReason + "\r\n" + "Do you want to save changes?", title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        savePathToRegistry(formPath);
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        // BUG: this is not the way or not enough to stop the form from closing.
                        // TODO: Fix bug, it should not close when Cancel was pressed.
                    }
                }
            }
        }

        // called by the 'add' button and menu item handlers
        public void addPathToList(string path)
        {
            if (isPath(path) && !listBoxPathComponents.Items.Contains(path))
            {
                listBoxPathComponents.Items.Add(path);
                listBoxPathComponents.SelectedIndex = listBoxPathComponents.Items.Count - 1;
                txtPathInput.Clear();
                updateStatus();
            }
        }

        public void setSelectedItem(int i)
        {
            if (i >= 0 && i < listBoxPathComponents.Items.Count)
            {
                listBoxPathComponents.SelectedIndex = i;
            }
        }

        public void deleteSelectedItem() {
            if (listBoxPathComponents.SelectedIndex != -1)
            {
                listBoxPathComponents.Items.RemoveAt(listBoxPathComponents.SelectedIndex);
                updateStatus();
            }
        }

        private void moveItemUp()
        {
            int idx = listBoxPathComponents.SelectedIndex;
            if (idx > 0)
            {
                string tmp = listBoxPathComponents.Items[idx - 1].ToString();
                listBoxPathComponents.Items[idx - 1] = listBoxPathComponents.Items[idx];
                listBoxPathComponents.Items[idx] = tmp;
                listBoxPathComponents.SelectedIndex = idx - 1;
                updateStatus();
            }
        }

        public void moveItemDown()
        {
            int idx = listBoxPathComponents.SelectedIndex;
            if (idx >= 0 && idx < listBoxPathComponents.Items.Count - 1)
            {
                string tmp = listBoxPathComponents.Items[idx + 1].ToString();
                listBoxPathComponents.Items[idx + 1] = listBoxPathComponents.Items[idx];
                listBoxPathComponents.Items[idx] = tmp;
                listBoxPathComponents.SelectedIndex = idx + 1;
                updateStatus();
            }
        }

        // Display the path as a string in the status box
        // Highlight the save button when our built string differs from what's in the registry.
        private void updateStatus() 
        {
            txtStatus.Text = getPathFromListBox();
            if (changesExist())
            {
                btnSave.BackColor = Color.HotPink;
            } else {
                btnSave.BackColor = Color.Azure;
            }
        }

        // Adds the text input's path to the list if Enter is pressed and it is a valid path.
        // Highlights the path to indicate when it is a valid path.
        // TODO: maybe add a tab completer?
        private void txtPathInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                switch (txtPathInput.Text) {
                    case ":q":
                        cleanUpAndExit(); 
                        break;
                    case ":wq":
                        if (changesExist()) saveChanges();
                        cleanUpAndExit();
                        break;
                    case ":q!":
                        closeWithoutSaving = true;
                        // populateListBoxFromRegistryPath();
                        cleanUpAndExit();
                        break;
                    default:
                        addPathToList(txtPathInput.Text);
                        ((Control)sender).BackColor = Color.Azure;
                        break;
                }
            }
            else if (isPath(txtPathInput.Text + e.KeyChar))
            {
                ((Control)sender).BackColor = Color.SpringGreen;

            }
            else
            {
                ((Control)sender).BackColor = Color.Azure;

            }
        }
    }
}
