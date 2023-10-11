using System;

class Delivery
{
    //Описание посылки
    private string DiscriptionOrder { get; set; }
    //Вес посылки
    public int WeightOrder { get; private set; }

    public Delivery(string discriptionOrder, int weightOrder)
    {
        DiscriptionOrder = discriptionOrder;
        WeightOrder = weightOrder;
    }
    public string order()
    {
        return DiscriptionOrder;
    }
}

class DeliveryService
{
    //Лимит веса посылок
    private int limitWeight = 5;
    
    public void sendOrders(Delivery delivery)
    {
        if (limitWeight >= delivery.WeightOrder)
        {
            //Если вес не превышает норму вычесть вес посылки из нормы
            limitWeight -= delivery.WeightOrder;
            Console.WriteLine($"'{delivery.order()}': отправка удалась");
        }
        else
        {
            Console.WriteLine($"'{delivery.order()}': отправка не удалась,  превышена норма веса на {delivery.WeightOrder - limitWeight} кг.");
        }
    }
}

static class postOffice
{
    static public void startLine()
    {
        Console.WriteLine("----------------------------------------------------");     
    }
    static public void HelloString()
    {
        Console.WriteLine("Приветствуем вас на нашей почте");
    }
}
class Program
{
    static void Main()
    {
        postOffice.startLine();
        postOffice.HelloString();
        postOffice.startLine();

        Delivery lamp = new Delivery("Лампа", 1);
        Delivery table = new Delivery("Стол", 10);

        DeliveryService delivery = new DeliveryService();
        delivery.sendOrders(lamp);
        delivery.sendOrders(table);
    }
}