
using Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RazboiCardGame
{
    public partial class Game : Form
    {
        private int currentPlayer = 2;
        private Client playerClient;
        private Listener playerListener;
        Dictionary<string, byte[]> gameCards = new Dictionary<string, byte[]>();
        private List<string> Cards = new List<string>();
        private List<string> currentPlayerCards = new List<string>();
        private List<int> takenCards = new List<int>();
        private int player1Card = 0;
        private int player2Card = 0;

        public Game()
        {
            InitializeComponent();
            DownloadPhotos();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (currentPlayer == 1) Player1();
            else if (currentPlayer == 2) Player2();
            InitializeCardList();
        }

        private void Player1() //Initializes the connection if the current player is player 1
        {
            playerListener = new Listener(this);
            new Thread(new ThreadStart(playerListener.StartListener)).Start();
            new Thread(new ThreadStart(playerListener.ListenForMessages)).Start();
            playerClient = new Client("272-738-082");
        }

        private void Player2() //Initializes the connection if the current player is player 2
        {
            playerListener = new Listener(this);
            new Thread(new ThreadStart(playerListener.StartListener)).Start();
            new Thread(new ThreadStart(playerListener.ListenForMessages)).Start();
            playerClient = new Client("272-738-043");
            
        }

        public void InitializeCardList()
        {
            Random rand = new Random();

            Cards.Add("2-inima-neagra");
            Cards.Add("2-inima-rosie");
            Cards.Add("2-trefla");
            Cards.Add("2-romb");
            Cards.Add("3-inima-neagra");
            Cards.Add("3-inima-rosie");
            Cards.Add("3-trefla");
            Cards.Add("3-romb");
            Cards.Add("4-inima-neagra");
            Cards.Add("4-inima-rosie");
            Cards.Add("4-trefla");
            Cards.Add("4-romb");
            Cards.Add("5-inima-neagra");
            Cards.Add("5-inima-rosie");
            Cards.Add("5-trefla");
            Cards.Add("5-romb");
            Cards.Add("6-inima-neagra");
            Cards.Add("6-inima-rosie");
            Cards.Add("6-trefla");
            Cards.Add("6-romb");
            Cards.Add("7-inima-neagra");
            Cards.Add("7-inima-rosie");
            Cards.Add("7-trefla");
            Cards.Add("7-romb");
            Cards.Add("8-inima-neagra");
            Cards.Add("8-inima-rosie");
            Cards.Add("8-trefla");
            Cards.Add("8-romb");
            Cards.Add("9-inima-neagra");
            Cards.Add("9-inima-rosie");
            Cards.Add("9-trefla");
            Cards.Add("9-romb");
            Cards.Add("10-inima-neagra");
            Cards.Add("10-inima-rosie");
            Cards.Add("10-trefla");
            Cards.Add("10-romb");
            Cards.Add("A-inima-neagra");
            Cards.Add("A-inima-rosie");
            Cards.Add("A-trefla");
            Cards.Add("A-romb");
            Cards.Add("J-inima-neagra");
            Cards.Add("J-inima-rosie");
            Cards.Add("J-trefla");
            Cards.Add("J-romb");
            Cards.Add("Q-inima-neagra");
            Cards.Add("Q-inima-rosie");
            Cards.Add("Q-trefla");
            Cards.Add("Q-romb");
            Cards.Add("K-inima-neagra");
            Cards.Add("K-inima-rosie");
            Cards.Add("K-trefla");
            Cards.Add("K-romb");

            for (int i = 0; i < Cards.Count; i++)
            {
                int randomIndex = rand.Next(Cards.Count);
                string temp = Cards[i];
                Cards[i] = Cards[randomIndex];
                Cards[randomIndex] = temp;
            }

            for (int i = 0; i < Cards.Count; i++)
            {
                if (i % 2 == 0 && currentPlayer == 1)
                {
                    currentPlayerCards.Add(Cards[i]);
                }
                else
                {
                    playerClient.sendPlayerDeck(Cards[i], 2);
                }
            }

        }

        public void DownloadPhotos()
        {
            WebClient webClient = new WebClient();
            gameCards.Add("spate-carte", webClient.DownloadData("https://i.imgur.com/NmRuATQ.png"));
            gameCards.Add("trefla", webClient.DownloadData("https://i.imgur.com/vfLTHEM.png"));
            gameCards.Add("romb", webClient.DownloadData("https://i.imgur.com/vu1fnNQ.png"));
            gameCards.Add("inima-rosie", webClient.DownloadData("https://i.imgur.com/iTTMz5k.png"));
            gameCards.Add("inima-neagra", webClient.DownloadData("https://i.imgur.com/0nxM3lf.png"));
            gameCards.Add("J-inima-neagra", webClient.DownloadData("https://i.imgur.com/1XUzID9.png"));
            gameCards.Add("J-romb", webClient.DownloadData("https://i.imgur.com/6DDELar.png"));
            gameCards.Add("J-inima-rosie", webClient.DownloadData("https://i.imgur.com/a2huolv.png"));
            gameCards.Add("J-trefla", webClient.DownloadData("https://i.imgur.com/IoGsvHJ.png"));
            gameCards.Add("K-inima-neagra", webClient.DownloadData("https://i.imgur.com/Ok2e0fJ.png"));
            gameCards.Add("K-romb", webClient.DownloadData("https://i.imgur.com/YpdnFdS.png"));
            gameCards.Add("K-inima-rosie", webClient.DownloadData("https://i.imgur.com/KB3VQIa.png"));
            gameCards.Add("K-trefla", webClient.DownloadData("https://i.imgur.com/Qc8RR30.png"));
            gameCards.Add("Q-inima-neagra", webClient.DownloadData("https://i.imgur.com/XxWyDY5.png"));
            gameCards.Add("Q-romb", webClient.DownloadData("https://i.imgur.com/Dr06dVb.png"));
            gameCards.Add("Q-inima-rosie", webClient.DownloadData("https://i.imgur.com/20Dk1rG.png"));
            gameCards.Add("Q-trefla", webClient.DownloadData("https://i.imgur.com/7EUp8tc.png"));


        } //Downloads the photos 

        public void DrawCardPlayer1(string card)
        {
            System.IO.MemoryStream ms;

            switch (card)
            {
                case "2-inima-neagra": ms = new System.IO.MemoryStream(gameCards["inima-neagra"]); break;
                case "J-inima-neagra": ms = new System.IO.MemoryStream(gameCards["J-inima-neagra"]); break;
                case "10-trefla": ms = new System.IO.MemoryStream(gameCards["trefla"]); break;
                case "A-trefla": ms = new System.IO.MemoryStream(gameCards["trefla"]); break;
                default: ms = new System.IO.MemoryStream(gameCards["spate-carte"]); break;
            }

            char firstLetter = card.ElementAt(0);

            switch (firstLetter)
            {
                case '1': Player1_UpperLabel.Text = "10"; Player1_BottomLabel.Text = "10"; break;
                case '2': Player1_UpperLabel.Text = "2"; Player1_BottomLabel.Text = "2"; break;
                case '3': Player1_UpperLabel.Text = "3"; Player1_BottomLabel.Text = "3"; break;
                case '4': Player1_UpperLabel.Text = "4"; Player1_BottomLabel.Text = "4"; break;
                case '5': Player1_UpperLabel.Text = "5"; Player1_BottomLabel.Text = "5"; break;
                case '6': Player1_UpperLabel.Text = "6"; Player1_BottomLabel.Text = "6"; break;
                case '7': Player1_UpperLabel.Text = "7"; Player1_BottomLabel.Text = "7"; break;
                case '8': Player1_UpperLabel.Text = "8"; Player1_BottomLabel.Text = "8"; break;
                case '9': Player1_UpperLabel.Text = "9"; Player1_BottomLabel.Text = "9"; break;
                case 'A': Player1_UpperLabel.Text = "A"; Player1_BottomLabel.Text = "A"; break;
                default: Player1_UpperLabel.Text = ""; Player1_BottomLabel.Text = ""; break;
            }

            Player1_pictureBox.Image = Image.FromStream(ms);

        } //Draws the card in the player1 imageView

        public void DrawCardPlayer2(string card)
        {
            System.IO.MemoryStream ms;

            switch (card)
            {
                case "J-inima-neagra": ms = new System.IO.MemoryStream(gameCards["J-inima-neagra"]); break;
                case "A-trefla": ms = new System.IO.MemoryStream(gameCards["trefla"]); break;
                case "10-trefla": ms = new System.IO.MemoryStream(gameCards["trefla"]); break;
                default: ms = new System.IO.MemoryStream(gameCards["spate-carte"]); break;
            }

            char firstLetter = card.ElementAt(0);

            switch (firstLetter)
            {
                case '1': Player2_UpperLabel.Text = "10"; Player2_BottomLabel.Text = "10"; break;
                case '2': Player2_UpperLabel.Text = "2"; Player2_BottomLabel.Text = "2"; break;
                case '3': Player2_UpperLabel.Text = "3"; Player2_BottomLabel.Text = "3"; break;
                case '4': Player2_UpperLabel.Text = "4"; Player2_BottomLabel.Text = "4"; break;
                case '5': Player2_UpperLabel.Text = "5"; Player2_BottomLabel.Text = "5"; break;
                case '6': Player2_UpperLabel.Text = "6"; Player2_BottomLabel.Text = "6"; break;
                case '7': Player2_UpperLabel.Text = "7"; Player2_BottomLabel.Text = "7"; break;
                case '8': Player2_UpperLabel.Text = "8"; Player2_BottomLabel.Text = "8"; break;
                case '9': Player2_UpperLabel.Text = "9"; Player2_BottomLabel.Text = "9"; break;
                case 'A': Player2_UpperLabel.Text = "A"; Player2_BottomLabel.Text = "A"; break;
                default: Player2_UpperLabel.Text = ""; Player2_BottomLabel.Text = ""; break;
            }

            Player2_pictureBox.Image = Image.FromStream(ms);
        } //Draws the card in the player2 imageView

        public void computeMessage(string message)
        {
            if (message.ElementAt(0) == '1')
            {
                string modifiedMessage = message.Substring(1);
                Player1_UpperLabel.Invoke(new Action(() => DrawCardPlayer1(modifiedMessage)));
            }
            else if (message.ElementAt(0) == '2')
            {
                string modifiedMessage = message.Substring(1);
                Player2_UpperLabel.Invoke(new Action(() => DrawCardPlayer2(modifiedMessage)));
                switch (modifiedMessage.ElementAt(0))
                {
                    case '1': player2Card = 10; break;
                    case '2': player2Card = 2; break;
                    case '3': player2Card = 3; break;
                    case '4': player2Card = 4; break;
                    case '5': player2Card = 5; break;
                    case '6': player2Card = 6; break;
                    case '7': player2Card = 7; break;
                    case '8': player2Card = 8; break;
                    case '9': player2Card = 9; break;
                    case 'A': player2Card = 11; break;
                    case 'J': player2Card = 12; break;
                    case 'Q': player2Card = 13; break;
                    case 'K': player2Card = 14; break;
                    default: break;
                }
            }
            else if (message.ElementAt(0) == 'd')
            { 
                string modifiedMessage = message.Substring(1);
                currentPlayerCards.Add(modifiedMessage);
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            playerClient.closeClient();
            playerListener.Close();
        }

        private void DrawCard_button_Click(object sender, EventArgs e)
        {
            //Last card of the list 
            var lastCard = currentPlayerCards.Last();
            currentPlayerCards.Remove(lastCard);
            playerClient.sendCurrentCard(lastCard, currentPlayer);
            if (currentPlayer == 1)
            {
                switch (lastCard.ElementAt(0))
                {
                    case '1': player1Card = 10; break;
                    case '2': player1Card = 2; break;
                    case '3': player1Card = 3; break;
                    case '4': player1Card = 4; break;
                    case '5': player1Card = 5; break;
                    case '6': player1Card = 6; break;
                    case '7': player1Card = 7; break;
                    case '8': player1Card = 8; break;
                    case '9': player1Card = 9; break;
                    case 'A': player1Card = 11; break;
                    case 'J': player1Card = 12; break;
                    case 'Q': player1Card = 13; break;
                    case 'K': player1Card = 14; break;
                    default: break;
                }
                DrawCardPlayer1(lastCard);
            }
            else if (currentPlayer == 2) DrawCardPlayer2(lastCard);
           
        }
    }
}
