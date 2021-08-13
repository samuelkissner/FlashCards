using System;
using System.Collections;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace FlashCards
{
    class CSVParser
    {

        TextFieldParser csvParser;
        ArrayList Records;

        public CSVParser(string filePath)
        {
            csvParser = new TextFieldParser(filePath);
            Records = new ArrayList();
        }
        public ArrayList AddCSVRecordsToArrayList()
        {
            using (csvParser)
            {
                prepareCVSFileForParsing();

                while (!csvParser.EndOfData)
                {
                    AddCSVLineToArrayList();
                }
            }
            return Records;
        }
        public void prepareCVSFileForParsing()
        {
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = true;

            // Skip the row with the column names
            csvParser.ReadLine();
        }

        public void AddCSVLineToArrayList()
        {
            // Read current line fields, pointer moves to the next line.
            string[] fields = csvParser.ReadFields();
            string concept = fields[0];
            string description = fields[1];
            Records.Add(new Card(concept, description));
        }
         
    }
}
