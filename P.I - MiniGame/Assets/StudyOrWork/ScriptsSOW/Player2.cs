using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public int pontoCoin;
    public TMP_Text textP1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Horizontal2") > 0) && (transform.position.x <= -16.1))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if((Input.GetAxisRaw("Horizontal2") < 0) && (transform.position.x >= -223))
        {
            transform.Translate(speed, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Respawn"))
        {
            pontoCoin++;
            textP1.SetText(pontoCoin.ToString());
        }
    }
}
