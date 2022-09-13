public class Player
{

    private string name = "";

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            Console.WriteLine("Yay");

            if (name != "" && name.All(char.IsLetter))
            {
                name = value;
            } else
            {
                Console.WriteLine("You can only use letters!");
            }
        }
    }

    Vector2 position { get; set; }

    public int hp = 500;
    public int damage = 35;
}
