//Напишите программу используя метод. Если товары стоят больше или ровно 1000 рублей, то мы их
// не покупаем. Стоимость товара задается рандомно. Ответ необходимо представить в виде коронарного выражения

int price = new Random().Next(1, 10000);
Console.WriteLine($"Цена товара: {price}");
// if (price < 1000) 
// Console.WriteLine("Покупаем");
// else Console.WriteLine("Очень дорого");

bool MaxPrice(int price, int maxPrice)
{
    return price < maxPrice;
}
Console.WriteLine(MaxPrice(price, 1000) ? "Покупаем" : "Очень дорого"); // коронарное выражение
