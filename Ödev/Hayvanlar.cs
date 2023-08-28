using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ödev;

abstract class Hayvanlar
{
    public void Ses()
    {
        Console.WriteLine("Sesler:");
    }
    public abstract void Sescikar();
    
}
class bird : Hayvanlar
{
    public override void Sescikar()
    {
        Console.WriteLine("Kuşlar Cikcikler");
    }
}
class dog : Hayvanlar
{
public override void Sescikar()
    {
        Console.WriteLine("Köpekler Havlar");
    }
}

class cat : Hayvanlar
{
    public override void Sescikar()
    {
        Console.WriteLine("Kediler Miyavlar");
    }

}

