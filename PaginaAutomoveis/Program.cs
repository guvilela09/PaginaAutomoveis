using System;
using System.Collections.Generic;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<Car> cars = new List<Car>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Página de Automóveis");
            Console.WriteLine("1. Listar carros");
            Console.WriteLine("2. Adicionar um carro");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListCars();
                    break;
                case "2":
                    AddCar();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ListCars()
    {
        Console.WriteLine("Lista de Carros:");
        if (cars.Count == 0)
        {
            Console.WriteLine("Nenhum carro na lista.");
        }
        else
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Marca: {car.Make}, Modelo: {car.Model}, Ano: {car.Year}, Preço: {car.Price:C}");
            }
        }
    }

    static void AddCar()
    {
        Car car = new Car();
        Console.Write("Marca do carro: ");
        car.Make = Console.ReadLine();
        Console.Write("Modelo do carro: ");
        car.Model = Console.ReadLine();
        Console.Write("Ano do carro: ");
        car.Year = int.Parse(Console.ReadLine());
        Console.Write("Preço do carro: ");
        car.Price = double.Parse(Console.ReadLine());

        cars.Add(car);
        Console.WriteLine("Carro adicionado com sucesso.");
    }
}

