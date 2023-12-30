namespace Task5;

public class Student : Person
{
    string Program;
    int Year;
    double Fee;

    public Student(string program, int year, double fee, string name, string address) : base(name, address){}
    public string GetProgram(){
        return Program;
    }
    public void SetProgram(string program){
        this.Program = program;
    }
    public int GetYear(){
        return Year;
    }
    public void SetProgram(int year){
        this.Year = year;
    }
    public double GetFee(){
        return Fee;
    }
    public void SetFee(double fee){
        this.Fee = fee;
    }
    public override string ToString()
    {
        return $"{base.ToString()} {Program} {Year} {Fee}";
    }

}
