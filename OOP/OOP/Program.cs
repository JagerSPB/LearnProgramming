using System.Dynamic;

class Program
{
    static void Main()
    {
        Client clientID1 = new Client("Semen","Vaysman");
        
        clientID1.id = clientID1.NewId(Client.Id);
       
        Console.WriteLine($"Имя: {clientID1.name} Id: {clientID1.id}");
        Console.WriteLine($"Имя: {clientID1.name} Фамилия: {clientID1.secondName}");
        Client clientID2 = new Client("Ali","Baba");
        clientID2.id = clientID2.NewId(Client.Id);
        Console.WriteLine($"Имя: {clientID2.name} Id: {clientID2.id}");
        void ChangeClient()
        {
            Console.Write("Enter client's name: ");
            clientID1.name = Console.ReadLine();
            Console.Write("Enter client's Second name: ");
            clientID1.secondName = Console.ReadLine();
        }

        ChangeClient();
        Console.WriteLine($"Имя: {clientID1.name} Фамилия: {clientID1.secondName}");
        Console.ReadLine();
    }
}


class Car
{
    public Car()
    {
    }

    public Car(int speed, string color, string model)
    {
        this.speed = speed;
        this.color = color;
        this.model = model;
    }

    public Car(int speed, string color, int age)
    {
        this.speed = speed;
        this.color = color;
        this.age = age;
    }

    public int speed;
    public string color;
    public string model;
    public int age = 7;
    public bool isCrashed;

    public void CurrentSpeed()
    {
        Console.WriteLine($"Текущая скорость: {speed}");
    }

    public void ChangeColor(string col)
    {
        color = col;
    }
}

class Person
{
    public Person()
    {
    }

    public Person(string name, string gender)
    {
        this.name = name;
        this.gender = gender;
    }

    public string name;
    public string gender;
    public int age;
    public bool isImploy = true;
    public bool isMaried;
    public int yearOfBirth;

    public void GetAge()
    {
        Console.WriteLine($"привет мой возраст {age}");
    }
}

class Client
{
    public Client()
    {
    }

    public Client(string name, string secondName)
    {
        this.name = name;
        this.secondName = secondName;
    }

    public Client(string name, string secondName, int phoneNumber)
    {
        this.name = name;
        this.secondName = secondName;
        this.phoneNumber = phoneNumber;
    }

    public Client(bool isActive, int discountValue, string name, string secondName, int phoneNumber,
        int dateOfBirth)
    {
        this.isActive = isActive;
        this.discountValue = discountValue;
        this.name = name;
        this.secondName = secondName;
        this.phoneNumber = phoneNumber;
        this.dateOfBirth = dateOfBirth;
    }

   
    public static int Id { get; set; } = 10;
    public int NewId(int id)
    {
        return ++Id;
    }
    public int id { get; set; }
    public bool isActive;
    public int cardNumber { get; set; }
    public int discountValue { get; set; }
    public string name;
    public string secondName;
    public int phoneNumber;
    public string gender;
    public int dateOfBirth;
}