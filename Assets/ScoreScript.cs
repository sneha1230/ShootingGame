using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    int score=0;
    /*private void OnCollisionEnter(Collision collision)
    {
        ScoreCalculator();
    }*/


    public void ScoreCalculator(int value)
    {
        score=score+value;
        print("The Score is " + score);
    }
}
