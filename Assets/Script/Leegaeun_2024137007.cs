using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leegaeun_2024137007 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //215
        string message = "안녕하세요";

        Debug.Log(message + "!");
        Debug.Log(message[0]);
        Debug.Log(message[1]);
        Debug.Log(message[2]);

        Debug.Log("안녕하세요"[0]);
        Debug.Log("안녕하세요"[1]);
        Debug.Log("안녕하세요"[2]);

        //216
        bool one = 10 < 0;
        bool other = 20 > 100;

        Debug.Log(one);
        Debug.Log(other);

        //217
        int output = 0;
        output += 52;
        output += 273;
        output += 103;

        Debug.Log(output);

        //218
        string utput = "hello";
        utput += "world";
        utput += "!!";

        Debug.Log(utput);

        //219
        int number = 10;
        number++;
        Debug.Log(number);
        number--;
        Debug.Log(number);

        //220
        int numbe = 10;
        Debug.Log(numbe);
        Debug.Log(numbe++);
        Debug.Log(numbe--);
        Debug.Log(numbe);

        Debug.Log(number);
        Debug.Log(++number);
        Debug.Log(--number);
        Debug.Log(number);

        //224
        //강제 자료형 변환에 따른 데이터 손실 예
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);

        //강제 자료형 변환에 따른 데이터 손실 발생하지 않는 예
        long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

        //225
        //long 자료형을 int 자료형으로 변환
        long ongNumber = 2147483647L + 2147483647L;
        int ongToInt = (int)ongNumber;
        Debug.Log(ongToInt);

        //double 자료형을 int 자료형으로 변환
        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Debug.Log(doubleToInt);

        //226
        //int 자료형의 숫자를 생성
        int ntNumber = 2147483647;

        //int 자료형을 long 자료형으로 자동 변환
        long intToLong = ntNumber;
        Debug.Log(intToLong);

        //int 자료형을 double 자료형으로 자동 변환
        double intToDouble = ntNumber;

        //string 자료형을 int 자료형으로 변환
        /*string numberString = "52273";
        int tNumber = (int)numberString;
        Debug.Log(tNumber);*/

        //227
        Debug.Log(int.Parse("52"));
        Debug.Log(long.Parse("273"));
        Debug.Log(float.Parse("52.273"));
        Debug.Log(double.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());
        Debug.Log(long.Parse("273").GetType());
        Debug.Log(float.Parse("52.273").GetType());
        Debug.Log(double.Parse("103.32").GetType());

        //228
        Debug.Log((52).ToString());
        Debug.Log((52.273).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());

        Debug.Log((52).ToString().GetType());
        Debug.Log((52.273).ToString().GetType());
        Debug.Log(('a').ToString().GetType());
        Debug.Log((true).ToString().GetType());
        Debug.Log((false).ToString().GetType());

        //229
        double numgber = 52.273103;
        Debug.Log(numgber.ToString("0.0"));
        Debug.Log(numgber.ToString("0.00"));
        Debug.Log(numgber.ToString("0.000"));
        Debug.Log(numgber.ToString("0.0000"));

        //230
        Debug.Log(52 + 273);
        Debug.Log("52" + 273);
        Debug.Log(52 + "273");
        Debug.Log("52" + "273");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
