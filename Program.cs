namespace Dino
{

    internal class Program
    {
        static void Main()
        {
            Console.Title = "Console Dino";
            Console.CursorVisible = false;
            Console.Clear();

            Random rnd = new();
            Obstacle obstacle = new(Console.WindowWidth - 10, Obstacle.cactusSprites[rnd.Next(Obstacle.cactusSprites.Length)]);

            while (Character.position < int.MaxValue)
            {
                if (Console.KeyAvailable) 
                {
                    switch (Console.ReadKey(true).Key) 
                    {
                        case ConsoleKey.Escape:
                            Console.Clear();
                            return;
                        case ConsoleKey.UpArrow:
                            if (!Character.jumpingFrame.HasValue)
                            {
                                Character.jumpingFrame = 0;
                                Character.runningFrame = null;
                                Character.squattingFrame = null;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (!Character.squattingFrame.HasValue)
                            {
                                Character.squattingFrame = 0;
                                Character.jumpingFrame = null;
                                Character.runningFrame = null;

                            }
                            break;
                    }
                }

                string playerFrame = Character.jumpingFrame.HasValue ? Character.jumpingAnimation[Character.jumpingFrame.Value] :
                    Character.squattingFrame.HasValue ? Character.squattingAnimation[Character.squattingFrame.Value] :
                    Character.runningAnimation[Character.runningFrame!.Value];

                Console.Clear();
                if (obstacle.x <= 0) 
                {
                    obstacle.x = Console.WindowWidth - 10;
                    obstacle.sprite = rnd.Next(12) <= 7 ? Obstacle.cactusSprites[rnd.Next(Obstacle.cactusSprites.Length)] : 
                        Obstacle.pteroSprite[0];
                }
                else
                {
                    obstacle.Move();
                }

                Console.SetCursorPosition(1,5);
                Character.Render(playerFrame);
                Console.SetCursorPosition(Console.WindowWidth - 9,0);
                Console.WriteLine($"{Character.position:D9}");


                Character.runningFrame = Character.runningFrame.HasValue ? (Character.runningFrame + 1) % Character.runningAnimation.Length : Character.runningFrame;
                Character.jumpingFrame = Character.jumpingFrame.HasValue ? Character.jumpingFrame + 1 : Character.jumpingFrame;
                Character.squattingFrame = Character.squattingFrame.HasValue ? Character.squattingFrame + 1 : Character.squattingFrame;

                if (Character.jumpingFrame >= Character.jumpingAnimation.Length || Character.squattingFrame >= Character.squattingAnimation.Length)
                {
                    Character.jumpingFrame = null;
                    Character.squattingFrame = null;
                    Character.runningFrame = 1;
                }

                Character.position++;
                Thread.Sleep(200);
            }

        }
    }
}