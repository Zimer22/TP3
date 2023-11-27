using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text aiamount;
    private void Start()
    {
        aiamount.text = "";
    }
    void Update()
    {
        var tags = GameObject.FindGameObjectsWithTag("AI").Length;
        aiamount.text = tags.ToString();

    }
}