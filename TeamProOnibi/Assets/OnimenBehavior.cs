using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnimenBehavior : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
       
        transform.position += (new Vector3(Mathf.Sin(Time.time / 2), Mathf.Cos(Time.time*2) , 0.0f) * Time.deltaTime);
    }
}
