using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int pontoBook;
    public TMP_Text textP2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Horizontal") > 0) && (transform.position.x <= 223))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if ((Input.GetAxisRaw("Horizontal") < 0) && (transform.position.x >= 17))
        {
            transform.Translate(speed, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Respawn"))
        {
            pontoBook++;
            textP2.SetText(pontoBook.ToString());
        }
    }
}
