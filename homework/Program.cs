using homework.Models;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ააწყვეთ თამაშის ლოგიკა სადაც გვეყოლება ორი ტიპის პერსონაჟი გმირი (Hero) და ბოროტმოქმედი (Villan).
            // პერსონაჟებს უნდა შეეძლოთ ერთანეთთან ბრძოლა და ბრძოლის შედეგად მოწინააღმდეგის სიცოცხლის მაჩვენებლის შემცირება.
            // თითოეულ პერსონაჟს უნდა ჰქონდეს განსხვავებული ძალა სახელად  LightAbility ან DarkAbility გამომდინარე იქიდან ეს პერსონაჟი გმირია თუ ბოროტმოქმედი (ძალა გამოსახეთ int ებში, გმირებს უნდა ჰქონდეთ ნათელი ძალა (LightAbility) ხოლო ბოროტმოქმედებს ბნელი ძალა (DarkAbility)) რამდენიც არის პერსონაჟის ძალა იმდენით უნდა მცირდებოდეს მოწინააღმდეგის სიცოცხლის მაჩვენებელი შეტევის შემთხვევაში.

            //მახასიათებლები რომლებიც პერსონაჟებს უნდა ჰქონდეთ:
            //სახელი - Name
            //ფული - Money
            //სიცოცხლე - Health
            //ძალა (LightAbility დადებითი პერსონაჟის შემთხვევაში, DarkAbility უარყოფითი პერსონაჟის შემთხვევაში)

            //ყველა პერსონაჟს უნდა შეეძლოს სხვა პერსონაჟზე შეტევის მიტანა
            //მხოლოდ გმირებს უნდა შეეძლოთ სხვა გმირების განკურნება საკუთარი სიცოცხლის ფასად მაგალითად თუ მოუმატებს სიცოცხლის მაჩვენებელს 20 - ით, თავისი სიცოცხლის მაჩვენებელი უნდა შემცირდეს იმდენითვე ანუ 20-ით.

            //P.S. დავალების შესრულებისას აუცილებლად გამოიყენეთ მემკვიდრეობა.


            Hero hero = new()
            {
                Name = "hero1",
                Health = 100,
                Money = 1000,
                Power = PowerType.LightAbility
            };

            Villan villan = new()
            {
                Name = "villan1",
                Health = 100,
                Money = 1000,
                Power = PowerType.DarkAbility
            };

            hero.Opponent = villan;
            villan.Opponent = hero;


            hero.Attack(hero.Opponent);
            villan.Attack(villan.Opponent);
            villan.Attack(villan.Opponent);

            Console.WriteLine(hero.AboutMe());
            Console.WriteLine(villan.AboutMe());


            hero.Heal(villan, 5);
            Console.WriteLine(hero.AboutMe());
            Console.WriteLine(villan.AboutMe());
        }
    }
}
