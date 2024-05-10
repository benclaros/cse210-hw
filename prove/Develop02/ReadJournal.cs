using System;
public class ReadJournal{
    List<Entry1>entrylist = new List<Entry1>();
    public void writefile(List<Entry1> entrylist){
      string filename = promptFile($"what is the file name?");
      using (StreamWriter outputFile = new StreamWriter(filename))
      foreach (var entry in entrylist)
      {

        outputFile.WriteLine(entry.something());

      }
    }
    public string promptFile(string promptQuestion){
      Console.Write(promptQuestion);
      string fileName = Console.ReadLine();
      fileName = "journal.txt";
      return fileName;    
    }

    public List<Entry1>readFile()
    {
      string fileName = promptFile($"what is the file name?");;
      string[] lines = System.IO.File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
        string[] parts = line.Split(",");
        Entry1 write = new Entry1();
        write.creatlist(parts);
        entrylist.Add(write);

        }
        return entrylist;

    }
}