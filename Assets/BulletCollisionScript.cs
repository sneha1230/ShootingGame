using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionScript : MonoBehaviour
{
    //int score = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.name == "enemy")
        {
            print("I got a HIT Enemy");
        }*/
        if (collision.gameObject.name == "Enemy")
        {
            //score++;
            print("I got a HIT Enemy and score is " );

        }
    }
}
