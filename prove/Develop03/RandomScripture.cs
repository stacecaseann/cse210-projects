public class RandomScripture
{
    private List<Scripture> _scriptures = [];

    public RandomScripture()
    {
        _scriptures = CreateScriptureList();
    }

    public Scripture GetRandomScripture()
    {
        Random random = new();
        int randomNumber = random.Next(0, _scriptures.Count);
        return _scriptures[randomNumber];
    }
    private List<Scripture> CreateScriptureList()
    {
        List<Scripture> scriptures  =
        [
            new Scripture(
                new Reference("1 Nephi",3,7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            ),
            new Scripture(
                new Reference("2 Nephi",2,28,29),
                "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God."
            ),
            new Scripture(
                new Reference("Jacob",2,18,19),
                "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."
            ),
            new Scripture(
                new Reference("Mosiah",2,17),
                "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."
            ),
            new Scripture(
                new Reference("Mosiah",4,30),
                "But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not."
            ),
            new Scripture(
                new Reference("Alma",32,21),
                "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."
            ),
            new Scripture(
                new Reference("Alma",41,10),
                "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."
            ),
            new Scripture(
                new Reference("Helaman",5,12),
                "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."
            ),
            new Scripture(
                new Reference("3 Nephi",11,29),
                "For verily, verily I say unto you, he that hath the spirit of contention is not of me, but is of the devil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another."
            ),
            new Scripture(
                new Reference("3 Nephi",27,27),
                "And know ye that ye shall be judges of this people, according to the judgment which I shall give unto you, which shall be just. Therefore, what manner of men ought ye to be? Verily I say unto you, even as I am."
            ),
            new Scripture(
                new Reference("Ether",12,6),
                "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."
            ),
            new Scripture(
                new Reference("Ether",12,27),
                "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
            ),
            new Scripture(
                new Reference("Moroni",7,45),
                "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things."
            ),
            new Scripture(
                new Reference("Moroni",10,4,5),
                "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."
            )
        ];
        return scriptures;
    }
}