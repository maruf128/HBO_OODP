public class Button
{
    // stell hier de variables vast
    public bool IsPressed { get; set; } = false;

    // en geef times pressed standaard0
    public int TimesPressed { get; set; } = 0;

    // aka de constructor is niet verplicht sinds de data geen parameters hebben (zou dit weg kunnen laten maar voor me osd laat ik het)
    public Button() { }

    // indie press word aangreoepen
    public void Press()
    {
        // indien wnr het flase is tell hem vooriedere keer dat het word opgeroepen 
        IsPressed = !IsPressed;
        TimesPressed++;
    }

    public string Info()
    {
        // again niet opgelet op hoe codegrade het wilt (HOOFDLETTER?????)
        return $"Button is {(IsPressed ? "pressed" : "not pressed")}.{Environment.NewLine}pressed {TimesPressed} times.";
        // met new line zorg je ervoor dat codegrade miss niet vervelend doet
    }
}
