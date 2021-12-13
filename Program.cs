//Console.WriteLine("Hello, World!");
string[] folder1files = Directory.GetFiles(@"G:\My Drive\Films", "*.*", SearchOption.AllDirectories);
string[] folder2files = Directory.GetFiles(@"D:\Huge Merger", "*.*", SearchOption.AllDirectories);

List<string> filenamesandsizes1 = new List<string>() { };
List<string> filenamesandsizes2 = new List<string>() { };

foreach (var file in folder1files)
{
    //Console.WriteLine(Path.GetFileName(file));
    long length = new System.IO.FileInfo(file).Length;
    //Console.WriteLine("File Size in Bytes: {0}", length);
    filenamesandsizes1.Add(file);
    filenamesandsizes1.Add(Path.GetFileName(file));
    filenamesandsizes1.Add(length.ToString());

}
foreach (var file in folder2files)
{
    //Console.WriteLine(Path.GetFileName(file));
    long length = new System.IO.FileInfo(file).Length;
    //Console.WriteLine("File Size in Bytes: {0}", length);
    filenamesandsizes2.Add(file);
    filenamesandsizes2.Add(Path.GetFileName(file));
    filenamesandsizes2.Add(length.ToString());
}

for (int i = 0; i < filenamesandsizes1.Count; i = i + 3)
{
    Console.WriteLine("Searching for: " + filenamesandsizes1[i+1]);
    for (int x = 0; x < filenamesandsizes2.Count; x = x + 3)
    {
        //Console.WriteLine("Is this it: " + filenamesandsizes2[x]);
        if (filenamesandsizes1[i+2] == filenamesandsizes2[x+2] && filenamesandsizes1[i+1] == filenamesandsizes2[x+1])
        {
            Console.WriteLine("Match found!");
            File.Delete(filenamesandsizes1[i]);
            break;
        }
    }
}
