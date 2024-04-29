namespace Dino
{
    internal class Character
    {
        public static int position = 0;
        public static int? runningFrame = 0;
        public static int? jumpingFrame = null;
        public static int? squattingFrame = null;

        public static string[] runningAnimation =
        {
            #region Frames
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L -    ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  - L    ",
            #endregion
        };
        public static string[] jumpingAnimation =
        {
            #region Frames
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         ",

            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         " + '\n' +
            @"         ",


            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         ",

            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         ",

            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         " + '\n' +
            @"         ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n' +
            @"         ",

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"      __ " + '\n' +
            @".____/'_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    ",
            #endregion 
        };
        public static string[] squattingAnimation =
        { 
            #region Frame
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  L L    " + '\n',

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  L -    " + '\n',

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  L L    " + '\n',

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  - L    " + '\n',
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  L L    " + '\n',

            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @"         " + '\n' +
            @".____—,—," + '\n' +
            @" \___,——'" + '\n' +
            @"  L -    " + '\n'
            #endregion
        };
        public static string deathSprite =
        #region Sprite
            @"      __ " + '\n' +
            @".____/o_|" + '\n' +
            @" \___,/  " + '\n' +
            @"  L L    " + '\n';
        #endregion

        public static void Render(string sprite)
        {

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            foreach (char c in sprite)
            {
                if (c == '\n')
                {
                    Console.SetCursorPosition(x, ++y);
                }
                else if (c == ' ')
                {
                    Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
