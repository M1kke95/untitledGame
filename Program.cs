// See https://aka.ms/new-console-template for more information

using untitledGame.Player;

Player player = new Player();
while (true)
{
    Console.WriteLine("Hva vil du gjøre? (move, attack, idle, mine)");
    string input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "move":
            player.updateState(untitledGame.Enums.CharacterState.Moving);
            break;

        case "attack":
            player.updateState(untitledGame.Enums.CharacterState.Attacking);
            break;

        case "idle":
            player.updateState(untitledGame.Enums.CharacterState.Idle);
            break;

        case "mine":
            player.updateState(untitledGame.Enums.CharacterState.Mining);
            break;

    }
    player.update();
}
