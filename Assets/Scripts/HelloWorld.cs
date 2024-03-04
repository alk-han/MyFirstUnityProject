using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField]
    GameObject helloText;

    string myText = "Hello World!";
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Application.targetFrameRate = 30;   // Fixed fps rate
        helloText.GetComponent<TextMeshPro>().text = $"{myText} : {speed}";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(1, 1, 1), Color.cyan);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
