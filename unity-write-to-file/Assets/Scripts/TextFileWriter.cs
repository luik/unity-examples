using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextFileWriter : MonoBehaviour {

    public const string FILE_PATH = "logs.txt";


	void Start () {
	}
	
	void Update () {
		
	}

    public void WriteLine(string line)
    {
        File.AppendAllText(FILE_PATH, line + "\n");
    }

    public void Clear()
    {
        File.Delete(FILE_PATH);
    }
}
