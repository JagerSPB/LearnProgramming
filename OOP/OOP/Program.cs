using System.Dynamic;

class Program
{
    static void Main()
    {
        Client clientID1 = new Client("Semen", "Vaysman");

        //clientID1.id = clientID1.NewId(Client.Id);
        Console.WriteLine(
            $"Имя: {clientID1.Name} Фамилия: {clientID1.secondName} Id: {clientID1.id}");
        Client clientID2 = new Client("Ali", "Baba");
        // clientID2.id = clientID2.NewId(Client.Id);
        Console.WriteLine($"Имя: {clientID2.Name} Фамилия: {clientID2.secondName} Id: {clientID2.id}");
        clientID1.ChangeClientsData();
        
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
    public Client() //public Client() : this("1", "1") Вариант написания параметров конструктора
    {
        NewId(Id);
    }

    public Client(string name, string secondName)
    {
        Name = name;
        this.secondName = secondName;
        NewId(Id);
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
        Name = name;
        this.secondName = secondName;
        this.phoneNumber = phoneNumber;
        this.dateOfBirth = dateOfBirth;
    }


    private static int Id { get; set; } = 10;

    public int NewId(int id)
    {
        Console.WriteLine($"Клиент {++Id} создан");
        return Id;
    }

    public int id;
    private string name;
    public string Name { get; private set; }
    public string secondName;
    public bool isActive;
    public int cardNumber;
    public int phoneNumber;
    public int dateOfBirth;

    public void ChangeClientsData()
    {
        Console.Write("Enter new client's name: ");
        Name = Console.ReadLine();
        Console.Write("Enter new client's Second name: ");
        secondName = Console.ReadLine();
        Console.Write("Enter new client's phone number: ");
        phoneNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(
            $"Новое имя: {Name} Новая фамилия: {secondName} новый телефон: {phoneNumber}");
    }
}