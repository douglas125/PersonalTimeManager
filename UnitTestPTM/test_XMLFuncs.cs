using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalManager;

using System.Data;
using System.Windows.Forms;

namespace UnitTestPTM
{
    [TestClass]
    public class test_XMLFuncs
    {
        [TestMethod]
        public void TestCreateColumn()
        {
            DataTable t = new DataTable();
            TextBox txtBox = new TextBox() { Name = "txtDumName" };

            XMLFuncs.CreateColumn(t, txtBox);

            Assert.AreEqual(t.Columns[0].ColumnName, "txtDumName");

            // test data type
            Assert.AreEqual(t.Columns[0].DataType, Type.GetType("System.String"));

            // test binding
            Assert.AreEqual(txtBox.DataBindings[0].PropertyName, "Text");
            Assert.AreEqual(txtBox.DataBindings[0].DataSource, t);
            Assert.AreEqual(txtBox.DataBindings[0].BindingMemberInfo.BindingMember, "txtDumName");

            t = new DataTable();
            txtBox = new TextBox() { Name = "txtDum" };
            XMLFuncs.CreateColumn(t, txtBox);
            Assert.AreEqual(t.Columns[0].ColumnName, "txtDum");
            // test data type
            Assert.AreEqual(t.Columns[0].DataType, Type.GetType("System.Double"));

        }
    }
}
