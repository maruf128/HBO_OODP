public interface IFactory<out T>
{
    T CreateLightTheme();
    T CreateDarkTheme();
}