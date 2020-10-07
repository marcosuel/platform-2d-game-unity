using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileManager : MonoBehaviour
{

    string[] lines;
    string myFilePath, lang, fileName;
    private Dictionary<string, string> mapped;
    // Start is called before the first frame update
    

    void Awake()
    {
        mapped = new Dictionary<string, string>();
        lang = FileScript.Language;
        fileName = "translation.txt";
        myFilePath = Application.streamingAssetsPath  + "/Resourses/Lang" + lang +"/" + fileName;
        MapFromFile();
    }

    public void MapFromFile(){
        lines = File.ReadAllLines(myFilePath);
        foreach(string line in lines){
            string[] aux = line.Split('=');
            mapped.Add(aux[0], aux[1]);
        }
        FileScript.MappedLines = mapped;
    }
}
