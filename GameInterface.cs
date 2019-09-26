using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Golf_Game;

namespace Assignment_6
{

    public partial class GameInterface : Form
    {
        public Game game = new Game();
        int P1flipcount = 0;
        int P2flipcount = 0;

        public GameInterface()
        {
            InitializeComponent();
            hand_ini();         //shows all of cards back side
            label1.Text = game.player1.Name;
            label2.Text = game.player2.Name;

            
            if (P1flipcount >= 3 && P2flipcount >= 3)
            {
                if (game.turn_player1 == true)
                    label1.BackColor = Color.Yellow;
                else
                    label1.BackColor = SystemColors.Control;

                if (game.turn_player2 == true)
                    label2.BackColor = Color.Yellow;
                else
                    label2.BackColor = SystemColors.Control;
            }



        }

        public void Convert_to_image(Card card, Label label)
        {
            string filename = "joker";

            if (card == null)
                return;
            if (card.Card_Value == 0)
                filename = "joker";
            if (card.Card_Value == 1)
                filename = "Ace";
            if (card.Card_Value == 2)
                filename = "Two";
            if (card.Card_Value == 3)
                filename = "Three";
            if (card.Card_Value == 4)
                filename = "Four";
            if (card.Card_Value == 5)
                filename = "Five";
            if (card.Card_Value == 6)
                filename = "Six";
            if (card.Card_Value == 7)
                filename = "Seven";
            if (card.Card_Value == 8)
                filename = "Eight";
            if (card.Card_Value == 9)
                filename = "Nine";
            if (card.Card_Value == 10)
                filename = "Ten";
            if (card.Card_Value == 11)
                filename = "Jack";
            if (card.Card_Value == 12)
                filename = "Queen";
            if (card.Card_Value == 13)
                filename = "King";

            if (filename != "joker")
            {
                filename = filename + "of";

                if (card.Card_Suit == 'S')
                    filename = filename + "Spades";
                if (card.Card_Suit == 'H')
                    filename = filename + "Hearts";
                if (card.Card_Suit == 'D')
                    filename = filename + "Diamonds";
                if (card.Card_Suit == 'C')
                    filename = filename + "Clubs";
            }

            filename = filename + ".png";


            //tried doing this way but forgot it would only work in my computer.
            //label.Image = Image.FromFile("c:/users/adrian/documents/visual studio 2015/Projects/lab06/CardImages/" + filename);

            
            
            //Joker
            if (filename == "joker.png")
                label.Image = Properties.Resources.joker;
            //Aces
            if (filename == "AceofSpades.png")
                label.Image = Properties.Resources.AceofSpades;
            if (filename == "AceofHearts.png")
                label.Image = Properties.Resources.AceofHearts;
            if (filename == "AceofDiamonds.png")
                label.Image = Properties.Resources.AceofDiamonds;
            if (filename == "AceofClubs.png")
                label.Image = Properties.Resources.AceofClubs;
            //Two's
            if (filename == "TwoofSpades.png")
                label.Image = Properties.Resources.TwoofSpades;
            if (filename == "TwoofHearts.png")
                label.Image = Properties.Resources.TwoofHearts;
            if (filename == "TwoofDiamonds.png")
                label.Image = Properties.Resources.TwoofDiamonds;
            if (filename == "TwoofClubs.png")
                label.Image = Properties.Resources.TwoofClubs;
            //Three's
            if (filename == "ThreeofSpades.png")
                label.Image = Properties.Resources.ThreeofSpades;
            if (filename == "ThreeofHearts.png")
                label.Image = Properties.Resources.ThreeofHearts;
            if (filename == "ThreeofDiamonds.png")
                label.Image = Properties.Resources.ThreeofDiamonds;
            if (filename == "ThreeofClubs.png")
                label.Image = Properties.Resources.ThreeofClubs;
            //Fours
            if (filename == "FourofSpades.png")
                label.Image = Properties.Resources.FourofSpades;
            if (filename == "FourofHearts.png")
                label.Image = Properties.Resources.FourofHearts;
            if (filename == "FourofDiamonds.png")
                label.Image = Properties.Resources.FourofDiamonds;
            if (filename == "FourofClubs.png")
                label.Image = Properties.Resources.FourofClubs;
            //Fives
            if (filename == "FiveofSpades.png")
                label.Image = Properties.Resources.FiveofSpades;
            if (filename == "FiveofHearts.png")
                label.Image = Properties.Resources.FiveofHearts;
            if (filename == "FiveofDiamonds.png")
                label.Image = Properties.Resources.FiveofDiamonds;
            if (filename == "FiveofClubs.png")
                label.Image = Properties.Resources.FiveofClubs;
            //Sixs
            if (filename == "SixofSpades.png")
                label.Image = Properties.Resources.SixofSpades;
            if (filename == "SixofHearts.png")
                label.Image = Properties.Resources.SixofHearts;
            if (filename == "SixofDiamonds.png")
                label.Image = Properties.Resources.SixofDiamonds;
            if (filename == "SixofClubs.png")
                label.Image = Properties.Resources.SixofClubs;
            //Sevens
            if (filename == "SevenofSpades.png")
                label.Image = Properties.Resources.SevenofSpades;
            if (filename == "SevenofHearts.png")
                label.Image = Properties.Resources.SevenofHearts;
            if (filename == "SevenofDiamonds.png")
                label.Image = Properties.Resources.SevenofDiamonds;
            if (filename == "SevenofClubs.png")
                label.Image = Properties.Resources.SevenofClubs;
            //Eights
            if (filename == "EightofSpades.png")
                label.Image = Properties.Resources.EightofSpades;
            if (filename == "EightofHearts.png")
                label.Image = Properties.Resources.EightofHearts;
            if (filename == "EightofDiamonds.png")
                label.Image = Properties.Resources.EightofDiamonds;
            if (filename == "EightofClubs.png")
                label.Image = Properties.Resources.EightofClubs;
            //Nines
            if (filename == "NineofSpades.png")
                label.Image = Properties.Resources.NineofSpades;
            if (filename == "NineofHearts.png")
                label.Image = Properties.Resources.NineofHearts;
            if (filename == "NineofDiamonds.png")
                label.Image = Properties.Resources.NineofDiamonds;
            if (filename == "NineofClubs.png")
                label.Image = Properties.Resources.NineofClubs;
            //Tens
            if (filename == "TenofSpades.png")
                label.Image = Properties.Resources.TenofSpades;
            if (filename == "TenofHearts.png")
                label.Image = Properties.Resources.TenofHearts;
            if (filename == "TenofDiamonds.png")
                label.Image = Properties.Resources.TenofDiamonds;
            if (filename == "TenofClubs.png")
                label.Image = Properties.Resources.TenofClubs;
            //Jacks
            if (filename == "JackofSpades.png")
                label.Image = Properties.Resources.JackofSpades;
            if (filename == "JackofHearts.png")
                label.Image = Properties.Resources.JackofHearts;
            if (filename == "JackofDiamonds.png")
                label.Image = Properties.Resources.JackofDiamonds;
            if (filename == "JackofClubs.png")
                label.Image = Properties.Resources.JackofClubs;
            //Queens
            if (filename == "QueenofSpades.png")
                label.Image = Properties.Resources.QueenofSpades;
            if (filename == "QueenofHearts.png")
                label.Image = Properties.Resources.QueenofHearts;
            if (filename == "QueenofDiamonds.png")
                label.Image = Properties.Resources.QueenofDiamonds;
            if (filename == "QueenofClubs.png")
                label.Image = Properties.Resources.QueenofClubs;
            //Kings
            if (filename == "KingofSpades.png")
                label.Image = Properties.Resources.KingofSpades;
            if (filename == "KingofHearts.png")
                label.Image = Properties.Resources.KingofHearts;
            if (filename == "KingofDiamonds.png")
                label.Image = Properties.Resources.KingofDiamonds;
            if (filename == "KingofClubs.png")
                label.Image = Properties.Resources.KingofClubs;
            //Face Down
            if (card.FaceUp == false)
                label.Image = Properties.Resources.cardback;

        }

        public void hand_ini()
        {
            Convert_to_image(game.Info(Convert.ToString(CardA11.Tag)), CardA11);
            Convert_to_image(game.Info(Convert.ToString(CardA12.Tag)), CardA12);
            Convert_to_image(game.Info(Convert.ToString(CardA13.Tag)), CardA13);
            Convert_to_image(game.Info(Convert.ToString(CardA21.Tag)), CardA21);
            Convert_to_image(game.Info(Convert.ToString(CardA22.Tag)), CardA22);
            Convert_to_image(game.Info(Convert.ToString(CardA23.Tag)), CardA23);
            Convert_to_image(game.Info(Convert.ToString(CardA31.Tag)), CardA31);
            Convert_to_image(game.Info(Convert.ToString(CardA32.Tag)), CardA32);
            Convert_to_image(game.Info(Convert.ToString(CardA33.Tag)), CardA33);

            Convert_to_image(game.Info(Convert.ToString(CardB11.Tag)), CardB11);
            Convert_to_image(game.Info(Convert.ToString(CardB12.Tag)), CardB12);
            Convert_to_image(game.Info(Convert.ToString(CardB13.Tag)), CardB13);
            Convert_to_image(game.Info(Convert.ToString(CardB21.Tag)), CardB21);
            Convert_to_image(game.Info(Convert.ToString(CardB22.Tag)), CardB22);
            Convert_to_image(game.Info(Convert.ToString(CardB23.Tag)), CardB23);
            Convert_to_image(game.Info(Convert.ToString(CardB31.Tag)), CardB31);
            Convert_to_image(game.Info(Convert.ToString(CardB32.Tag)), CardB32);
            Convert_to_image(game.Info(Convert.ToString(CardB33.Tag)), CardB33);

            Convert_to_image(game.Info(Convert.ToString(Deck.Tag)), Deck);
            Convert_to_image(game.Info(Convert.ToString(Discard.Tag)), Discard);
        }

        private void CardA11_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA11.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA11.Tag)), CardA11);
                P1flipcount++;
            }

            if (P1flipcount >= 3)
            {
                game.player1.replace = game.Info(Convert.ToString(CardA11.Tag));


            }
        }

        private void CardA12_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA12.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA12.Tag)), CardA12);
                P1flipcount++;
            }
        }

        private void CardA13_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA13.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA13.Tag)), CardA13);
                P1flipcount++;
            }
        }

        private void CardA21_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA21.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA21.Tag)), CardA21);
                P1flipcount++;
            }
        }

        private void CardA22_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA22.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA22.Tag)), CardA22);
                P1flipcount++;
            }
        }

        private void CardA23_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA23.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA23.Tag)), CardA23);
                P1flipcount++;
            }
        }

        private void CardA31_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA31.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA31.Tag)), CardA31);
                P1flipcount++;
            }
        }

        private void CardA32_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA32.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA32.Tag)), CardA32);
                P1flipcount++;
            }
        }

        private void CardA33_Click(object sender, EventArgs e)
        {
            if (P1flipcount < 3)
            {
                game.Info(Convert.ToString(CardA33.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardA33.Tag)), CardA33);
                P1flipcount++;
            }
        }

        private void CardB11_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB11.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB11.Tag)), CardB11);
                P2flipcount++;
            }
        }

        private void CardB12_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB12.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB12.Tag)), CardB12);
                P2flipcount++;
            }
        }

        private void CardB13_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB13.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB13.Tag)), CardB13);
                P2flipcount++;
            }
        }

        private void CardB21_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB21.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB21.Tag)), CardB21);
                P2flipcount++;
            }
        }

        private void CardB22_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB22.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB22.Tag)), CardB22);
                P2flipcount++;
            }
        }

        private void CardB23_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB23.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB23.Tag)), CardB23);
                P2flipcount++;
            }
        }

        private void CardB31_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB31.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB31.Tag)), CardB31);
                P2flipcount++;
            }
        }

        private void CardB32_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB32.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB32.Tag)), CardB32);
                P2flipcount++;
            }
        }

        private void CardB33_Click(object sender, EventArgs e)
        {
            if (P2flipcount < 3)
            {
                game.Info(Convert.ToString(CardB33.Tag)).FaceUp = true;
                Convert_to_image(game.Info(Convert.ToString(CardB33.Tag)), CardB33);
                P2flipcount++;
            }
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            Deck.BackColor = SystemColors.Control;
            Discard.BackColor = Color.Yellow;
            
            if (game.turn_player1 == true)
                game.player1.ChooseDrawDiscard = true;
            if (game.turn_player2 == true)
                game.player2.ChooseDrawDiscard = true;

        }

        private void Deck_Click(object sender, EventArgs e)
        {
            Discard.BackColor = SystemColors.Control;
            Deck.BackColor = Color.Yellow;

            if (game.turn_player1 == true)
                game.player1.ChooseDrawDiscard = false;
            if (game.turn_player2 == true)
                game.player2.ChooseDrawDiscard = false;
        }
    }
}
