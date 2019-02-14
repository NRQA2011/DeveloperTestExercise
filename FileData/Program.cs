using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        private static FileDetails _fd;
        /// <summary>
        /// Gets the fd.
        /// </summary>
        /// <value>The fd.</value>
        public static FileDetails fd
        {
            get
            {
                if (_fd == null)
                    return _fd = new FileDetails();

                return _fd;
            }
        }
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Count() == 0)
                return;

            foreach (var arg in args)
            {
                var items = arg.Split(' ');
                var result = FileOperation(items[0], items[1]);

                Console.WriteLine(string.Format("Result returned for requested action Type {0} is - {1} ", items[0], result));
            }

            Console.ReadLine();
        }

       /// <summary>
       /// Files the operation.
       /// </summary>
       /// <returns>The operation.</returns>
       /// <param name="action">Action.</param>
       /// <param name="filePath">File path.</param>
        public static string FileOperation(string action, string filePath)
        {
            var result = string.Empty;
            string[] possibleVersionArgs = new string[] { "-v", "--v", "/v", "--version" };
            string[] possibleSizeArgs = new string[] { "-s", "--s", "/s", "--size" };

            if (string.IsNullOrEmpty(action) || string.IsNullOrEmpty(filePath))
                return string.Empty;

            if (possibleVersionArgs.Contains(action))
                result = GetFileVersion(filePath);

            if (possibleSizeArgs.Contains(action))
                result = GetFileSize(filePath).ToString();

            return result;
        }

       /// <summary>
       /// Gets the file version.
       /// </summary>
       /// <returns>The file version.</returns>
       /// <param name="filePath">File path.</param>
        private static string GetFileVersion(string filePath)
        {
            return fd.Version(filePath);
        }


        /// <summary>
        /// Gets the size of the file.
        /// </summary>
        /// <returns>The file size.</returns>
        /// <param name="filePath">File path.</param>
        private static int GetFileSize(string filePath)
        {
            return fd.Size(filePath);
        }
    }
}

