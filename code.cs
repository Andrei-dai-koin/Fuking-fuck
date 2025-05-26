using System;

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
}

public class User
{
    public string Name { get; set; }
    public Company Company { get; set; }
}

class Program
{
    static void Main()
    {
        User user1 = new User { Name = "Иван Иванов" };
        DisplayUserInfo(user1);

        User user2 = new User
        {
            Name = "Петр Петров",
            Company = new Company { Name = "ООО Рога и копыта" }
        };
        DisplayUserInfo(user2);

        User user3 = new User
        {
            Name = "Сидор Сидоров",
            Company = new Company
            {
                Name = "АО Программист",
                Address = "ул. Кодовая, 42"
            }
        };
        DisplayUserInfo(user3);
    }

    static void DisplayUserInfo(User user)
    {
        Console.WriteLine($"Пользователь: {user.Name}");

        string companyName = user.Company?.Name ?? "не указана";
        string companyAddress = user.Company?.Address ?? "не указан";

        Console.WriteLine($"Компания: {companyName}");
        Console.WriteLine($"Адрес компании: {companyAddress}");
        Console.WriteLine();
    }
}
