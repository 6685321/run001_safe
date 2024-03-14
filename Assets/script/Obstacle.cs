using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject[] res;
    public float CreateTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CreateTime -= Time.deltaTime;
        if(CreateTime <= 0)
        {
            CreateTime = Random.Range(2, 4);
            Ins_Objs();
        }

    }

    void Ins_Objs()
    {
        int Random_Objects = Random.Range(0, res.Length);
        transform.position = new Vector2(10, -2);

        Instantiate(res[Random_Objects]);
    }
}
