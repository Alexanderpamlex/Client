using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WF1.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        Model model = new Model();


        Label label = new Label();

        


        [TestMethod]
        public void SetX()
        {

            model.SetX(label);
            Assert.AreEqual(label.Text, "X");
        }

        [TestMethod]
        public void SetO()
        {
            model.SetO(label);
            Assert.AreEqual(label.Text, "O");
        }



    }
}
