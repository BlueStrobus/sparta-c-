namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //1. 클레스, 메서드, 변수 등의 이름을 입려할 때 일부를 입력하고 Tab 키를 누르면 자동완성이 됩니다.
        // Console.WriteLine()을 입력시 Console까지만 입력하고 Tab 키를 누르면 자동완성이 됩니다.
        Console.WriteLine("C#");

        // 메서드나 변수를 입력하는 도중에 Ctrl + Space를 눌러 IntelliSense를 호출하면, 해당 메서드나 변수에 대한 정보와 예제를 볼 수 있습니다.
        Console.WriteLine("IntelliSense");

        // 2. 코드 템플릿을 사용하여 코드를 빠르게 작성할 수 있습니다.
        // ex) for문 작성 시, for 키워드를 입력하고, 두번 tap키를 누르면 for문의 기본적인 코드 템플릿이 자동으로 생성됩니다.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}