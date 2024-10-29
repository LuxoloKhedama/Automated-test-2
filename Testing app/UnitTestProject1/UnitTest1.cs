using System;
using System.IO;
using Testing_app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Chat_WhenInputIs1_CallsBDMethod()
        {
            // Arrange
            CCHAT testableChat = new CCHAT();
            StringWriter stringWriter = new StringWriter();
            StringReader stringReader = new StringReader("1\n");

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            testableChat.BD();
            //chat(testableChat); // Call the chat method with the testable instance

            // Assert
            Assert.AreEqual("BD method was not called.",testableChat.BD() );
        }

        [TestMethod]
        public void Chat_WhenInputIs2_DoesNotCallBDMethod()
        {
            // Arrange
            CCHAT testableChat = new CCHAT();
            StringWriter stringWriter = new StringWriter();
            StringReader stringReader = new StringReader("2\n");

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            testableChat.BD();
            //chat(testableChat); // Call the chat method with the testable instance

            // Assert
            Assert.AreEqual("BD method should not have been called.", testableChat.BD());
        }
    }
}
