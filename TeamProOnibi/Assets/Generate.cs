using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject player;
    public GameObject mazzle;
    public GameObject onibi;
    public float speed = 2.0f;
    public float destroyTime = 3.0f;
    float scale;
    public float exRate = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
        StartCoroutine("Onibi");
        scale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = mazzle.transform.position;
        scale += exRate;
        onibi.transform.localScale += new Vector3(scale, scale, scale);

        鬼火のほうでスケールを変更→ここでif（１になったら）発射する
    }
    IEnumerator Onibi()
    {
        while (true)
        {
            transform.LookAt(player.transform);
            var aim = this.player.transform.position - this.transform.position;//方向の設定
            var shot = Instantiate(onibi, transform.position, Quaternion.LookRotation(aim));
            shot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;//移動
            yield return new WaitForSeconds(1.0f);
            Destroy(shot, destroyTime);

        }
    }
}
