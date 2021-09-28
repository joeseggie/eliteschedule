List<string> teamA = new List<string>();
List<string> teamB = new List<string>();
List<string> teamC = new List<string>();
List<string> teamD = new List<string>();

List<string> potA = new List<string>{
    "Kembo", "Jurua", "Keyz", "Karim", "Patu", "Mago"
};

List<string> potB = new List<string>{
    "Ismail", "Kala", "Sempa", "Onyango", "Seggie", "Scholes", "Emma", "Swaibu", "Norman",
    "Cheho", "Ayo", "Adama", "Rogers"
};

List<string> potC = new List<string>{
    "Ben", "Fisherman", "Herman", "Fireboy", "Osman", "Feysal", "Musa", "Simon", "Muzaata", "Kyagz"
};

List<string> potD = new List<string>{
    "Prem", "Sadati", "Andrew S", "Kirum", "Jeff", "Samson", "Pius", "Lameck", "Frank", "Wilberforce", "Bright", "Ken O"
};

void PickFromPot(ref List<string> teamA, ref List<string> teamB, ref List<string> teamC, ref List<string> teamD, List<string> pot)
{
    while (pot.Count > 0)
    {
         pot = PopulateTeams(ref teamA, ref teamB, ref teamC, ref teamD, pot);
    }
}

List<string> PopulateTeams(ref List<string> teamA, ref List<string> teamB, ref List<string> teamC, ref List<string> teamD, List<string> pot)
{
    pot = AddAndRemoveOperation(ref teamA, pot);
    pot = AddAndRemoveOperation(ref teamB, pot);
    pot = AddAndRemoveOperation(ref teamC, pot);
    pot = AddAndRemoveOperation(ref teamD, pot);
    return pot;
}

List<string> AddAndRemoveOperation(ref List<string> team, List<string> pot)
{
    var randomPicker = new Random();
    int index = randomPicker.Next(pot.Count);
    if (pot.Count > 0)
    {
        team.Add(pot[index]);
        pot.RemoveAt(index);
    }

    return pot;
}

System.Console.WriteLine("Teams\n=======================\n");

PickFromPot(ref teamA, ref teamB, ref teamC, ref teamD, potA);
PickFromPot(ref teamA, ref teamB, ref teamC, ref teamD, potB);
PickFromPot(ref teamA, ref teamB, ref teamC, ref teamD, potC);
PickFromPot(ref teamA, ref teamB, ref teamC, ref teamD, potD);

System.Console.WriteLine($"Team 1:");
teamA.ForEach(Console.WriteLine);

System.Console.WriteLine($"\nTeam 2:");
teamB.ForEach(Console.WriteLine);

System.Console.WriteLine($"\nTeam 3:");
teamC.ForEach(Console.WriteLine);

System.Console.WriteLine($"\nTeam 4:");
teamD.ForEach(Console.WriteLine);
