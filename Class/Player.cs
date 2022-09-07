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
            }
        }
    }

    Vector2 position { get; set; }

    public int hp = 500;
    public int damage = 35;
}
