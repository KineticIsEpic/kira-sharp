using System;
using System.IO;
using System.Collections.Generic;

namespace KiraSharp {
    public delegate void LogEventArgs();

    /// <summary>
    /// App-wide message logging system
    /// </summary>
    public class Logger {
        /// <summary>
        /// Write a message to the application log.
        /// </summary>
        public static void Write(string text) {
            Write(text, false);
        }

        /// <summary>
        /// write a message to the application log.
        /// </summary>
        public static void Write(string text, bool append) {
            if (!File.Exists(".olog") && File.Exists(".log"))
                File.Copy(".log", ".olog");

            StreamWriter sw = new StreamWriter(".log", true);

            if (!append) sw.WriteLine("::$$ent:" + DateTime.Now.ToString() + ":");
            sw.Write(text);

            sw.Close();

            if (!File.Exists(".olog")) File.Copy(".log", ".olog");
        }

        /// <summary>
        /// Write a message to the appplication log, 
        /// followed by a return-newline sequence.
        /// </summary>
        public static void WriteLine(string text) {
            Write(text + "\r\n", false);
        }

        /// <summary>
        /// Write a message to the appplication log, 
        /// followed by a return-newline sequence.
        /// </summary>
        public static void WriteLine(string text, bool append) {
            Write(text + "\r\n", append);
        }

        /// <summary>
        /// read all unread messages in the application log.
        /// </summary>
        /// <returns></returns>
        public static List<LogEntry> Read() {
            if (File.Exists(".olog")) {
                StreamReader sr = new StreamReader(".log");
                StreamReader osr = new StreamReader(".olog");

                List<LogEntry> le = new List<LogEntry>();

                string logtext = sr.ReadToEnd();
                string ologtext = osr.ReadToEnd();
                sr.Close();
                osr.Close();

                File.Delete(".olog");

                List<int> entries = new List<int>();
                string newlogtext = logtext.Replace(ologtext, "");
                int i = 0;
                int j = 0;

                while (newlogtext.IndexOf("::$$", j) != -1) {
                    if (i == 0) entries.Add(newlogtext.IndexOf("::$$"));
                    else entries.Add(newlogtext.IndexOf("::$$", entries[i - 1] + 1));

                    j = entries[entries.Count - 1];
                    i++;

                    if (j == -1) break;
                }

                i = 0;

                foreach (int entry in entries) {
                    if (entry == -1) break;

                    int textend = 0;
                    try { textend = entries[i + 1]; }
                    catch (Exception) { textend = entries[entries.Count - 1]; }

                    if (textend == -1) textend = newlogtext.Length;

                    le.Add(new LogEntry(LogEntry.Type.General,
                        string.Copy(newlogtext.Substring(newlogtext.IndexOf(":\r\n", entries[i]) + 3, 
                            textend - newlogtext.IndexOf(":\r\n", entries[i]) - 3)),
                        string.Copy(newlogtext.Substring(entries[i] + 8,
                            newlogtext.IndexOf(":\r\n", entries[i]) - entries[i] - 8))));

                    i++;
                }
                return le; 
            }

            return new List<LogEntry> { new LogEntry(LogEntry.Type.None, "", "") };
        }

        /// <summary>
        /// reads the entire log contents. 
        /// </summary>
        /// <returns></returns>
        public static List<LogEntry> ReadAll() {
            if (File.Exists(".olog")) File.Delete(".olog");
            File.Create(".olog");

            return Read();
        }

        /// <summary>
        /// Clears all log files.
        /// </summary>
        public static void Clear() {
            File.Delete(".log");
            File.Delete(".olog");
            
            Write("Log cleared.");
        }
    }

    public class LogEntry {
        /// <summary>
        /// Make a new log entry
        /// </summary>
        public LogEntry(LogEntry.Type type, string text, string time) {
            Logtype = type;
            Text = text;
            Time = time;
        }

        public enum Type { General, None, }
        public Type Logtype;
        public string Text;
        public string Time;
    }
}
