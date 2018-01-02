using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinAppDriver_TFNRemover.Tests
{
    [TestClass]
    public class PDFTests
    {
        [TestMethod]
        public void PDFToText()
        {
            MethodController.PDFMethods.ConvertPDFToText("c:\\temp\\PDF2.pdf");
        }

    }
}
