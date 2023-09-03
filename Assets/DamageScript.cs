using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 20;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // if (Enemy.gameObject.tag == "Enemy")
        // {
        //     hp -= 5
        // }
    }
}
