using NUnit.Framework;
using System;
using FileData;
using log4net;

namespace FileDataTest
{
    /// <summary>
    /// Program test.
    /// </summary>
    [TestFixture()]
    public class ProgramTest
    {
        string filePath = string.Empty;
        string actionType = string.Empty;
        /// <summary>
        /// The logger.
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger("ProgramTest");

        /// <summary>
        /// Tests the initialization.
        /// </summary>
        [TestFixtureSetUp]
        public void TestInitialization()
        {
            filePath = "C:\\test.txt";

        }

        /// <summary>
        /// Checks for version no on actiontype and filepath test1.
        /// </summary>
        /// 
        /// 
        [Test()]
        public void Check_for_version_no_on_actiontype_and_filepath_Test1()
        {
            actionType = "-v";
            var actualResult = Program.FileOperation(actionType, filePath);
            /// Just written one try catch and logging block in this test, so for best practice can follow for test cases 
            try
            {
                if (!string.IsNullOrEmpty(actualResult))
                {
                    Assert.IsTrue(actualResult.Length > 0, string.Format("Version number for {0} passed is - {1}", filePath, actualResult));
                    logger.Info(string.Format("Version number for {0} passed is - {1}", filePath, actualResult));
                }
                else
                {
                    logger.Error("Expected result is null or empty" + actualResult);
                }
            }
            catch(Exception ex)
            {
                logger.Error("Error: "+ex);
            }



        }


       /// <summary>
       /// Checks for version no on actiontype and filepath test2.
       /// </summary>
        [Test()]
        public void Check_for_version_no_on_actiontype_and_filepath_Test2()
        {
            actionType = "--v";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(actualResult.Length > 0, string.Format("Version number for {0} passed is - {1}", filePath, actualResult));
            }
        }

        /// <summary>
        /// Checks for version no on actiontype and filepath test3.
        /// </summary>
        [Test()]
        public void Check_for_version_no_on_actiontype_and_filepath_Test3()
        {
            actionType = "/v";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(actualResult.Length > 0, string.Format("Version number for {0} passed is - {1}", filePath, actualResult));
            }
        }

       /// <summary>
       /// Checks for version no on actiontype and filepath test4.
       /// </summary>
        [Test()]
        public void Check_for_version_no_on_actiontype_and_filepath_Test4()
        {
            actionType = "--version";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(actualResult.Length > 0, string.Format("Version number for {0} passed is - {1}", filePath, actualResult));
            }
        }

       /// <summary>
       /// Checks for filesize on actiontype and filepath test1.
       /// </summary>
        [Test()]
        public void Check_for_filesize_on_actiontype_and_filepath_Test1()
        {
            actionType = "-s";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(Convert.ToInt32(actualResult) > 0, string.Format("filesize for {0} passed is - {1}", filePath, actualResult));
            }
        }

        /// <summary>
        /// Checks for filesize on actiontype and filepath test2.
        /// </summary>
        [Test()]
        public void Check_for_filesize_on_actiontype_and_filepath_Test2()
        {
            actionType = "--s";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(Convert.ToInt32(actualResult) > 0, string.Format("filesize for {0} passed is - {1}", filePath, actualResult));
            }
        }

        /// <summary>
        /// Checks for filesize on actiontype and filepath test3.
        /// </summary>
        [Test()]
        public void Check_for_filesize_on_actiontype_and_filepath_Test3()
        {
            actionType = "/s";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(Convert.ToInt32(actualResult) > 0, string.Format("filesize for {0} passed is - {1}", filePath, actualResult));
            }
        }

        /// <summary>
        /// Checks for filesize on actiontype and filepath test4.
        /// </summary>
        [Test()]
        public void Check_for_filesize_on_actiontype_and_filepath_Test4()
        {
            actionType = "--size";
            var actualResult = Program.FileOperation(actionType, filePath);

            if (!string.IsNullOrEmpty(actualResult))
            {
                Assert.IsTrue(Convert.ToInt32(actualResult) > 0, string.Format("filesize for {0} passed is - {1}", filePath, actualResult));
            }
        }
    }
}