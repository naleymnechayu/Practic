using System;
//Словарь
using System.Collections.Generic;

namespace Program
{
    class Car
    {
        private string ModelCar;
        private double maxSpeed;
        public double raceDistance;

        public Car(string nameCar, double maxSpeed)
        {
            this.ModelCar = nameCar;
            this.maxSpeed = maxSpeed;
        }

        public void ShowModelCar()
        {
            Console.WriteLine($"\nАвтомобиль: {ModelCar}\nСкорость: {maxSpeed} km/h\n\n");
        }

        public double RaceTime()
        {
            return Math.Round((raceDistance / maxSpeed) * 3600);
        }        
    }

    class MainClass
    {
        static void Main()
        {
            Dictionary<string, double> racers = new Dictionary<string, double>();
            double RaceDistance;
            string modelCar;

            Console.Write("Укажите размер трассы в километрах: ");
            RaceDistance = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введите марку автомобиля гонщика: ");
                while (true)
                {
                    modelCar = Console.ReadLine();
                    if (modelCar.Length == 0 || modelCar.Length > 25)
                    {
                        Console.Write("Модель авто не должна превышать 25 символов: ");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Write("Введите скорость автомобиля: ");
                while (true)
                {
                    double maxSpeed = Convert.ToDouble(Console.ReadLine());
                    if (maxSpeed < 1 || maxSpeed > 500)
                    {
                        Console.Write("Введите допустимую скорость: ");
                    }
                    else
                    {
                        Console.WriteLine($"\nГонщик под номером {i + 1}");
                        Car user = new Car(modelCar, maxSpeed);
                        user.raceDistance = RaceDistance;
                        user.ShowModelCar();


                        double raceTime = user.RaceTime();
                        racers[modelCar] = raceTime;


                        break;
                    }
                }
            }
            
                Console.WriteLine("\nГонка закончилсь\n\nРезультаты:\n");
                startRace(racers);

            
            

            static void startRace(Dictionary <string,double> racers)
            {
                int hour, minute, seconds;
                double minTime = double.MaxValue;
                string winner = "";
                // вывод ключ-значение модели машины и время
                foreach (var racer in racers)
                {
                    if (racer.Value < minTime)
                    {
                        minTime = racer.Value;
                        winner = racer.Key;
                       
                    }
                    hour = Convert.ToInt32(racer.Value / 3600);
                    minute = Convert.ToInt32((racer.Value % 3600) / 60);
                    seconds = Convert.ToInt32(racer.Value % 60);
                    Console.WriteLine($"Модель машины: {racer.Key}, Время: {hour} часов, {minute} минут, {seconds} секунд");
                }
                hour = Convert.ToInt32(minTime / 3600);
                minute = Convert.ToInt32((minTime % 3600) / 60);
                seconds = Convert.ToInt32(minTime % 60);
                Console.WriteLine($"\n\nПобедителем оказался гонщик на автомобиле: '{winner}'. Он проехал трассу за: {hour} часов, {minute} минут, {seconds} секунд\n\n");
            }
        }
    }
}


