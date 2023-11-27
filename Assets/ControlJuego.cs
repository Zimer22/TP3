using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControlJuego : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bot;
    public List<GameObject> listaEnemigos;
    float tiempoRestante;
    void Start()
    {
        ComenzarJuego();
    }
    void Update()
    {
        if (tiempoRestante == 0)
        {
            ComenzarJuego();

        }
        if (GameObject.FindGameObjectsWithTag("AI").Length == 0)
        {
            ComenzarJuego();

        }
    }
    void ComenzarJuego()
    {
        jugador.transform.position = new Vector3(-7.277461f, -3.39f, -8.402497f);
        foreach (GameObject item in listaEnemigos)
        {
            Destroy(item);
        }
        listaEnemigos.Add(Instantiate(bot, new Vector3(-2.87f, -3.47f, -1.892764f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-2.87f, -1.80f, -1.892764f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-2.87f, -0.47f, -1.892764f), Quaternion.identity));
        StartCoroutine(ComenzarCronometro(30));
    }

    public IEnumerator ComenzarCronometro(float valorCronometro = 30)
    {
        tiempoRestante = valorCronometro;
        while (tiempoRestante > 0)
        {
            Debug.Log("Restan " + tiempoRestante + " segundos.");
            yield return new WaitForSeconds(1.0f);
            tiempoRestante--;
        }
    }
}