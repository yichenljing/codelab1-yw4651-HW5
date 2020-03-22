using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class AsciiLevelLoader : MonoBehaviour
{
    public GameObject wall;
    public GameObject prize;
    public GameObject player;

    public float xOffset = -5;
    public float yOffset = 5;

    public string fileLevel = "Level.txt"; 

    // Start is called before the first frame update
    void Start()
    {
        string fullFilePath = Application.dataPath + "/" + fileLevel;

        print("Full file path: " + fullFilePath); // print the path

        print(File.ReadAllText(fullFilePath));   // print the contents of the file

        string[] lines = File.ReadAllLines(fullFilePath); // line = an array of syrings

        GameObject wallHolder = new GameObject("wall Holder");

        for (int y = 0; y < lines.Length; y++) {
            string line = lines[y];  //get throgh eacch line

            char[] characters = line.ToCharArray(); // get throgh each character

        for (int x = 0; x < characters.Length; x++){
                GameObject newObject;

                switch (characters[x])
                { 
                    case 'W':

                        newObject = Instantiate<GameObject>(wall);
                        newObject.transform.SetParent(wallHolder.transform);

                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'P':
                        newObject = Instantiate<GameObject>(player);
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'E':
                        newObject = Instantiate<GameObject>(prize);
                        newObject.transform.position =
                                     new Vector2(x + xOffset, -y + yOffset);
                        break;

                    default:
                        print("empty");
                        break;


                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
