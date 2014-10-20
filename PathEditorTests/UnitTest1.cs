using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathEditor;

namespace PathEditorTests
{
    [TestClass]
    public class UnitTest1
    {
        PathEditor.frmPathEditor dut = null;
        const string simplePath = "C:\\a;C:\\b;C:\\c;C:\\a\\b\\c";
        const string emptyPath = "";
        const string validPath = "C:\\bin;C:\\utils";
        const string invalidPath = simplePath;
        delegate void Del(string input);
        delegate void Del2(string input, string exp = null);


        // quasi-singleton instantiation of dut
        // any method can call this to be sure dut is instantiated...
        // if a method needs a fresh dut, it can pass 'true' to force a renewal
        public void setup(bool renew = false)
        {
            if (dut != null && renew)
            {
                dut.Dispose();
                dut = null;
            }
            if (dut == null)
            {
                dut = new frmPathEditor();
            }
        }

        [TestMethod]
        public void testMakeForm()
        {
            setup();
            Assert.IsNotNull(dut);
            frmPathEditor dut0 = dut;

            // dut should be the same instance after setup is called again
            setup();
            Assert.ReferenceEquals(dut0, dut);

            setup(true);
            Assert.IsFalse(dut.Equals(dut0));
        }

        /*
         * Delegated tests - this section contains:
         *    delegator methdos to run tests with standard sets of inputs
         *    private methods that take an input parameter and do the actual test
         *    public methods marked [TestMethod] that simply call a delegator for the matching test
         *       (having separate test methods makes for a better level of details in the report.)
         */
        private void testFillReadListBox(string exp)
        {
            dut.populateListBox(exp);
            string obs = dut.getPathFromListBox();
            Assert.AreEqual(exp, obs);
        }

        [TestMethod]
        public void runTestFillReadListBox()
        {
            runTest(testFillReadListBox);
        }


        private void runTest(Del test)
        {
            setup();
            string[] inputs = { emptyPath, simplePath };
            foreach (string input in inputs)
            {
                test(input);
            }
        }

        /* this section contains tests that don't lend to using the standard string inputs and delegator */
        [TestMethod]
        public void runTestRegistrySetGet()
        {
            setup();
            string orig = dut.getPathFromRegistry();
            
            runTest(testRegistrySetGet);

            dut.savePathToRegistry(orig);
        }

        private void testRegistrySetGet(string exp)
        {
            dut.savePathToRegistry(exp);
            string obs = dut.getPathFromRegistry();
            Assert.AreEqual(exp, obs);
        }

        [TestMethod]
        public void runTestPathConversions()
        {
            runTest(testPathConversions);
        }

        private void testPathConversions(string exp = "")
        {
            List<string> list = dut.pathStringToList(exp);
            string obs = dut.pathListToString(list);
            Assert.AreEqual(exp, obs);
        }

        [TestMethod]
        public void runTestInputBox()
        {
            runTest(testInputBox);
        }

        private void testInputBox(string exp = "")
        {
            dut.setPathInputText(exp);
            string obs = dut.getPathInputText();
            Assert.AreEqual(exp, obs);
        }

        [TestMethod]
        public void testIsPath()
        {
            setup();
            Assert.IsTrue(dut.isPath("C:\\Users"));
            Assert.IsFalse(dut.isPath("X:\\foo\\bar\\whataretheodds"), "path should not exist");
        }

        [TestMethod]
        public void testDeleteSelectedItem()
        {
            setup();
            dut.populateListBox("C:\\a;C:\\b;C:\\c;C:\\d;C:\\e");
            dut.setSelectedItem(0);
            dut.deleteSelectedItem();
            Assert.AreEqual("C:\\b;C:\\c;C:\\d;C:\\e", dut.getPathFromListBox());
            dut.setSelectedItem(3);
            dut.deleteSelectedItem();
            Assert.AreEqual("C:\\b;C:\\c;C:\\d", dut.getPathFromListBox());
            dut.setSelectedItem(1);
            dut.deleteSelectedItem();
            Assert.AreEqual("C:\\b;C:\\d", dut.getPathFromListBox());
        }

        [TestMethod]
        public void testSplitEmptyString()
        {
            setup();
            // splitting an empty string should result in a list of zero items
            string input = "";
            List<string> list = dut.pathStringToList(input);
            int exp = 0;
            int obs = list.Count;
            Assert.AreEqual(exp, obs, "should result in an empty list");
        }
        //[TestMethod]
        //public void testWillFail()
        //{
        //    Assert.AreEqual("Foo", "bar");
        //}
    }
}
