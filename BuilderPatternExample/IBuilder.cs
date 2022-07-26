namespace BuilderPatternExample;

public interface IBuilder<out T>
{
    T Build();
}