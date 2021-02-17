using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class LoggerSingleton
    {
        private static readonly Lazy<LoggerSingleton> instance =
            new Lazy<LoggerSingleton>(() => new LoggerSingleton());

        public static LoggerSingleton Instance { get { return instance.Value; } }
        public string FilePath { get; }
        public string Text { get; set; }

        private LoggerSingleton()
        {
            FilePath = "test.txt";
            ReadTextFromFile();
        }

        public void WriteText(string text)
        {
            Text += text;
        }
        public void Save()
        {
            using (var writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(Text);
            }
        }
        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }
    }
}
