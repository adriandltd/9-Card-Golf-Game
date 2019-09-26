using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_6;

namespace Golf_Game
{

    public class Card
    {
        public Card(int v, char s)
        {
            Card_Value = v;
            Card_Suit = s;
            FaceUp = false;
        }

        public int Card_Value { get; set; }

        public char Card_Suit { get; set; }

        public bool FaceUp;

    }


    public class Deck
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 13;
        private const int NUMBER_OF_CARDS = 54;


        static List<char> SUITS = new List<char>() { 'S', 'H', 'D', 'C' };



        //hold cards
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            cards.Add(new Card(0, 'J'));    //Creates two Joker cards
            cards.Add(new Card(0, 'J'));

            foreach (char suit in SUITS)
            {

                for (int i = MAX_VALUE; i > MIN_VALUE; i--)
                {
                    cards.Add(new Card(i, suit));
                }
            }
        }

        public bool Test_Deck()
        {
            Deck test = new Deck();
            Deck test_unshuffled = new Deck();
            Deck test_shuffled = new Deck();

            test_unshuffled = test;
            test.Shuffle();
            test_shuffled = test;

            if (test_unshuffled != test_shuffled)
                return false;

            return true;

        }

        public void Shuffle()
        {
            var rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).ToList();
        }

        public Card Peek(int position)
        {
            return cards.ElementAt(position - 1);
        }

        public Card Draw()
        {
            Card card_drawn = cards.ElementAt(0);
            cards.Remove(cards.ElementAt(0));
            return card_drawn;
        }

        public void Add(Card new_card)
        {
            cards.Insert(0, new_card);
        }

        public int count()
        {
            return Convert.ToInt32(cards.Count());
        }

        public bool IsEmpty()
        {
            if (cards.Count == 0)
                return true;
            return false;
        }
    }


    public class Hand
    {
        public Card[,] hand_array;

        public Hand()
        {
            hand_array = new Card[3, 3];        //creates a 2d array to hold the 9 cards for each hand
        }

        public void Add(Card card)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (hand_array[i, j] == null)
                    {
                        hand_array[i, j] = card;
                        return;
                    }
                }
            }
        }


        public Card Peek(int position)
        {
            if (position == 1)
                return hand_array[0, 0];
            else if (position == 2)
                return hand_array[0, 1];
            else if (position == 3)
                return hand_array[0, 2];
            else if (position == 4)
                return hand_array[1, 0];
            else if (position == 5)
                return hand_array[1, 1];
            else if (position == 6)
                return hand_array[1, 2];
            else if (position == 7)
                return hand_array[2, 0];
            else if (position == 8)
                return hand_array[2, 1];
            else if (position == 9)
                return hand_array[2, 2];
            else
                return null;
        }

        public void TurnUp(Card card)
        {
            card.FaceUp = true;
        }

        public bool IsFaceUp(Card card)
        {
            if (card.FaceUp == true)
                return true;
            return false;
        }

        public void Replace(Card new_card, Card old_card)
        {
            new_card.FaceUp = true;
            Card tmp;
            tmp = new_card;
            new_card = old_card;
            old_card = tmp;
        }

        public bool IsDone(Hand hand)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (hand.hand_array[i, j].FaceUp == true)
                        count++;
                }
            }
            if (count >= 9)
                return true;
            return false;
        }

        public int Score()
        {
            int total_value = 0;

            for (int i = 0; i <= 2; i++)
            {
                if ((hand_array[i, 0].Card_Value == hand_array[i, 1].Card_Value) && ((hand_array[i, 0].Card_Value == hand_array[i, 2].Card_Value)))             //checks the rows
                {
                    hand_array[i, 0].Card_Value = -1;
                    hand_array[i, 1].Card_Value = -1;
                    hand_array[i, 2].Card_Value = -1;
                }
            }

            for (int j = 0; j <= 2; j++)
            {
                if ((hand_array[0, j].Card_Value == hand_array[1, j].Card_Value) && ((hand_array[0, j].Card_Value == hand_array[2, j].Card_Value)))             //checks the columns
                {
                    hand_array[0, j].Card_Value = -1;
                    hand_array[1, j].Card_Value = -1;
                    hand_array[2, j].Card_Value = -1;
                }
            }

            if ((hand_array[0, 0].Card_Value == hand_array[1, 1].Card_Value) && ((hand_array[0, 0].Card_Value == hand_array[2, 2].Card_Value)))                 //checks diagnol to the right
            {
                hand_array[0, 0].Card_Value = -1;
                hand_array[1, 1].Card_Value = -1;
                hand_array[2, 2].Card_Value = -1;
            }

            if ((hand_array[0, 2].Card_Value == hand_array[1, 1].Card_Value) && ((hand_array[0, 2].Card_Value == hand_array[2, 0].Card_Value)))                 //checks diagnol to the left
            {
                hand_array[0, 2].Card_Value = -1;
                hand_array[1, 1].Card_Value = -1;
                hand_array[2, 0].Card_Value = -1;
            }

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if ((hand_array[i, j].FaceUp == true) && (hand_array[i, j] != null))
                    {
                        if ((hand_array[i, j].Card_Value >= 1) && (hand_array[i, j].Card_Value <= 10))                //checks for ace's and #'s 2-10
                            total_value += hand_array[i, j].Card_Value;
                        else if ((hand_array[i, j].Card_Value == 11) || (hand_array[i, j].Card_Value == 12))        //checks for Jacks and Queens
                            total_value += 10;
                        else if ((hand_array[i, j].Card_Value == 13) || (hand_array[i, j].Card_Value == -1))        //checks for kings or 3 in a row
                            total_value += 0;
                        else if (hand_array[i, j].Card_Value == 0)                                                  //checks for jokers
                            total_value = total_value - 2;
                    }
                }
            }

            return total_value;
        }

        public void FlipAllCardsUp(Hand hand)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    hand_array[i, j].FaceUp = true;
                }
            }

        }

        public void RemoveCard(Card card)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (hand_array[i, j] == card)
                        hand_array[i, j] = null;
                }
            }
        }

    }

    public class Player
    {
        public void TakeTurn(Hand hand, Deck deck, Card discard, Card replace)
        {
            if (ChooseDrawDiscard == true)
                hand.Replace(discard, replace);
            if (ChooseDrawDiscard == false)
                hand.Replace(deck.Draw(), replace);
        }

        public string Name;

        public bool ChooseDrawDiscard;
        public Card replace;

    }

    public class Game
    {
        Deck deck = new Deck();
        public Player player1 = new Player();
        public Player player2 = new Player();
        Hand hand1 = new Hand();
        Hand hand2 = new Hand();
        Card discard;
        public bool turn_player1 = true;
        public bool turn_player2= false;
        StartScreen start;

        public Game()
        {
            deck.Shuffle();
            discard = deck.Draw();         //creates a discard pile
            for (int i = 0; i < 9; i++)
                hand1.Add(deck.Draw());         //Fills up hand 1
            
            for (int i = 0; i < 9; i++)
                hand2.Add(deck.Draw());         //Fills up hand 2

        }

        public void Play()
        {
            while ((start.GameInterface.game.hand1.IsDone(hand1) == false) || (start.GameInterface.game.hand2.IsDone(hand2) == false))
            {
                if (deck.count() == 0)
                {
                    Deck deck2 = new Deck();
                    deck2.Shuffle();
                    deck = deck2;
                }

                if (turn_player1 == true)
                {
                    player1.TakeTurn(hand1, deck, discard, player1.replace);
                    turn_player1 = false;
                    turn_player2 = true;
                }

                else if (turn_player2 == true)
                {
                    player2.TakeTurn(hand1, deck, discard, player2.replace);
                    turn_player1 = true;
                    turn_player2 = false;
                }

                start.GameInterface.Refresh();
            }
        }

        public Card Info(string player_position)
        {
            int position = 0;

            if (player_position[0] == 'A')
            {
                if (player_position[1] == '1' && player_position[2] == '1')
                    position = 1;
                else if (player_position[1] == '1' && player_position[2] == '2')
                    position = 2;
                else if (player_position[1] == '1' && player_position[2] == '3')
                    position = 3;
                else if (player_position[1] == '2' && player_position[2] == '1')
                    position = 4;
                else if (player_position[1] == '2' && player_position[2] == '2')
                    position = 5;
                else if (player_position[1] == '2' && player_position[2] == '3')
                    position = 6;
                else if (player_position[1] == '3' && player_position[2] == '1')
                    position = 7;
                else if (player_position[1] == '3' && player_position[2] == '2')
                    position = 8;
                else if (player_position[1] == '3' && player_position[2] == '3')
                    position = 9;

                return hand1.Peek(position);
            }

            if (player_position[0] == 'B')
            {
                if (player_position[1] == '1' && player_position[2] == '1')
                    position = 1;
                else if (player_position[1] == '1' && player_position[2] == '2')
                    position = 2;
                else if (player_position[1] == '1' && player_position[2] == '3')
                    position = 3;
                else if (player_position[1] == '2' && player_position[2] == '1')
                    position = 4;
                else if (player_position[1] == '2' && player_position[2] == '2')
                    position = 5;
                else if (player_position[1] == '2' && player_position[2] == '3')
                    position = 6;
                else if (player_position[1] == '3' && player_position[2] == '1')
                    position = 7;
                else if (player_position[1] == '3' && player_position[2] == '2')
                    position = 8;
                else if (player_position[1] == '3' && player_position[2] == '3')
                    position = 9;

                return hand2.Peek(position);
            }


            if (player_position == "Deck")
            {
                deck.Peek(1).FaceUp = true;
                return deck.Peek(1);
            }

            if (player_position == "Discard")
            {
                discard.FaceUp = true;
                return discard;
            }

            return null;
        }
    }
}

