class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName() {
        return FirstName + ' ' + LastName; 
    }
}

class Program
{
    private int a;
    public int Sr { // Власність
        get { return a; }
        set { a = value; }
    }
    public void p() {
        System.Console.WriteLine("Hi");
    }
    public int suma(int a, int b) {
        int res = a + b;
        return res;
    }

        static void Main() {
        
        Program p = new Program();
        p.Sr = 100000;
        int res = p.suma(10, 11);
        p.p();
        
        int aa = 10;
        string ss = "ss";

        Student NUM_1 = new Student();
        NUM_1.FirstName = "Name";
        NUM_1.LastName = "Surname";
        string str = NUM_1.FullName();
        //str = " ";
        //str = NUM_1.LastName;


        System.Console.WriteLine(p.Sr);
        System.Console.WriteLine(res);

        System.Console.WriteLine(str);

    }
}
