using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnScript : MonoBehaviour
{
    public GameObject Bulletobj;
    public float bulletspeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            BulletDirection(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            BulletDirection(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            BulletDirection(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            BulletDirection(Vector3.right);
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            BulletDirection(Vector3.forward);
        }
        float xAxis = Input.GetAxis("Mouse X");
        float yAxis = Input.GetAxis("Mouse Y");
        transform.Rotate(-yAxis, xAxis,0);
    }
    private void BulletDirection(Vector3 direction)
    {
        GameObject bulletref = Instantiate(Bulletobj);
        bulletref.transform.position = transform.position;
        Rigidbody rb = bulletref.GetComponent<Rigidbody>();
        //rb.AddForce(direction * bulletspeed);
        //rb.velocity = Vector3.forward * bulletspeed;
        Camera camera = GetComponentInChildren<Camera>();
        rb.velocity = camera.transform.rotation * Vector3.forward * bulletspeed;
    }
}
