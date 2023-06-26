using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.RichTextParser;

namespace rtf2frx
{
    class Program
    {
        static string SelectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "RichText files (*.rtf)|*.rtf";
            dialog.Title = "Select a file for conversion to FRX format";

            if (dialog.ShowDialog() != DialogResult.OK)
                return null;
            return dialog.FileName;
        }

        static void ConvertFile(string filename)
        {
            try
            {
                ImportRtf rtf_convertor = new ImportRtf(filename);
                rtf_convertor.ResetProperties();
                Report report = rtf_convertor.CreateReport();
                report.FileName = filename + ".frx";
                report.Save(report.FileName);
            }
            catch (Exception excp)
            {
                Console.WriteLine("Processing file: " + filename);
                Console.WriteLine(excp.Message);
            }
        }

        static void TraverseDirectory(string dirname)
        {
            foreach (string dir in Directory.GetDirectories(dirname))
                TraverseDirectory(dir);
            foreach (string file in Directory.GetFiles(dirname))
                if (file.ToLower().EndsWith(".rtf"))
                    ConvertFile(file);
        }

        [STAThread]
        static void Main(string[] args)
        {
            string source_name = string.Empty;
            if (args.Length > 0)
            {
                source_name = args[0];
                if (!File.Exists(source_name))
                {
                    if(Directory.Exists(source_name))
                    {
                        Console.WriteLine("Starting batch conversion in '" + source_name + "'");
                        TraverseDirectory(source_name);
                        return;
                    }
                    Console.WriteLine("File '" + source_name + "' not found");
                    return;
                }
            }
            else
            {
                source_name = SelectFile();
            }

            bool repit = false;

            do
            { 
                try
                {
                    repit = false;
                    ImportRtf rtf_convertor = new ImportRtf(source_name);
                    rtf_convertor.ResetProperties();
                    Report report = rtf_convertor.CreateReport();
                    if (args.Length < 2)
                    {
                        report.FileName = source_name + ".frx";
                        report.Design();
                    }
                    else
                    {
                        report.FileName = args[1];
                        report.Save(args[1]);
                    }
                }
                catch (IOException exc)
                {
                    DialogResult dr = MessageBox.Show(exc.Message + "\n\nWould you like to comnvert another file?",
                        "Unable convert " + Path.GetFileName(source_name), MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        source_name = SelectFile();
                        if(source_name != null)
                            repit = true;
                    }
                    else
                        repit = false;
                }
            }
            while (repit);
        }
    }
}
