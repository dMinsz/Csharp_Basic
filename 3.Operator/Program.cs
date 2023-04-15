using System;

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

            // 단항 연산자
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

            ///논리 연산자

            bool flag;
            flag = !false;        // !(Not) : 피연산자의 논리의 부정을 반환
            flag = true && false; // &&(And) : 두 피연산자가 모두 true 일 경우 true
            flag = true || false; // ||(Or) : 두 피연산자가 모두 false 일 경우 false
            flag = true ^ false;  // ^(Xor) : 두 피연산자가 다를 경우 true

            // <조건부 논리 연산자>
            // 조건부 논리 And 연산자 &&
            
            // 주의 빠른 계산을 위해 false && x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
            // 결과는 항상 false이기 때문에 false && x 에서 x는 무시하게 됨
            
            int num = 10;

            flag = false && (++num > 5);
            Console.WriteLine(num);  // output : 10

            // 조건부 논리 Or 연산자 ||
            
            // 주의 빠른 계산을 위해 true || x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
            // 결과는 항상 true이기 때문에 true || x 에서 x는 무시하게 됨
            
            num = 10;
            
            flag = true || (++num > 5);
            Console.WriteLine(num);  // output : 10


            //비트 연산자

            // <단항 연산자>
            int bit  = ~0x25;         // ~(비트 보수) : 데이터를 비트단위로 보수 연산 (보수 : 0->1, 1->0)

            // <이진 연산자>
            bit = 0x11 & 0x83;   // &(And) : 데이터를 비트단위로 And 연산
            // 0001 0001 & 1000 0011 = 0000 0001
           
            bit = 0x11 | 0x83;   // |(Or) : 데이터를 비트단위로 Or 연산
            //0001 0001 | 1000 0011 = 1001 0011

            bit = 0x11 ^ 0x83;   // ^(Xor) : 데이터를 비트단위로 Xor 연산
            //0001 0001 ^ 1000 0011 = 1001 0010

            // <비트 쉬프트 연산자>
            bit = 0x20 << 2;     // << : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 왼쪽으로 이동
            bit = 0x20 >> 2;     // >> : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 오른쪽으로 이동


            /*
             * 연산자 우선순위 높은거부터 낮은순서로
             * 
             * () 괄호
             * ++, -- (전위 연산자)
             * ! (논리 부정)
             * *, /, %
             * +, -
             * <<, >>
             * <, <=, >, >=, is, as
             * ==, !=
             * &
             * ^
             * |
             * &&
             * ||
             * ? : (삼항 연산자)
             * =, +=, -=, *=, /=, %=, &=, ^=, |=, <<=, >>= 
             * ++, -- (후위 연산자)
             * 
             */

        }
    }
}