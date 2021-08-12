using System;
using System.Collections;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace FlashCards
{
    class CSVParser
    {

        TextFieldParser csvParser;
        ArrayList Cards;

        public CSVParser(string filePath)
        {
            csvParser = new TextFieldParser(filePath);
            Cards = new ArrayList();
        }
        public ArrayList parse()
        {

            using (csvParser)
            {
                prepareCVSFileForParsing();

                while (!csvParser.EndOfData)
                {
                    ProcessCSVRecord();
                }
            }


            return Cards;
        }


        public void prepareCVSFileForParsing()
        {
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = true;

            // Skip the row with the column names
            csvParser.ReadLine();
        }

        public void ProcessCSVRecord()
        {
            // Read current line fields, pointer moves to the next line.
            string[] fields = csvParser.ReadFields();
            string concept = fields[0];
            string description = fields[1];
            flashCards.Cards.Add(new Card(concept, description));
        }
         
    }
}
