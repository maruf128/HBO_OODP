// class Game
// {
//     public new Player Player1;
//     public new Player Player2;

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