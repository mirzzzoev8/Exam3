namespace Task6;

public class Dog : Animal
{
    public Dog(string name) :base(name){}
    public override void Greets()
    {
        base.Greets();
        {
            System.Console.WriteLine("Woof");
        }
    }
    public  void Greets(Dog another){
       System.Console.WriteLine("Woooooof");
    }

}
