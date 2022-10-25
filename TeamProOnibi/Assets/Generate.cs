using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject player;
    public GameObject mazzle;
    public GameObject onibi;
    public float speed = 2.0f;//�e��
    public float destroyTime = 3.0f;//���ł���܂ł̎���
    public float waitTime = 1.0f;//���ˊԊu
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
        StartCoroutine(FirstWait());
    }

    // Update is called once per frame
    void Update()
    {
        //�G�̂ق�������
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

            //���ˏ���
            var aim = this.player.transform.position - this.transform.position;//�����̐ݒ�
            var shot = Instantiate(onibi, transform.position, Quaternion.LookRotation(aim));
            shot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;//�ړ�
            yield return new WaitForSeconds(waitTime);
            Destroy(shot, destroyTime);
        }
    }

}
