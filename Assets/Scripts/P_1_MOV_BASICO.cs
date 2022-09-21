using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_1_MOV_BASICO : MonoBehaviour
{
    [SerializeField]
    float velocidad  = 20;

    int aux = 2;

    public int temp = 5;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v;
            v = transform.forward;
            v = transform.forward * -1; //atras
            v = transform.right;
            v = transform.up;

        v = Vector3.forward;
        v = Vector3.back;
        v = Vector3.right;
        v = Vector3.left;
        v = Vector3.up;
        v = Vector3.down;

        //               x   y   z
        v = new Vector3(2f, 4f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
            //transform.Translate(Vector3.forward * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1f * velocidad * Time.deltaTime);
            //transform.Translate(Vector3.back * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
        

    }
}
