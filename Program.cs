using System;
class FirstProgram
{
    static void Main() {
       Console.WriteLine("Hello");

        //signed integer types
        sbyte sb = -120;
        short s = 30000;
        int i = 2000000000;
        long l = 10000000000000;
        Console.WriteLine(sb);
        Console.WriteLine(i);
        Console.WriteLine(l);
        Console.WriteLine(s);

        //unsigned Integer types
        byte b = 122;
        ushort us = 60123;
        uint ui = 4000000000;
        ulong ul = 100000000000000;
        Console.WriteLine(b);
        Console.WriteLine(us);
        Console.WriteLine(ui);
        Console.WriteLine(ul);

        //floating point type
        float f = 12.7f;
            double d = 23.67;
        decimal dm = 99.12520m;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(dm);

        //other variable types
        char c = 'a';
        bool flag = false;
        string str = "Welcome to BridgeLabz";

        Console.WriteLine(str);
        Console.WriteLine(flag);
        Console.WriteLine(c);
            }
}