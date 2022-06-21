// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("Hello, World!");


Play play = new Play();

List<Player> playerList = new List<Player>();
playerList.Add(new Player("PlayerAAAA", true));
playerList.Add(new Player("PlayerBBBB", false));


 Player playerInTurn = playerList.Find(player => player.Turn == true);
Console.WriteLine($"It's {playerInTurn.Name}'s turn");
//foreach(Player player in playerList){

//Console.WriteLine($"It's {playerA.Name}'s turn");
    
//Play.changeTurn(player)=> player.
//}
