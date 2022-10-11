using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnimenBehavior : MonoBehaviour
{
    public GameObject player;
    public float T = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform);
       
        float f = 1.0f / T;
        float y = Mathf.Sin(2 * Mathf.PI * f * Time.time);
        this.transform.position = new Vector3(0,y,0);//oŒ»ˆÊ’u‚ğ’†S‚É•â³‚·‚é‚×‚µ
    }
}
