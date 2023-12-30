namespace Task6;

public abstract class Animal
{
    string Name;

    public Animal(string name)
    {
        Name = name;
    }

    public  void animal(string name){
      this.Name = name;

    }
     public virtual void Greets(){}



}
