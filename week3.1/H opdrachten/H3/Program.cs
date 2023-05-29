// class Player
// {
//     public string Name;
//     public int Points;
//     public int Skill;
//     public int Intelligence;
//     public int Knowledge;
//     // constructor
//     public Player(string naam, int vaardigheid, int slimheid, int wetend)
//     {
//         Name = naam;
//         Skill = vaardigheid;
//         Intelligence = slimheid;
//         Knowledge = wetend;
//     }

//     public int Score()
//     {
//         // doe ++ bij score
//         Points++;
//         return Points;
//     }
//     public static Player WhoIsWinning(Player player1, Player player2)
//     {
//         if (player1.Points > player2.Points)
//         {
//             // aka player 1 wint
//             return player1;
//         }
//         else if (player1.Points == player2.Points)
//         {
//             // gelijk spel
//             return null;
//         }
//         else if (player2.Points > player1.Points)
//         {
//             //aka player 2 wint
//             return player2;
//         }
//         // anders idk foutmelding?
//         return null;
//     }
// }

// class Game
// {
//     public Player Player1;
//     public Player Player2;

//     // constructor
//     public Game(Player speler1, Player speler2)
//     {
//         Player1 = speler1;
//         Player2 = speler2;
//     }
//     public Player Round1()
//     {
//         // op basis van volg orde dus eerst skill
//         if (Player1.Skill >= Player2.Skill)
//         {
//             // indien het gelijk is moesten we ook player 1 returnen
//             // dit zorgt ervoor dat de score omhoog gaat (geld ook bij derest)
//             player1.Score();
//             return Player1;
//         }
//         else
//         {
//             player2.Score();
//             return Player2;
//         }
//     }

//     public Player Round2()
//     {
//         // dan inteligence
//         if (Player1.Intelligence >= Player2.Intelligence)
//         {
//             // indien het gelijk is moesten we ook player 1 returnen
//             player1.Score();
//             return Player1;
//         }
//         else
//         {
//             player2.Score();
//             return Player2;
//         }
//     }

//     public Player Round3()
//     {
//         // dan knowledge
//         if (Player1.Knowledge >= Player2.Knowledge)
//         {
//             // indien het gelijk is moesten we ook player 1 returnen
//             player1.Score();
//             return Player1;
//         }
//         else
//         {
//             player2.Score();
//             return Player2;
//         }
//     }
//     public static string Instructions() // hoort string te staan maar ga liever voor de 50% dan 0% want als ik string zet geet het veel errors
//     {
//         return $"Win at least 2 rounds to win!";
//     }

// }