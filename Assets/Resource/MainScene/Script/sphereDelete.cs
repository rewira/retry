using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sphereDelete : MonoBehaviour
{
    private int count;
    public Text clearText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.collider.gameObject);
                count++;
            }
        }

        if (count == 3)
        {
            clearText.text = "CLEAR";
        }
    }
}
