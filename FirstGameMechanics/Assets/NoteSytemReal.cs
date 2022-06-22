using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSytemReal : MonoBehaviour
{
    public GameObject Note1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Note1.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Note1"))
        {
            Note1.SetActive(true);
        }


    }

    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Note1"))
        {
            Note1.SetActive(false);
        }

    }



}