public class Animation
{
    public static void ShowAnimation()
    {
        
        string[] firstAnimation = 
        [
        "               ''                ",
        "              ' * '              ",
        "               ' '                ",
        "      ''                 ''        ",
        "     ' * '              ' * '        ",
        "      ''                 ''        ",
        "               ''                ",
        "              ' * '                ",
        "               ' '                ",
        ];
        string[] secondAnimation = 
        [
        "      ''                 ''        ",
        "     ' * '              ' * '        ",
        "      ''                 ''        ",
        "               ''                ",
        "              ' * '              ",
        "               ' '                ",
        "        ''             ''        ",
        "       ' * '          ' * '        ",
        "        ''             ''        "
        ];
        int seconds = 4;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Clear();
            string[] currentAnimation = (index % 2 == 0) ? firstAnimation : secondAnimation;
            foreach(var line in currentAnimation)
            {
                Console.WriteLine(line);
            }
            index ++;
            Thread.Sleep(500);
        }
        Console.Clear();
    }
}