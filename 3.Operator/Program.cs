namespace _3.Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 연산자 (Operator)
            // 수학에서 의미하는 변수가 프로그래밍에 있듯이
            // 수학에서 제공하는 다양한 연산을 할 수 있게 도와주는 다양한 연산자들이 있다.
            // 추가로 더 다양한 연산자들도 있다.

            /// 산술 연산자  
            // [] op [] // []괄호에 연산할 피연산자 , op 는 연산자를 의미
            int num;
            num = 1 + 1;     // +(더하기)
            num = 2 - 1;     // -(빼기)
            num = 3 * 3;     // *(곱하기)
            num = 4 / 3;   // /(나누기) : 주의! 5 / 3 과 같이 int의 나눗셈은 소수점을 버린다.
            num = 15 % 4;    // %(나머지)	: a - (a / b) * b 와 동일

            /// 단항 연산자
            // 하나의 항의 연산자
            num = +num;   // + 단항연산자(양수)	: 값을 반환;
            num = -num;   // - 단항연산자(음수)	: 값의 마이너스를 반환;

            ++num;           // ++ 전위증가연산자	: 값을 1 증가
            num++;           // ++ 후위증가연산자	: 값을 1 증가
            --num;           // -- 전위감소연산자	: 값을 1 감소
            num--;           // -- 후위감소연산자	: 값을 1 감소

            // 전위연산자 : 값을 반환하기 전에 연산
            num = 0;
            Console.WriteLine(num);      // output: 0
            Console.WriteLine(++num);    // output: 1 // 전위연산
            Console.WriteLine(num);      // output: 1		

            num = 0;
            Console.WriteLine(num);      // output: 0
            Console.WriteLine(num++);    // output: 0 // 후위연산
            Console.WriteLine(num);      // output: 1

            // 주의 전위 연산은 연산후 값을 주고 , 후위 연산은 값을 준후에 연산한다.

            // <대입 연산자>
            num = 10;        // = : 오른쪽의 값을 왼쪽 변수에 대입

            // <복합 대입 연산자>
            // 이진 연산자(op)의 경우
            // x op= y 는 x = x op y 와 동일
            num += 5;        // num = num + 5; 
            num -= 1;        // num = num - 1;
            num *= 2;        // num = num * 2;
            //... 모든 산술연산자 는 가능하다.


        }
    }
}