using UnityEngine;

public class Week : MonoBehaviour
{   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Task 1 Using a for loop, print numbers 1 to 10 in a single line.

        string line1To10 = "";
        for (int i = 1; i < 11; i++)
        {
            line1To10 += i + " ";
        }
        Debug.Log(line1To10);
        //Task 2 Create 2 int variables 
        // Using a while loop, increase the value of the smaller int by 1 until it is equal to the value of the larger int.
        //Then, print how many increments it took to make the variables equal.

        int smaller = 12;
        int larger = 219;
        int count = 0;

        while (smaller < larger)
        {
            ++smaller;
            ++count;
        }
        Debug.Log("It took " + count + " increments to make the numbers equal.");
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
