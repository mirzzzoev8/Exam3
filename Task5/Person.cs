namespace Task5;

public class Person
{
    string Name;
    string Address;
    public Person(string name, string address)
    {
        this.Name = name;
        this.Address = address;
        
    }
    public string GetName(){
        return Name;
    }
    public string GetAddress(){
        return Address;
    }
     public void SetAddress(string address){
        this.Address = address;
    }
    public override string ToString()
    {
        return $"Person [{Name} {Address} ]";
    }



}
