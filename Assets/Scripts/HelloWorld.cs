using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    #pragma warning disable 0414
    // Integral types
    sbyte   _masks       = 127;                         // Signed 8-bit integer -128 to 127
    byte    _skillPoints = 255;                         // Unsigned 8=bit integer 0 to 255
    short   _hitPoints   = 32_767;                      // Signed 16-bit integer -32,768 to 32,767
    ushort  _maxDamage   = 65_535;                      // Unsigned 16-bit integer 0 to 65,535
    int     _rank        = 2_147_483_647;               // Signed 32-bit integer -2,147,483,648 to 2,147,483,647
    uint    _userID      = 4_294_967_295;               // Unsigned 32-bit integer 0 to 4,294,967,295
    long    _largeNum    =  9_223_372_036_854_775_807;  // Signed 64-bit integer -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
    ulong   _bigNum      = 18_446_744_073_709_551_615;  // Unsigned 64-bit integer 0 to 18,446,744,073,709,551,615

    // Floating-point numeric types
    float   _force   = 1000f;               // 4 bytes 6 to 9 digits precision
    double  _pi      = 3.141592653589793;   // 8 bytes 15 to 17 digits precision
    decimal _deposit = 54675.4242424242m;   // 16 bytes 28-29 digits precision

    // Characters
    string _username = "user123";
    char _c = 'A';
    #pragma warning restore

    [SerializeField] GameObject helloText;

    float speed = 3.0f;
    string myText = "Hello World!";
    
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
