using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 randpos;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        Randomposition();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //동물이 반대로 움직이면 좌우 반전되어 이동
        if (randpos.x - transform.position.x < 0)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }


            this.transform.position = Vector3.MoveTowards(transform.position, randpos, 0.003f);
        if(transform.position == randpos)
        {
            Randomposition();
        }
    }

    void Randomposition()
    {
        randpos = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), -4);
    }
}
