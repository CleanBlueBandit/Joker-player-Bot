# Joker Player v2

A C# console application that assists (or plays it itself) with the card game **Joker** by modelling the deck, validating hands, comparing cards, and (eventually) helping calculate the optimal bet.

> **Project Status:** Work in Progress

---

## Features

Current functionality includes:

* Complete in-memory representation of a Joker deck
* Card validation against the deck
* Manual hand input
* Card comparison logic

  * Supports trump suits
  * Handles Joker cards correctly
  * Compares equal and non-equal card values
* Simple, modular code structure for expanding the game's logic

## Planned Features

* Bet recommendation based on your hand
* Win probability calculations
* Opponent hand estimation
* Smarter game strategy
And the best of them all - Autonomous gameplay

## How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio (or any C# IDE).
3. Build and run the project.

The application currently asks you to manually enter the cards in your hand.

Example:

```text
Card number 1 -----
Name: Ace
Suit: Hearts
```

Repeat until your hand has been entered.

## How It Works

Each card stores:

* Name
* Suit
* Numeric rank (`Index`)

The comparison logic determines the winning card by:

1. Checking for Jokers.
2. Comparing cards of the same suit.
3. Applying the selected trump suit.
4. Falling back to card rank when no trump is involved.

## Project Goals

The long-term goal is to create a tool that can assist players during a game of Joker by suggesting the statistically strongest bet and eventually providing strategic recommendations based on the current state of the game.

## Current Limitations

* Betting logic has not been implemented.
* No graphical interface.
* Requires manual card input.
* No complete game simulation yet.

## License

Feel free to use, modify, or learn from this project.
