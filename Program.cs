// start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations (stadium);
DisplayStadiumDetails(stadium,game);
// end main

static string GetEnjoymentLevel(){
 System.Console.WriteLine("What is your Preferred Enjoyment Level: \nBoring \nAverage \nFun \nEpic");
    return Console.ReadLine();
}

static string GetStadiumRecommendations(string enjoymentLevel){
    if (enjoymentLevel == "Boring"){
        return  "Neyland Stadium";
    }
    else if (enjoymentLevel == "Average"){
        return  "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "Fun"){
        return "Tiger Stadium";
    }
    else if (enjoymentLevel == "Epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else {
        return "Invalid Entry";
    }
}

static string GetGameRecommendations(string stadium){
    switch (stadium){
        case "Neyland Stadium":
            return "Kent State";
        case "Jordan-Hare Stadium":
            return "Kentucky";
        case "Tiger Stadium":
            return "Alabama";
        case "Saban Field at Bryant-Denny Stadium":
            return "Auburn";
        default:
            return "Unknown Game";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    if (stadium == "Invalid Entry"){
        System.Console.WriteLine("Invalid enjoyment level entry. Please try again.");
    }   else {
        System.Console.WriteLine($"We suggest you visit {stadium} and the best game to attend would be the {game} game. \nThanks!");
    }
    
}