using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    //GameObject Ground;
    //public float offsetX = 17;
    //public int velocidadPiso;


    //void Update()
    //{
    //    transform.position -= new Vector3(velocidadPiso * Time.deltaTime, 0, 0);
    //    if (transform.position.x <= -offsetX)
    //    {
    //        transform.position = new Vector3 (offsetX, transform.position.y, 0);
    //    }
    //}
    GroundSpawner groundSpawner;
    
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

}
