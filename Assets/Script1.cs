using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script1 : MonoBehaviour
{
    public Script2 scr;
    public int s = 0;
    public TextMeshPro t;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && scr.n == true)
        {
            s++;
            scr.n = false;
        }
    }

    public void Update()
    {
        t.text = s.ToString();
    }
}
