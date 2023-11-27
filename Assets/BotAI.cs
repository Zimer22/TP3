using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAI : MonoBehaviour
{
    private int hp;
    public int speed;
    Rigidbody bot_Rigidbody;
    void Start()
    {
        hp = 1;
        bot_Rigidbody = GetComponent<Rigidbody>();
        InvokeRepeating("MovimientoIzquierda", 0.0f, 10.0f);
        InvokeRepeating("MovimientoDerecha", 5.0f, 10.0f);
     
    }
    public void recibirDaño()
    {
        hp = hp - 1;
        if (hp <= 0)
        {
            this.desaparecer();
        }
    }
    private void desaparecer()
    {
        Destroy(gameObject);
    }
    void MovimientoIzquierda()
    {
        bot_Rigidbody.velocity = Vector3.zero;
        bot_Rigidbody.AddForce(-speed ,0 ,0 ,ForceMode.VelocityChange);
    }
    void MovimientoDerecha()
    {
        bot_Rigidbody.velocity = Vector3.zero;
        bot_Rigidbody.AddForce(speed, 0, 0, ForceMode.VelocityChange);
    }
}
