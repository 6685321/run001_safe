using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBG : MonoBehaviour
{
    Material material;
    Vector2 movement;
    public Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        movement += speed * Time.deltaTime;
        material.mainTextureOffset = movement;

        if(SpeedUp.change == true)
        {
            movement += speed * Time.deltaTime * 4;
            material.mainTextureOffset = movement;
            Debug.Log("hahaha");
        }
    }
}
