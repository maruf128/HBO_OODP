static class GameTools
{
    public static bool ReturnCount = true;

    public static string CoinFlip(int flips)
    {
        string result = ""; // zodat er geen error is dat coinflip niks
        if (ReturnCount == false)
        {
            for (int i = 1; i <= flips; i++)
            {
                // moet in de for loop anders is het niet random
                Random r = new Random();
                // randomise heads en tails
                string[] words = { "Heads", "Tails" };
                string random_flip = words[r.Next(0, words.Length)]; // zet het in een variable
                result += $"{random_flip}\n"; // voeg het toe aan de string
            }
        }
        else if (ReturnCount == true)
        {
            int tel_heads = 0;
            int tel_tails = 0;
            for (int i = 1; i <= flips; i++)
            {
                Random r = new Random();
                // randomise heads en tails
                string[] words = { "Heads", "Tails" };
                string random_flip = words[r.Next(0, words.Length)]; // zet het in een variable
                // tell de aantal heads en tel de aantal tails
                if (random_flip == "Heads")
                {
                    tel_heads++;
                }
                else if (random_flip == "Tails")
                {
                    tel_tails++;
                }
            }
            // nu heb je alles getelt print het dan uit zoals codegrade wilt
            result += $"Heads: {tel_heads}\nTails: {tel_tails}\n"; // add the counts to the string
        }
        return result; // return the full string with all the results
    }

    public static string DiceRoll(int sides, int rolls)
    {
        // aka het moet groter zijn dan 3 of 3 zijn
        if (sides >= 3)
        {
            if (ReturnCount == false)
            {
                string result = "";
                for (int i = 1; i <= rolls; i++)
                {
                    Random r = new Random();
                    int random_dice = r.Next(0, sides + 1);
                    result += $"Roll {i}: {random_dice}\n";
                    // aka voor iedere roll doe dit
                }
                return result;
            }
            else if (ReturnCount == true)
            {
                string result = "";
                List<int> mogelijkheden = new List<int>();
                for (int i = 1; i <= sides; i++)
                {
                    // nu voeg je elke side dat er is aan de list
                    mogelijkheden.Add(i);
                }

                // maak de lijst met alle gerolde getallen
                List<int> gerolled = new List<int>();
                for (int i = 1; i <= rolls; i++)
                {
                    Random r = new Random();
                    int random_dice = r.Next(1, sides + 1);
                    gerolled.Add(random_dice);
                    // aka voor iedere roll doe dit
                }

                // nu join je de 2 lijsten en vergelijk je hoe vaak het voorkomt
                var g = mogelijkheden.GroupJoin(gerolled,
                                                s => s,
                                                r => r,
                                                (s, rs) => new { Side = s, Count = rs.Count() });

                // en hier voeg je voor iedere getal toe hoevaak het voorkomt
                foreach (var grp in g)
                {
                    result += $"{grp.Side} was rolled {grp.Count} times\n";
                }
                return result;
            }
        }
        else
        {
            // indien het kleiner is dan 3
            return "Invalid number of die sides";
        }
        return ""; // return dit indien er iets fout is gegeaan
    }

}