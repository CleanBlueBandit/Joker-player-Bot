using Joker_player_v2;
using System.Linq;


#region Initialisation
string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
string[] names = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

List<Card> deck = new List<Card>
{
    // Hearts
    new Card { Name = "6", Suit = "Hearts", Index = 1 },
    new Card { Name = "7", Suit = "Hearts", Index = 2 },
    new Card { Name = "8", Suit = "Hearts", Index = 3 },
    new Card { Name = "9", Suit = "Hearts", Index = 4 },
    new Card { Name = "10", Suit = "Hearts", Index = 5 },
    new Card { Name = "Jack", Suit = "Hearts", Index = 6 },
    new Card { Name = "Queen", Suit = "Hearts", Index = 7 },
    new Card { Name = "King", Suit = "Hearts", Index = 8 },
    new Card { Name = "Ace", Suit = "Hearts", Index = 9 },

    // Diamonds
    new Card { Name = "6", Suit = "Diamonds", Index = 1 },
    new Card { Name = "7", Suit = "Diamonds", Index = 2 },
    new Card { Name = "8", Suit = "Diamonds", Index = 3 },
    new Card { Name = "9", Suit = "Diamonds", Index = 4 },
    new Card { Name = "10", Suit = "Diamonds", Index = 5 },
    new Card { Name = "Jack", Suit = "Diamonds", Index = 6 },
    new Card { Name = "Queen", Suit = "Diamonds", Index = 7 },
    new Card { Name = "King", Suit = "Diamonds", Index = 8 },
    new Card { Name = "Ace", Suit = "Diamonds", Index = 9 },

    // Clubs
    new Card { Name = "7", Suit = "Clubs", Index = 2 },
    new Card { Name = "8", Suit = "Clubs", Index = 3 },
    new Card { Name = "9", Suit = "Clubs", Index = 4 },
    new Card { Name = "10", Suit = "Clubs", Index = 5 },
    new Card { Name = "Jack", Suit = "Clubs", Index = 6 },
    new Card { Name = "Queen", Suit = "Clubs", Index = 7 },
    new Card { Name = "King", Suit = "Clubs", Index = 8 },
    new Card { Name = "Ace", Suit = "Clubs", Index = 9 },

    // Spades
    new Card { Name = "7", Suit = "Spades", Index = 2 },
    new Card { Name = "8", Suit = "Spades", Index = 3 },
    new Card { Name = "9", Suit = "Spades", Index = 4 },
    new Card { Name = "10", Suit = "Spades", Index = 5 },
    new Card { Name = "Jack", Suit = "Spades", Index = 6 },
    new Card { Name = "Queen", Suit = "Spades", Index = 7 },
    new Card { Name = "King", Suit = "Spades" , Index = 8},
    new Card { Name = "Ace", Suit = "Spades", Index = 9 },

    // Jokers
    new Card { Name = "Joker", Suit = "Red", Index = 10 },
    new Card { Name = "Joker", Suit = "Black", Index = 10 }
};

#endregion


#region Core_Functions

bool validate(Card card)
{
    return deck.Any(c => c.Name == card.Name && c.Suit == card.Suit);
}

List<Card> getHand(int amount)
{
    // Initialise
    var final = new List<Card>();
    for (int i = 0; i < amount; i++)
    {
        // Get the Card
        Console.Write($"Card number {i + 1} -----\nName: ");
        string inputName = Console.ReadLine();
        Console.Write("Suit: ");
        string inputSuit = Console.ReadLine();

        // Find (validate)
        Card validCard = deck.FirstOrDefault(c => c.Name == inputName && c.Suit == inputSuit);

        // Add
        if (validCard != null)
        {
            final.Add(validCard);
        }
        else
        {
            Console.WriteLine("No such card exists in this deck. Try again.");
            i--;
        }
    }
    return final;
}

Card? compare(Card c1, Card c2, string Trump)
{
    // Jokers
    if (c1.Name == "Joker" && c2.Name == "Joker") return null;
    if (c1.Name == "Joker") return c1;
    if (c2.Name == "Joker") return c2;

    // Same suit
    if (c1.Suit == c2.Suit)
    {
        if (c1.Index == c2.Index) return null;
        return c1.Index > c2.Index ? c1 : c2;
    }

    // Trumps
    if (c1.Suit == Trump) return c1;
    if (c2.Suit == Trump) return c2;

    // No trumps
    if (c1.Index == c2.Index) return null;
    return c1.Index > c2.Index ? c1 : c2;
}

int placeBet(List<Card> hand)
{
    for(int i = 0; i < hand.Count(); i++)
    {

    }
}

#endregion


