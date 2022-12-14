using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject player;
    public GameObject mazzle;
    public GameObject onibi;
    public float speed = 2.0f;//弾速
    public float destroyTime = 3.0f;//自滅するまでの時間
    public float waitTime = 1.0f;//発射間隔
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
        StartCoroutine(FirstWait());
    }

    // Update is called once per frame
    void Update()
    {
        //敵のほうを向く
        transform.LookAt(player.transform);
    }
    IEnumerator FirstWait()
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(Onibi());
    }
    IEnumerator Onibi()
    {
        while (true)
        {

            //発射処理
            var aim = this.player.transform.position - this.transform.position;//方向の設定
            var shot = Instantiate(onibi, transform.position, Quaternion.LookRotation(aim));
            shot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;//移動
            yield return new WaitForSeconds(waitTime);
            Destroy(shot, destroyTime);
        }
    }

}
