using System;
using System.IO;

namespace es_06
{
    public class Program
    {
        public static int[] ParseNumberFile(string filename)
        {

            string fileContent = File.ReadAllText(filename);

            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] integers = new int[integerStrings.Length];

            for (int row = 0; row < integerStrings.Length; row++)
            {
                try
                {
                    integers[row] = int.Parse(integerStrings[row]);
                }

                catch (Exception)
                {
                    throw new FileParseException(filename, row);
                }
            }
            return integers;
        }

        public class FileParseException : ApplicationException
        {
            string message;
            string fileName;
            int row;
            public FileParseException(string fileName, int row)
            {
                this.fileName = fileName;
                this.row = row;
                message = string.Format("Nel file {0}, nella riga {1} non è presente un intero ", this.fileName, this.row);
            }
            public override string Message
            {
                get { return this.message; }
            }
        }
        public static void Main()
        {
            int[] numbers = ParseNumberFile("file.txt");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

}



/*using System;
using System.IO;

namespace es_06
{
    public class FileParses
    {
        public static void FileParse(string path)
        {
            StreamReader input = null;
            string line = null;
            int row = 0;

            try
            {
                input = new StreamReader(path);
            }

            catch (IOException exception)
            {
                throw new FileParseException(path, exception);
            }

            line = input.ReadLine();
            row++;
            while (line != null)
            {
                try
                {
                    int.Parse(line);
                }
                catch (Exception exception)
                {
                    throw new FileParseException(path, row, exception);
                }

                
                row++;
            }

        }
        static void Main(string[] args)
        {
            FileParse("file.txt");
        }
    }

    public class FileParseException : ApplicationException
    {
        public FileParseException(string errorMessage, Exception internalException) : base(null, internalException)
        {
            this.message = errorMessage;
        }

        public FileParseException(string errorMessage)
        {
            this.message = errorMessage;
        }


        public FileParseException(string file, int row, Exception internalException)
            : base(null, internalException)
        {
            this.fileName = file;
            this.row = row;
        }

        public FileParseException(string file, int row)
        {
            this.FileName = file;
            this.Row = row;
            this.message = string.Format("Input {0] at row {1} has a wrong format", this.FileName, this.Row);
        }

        private string fileName;

        public string FileName
        {
            get { return this.fileName; }
            private set { this.fileName = value; }
        }

        private string message;

        public override string Message
        {
            get { return this.message; }
        }

        private int row;

        public int Row
        {
            get { return this.row; }
            private set { this.row = value; }
        }

    }
}
*/