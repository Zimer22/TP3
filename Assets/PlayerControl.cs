using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Camera camaraPrimeraPersona;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            RaycastHit hit;

            if ((Physics.Raycast(ray, out hit) == true))
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.name);
                if (hit.collider.name.Substring(0, 10) == "Bot(Clone)")
                {
                    Destroy(GameObject.FindWithTag("AI"));
                }
            }
        }
    }


}


