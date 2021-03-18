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
public class Week7 : MonoBehaviour
{
    /*
     * Below are a series of problems to solve with recursion.  You may need to make additional functions to do so.
     * Do not solve these problems with loops.
     */

    
    public string output = "";
    public string leftover = "";
    
    // Return the reversed version of the input.
    public string ReverseString(string toReverse)
    {
        
        /*
        general solution layout:
        concatenate last letter to output string
        run everything but last letter back through reverse string function
        
        
        string leftover = toReverse(0:end-1);
        string output = toReverse(end) + ReverseString(leftover); 
        */

        /*
        if (toReverse.Length > 0)
        {
            leftover = toReverse.Substring(0, toReverse.Length);
            output = output + ReverseString(toReverse.Substring(0, toReverse.Length)); // + ReverseString(leftover);  
        }*/
        
        if (toReverse.Length > 1)
        {
            leftover = toReverse.Substring(0, toReverse.Length - 2);
            return
                (toReverse.Substring(toReverse.Length - 1) +
                 ReverseString(leftover)); //.Substring(0, toReverse.Length-1))); // + ReverseString(leftover);  
        }
        
        else
        {
            return toReverse;
        }
        
        
        return "";
    }

    private string first = "";
    private string last = "";
    private string middle = "";
    
    // Return whether or not the string is a palindrome
    public bool IsPalindrome(string toCheck)
    {
        /*
         * compare first letter to last letter
         * run substring of everything but first and last letter through comparer again
         * if ever not equal, return false
         * return true if 0 or 1 letter is left in the substring and still true
         */



        if (toCheck.Length > 1)
        {
            
            
            first = toCheck.Substring(0);
            last = toCheck.Substring(toCheck.Length - 1);

            Debug.Log(first + last);
            
            if (first != last)
            {
                return false;
            }

            middle = toCheck.Substring(1, toCheck.Length - 2);
            
            IsPalindrome(middle);

        }
        
        return true;
    }
    
    
    
    

    // Return all strings that can be made from the set characters using all characters.
    
    /*
     *this time i will start with an external method
     * 
     * abc
     * abc acb bac bca cab cba
     *
     * assign each letter a number in a character array
     * for string.length-1 iterate what the next character could be 
     */
    public string[] AllStringsFromCharacters(params char[] characters)
    {
        return new string[0];
    }

    private static nextLetter()
    {
        
    }
    
    // Return the sum of all the numbers given.

    public int SumOfAllNumbers(params int[] numbers)
    {
        return 0;
    }
    
    /*
     * Solve the following problem with recursion:
     *
     * A new soda company is doing a promotion - they'll buy back cans.  But they're not sure how much to charge per can,
     * or how much to pay out for cans.  Write a function that can determine how many cans someone can purchase for
     * a given amount of money, assuming they always return all the cans and then buy as much soda as they can.
     */

    public int TotalCansPurchasable(float money, float price, float canRefund)
    {
        return 0;
    }
    
    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI recursionTest, sodaTest;
    
    private void Update()
    {
        
        //Debug.Log(ReverseString("TEST"));
        Debug.Log(IsPalindrome("racecar"));
        recursionTest.text =  "Recursion Problems\n<align=left>\n";
        recursionTest.text += Success(ReverseString("TEST") == "TSET") + " string reverser worked correctly.\n";
        recursionTest.text += Success(!IsPalindrome("TEST") && IsPalindrome("ASDFDSA") && IsPalindrome("ASDFFDSA")) + " palindrome test worked correctly.\n";
        recursionTest.text += Success(AllStringsFromCharacters('A', 'B').Length == 2 && AllStringsFromCharacters('A').Length == 1 && AllStringsFromCharacters('A', 'B', 'C').Length == 6 && AllStringsFromCharacters('A', 'B', 'C', 'D', 'E', 'F', 'G').Length == 5040) + " all strings test worked correctly.\n";
        recursionTest.text += Success(SumOfAllNumbers(1, 2, 3, 4, 5) == 15 && SumOfAllNumbers(1, 2, 3, 4, 5, 6, 7) == 28) + " sum test worked correctly.\n";

        sodaTest.text = "Soda Problem\n<align=left>\n";
        
        sodaTest.text += Success(TotalCansPurchasable(4, 2, 1) == 3) + " soda test works correctly w/out change.\n";
        sodaTest.text += Success(TotalCansPurchasable(5, 2, 1) == 4) + " soda test works correctly w/change.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}