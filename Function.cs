using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //CalculateTwoNumbers(4,8);
        int Sum = CalculateTwoNumbers(12, 23);
        print("sum of two numbers is " + Sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void CalculateTwoNumbers()
    //{
    //    print("sum of two numbers is " + (4 + 6));
    //}
    //void CalculateTwoNumbers(int a, int b)
    //{
    //    int Sum = a+ b;
    //    print("sum of two numbers is " + Sum);
    //}
    //int CalculateTwoNumbers()
    //{
    //    return 4 + 5;
    //}
    int CalculateTwoNumbers(int a, int b)
    {
        return (a+b);
    }
}
