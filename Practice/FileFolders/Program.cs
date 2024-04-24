using System;
using System.Collections.Generic;
using System.IO;
namespace FileFolders;
class Program{
    public static void Main(string[] args)
    {
        //string path=@"C:\Users\SivakumarVairamuthu\OneDrive - Syncfusion\Desktop\Files";
      /*  bool flag=true;
        do
        {
            Console.WriteLine($"1. Folder Created\n2. File Created\n3. Delete Folder\n4. Delete Files");
            Console.WriteLine($"Enter the option : ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine($"Enter the Folder Name : ");
                    string folderPath=Console.ReadLine();
                    if(!Directory.Exists(path+"/"+folderPath))
                    {
                        Directory.CreateDirectory(path+"/"+folderPath);
                        Console.WriteLine($"Folder Created Successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Already Exists");
                        
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Enter the File Name : ");
                    string filename=Console.ReadLine();
                    Console.WriteLine($"Enter extension of file : ");
                    string extension=Console.ReadLine();
                    string filePath=path+"/"+filename+"."+extension;
                    
                    if(!File.Exists(filePath))
                    {
                        File.Create(filePath);
                        Console.WriteLine($"File Created Successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Already Exists");
                        
                    }
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Enter folder name to Remove : ");
                    string folder=Console.ReadLine();
                    foreach (string  path1 in Directory.GetDirectories(path))
                    {
                        if(path1.Contains(folder))
                        {
                            //Directory.Delete(path1);
                            Console.WriteLine($"{path1}");
                            
                            Console.WriteLine($"Folder deleted");
                            
                        }
                    }
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Enter Filename With extension to Remove : ");
                    string file=Console.ReadLine();
                    foreach (string  path1 in Directory.GetFiles(path))
                    {
                        if(path1.Contains(file))
                        {
                            //File.Delete(path1);
                            Console.WriteLine($"{path1}");
                        }
                    }
                    break;
                }
                case 5:
                {
                    flag=false;
                    break;
                }
            }       
        } while (flag); */


       if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine($"Folder Created Successfully.");
        }
        else
        {
            Console.WriteLine($"Already Exists");    
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            File.Create("TestFolder/Data.csv");
            Console.WriteLine($"File Created Successfully.");
        }
        else
        {
            Console.WriteLine($"Already Exists");
            
        }
        List<Student> studentList=new List<Student>();
        studentList.Add(new Student(){Name="siva",FatherName="vairamuthu",DOB=new DateTime(2001,12,24),Gender=Gender.Male,TotalMark=450});
        studentList.Add(new Student(){Name="Sivakumar",FatherName="muthu",DOB=new DateTime(2001,12,24),Gender=Gender.Male,TotalMark=450});
        studentList.Add(new Student(){Name="Kumar",FatherName="vairamuthu",DOB=new DateTime(2001,12,24),Gender=Gender.Male,TotalMark=450});
        studentList.Add(new Student(){Name="Kumar",FatherName="vairamuthu",DOB=new DateTime(2001,12,24),Gender=Gender.Male,TotalMark=450});
        WriteTOCSV(studentList);
        ReadCSV();
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine($"Folder Created Successfully.");
        }
        else
        {
            Console.WriteLine($"Already Exists");    
        }
        

    }
    static void ReadText()
    {
        string[] content=File.ReadAllLines("TestFolder/Myfile.txt");
        foreach (string item in content)
        {
            Console.WriteLine($"{item}");
            
        }
    }
    static void WriteToText()
    {
        string[] content=File.ReadAllLines("TestFolder/Myfile.txt");
        Console.WriteLine($"Enter the Text : ");
        string newLine=Console.ReadLine();
        StreamWriter streamWriter=new StreamWriter("TestFolder/Myfile.txt");
        string old="";
        foreach (string item in content)
        {
            old=old+item+"\n";
        }
        old=old+newLine;
        streamWriter.WriteLine(old);
        streamWriter.Close();
    }
    static void WriteTOCSV(List<Student> studentList)
    {
        StreamWriter streamWriter=new StreamWriter("TestFolder/Data.csv");
        foreach(Student student in studentList)
        {
            string Line=student.Name+","+student.FatherName+","+student.DOB.ToString("dd/MM/yyyy")+","+student.Gender+","+student.TotalMark;
            streamWriter.WriteLine(Line);
        }
        streamWriter.Close();
    }
    static void ReadCSV()
    {
        List<Student> students=new List<Student>();
        StreamReader streamReader=new StreamReader("TestFolder/Data.csv");
        string line=streamReader.ReadLine();
        //string[] lines=File.ReadAllLines("TestFolder/Data.csv"); --> Read all lines and store into string array
        while(line!=null)
        {
            string[] values=line.Split(",");
            if(values[0]!="")
            {
                Student student=new Student(){
                    Name=values[0],
                    FatherName=values[1],
                    DOB=DateTime.ParseExact(values[2],"dd/MM/yyyy",null),
                    Gender=Enum.Parse<Gender>(values[3]),
                    TotalMark=int.Parse(values[4])
                };
                students.Add(student);
            }
                line=streamReader.ReadLine();
        }
        streamReader.Close();
        foreach (Student list in students)
        {
            Console.WriteLine($"{list.Name},{list.FatherName},{list.Gender},{list.DOB},{list.TotalMark}");            
        }
    }
}
