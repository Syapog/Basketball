using UnityEngine;
using System.Collections;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshPro my_text;
    private int i = 0;

    private void Start()
    {
        i = 0;
        my_text.text = " " + i.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            i++;
            my_text.text = " " + i.ToString();
           
        }
       
    }

  
}
