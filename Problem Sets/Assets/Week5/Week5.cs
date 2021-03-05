using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using SimpleJSON;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class Week5 : MonoBehaviour
{
    /*
     *Hi Jack!  I'm not sure exactly what is required to
     * convert each player's classType into a class-- right now they're strings (which I know is not the most efficient
     * way to think about solving this but in retrospect I'm not sure if I have as much cs background as I thought I
     * did when signing up for this class)!  Thank you for being patient as always :)
     *
     *
     * I spent way too long on the first question as per usual.  I feel like if I truly limited myself to
     * 30 minutes each I wouldn't be learning on my own, but I couldn't get the first one to work so far and I'm going
     * to move onto the second problem now!
     *
     * As for the regular assignment, I'm debating whether I want to use the given Roguelike or if I want to do
     * something super simple with my virtual DAW game, but I'll have to make that decision soon!
     *
     *
     *
     * 
     * Write a CSV parser - that takes in a CSV file of players and returns a list of those players as class objects.
     * To help you out, I've defined the player class below.  An example save file is in the folder "CSV Examples".
     *
     * NOTES:
     *     - the first row of the file has the column headings: don't include those!
     *     - location is tricky - because the location has a comma in it!!
     */

    /*
    private class Player
    {
        public enum Class : byte
        {
            Undefined = 0,
            Monk,
            Wizard,
            Druid,
            Thief,
            Sorcerer
        }
        
        public Class classType;
        public string name;
        public uint maxHealth;
        public int[] stats;
        public bool alive;
        public Vector2 location;
    }
    */

    private class Player
    {
        public enum Class : byte
        {
            Undefined = 0,
            Monk,
            Wizard,
            Druid,
            Thief,
            Sorcerer
        }
        
        public Class classType;
        public string name;
        public uint maxHealth;
        public int[] stats;
        public bool alive;
        public Vector2 location;
        
        public Player(Class classType, string name, uint maxHealth, int[] stats, bool alive, Vector2 location)
        {
            
        }
        

    }
    
    private string newName = null;
    private string newClass = null;
    private int newMaxHealth = 0;

    private int[] newStats = new int[5];
    //int newWisdom = 0;
    //int newIntelligence = 0;
    //int newStrength = 0;
    //int newDefense = 0;
    //int newAcrimony = 0;
    private bool newAlive = false;
    private int[] newLocation = new int[1];
    private List<Player> CSVParser(TextAsset toParse)
    {
        //declare variables to be reassigned

        
        
        
        
        //create string array of each character's details
        string[] players = toParse.text.Split ('\n');
        
        
        //defines dimensions of csv
        int rows = players.Length; //-1?
        int columns = 11;
        //string[,] statMatrix = new string[rows, columns];
        

        //create a player list that will hold all players
        List<Player> allPlayers = new List<Player>();
        
        
        
        for (int i = 1; i < rows; i++)  //start at 1 because of column headings row
        {
            //separates each character's stats into string array
            string[] stats = players[i].Split(',');

            
            
            for (int j = 0; j < columns; j++)
            {
                switch (j) 
                {
                    case 0:
                        newName  = stats[j];
                        break;

                    case 1:
                        newClass = stats[j];
                        break;

                    case 2:
                        newMaxHealth = Int32.Parse(stats[j]);
                        break;
                        
                    case 3:
                        newStats[0] = Int32.Parse(stats[j]);
                        break;
                        
                    case 4:
                        newStats[1] = Int32.Parse(stats[j]);
                        break;
                    
                    case 5:
                        newStats[2] = Int32.Parse(stats[j]);
                        break;
                        
                    case 6:
                        newStats[3] = Int32.Parse(stats[j]);
                        break;
                        
                    case 7:
                        newStats[4] = Int32.Parse(stats[j]);
                        break;
                        
                    case 8:
                        newAlive = Convert.ToBoolean(stats[j]);
                        break;
                        
                    case 9:
                        newLocation[0] = Int32.Parse(stats[j]);;
                        break;
                        
                    case 10:
                        newLocation[1] = Int32.Parse(stats[j]);
                        //Player.name = Player.name + ", " + stats[j]; //concatenates both location coordinates
                        break;
                        
                    //default:
                        //Console.WriteLine("Done");
                        //break;
                }
            }//exits for loop
            
            
            //add new player to list each loop
            allPlayers.Add(new Player(newClass, newName, newMaxHealth, newStats, newAlive, newLocation)); 
            
            //not sure when to use {} in a new class instantiation?
            //(newClass, newName, newMaxHealth, newStats, newAlive, newLocation));

        }
        
        
        //2D ARRAY ATTEMPT
        /*
        //fills in slots
        for (int i = 1; i < rows; i++)
        {
            //separates each character's stats into string array
            string[] stats = players[i].Split(',');
            
            for (int j = 0; j < columns; j++)
            {
            
                //check to see if string is second "location dimension" and if so concatenate
                if (j == 10)
                {
                    statMatrix[i, 9] = statMatrix[i, 9] + ", " + stats[j];
                }

                else
                {
                    statMatrix[i, j] = stats[j];
                }

            }
        }
        */
            

            //Player Yes = new Player();



            var toReturn = allPlayers;

        return toReturn;
    }
    
    
    
    

    /*
     * Provided is a high score list as a JSON file.  Create the functions that will find the highest scoring name, and
     * the number of people with a score above a score.
     *
     * I've included a library "SimpleJSON", which parses JSON into a dictionary of strings to strings or dictionaries
     * of strings.
     *
     * JSON.Parse(someJSONString)["someKey"] will return either a string value, or a Dictionary of strings to
     * JSON objects.
     */

    public int NumberAboveScore(TextAsset jsonFile, int score)
    {
        var toReturn = 0;
     
        return toReturn;
    }

    public string GetHighScoreName(TextAsset jsonFile)
    {
        return "";
    }
    
    
    
    
    
    
    
    
    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI csvTest, networkTest;
    public TextAsset csvExample, jsonExample;
    private Coroutine checkingScores;
    
    private void Update()
    {
        csvTest.text = "CSV Parser\n<align=left>\n";

        var parsedPlayers1 = CSVParser(csvExample);
        
        if (parsedPlayers1.Count == 0)
        {
            csvTest.text += "Need to return some players.";
        }
        else
        {
            csvTest.text += Success(parsedPlayers1.Any(p => p.name == "Jeff") &&
                                    parsedPlayers1.Any(p => p.name == "Stonks")
                            ) + " read in player names correctly.\n";
            csvTest.text +=
                Success(parsedPlayers1.First(p => p.name == "Jeff").alive &&
                        !parsedPlayers1.First(p => p.name == "Stonks").alive) + " Correctly read 'alive'.\n";
            csvTest.text +=
                Success(parsedPlayers1.First(p => p.name == "Stonks").classType == Player.Class.Wizard &&
                        parsedPlayers1.First(p => p.name == "Twergle").classType == Player.Class.Thief) +
                " Correctly read player class.\n";
            csvTest.text +=
                Success(parsedPlayers1.First(p => p.name == "Fortune").location == new Vector2(12.322f, 42f)) +
                " Correctly read in location.\n";
            csvTest.text += Success(parsedPlayers1.First(p => p.name == "Jeff").maxHealth == 23) +
                            " Correctly read in max health.\n";
            csvTest.text +=
                Success(parsedPlayers1.First(p => p.name == "Fortune").location == new Vector2(12.322f, 42f)) +
                " Correctly read in location.\n";
        }
        
        networkTest.text = "JSON Data\n<align=left>\n";
        networkTest.text += Success(NumberAboveScore(jsonExample, 10) == 6) + " number above score worked correctly.\n";
        networkTest.text += Success(GetHighScoreName(jsonExample) == "GUW") + " get high score name worked correctly.\n";
    }
    
    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}