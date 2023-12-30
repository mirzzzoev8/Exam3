namespace Task6;

public class BigDog : Dog
{
  public BigDog(string Name) :base(Name){}
    public override void Greets()
    {
        base.Greets();
    }
     public void Greets(Dog another){
       System.Console.WriteLine("Woooooof");
    }

      public void Greets(BigDog another){
       System.Console.WriteLine("Woooooooooooof");
    }

    

}
