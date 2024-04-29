namespace Dino
{
    internal class Obstacle
    {
        private int y = 5;
        public int x;
        public string sprite;


        static public readonly string[] cactusSprites =
        {
            #region Sprites
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"  L[]/   "+'\n'+
            @"   []    "+'\n',

            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @" L[] ++  "+'\n'+
            @"  []![]  "+'\n',

            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"   []    "+'\n'+
            @"  L[]/   "+'\n'+
            @"   []    "+'\n',

            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @" .o[]+L. "+'\n',
            #endregion
        };

        static public readonly string[] pteroSprite =
        {    
            #region Sprite
            @"         "+'\n'+
            @"         "+'\n'+
            @"  ,,___  "+'\n'+
            @" <O-\_\--"+'\n'+
            @"         "+'\n'+
            @"         "+'\n'+
            @"         "
            #endregion
        };

        public Obstacle(int x, string sprite) 
        {
            this.x = x;
            this.sprite = sprite;
        }


        public void Move()
        {
            if (this.x == Console.WindowWidth - 10)
            {
                Console.SetCursorPosition(this.x, this.y);
                this.Render(this.sprite);
                this.x -= 3;
            }
            else 
            {
                Console.SetCursorPosition(this.x, this.y);
                this.Render(this.sprite);
                this.x -= 3;
            }
        }

        private void Render(string sprite) 
        {
            int x = this.x;
            int y = this.y;

            foreach (char c in sprite)
            {
                if (c == '\n')
                {
                    Console.SetCursorPosition(x, ++y);
                }
                else
                {
                    Console.Write(c);
                }
            }
        }

    }
}
