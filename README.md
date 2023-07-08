### Guess The Word

Проектна задача по предметот Визуелно Програмирање изработена од Кире Атанасков, бр. на индекс: 213132

#### Опис на апликацијата
Апликацијата е малку изменета варијанта на познатата игра Бесилка. Се со цел играта да биде поинтересна,
имплементирани се различни карактериски кој се детално опишани подолу во инструкциите за играње на играта.

#### 1. Инструкции за играње на играта
![MainMenu.png](Screenshots%2FMainMenu.png)  
Слика 1. Почетно мени на апликацијата  
  
![Game.png](Screenshots%2FGame.png)  
Слика 2. Изгледа на главната форма
  
![Register.png](Screenshots%2FRegister.png)  
Слика 3. Форма за регистрирање на играч

Со кликнување на копчето „Start“ се отвара нов прозорец (слика 2) и започнува играта. Кога ќе се отвори новиот прозорец, се пушта звучен ефект на часовник. 
Играчот има време од 1 минута за да го погоди скриениот збор. При стартување на играта, некои букви од зборот може да биде откриени, се со цел играчот побрзо да го погоди зборот.
Играчот има право и 3 пати да побара помош (со hover на иконата со сијаличка, се покажува објаснување за зборот што треба да го погоди).
Играчот во полето за внесување буква, мора да внесе само една буква, ако внесе повеќе букви или не внесе ништо, ќе му биде сигнализирано соодветно при кликнување на копчето „ENTER“.
Доколку корисникот внесе погрешна буква или внесе буква која што е веќе погодена (како буквата „С“ на слика 2), тоа ќе биде избројано како грешка при погодување. Кога играчот ќе го погоди зборот, ќе се појави форма која ќе го праша дали сака да во пријави неговиот резултат. Доколку одгови со „Да“, ќе биде пренасочен на друга форма каде мора да го внесе своето корисничко име (слика 3).


![Leaderboard.png](Screenshots%2FLeaderboard.png)  
Слика 4. Leaderboard  
  
Во играта е имплементирано и „Leaderboard“ каде што се води статистика за играчите кој веќе ја завршиле играта.
Се прикажува нивното корисничко име и резултат. Резултатот се пресметува по следната формула:  
  
#### Score = (TimeLeft * 1.5) + (HintsLeft * 3) - NumberOfMistakes  
  
Резултати се сортирани во опаѓачки редослед според резултатот, но со клик на „Score“ во првиот ред од табелата, резултатите ќе се сортираат во обратен редослед.  
  
![Instructions.png](Screenshots%2FInstructions.png)  
Слика 5. Инструкции

При притискање на копчето „HOW TO PLAY“ од слика 1, се отвара прозорецот од слика 5 каде што се напишани инструкции како се игра играта.  

#### 2. Претставување на проблемот
Во играта има повеќе класи што ни ја овозможуваат функционалноста на играта.  
Во класата ```Player``` само се чуваат податоци за секој играч како што се корисничко име и резултат. Има само еден конструктор, нема други методи.  
Со класата ```HiddenWord``` го претставуваме зборот кој што треба играчот да го погоди.  
```
public class HiddenWord
{
    // random objektot sluzi za prikazuvanje na random bukvi pri startuvanje na igrata
    Random random = new Random();
    public string Word { get; set; }
    // HashSet kade se chuvaat bukvite koj igracot treba da gi pogodi
    public HashSet<char> AllLetters { get; set; }
    // HashSet kade se chuvaat bukvite koj korisnikot vekje se otkrieni
    public HashSet<char> GivenLetters { get; set; }
    
    public HiddenWord(string word)
    {
        Word = word.ToUpper();
        AllLetters = new HashSet<char>();
        GivenLetters = new HashSet<char>();
        foreach (char c in Word)
        {
            if (Random.Next(5) == 3)
            {
                GivenLetters.Add(c);
            }
            if (!GivenLetters.Contains(c))
            {
                AllLetters.Add(c);
            }
        }

        foreach (char c in GivenLetters.ToList())
        {
            foreach (char c1 in AllLetters.ToList())
            {
                if (c == c1)
                {
                    AllLetters.Remove(c1);
                }
            }
        }
    }

    // funkcija so koja sto se dobiva skrieniot zbor koj igracot treba da go pogodi soodvetno za sekoja bukva od zborot 
    // dodava dolna crta ili ja prikazuva bukvata vo zavisnost od toa vo koe mnozestvo e bukvata
    public string GetHiddenWord()
    {
        Random random = new Random();
        StringBuilder sb = new StringBuilder();

        foreach (char c in Word)
        {
            if (GivenLetters.Contains(c))
            {
                sb.Append(c);
            }
            else
            {
                sb.Append("_");
            }
            sb.Append(' ');
        }
        return sb.ToString();
    }

    // funkcija koja sto proveruva dali vnesenata bukva se sodrzi vo HashSetot od bukvi koj igracot treba da gi pogodi,
    // ako se sodrzi, ja brise od toj set i ja dodava vo setot na pogodeni bukvi
    public string GuessLetter(char Letter)
    {
        Letter = Char.ToUpper(Letter);

        if (AllLetters.Contains(Letter) && !GivenLetters.Contains(Letter))
        {
            AllLetters.Remove(Letter);
            GivenLetters.Add(Letter);
        }
    }
}
```  
Имаме класи и за секоја од формите соодветно каде што се имплементирани функционалностите на играта.  
  

Во класата ```GameForm``` во листа од стрингови се чуваат зборовите и играчот добива еден рандом збор од листата кој треба да го погоди.  
```readonly List<string> words = new List<string>() { "ELEPHANT", "BONSAI", "EUPHORIA", "PARADOX", "ACROBAT", "CHAIR", "MOON", "RAIN" };```  
За чување на објаснувањата за секој од зборовите, се користи ```Речник(Мапа)``` каде секој еден од зборовите во листата преставува клуч, и за секој од нив има листа од стрингови каде што се чуваат објаснувањата.  
  
Податоците за играчите (корисничките имиња и резултатите) се запишани во фајлот ```Players.csv``` кој што се наоѓа во ```\GuessTheWord\bin\Debug```. Кога играчот сака да ја провери табелата со резултати,  
апликацијата податоците за играчите ги чита од тој фајл и соодветно кога се регистрира нов играч, податоците ги запишува во истиот фајл. Players.csv фајлот служи како еден вид на база на податоци.