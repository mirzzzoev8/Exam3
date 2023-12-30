namespace Task5;

public class Staff : Person
{
    string School;
    double Pay;
    public Staff(string name, string address, string school, double pay) : base(name, address){}

    public string GetSchool(){
        return School;
    }
     public void SetSchool(string school){
        this.School = school;
    }
     public double GetPay(){
        return Pay;
    }
     public void SetSchool(double pay){
        this.Pay = pay;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {School} {Pay}";
    }


}
