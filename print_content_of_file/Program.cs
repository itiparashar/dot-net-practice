// See https://aka.ms/new-console-template for more information

// Program to print the contents of a file
// file name must be taken from cooamd line argument
// Let file will be of txt format

// check args are there
if(args.Length > 0)
{
    for(int i= 0; i<args.Length; i++)
    {
        printContents(args[i]);
    }
}

void printContents(string filePath)
{
    // 1. import necessary library "using system.IO"
    // 2. check file exists or not
    // 3. Open the file in read mode
    // 4. read contents
    // 5. close the file

    // C# streamreader => to read a file, streamwrite => write the file
    
    if (File.Exists(filePath))
    {
        // true means file exists
        StreamReader sr = new StreamReader(filePath);
        string data = sr.ReadToEnd();
        sr.Close();
        Console.WriteLine(data);
    }
    else
    {
        // false doesnot exists
        Console.WriteLine("File does not exists");
    }
}


