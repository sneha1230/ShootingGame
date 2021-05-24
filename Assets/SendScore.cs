using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemeOneScoreValue = 1;

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        //GameObjectDestroy(collision);
        //print(collision.gameObject);
        collision.gameObject.SetActive(false);
    }
    private void GameObjectDestroy(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //print(collision.gameObject.tag);
            ScoreScript scrobj = FindObjectOfType<ScoreScript>();
            scrobj.ScoreCalculator(EnemeOneScoreValue);
            Destroy(collision.gameObject, 0.2f);
        }
    }
        
    /*private void OnTriggerEnter(Collider other)
    {
        print("the game object tag" + other.gameObject.tag);
    }*/
}