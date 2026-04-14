using Joker_player_v2;


#region Initialisation
string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
string[] names = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

List<Card> deck = new List<Card>
{
    // Hearts
    new Card { Name = "6", Suit = "Hearts" },
    new Card { Name = "7", Suit = "Hearts" },
    new Card { Name = "8", Suit = "Hearts" },
    new Card { Name = "9", Suit = "Hearts" },
    new Card { Name = "10", Suit = "Hearts" },
    new Card { Name = "Jack", Suit = "Hearts" },
    new Card { Name = "Queen", Suit = "Hearts" },
    new Card { Name = "King", Suit = "Hearts" },
    new Card { Name = "Ace", Suit = "Hearts" },

    // Diamonds
    new Card { Name = "6", Suit = "Diamonds" },
    new Card { Name = "7", Suit = "Diamonds" },
    new Card { Name = "8", Suit = "Diamonds" },
    new Card { Name = "9", Suit = "Diamonds" },
    new Card { Name = "10", Suit = "Diamonds" },
    new Card { Name = "Jack", Suit = "Diamonds" },
    new Card { Name = "Queen", Suit = "Diamonds" },
    new Card { Name = "King", Suit = "Diamonds" },
    new Card { Name = "Ace", Suit = "Diamonds" },

    // Clubs
    new Card { Name = "7", Suit = "Clubs" },
    new Card { Name = "8", Suit = "Clubs" },
    new Card { Name = "9", Suit = "Clubs" },
    new Card { Name = "10", Suit = "Clubs" },
    new Card { Name = "Jack", Suit = "Clubs" },
    new Card { Name = "Queen", Suit = "Clubs" },
    new Card { Name = "King", Suit = "Clubs" },
    new Card { Name = "Ace", Suit = "Clubs" },

    // Spades
    new Card { Name = "7", Suit = "Spades" },
    new Card { Name = "8", Suit = "Spades" },
    new Card { Name = "9", Suit = "Spades" },
    new Card { Name = "10", Suit = "Spades" },
    new Card { Name = "Jack", Suit = "Spades" },
    new Card { Name = "Queen", Suit = "Spades" },
    new Card { Name = "King", Suit = "Spades" },
    new Card { Name = "Ace", Suit = "Spades" },

    // Jokers
    new Card { Name = "Joker", Suit = "Red" },
    new Card { Name = "Joker", Suit = "Black" }
};

#endregion


#region Core_Functions

bool validate(Card card)
{
    foreach(var c in deck)
    {
        if (c.Name == card.Name) goto suit;
    }
    return false;
suit: foreach(var c in deck)
    {
        if (c.Suit == card.Suit) return true;
    }
    return false;
}

List<Card> getHand(int amount)
{
    var final = new List<Card>();
    for(int i = 0; i < amount; i++)
    {
        var c = new Card();
        Console.Write($"Card number {i+1} -----\nName: ");
        c.Name = Console.ReadLine();
        Console.Write("Suit: ");
        c.Suit = Console.ReadLine();
        if (validate(c)) final.Add(c);
        else throw new Exception(message: "No such card exists");
    }
    return final;
}

#endregion


foreach(var c in getHand(3))
{
    Console.WriteLine(c.write());
}